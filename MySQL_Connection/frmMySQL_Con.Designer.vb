<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMySQL_Con
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCheck_Conn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCheck_Conn
        '
        Me.btnCheck_Conn.Location = New System.Drawing.Point(54, 29)
        Me.btnCheck_Conn.Name = "btnCheck_Conn"
        Me.btnCheck_Conn.Size = New System.Drawing.Size(204, 84)
        Me.btnCheck_Conn.TabIndex = 0
        Me.btnCheck_Conn.Text = "Check Connection"
        Me.btnCheck_Conn.UseVisualStyleBackColor = True
        '
        'frmMySQL_Con
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 143)
        Me.Controls.Add(Me.btnCheck_Conn)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMySQL_Con"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MySQL Connection"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCheck_Conn As Button
End Class
