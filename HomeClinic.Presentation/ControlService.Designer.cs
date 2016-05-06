namespace HomeClinic.Presentation
{
    partial class ControlService
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
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.lblServiceDescription = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtRegistrationDate = new System.Windows.Forms.TextBox();
            this.lblRegistrationDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(6, 101);
            this.txtClientName.MaxLength = 100;
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(593, 29);
            this.txtClientName.TabIndex = 52;
            // 
            // lblServiceDescription
            // 
            this.lblServiceDescription.AutoSize = true;
            this.lblServiceDescription.Location = new System.Drawing.Point(4, 77);
            this.lblServiceDescription.Name = "lblServiceDescription";
            this.lblServiceDescription.Size = new System.Drawing.Size(157, 21);
            this.lblServiceDescription.TabIndex = 53;
            this.lblServiceDescription.Text = "Descriçao do Serviço:";
            // 
            // txtCode
            // 
            this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode.Location = new System.Drawing.Point(6, 34);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(97, 29);
            this.txtCode.TabIndex = 51;
            this.txtCode.TabStop = false;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(4, 10);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(63, 21);
            this.lblCode.TabIndex = 50;
            this.lblCode.Text = "Código:";
            // 
            // txtRegistrationDate
            // 
            this.txtRegistrationDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegistrationDate.Location = new System.Drawing.Point(127, 34);
            this.txtRegistrationDate.Name = "txtRegistrationDate";
            this.txtRegistrationDate.ReadOnly = true;
            this.txtRegistrationDate.Size = new System.Drawing.Size(128, 29);
            this.txtRegistrationDate.TabIndex = 54;
            this.txtRegistrationDate.TabStop = false;
            // 
            // lblRegistrationDate
            // 
            this.lblRegistrationDate.AutoSize = true;
            this.lblRegistrationDate.Location = new System.Drawing.Point(123, 10);
            this.lblRegistrationDate.Name = "lblRegistrationDate";
            this.lblRegistrationDate.Size = new System.Drawing.Size(122, 21);
            this.lblRegistrationDate.TabIndex = 55;
            this.lblRegistrationDate.Text = "Data Atualizado:";
            // 
            // ControlService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtRegistrationDate);
            this.Controls.Add(this.lblRegistrationDate);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.lblServiceDescription);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ControlService";
            this.Size = new System.Drawing.Size(611, 592);
            this.Load += new System.EventHandler(this.ControlService_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label lblServiceDescription;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtRegistrationDate;
        private System.Windows.Forms.Label lblRegistrationDate;
    }
}
