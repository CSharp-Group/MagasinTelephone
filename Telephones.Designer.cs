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
            this.rtbTelephones = new System.Windows.Forms.RichTextBox();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.lblTypeDeRecherche = new System.Windows.Forms.Label();
            this.lblTypeDeTelephone = new System.Windows.Forms.Label();
            this.telephonePrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.telephonePrintDocument = new System.Drawing.Printing.PrintDocument();
            this.pbThumbnail = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cboPolice});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(533, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cboPolice
            // 
            this.cboPolice.Name = "cboPolice";
            this.cboPolice.Size = new System.Drawing.Size(280, 38);
            this.cboPolice.SelectedIndexChanged += new System.EventHandler(this.cboPolice_SelectedIndexChanged);
            // 
            // rtbTelephones
            // 
            this.rtbTelephones.Location = new System.Drawing.Point(8, 194);
            this.rtbTelephones.Margin = new System.Windows.Forms.Padding(2);
            this.rtbTelephones.Name = "rtbTelephones";
            this.rtbTelephones.ReadOnly = true;
            this.rtbTelephones.Size = new System.Drawing.Size(519, 155);
            this.rtbTelephones.TabIndex = 2;
            this.rtbTelephones.Text = "";
            this.rtbTelephones.WordWrap = false;
            // 
            // btnImprimer
            // 
            this.btnImprimer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimer.Location = new System.Drawing.Point(8, 352);
            this.btnImprimer.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(513, 46);
            this.btnImprimer.TabIndex = 3;
            this.btnImprimer.Text = "Imprimer la liste de Telephone";
            this.btnImprimer.UseVisualStyleBackColor = true;
            this.btnImprimer.Click += new System.EventHandler(this.btnImprimer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRecherche);
            this.groupBox1.Controls.Add(this.txtRecherche);
            this.groupBox1.Controls.Add(this.lblTypeDeRecherche);
            this.groupBox1.Location = new System.Drawing.Point(8, 402);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(517, 101);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche:";
            // 
            // btnRecherche
            // 
            this.btnRecherche.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecherche.Location = new System.Drawing.Point(7, 53);
            this.btnRecherche.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(506, 43);
            this.btnRecherche.TabIndex = 2;
            this.btnRecherche.Text = "Afficher le nombre de Telephone";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.Recherche);
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(7, 32);
            this.txtRecherche.Margin = new System.Windows.Forms.Padding(2);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(507, 20);
            this.txtRecherche.TabIndex = 1;
            this.txtRecherche.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRecherche_KeyDown);
            // 
            // lblTypeDeRecherche
            // 
            this.lblTypeDeRecherche.AutoSize = true;
            this.lblTypeDeRecherche.Location = new System.Drawing.Point(5, 17);
            this.lblTypeDeRecherche.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTypeDeRecherche.Name = "lblTypeDeRecherche";
            this.lblTypeDeRecherche.Size = new System.Drawing.Size(167, 13);
            this.lblTypeDeRecherche.TabIndex = 0;
            this.lblTypeDeRecherche.Text = "Types de Telephone Rechercher:";
            // 
            // lblTypeDeTelephone
            // 
            this.lblTypeDeTelephone.AutoSize = true;
            this.lblTypeDeTelephone.Location = new System.Drawing.Point(8, 177);
            this.lblTypeDeTelephone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTypeDeTelephone.Name = "lblTypeDeTelephone";
            this.lblTypeDeTelephone.Size = new System.Drawing.Size(108, 13);
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
            // pbThumbnail
            // 
            this.pbThumbnail.BackColor = System.Drawing.SystemColors.Control;
            this.pbThumbnail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbThumbnail.Image = ((System.Drawing.Image)(resources.GetObject("pbThumbnail.Image")));
            this.pbThumbnail.Location = new System.Drawing.Point(8, 23);
            this.pbThumbnail.Margin = new System.Windows.Forms.Padding(2);
            this.pbThumbnail.Name = "pbThumbnail";
            this.pbThumbnail.Size = new System.Drawing.Size(513, 151);
            this.pbThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbThumbnail.TabIndex = 1;
            this.pbThumbnail.TabStop = false;
            // 
            // Telephones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(533, 545);
            this.Controls.Add(this.lblTypeDeTelephone);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.rtbTelephones);
            this.Controls.Add(this.pbThumbnail);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Telephones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telephones";
            this.Load += new System.EventHandler(this.Telephones_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox cboPolice;
        private System.Windows.Forms.PictureBox pbThumbnail;
        private System.Windows.Forms.RichTextBox rtbTelephones;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Label lblTypeDeRecherche;
        private System.Windows.Forms.Label lblTypeDeTelephone;
        private System.Windows.Forms.PrintPreviewDialog telephonePrintPreviewDialog;
        private System.Drawing.Printing.PrintDocument telephonePrintDocument;
    }
}

