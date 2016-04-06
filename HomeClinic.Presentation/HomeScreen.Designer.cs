namespace HomeClinic.Presentation
{
    partial class HomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.administrativoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.medicamentoVacinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raçaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tosaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.petToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.veterinárioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.administrativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tosaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raçaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacinaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.petToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veterinárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(613, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrativoToolStripMenuItem1,
            this.clienteToolStripMenuItem1,
            this.petToolStripMenuItem1,
            this.veterinárioToolStripMenuItem1});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(67, 22);
            this.toolStripDropDownButton2.Text = "Cadastro";
            // 
            // administrativoToolStripMenuItem1
            // 
            this.administrativoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicamentoVacinaToolStripMenuItem,
            this.raçaToolStripMenuItem1,
            this.tosaToolStripMenuItem1});
            this.administrativoToolStripMenuItem1.Name = "administrativoToolStripMenuItem1";
            this.administrativoToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.administrativoToolStripMenuItem1.Text = "Administrativo";
            // 
            // medicamentoVacinaToolStripMenuItem
            // 
            this.medicamentoVacinaToolStripMenuItem.Name = "medicamentoVacinaToolStripMenuItem";
            this.medicamentoVacinaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.medicamentoVacinaToolStripMenuItem.Text = "Medicamento/Vacina";
            // 
            // raçaToolStripMenuItem1
            // 
            this.raçaToolStripMenuItem1.Name = "raçaToolStripMenuItem1";
            this.raçaToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.raçaToolStripMenuItem1.Text = "Raça";
            // 
            // tosaToolStripMenuItem1
            // 
            this.tosaToolStripMenuItem1.Name = "tosaToolStripMenuItem1";
            this.tosaToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.tosaToolStripMenuItem1.Text = "Serviço";
            this.tosaToolStripMenuItem1.Click += new System.EventHandler(this.tosaToolStripMenuItem1_Click);
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            // 
            // petToolStripMenuItem1
            // 
            this.petToolStripMenuItem1.Name = "petToolStripMenuItem1";
            this.petToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.petToolStripMenuItem1.Text = "Pet";
            this.petToolStripMenuItem1.Click += new System.EventHandler(this.petToolStripMenuItem_Click);
            // 
            // veterinárioToolStripMenuItem1
            // 
            this.veterinárioToolStripMenuItem1.Name = "veterinárioToolStripMenuItem1";
            this.veterinárioToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.veterinárioToolStripMenuItem1.Text = "Veterinário";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(48, 22);
            this.toolStripLabel3.Text = "Agenda";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(36, 22);
            this.toolStripLabel2.Text = "Inicio";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(48, 22);
            this.toolStripLabel1.Text = "Agenda";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrativoToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.petToolStripMenuItem,
            this.veterinárioToolStripMenuItem});
            this.toolStripDropDownButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(72, 22);
            this.toolStripDropDownButton1.Text = "Cadastros";
            this.toolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripDropDownButton1.ToolTipText = "Cadastrar";
            // 
            // administrativoToolStripMenuItem
            // 
            this.administrativoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tosaToolStripMenuItem,
            this.raçaToolStripMenuItem,
            this.vacinaToolStripMenuItem1});
            this.administrativoToolStripMenuItem.Name = "administrativoToolStripMenuItem";
            this.administrativoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.administrativoToolStripMenuItem.Text = "Administrativo";
            // 
            // tosaToolStripMenuItem
            // 
            this.tosaToolStripMenuItem.Name = "tosaToolStripMenuItem";
            this.tosaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.tosaToolStripMenuItem.Text = "Tosa";
            // 
            // raçaToolStripMenuItem
            // 
            this.raçaToolStripMenuItem.Name = "raçaToolStripMenuItem";
            this.raçaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.raçaToolStripMenuItem.Text = "Raça";
            // 
            // vacinaToolStripMenuItem1
            // 
            this.vacinaToolStripMenuItem1.Name = "vacinaToolStripMenuItem1";
            this.vacinaToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.vacinaToolStripMenuItem1.Text = "Medicamento/Vacina";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // petToolStripMenuItem
            // 
            this.petToolStripMenuItem.Name = "petToolStripMenuItem";
            this.petToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.petToolStripMenuItem.Text = "Pet";
            this.petToolStripMenuItem.Click += new System.EventHandler(this.petToolStripMenuItem_Click);
            // 
            // veterinárioToolStripMenuItem
            // 
            this.veterinárioToolStripMenuItem.Name = "veterinárioToolStripMenuItem";
            this.veterinárioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.veterinárioToolStripMenuItem.Text = "Veterinário";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 592);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 624);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pet Shop";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem administrativoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tosaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raçaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacinaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem petToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veterinárioToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem administrativoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem medicamentoVacinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raçaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tosaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem petToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem veterinárioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
    }
}

