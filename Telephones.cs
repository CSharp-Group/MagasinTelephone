using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        #region Recherche
        private int _lastSearchIndex = 0;
        private string _lastSearchString = string.Empty;

        private void Recherche(object sender, EventArgs e)
        {
            string searchText = txtRecherche.Text;

            if (searchText != _lastSearchString)
            {
                _lastSearchIndex = 0;
                _lastSearchString = searchText;
            }
            else
            {
                // Move the index to the next character after the last found instance.
                _lastSearchIndex += searchText.Length;
            }

            int index = rtbTelephones.Find(searchText, _lastSearchIndex, RichTextBoxFinds.None);

            // If no match was found, search from the beginning.
            if (index < 0)
            {
                index = rtbTelephones.Find(searchText, 0, RichTextBoxFinds.None);
            }

            // Determine whether the text was found in rtbTelephones.
            if (index >= 0)
            {
                // Select the found text.
                rtbTelephones.Select(index, txtRecherche.Text.Length);
                rtbTelephones.Focus();

                // Update the index.
                _lastSearchIndex = index;
            }
            else
            {
                // Display a message box indicating that the text was not found.
                MessageBox.Show("Text was not found.");
                _lastSearchIndex = 0; // Reset the index.
            }
        }
        private void txtRecherche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Recherche(sender, e);
            }
        }
        #endregion
    }
}
