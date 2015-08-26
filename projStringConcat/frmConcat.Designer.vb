<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConcat
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
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtEmail1 = New System.Windows.Forms.TextBox()
        Me.lblEmail1 = New System.Windows.Forms.Label()
        Me.lblEmail2 = New System.Windows.Forms.Label()
        Me.txtEmail2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(15, 111)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(96, 111)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtEmail1
        '
        Me.txtEmail1.Location = New System.Drawing.Point(15, 25)
        Me.txtEmail1.Name = "txtEmail1"
        Me.txtEmail1.Size = New System.Drawing.Size(156, 20)
        Me.txtEmail1.TabIndex = 0
        '
        'lblEmail1
        '
        Me.lblEmail1.AutoSize = True
        Me.lblEmail1.Location = New System.Drawing.Point(12, 9)
        Me.lblEmail1.Name = "lblEmail1"
        Me.lblEmail1.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail1.TabIndex = 4
        Me.lblEmail1.Text = "Email"
        '
        'lblEmail2
        '
        Me.lblEmail2.AutoSize = True
        Me.lblEmail2.Location = New System.Drawing.Point(12, 58)
        Me.lblEmail2.Name = "lblEmail2"
        Me.lblEmail2.Size = New System.Drawing.Size(70, 13)
        Me.lblEmail2.TabIndex = 5
        Me.lblEmail2.Text = "Repeat Email"
        '
        'txtEmail2
        '
        Me.txtEmail2.Location = New System.Drawing.Point(15, 74)
        Me.txtEmail2.Name = "txtEmail2"
        Me.txtEmail2.ReadOnly = True
        Me.txtEmail2.Size = New System.Drawing.Size(156, 20)
        Me.txtEmail2.TabIndex = 1
        '
        'frmConcat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(188, 148)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblEmail2)
        Me.Controls.Add(Me.lblEmail1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtEmail2)
        Me.Controls.Add(Me.txtEmail1)
        Me.Name = "frmConcat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Concat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtEmail1 As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail1 As System.Windows.Forms.Label
    Friend WithEvents lblEmail2 As System.Windows.Forms.Label
    Friend WithEvents txtEmail2 As System.Windows.Forms.TextBox

End Class
