using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{

    class Class1
    {
        //[DllImport("kernel32.dll", SetLastError = true)]
        //static extern SafeFileHandle CreateFile(string lpFileName, FileAccess dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, FileMode dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

        //public  bool Print()
        //{
        //string nl = Convert.ToChar(13).ToString() + Convert.ToChar(10).ToString();
        //bool IsConnected = false;

        //string sampleText = "Hello World!" + nl +
        //"Enjoy Printing...";
        //try
        //{
        //Byte[] buffer = new byte[sampleText.Length];
        //buffer = System.Text.Encoding.ASCII.GetBytes(sampleText);

        //SafeFileHandle fh = CreateFile("usb001", FileAccess.Write, 0, IntPtr.Zero, FileMode.OpenOrCreate, 0, IntPtr.Zero);
        //if (!fh.IsInvalid)
        //{
        //IsConnected = true;
        //FileStream lpt1 = new FileStream(fh, FileAccess.ReadWrite);
        //lpt1.Write(buffer, 0, buffer.Length);
        //lpt1.Close();
        //}

        //}
        //catch (Exception ex)
        //{
        //string message = ex.Message;
        //}

        //return IsConnected;
        //}
        public const short FILE_ATTRIBUTE_NORMAL = 0x80;
        public const short INVALID_HANDLE_VALUE = -1;
        public const uint GENERIC_READ = 0x80000000;
        public const uint GENERIC_WRITE = 0x40000000;
        public const uint CREATE_NEW = 1;
        public const uint CREATE_ALWAYS = 2;
        public const uint OPEN_EXISTING = 3;

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr CreateFile(string lpFileName, uint dwDesiredAccess,
            uint dwShareMode, IntPtr lpSecurityAttributes, uint dwCreationDisposition,
            uint dwFlagsAndAttributes, IntPtr hTemplateFile);

        public  void sendTextToLPT1(String receiptText)
        {
            IntPtr ptr = CreateFile("USB001", GENERIC_WRITE, 0,
                     IntPtr.Zero, OPEN_EXISTING, 0, IntPtr.Zero);

            /* Is bad handle? INVALID_HANDLE_VALUE */
            if (ptr.ToInt32() == -1)
            {
                /* ask the framework to marshall the win32 error code to an exception */
                Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
            }
            else
            {
            //    FileStream lpt = new FileStream(ptr, FileAccess.ReadWrite);
              //  Byte[] buffer = new Byte[2048];
                //Check to see if your printer support ASCII encoding or Unicode.
                //If unicode is supported, use the following:
                //buffer = System.Text.Encoding.Unicode.GetBytes(Temp);
                //buffer = System.Text.Encoding.ASCII.GetBytes(receiptText);
                //lpt.Write(buffer, 0, buffer.Length);
                //lpt.Close();
            }
        }


    }

}
