using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagasinTelephone
{
    public partial class Telephones : Form
    {
        public Telephones()
        {
            InitializeComponent();
        }

        private void Telephones_Load(object sender, EventArgs e)
        {
            string currentDirectory = Environment.CurrentDirectory;
            string projectDirectory = System.IO.Directory.GetParent(currentDirectory).Parent.FullName;
            string filePath = projectDirectory + "\\Data\\Telephones.rtf";
            rtbTelephones.LoadFile(filePath);
            AfficherPolicesInstallées(sender, e)
        }

        private void telephonePrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //AntiAlias
            Graphics g = this.CreateGraphics();
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Font enteteFont, detailsFont, listeFont, sousTitreFont;

            enteteFont = new Font("Segoe UI", 24, FontStyle.Bold);
            detailsFont = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
            listeFont = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            sousTitreFont = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);

            Single hauteurPoliceEnteteSingle = enteteFont.GetHeight(e.Graphics);
            Single hauteurPoliceDetailSingle = detailsFont.GetHeight(e.Graphics);

            Image image = pbThumbnail.Image;
            string titreStr = "Marques de téléphones";
            string listeMarquesStr = "Marques: ";
            string listeNomStr = "Nom: ";
            Single largeurTitreSingle = e.Graphics.MeasureString(titreStr, enteteFont).Width;
            Single hauteurListeMarquesSingle = e.Graphics.MeasureString(listeMarquesStr, listeFont).Height;
            Single hauteurListeNomSingle = e.Graphics.MeasureString(listeNomStr, listeFont).Height;

            float xFloat = e.MarginBounds.X;
            float yFloat = e.MarginBounds.Y;

            float imgWidth, imgHeight, imgCenterX;

            float imgRatio = (float)image.Width / (float)image.Height;
            imgWidth = 500;
            imgHeight = imgWidth / imgRatio;
            imgCenterX = (e.PageBounds.Width / 2) - (imgWidth / 2);


            float logoX = e.MarginBounds.X + (e.MarginBounds.Width - image.Width * 2) / 2;
            
            
            yFloat += hauteurPoliceEnteteSingle + 10; 
            e.Graphics.DrawImage(image, imgCenterX, yFloat, imgWidth, imgHeight);
            yFloat += imgHeight + 10;

            float titreCentreFloat = (e.PageBounds.Width / 2) - (largeurTitreSingle / 2);

            e.Graphics.DrawString(titreStr, enteteFont, Brushes.Blue, titreCentreFloat, yFloat);
            yFloat += hauteurPoliceEnteteSingle + 5;
            e.Graphics.DrawLine(new Pen(Color.Blue, 0.4F), titreCentreFloat, yFloat, titreCentreFloat + largeurTitreSingle, yFloat);

            yFloat += 30;

            e.Graphics.DrawString(listeMarquesStr, sousTitreFont, Brushes.Coral, xFloat, yFloat);
            e.Graphics.DrawString(listeNomStr, sousTitreFont, Brushes.Coral, xFloat + 198, yFloat);

            yFloat += 30;

            foreach (string line in rtbTelephones.Lines)
            {
                e.Graphics.DrawString(line, listeFont, Brushes.Black, xFloat, yFloat);
                yFloat += detailsFont.GetHeight(e.Graphics) + 5; 
            }

        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            telephonePrintPreviewDialog.ShowDialog();
        }


        #region AfficherPolicesInstallées
        private void AfficherPolicesInstallées(object sender, EventArgs e)
        {
            try
            {
                FontFamily[] fontFamilies;
                InstalledFontCollection installedFontCollection = new InstalledFontCollection();

                fontFamilies = installedFontCollection.Families;

                foreach (FontFamily fontFamily in fontFamilies)
                {
                    cboPolice.Items.Add(fontFamily.Name);
                }

                cboPolice.SelectedIndex = cboPolice.Items.IndexOf(richTextBox1.Font.FontFamily.Name);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur: {ex.Message}", "Erreur pendant l'affichage des polices installées");
            }
        }
        #endregion

        private void cboPolice_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedFont = cboPolice.SelectedItem.ToString();
                richTextBox1.Font = new Font(selectedFont, 12);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'application de la police : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
