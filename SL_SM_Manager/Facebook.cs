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
            dateTimePicker1.Value = DateTime.Today;
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

                DateTime now = DateTime.Today;

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

                    iTextSharp.text.Font boldHel = new iTextSharp.text.Font(hel, 26, iTextSharp.text.Font.BOLD);
                    iTextSharp.text.Font labelHel = new iTextSharp.text.Font(hel, 16, iTextSharp.text.Font.BOLD);
                    iTextSharp.text.Font smallHel = new iTextSharp.text.Font(hel, 12);
                    iTextSharp.text.Font xSmallHel = new iTextSharp.text.Font(hel, 8);
                    iTextSharp.text.Font xSmalliHel = new iTextSharp.text.Font(hel, 8, iTextSharp.text.Font.ITALIC);


                    //set logo - top left header
                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance("Servant-Leadership+Logo.jpg");
                    logo.ScalePercent(50f);
                    pdfDoc.Add(logo);
                    pdfDoc.Add(new Paragraph("      Social Media Request Form", xSmallHel));
                    pdfDoc.Add(new Paragraph("      "+now.ToString("MM/dd/yyy"), xSmallHel));

                    Paragraph title = new Paragraph("Facebook Request", boldHel);
                    title.Alignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(title);

                    PdfPTable table = new PdfPTable(2);
                    table.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    table.HorizontalAlignment = Element.ALIGN_LEFT;

                    //blank formatting space
                    table.AddCell(" ");
                    table.AddCell(" ");
                    table.AddCell(" ");
                    table.AddCell(" ");

                    //request name - left
                    Paragraph rName = new Paragraph("Request Name:", labelHel);
                    Paragraph rTitleText = new Paragraph(nameBox.Text, smallHel);
                    table.AddCell(rName);
                    table.AddCell(rTitleText);

                    //blank formatting space
                    table.AddCell(" ");
                    table.AddCell(" ");

                    //date for request to be posted
                    Paragraph rDate = new Paragraph("Date To Be Posted:", labelHel);
                    Paragraph rDateText = new Paragraph(dateTimePicker1.Value.ToString("MM/dd/yyy"), smallHel);
                    table.AddCell(rDate);
                    table.AddCell(rDateText);

                    //blank formatting space
                    table.AddCell(" ");
                    table.AddCell(" ");

                    Paragraph rContent = new Paragraph("Text Content:", labelHel);
                    Paragraph rContentText = new Paragraph(contentBox.Text, smallHel);
                    table.AddCell(rContent);
                    table.AddCell(rContentText);

                    //blank formatting space
                    table.AddCell(" ");
                    table.AddCell(" ");
                    

                    //image 1 - if null, pass
                    if (imgUploadPath != null)
                    {
                        Paragraph rimg1 = new Paragraph("Image 1:", labelHel);
                        table.AddCell(rimg1);
                        uploadImage1 = iTextSharp.text.Image.GetInstance(imgUploadPath);
                        uploadImage1.ScaleToFit(200, 150);
                        table.AddCell(uploadImage1);
                    }

                    //blank formatting space
                    table.AddCell(" ");
                    table.AddCell(" ");

                    //image 2 - if null, pass
                    if (imgUploadPath2 != null)
                    {
                        Paragraph rimg2 = new Paragraph("Image 2:", labelHel);
                        table.AddCell(rimg2);
                        uploadImage2 = iTextSharp.text.Image.GetInstance(imgUploadPath2);
                        uploadImage2.ScaleToFit(200, 150);
                        table.AddCell(uploadImage2);
                    }


                    pdfDoc.Add(table);

                    Paragraph footer = new Paragraph("Please send this request to hub@msoe.edu for further processing.", xSmalliHel);
                    footer.Alignment = Element.ALIGN_CENTER;
                    Paragraph footerb = new Paragraph("Please include the raw images saved to the same location of the form.", xSmalliHel);
                    footerb.Alignment = Element.ALIGN_CENTER;
                    Paragraph footer2 = new Paragraph("If you would like this to be posted ASAP, please text the information to Dana Grenier.", xSmalliHel);
                    footer2.Alignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(footer);
                    pdfDoc.Add(footerb);
                    pdfDoc.Add(footer2);

                    pdfDoc.Close();

                    if (imgUpload.Image != null)
                    {
                        imgUpload.Image.Save(dlg.FileName + "-image1.jpg");
                    }
                    if (imgUpload2.Image != null)
                    {
                        imgUpload2.Image.Save(dlg.FileName + "-image2.jpg");
                    }

                    Close();

                }

          }



       }
 }



