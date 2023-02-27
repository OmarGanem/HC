namespace HC
{
    partial class FrmPatient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbcPatient = new System.Windows.Forms.TabControl();
            this.tbpPersonalData = new System.Windows.Forms.TabPage();
            this.tbpAddress = new System.Windows.Forms.TabPage();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.mthCalInternDate = new System.Windows.Forms.MonthCalendar();
            this.lblInternDate = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.ComboBox();
            this.lblOccupation = new System.Windows.Forms.Label();
            this.txtOccupation = new System.Windows.Forms.ComboBox();
            this.lblaMaritalSatus = new System.Windows.Forms.Label();
            this.txtMaritalStatus = new System.Windows.Forms.ComboBox();
            this.lblSchoolLevel = new System.Windows.Forms.Label();
            this.txtScoolLevel = new System.Windows.Forms.ComboBox();
            this.lblRace = new System.Windows.Forms.Label();
            this.txtRace = new System.Windows.Forms.ComboBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblInternalNumber = new System.Windows.Forms.Label();
            this.txtIntenalNumber = new System.Windows.Forms.TextBox();
            this.lblExternalNumber = new System.Windows.Forms.Label();
            this.txtExternalNumber = new System.Windows.Forms.TextBox();
            this.District = new System.Windows.Forms.Label();
            this.txtDistrict = new System.Windows.Forms.TextBox();
            this.tbcPatient.SuspendLayout();
            this.tbpPersonalData.SuspendLayout();
            this.tbpAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcPatient
            // 
            this.tbcPatient.Controls.Add(this.tbpPersonalData);
            this.tbcPatient.Controls.Add(this.tbpAddress);
            this.tbcPatient.Location = new System.Drawing.Point(12, 12);
            this.tbcPatient.Name = "tbcPatient";
            this.tbcPatient.SelectedIndex = 0;
            this.tbcPatient.Size = new System.Drawing.Size(587, 448);
            this.tbcPatient.TabIndex = 0;
            // 
            // tbpPersonalData
            // 
            this.tbpPersonalData.Controls.Add(this.txtRace);
            this.tbpPersonalData.Controls.Add(this.txtScoolLevel);
            this.tbpPersonalData.Controls.Add(this.txtMaritalStatus);
            this.tbpPersonalData.Controls.Add(this.txtOccupation);
            this.tbpPersonalData.Controls.Add(this.txtGender);
            this.tbpPersonalData.Controls.Add(this.mthCalInternDate);
            this.tbpPersonalData.Controls.Add(this.lblRace);
            this.tbpPersonalData.Controls.Add(this.txtPhone);
            this.tbpPersonalData.Controls.Add(this.lblSchoolLevel);
            this.tbpPersonalData.Controls.Add(this.txtName);
            this.tbpPersonalData.Controls.Add(this.lblaMaritalSatus);
            this.tbpPersonalData.Controls.Add(this.txtFileName);
            this.tbpPersonalData.Controls.Add(this.lblOccupation);
            this.tbpPersonalData.Controls.Add(this.txtId);
            this.tbpPersonalData.Controls.Add(this.lblGender);
            this.tbpPersonalData.Controls.Add(this.lblPhone);
            this.tbpPersonalData.Controls.Add(this.lblName);
            this.tbpPersonalData.Controls.Add(this.lblFileName);
            this.tbpPersonalData.Controls.Add(this.lblInternDate);
            this.tbpPersonalData.Controls.Add(this.lblId);
            this.tbpPersonalData.Location = new System.Drawing.Point(4, 22);
            this.tbpPersonalData.Name = "tbpPersonalData";
            this.tbpPersonalData.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPersonalData.Size = new System.Drawing.Size(579, 422);
            this.tbpPersonalData.TabIndex = 0;
            this.tbpPersonalData.Text = "PersonalData";
            this.tbpPersonalData.UseVisualStyleBackColor = true;
            // 
            // tbpAddress
            // 
            this.tbpAddress.Controls.Add(this.txtDistrict);
            this.tbpAddress.Controls.Add(this.District);
            this.tbpAddress.Controls.Add(this.txtExternalNumber);
            this.tbpAddress.Controls.Add(this.lblExternalNumber);
            this.tbpAddress.Controls.Add(this.txtIntenalNumber);
            this.tbpAddress.Controls.Add(this.lblInternalNumber);
            this.tbpAddress.Controls.Add(this.txtStreet);
            this.tbpAddress.Controls.Add(this.lblStreet);
            this.tbpAddress.Location = new System.Drawing.Point(4, 22);
            this.tbpAddress.Name = "tbpAddress";
            this.tbpAddress.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAddress.Size = new System.Drawing.Size(579, 422);
            this.tbpAddress.TabIndex = 1;
            this.tbpAddress.Text = "Address";
            this.tbpAddress.UseVisualStyleBackColor = true;
            this.tbpAddress.Click += new System.EventHandler(this.tbpAddress_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(6, 20);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            this.lblId.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(121, 17);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 1;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(6, 59);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(109, 13);
            this.lblFileName.TabIndex = 0;
            this.lblFileName.Text = "NumerodeExpediente";
            this.lblFileName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(121, 56);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(100, 20);
            this.txtFileName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 92);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(121, 85);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(3, 126);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(45, 13);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "telefono";
            this.lblPhone.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(121, 119);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 1;
            this.txtPhone.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // mthCalInternDate
            // 
            this.mthCalInternDate.Location = new System.Drawing.Point(295, 20);
            this.mthCalInternDate.Name = "mthCalInternDate";
            this.mthCalInternDate.TabIndex = 2;
            // 
            // lblInternDate
            // 
            this.lblInternDate.AutoSize = true;
            this.lblInternDate.Location = new System.Drawing.Point(234, 24);
            this.lblInternDate.Name = "lblInternDate";
            this.lblInternDate.Size = new System.Drawing.Size(57, 13);
            this.lblInternDate.TabIndex = 0;
            this.lblInternDate.Text = "Fecha alta";
            this.lblInternDate.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(3, 161);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(40, 13);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "genero";
            this.lblGender.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtGender
            // 
            this.txtGender.FormattingEnabled = true;
            this.txtGender.Location = new System.Drawing.Point(121, 153);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(121, 21);
            this.txtGender.TabIndex = 3;
            this.txtGender.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblOccupation
            // 
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.Location = new System.Drawing.Point(3, 188);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(57, 13);
            this.lblOccupation.TabIndex = 0;
            this.lblOccupation.Text = "ocupacion";
            this.lblOccupation.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtOccupation
            // 
            this.txtOccupation.FormattingEnabled = true;
            this.txtOccupation.Location = new System.Drawing.Point(121, 180);
            this.txtOccupation.Name = "txtOccupation";
            this.txtOccupation.Size = new System.Drawing.Size(121, 21);
            this.txtOccupation.TabIndex = 3;
            // 
            // lblaMaritalSatus
            // 
            this.lblaMaritalSatus.AutoSize = true;
            this.lblaMaritalSatus.Location = new System.Drawing.Point(3, 215);
            this.lblaMaritalSatus.Name = "lblaMaritalSatus";
            this.lblaMaritalSatus.Size = new System.Drawing.Size(60, 13);
            this.lblaMaritalSatus.TabIndex = 0;
            this.lblaMaritalSatus.Text = "estado civil";
            this.lblaMaritalSatus.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMaritalStatus
            // 
            this.txtMaritalStatus.FormattingEnabled = true;
            this.txtMaritalStatus.Location = new System.Drawing.Point(121, 207);
            this.txtMaritalStatus.Name = "txtMaritalStatus";
            this.txtMaritalStatus.Size = new System.Drawing.Size(121, 21);
            this.txtMaritalStatus.TabIndex = 3;
            // 
            // lblSchoolLevel
            // 
            this.lblSchoolLevel.AutoSize = true;
            this.lblSchoolLevel.Location = new System.Drawing.Point(3, 242);
            this.lblSchoolLevel.Name = "lblSchoolLevel";
            this.lblSchoolLevel.Size = new System.Drawing.Size(56, 13);
            this.lblSchoolLevel.TabIndex = 0;
            this.lblSchoolLevel.Text = "Esclaridad";
            this.lblSchoolLevel.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtScoolLevel
            // 
            this.txtScoolLevel.FormattingEnabled = true;
            this.txtScoolLevel.Location = new System.Drawing.Point(121, 234);
            this.txtScoolLevel.Name = "txtScoolLevel";
            this.txtScoolLevel.Size = new System.Drawing.Size(121, 21);
            this.txtScoolLevel.TabIndex = 3;
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Location = new System.Drawing.Point(3, 269);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(31, 13);
            this.lblRace.TabIndex = 0;
            this.lblRace.Text = "Etnia";
            this.lblRace.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtRace
            // 
            this.txtRace.FormattingEnabled = true;
            this.txtRace.Location = new System.Drawing.Point(121, 261);
            this.txtRace.Name = "txtRace";
            this.txtRace.Size = new System.Drawing.Size(121, 21);
            this.txtRace.TabIndex = 3;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(20, 32);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(29, 13);
            this.lblStreet.TabIndex = 1;
            this.lblStreet.Text = "calle";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(114, 25);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(100, 20);
            this.txtStreet.TabIndex = 2;
            this.txtStreet.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // lblInternalNumber
            // 
            this.lblInternalNumber.AutoSize = true;
            this.lblInternalNumber.Location = new System.Drawing.Point(20, 58);
            this.lblInternalNumber.Name = "lblInternalNumber";
            this.lblInternalNumber.Size = new System.Drawing.Size(76, 13);
            this.lblInternalNumber.TabIndex = 1;
            this.lblInternalNumber.Text = "numero interior";
            // 
            // txtIntenalNumber
            // 
            this.txtIntenalNumber.Location = new System.Drawing.Point(114, 51);
            this.txtIntenalNumber.Name = "txtIntenalNumber";
            this.txtIntenalNumber.Size = new System.Drawing.Size(100, 20);
            this.txtIntenalNumber.TabIndex = 2;
            this.txtIntenalNumber.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // lblExternalNumber
            // 
            this.lblExternalNumber.AutoSize = true;
            this.lblExternalNumber.Location = new System.Drawing.Point(20, 84);
            this.lblExternalNumber.Name = "lblExternalNumber";
            this.lblExternalNumber.Size = new System.Drawing.Size(79, 13);
            this.lblExternalNumber.TabIndex = 1;
            this.lblExternalNumber.Text = "numero exterior";
            // 
            // txtExternalNumber
            // 
            this.txtExternalNumber.Location = new System.Drawing.Point(114, 77);
            this.txtExternalNumber.Name = "txtExternalNumber";
            this.txtExternalNumber.Size = new System.Drawing.Size(100, 20);
            this.txtExternalNumber.TabIndex = 2;
            this.txtExternalNumber.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // District
            // 
            this.District.AutoSize = true;
            this.District.Location = new System.Drawing.Point(20, 110);
            this.District.Name = "District";
            this.District.Size = new System.Drawing.Size(42, 13);
            this.District.TabIndex = 1;
            this.District.Text = "Colonia";
            this.District.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtDistrict
            // 
            this.txtDistrict.Location = new System.Drawing.Point(114, 103);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(100, 20);
            this.txtDistrict.TabIndex = 2;
            this.txtDistrict.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // FrmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 749);
            this.Controls.Add(this.tbcPatient);
            this.Name = "FrmPatient";
            this.Text = "FrmPatient";
            this.tbcPatient.ResumeLayout(false);
            this.tbpPersonalData.ResumeLayout(false);
            this.tbpPersonalData.PerformLayout();
            this.tbpAddress.ResumeLayout(false);
            this.tbpAddress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcPatient;
        private System.Windows.Forms.TabPage tbpPersonalData;
        private System.Windows.Forms.TabPage tbpAddress;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.ComboBox txtRace;
        private System.Windows.Forms.ComboBox txtScoolLevel;
        private System.Windows.Forms.ComboBox txtMaritalStatus;
        private System.Windows.Forms.ComboBox txtOccupation;
        private System.Windows.Forms.ComboBox txtGender;
        private System.Windows.Forms.MonthCalendar mthCalInternDate;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.Label lblSchoolLevel;
        private System.Windows.Forms.Label lblaMaritalSatus;
        private System.Windows.Forms.Label lblOccupation;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblInternDate;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtDistrict;
        private System.Windows.Forms.Label District;
        private System.Windows.Forms.TextBox txtExternalNumber;
        private System.Windows.Forms.Label lblExternalNumber;
        private System.Windows.Forms.TextBox txtIntenalNumber;
        private System.Windows.Forms.Label lblInternalNumber;
    }
}