using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Database
    {
        private object binQty;
        Form1 form1 = new Form1();
        public string filePathDatabase;

        public object dateName { get; private set; }

        
        internal void database_qrcode_details( TextBox part_no, TextBox shift_name, 
            TextBox serial_no,  DateTimePicker dateName, NumericUpDown labels, Label qrCode)
        {
            //MessageBox.Show(dataBasePath+ labels.ToString()+"LOV");

            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + @databasePath());
            if (File.Exists(@databasePath()))
            {
                //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gunjan\\Documents\\Visual Studio 2015\\Projects\\MultiLabel\\qrcodedetails.mdb");

                OleDbCommand cmd = con.CreateCommand();
                con.Open();
                //cmd.CommandText = "Insert into qrcodedetails_table(vendor_code,port_code,part_name)Values('" + vendorCode.Text + "','" + partCode.Text + "','" + partName.Text + "')";
                cmd.CommandText = "Insert into qrcodedetails_motherson(part_no,shift_name,serial_no,date_name,labels,qrcode_name)Values('"
                + part_no.Text + "','" + shift_name.Text +  "','" + serial_no.Text + "','" + Convert.ToDateTime(dateName.Text) + "','" + labels.Value + "','" + qrCode.Text + "')";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();

                con.Close();

            }
        }

        internal void database_mailing_address(string dataBasePath, string to_address, string from_address)
        {
            //MessageBox.Show(dataBasePath+ to_address+ to_address+ from_address);
            //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + @dataBasePath + "\\qrcodedetails.mdb");
            //try {
            if (File.Exists(@dataBasePath))
            {
                //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gunjan\\Documents\\Visual Studio 2015\\Projects\\MultiLabel\\qrcodedetails.mdb");

                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + @dataBasePath);

                OleDbCommand cmd = con.CreateCommand();

                //------------------------------------------------------------------------
                string cmdStr = "select count(*) from mailing_address where (to_address ='" + @to_address.Trim() + "') AND (from_address ='" + @from_address.Trim() + "')"; //get the existence of the record as count 
                con.Open();
                OleDbCommand cmd1 = new OleDbCommand(cmdStr, con);

                try
                {
                    //-------------------------------------------------------------------------------


                    int count = (int)cmd1.ExecuteScalar();

                    if (count > 0)
                    {
                        AutoClosingMessageBox.Show("Data already existed in the table", "Duplicate data found", 1000);
                        con.Close();
                        //record already exist 
                    }
                    else
                    {
                        con.Close();

                        // try
                        //{
                        con.Open();

                        cmd.CommandText = "Insert into mailing_address(to_address,from_address)Values('"
                        + to_address + "','" + from_address + "')" ;
                        //cmd.CommandText = "Insert into mailing_address(to_address,from_address)Values('"
                        //+ to_address + "','" + from_address + "') ON DUPLICATE KEY UPDATE to_address='" + @to_address.Trim() + "' , from_address ='" + @from_address.Trim();
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {

                }
                finally
                {
                    con.Close();
                }


            }
               
        }

        public string databasePath()
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

        public void mailing_address_data_query(Form4 form4,string dataBasePath)
        {
           // Form4 newForm4 = new Form4();
            if (File.Exists(@databasePath()))
            {
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + @databasePath());
                OleDbCommand cmd = con.CreateCommand();
                con.Open();
                //cmd.CommandText = "Insert into qrcodedetails_table(vendor_code,port_code,part_name)Values('" + vendorCode.Text + "','" + partCode.Text + "','" + partName.Text + "')";
                cmd.CommandText = "SELECT to_address AS to_add, from_address AS from_add  FROM mailing_address";

                //  cmd.CommandText = "SELECT LAST(to_address) AS to_add,LAST(from_address) AS from_add  FROM mailing_address";
                form4.from_address.Text= "KRISHNA HALFTONE PVT. LTD, D 177 FLATTED FACTORY COMPLEX, OKHLA PHASE III, NEW DELHI 110020, M:09810063914";

              //  form4.to_address.SelectedItem = null;

         //       form4.to_address.Text = "-----------------------Select---------------------";

                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (!form4.from_address.Items.Contains(dr["from_add"]))
                    {
                        form4.from_address.Items.Add(dr["from_add"].ToString());
                    }
                    if (!form4.to_address.Items.Contains(dr["to_add"]))
                    {
                        form4.to_address.Items.Add(dr["to_add"].ToString());
                    }
                    //id = dr["item_id"].ToString();
                    // MessageBox.Show(dr["from_add"].ToString()+" "+ dr["to_add"].ToString());
                   //   form4.to_address.Text = dr["to_add"].ToString();
                    

                }
                //RemoveDuplicateItems(form4.from_address);
                // cmd.Connection = con;
                // cmd.ExecuteNonQuery();

                con.Close();

            }
        }
        internal void qrcode_data_query()
        {

        }


        internal void dataBaseFilePath(string filePath)
        {
            filePathDatabase = filePath;
        }

        public class AutoClosingMessageBox
        {
            System.Threading.Timer _timeoutTimer;
            string _caption;
            AutoClosingMessageBox(string text, string caption, int timeout)
            {
                _caption = caption;
                _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                    null, timeout, System.Threading.Timeout.Infinite);
                using (_timeoutTimer)
                    MessageBox.Show(text, caption);
            }
            public static void Show(string text, string caption, int timeout)
            {
                new AutoClosingMessageBox(text, caption, timeout);
            }
            void OnTimerElapsed(object state)
            {
                IntPtr mbWnd = FindWindow("#32770", _caption); // lpClassName is #32770 for MessageBox
                if (mbWnd != IntPtr.Zero)
                    SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                _timeoutTimer.Dispose();
            }
            const int WM_CLOSE = 0x0010;
            [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
            static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
            [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
            static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
        }





        private void create2_btn_Click(object sender, EventArgs e)

        {
            
            string dbconnection = "Provider=Microsoft.Jet.OLEDB.4.0;" + @"data source=BookCSharp.mdb";

            string dbcommand = "Select * from Publisher;";

            OleDbDataAdapter DataAdapterTest = new OleDbDataAdapter(dbcommand, dbconnection);

            DataSet ds = new DataSet();

            DataAdapterTest.Fill(ds);

            DataTable publisher = new DataTable("Publisher");

            DataColumn publisherId = new DataColumn();

            publisherId.DataType = Type.GetType("System.Int32");

            publisherId.ColumnName = "PublisherID";

            publisherId.AllowDBNull = false;

            publisherId.Unique = true;

            publisherId.AutoIncrement = true;

            publisherId.AutoIncrementSeed = 1;

            publisherId.AutoIncrementStep = 1;

            publisher.Columns.Add(publisherId);

            DataColumn publishername = new DataColumn();

            publishername.DataType = Type.GetType("System.String");

            publishername.ColumnName = "PublisherName";

            publishername.AllowDBNull = true;

            publisher.Columns.Add(publishername);

            DataColumn[] PK = new DataColumn[1];

            PK[0] = publisher.Columns["PublisherID"];

            publisher.PrimaryKey = PK;

            MessageBox.Show("A new Data Table is successfully Created");

        }
//------------------------------------------------------------------------------------------------------------------------------------------
        public void CreateDatabaseTable(string database, string dbTableName)
        {
            OleDbConnection con;
            OleDbCommand cmd;
            string queryStr = "";

            try
            {
                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + database);

                con.Open();

               // queryStr = getDataGridViewHeaders().ToString();

                cmd = new OleDbCommand("CREATE TABLE " + dbTableName +
                    "( [keyID] AUTOINCREMENT PRIMARY KEY NOT NULL," + queryStr + ")", con);

                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        //------------------------------------------------------------------------------------------------------------------------------   
        protected void PopulateDropDownListCountry()
        {
            string queryString = "SELECT * from name of table";
            SqlConnection connection = new SqlConnection("Your Conenction string");
            SqlCommand command = new SqlCommand(queryString, connection);
            connection.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(command);
            ad.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                //DropDownList1.DataSource = dt;
                //DropDownList1.DataTextField = "coulmn name";
                //DropDownList1.DataValueField = "column name ";
                //DropDownList1.DataBind();
            }
            connection.Close();
        }

        //------------------------------------------------------------------------------------------------------------------------------


        void RemoveDuplicateItems(ComboBox ddl)
        {
            for (int i = 0; i < ddl.Items.Count; i++)
            {
                ddl.SelectedIndex = i;
                string str = ddl.SelectedItem.ToString();
                for (int counter = i + 1; counter < ddl.Items.Count; counter++)
                {
                    ddl.SelectedIndex = counter;
                    string compareStr = ddl.SelectedItem.ToString();
                    if (str == compareStr)
                    {
                        ddl.Items.RemoveAt(counter);
                        counter = counter - 1;
                    }
                }
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------
    }
}
