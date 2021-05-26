using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RawPrint;

namespace WindowsFormsApplication1
{
    public partial class FromVendor : Form
    {
        PrintDocument document = new PrintDocument();
        PrintDialog dialog = new PrintDialog();
        PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
        private  Font printFont;
        private string stringToPrint;
      //  private int linesPerPage=9;
        private Font printFont1;
        QRCode qrCode1;
        private string stringToPrint1;
        private string databasePath;
        private string lenght;
        private PngByteQRCode qwerfhqwu;

        public FromVendor()
        {
            InitializeComponent();

            
            //document.DefaultPageSettings.PrinterSettings.PrinterName = "GODEX500";
            //  document.DefaultPageSettings.Landscape = true;
            document.DefaultPageSettings.PaperSize = new PaperSize("75 x50 mm", 300, 200);
            document.DefaultPageSettings.Margins = new Margins(2, 2, 2, 2);
            printFont = new Font("Arial", 10);
           // printFont1 = new Font("NewBarcodeFont", 12);

            //    document= new Font("GODEX-NewBarcodeFont", 12, FontStyle.Regular);
            // document.OriginAtMargins = true;
            document.PrintPage += new PrintPageEventHandler(document_PrintPage);

        }



        void document_PrintPage(object sender, PrintPageEventArgs e)
        {

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            stringToPrint = "Vendor Code:" + "" + vendorCode.Text
                + "\r\n" + "Part Code:" + "" + partCode.Text +
                "\r\n" + "Part Name:" + "" + partName.Text +
                "\r\n" + "INV.:" + "" + invoiceName.Text +
                "\r\n" + "Qty IN NOS:" + "" + binQty.Text +
                "\r\n" + "Date:" + "" + dateName.Text +
                "\r\n" + "Net Wt.:" + "" + netWeight.Text +
                "\r\n" + "Gross Wt.:" + "" + grWeight.Text +
                "\r\n" + "PO No:" + "" + poNumber.Text;

            stringToPrint1 =  vendorCode.Text
                + ","+ partCode.Text +
                ","+ partName.Text +
                 "," + invoiceName.Text +
                 "," + binQty.Text +
                 "," + dateName.Text +
                 "," + netWeight.Text +
                 "," + grWeight.Text+
                 "," + poNumber.Text;

            QRCodeData qrCodeData = qrGenerator.CreateQrCode(stringToPrint1, QRCodeGenerator.ECCLevel.L);
            qrCode1 = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode1.GetGraphic(2);
           

            

            //For Image
            e.Graphics.DrawImage(qrCodeImage, 175, 70, 100,100);
            //For Text lines
            e.Graphics.DrawString(stringToPrint, printFont, Brushes.Black, 10, 20);
         
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
        }

       


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bin_qty_Click(object sender, EventArgs e)
        {

        }

