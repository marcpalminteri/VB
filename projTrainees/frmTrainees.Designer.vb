<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrainees
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
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.lblFirstname = New System.Windows.Forms.Label()
        Me.lblLastname = New System.Windows.Forms.Label()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.lblDateOfBirth = New System.Windows.Forms.Label()
        Me.dtpDateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.rdoMale = New System.Windows.Forms.RadioButton()
        Me.rdoFemale = New System.Windows.Forms.RadioButton()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtAddress1 = New System.Windows.Forms.TextBox()
        Me.txtAddress2 = New System.Windows.Forms.TextBox()
        Me.cboNationality = New System.Windows.Forms.ComboBox()
        Me.txtNationality = New System.Windows.Forms.Label()
        Me.cboAddress = New System.Windows.Forms.ComboBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblBirthCountry = New System.Windows.Forms.Label()
        Me.cboBirthCountry = New System.Windows.Forms.ComboBox()
        Me.lblBirthCounty = New System.Windows.Forms.Label()
        Me.cboBirthCounty = New System.Windows.Forms.ComboBox()
        Me.lblManditory1 = New System.Windows.Forms.Label()
        Me.lblManditory2 = New System.Windows.Forms.Label()
        Me.lblManditory3 = New System.Windows.Forms.Label()
        Me.lblManditory4 = New System.Windows.Forms.Label()
        Me.lblManditory5 = New System.Windows.Forms.Label()
        Me.lblManditory6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtFirstname
        '
        Me.txtFirstname.Location = New System.Drawing.Point(98, 23)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(158, 20)
        Me.txtFirstname.TabIndex = 0
        '
        'lblFirstname
        '
        Me.lblFirstname.AutoSize = True
        Me.lblFirstname.Location = New System.Drawing.Point(11, 26)
        Me.lblFirstname.Name = "lblFirstname"
        Me.lblFirstname.Size = New System.Drawing.Size(60, 13)
        Me.lblFirstname.TabIndex = 1
        Me.lblFirstname.Text = "First Name:"
        '
        'lblLastname
        '
        Me.lblLastname.AutoSize = True
        Me.lblLastname.Location = New System.Drawing.Point(11, 52)
        Me.lblLastname.Name = "lblLastname"
        Me.lblLastname.Size = New System.Drawing.Size(61, 13)
        Me.lblLastname.TabIndex = 3
        Me.lblLastname.Text = "Last Name:"
        '
        'txtLastname
        '
        Me.txtLastname.Location = New System.Drawing.Point(98, 49)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(158, 20)
        Me.txtLastname.TabIndex = 2
        '
        'lblDateOfBirth
        '
        Me.lblDateOfBirth.AutoSize = True
        Me.lblDateOfBirth.Location = New System.Drawing.Point(11, 104)
        Me.lblDateOfBirth.Name = "lblDateOfBirth"
        Me.lblDateOfBirth.Size = New System.Drawing.Size(69, 13)
        Me.lblDateOfBirth.TabIndex = 4
        Me.lblDateOfBirth.Text = "Date of Birth:"
        '
        'dtpDateOfBirth
        '
        Me.dtpDateOfBirth.Location = New System.Drawing.Point(98, 98)
        Me.dtpDateOfBirth.Name = "dtpDateOfBirth"
        Me.dtpDateOfBirth.Size = New System.Drawing.Size(158, 20)
        Me.dtpDateOfBirth.TabIndex = 5
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(11, 77)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(45, 13)
        Me.lblGender.TabIndex = 6
        Me.lblGender.Text = "Gender:"
        '
        'rdoMale
        '
        Me.rdoMale.AutoSize = True
        Me.rdoMale.Location = New System.Drawing.Point(98, 75)
        Me.rdoMale.Name = "rdoMale"
        Me.rdoMale.Size = New System.Drawing.Size(48, 17)
        Me.rdoMale.TabIndex = 7
        Me.rdoMale.TabStop = True
        Me.rdoMale.Text = "Male"
        Me.rdoMale.UseVisualStyleBackColor = True
        '
        'rdoFemale
        '
        Me.rdoFemale.AutoSize = True
        Me.rdoFemale.Location = New System.Drawing.Point(152, 75)
        Me.rdoFemale.Name = "rdoFemale"
        Me.rdoFemale.Size = New System.Drawing.Size(59, 17)
        Me.rdoFemale.TabIndex = 8
        Me.rdoFemale.TabStop = True
        Me.rdoFemale.Text = "Female"
        Me.rdoFemale.UseVisualStyleBackColor = True
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(293, 26)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(48, 13)
        Me.lblAddress.TabIndex = 9
        Me.lblAddress.Text = "Address:"
        '
        'txtAddress1
        '
        Me.txtAddress1.Location = New System.Drawing.Point(380, 23)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(158, 20)
        Me.txtAddress1.TabIndex = 10
        '
        'txtAddress2
        '
        Me.txtAddress2.Location = New System.Drawing.Point(380, 49)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(158, 20)
        Me.txtAddress2.TabIndex = 11
        '
        'cboNationality
        '
        Me.cboNationality.FormattingEnabled = True
        Me.cboNationality.Items.AddRange(New Object() {"Afghan", "Albanian", "Algerian", "American", "Andorran", "Angolan", "Antiguans", "Argentinean", "Armenian", "Australian", "Austrian", "Azerbaijani", "Bahamian", "Bahraini", "Bangladeshi", "Barbadian", "Barbudans", "Batswana", "Belarusian", "Belgian", "Belizean", "Beninese", "Bhutanese", "Bolivian", "Bosnian", "Brazilian", "British", "Bruneian", "Bulgarian", "Burkinabe", "Burmese", "Burundian", "Cambodian", "Cameroonian", "Canadian", "Cape Verdean", "Central African", "Chadian", "Chilean", "Chinese", "Colombian", "Comoran", "Congolese", "Costa Rican", "Croatian", "Cuban", "Cypriot", "Czech", "Danish", "Djibouti", "Dominican", "Dutch", "East Timorese", "Ecuadorean", "Egyptian", "Emirian", "Equatorial Guinean", "Eritrean", "Estonian", "Ethiopian", "Fijian", "Filipino", "Finnish", "French", "Gabonese", "Gambian", "Georgian", "German", "Ghanaian", "Greek", "Grenadian", "Guatemalan", "Guinea-Bissauan", "Guinean", "Guyanese", "Haitian", "Herzegovinian", "Honduran", "Hungarian", "I-Kiribati", "Icelander", "Indian", "Indonesian", "Iranian", "Iraqi", "Irish", "Israeli", "Italian", "Ivorian", "Jamaican", "Japanese", "Jordanian", "Kazakhstani", "Kenyan", "Kittian and Nevisian", "Kuwaiti", "Kyrgyz", "Laotian", "Latvian", "Lebanese", "Liberian", "Libyan", "Liechtensteiner", "Lithuanian", "Luxembourger", "Macedonian", "Malagasy", "Malawian", "Malaysian", "Maldivan", "Malian", "Maltese", "Marshallese", "Mauritanian", "Mauritian", "Mexican", "Micronesian", "Moldovan", "Monacan", "Mongolian", "Moroccan", "Mosotho", "Motswana", "Mozambican", "Namibian", "Nauruan", "Nepalese", "New Zealander", "Nicaraguan", "Nigerian", "Nigerien", "North Korean", "Northern Irish", "Norwegian", "Omani", "Pakistani", "Palauan", "Panamanian", "Papua New Guinean", "Paraguayan", "Peruvian", "Polish", "Portuguese", "Qatari", "Romanian", "Russian", "Rwandan", "Saint Lucian", "Salvadoran", "Samoan", "San Marinese", "Sao Tomean", "Saudi", "Scottish", "Senegalese", "Serbian", "Seychellois", "Sierra Leonean", "Singaporean", "Slovakian", "Slovenian", "Solomon Islander", "Somali", "South African", "South Korean", "Spanish", "Sri Lankan", "Sudanese", "Surinamer", "Swazi", "Swedish", "Swiss", "Syrian", "Taiwanese", "Tajik", "Tanzanian", "Thai", "Togolese", "Tongan", "Trinidadian or Tobagonian", "Tunisian", "Turkish", "Tuvaluan", "Ugandan", "Ukrainian", "Uruguayan", "Uzbekistani", "Venezuelan", "Vietnamese", "Welsh", "Yemenite", "Zambian", "Zimbabwean"})
        Me.cboNationality.Location = New System.Drawing.Point(98, 124)
        Me.cboNationality.Name = "cboNationality"
        Me.cboNationality.Size = New System.Drawing.Size(158, 21)
        Me.cboNationality.TabIndex = 12
        '
        'txtNationality
        '
        Me.txtNationality.AutoSize = True
        Me.txtNationality.Location = New System.Drawing.Point(11, 127)
        Me.txtNationality.Name = "txtNationality"
        Me.txtNationality.Size = New System.Drawing.Size(59, 13)
        Me.txtNationality.TabIndex = 13
        Me.txtNationality.Text = "Nationality:"
        '
        'cboAddress
        '
        Me.cboAddress.FormattingEnabled = True
        Me.cboAddress.Items.AddRange(New Object() {"Antrim", "Armagh", "Carlow", "Cavan", "Clare", "Cork", "Derry", "Donegal", "Down", "Dublin", "Fermanagh", "Galway", "Kerry", "Kildare", "Kilkenny", "Laois", "Leitrim", "Limerick", "Longford", "Louth", "Mayo", "Meath", "Monaghan", "Offaly", "Roscommon", "Sligo", "Tipperary", "Tyrone", "Waterford", "Westmeath", "Wexford", "Wicklow"})
        Me.cboAddress.Location = New System.Drawing.Point(380, 75)
        Me.cboAddress.Name = "cboAddress"
        Me.cboAddress.Size = New System.Drawing.Size(158, 21)
        Me.cboAddress.TabIndex = 14
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(293, 105)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(81, 13)
        Me.lblPhone.TabIndex = 15
        Me.lblPhone.Text = "Phone Number:"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(380, 102)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(158, 20)
        Me.txtPhone.TabIndex = 16
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(380, 128)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(158, 20)
        Me.txtEmail.TabIndex = 18
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(293, 131)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 17
        Me.lblEmail.Text = "Email:"
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Location = New System.Drawing.Point(293, 157)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(38, 13)
        Me.lblNotes.TabIndex = 19
        Me.lblNotes.Text = "Notes:"
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(380, 154)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(158, 102)
        Me.txtNotes.TabIndex = 20
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(49, 233)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 21
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(161, 233)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 22
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblBirthCountry
        '
        Me.lblBirthCountry.AutoSize = True
        Me.lblBirthCountry.Location = New System.Drawing.Point(11, 154)
        Me.lblBirthCountry.Name = "lblBirthCountry"
        Me.lblBirthCountry.Size = New System.Drawing.Size(82, 13)
        Me.lblBirthCountry.TabIndex = 24
        Me.lblBirthCountry.Text = "Country of Birth:"
        '
        'cboBirthCountry
        '
        Me.cboBirthCountry.FormattingEnabled = True
        Me.cboBirthCountry.Items.AddRange(New Object() {"Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua & Deps", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Central African Rep", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo", "Congo {Democratic Rep}", "Costa Rica", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Ivory Coast", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea North", "Korea South", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Macedonia", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar, {Burma}", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russian Federation", "Rwanda", "St Kitts & Nevis", "St Lucia", "Saint Vincent & the Grenadines", "Samoa", "San Marino", "Sao Tome & Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Sudan", "Spain", "Sri Lanka", "Sudan", "Suriname", "Swaziland", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tonga", "Trinidad & Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe"})
        Me.cboBirthCountry.Location = New System.Drawing.Point(98, 151)
        Me.cboBirthCountry.Name = "cboBirthCountry"
        Me.cboBirthCountry.Size = New System.Drawing.Size(158, 21)
        Me.cboBirthCountry.TabIndex = 23
        '
        'lblBirthCounty
        '
        Me.lblBirthCounty.AutoSize = True
        Me.lblBirthCounty.Location = New System.Drawing.Point(11, 181)
        Me.lblBirthCounty.Name = "lblBirthCounty"
        Me.lblBirthCounty.Size = New System.Drawing.Size(79, 13)
        Me.lblBirthCounty.TabIndex = 25
        Me.lblBirthCounty.Text = "County of Birth:"
        '
        'cboBirthCounty
        '
        Me.cboBirthCounty.FormattingEnabled = True
        Me.cboBirthCounty.Items.AddRange(New Object() {"Antrim", "Armagh", "Carlow", "Cavan", "Clare", "Cork", "Derry", "Donegal", "Down", "Dublin", "Fermanagh", "Galway", "Kerry", "Kildare", "Kilkenny", "Laois", "Leitrim", "Limerick", "Longford", "Louth", "Mayo", "Meath", "Monaghan", "Offaly", "Roscommon", "Sligo", "Tipperary", "Tyrone", "Waterford", "Westmeath", "Wexford", "Wicklow"})
        Me.cboBirthCounty.Location = New System.Drawing.Point(98, 178)
        Me.cboBirthCounty.Name = "cboBirthCounty"
        Me.cboBirthCounty.Size = New System.Drawing.Size(158, 21)
        Me.cboBirthCounty.TabIndex = 26
        '
        'lblManditory1
        '
        Me.lblManditory1.AutoSize = True
        Me.lblManditory1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManditory1.Location = New System.Drawing.Point(262, 23)
        Me.lblManditory1.Name = "lblManditory1"
        Me.lblManditory1.Size = New System.Drawing.Size(15, 20)
        Me.lblManditory1.TabIndex = 27
        Me.lblManditory1.Text = "*"
        '
        'lblManditory2
        '
        Me.lblManditory2.AutoSize = True
        Me.lblManditory2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManditory2.Location = New System.Drawing.Point(262, 47)
        Me.lblManditory2.Name = "lblManditory2"
        Me.lblManditory2.Size = New System.Drawing.Size(15, 20)
        Me.lblManditory2.TabIndex = 28
        Me.lblManditory2.Text = "*"
        '
        'lblManditory3
        '
        Me.lblManditory3.AutoSize = True
        Me.lblManditory3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManditory3.Location = New System.Drawing.Point(262, 98)
        Me.lblManditory3.Name = "lblManditory3"
        Me.lblManditory3.Size = New System.Drawing.Size(15, 20)
        Me.lblManditory3.TabIndex = 29
        Me.lblManditory3.Text = "*"
        '
        'lblManditory4
        '
        Me.lblManditory4.AutoSize = True
        Me.lblManditory4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManditory4.Location = New System.Drawing.Point(262, 126)
        Me.lblManditory4.Name = "lblManditory4"
        Me.lblManditory4.Size = New System.Drawing.Size(15, 20)
        Me.lblManditory4.TabIndex = 30
        Me.lblManditory4.Text = "*"
        '
        'lblManditory5
        '
        Me.lblManditory5.AutoSize = True
        Me.lblManditory5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManditory5.Location = New System.Drawing.Point(544, 23)
        Me.lblManditory5.Name = "lblManditory5"
        Me.lblManditory5.Size = New System.Drawing.Size(15, 20)
        Me.lblManditory5.TabIndex = 31
        Me.lblManditory5.Text = "*"
        '
        'lblManditory6
        '
        Me.lblManditory6.AutoSize = True
        Me.lblManditory6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManditory6.Location = New System.Drawing.Point(544, 100)
        Me.lblManditory6.Name = "lblManditory6"
        Me.lblManditory6.Size = New System.Drawing.Size(15, 20)
        Me.lblManditory6.TabIndex = 32
        Me.lblManditory6.Text = "*"
        '
        'frmTrainees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 292)
        Me.Controls.Add(Me.lblManditory6)
        Me.Controls.Add(Me.lblManditory5)
        Me.Controls.Add(Me.lblManditory4)
        Me.Controls.Add(Me.lblManditory3)
        Me.Controls.Add(Me.lblManditory2)
        Me.Controls.Add(Me.lblManditory1)
        Me.Controls.Add(Me.cboBirthCounty)
        Me.Controls.Add(Me.lblBirthCounty)
        Me.Controls.Add(Me.lblBirthCountry)
        Me.Controls.Add(Me.cboBirthCountry)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.cboAddress)
        Me.Controls.Add(Me.txtNationality)
        Me.Controls.Add(Me.cboNationality)
        Me.Controls.Add(Me.txtAddress2)
        Me.Controls.Add(Me.txtAddress1)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.rdoFemale)
        Me.Controls.Add(Me.rdoMale)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.dtpDateOfBirth)
        Me.Controls.Add(Me.lblDateOfBirth)
        Me.Controls.Add(Me.lblLastname)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.lblFirstname)
        Me.Controls.Add(Me.txtFirstname)
        Me.Name = "frmTrainees"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFirstname As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstname As System.Windows.Forms.Label
    Friend WithEvents lblLastname As System.Windows.Forms.Label
    Friend WithEvents txtLastname As System.Windows.Forms.TextBox
    Friend WithEvents lblDateOfBirth As System.Windows.Forms.Label
    Friend WithEvents dtpDateOfBirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents rdoMale As System.Windows.Forms.RadioButton
    Friend WithEvents rdoFemale As System.Windows.Forms.RadioButton
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents cboNationality As System.Windows.Forms.ComboBox
    Friend WithEvents txtNationality As System.Windows.Forms.Label
    Friend WithEvents cboAddress As System.Windows.Forms.ComboBox
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblBirthCountry As System.Windows.Forms.Label
    Friend WithEvents cboBirthCountry As System.Windows.Forms.ComboBox
    Friend WithEvents lblBirthCounty As System.Windows.Forms.Label
    Friend WithEvents cboBirthCounty As System.Windows.Forms.ComboBox
    Friend WithEvents lblManditory1 As System.Windows.Forms.Label
    Friend WithEvents lblManditory2 As System.Windows.Forms.Label
    Friend WithEvents lblManditory3 As System.Windows.Forms.Label
    Friend WithEvents lblManditory4 As System.Windows.Forms.Label
    Friend WithEvents lblManditory5 As System.Windows.Forms.Label
    Friend WithEvents lblManditory6 As System.Windows.Forms.Label

End Class
