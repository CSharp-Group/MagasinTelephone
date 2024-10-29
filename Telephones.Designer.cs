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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Telephones));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cboPolice = new System.Windows.Forms.ToolStripComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTypeDeRecherche = new System.Windows.Forms.Label();
            this.lblTypeDeTelephone = new System.Windows.Forms.Label();
            this.telephonePrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.telephonePrintDocument = new System.Drawing.Printing.PrintDocument();
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
            this.cboPolice.Size = new System.Drawing.Size(280, 38);
            this.cboPolice.SelectedIndexChanged += new System.EventHandler(this.cboPolice_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(770, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 298);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
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
            this.btnImprimer.Click += new System.EventHandler(this.btnImprimer_Click);
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
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(11, 81);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(759, 66);
            this.btnRecherche.TabIndex = 2;
            this.btnRecherche.Text = "Afficher le nombre de Telephone";
            this.btnRecherche.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(759, 26);
            this.textBox1.TabIndex = 1;
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
            // lblTypeDeTelephone
            // 
            this.lblTypeDeTelephone.AutoSize = true;
            this.lblTypeDeTelephone.Location = new System.Drawing.Point(12, 272);
            this.lblTypeDeTelephone.Name = "lblTypeDeTelephone";
            this.lblTypeDeTelephone.Size = new System.Drawing.Size(156, 20);
            this.lblTypeDeTelephone.TabIndex = 5;
            this.lblTypeDeTelephone.Text = "Type de Telephones:";
            // 
            // telephonePrintPreviewDialog
            // 
            this.telephonePrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.telephonePrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.telephonePrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.telephonePrintPreviewDialog.Document = this.telephonePrintDocument;
            this.telephonePrintPreviewDialog.Enabled = true;
            this.telephonePrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("telephonePrintPreviewDialog.Icon")));
            this.telephonePrintPreviewDialog.Name = "telephonePrintPreviewDialog";
            this.telephonePrintPreviewDialog.Visible = false;
            // 
            // telephonePrintDocument
            // 
            this.telephonePrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.telephonePrintDocument_PrintPage);
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
            this.Load += new System.EventHandler(this.Telephones_Load);
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
        private System.Windows.Forms.PrintPreviewDialog telephonePrintPreviewDialog;
        private System.Drawing.Printing.PrintDocument telephonePrintDocument;
    }
}

