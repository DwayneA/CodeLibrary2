Public Class HotkeyClass

#Region "Declarations - WinAPI, Hotkey constant and Modifier Enum"

    Public Declare Function RegisterHotKey Lib "user32" (ByVal hwnd As IntPtr, ByVal id As Integer, ByVal fsModifiers As Integer, ByVal vk As Integer) As Integer

    Public Declare Function UnregisterHotKey Lib "user32" (ByVal hwnd As IntPtr, ByVal id As Integer) As Integer

    Public Const WM_HOTKEY As Integer = &H312

    Enum KeyModifier
        None = 0      ''Not used, but can be insted of ALT''
        Alt = &H1
    End Enum

#End Region

#Region "Hotkey registration, unregistration and handling"

    ''Register all the hotkeys'' 
    Public Shared Sub registerHotkey(ByRef sourceForm As Form, ByVal hotKeyID As Int16, ByVal triggerKey As String, ByVal modifier As KeyModifier)

        RegisterHotKey(sourceForm.Handle, hotKeyID, modifier, Asc(triggerKey.ToUpper))

    End Sub

    ''Unregister all the hotkeys''
    Public Shared Sub unregisterHotkeys(ByRef sourceForm As Form)

        UnregisterHotKey(sourceForm.Handle, 1)
        UnregisterHotKey(sourceForm.Handle, 2)
        UnregisterHotKey(sourceForm.Handle, 3)
        UnregisterHotKey(sourceForm.Handle, 4)
        UnregisterHotKey(sourceForm.Handle, 5)
        UnregisterHotKey(sourceForm.Handle, 6)
        UnregisterHotKey(sourceForm.Handle, 7)
        UnregisterHotKey(sourceForm.Handle, 8)
        UnregisterHotKey(sourceForm.Handle, 9)
        UnregisterHotKey(sourceForm.Handle, 10)
        UnregisterHotKey(sourceForm.Handle, 11)
        UnregisterHotKey(sourceForm.Handle, 12)

    End Sub

    ''Hotkey event handler. do event depending on hotkey pressed''
    Public Shared Sub handleHotKeyEvent(ByVal HotKeyID As IntPtr)

        Select Case HotKeyID

            Case 1

                ''hotkey Alt + 1 sets mode to first folder''
                Try

                    FrmMain.PopulateListBox(Languages(0).ToString())
                    CurrentLang = Languages(0).ToString()
                    If CurrentLang = CurrentLang2 Then
                        FrmMain.FadeOut(FrmMain)
                        CurrentLang2 = Nothing
                    Else
                        If MainVisible = False Then
                            FrmMain.FadeIn(FrmMain)
                        End If
                        CurrentLang2 = CurrentLang
                        AppActivate(myProcess.Id)
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try

            Case 2

                ''hotkey Alt + 2 sets mode to second folder''
                Try

                    FrmMain.PopulateListBox(Languages(1).ToString())
                    CurrentLang = Languages(1).ToString()
                    If CurrentLang = CurrentLang2 Then
                        FrmMain.FadeOut(FrmMain)
                        CurrentLang2 = Nothing
                    Else
                        If MainVisible = False Then
                            FrmMain.FadeIn(FrmMain)
                        End If
                        CurrentLang2 = CurrentLang
                        AppActivate(myProcess.Id)
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try

            Case 3

                ''hotkey Alt + 3 sets mode to third folder''
                Try

                    FrmMain.PopulateListBox(Languages(2).ToString())
                    CurrentLang = Languages(2).ToString()
                    If CurrentLang = CurrentLang2 Then
                        FrmMain.FadeOut(FrmMain)
                        CurrentLang2 = Nothing
                    Else
                        If MainVisible = False Then
                            FrmMain.FadeIn(FrmMain)
                        End If
                        CurrentLang2 = CurrentLang
                        AppActivate(myProcess.Id)
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try

            Case 4

                ''hotkey Alt + 4 sets mode to fourth folder''
                Try

                    FrmMain.PopulateListBox(Languages(3).ToString())
                    CurrentLang = Languages(3).ToString()
                    If CurrentLang = CurrentLang2 Then
                        FrmMain.FadeOut(FrmMain)
                        CurrentLang2 = Nothing
                    Else
                        If MainVisible = False Then
                            FrmMain.FadeIn(FrmMain)
                        End If
                        CurrentLang2 = CurrentLang
                        AppActivate(myProcess.Id)
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try

            Case 5

                ''hotkey Alt + 5 sets mode to fith folder''
                Try

                    FrmMain.PopulateListBox(Languages(4).ToString())
                    CurrentLang = Languages(4).ToString()
                    If CurrentLang = CurrentLang2 Then
                        FrmMain.FadeOut(FrmMain)
                        CurrentLang2 = Nothing
                    Else
                        If MainVisible = False Then
                            FrmMain.FadeIn(FrmMain)
                        End If
                        CurrentLang2 = CurrentLang
                        AppActivate(myProcess.Id)
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try

            Case 6

                ''hotkey Alt + 6 sets mode to sixth folder''
                Try

                    FrmMain.PopulateListBox(Languages(5).ToString())
                    CurrentLang = Languages(5).ToString()
                    If CurrentLang = CurrentLang2 Then
                        FrmMain.FadeOut(FrmMain)
                        CurrentLang2 = Nothing
                    Else
                        If MainVisible = False Then
                            FrmMain.FadeIn(FrmMain)
                        End If
                        CurrentLang2 = CurrentLang
                        AppActivate(myProcess.Id)
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try

            Case 7

                ''hotkey Alt + 7 sets mode to seventh folder''
                Try

                    FrmMain.PopulateListBox(Languages(6).ToString())
                    CurrentLang = Languages(6).ToString()
                    If CurrentLang = CurrentLang2 Then
                        FrmMain.FadeOut(FrmMain)
                        CurrentLang2 = Nothing
                    Else
                        If MainVisible = False Then
                            FrmMain.FadeIn(FrmMain)
                        End If
                        CurrentLang2 = CurrentLang
                        AppActivate(myProcess.Id)
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try

            Case 8

                ''hotkey Alt + 8 sets mode to eighth folder''
                Try

                    FrmMain.PopulateListBox(Languages(7).ToString())
                    CurrentLang = Languages(7).ToString()
                    If CurrentLang = CurrentLang2 Then
                        FrmMain.FadeOut(FrmMain)
                        CurrentLang2 = Nothing
                    Else
                        If MainVisible = False Then
                            FrmMain.FadeIn(FrmMain)
                        End If
                        CurrentLang2 = CurrentLang
                        AppActivate(myProcess.Id)
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try

            Case 9

                ''hotkey Alt + 9 sets mode to ninth folder''
                Try

                    FrmMain.PopulateListBox(Languages(8).ToString())
                    CurrentLang = Languages(8).ToString()
                    If CurrentLang = CurrentLang2 Then
                        FrmMain.FadeOut(FrmMain)
                        CurrentLang2 = Nothing
                    Else
                        If MainVisible = False Then
                            FrmMain.FadeIn(FrmMain)
                        End If
                        CurrentLang2 = CurrentLang
                        AppActivate(myProcess.Id)
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try

            Case 10

                ''hotkey Alt + 0 sets mode to add code''
                Try

                    Code = Nothing
                    If MainVisible = False Then
                        FrmMain.FadeIn(FrmMain)
                    End If

                    If ViewerVisible = False Then
                        FrmMain.FadeIn(FrmViewer)
                        AppActivate(myProcess.Id)
                    End If

                Catch ex As Exception
                End Try

            Case 11

                ''hotkey Alt + P Exit the application''
                Try

                    FrmViewer.Dispose()
                    FrmMain.Dispose()

                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try

            Case 12

                ''hotkey Alt + Q will hide all the windows''
                Try

                    If MainVisible = True Then
                        ''Check to see if viewer is open and close it before attempting to close main window''
                        If ViewerVisible = True Then
                            FrmViewer.SaveData()
                            FrmMain.FadeOut(FrmViewer)
                            ''Sets active app/form based on proccess id or you can use the forms title text as string instead''
                            AppActivate(myProcess.Id)
                        Else
                            FrmMain.FadeOut(FrmMain)
                        End If

                    Else
                        ''Nothing''
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try

        End Select

    End Sub

#End Region

End Class
