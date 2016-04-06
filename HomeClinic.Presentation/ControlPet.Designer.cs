namespace HomeClinic.Presentation
{
    partial class ControlPet
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblRegistrationDate = new System.Windows.Forms.Label();
            this.txtRegistrationDate = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblAges = new System.Windows.Forms.Label();
            this.txtAges = new System.Windows.Forms.TextBox();
            this.lblOwner = new System.Windows.Forms.Label();
            this.cboOwner = new System.Windows.Forms.ComboBox();
            this.txtColor1 = new System.Windows.Forms.TextBox();
            this.lblColor1 = new System.Windows.Forms.Label();
            this.txtColor2 = new System.Windows.Forms.TextBox();
            this.lblColor2 = new System.Windows.Forms.Label();
            this.txtPelage = new System.Windows.Forms.TextBox();
            this.lblPelage = new System.Windows.Forms.Label();
            this.txtAdditionalInformation = new System.Windows.Forms.TextBox();
            this.lblAdditionalInformation = new System.Windows.Forms.Label();
            this.btnAppointmentHistory = new System.Windows.Forms.Button();
            this.btnVaccinesHistory = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cboAnimalStatus = new System.Windows.Forms.ComboBox();
            this.lblAnimalStatus = new System.Windows.Forms.Label();
            this.txtPedigreeNumber = new System.Windows.Forms.TextBox();
            this.lblPedigreeNumber = new System.Windows.Forms.Label();
            this.lblScale = new System.Windows.Forms.Label();
            this.cboScale = new System.Windows.Forms.ComboBox();
            this.lblBreed = new System.Windows.Forms.Label();
            this.lblSpecie = new System.Windows.Forms.Label();
            this.cboBreed = new System.Windows.Forms.ComboBox();
            this.cboSpecie = new System.Windows.Forms.ComboBox();
            this.chkCastrated = new System.Windows.Forms.CheckBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(9, 6);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(63, 21);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Código:";
            // 
            // txtCode
            // 
            this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode.Location = new System.Drawing.Point(11, 30);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(64, 29);
            this.txtCode.TabIndex = 1;
            this.txtCode.TabStop = false;
            // 
            // lblRegistrationDate
            // 
            this.lblRegistrationDate.AutoSize = true;
            this.lblRegistrationDate.Location = new System.Drawing.Point(91, 6);
            this.lblRegistrationDate.Name = "lblRegistrationDate";
            this.lblRegistrationDate.Size = new System.Drawing.Size(132, 21);
            this.lblRegistrationDate.TabIndex = 2;
            this.lblRegistrationDate.Text = "Data de Cadastro:";
            // 
            // txtRegistrationDate
            // 
            this.txtRegistrationDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegistrationDate.Location = new System.Drawing.Point(95, 30);
            this.txtRegistrationDate.Name = "txtRegistrationDate";
            this.txtRegistrationDate.ReadOnly = true;
            this.txtRegistrationDate.Size = new System.Drawing.Size(128, 29);
            this.txtRegistrationDate.TabIndex = 2;
            this.txtRegistrationDate.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(243, 30);
            this.txtName.MaxLength = 100;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(359, 29);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(239, 6);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 21);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Nome:";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(11, 90);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(148, 29);
            this.dtpDateOfBirth.TabIndex = 2;
            this.dtpDateOfBirth.Value = new System.DateTime(2016, 3, 31, 11, 44, 38, 0);
            this.dtpDateOfBirth.Leave += new System.EventHandler(this.dtpDateOfBirth_Leave);
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(9, 66);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(153, 21);
            this.lblDateOfBirth.TabIndex = 7;
            this.lblDateOfBirth.Text = "Data de Nascimento:";
            // 
            // lblAges
            // 
            this.lblAges.AutoSize = true;
            this.lblAges.Location = new System.Drawing.Point(175, 66);
            this.lblAges.Name = "lblAges";
            this.lblAges.Size = new System.Drawing.Size(51, 21);
            this.lblAges.TabIndex = 9;
            this.lblAges.Text = "Idade:";
            // 
            // txtAges
            // 
            this.txtAges.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAges.Location = new System.Drawing.Point(179, 90);
            this.txtAges.Name = "txtAges";
            this.txtAges.ReadOnly = true;
            this.txtAges.Size = new System.Drawing.Size(90, 29);
            this.txtAges.TabIndex = 10;
            this.txtAges.TabStop = false;
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Location = new System.Drawing.Point(286, 66);
            this.lblOwner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(96, 21);
            this.lblOwner.TabIndex = 11;
            this.lblOwner.Text = "Proprietário:";
            // 
            // cboOwner
            // 
            this.cboOwner.FormattingEnabled = true;
            this.cboOwner.Location = new System.Drawing.Point(289, 90);
            this.cboOwner.Name = "cboOwner";
            this.cboOwner.Size = new System.Drawing.Size(274, 29);
            this.cboOwner.TabIndex = 3;
            // 
            // txtColor1
            // 
            this.txtColor1.Location = new System.Drawing.Point(11, 215);
            this.txtColor1.MaxLength = 50;
            this.txtColor1.Name = "txtColor1";
            this.txtColor1.Size = new System.Drawing.Size(175, 29);
            this.txtColor1.TabIndex = 8;
            // 
            // lblColor1
            // 
            this.lblColor1.AutoSize = true;
            this.lblColor1.Location = new System.Drawing.Point(9, 191);
            this.lblColor1.Name = "lblColor1";
            this.lblColor1.Size = new System.Drawing.Size(51, 21);
            this.lblColor1.TabIndex = 17;
            this.lblColor1.Text = "Cor 1:";
            // 
            // txtColor2
            // 
            this.txtColor2.Location = new System.Drawing.Point(206, 215);
            this.txtColor2.MaxLength = 50;
            this.txtColor2.Name = "txtColor2";
            this.txtColor2.Size = new System.Drawing.Size(175, 29);
            this.txtColor2.TabIndex = 9;
            // 
            // lblColor2
            // 
            this.lblColor2.AutoSize = true;
            this.lblColor2.Location = new System.Drawing.Point(202, 191);
            this.lblColor2.Name = "lblColor2";
            this.lblColor2.Size = new System.Drawing.Size(51, 21);
            this.lblColor2.TabIndex = 19;
            this.lblColor2.Text = "Cor 2:";
            // 
            // txtPelage
            // 
            this.txtPelage.Location = new System.Drawing.Point(401, 215);
            this.txtPelage.MaxLength = 100;
            this.txtPelage.Name = "txtPelage";
            this.txtPelage.Size = new System.Drawing.Size(201, 29);
            this.txtPelage.TabIndex = 10;
            // 
            // lblPelage
            // 
            this.lblPelage.AutoSize = true;
            this.lblPelage.Location = new System.Drawing.Point(397, 191);
            this.lblPelage.Name = "lblPelage";
            this.lblPelage.Size = new System.Drawing.Size(72, 21);
            this.lblPelage.TabIndex = 22;
            this.lblPelage.Text = "Pelagem:";
            // 
            // txtAdditionalInformation
            // 
            this.txtAdditionalInformation.Location = new System.Drawing.Point(11, 343);
            this.txtAdditionalInformation.Multiline = true;
            this.txtAdditionalInformation.Name = "txtAdditionalInformation";
            this.txtAdditionalInformation.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtAdditionalInformation.Size = new System.Drawing.Size(591, 150);
            this.txtAdditionalInformation.TabIndex = 14;
            // 
            // lblAdditionalInformation
            // 
            this.lblAdditionalInformation.AutoSize = true;
            this.lblAdditionalInformation.Location = new System.Drawing.Point(9, 319);
            this.lblAdditionalInformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdditionalInformation.Name = "lblAdditionalInformation";
            this.lblAdditionalInformation.Size = new System.Drawing.Size(174, 21);
            this.lblAdditionalInformation.TabIndex = 29;
            this.lblAdditionalInformation.Text = "Informações Adicionais:";
            // 
            // btnAppointmentHistory
            // 
            this.btnAppointmentHistory.Location = new System.Drawing.Point(11, 499);
            this.btnAppointmentHistory.Name = "btnAppointmentHistory";
            this.btnAppointmentHistory.Size = new System.Drawing.Size(193, 50);
            this.btnAppointmentHistory.TabIndex = 30;
            this.btnAppointmentHistory.TabStop = false;
            this.btnAppointmentHistory.Text = "Histórico de Consultas";
            this.btnAppointmentHistory.UseVisualStyleBackColor = true;
            this.btnAppointmentHistory.Visible = false;
            this.btnAppointmentHistory.Click += new System.EventHandler(this.btnAppointmentHistory_Click);
            // 
            // btnVaccinesHistory
            // 
            this.btnVaccinesHistory.Location = new System.Drawing.Point(210, 499);
            this.btnVaccinesHistory.Name = "btnVaccinesHistory";
            this.btnVaccinesHistory.Size = new System.Drawing.Size(193, 50);
            this.btnVaccinesHistory.TabIndex = 31;
            this.btnVaccinesHistory.TabStop = false;
            this.btnVaccinesHistory.Text = "Histórico de Vacinas/Vermífugos";
            this.btnVaccinesHistory.UseVisualStyleBackColor = true;
            this.btnVaccinesHistory.Visible = false;
            this.btnVaccinesHistory.Click += new System.EventHandler(this.btnVaccinesHistory_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(252, 555);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 33);
            this.btnSave.TabIndex = 32;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(252, 555);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(109, 33);
            this.btnEdit.TabIndex = 33;
            this.btnEdit.TabStop = false;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cboAnimalStatus
            // 
            this.cboAnimalStatus.FormattingEnabled = true;
            this.cboAnimalStatus.Location = new System.Drawing.Point(421, 279);
            this.cboAnimalStatus.Name = "cboAnimalStatus";
            this.cboAnimalStatus.Size = new System.Drawing.Size(181, 29);
            this.cboAnimalStatus.TabIndex = 13;
            // 
            // lblAnimalStatus
            // 
            this.lblAnimalStatus.AutoSize = true;
            this.lblAnimalStatus.Location = new System.Drawing.Point(417, 255);
            this.lblAnimalStatus.Name = "lblAnimalStatus";
            this.lblAnimalStatus.Size = new System.Drawing.Size(130, 21);
            this.lblAnimalStatus.TabIndex = 35;
            this.lblAnimalStatus.Text = "Status do Animal:";
            // 
            // txtPedigreeNumber
            // 
            this.txtPedigreeNumber.Location = new System.Drawing.Point(11, 279);
            this.txtPedigreeNumber.Name = "txtPedigreeNumber";
            this.txtPedigreeNumber.Size = new System.Drawing.Size(222, 29);
            this.txtPedigreeNumber.TabIndex = 11;
            // 
            // lblPedigreeNumber
            // 
            this.lblPedigreeNumber.AutoSize = true;
            this.lblPedigreeNumber.Location = new System.Drawing.Point(9, 255);
            this.lblPedigreeNumber.Name = "lblPedigreeNumber";
            this.lblPedigreeNumber.Size = new System.Drawing.Size(157, 21);
            this.lblPedigreeNumber.TabIndex = 37;
            this.lblPedigreeNumber.Text = "Número do Pedigree:";
            // 
            // lblScale
            // 
            this.lblScale.AutoSize = true;
            this.lblScale.Location = new System.Drawing.Point(249, 255);
            this.lblScale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScale.Name = "lblScale";
            this.lblScale.Size = new System.Drawing.Size(49, 21);
            this.lblScale.TabIndex = 39;
            this.lblScale.Text = "Porte:";
            // 
            // cboScale
            // 
            this.cboScale.FormattingEnabled = true;
            this.cboScale.Location = new System.Drawing.Point(253, 279);
            this.cboScale.Name = "cboScale";
            this.cboScale.Size = new System.Drawing.Size(148, 29);
            this.cboScale.TabIndex = 12;
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.Location = new System.Drawing.Point(423, 129);
            this.lblBreed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(46, 21);
            this.lblBreed.TabIndex = 46;
            this.lblBreed.Text = "Raça:";
            // 
            // lblSpecie
            // 
            this.lblSpecie.AutoSize = true;
            this.lblSpecie.Location = new System.Drawing.Point(248, 129);
            this.lblSpecie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpecie.Name = "lblSpecie";
            this.lblSpecie.Size = new System.Drawing.Size(64, 21);
            this.lblSpecie.TabIndex = 45;
            this.lblSpecie.Text = "Espécie:";
            // 
            // cboBreed
            // 
            this.cboBreed.FormattingEnabled = true;
            this.cboBreed.Location = new System.Drawing.Point(424, 153);
            this.cboBreed.Name = "cboBreed";
            this.cboBreed.Size = new System.Drawing.Size(178, 29);
            this.cboBreed.TabIndex = 7;
            // 
            // cboSpecie
            // 
            this.cboSpecie.FormattingEnabled = true;
            this.cboSpecie.Location = new System.Drawing.Point(252, 153);
            this.cboSpecie.Name = "cboSpecie";
            this.cboSpecie.Size = new System.Drawing.Size(152, 29);
            this.cboSpecie.TabIndex = 6;
            // 
            // chkCastrated
            // 
            this.chkCastrated.AutoSize = true;
            this.chkCastrated.Location = new System.Drawing.Point(141, 155);
            this.chkCastrated.Name = "chkCastrated";
            this.chkCastrated.Size = new System.Drawing.Size(91, 25);
            this.chkCastrated.TabIndex = 5;
            this.chkCastrated.Text = "Castrado";
            this.chkCastrated.UseVisualStyleBackColor = true;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(9, 129);
            this.lblSex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(46, 21);
            this.lblSex.TabIndex = 44;
            this.lblSex.Text = "Sexo:";
            // 
            // cboSex
            // 
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Location = new System.Drawing.Point(11, 153);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(110, 29);
            this.cboSex.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(409, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 50);
            this.button1.TabIndex = 47;
            this.button1.TabStop = false;
            this.button1.Text = "Histórico de Serviços";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::HomeClinic.Presentation.Resource.add;
            this.btnAdd.Location = new System.Drawing.Point(564, 84);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(38, 38);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.TabStop = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ControlPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblBreed);
            this.Controls.Add(this.lblSpecie);
            this.Controls.Add(this.cboBreed);
            this.Controls.Add(this.cboSpecie);
            this.Controls.Add(this.chkCastrated);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.cboSex);
            this.Controls.Add(this.lblScale);
            this.Controls.Add(this.cboScale);
            this.Controls.Add(this.txtPedigreeNumber);
            this.Controls.Add(this.lblPedigreeNumber);
            this.Controls.Add(this.lblAnimalStatus);
            this.Controls.Add(this.cboAnimalStatus);
            this.Controls.Add(this.btnVaccinesHistory);
            this.Controls.Add(this.btnAppointmentHistory);
            this.Controls.Add(this.lblAdditionalInformation);
            this.Controls.Add(this.txtAdditionalInformation);
            this.Controls.Add(this.lblPelage);
            this.Controls.Add(this.txtPelage);
            this.Controls.Add(this.txtColor2);
            this.Controls.Add(this.lblColor2);
            this.Controls.Add(this.txtColor1);
            this.Controls.Add(this.lblColor1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboOwner);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.txtAges);
            this.Controls.Add(this.lblAges);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtRegistrationDate);
            this.Controls.Add(this.lblRegistrationDate);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ControlPet";
            this.Size = new System.Drawing.Size(611, 592);
            this.Load += new System.EventHandler(this.RegisterPet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblRegistrationDate;
        private System.Windows.Forms.TextBox txtRegistrationDate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblAges;
        private System.Windows.Forms.TextBox txtAges;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.ComboBox cboOwner;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtColor1;
        private System.Windows.Forms.Label lblColor1;
        private System.Windows.Forms.TextBox txtColor2;
        private System.Windows.Forms.Label lblColor2;
        private System.Windows.Forms.TextBox txtPelage;
        private System.Windows.Forms.Label lblPelage;
        private System.Windows.Forms.TextBox txtAdditionalInformation;
        private System.Windows.Forms.Label lblAdditionalInformation;
        private System.Windows.Forms.Button btnAppointmentHistory;
        private System.Windows.Forms.Button btnVaccinesHistory;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cboAnimalStatus;
        private System.Windows.Forms.Label lblAnimalStatus;
        private System.Windows.Forms.TextBox txtPedigreeNumber;
        private System.Windows.Forms.Label lblPedigreeNumber;
        private System.Windows.Forms.Label lblScale;
        private System.Windows.Forms.ComboBox cboScale;
        private System.Windows.Forms.Label lblBreed;
        private System.Windows.Forms.Label lblSpecie;
        private System.Windows.Forms.ComboBox cboBreed;
        private System.Windows.Forms.ComboBox cboSpecie;
        private System.Windows.Forms.CheckBox chkCastrated;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.Button button1;
    }
}
