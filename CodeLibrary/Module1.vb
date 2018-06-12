Module Module1

    ''Global variables''
    Public BackColor = Color.Gray
    Public MainVisible As Boolean = False
    Public ViewerVisible As Boolean = False
    Public Code As String
    Public CurrentLang As String
    Public CurrentLang2 As String
    Public OpenFolder As String
    Public LoadFileStr As String
    Public FrmViewer As New FrmViewer
    Public Languages As Array
    Public myProcess As System.Diagnostics.Process

    ''Needed for drag and drop''
    Public drag As Boolean
    Public mousex As Integer
    Public mousey As Integer

End Module
