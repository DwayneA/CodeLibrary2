<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmViewer
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
        Me.RTB = New System.Windows.Forms.RichTextBox()
        Me.BtnOpen = New System.Windows.Forms.Button()
        Me.BtnOpenProject = New System.Windows.Forms.Button()
        Me.CodeName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'RTB
        '
        Me.RTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RTB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RTB.Location = New System.Drawing.Point(0, 0)
        Me.RTB.Name = "RTB"
        Me.RTB.Size = New System.Drawing.Size(860, 504)
        Me.RTB.TabIndex = 0
        Me.RTB.Text = ""
        '
        'BtnOpen
        '
        Me.BtnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOpen.Location = New System.Drawing.Point(12, 536)
        Me.BtnOpen.Name = "BtnOpen"
        Me.BtnOpen.Size = New System.Drawing.Size(1066, 34)
        Me.BtnOpen.TabIndex = 1
        Me.BtnOpen.Text = "Open Folder"
        Me.BtnOpen.UseVisualStyleBackColor = True
        '
        'BtnOpenProject
        '
        Me.BtnOpenProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOpenProject.Location = New System.Drawing.Point(12, 576)
        Me.BtnOpenProject.Name = "BtnOpenProject"
        Me.BtnOpenProject.Size = New System.Drawing.Size(1066, 34)
        Me.BtnOpenProject.TabIndex = 2
        Me.BtnOpenProject.Text = "Open Project"
        Me.BtnOpenProject.UseVisualStyleBackColor = True
        '
        'CodeName
        '
        Me.CodeName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CodeName.Dock = System.Windows.Forms.DockStyle.Top
        Me.CodeName.Location = New System.Drawing.Point(0, 0)
        Me.CodeName.Name = "CodeName"
        Me.CodeName.Size = New System.Drawing.Size(860, 15)
        Me.CodeName.TabIndex = 4
        Me.CodeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FrmViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 504)
        Me.ControlBox = False
        Me.Controls.Add(Me.CodeName)
        Me.Controls.Add(Me.RTB)
        Me.Controls.Add(Me.BtnOpenProject)
        Me.Controls.Add(Me.BtnOpen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "FrmViewer"
        Me.Opacity = 0.0R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RTB As System.Windows.Forms.RichTextBox
    Friend WithEvents BtnOpen As System.Windows.Forms.Button
    Friend WithEvents BtnOpenProject As System.Windows.Forms.Button
    Friend WithEvents CodeName As System.Windows.Forms.TextBox
End Class