        private void part_name_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void print_file_Click(object sender, EventArgs e)
        {
         

        }
        public Boolean dataValidation()
        {
            if (vendorCode.Text != "")
            {
                qrCode.Text = vendorCode.Text;
            }

            if (partCode.Text != "")
            {
                qrCode.Text += " " + partCode.Text;
            }
            if (partName.Text != "")
            {
                qrCode.Text += " " + partName.Text;
            }

            if (invoiceName.Text != "")
            {
                qrCode.Text += " " + invoiceName.Text;
            }
            if (binQty.Text != "")
            {
                qrCode.Text += " " + binQty.Text;
            }
            if (netWeight.Text != "")
            {
                qrCode.Text += " " +netWeight.Text;
            }
            if (poNumber.Text != "")
            {
                qrCode.Text += " " + poNumber.Text;
            }
            if (dateName.Text != "")
            {
                qrCode.Text += " " + dateName.Text;
            }
            

         //   qrCode.Text = vendorCode.Text
         //       +","+partCode.Text
         //       +","+partName.Text
         //       +","+invoiceName.Text
         //       +","+binQty.Text
         //       +","+dateName.Text
         //       +","+lotNo.Text
         //       +","+labels.Text;
         //MessageBox.Show(stringToPrint1);

            if (vendorCode.Text == "")
            {
                MessageBox.Show("Please enter vendor code");
                vendorCode.Focus();
                return false;
            }
            else if (partCode.Text == "")
            {
                MessageBox.Show("Please enter part code");
                partCode.Focus();
                return false;
            }
            else if (partName.Text == "")
            {
                MessageBox.Show("Please enter Part Name");
                partName.Focus();
                return false;
            }
            else if (invoiceName.Text == "")
            {
                MessageBox.Show("Please enter Invoice Name");
                invoiceName.Focus();
                return false;
            }
            else if (binQty.Text == "")
            {
                MessageBox.Show("Please enter Bin quantity");
                binQty.Focus();
                return false;
            }
            else if (dateName.Text == "")
            {
                MessageBox.Show("Please enter Date");
                dateName.Focus();
                return false;
            }
            else if (netWeight.Text == "")
            {
                MessageBox.Show("Please enter Net Weight");
                netWeight.Focus();
                return false;
            }
            else if (grWeight.Text == "")
            {
                MessageBox.Show("Please enter gross weight");
                grWeight.Focus();
                return false;

            }
            else if (poNumber.Text == "")
            {
                MessageBox.Show("Please enter PO No");
                poNumber.Focus();
                return false;

            }
            else {
                return true;
            }



        }


        public void printCode(object sender, EventArgs e)
        {
           

        if (dataValidation())
            {

                if (databePath() != null)
                {
                    try
                    {

                        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + @databePath());
                        // OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gunjan\\Documents\\Visual Studio 2015\\Projects\\qrcodedetails.mdb");

                        OleDbCommand cmd = con.CreateCommand();
                        con.Open();
                        //cmd.CommandText = "Insert into qrcodedetails_table(vendor_code,port_code,part_name)Values('" + vendorCode.Text + "','" + partCode.Text + "','" + partName.Text + "')";
                        cmd.CommandText = "Insert into qrcodedetails_table(vendor_code,part_code,part_name,invoice_no,bin_qty,date_name,netWeight,grWeight,labels,qrcode_name,po_num)Values('" + vendorCode.Text + "','" + partCode.Text + "','" + partName.Text + "','" + invoiceName.Text + "','" + binQty.Text + "','" + Convert.ToDateTime(dateName.Text) + "','" + netWeight.Text + "','" + grWeight.Text + "','" + labels.Text + "','" + qrCode.Text + "','" + poNumber.Text + "')";
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();

                        con.Close();
                    }
                    catch
                    {

                    }
                }

                    Database dataconnection = new Database();
                    //  String path = @"" + databasePathUsingSetting;
                    // String path = @"" + Form2.databaseFilePath;

                    // string dataBasePath = Path.GetDirectoryName(path);






              //      printPreviewDialog1.Document = document;

                 printPreviewDialog1.Show();
                    //------------------------------------------------------------------

                ///    document.PrinterSettings.Copies = (short)labels.Value;


                    //-------------------------------------------------------------------
                    // Create an instance of the Printer
                    IPrinter printer = new Printer();

                    //MessageBox.Show(""+File.Exists(@filePath()));
                    if (IsValidPath(@filePath()) && @filePath() != null && File.Exists(@filePath()))
                    {


                        if (!File.Exists(@filePath()))
                        {
                            MessageBox.Show("File not exits. Please enter valid path for the file.");
                            return;
                        }


                        //using (StreamReader sr = new System.IO.StreamReader(path))
                        //{
                        string fileLocMove = "";
                        string newpath = Path.GetDirectoryName(@filePath());

                        fileLocMove = newpath + "\\" + "new.prn";

                        var datestring = dateName.Value.ToString("dd/MM/yyyy");

                        var date = dateName.Value;
                        var year = date.ToString("yy");
                        var month = date.ToString("MM");
                        var day = date.ToString("dd");  // dd for 2-digit day




                        string text = File.ReadAllText(@filePath());
                        
                        qrCode.Text = vendorCode.Text + "," + partCode.Text + "," + partName.Text + "," + invoiceName.Text + "," + binQty.Text + "," + dateName.Text + "," + netWeight.Text + "," + grWeight.Text + "," + poNumber.Text;
                        text = text.Replace("<VENDORCODE>", vendorCode.Text);
                        text = text.Replace("<PARTCODE>", partCode.Text);
                        text = text.Replace("<PARTNAME>", partName.Text);
                        text = text.Replace("<INVOICE>", invoiceName.Text);
                        text = text.Replace("<BINQTY>", binQty.Text);
                        text = text.Replace("<DATED>", dateName.Text);
                        text = text.Replace("<NETWEIGHT>", netWeight.Text);
                        text = text.Replace("<GRWEIGHT>", grWeight.Text);
                        text = text.Replace("<PONUMBER>", poNumber.Text);
                        text = text.Replace("<BARCODE>", qrCode.Text);
                        lenght = qrCode.Text.Length.ToString();
                        text = text.Replace("<BARCODELEN>", lenght);


                        File.WriteAllText(fileLocMove, text);




                        // Print the file
                        int n = 0;
                        while ((int)labels.Value > n)
                        {
                            //Ring 408PEL+
                            //  printer.PrintRawFile("Ring 408PEL+", fileLocMove, "Printing file");

                            //  printer.PrintRawFile("Ring 408L", fileLocMove, "Printing file");

                            //printer.PrintRawFile("Godex G500", fileLocMove, "n");
                            printer.PrintRawFile("Godex EZ-1100 Plus", fileLocMove, "n");

                            n++;
                        }
                    }

                    else
                    {


                        printPreviewDialog1.Document = document;
                      //  printPreviewDialog1.ShowDialog();
                        // if (dialog.ShowDialog() == DialogResult.OK)
                        //{
                        // document.PrinterSettings.DefaultPageSettings.PrintableArea.X.Equals(12);
                        //document.PrinterSettings.DefaultPageSettings.PrintableArea.Y.Equals(12);

                        //------------------------------------------------------------------
                        document.PrinterSettings.Copies = (short)labels.Value;
                        Random random = new Random();
                        // string ran= random.Next(100,200).ToString();
                        // MessageBox.Show(ran);
                        //------------------------------------------------------------------
                        document.Print();

                    }
                
               


            }
        }


