using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace SL_SM_Manager
{
    public partial class Facebook : Form
    {
        string imgUploadPath { get; set; }

        public Facebook()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameBox.Text = "";
            dateBox.Text = "";
            rDateBox.Text = "";
            contentBox.Text = "";
            imgUpload.Image = null;
        }

        private void imgButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg2 = new OpenFileDialog();
            dlg2.Title = "Open Image";
            dlg2.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

            if (dlg2.ShowDialog() == DialogResult.OK)
            {
                imgUpload.Image = new Bitmap(dlg2.FileName);
            }

            imgUploadPath = dlg2.FileName;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "PDF Files|*.pdf";
                dlg.FilterIndex = 0;

                string fileName = string.Empty;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    fileName = dlg.FileName;

                    Document pdfDoc = new Document();
                    PdfWriter.GetInstance(pdfDoc, new FileStream(fileName, FileMode.Create));
                    pdfDoc.Open();

                    iTextSharp.text.Image upload = iTextSharp.text.Image.GetInstance(imgUploadPath);

                    //logo
                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance("Servant-Leadership+Logo.jpg");
                    logo.ScalePercent(50f);
                    pdfDoc.Add(logo);

                    pdfDoc.Add(new Paragraph("Hello"));

                    upload.ScaleToFit(100,100);
                    pdfDoc.Add(upload);

                    pdfDoc.Close();

                }

          }

       }
 }



