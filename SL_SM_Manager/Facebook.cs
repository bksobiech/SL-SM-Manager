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
        //set 'global' variables - accessible to all methods, etc.
        string imgUploadPath { get; set; }
        string imgUploadPath2 { get; set; }
        iTextSharp.text.Image uploadImage1 { get; set; }
        iTextSharp.text.Image uploadImage2 { get; set; }

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
            imgUpload2.Image = null;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
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

        private void imgButton2_Click(object sender, EventArgs e)
        {
                OpenFileDialog dlg2 = new OpenFileDialog();
                dlg2.Title = "Open Image";
                dlg2.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

                if (dlg2.ShowDialog() == DialogResult.OK)
                {
                    imgUpload2.Image = new Bitmap(dlg2.FileName);
                }

                imgUploadPath2 = dlg2.FileName;
            
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "PDF Files|*.pdf";
                dlg.FilterIndex = 0;

                string fileName = string.Empty;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    //save PDF
                    fileName = dlg.FileName;

                    //declare pdf, open stream
                    Document pdfDoc = new Document();
                    PdfWriter.GetInstance(pdfDoc, new FileStream(fileName, FileMode.Create));
                    pdfDoc.Open();

                    //set fonts - all doc use
                    BaseFont hel = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);

                    iTextSharp.text.Font boldHel = new iTextSharp.text.Font(hel, 22, iTextSharp.text.Font.BOLD);
                    iTextSharp.text.Font labelHel = new iTextSharp.text.Font(hel, 16, iTextSharp.text.Font.BOLD);
                    iTextSharp.text.Font smallHel = new iTextSharp.text.Font(hel, 12);


                    //set logo - top left header
                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance("Servant-Leadership+Logo.jpg");
                    logo.ScalePercent(50f);
                    pdfDoc.Add(logo);

                    //title - center
                    Paragraph title = new Paragraph("Facebook Request", boldHel);
                    title.Alignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(title);

                    //request name - left
                    Paragraph rName = new Paragraph("Request Name:", labelHel);
                    Paragraph rText = new Paragraph(nameBox.Text, smallHel);
                    pdfDoc.Add(rName);
                    pdfDoc.Add(rText);

                    //image 1 - if null, pass
                    if (imgUploadPath != null)
                    {
                        uploadImage1 = iTextSharp.text.Image.GetInstance(imgUploadPath);
                        uploadImage1.ScaleToFit(100, 100);
                        pdfDoc.Add(uploadImage1);
                    }

                    //image 2 - if null, pass
                    if (imgUploadPath2 != null)
                    {
                        uploadImage2 = iTextSharp.text.Image.GetInstance(imgUploadPath2);
                        uploadImage2.ScaleToFit(100, 100);
                        pdfDoc.Add(uploadImage2);
                    }

                    pdfDoc.Close();
                    Close();

                }

          }



       }
 }



