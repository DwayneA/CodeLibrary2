Imports CodeLibrary.HotkeyClass
Public Class FrmViewer

    ''Needed for round edges''
    Overloads Property FormBorderStyle As Windows.Forms.FormBorderStyle

    ''Call refresh data on load''
    Private Sub FrmViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ''Hides form on load''
        Me.Opacity = 0

        ''Sets the text area's background color from the global variable in the module''
        RTB.BackColor = BackColor
        CodeName.BackColor = BackColor

        ''Populate text area and textbox''
        GetData()

    End Sub

    ''Gets the data for the viewer''
    Public Sub GetData()

        If Code = Nothing Then
            CodeName.Text = Nothing
            RTB.Clear()
            ''Adds new line to get out from underneath the textbox at the top where the name is shown''
            RTB.AppendText(Environment.NewLine)
        Else
            CodeName.Text = Code
            LoadFileStr = Application.StartupPath & "\samples\" & CurrentLang & "\" & Code & "\codelibrary.rtf"
            OpenFolder = Application.StartupPath & "\samples\" & CurrentLang & "\" & Code
            RTB.LoadFile(LoadFileStr)
            RTB.Refresh()
        End If

    End Sub

    ''Saves the viewers data''
    Public Sub SaveData()

        ''If folder does not exsist the create it, for new code''
        If (Not System.IO.Directory.Exists(Application.StartupPath & "\samples\" & CurrentLang & "\" & Code)) Then
            System.IO.Directory.CreateDirectory(Application.StartupPath & "\samples\" & CurrentLang & "\" & Code)
        End If

        ''Save new code''
        LoadFileStr = Application.StartupPath & "\samples\" & CurrentLang & "\" & Code & "\codelibrary.rtf"
        RTB.SaveFile(LoadFileStr)

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

    ''Handles drag and drop for rtb viewer''
#Region "Handles drag and drop"

    Private Sub RTB_MouseDown(sender As Object, e As MouseEventArgs) Handles RTB.MouseDown

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

    Private Sub RTB_MouseMove(sender As Object, e As MouseEventArgs) Handles RTB.MouseMove

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

    Private Sub RTB_MouseUp(sender As Object, e As MouseEventArgs) Handles RTB.MouseUp

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

    ''Opens the code you are viewing's folder''
    ''System.Diagnostics.Process.Start(OpenFolder)

End Class