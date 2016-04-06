namespace HomeClinic.Presentation
{
    partial class ControlList
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
            this.grdvList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdvList)).BeginInit();
            this.SuspendLayout();
            // 
            // grdvList
            // 
            this.grdvList.AllowUserToDeleteRows = false;
            this.grdvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdvList.Location = new System.Drawing.Point(3, 3);
            this.grdvList.Name = "grdvList";
            this.grdvList.ReadOnly = true;
            this.grdvList.Size = new System.Drawing.Size(605, 586);
            this.grdvList.TabIndex = 0;
            // 
            // ControlList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grdvList);
            this.Name = "ControlList";
            this.Size = new System.Drawing.Size(611, 592);
            ((System.ComponentModel.ISupportInitialize)(this.grdvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdvList;
    }
}
