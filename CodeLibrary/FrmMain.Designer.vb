<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.LbCodes = New System.Windows.Forms.ListBox()
        Me.Icon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SuspendLayout()
        '
        'LbCodes
        '
        Me.LbCodes.BackColor = System.Drawing.Color.LightGray
        Me.LbCodes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LbCodes.FormattingEnabled = True
        Me.LbCodes.ItemHeight = 16
        Me.LbCodes.Location = New System.Drawing.Point(0, 0)
        Me.LbCodes.Name = "LbCodes"
        Me.LbCodes.Size = New System.Drawing.Size(470, 176)
        Me.LbCodes.TabIndex = 1
        '
        'Icon1
        '
        Me.Icon1.Icon = CType(resources.GetObject("Icon1.Icon"), System.Drawing.Icon)
        Me.Icon1.Text = "Code Library"
        Me.Icon1.Visible = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 176)
        Me.ControlBox = False
        Me.Controls.Add(Me.LbCodes)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "FrmMain"
        Me.Opacity = 0.0R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LbCodes As System.Windows.Forms.ListBox
    Friend WithEvents Icon1 As System.Windows.Forms.NotifyIcon

End Class
