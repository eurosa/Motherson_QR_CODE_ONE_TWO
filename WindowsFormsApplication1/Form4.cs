using QRCoder;
using RawPrint;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {

        PrintDocument document = new PrintDocument();
        PrintDialog dialog = new PrintDialog();
        //-----------------------------------------------------------


        //-----------------------------------------------------------
        PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
        //-----------------------------------------------------------
        private Font printFont;
        private string stringToPrint;
        //  private int linesPerPage=9;
        private Font printFont1;
        QRCode qrCode1;
        private string stringToPrint1;
        public string databasepathforall;
        public Form4()
        {
            InitializeComponent();
            Database newConn = new Database();
            newConn.mailing_address_data_query(this,Properties.Settings.Default.databasePath);
            // MessageBox.Show(Properties.Settings.Default.databasePath);
            databasepathforall = Properties.Settings.Default.databasePath;
            //-----------------------------------------------------------------------------------

            document.DefaultPageSettings.PaperSize = new PaperSize("150 x100 mm", 400, 600);


            document.DefaultPageSettings.Margins = new Margins(2, 2, 2, 2);
            printFont = new Font("Arial", 18,FontStyle.Bold);
            printFont1 = new Font("Arial", 18);

          //  printFont = new Font("NewBarcodeFont", 16, FontStyle.Bold);
         //   printFont1 = new Font("NewBarcodeFont", 12);

            // document= new Font("GODEX-NewBarcodeFont", 12, FontStyle.Regular);
            // document.OriginAtMargins = true;
            document.PrintPage += new PrintPageEventHandler(document_Print);

        }

        private void document_Print(object sender, PrintPageEventArgs e)
        {
            
            //--------------------------------------------------------------------------------------
            //  +"" + GetAllPorts()
            Pen myPen = new Pen(Color.Black);
            myPen.Width = 1;
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            //stringToPrint = "Ref.:" + "" + reference_code.Text
            //+ "\r\n" + "Orange:" + "" + orange_name.Text +
            //"\r\n" + "Size:" + "" + size_name.Text +
            //"\r\n" + "Invoice NO.:" + "" + invoiceName.Text +
            //"\r\n" + "Qty IN NOS:" + "" + binQty.Text +
            //"\r\n" + "Date:" + "" + dateName.Text;
            
            stringToPrint = "TO \r\n" + to_address.Text;
            stringToPrint1 = "FROM \r\n" + from_address.Text;
            stringToPrint = stringToPrint.Replace(",",  System.Environment.NewLine);
            //stringToPrint = stringToPrint.Replace("  ", System.Environment.NewLine);

            //stringToPrint1 = stringToPrint1.Replace(",", System.Environment.NewLine);
            // stringToPrint1= Regex.Replace(stringToPrint1, @"(\r\n){2,}", Environment.NewLine);
          //  stringToPrint1 = stringToPrint1.Replace("  ", System.Environment.NewLine);

            //stringToPrint1 = reference_code.Text
            //+ "," + orange_name.Text +
            //"," + size_name.Text +
            //"," + invoiceName.Text +
            //"," + binQty.Text +
            //"," + dateName.Text;

            QRCodeData qrCodeData = qrGenerator.CreateQrCode(stringToPrint1, QRCodeGenerator.ECCLevel.Q);
            qrCode1 = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode1.GetGraphic(4);



            //   intMax = 14;
            //  stringToPrint = stringToPrint.PadLeft(intMax / 2 - stringToPrint.Length / 2);
            //For Image
            //You can set specified position and specified image overloading this file
            //  e.Graphics.DrawImage(qrCodeImage, 100, 100);

            ////--------------------------------------------------------------------------------------
            //Graphics g = e.Graphics;
            //if (printAction != PrintAction.PrintToPreview)
            //g.TranslateTransform(-e.PageSettings.HardMarginX, -e.PageSettings.HardMarginY);

            //RectangleF printArea = GetBestPrintableArea(e);

            //g.DrawRectangle(Pens.Red, printArea.X, printArea.Y, printArea.Width - 1, printArea.Hei
            int charactersOnPage = 0;
            int linesPerPage = 0;

            // Sets the value of charactersOnPage to the number of characters 
            // of stringToPrint that will fit within the bounds of the page.
            e.Graphics.MeasureString(stringToPrint, printFont,
                e.MarginBounds.Size, StringFormat.GenericTypographic,
                out charactersOnPage, out linesPerPage);

            // Draws the string within the bounds of the page
           // e.Graphics.DrawString(stringToPrint, printFont, Brushes.Black,
             //   e.MarginBounds, StringFormat.GenericTypographic);

            // Remove the portion of the string that has been printed.
            stringToPrint = stringToPrint.Substring(charactersOnPage);

            // Check to see if more pages are to be printed.
            e.HasMorePages = (stringToPrint.Length > 0);
            //--------------------------------------------------------------------------------------
            //    e.Graphics.DrawImage(qrCodeImage, 130, 60, 60, 60);

            //  e.Graphics.DrawImage(qrCodeImage, 320, 60, 60, 60);
            //For Text lines
            // e.Graphics.DrawString(stringToPrint, printFont, Brushes.Black,10, 10);

            //string text2 = "Draw text in a rectangle by passing a RectF to the DrawString method.";
            //using (Font font2 = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point))
            //{
            //    Rectangle rect2 = new Rectangle(30, 10, 100, 122);

            //    // Specify the text is wrapped.
            //    TextFormatFlags flags = TextFormatFlags.WordBreak;
            //    TextRenderer.DrawText(e.Graphics, text2, font2, rect2, Color.Blue, flags);
            //    e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rect2));

            //}

            StringFormat format = new StringFormat();
            format.FormatFlags = StringFormatFlags.FitBlackBox;

         ///   string text1 = "Draw text in a rectangle by passing a RectF to the DrawString method.";
            using (Font font1 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                RectangleF rectF1 = new RectangleF(5, 20, 380, 290);
                e.Graphics.DrawString("TO \n" + to_address.Text.ToUpper(), printFont, Brushes.Black, rectF1, format);
             // e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectF1));
            }

            e.Graphics.DrawLine(myPen, 0, 300, 400, 300);

            using (Font font1 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                RectangleF rectF2 = new RectangleF(5, 320, 380, 290);
                e.Graphics.DrawString("FROM \n" + from_address.Text.ToUpper(), printFont, Brushes.Black, rectF2, format);
              // e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectF2));
            }

        

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void printAddress(object sender, EventArgs e)
        {
           // Create an instance of the Printer
            IPrinter printer = new Printer();

            // Print the file
            //  printer.PrintRawFile("Godex G500", file_path.Text, "n");

            //PrintDocument1.PrinterSettings.Copies = 1;
         //   if (dataValidation())
           // {
                //  Class1 posrr = new Class1();
             //   OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gunjan\\Documents\\Visual Studio 2015\\Projects\\MultiLabel\\qrcodedetails.mdb");
               // OleDbCommand cmd = con.CreateCommand();
                //con.Open();
                ////cmd.CommandText = "Insert into qrcodedetails_table(vendor_code,port_code,part_name)Values('" + vendorCode.Text + "','" + partCode.Text + "','" + partName.Text + "')";
                //cmd.CommandText = "Insert into qrcodedetails_table(reference_code,orange_name,size_name,invoice_no,bin_qty,date_name,labels,qrcode_name)Values('"
                    //+ reference_code.Text + "','" + orange_name.Text + "','" + size_name.Text + "','" + invoiceName.Text + "','" + binQty.Text + "','" + Convert.ToDateTime(dateName.Text) + "','" + labels.Text + "','" + qrCode.Text + "')";
                //cmd.Connection = con;
                //cmd.ExecuteNonQuery();

                //con.Close();


                printPreviewDialog1.Document = document;
                printPreviewDialog1.ShowDialog();

                document.PrinterSettings.Copies = (short)labels.Value;


                document.Print();

            //e.Graphics.DrawString(stringToPrint1, printFont, Brushes.Black, 10, 300);
            Database newData = new Database();
            
            newData.database_mailing_address(databasepathforall, to_address.Text, from_address.Text);

         //   newData.database_mailing_address(Form2.databaseFilePath, to_address.Text, from_address.Text);
            //}

        }
        private void exitForm4(object sender, EventArgs e)
        {
            Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
