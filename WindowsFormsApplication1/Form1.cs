using QRCoder;
using RawPrint;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        PrintDocument document = new PrintDocument();
        PrintDialog dialog = new PrintDialog();
        //-----------------------------------------------------------


        //-----------------------------------------------------------
        PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
        private  Font printFont;
        private string stringToPrint;
      //  private int linesPerPage=9;
        private Font printFont1;
        QRCode qrCode1;
        private string stringToPrint1;
       // private int intMax;
        private PrintAction printAction;
        private string lenght;
        public string databasePathUsingSetting;
        int i = 0;
        int step=0;
        public Form1()
        {
           InitializeComponent();
           
           databasePathUsingSetting = Properties.Settings.Default.databasePath;
           // MessageBox.Show(file_browse_path.Text);
           //document.DefaultPageSettings.PrinterSettings.PrinterName = "GODEX500";
           //document.DefaultPageSettings.Landscape = true;

           //document.DefaultPageSettings.PaperSize = new PaperSize("75 x50 mm", 300, 200);
           //document.DefaultPageSettings.Margins = new Margins(1, 2, 3, 4)

           //-----------------------------------------------------------------------------------


           //process1.StartInfo.FileName = "G:\\tst.prn";
           //process1.Exited += new EventHandler(myProcess_exited);
           //process1.StartInfo.Arguments = " /b C:\\temp\\my.prn prn";


            //-----------------------------------------------------------------------------------

            document.DefaultPageSettings.PaperSize = new PaperSize("50x25 mm", 400, 122);
            

            //document.DefaultPageSettings.Margins = new Margins(50, 50, 50, 50);
            printFont = new Font("NewBarcodeFont", 7);
            printFont1 = new Font("NewBarcodeFont", 12);
            printFont_m = new Font("Arial", 5, FontStyle.Regular);
            //document= new Font("GODEX-NewBarcodeFont", 12, FontStyle.Regular);
            //document.OriginAtMargins = true;
            document.PrintPage += new PrintPageEventHandler(document_PrintPage);

        }
        
        private void printDocument_BeginPrint(object sender, PrintEventArgs e)
        {
            printAction = e.PrintAction;
            document.OriginAtMargins = false;
        }


        void document_PrintPage(object sender, PrintPageEventArgs e)
        {


            //var datestri = dateName.Value.ToString("dd/MM/yyyy");

            var date = dateName.Value;
            var year = date.ToString("yy");
            var month = date.ToString("MM");
            var day = date.ToString("dd");  // dd for 2-digit day




            //string text = File.ReadAllText(@filePath());       
            //qrCode.Text = part_no.Text + "" + day + "" + month + "" + year + "" + shift_name.Text + "" + serial_no.Text;
         
            
          

       

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            //stringToPrint = part_no.Text + "-" + day + "" + month + "" + year + "-" + shift_name.Text + "-" + serial_no.Text;

          //  stringToPrint1 = part_no.Text + "-" + day + "" + month + "" + year + "-" + shift_name.Text + "-" + serial_no.Text;
            stringToPrint = part_no.Text + "-" + day + "" + month + "" + year + "-" + shift_name.Text ;

            stringToPrint1 = part_no.Text + "-" + day + "" + month + "" + year + "-" + shift_name.Text ;


            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;

           // Console.WriteLine("Sexy_key "+ Properties.Settings.Default.increValue);

            RectangleF rectF0 = new RectangleF(1,105, 80, 20);
            i = Properties.Settings.Default.increValue;
            QRCodeData qrCodeData0 = qrGenerator.CreateQrCode(stringToPrint1 + "-" + (i).ToString("000"), QRCodeGenerator.ECCLevel.L);
            qrCode1 = new QRCode(qrCodeData0);
            Bitmap qrCodeImage0 = qrCode1.GetGraphic(2);

            e.Graphics.DrawImage(qrCodeImage0, 8, 58, 60, 55);
            e.Graphics.DrawString(stringToPrint +"-"+(i).ToString("000"), printFont_m, Brushes.Black, rectF0, sf);
            saveSetting(i );





            RectangleF rectF1 = new RectangleF(95, 105, 80, 20);
            i ++;
            QRCodeData qrCodeData1 = qrGenerator.CreateQrCode(stringToPrint1 + "-"+ (i).ToString("000"), QRCodeGenerator.ECCLevel.L);
            qrCode1 = new QRCode(qrCodeData1);
            Bitmap qrCodeImage1 = qrCode1.GetGraphic(2);
            e.Graphics.DrawImage(qrCodeImage1, 105, 58, 60, 55);
            e.Graphics.DrawString(stringToPrint +"-" + (i ).ToString("000"), printFont_m, Brushes.Black, rectF1, sf);
            saveSetting(i);


            RectangleF rectF2 = new RectangleF(195, 105, 80, 20);
            i ++;

            QRCodeData qrCodeData2 = qrGenerator.CreateQrCode(stringToPrint1 + "-"+ (i + step).ToString("000"), QRCodeGenerator.ECCLevel.L);
            qrCode1 = new QRCode(qrCodeData2);
            Bitmap qrCodeImage2 = qrCode1.GetGraphic(2);
            e.Graphics.DrawImage(qrCodeImage2, 205, 58, 60, 55);
            e.Graphics.DrawString(stringToPrint +"-"+ (i ).ToString("000"), printFont_m, Brushes.Black, rectF2, sf);
            saveSetting(i );




            RectangleF rectF3 = new RectangleF(295, 105, 80, 20);
            i ++;
            QRCodeData qrCodeData3 = qrGenerator.CreateQrCode(stringToPrint1 + "-"+ (i).ToString("000"), QRCodeGenerator.ECCLevel.L);
            qrCode1 = new QRCode(qrCodeData3);
            Bitmap qrCodeImage3 = qrCode1.GetGraphic(2);
            e.Graphics.DrawImage(qrCodeImage3, 302, 58, 60, 55);
            e.Graphics.DrawString(stringToPrint+"-"+ (i).ToString("000"), printFont_m, Brushes.Black, rectF3, sf);
            saveSetting(i);

            //Application.Restart ();

            i++;

            Properties.Settings.Default.increValue = i;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Upgrade();
            Properties.Settings.Default.Save();

            if ((i)>=999)
            {
                i = 0;
                
                Properties.Settings.Default.increValue = 0;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.Save();

            }

            SerialPort serialPort = new SerialPort("COM46", 19200,Parity.None,8,StopBits.One);

            SerialPort ports = new SerialPort();

            ports.PortName = "USB001";//According to the personal computer serial port name set

            ports.BaudRate = 9600;

            //ports.Open();

            byte[] byt = new byte[] { 0x00, 0x00, 0x0A, 0x0A };

        }

        public void saveSetting(int value) {

            Properties.Settings.Default.increValue = value;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Upgrade();
            Properties.Settings.Default.Save();

        }




        //---------------------------------------------------------------------------------------------------------------------------

        public RectangleF GetBestPrintableArea(PrintPageEventArgs e)
        {
            RectangleF marginBounds = e.MarginBounds;
            RectangleF printableArea = e.PageSettings.PrintableArea;
            RectangleF pageBounds = e.PageBounds;

            if (e.PageSettings.Landscape)
                printableArea = new RectangleF(printableArea.Y, printableArea.X, printableArea.Height, printableArea.Width);

            RectangleF bestArea = RectangleF.FromLTRB(
                (float)Math.Max(marginBounds.Left, printableArea.Left),
                (float)Math.Max(marginBounds.Top, printableArea.Top),
                (float)Math.Min(marginBounds.Right, printableArea.Right),
                (float)Math.Min(marginBounds.Bottom, printableArea.Bottom)
            );

            float bestMarginX = (float)Math.Max(bestArea.Left, pageBounds.Right - bestArea.Right);
            float bestMarginY = (float)Math.Max(bestArea.Top, pageBounds.Bottom - bestArea.Bottom);

                bestArea = RectangleF.FromLTRB(
                bestMarginX,
                bestMarginY,
                pageBounds.Right - bestMarginX,
                pageBounds.Bottom - bestMarginY
            );

            return bestArea;
        }


        //-----------------------------------------------------------
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


        public List<string> GetAllPorts()
        {
            List<String> allPorts = new List<String>();
            foreach (String portName in System.IO.Ports.SerialPort.GetPortNames())
            {
                allPorts.Add(portName);

            }
            return allPorts;
        }



        String qrcodedetails;
        private Font printFont_m;

        public Boolean dataValidation()
        {
            if (part_no.Text != "")
            {
                qrcodedetails += part_no.Text;
            }

            if (shift_name.Text != "")
            {
                qrcodedetails += " " + shift_name.Text;
            }
           

           
           
           
            if (dateName.Text != "")
            {
                qrcodedetails += " " + dateName.Text;
            }

            qrCode.Text = qrcodedetails;
            

            if (part_no.Text == "")
            {
                MessageBox.Show("Please enter part no");
                part_no.Focus();
                return false;
            }
            else if (shift_name.Text == "")
            {
                MessageBox.Show("Please enter shift no");
                shift_name.Focus();
                return false;
            }
          
           
          
            else if (dateName.Text == "")
            {
                MessageBox.Show("Please enter Date");
                dateName.Focus();
                return false;
            }
            
            else {
                return true;
            }



        }


        public void printCode(object sender, EventArgs e)
        {
            //IsFilled(vendorCode.Text,partCode.Text,partName.Text,invoiceName.Text,
            //binQty.Text,dateName.Text,lotNo.Text,printFile.Text,labels.Text);
            //-----------------------------------------------------------------

            if (dataValidation())
            {
               Database dataconnection= new Database();
                //  String path = @"" + databasePathUsingSetting;
                // String path = @"" + Form2.databaseFilePath;

                // string dataBasePath = Path.GetDirectoryName(path);
                if (dataconnection.databasePath() != null)
                {
                    try
                    {
                        dataconnection.database_qrcode_details(part_no,
                        shift_name, null, dateName, labels, qrCode);
                    }
                    catch
                    {

                    }
                }


                printPreviewDialog1.Document = document;

              //  printPreviewDialog1.Show();
                //------------------------------------------------------------------
                
             //   document.PrinterSettings.Copies = (short)labels.Value;
                
                
                //-------------------------------------------------------------------
                // Create an instance of the Printer
                IPrinter printer = new Printer();

                //MessageBox.Show(""+File.Exists(@filePath()));
                if (IsValidPath(@filePath()) && @filePath() != null && File.Exists(@filePath())) {

                    
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
                    
                    /*
                    text = text.Replace("<PART>", part_no.Text);
                    text = text.Replace("<SHIFT>", shift_name.Text);
                    text = text.Replace("<SERIAL>", serial_no.Text);
                    text = text.Replace("<DATE>", day + "" + month + "" + year);
                    */
                    qrCode.Text = part_no.Text + "," + day + "" + month + "" + year + "," + shift_name.Text ;
                    text = text.Replace("<QRCODE>", qrCode.Text);
                        
                  //  qrCode.Text = part_no.Text + "" + day + "" + month + "" + year + "" + shift_name.Text + "" + serial_no.Text;
                    lenght = qrCode.Text.Length.ToString();
                    text = text.Replace("<BARCODELEN>", lenght);
                    text = text.Replace("<BARCODE>", part_no.Text + "" + day + "" + month + "" + year + "" + shift_name.Text );
                    File.WriteAllText(fileLocMove, text);

                        


                    // Print the file
                    int n = 0;
                        while ((int)labels.Value > n) {
                        //Ring 408PEL+
                        //  printer.PrintRawFile("Ring 408PEL+", fileLocMove, "Printing file");

                        //  printer.PrintRawFile("Ring 408L", fileLocMove, "Printing file");

                        //printer.PrintRawFile("Godex G500", fileLocMove, "n");
                        printer.PrintRawFile("Godex EZ-1100 Plus", fileLocMove, "n");

                        n++;
                        }
                    
                    ////--THIS IS FOR DOCUMENT PRINT. I AM COMMENT OUT FOR TESTING PURPOSE FOR PRINTING FROM FILE------------------------
                }
                else {
                    int n = 0;
                    while ((int)labels.Value > n)
                    {
                        document.Print();
                        n++;
                    }
                }
                

                qrcodedetails = "";
                }


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

        private void label1_Click_3(object sender, EventArgs e)
        {

        }
        private void fileBrowser(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open PRN File";
            openFileDialog1.Filter = "PRN files|*.prn";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)

            {

                string fileName;

                fileName = openFileDialog1.FileName;
                
                Properties.Settings.Default.printFilePath = fileName;
                Properties.Settings.Default.Save();
                //file_browse_path.Text = Properties.Settings.Default.printFilePath;
                //   MessageBox.Show(fileName);

            }
        }

        public string filePath()
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            // AppDomain.CurrentDomain.SetData("DataDirectory", path);
            // string[] filePaths = Directory.GetFiles(@path, "*.mdb",
            // SearchOption.TopDirectoryOnly);
            // MessageBox.Show(filePaths[0]);
            // E:\ShreekrishnaProject\PayrollManagement\PayrollManagement
            // return filePaths[0];
            // Console.WriteLine("file path"+filePaths[0]);
            return path + "\\print_one.prn";

        }
        public static void ReplaceInFile(string filePath, string searchText, string replaceText)
        {

            var content = string.Empty;
            using (StreamReader reader = new StreamReader(filePath))
            {
                content = reader.ReadToEnd();
                reader.Close();
            }

            content = Regex.Replace(content, searchText, replaceText);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(content);
                writer.Close();
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

        protected virtual bool IsFileinUse(FileInfo file)
        {
            FileStream stream = null;

            try
            {
                stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            step = 0;
            i = 0;
            Properties.Settings.Default.increValue = 0;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Upgrade();
            Properties.Settings.Default.Save();
            AutoClosingMessageBox.Show("Succesfully Reset Serial Number", "Resetting Serial Number", 1000);
        }
    }
}
