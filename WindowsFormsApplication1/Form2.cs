using RawPrint;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        Process process1 = new Process();
        Database dataconnection = new Database();

        public Form2()
        {
            InitializeComponent();
     //   public string databaseFilePath;

       // menuStrip1.BackColor = Color.OrangeRed;
         //   menuStrip1.ForeColor = Color.Black;
           // menuStrip1.Text = "File Menu";

        }

        private void button1_Click(object sender, EventArgs e)
        {
           Form frm1= new Form1();
            frm1.Show();
        }

        private void exitform2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        public void button_select(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open PRN File";
            openFileDialog1.Filter = "PRN files|*.prn";
         
            if (openFileDialog1.ShowDialog() == DialogResult.OK)

            {

                string fileName;
                fileName = openFileDialog1.FileName;
                //file_path.Text = fileName;
                //MessageBox.Show(fileName);

            }
        }

        //--------------------------------------------------
        void myProcess_exited(object sender, EventArgs e)
        {

            process1.Start();
        }
        //-------------------------------------------------

        private void file_generated_qr(object sender, EventArgs e)
        {
           

            // Create an instance of the Printer
         //     IPrinter printer = new Printer();

            //----------------------------------------------------------------------------
         //   String path = @""+file_path.Text;

            //using (StreamReader sr = File.OpenText(path))
            //{
                //String s = "";

                //while ((s = sr.ReadLine()) != null)
                //{
                  ////  MessageBox.Show(s);

                    //StringBuilder sb = new StringBuilder(s);

                    ////Console.WriteLine(s);
                //}
            //}
          //// Print the file
              //printer.PrintRawFile("Godex G500", file_path.Text, "n");
         //   Console.ReadKey();

            //-----------------------------------------------------------------------
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void mailing_address_Click(object sender, EventArgs e)
        {
            Form frm4 = new Form4();
            frm4.Show();
        }

        private void databaseSetting_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open DB File";
            openFileDialog1.Filter = "MDB files|*.mdb";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)

            {

                string fileName;
                fileName = openFileDialog1.FileName;
                //file_path.Text = fileName;
                // MessageBox.Show(fileName);
                databaseFilePath = fileName;
                dataconnection.dataBaseFilePath(databaseFilePath);
              // MessageBox.Show("Database path has been set"+ databaseFilePath);
                Database.AutoClosingMessageBox.Show("Database path has been set", "Database File", 1000);
                Properties.Settings.Default.databasePath = databaseFilePath;
                Properties.Settings.Default.Save();
            }
            

            //  MainMenu.Font = newFont("Georgia", 16);
        }

        public class AutoClosingMessageBox {
    System.Threading.Timer _timeoutTimer;
    string _caption;
    AutoClosingMessageBox(string text, string caption, int timeout) {
        _caption = caption;
        _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
            null, timeout, System.Threading.Timeout.Infinite);
        using(_timeoutTimer)
            MessageBox.Show(text, caption);
    }
    public static void Show(string text, string caption, int timeout) {
        new AutoClosingMessageBox(text, caption, timeout);
    }
    void OnTimerElapsed(object state) {
        IntPtr mbWnd = FindWindow("#32770", _caption); // lpClassName is #32770 for MessageBox
        if(mbWnd != IntPtr.Zero)
            SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
        _timeoutTimer.Dispose();
    }
    const int WM_CLOSE = 0x0010;
    [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
    static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
    [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
    static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
}

        private void button1_Click_1(object sender, EventArgs e)
        {
            FromVendor vendor = new FromVendor();
            vendor.Show();


        }
    }
}
