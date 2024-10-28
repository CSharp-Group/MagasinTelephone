namespace MagasinTelephone
{
    partial class Telephones
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cboPolice = new System.Windows.Forms.ToolStripComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTypeDeRecherche = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.lblTypeDeTelephone = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cboPolice});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 33);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cboPolice
            // 
            this.cboPolice.Name = "cboPolice";
            this.cboPolice.Size = new System.Drawing.Size(121, 33);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 204);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 298);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 237);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // btnImprimer
            // 
            this.btnImprimer.Location = new System.Drawing.Point(12, 542);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(770, 71);
            this.btnImprimer.TabIndex = 3;
            this.btnImprimer.Text = "Imprimer la liste de Telephone";
            this.btnImprimer.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRecherche);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblTypeDeRecherche);
            this.groupBox1.Location = new System.Drawing.Point(12, 619);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 156);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche:";
            // 
            // lblTypeDeRecherche
            // 
            this.lblTypeDeRecherche.AutoSize = true;
            this.lblTypeDeRecherche.Location = new System.Drawing.Point(7, 26);
            this.lblTypeDeRecherche.Name = "lblTypeDeRecherche";
            this.lblTypeDeRecherche.Size = new System.Drawing.Size(243, 20);
            this.lblTypeDeRecherche.TabIndex = 0;
            this.lblTypeDeRecherche.Text = "Types de Telephone Rechercher:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(759, 26);
            this.textBox1.TabIndex = 1;
            // 
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(11, 81);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(759, 66);
            this.btnRecherche.TabIndex = 2;
            this.btnRecherche.Text = "Afficher le nombre de Telephone";
            this.btnRecherche.UseVisualStyleBackColor = true;
            // 
            // lblTypeDeTelephone
            // 
            this.lblTypeDeTelephone.AutoSize = true;
            this.lblTypeDeTelephone.Location = new System.Drawing.Point(12, 272);
            this.lblTypeDeTelephone.Name = "lblTypeDeTelephone";
            this.lblTypeDeTelephone.Size = new System.Drawing.Size(156, 20);
            this.lblTypeDeTelephone.TabIndex = 5;
            this.lblTypeDeTelephone.Text = "Type de Telephones:";
            // 
            // Telephones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 838);
            this.Controls.Add(this.lblTypeDeTelephone);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Telephones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telephones";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox cboPolice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTypeDeRecherche;
        private System.Windows.Forms.Label lblTypeDeTelephone;
    }
}