        private bool IsValidPath(string path, bool exactPath = true)
        {
            bool isValid = true;

            try
            {
                string fullPath = Path.GetFullPath(path);

                if (exactPath)
                {
                    string root = Path.GetPathRoot(path);
                    isValid = string.IsNullOrEmpty(root.Trim(new char[] { '\\', '/' })) == false;
                }
                else
                {
                    isValid = Path.IsPathRooted(path);
                }
            }
            catch (Exception ex)
            {
                isValid = false;

            }

            return isValid;
        }


        public string filePath()
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            //  AppDomain.CurrentDomain.SetData("DataDirectory", path);
            // string[] filePaths = Directory.GetFiles(@path, "*.mdb",
            // SearchOption.TopDirectoryOnly);
            // MessageBox.Show(filePaths[0]);
            // E:\ShreekrishnaProject\PayrollManagement\PayrollManagement
            //  return filePaths[0];
            // Console.WriteLine("file path"+filePaths[0]);
            return path + "\\print.prn";

        }

        public string databePath()
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            //  AppDomain.CurrentDomain.SetData("DataDirectory", path);
            // string[] filePaths = Directory.GetFiles(@path, "*.mdb",
            // SearchOption.TopDirectoryOnly);
            // MessageBox.Show(filePaths[0]);
            // E:\ShreekrishnaProject\PayrollManagement\PayrollManagement
            //  return filePaths[0];
            // Console.WriteLine("file path"+filePaths[0]);
            return path + "\\qrcodedetails.mdb";

        }

        private void exitForm1(object sender, EventArgs e)
        {
            Close();
        }

        public bool IsFilled(String s)
        {
  
            if (s != "")
            { return true; }
            else
            { return false; }
        }

        private void partCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void qr_code_Click(object sender, EventArgs e)
        {

        }

        private void binQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void dateName_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lotNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void printFile_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
