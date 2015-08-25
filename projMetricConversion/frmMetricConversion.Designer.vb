<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMetricConversion
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
        Me.txtMiles = New System.Windows.Forms.TextBox()
        Me.lblMiles = New System.Windows.Forms.Label()
        Me.txtKilo = New System.Windows.Forms.TextBox()
        Me.lblKilo = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblCelsius = New System.Windows.Forms.Label()
        Me.txtCelsius = New System.Windows.Forms.TextBox()
        Me.txtFahrenheit = New System.Windows.Forms.TextBox()
        Me.lblFahrenheit = New System.Windows.Forms.Label()
        Me.rdoDistance = New System.Windows.Forms.RadioButton()
        Me.rdoTemperature = New System.Windows.Forms.RadioButton()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.gpbDistance = New System.Windows.Forms.GroupBox()
        Me.gpbTemperature = New System.Windows.Forms.GroupBox()
        Me.gpbDistance.SuspendLayout()
        Me.gpbTemperature.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtMiles
        '
        Me.txtMiles.Location = New System.Drawing.Point(23, 57)
        Me.txtMiles.Name = "txtMiles"
        Me.txtMiles.Size = New System.Drawing.Size(75, 20)
        Me.txtMiles.TabIndex = 0
        '
        'lblMiles
        '
        Me.lblMiles.AutoSize = True
        Me.lblMiles.Location = New System.Drawing.Point(20, 30)
        Me.lblMiles.Name = "lblMiles"
        Me.lblMiles.Size = New System.Drawing.Size(31, 13)
        Me.lblMiles.TabIndex = 1
        Me.lblMiles.Text = "Miles"
        '
        'txtKilo
        '
        Me.txtKilo.Location = New System.Drawing.Point(104, 57)
        Me.txtKilo.Name = "txtKilo"
        Me.txtKilo.Size = New System.Drawing.Size(75, 20)
        Me.txtKilo.TabIndex = 2
        '
        'lblKilo
        '
        Me.lblKilo.AutoSize = True
        Me.lblKilo.Location = New System.Drawing.Point(101, 30)
        Me.lblKilo.Name = "lblKilo"
        Me.lblKilo.Size = New System.Drawing.Size(55, 13)
        Me.lblKilo.TabIndex = 3
        Me.lblKilo.Text = "Kilometers"
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(194, 141)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 4
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(356, 141)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblCelsius
        '
        Me.lblCelsius.AutoSize = True
        Me.lblCelsius.Location = New System.Drawing.Point(21, 30)
        Me.lblCelsius.Name = "lblCelsius"
        Me.lblCelsius.Size = New System.Drawing.Size(40, 13)
        Me.lblCelsius.TabIndex = 6
        Me.lblCelsius.Text = "Celsius"
        '
        'txtCelsius
        '
        Me.txtCelsius.Location = New System.Drawing.Point(24, 57)
        Me.txtCelsius.Name = "txtCelsius"
        Me.txtCelsius.Size = New System.Drawing.Size(75, 20)
        Me.txtCelsius.TabIndex = 7
        '
        'txtFahrenheit
        '
        Me.txtFahrenheit.Location = New System.Drawing.Point(105, 57)
        Me.txtFahrenheit.Name = "txtFahrenheit"
        Me.txtFahrenheit.Size = New System.Drawing.Size(75, 20)
        Me.txtFahrenheit.TabIndex = 8
        '
        'lblFahrenheit
        '
        Me.lblFahrenheit.AutoSize = True
        Me.lblFahrenheit.Location = New System.Drawing.Point(102, 30)
        Me.lblFahrenheit.Name = "lblFahrenheit"
        Me.lblFahrenheit.Size = New System.Drawing.Size(57, 13)
        Me.lblFahrenheit.TabIndex = 9
        Me.lblFahrenheit.Text = "Fahrenheit"
        '
        'rdoDistance
        '
        Me.rdoDistance.AutoSize = True
        Me.rdoDistance.Location = New System.Drawing.Point(12, 12)
        Me.rdoDistance.Name = "rdoDistance"
        Me.rdoDistance.Size = New System.Drawing.Size(67, 17)
        Me.rdoDistance.TabIndex = 10
        Me.rdoDistance.TabStop = True
        Me.rdoDistance.Text = "Distance"
        Me.rdoDistance.UseVisualStyleBackColor = True
        '
        'rdoTemperature
        '
        Me.rdoTemperature.AutoSize = True
        Me.rdoTemperature.Location = New System.Drawing.Point(227, 12)
        Me.rdoTemperature.Name = "rdoTemperature"
        Me.rdoTemperature.Size = New System.Drawing.Size(85, 17)
        Me.rdoTemperature.TabIndex = 11
        Me.rdoTemperature.TabStop = True
        Me.rdoTemperature.Text = "Temperature"
        Me.rdoTemperature.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(275, 141)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'gpbDistance
        '
        Me.gpbDistance.Controls.Add(Me.lblMiles)
        Me.gpbDistance.Controls.Add(Me.txtMiles)
        Me.gpbDistance.Controls.Add(Me.txtKilo)
        Me.gpbDistance.Controls.Add(Me.lblKilo)
        Me.gpbDistance.Location = New System.Drawing.Point(12, 35)
        Me.gpbDistance.Name = "gpbDistance"
        Me.gpbDistance.Size = New System.Drawing.Size(200, 100)
        Me.gpbDistance.TabIndex = 13
        Me.gpbDistance.TabStop = False
        '
        'gpbTemperature
        '
        Me.gpbTemperature.Controls.Add(Me.lblCelsius)
        Me.gpbTemperature.Controls.Add(Me.txtCelsius)
        Me.gpbTemperature.Controls.Add(Me.txtFahrenheit)
        Me.gpbTemperature.Controls.Add(Me.lblFahrenheit)
        Me.gpbTemperature.Location = New System.Drawing.Point(231, 35)
        Me.gpbTemperature.Name = "gpbTemperature"
        Me.gpbTemperature.Size = New System.Drawing.Size(200, 100)
        Me.gpbTemperature.TabIndex = 14
        Me.gpbTemperature.TabStop = False
        '
        'frmMetricConversion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 182)
        Me.Controls.Add(Me.gpbTemperature)
        Me.Controls.Add(Me.gpbDistance)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.rdoTemperature)
        Me.Controls.Add(Me.rdoDistance)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnConvert)
        Me.Name = "frmMetricConversion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.gpbDistance.ResumeLayout(False)
        Me.gpbDistance.PerformLayout()
        Me.gpbTemperature.ResumeLayout(False)
        Me.gpbTemperature.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMiles As System.Windows.Forms.TextBox
    Friend WithEvents lblMiles As System.Windows.Forms.Label
    Friend WithEvents txtKilo As System.Windows.Forms.TextBox
    Friend WithEvents lblKilo As System.Windows.Forms.Label
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblCelsius As System.Windows.Forms.Label
    Friend WithEvents txtCelsius As System.Windows.Forms.TextBox
    Friend WithEvents txtFahrenheit As System.Windows.Forms.TextBox
    Friend WithEvents lblFahrenheit As System.Windows.Forms.Label
    Friend WithEvents rdoDistance As System.Windows.Forms.RadioButton
    Friend WithEvents rdoTemperature As System.Windows.Forms.RadioButton
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents gpbDistance As System.Windows.Forms.GroupBox
    Friend WithEvents gpbTemperature As System.Windows.Forms.GroupBox

End Class
