Imports System.Runtime.InteropServices
Imports CodeLibrary.HotkeyClass

Public Class FrmMain

    ''Needed for round corners''
    Overloads Property FormBorderStyle As Windows.Forms.FormBorderStyle

    ''Form loading events''
    Private Sub FrmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ''Gets the process id''
        myProcess = System.Diagnostics.Process.GetCurrentProcess()
     
        ''Hides form on load''
        Me.Opacity = 0

        ''Sets lbcodes background color from module variable''
        LbCodes.BackColor = BackColor

        ''Call to register HotKeys''
        RegisterHotkeys()

        ''Gives the form nice rounded edges''
        RoundEdges()

        ''Placing main form in the lower right hand corner of the screen''
        BottomRight()

        ''Call to get list of language folders''
        GetLanguages()

        ''Call to open viewer form but will stay invisible because of opacity settings''
        FrmViewer.Show()

    End Sub

    ''Fill Languages array from directory list for hotkeys''
    Public Sub GetLanguages()

        Dim Folder As New IO.DirectoryInfo(Application.StartupPath & "\samples\")
        Languages = Folder.GetDirectories()

    End Sub

    ''Populate lbcodes from hotkey selected language folder''
    Public Sub PopulateListBox(ByVal ListVar As String)

        Dim Folder As New IO.DirectoryInfo(Application.StartupPath & "\samples\" & ListVar)
        Dim SubFolders = Folder.GetDirectories()
        Me.LbCodes.DataSource = SubFolders
        LbCodes.Refresh()

    End Sub

    ''Handles setting code and refreshing data when enter or double click on lbcodes''
    Public Sub SelectedCode()

        Code = LbCodes.SelectedItem.ToString()
        FrmViewer.GetData()
        FadeIn(FrmViewer)

    End Sub

    ''When double click on selected item run the above sub which sets the selected item and refreshes the page''
    Private Sub LbCodes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LbCodes.DoubleClick

        SelectedCode()

    End Sub

    ''Catching the Enter key and making it preform just as the doubleClick funtion above''
    Private Sub LbCodes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LbCodes.KeyDown

        If e.KeyCode = Keys.Enter Then
            SelectedCode()
        End If

    End Sub

#Region "Form Graphics"

    ''Send Form to bottom right''
    Public Sub BottomRight()

        Dim X As Int32
        Dim Y As Int32
        X = Screen.PrimaryScreen.WorkingArea.Width
        Y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height
        Do Until X = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
            X = X - 1
            Me.Location = New Point(X, Y)
        Loop

    End Sub

    ''Rounds the forms edges''
    Public Sub RoundEdges()

        Dim p As New Drawing2D.GraphicsPath()
        p.StartFigure()
        p.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        p.AddLine(40, 0, Me.Width - 40, 0)
        p.AddArc(New Rectangle(Me.Width - 40, 0, 40, 40), -90, 90)
        p.AddLine(Me.Width, 40, Me.Width, Me.Height - 40)
        p.AddArc(New Rectangle(Me.Width - 40, Me.Height - 40, 40, 40), 0, 90)
        p.AddLine(Me.Width - 40, Me.Height, 40, Me.Height)
        p.AddArc(New Rectangle(0, Me.Height - 40, 40, 40), 90, 90)
        p.CloseFigure()
        Me.Region = New Region(p)

    End Sub

    ''Fade in function must be passed FrmID which is the form you want to fade''
    Public Sub FadeIn(ByVal FrmID)

        ''Fade in if not visible. Max opacity set to 0.8''
        Try
            Dim A = FrmID.Opacity
            If FrmID.Opacity < 0.8 Then
                Do Until A >= 0.8
                    A = A + 0.01   ''Adjust step here''
                    FrmID.Opacity = A
                    System.Threading.Thread.Sleep(1)    ''Adjust pause here''
                Loop

                If FrmID.name = "FrmMain" Then MainVisible = True
                If FrmID.name = "FrmViewer" Then ViewerVisible = True

            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    ''Fade out function must be passed FrmID which is the form you want to fade''
    Public Sub FadeOut(ByVal FrmID)

        ''Fade out if visible. Max opacity set to 0.8''
        Try
            Dim A = FrmID.Opacity
            If FrmID.Opacity >= 0.8 Then
                Do Until A <= 0
                    A = A - 0.01   ''Adjust step here''
                    FrmID.Opacity = A
                    System.Threading.Thread.Sleep(1)    ''Adjust pause here''
                Loop

                If FrmID.name = "FrmMain" Then MainVisible = False
                If FrmID.name = "FrmViewer" Then ViewerVisible = False

            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

#End Region

#Region "Drag and Drop"

    ''Drag and drop when mousedown on lbcodes''
    Private Sub LbCodes_MouseDown(sender As Object, e As MouseEventArgs) Handles LbCodes.MouseDown

        drag = True 'Sets the variable drag to true.
        mousex = Windows.Forms.Cursor.Position.X - Me.Left 'Sets variable mousex
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top 'Sets variable mousey
        Dim p As New Drawing2D.GraphicsPath()
        p.StartFigure()
        p.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        p.AddLine(40, 0, Me.Width - 40, 0)
        p.AddArc(New Rectangle(Me.Width - 40, 0, 40, 40), -90, 90)
        p.AddLine(Me.Width, 40, Me.Width, Me.Height - 40)
        p.AddArc(New Rectangle(Me.Width - 40, Me.Height - 40, 40, 40), 0, 90)
        p.AddLine(Me.Width - 40, Me.Height, 40, Me.Height)
        p.AddArc(New Rectangle(0, Me.Height - 40, 40, 40), 90, 90)
        p.CloseFigure()
        Me.Region = New Region(p)

    End Sub

    ''Drag and drop when mousemove on lbcodes''
    Private Sub LbCodes_MouseMove(sender As Object, e As MouseEventArgs) Handles LbCodes.MouseMove

        'If drag is set to true then move the form accordingly.
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
            Dim p As New Drawing2D.GraphicsPath()
            p.StartFigure()
            p.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
            p.AddLine(40, 0, Me.Width - 40, 0)
            p.AddArc(New Rectangle(Me.Width - 40, 0, 40, 40), -90, 90)
            p.AddLine(Me.Width, 40, Me.Width, Me.Height - 40)
            p.AddArc(New Rectangle(Me.Width - 40, Me.Height - 40, 40, 40), 0, 90)
            p.AddLine(Me.Width - 40, Me.Height, 40, Me.Height)
            p.AddArc(New Rectangle(0, Me.Height - 40, 40, 40), 90, 90)
            p.CloseFigure()
            Me.Region = New Region(p)
        End If

    End Sub

    ''Drag and drop when mouseup on lbcodes''
    Private Sub LbCodes_MouseUp(sender As Object, e As MouseEventArgs) Handles LbCodes.MouseUp

        'Sets drag to false, so the form does not move according to the code in MouseMove
        drag = False
        Dim p As New Drawing2D.GraphicsPath()
        p.StartFigure()
        p.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        p.AddLine(40, 0, Me.Width - 40, 0)
        p.AddArc(New Rectangle(Me.Width - 40, 0, 40, 40), -90, 90)
        p.AddLine(Me.Width, 40, Me.Width, Me.Height - 40)
        p.AddArc(New Rectangle(Me.Width - 40, Me.Height - 40, 40, 40), 0, 90)
        p.AddLine(Me.Width - 40, Me.Height, 40, Me.Height)
        p.AddArc(New Rectangle(0, Me.Height - 40, 40, 40), 90, 90)
        p.CloseFigure()
        Me.Region = New Region(p)

    End Sub

#End Region

#Region "Hotkeys"

    ''Register the global hotkeys and key modifier ALT or any other modifier in the KeyModifiers Enumerator''
    Public Sub RegisterHotkeys()

        HotkeyClass.RegisterHotKey(Me, "1", 1, HotkeyClass.KeyModifier.Alt)
        HotkeyClass.RegisterHotKey(Me, "2", 2, HotkeyClass.KeyModifier.Alt)
        HotkeyClass.RegisterHotKey(Me, "3", 3, HotkeyClass.KeyModifier.Alt)
        HotkeyClass.RegisterHotKey(Me, "4", 4, HotkeyClass.KeyModifier.Alt)
        HotkeyClass.RegisterHotKey(Me, "5", 5, HotkeyClass.KeyModifier.Alt)
        HotkeyClass.RegisterHotKey(Me, "6", 6, HotkeyClass.KeyModifier.Alt)
        HotkeyClass.RegisterHotKey(Me, "7", 7, HotkeyClass.KeyModifier.Alt)
        HotkeyClass.RegisterHotKey(Me, "8", 8, HotkeyClass.KeyModifier.Alt)
        HotkeyClass.RegisterHotKey(Me, "9", 9, HotkeyClass.KeyModifier.Alt)
        HotkeyClass.RegisterHotKey(Me, "10", 0, HotkeyClass.KeyModifier.Alt)
        HotkeyClass.RegisterHotKey(Me, "11", "p", HotkeyClass.KeyModifier.Alt)
        HotkeyClass.RegisterHotKey(Me, "12", "q", HotkeyClass.KeyModifier.Alt)


    End Sub

    ''Call to unregister all the hotkeys by calling unregisterHotkeys sub in the HotKeyClass when app closes''
    Public Sub KillHotkeys()

        Dim cls As New HotkeyClass()
        cls.GetType.InvokeMember("unregisterHotkeys", Reflection.BindingFlags.InvokeMethod Or Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic, Nothing, cls, Nothing)

    End Sub

    ''Handles the global hotkey message calls so the hotkeys can work when app is not in focus''
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)

        If m.Msg = HotkeyClass.WM_HOTKEY Then
            HotkeyClass.handleHotKeyEvent(m.WParam)
        End If
        MyBase.WndProc(m)

    End Sub

#End Region

    ''form closing events''
    Private Sub FrmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        KillHotkeys()

    End Sub

End Class
