namespace HomeClinic.Presentation
{
    partial class ControlAttendance
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
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.lblClientName = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCell = new System.Windows.Forms.Label();
            this.txtCell = new System.Windows.Forms.TextBox();
            this.TxtPetName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBreed = new System.Windows.Forms.Label();
            this.lblSpecie = new System.Windows.Forms.Label();
            this.cboBreed = new System.Windows.Forms.ComboBox();
            this.cboSpecie = new System.Windows.Forms.ComboBox();
            this.lblPelage = new System.Windows.Forms.Label();
            this.txtPelage = new System.Windows.Forms.TextBox();
            this.txtColor2 = new System.Windows.Forms.TextBox();
            this.lblColor2 = new System.Windows.Forms.Label();
            this.txtColor1 = new System.Windows.Forms.TextBox();
            this.lblColor1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCode
            // 
            this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode.Location = new System.Drawing.Point(6, 24);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(97, 29);
            this.txtCode.TabIndex = 9;
            this.txtCode.TabStop = false;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(4, 0);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(63, 21);
            this.lblCode.TabIndex = 8;
            this.lblCode.Text = "Código:";
            this.lblCode.Click += new System.EventHandler(this.lblCode_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(123, 24);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(124, 29);
            this.dtpDate.TabIndex = 42;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(119, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(119, 21);
            this.lblDate.TabIndex = 41;
            this.lblDate.Text = "Data Agendada:";
            this.lblDate.Click += new System.EventHandler(this.lblRegistrationDate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 21);
            this.label2.TabIndex = 45;
            this.label2.Text = "Hora:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::HomeClinic.Presentation.Resource.add;
            this.btnAdd.Location = new System.Drawing.Point(357, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(38, 38);
            this.btnAdd.TabIndex = 47;
            this.btnAdd.TabStop = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(8, 91);
            this.txtClientName.MaxLength = 100;
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(284, 29);
            this.txtClientName.TabIndex = 48;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(4, 67);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(130, 21);
            this.lblClientName.TabIndex = 49;
            this.lblClientName.Text = "Nome do Cliente:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(317, 91);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(118, 29);
            this.txtPhone.TabIndex = 50;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(313, 67);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(70, 21);
            this.lblPhone.TabIndex = 51;
            this.lblPhone.Text = "Telefone:";
            // 
            // lblCell
            // 
            this.lblCell.AutoSize = true;
            this.lblCell.Location = new System.Drawing.Point(459, 67);
            this.lblCell.Name = "lblCell";
            this.lblCell.Size = new System.Drawing.Size(62, 21);
            this.lblCell.TabIndex = 53;
            this.lblCell.Text = "Celular:";
            // 
            // txtCell
            // 
            this.txtCell.Location = new System.Drawing.Point(463, 91);
            this.txtCell.MaxLength = 14;
            this.txtCell.Name = "txtCell";
            this.txtCell.Size = new System.Drawing.Size(136, 29);
            this.txtCell.TabIndex = 52;
            // 
            // TxtPetName
            // 
            this.TxtPetName.Location = new System.Drawing.Point(8, 156);
            this.TxtPetName.MaxLength = 100;
            this.TxtPetName.Name = "TxtPetName";
            this.TxtPetName.Size = new System.Drawing.Size(284, 29);
            this.TxtPetName.TabIndex = 54;
            this.TxtPetName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 55;
            this.label1.Text = "Nome do Animal:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.Location = new System.Drawing.Point(459, 132);
            this.lblBreed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(46, 21);
            this.lblBreed.TabIndex = 59;
            this.lblBreed.Text = "Raça:";
            // 
            // lblSpecie
            // 
            this.lblSpecie.AutoSize = true;
            this.lblSpecie.Location = new System.Drawing.Point(313, 132);
            this.lblSpecie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpecie.Name = "lblSpecie";
            this.lblSpecie.Size = new System.Drawing.Size(64, 21);
            this.lblSpecie.TabIndex = 58;
            this.lblSpecie.Text = "Espécie:";
            // 
            // cboBreed
            // 
            this.cboBreed.FormattingEnabled = true;
            this.cboBreed.Location = new System.Drawing.Point(463, 156);
            this.cboBreed.Name = "cboBreed";
            this.cboBreed.Size = new System.Drawing.Size(136, 29);
            this.cboBreed.TabIndex = 57;
            // 
            // cboSpecie
            // 
            this.cboSpecie.FormattingEnabled = true;
            this.cboSpecie.Location = new System.Drawing.Point(317, 156);
            this.cboSpecie.Name = "cboSpecie";
            this.cboSpecie.Size = new System.Drawing.Size(118, 29);
            this.cboSpecie.TabIndex = 56;
            // 
            // lblPelage
            // 
            this.lblPelage.AutoSize = true;
            this.lblPelage.Location = new System.Drawing.Point(392, 188);
            this.lblPelage.Name = "lblPelage";
            this.lblPelage.Size = new System.Drawing.Size(72, 21);
            this.lblPelage.TabIndex = 65;
            this.lblPelage.Text = "Pelagem:";
            // 
            // txtPelage
            // 
            this.txtPelage.Location = new System.Drawing.Point(396, 212);
            this.txtPelage.MaxLength = 100;
            this.txtPelage.Name = "txtPelage";
            this.txtPelage.Size = new System.Drawing.Size(201, 29);
            this.txtPelage.TabIndex = 62;
            // 
            // txtColor2
            // 
            this.txtColor2.Location = new System.Drawing.Point(201, 213);
            this.txtColor2.MaxLength = 50;
            this.txtColor2.Name = "txtColor2";
            this.txtColor2.Size = new System.Drawing.Size(175, 29);
            this.txtColor2.TabIndex = 61;
            this.txtColor2.TextChanged += new System.EventHandler(this.txtColor2_TextChanged);
            // 
            // lblColor2
            // 
            this.lblColor2.AutoSize = true;
            this.lblColor2.Location = new System.Drawing.Point(197, 188);
            this.lblColor2.Name = "lblColor2";
            this.lblColor2.Size = new System.Drawing.Size(51, 21);
            this.lblColor2.TabIndex = 64;
            this.lblColor2.Text = "Cor 2:";
            // 
            // txtColor1
            // 
            this.txtColor1.Location = new System.Drawing.Point(8, 212);
            this.txtColor1.MaxLength = 50;
            this.txtColor1.Name = "txtColor1";
            this.txtColor1.Size = new System.Drawing.Size(175, 29);
            this.txtColor1.TabIndex = 60;
            // 
            // lblColor1
            // 
            this.lblColor1.AutoSize = true;
            this.lblColor1.Location = new System.Drawing.Point(4, 188);
            this.lblColor1.Name = "lblColor1";
            this.lblColor1.Size = new System.Drawing.Size(51, 21);
            this.lblColor1.TabIndex = 63;
            this.lblColor1.Text = "Cor 1:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(109, 278);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(490, 179);
            this.dataGridView1.TabIndex = 66;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(268, 24);
            this.textBox1.MaxLength = 14;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(83, 29);
            this.textBox1.TabIndex = 67;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(8, 278);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 85);
            this.btnEdit.TabIndex = 68;
            this.btnEdit.TabStop = false;
            this.btnEdit.Text = "Adicionar Serviços";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 88);
            this.button1.TabIndex = 69;
            this.button1.TabStop = false;
            this.button1.Text = "Excluir Serviços";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 520);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 58);
            this.button2.TabIndex = 70;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(230, 520);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 58);
            this.button3.TabIndex = 71;
            this.button3.Text = "Alterar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(432, 520);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 58);
            this.button4.TabIndex = 72;
            this.button4.Text = "Excluir";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ControlAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblPelage);
            this.Controls.Add(this.txtPelage);
            this.Controls.Add(this.txtColor2);
            this.Controls.Add(this.lblColor2);
            this.Controls.Add(this.txtColor1);
            this.Controls.Add(this.lblColor1);
            this.Controls.Add(this.lblBreed);
            this.Controls.Add(this.lblSpecie);
            this.Controls.Add(this.cboBreed);
            this.Controls.Add(this.cboSpecie);
            this.Controls.Add(this.TxtPetName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCell);
            this.Controls.Add(this.txtCell);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ControlAttendance";
            this.Size = new System.Drawing.Size(611, 592);
            this.Load += new System.EventHandler(this.ControlAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCell;
        private System.Windows.Forms.TextBox txtCell;
        private System.Windows.Forms.TextBox TxtPetName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBreed;
        private System.Windows.Forms.Label lblSpecie;
        private System.Windows.Forms.ComboBox cboBreed;
        private System.Windows.Forms.ComboBox cboSpecie;
        private System.Windows.Forms.Label lblPelage;
        private System.Windows.Forms.TextBox txtPelage;
        private System.Windows.Forms.TextBox txtColor2;
        private System.Windows.Forms.Label lblColor2;
        private System.Windows.Forms.TextBox txtColor1;
        private System.Windows.Forms.Label lblColor1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}
