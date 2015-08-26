<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDemoListBox
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
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.lblBothPrices = New System.Windows.Forms.Label()
        Me.lstPricePds = New System.Windows.Forms.ListBox()
        Me.lstPriceEuros = New System.Windows.Forms.ListBox()
        Me.txtPriceBoth = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(273, 212)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 0
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'lblBothPrices
        '
        Me.lblBothPrices.AutoSize = True
        Me.lblBothPrices.Location = New System.Drawing.Point(9, 173)
        Me.lblBothPrices.Name = "lblBothPrices"
        Me.lblBothPrices.Size = New System.Drawing.Size(79, 13)
        Me.lblBothPrices.TabIndex = 1
        Me.lblBothPrices.Text = "BOTH PRICES"
        '
        'lstPricePds
        '
        Me.lstPricePds.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPricePds.FormattingEnabled = True
        Me.lstPricePds.ItemHeight = 14
        Me.lstPricePds.Location = New System.Drawing.Point(12, 12)
        Me.lstPricePds.Name = "lstPricePds"
        Me.lstPricePds.Size = New System.Drawing.Size(157, 158)
        Me.lstPricePds.TabIndex = 2
        '
        'lstPriceEuros
        '
        Me.lstPriceEuros.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPriceEuros.FormattingEnabled = True
        Me.lstPriceEuros.ItemHeight = 14
        Me.lstPriceEuros.Location = New System.Drawing.Point(189, 12)
        Me.lstPriceEuros.Name = "lstPriceEuros"
        Me.lstPriceEuros.Size = New System.Drawing.Size(157, 158)
        Me.lstPriceEuros.TabIndex = 3
        '
        'txtPriceBoth
        '
        Me.txtPriceBoth.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPriceBoth.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPriceBoth.Location = New System.Drawing.Point(12, 189)
        Me.txtPriceBoth.Multiline = True
        Me.txtPriceBoth.Name = "txtPriceBoth"
        Me.txtPriceBoth.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPriceBoth.Size = New System.Drawing.Size(255, 73)
        Me.txtPriceBoth.TabIndex = 4
        '
        'frmDemoListBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 278)
        Me.Controls.Add(Me.txtPriceBoth)
        Me.Controls.Add(Me.lstPriceEuros)
        Me.Controls.Add(Me.lstPricePds)
        Me.Controls.Add(Me.lblBothPrices)
        Me.Controls.Add(Me.btnQuit)
        Me.MaximumSize = New System.Drawing.Size(376, 10000)
        Me.MinimumSize = New System.Drawing.Size(376, 316)
        Me.Name = "frmDemoListBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Veg"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents lblBothPrices As System.Windows.Forms.Label
    Friend WithEvents lstPricePds As System.Windows.Forms.ListBox
    Friend WithEvents lstPriceEuros As System.Windows.Forms.ListBox
    Friend WithEvents txtPriceBoth As System.Windows.Forms.TextBox

End Class
