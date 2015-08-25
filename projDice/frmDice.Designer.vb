<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDice
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
        Me.txtNoOfRolls = New System.Windows.Forms.TextBox()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.lblNoOfRolls = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.btnDie1 = New System.Windows.Forms.Button()
        Me.btnDie2 = New System.Windows.Forms.Button()
        Me.txtDie1 = New System.Windows.Forms.TextBox()
        Me.txtDie2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtNoOfRolls
        '
        Me.txtNoOfRolls.Location = New System.Drawing.Point(178, 38)
        Me.txtNoOfRolls.Name = "txtNoOfRolls"
        Me.txtNoOfRolls.ReadOnly = True
        Me.txtNoOfRolls.Size = New System.Drawing.Size(32, 20)
        Me.txtNoOfRolls.TabIndex = 2
        '
        'txtScore
        '
        Me.txtScore.Location = New System.Drawing.Point(178, 77)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.ReadOnly = True
        Me.txtScore.Size = New System.Drawing.Size(32, 20)
        Me.txtScore.TabIndex = 3
        '
        'lblNoOfRolls
        '
        Me.lblNoOfRolls.AutoSize = True
        Me.lblNoOfRolls.Location = New System.Drawing.Point(175, 22)
        Me.lblNoOfRolls.Name = "lblNoOfRolls"
        Me.lblNoOfRolls.Size = New System.Drawing.Size(62, 13)
        Me.lblNoOfRolls.TabIndex = 4
        Me.lblNoOfRolls.Text = "No. of Rolls"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(175, 61)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(35, 13)
        Me.lblScore.TabIndex = 5
        Me.lblScore.Text = "Score"
        '
        'btnDie1
        '
        Me.btnDie1.BackColor = System.Drawing.Color.White
        Me.btnDie1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnDie1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDie1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDie1.Location = New System.Drawing.Point(13, 22)
        Me.btnDie1.Name = "btnDie1"
        Me.btnDie1.Size = New System.Drawing.Size(75, 36)
        Me.btnDie1.TabIndex = 0
        Me.btnDie1.Text = "Roll!"
        Me.btnDie1.UseVisualStyleBackColor = False
        '
        'btnDie2
        '
        Me.btnDie2.BackColor = System.Drawing.Color.White
        Me.btnDie2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnDie2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDie2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDie2.Location = New System.Drawing.Point(94, 22)
        Me.btnDie2.Name = "btnDie2"
        Me.btnDie2.Size = New System.Drawing.Size(75, 36)
        Me.btnDie2.TabIndex = 1
        Me.btnDie2.UseVisualStyleBackColor = False
        '
        'txtDie1
        '
        Me.txtDie1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDie1.Location = New System.Drawing.Point(28, 64)
        Me.txtDie1.Name = "txtDie1"
        Me.txtDie1.Size = New System.Drawing.Size(45, 31)
        Me.txtDie1.TabIndex = 6
        Me.txtDie1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDie2
        '
        Me.txtDie2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDie2.Location = New System.Drawing.Point(109, 64)
        Me.txtDie2.Name = "txtDie2"
        Me.txtDie2.Size = New System.Drawing.Size(45, 31)
        Me.txtDie2.TabIndex = 7
        Me.txtDie2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmDice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(248, 112)
        Me.Controls.Add(Me.txtDie2)
        Me.Controls.Add(Me.txtDie1)
        Me.Controls.Add(Me.btnDie2)
        Me.Controls.Add(Me.btnDie1)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblNoOfRolls)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.txtNoOfRolls)
        Me.Name = "frmDice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNoOfRolls As System.Windows.Forms.TextBox
    Friend WithEvents txtScore As System.Windows.Forms.TextBox
    Friend WithEvents lblNoOfRolls As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents btnDie1 As System.Windows.Forms.Button
    Friend WithEvents btnDie2 As System.Windows.Forms.Button
    Friend WithEvents txtDie1 As System.Windows.Forms.TextBox
    Friend WithEvents txtDie2 As System.Windows.Forms.TextBox

End Class
