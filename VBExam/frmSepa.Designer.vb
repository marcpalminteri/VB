<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSepa
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
        Me.components = New System.ComponentModel.Container()
        Me.rdoAccountTransfer = New System.Windows.Forms.RadioButton()
        Me.rdoPayees = New System.Windows.Forms.RadioButton()
        Me.gpbAccountTransfer = New System.Windows.Forms.GroupBox()
        Me.lblATTo = New System.Windows.Forms.Label()
        Me.lblATFrom = New System.Windows.Forms.Label()
        Me.cboATTo = New System.Windows.Forms.ComboBox()
        Me.cboATFrom = New System.Windows.Forms.ComboBox()
        Me.gpbPayees = New System.Windows.Forms.GroupBox()
        Me.lblPFrom = New System.Windows.Forms.Label()
        Me.cboPFrom = New System.Windows.Forms.ComboBox()
        Me.lblPBIC = New System.Windows.Forms.Label()
        Me.lblPIBAN = New System.Windows.Forms.Label()
        Me.txtPBIC = New System.Windows.Forms.TextBox()
        Me.txtPIBAN = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.txtReference = New System.Windows.Forms.TextBox()
        Me.lblReference = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancal = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtPName = New System.Windows.Forms.TextBox()
        Me.lblPName = New System.Windows.Forms.Label()
        Me.VBExamDBDataSet = New VBExam.VBExamDBDataSet()
        Me.TblSepaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblSepaTableAdapter = New VBExam.VBExamDBDataSetTableAdapters.tblSepaTableAdapter()
        Me.TableAdapterManager = New VBExam.VBExamDBDataSetTableAdapters.TableAdapterManager()
        Me.gpbAccountTransfer.SuspendLayout()
        Me.gpbPayees.SuspendLayout()
        CType(Me.VBExamDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSepaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rdoAccountTransfer
        '
        Me.rdoAccountTransfer.AutoSize = True
        Me.rdoAccountTransfer.Location = New System.Drawing.Point(44, 12)
        Me.rdoAccountTransfer.Name = "rdoAccountTransfer"
        Me.rdoAccountTransfer.Size = New System.Drawing.Size(107, 17)
        Me.rdoAccountTransfer.TabIndex = 0
        Me.rdoAccountTransfer.TabStop = True
        Me.rdoAccountTransfer.Text = "Account Transfer"
        Me.rdoAccountTransfer.UseVisualStyleBackColor = True
        '
        'rdoPayees
        '
        Me.rdoPayees.AutoSize = True
        Me.rdoPayees.Location = New System.Drawing.Point(178, 12)
        Me.rdoPayees.Name = "rdoPayees"
        Me.rdoPayees.Size = New System.Drawing.Size(60, 17)
        Me.rdoPayees.TabIndex = 1
        Me.rdoPayees.TabStop = True
        Me.rdoPayees.Text = "Payees"
        Me.rdoPayees.UseVisualStyleBackColor = True
        '
        'gpbAccountTransfer
        '
        Me.gpbAccountTransfer.Controls.Add(Me.lblATTo)
        Me.gpbAccountTransfer.Controls.Add(Me.lblATFrom)
        Me.gpbAccountTransfer.Controls.Add(Me.cboATTo)
        Me.gpbAccountTransfer.Controls.Add(Me.cboATFrom)
        Me.gpbAccountTransfer.Location = New System.Drawing.Point(12, 35)
        Me.gpbAccountTransfer.Name = "gpbAccountTransfer"
        Me.gpbAccountTransfer.Size = New System.Drawing.Size(251, 124)
        Me.gpbAccountTransfer.TabIndex = 2
        Me.gpbAccountTransfer.TabStop = False
        '
        'lblATTo
        '
        Me.lblATTo.AutoSize = True
        Me.lblATTo.Location = New System.Drawing.Point(6, 43)
        Me.lblATTo.Name = "lblATTo"
        Me.lblATTo.Size = New System.Drawing.Size(23, 13)
        Me.lblATTo.TabIndex = 3
        Me.lblATTo.Text = "To:"
        '
        'lblATFrom
        '
        Me.lblATFrom.AutoSize = True
        Me.lblATFrom.Location = New System.Drawing.Point(6, 16)
        Me.lblATFrom.Name = "lblATFrom"
        Me.lblATFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblATFrom.TabIndex = 2
        Me.lblATFrom.Text = "From:"
        '
        'cboATTo
        '
        Me.cboATTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboATTo.FormattingEnabled = True
        Me.cboATTo.Items.AddRange(New Object() {"Current", "Deposit", "Loan"})
        Me.cboATTo.Location = New System.Drawing.Point(56, 40)
        Me.cboATTo.Name = "cboATTo"
        Me.cboATTo.Size = New System.Drawing.Size(183, 21)
        Me.cboATTo.TabIndex = 1
        '
        'cboATFrom
        '
        Me.cboATFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboATFrom.FormattingEnabled = True
        Me.cboATFrom.Items.AddRange(New Object() {"Current", "Deposit", "Loan"})
        Me.cboATFrom.Location = New System.Drawing.Point(56, 13)
        Me.cboATFrom.Name = "cboATFrom"
        Me.cboATFrom.Size = New System.Drawing.Size(183, 21)
        Me.cboATFrom.TabIndex = 0
        '
        'gpbPayees
        '
        Me.gpbPayees.Controls.Add(Me.txtPIBAN)
        Me.gpbPayees.Controls.Add(Me.txtPName)
        Me.gpbPayees.Controls.Add(Me.lblPName)
        Me.gpbPayees.Controls.Add(Me.txtPBIC)
        Me.gpbPayees.Controls.Add(Me.lblPIBAN)
        Me.gpbPayees.Controls.Add(Me.lblPFrom)
        Me.gpbPayees.Controls.Add(Me.cboPFrom)
        Me.gpbPayees.Controls.Add(Me.lblPBIC)
        Me.gpbPayees.Location = New System.Drawing.Point(12, 35)
        Me.gpbPayees.Name = "gpbPayees"
        Me.gpbPayees.Size = New System.Drawing.Size(251, 124)
        Me.gpbPayees.TabIndex = 3
        Me.gpbPayees.TabStop = False
        '
        'lblPFrom
        '
        Me.lblPFrom.AutoSize = True
        Me.lblPFrom.Location = New System.Drawing.Point(6, 16)
        Me.lblPFrom.Name = "lblPFrom"
        Me.lblPFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblPFrom.TabIndex = 6
        Me.lblPFrom.Text = "From:"
        '
        'cboPFrom
        '
        Me.cboPFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPFrom.FormattingEnabled = True
        Me.cboPFrom.Items.AddRange(New Object() {"Current", "Deposit"})
        Me.cboPFrom.Location = New System.Drawing.Point(56, 13)
        Me.cboPFrom.Name = "cboPFrom"
        Me.cboPFrom.Size = New System.Drawing.Size(183, 21)
        Me.cboPFrom.TabIndex = 4
        '
        'lblPBIC
        '
        Me.lblPBIC.AutoSize = True
        Me.lblPBIC.Location = New System.Drawing.Point(6, 69)
        Me.lblPBIC.Name = "lblPBIC"
        Me.lblPBIC.Size = New System.Drawing.Size(27, 13)
        Me.lblPBIC.TabIndex = 7
        Me.lblPBIC.Text = "BIC:"
        '
        'lblPIBAN
        '
        Me.lblPIBAN.AutoSize = True
        Me.lblPIBAN.Location = New System.Drawing.Point(6, 95)
        Me.lblPIBAN.Name = "lblPIBAN"
        Me.lblPIBAN.Size = New System.Drawing.Size(35, 13)
        Me.lblPIBAN.TabIndex = 8
        Me.lblPIBAN.Text = "IBAN:"
        '
        'txtPBIC
        '
        Me.txtPBIC.Location = New System.Drawing.Point(56, 66)
        Me.txtPBIC.MaxLength = 8
        Me.txtPBIC.Name = "txtPBIC"
        Me.txtPBIC.Size = New System.Drawing.Size(73, 20)
        Me.txtPBIC.TabIndex = 9
        '
        'txtPIBAN
        '
        Me.txtPIBAN.Location = New System.Drawing.Point(56, 92)
        Me.txtPIBAN.MaxLength = 14
        Me.txtPIBAN.Name = "txtPIBAN"
        Me.txtPIBAN.Size = New System.Drawing.Size(107, 20)
        Me.txtPIBAN.TabIndex = 10
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(68, 165)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(107, 20)
        Me.txtAmount.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Date:"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(18, 168)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(46, 13)
        Me.lblAmount.TabIndex = 11
        Me.lblAmount.Text = "Amount:"
        '
        'txtReference
        '
        Me.txtReference.Location = New System.Drawing.Point(68, 217)
        Me.txtReference.MaxLength = 15
        Me.txtReference.Name = "txtReference"
        Me.txtReference.Size = New System.Drawing.Size(183, 20)
        Me.txtReference.TabIndex = 16
        '
        'lblReference
        '
        Me.lblReference.AutoSize = True
        Me.lblReference.Location = New System.Drawing.Point(18, 220)
        Me.lblReference.Name = "lblReference"
        Me.lblReference.Size = New System.Drawing.Size(27, 13)
        Me.lblReference.TabIndex = 15
        Me.lblReference.Text = "Ref:"
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(68, 191)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(183, 20)
        Me.dtpDate.TabIndex = 17
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(284, 56)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 40)
        Me.btnSave.TabIndex = 18
        Me.btnSave.Text = "Submit"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancal
        '
        Me.btnCancal.Location = New System.Drawing.Point(284, 119)
        Me.btnCancal.Name = "btnCancal"
        Me.btnCancal.Size = New System.Drawing.Size(75, 40)
        Me.btnCancal.TabIndex = 19
        Me.btnCancal.Text = "Cancel"
        Me.btnCancal.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(284, 182)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 40)
        Me.btnExit.TabIndex = 20
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtPName
        '
        Me.txtPName.Location = New System.Drawing.Point(56, 40)
        Me.txtPName.MaxLength = 30
        Me.txtPName.Name = "txtPName"
        Me.txtPName.Size = New System.Drawing.Size(183, 20)
        Me.txtPName.TabIndex = 12
        '
        'lblPName
        '
        Me.lblPName.AutoSize = True
        Me.lblPName.Location = New System.Drawing.Point(6, 43)
        Me.lblPName.Name = "lblPName"
        Me.lblPName.Size = New System.Drawing.Size(38, 13)
        Me.lblPName.TabIndex = 7
        Me.lblPName.Text = "Name:"
        '
        'VBExamDBDataSet
        '
        Me.VBExamDBDataSet.DataSetName = "VBExamDBDataSet"
        Me.VBExamDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblSepaBindingSource
        '
        Me.TblSepaBindingSource.DataMember = "tblSepa"
        Me.TblSepaBindingSource.DataSource = Me.VBExamDBDataSet
        '
        'TblSepaTableAdapter
        '
        Me.TblSepaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblSepaTableAdapter = Me.TblSepaTableAdapter
        Me.TableAdapterManager.UpdateOrder = VBExam.VBExamDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmSepa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(375, 252)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCancal)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.gpbPayees)
        Me.Controls.Add(Me.txtReference)
        Me.Controls.Add(Me.lblReference)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.gpbAccountTransfer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rdoPayees)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.rdoAccountTransfer)
        Me.MaximumSize = New System.Drawing.Size(391, 290)
        Me.MinimumSize = New System.Drawing.Size(391, 290)
        Me.Name = "frmSepa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marc Anthony Palminteri VB Exam"
        Me.gpbAccountTransfer.ResumeLayout(False)
        Me.gpbAccountTransfer.PerformLayout()
        Me.gpbPayees.ResumeLayout(False)
        Me.gpbPayees.PerformLayout()
        CType(Me.VBExamDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSepaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdoAccountTransfer As System.Windows.Forms.RadioButton
    Friend WithEvents rdoPayees As System.Windows.Forms.RadioButton
    Friend WithEvents gpbAccountTransfer As System.Windows.Forms.GroupBox
    Friend WithEvents lblATTo As System.Windows.Forms.Label
    Friend WithEvents lblATFrom As System.Windows.Forms.Label
    Friend WithEvents cboATTo As System.Windows.Forms.ComboBox
    Friend WithEvents cboATFrom As System.Windows.Forms.ComboBox
    Friend WithEvents gpbPayees As System.Windows.Forms.GroupBox
    Friend WithEvents txtPIBAN As System.Windows.Forms.TextBox
    Friend WithEvents txtPBIC As System.Windows.Forms.TextBox
    Friend WithEvents lblPIBAN As System.Windows.Forms.Label
    Friend WithEvents lblPBIC As System.Windows.Forms.Label
    Friend WithEvents lblPFrom As System.Windows.Forms.Label
    Friend WithEvents cboPFrom As System.Windows.Forms.ComboBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents txtReference As System.Windows.Forms.TextBox
    Friend WithEvents lblReference As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancal As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtPName As System.Windows.Forms.TextBox
    Friend WithEvents lblPName As System.Windows.Forms.Label
    Friend WithEvents VBExamDBDataSet As VBExam.VBExamDBDataSet
    Friend WithEvents TblSepaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblSepaTableAdapter As VBExam.VBExamDBDataSetTableAdapters.tblSepaTableAdapter
    Friend WithEvents TableAdapterManager As VBExam.VBExamDBDataSetTableAdapters.TableAdapterManager

End Class
