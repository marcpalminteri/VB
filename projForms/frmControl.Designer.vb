<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControl
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
        Me.btnDisplay1 = New System.Windows.Forms.Button()
        Me.btnDisplay2 = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDisplay1
        '
        Me.btnDisplay1.Location = New System.Drawing.Point(24, 22)
        Me.btnDisplay1.Name = "btnDisplay1"
        Me.btnDisplay1.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplay1.TabIndex = 0
        Me.btnDisplay1.Text = "Display 1"
        Me.btnDisplay1.UseVisualStyleBackColor = True
        '
        'btnDisplay2
        '
        Me.btnDisplay2.Location = New System.Drawing.Point(105, 22)
        Me.btnDisplay2.Name = "btnDisplay2"
        Me.btnDisplay2.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplay2.TabIndex = 1
        Me.btnDisplay2.Text = "Display 2"
        Me.btnDisplay2.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(186, 22)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 63)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDisplay2)
        Me.Controls.Add(Me.btnDisplay1)
        Me.Name = "frmControl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDisplay1 As System.Windows.Forms.Button
    Friend WithEvents btnDisplay2 As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button

End Class
