namespace WindowsFormsApplication1
{
    partial class FromVendor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromVendor));
            this.vendorCode = new System.Windows.Forms.TextBox();
            this.partCode = new System.Windows.Forms.TextBox();
            this.partName = new System.Windows.Forms.TextBox();
            this.invoiceName = new System.Windows.Forms.TextBox();
            this.binQty = new System.Windows.Forms.TextBox();
            this.vendor = new System.Windows.Forms.Label();
            this.part = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.invoice_no = new System.Windows.Forms.Label();
            this.bin_qty = new System.Windows.Forms.Label();
            this.date_name = new System.Windows.Forms.Label();
            this.lot_no = new System.Windows.Forms.Label();
            this.print_file = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.netWeight = new System.Windows.Forms.ComboBox();
            this.grWeight = new System.Windows.Forms.ComboBox();
            this.qr_code = new System.Windows.Forms.Label();
            this.exitEntryForm = new System.Windows.Forms.Button();
            this.printQrCode = new System.Windows.Forms.Button();
            this.dateName = new System.Windows.Forms.DateTimePicker();
            this.labels = new System.Windows.Forms.NumericUpDown();
            this.qrCode = new System.Windows.Forms.Label();
            this.poNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.labels)).BeginInit();
            this.SuspendLayout();
            // 
            // vendorCode
            // 
            resources.ApplyResources(this.vendorCode, "vendorCode");
            this.vendorCode.Name = "vendorCode";
            this.vendorCode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // partCode
            // 
            resources.ApplyResources(this.partCode, "partCode");
            this.partCode.Name = "partCode";
            this.partCode.TextChanged += new System.EventHandler(this.partCode_TextChanged);
            // 
            // partName
            // 
            resources.ApplyResources(this.partName, "partName");
            this.partName.Name = "partName";
            // 
            // invoiceName
            // 
            resources.ApplyResources(this.invoiceName, "invoiceName");
            this.invoiceName.Name = "invoiceName";
            // 
            // binQty
            // 
            resources.ApplyResources(this.binQty, "binQty");
            this.binQty.Name = "binQty";
            this.binQty.TextChanged += new System.EventHandler(this.binQty_TextChanged);
            // 
            // vendor
            // 
            resources.ApplyResources(this.vendor, "vendor");
            this.vendor.Name = "vendor";
            this.vendor.Click += new System.EventHandler(this.label1_Click);
            // 
            // part
            // 
            resources.ApplyResources(this.part, "part");
            this.part.Name = "part";
            this.part.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.part_name_Click);
            // 
            // invoice_no
            // 
            resources.ApplyResources(this.invoice_no, "invoice_no");
            this.invoice_no.Name = "invoice_no";
            this.invoice_no.Click += new System.EventHandler(this.label4_Click);
            // 
            // bin_qty
            // 
            resources.ApplyResources(this.bin_qty, "bin_qty");
            this.bin_qty.Name = "bin_qty";
            this.bin_qty.Click += new System.EventHandler(this.bin_qty_Click);
            // 
            // date_name
            // 
            resources.ApplyResources(this.date_name, "date_name");
            this.date_name.Name = "date_name";
            this.date_name.Click += new System.EventHandler(this.label6_Click);
            // 
            // lot_no
            // 
            resources.ApplyResources(this.lot_no, "lot_no");
            this.lot_no.Name = "lot_no";
            this.lot_no.Click += new System.EventHandler(this.label7_Click);
            // 
            // print_file
            // 
            resources.ApplyResources(this.print_file, "print_file");
            this.print_file.Name = "print_file";
            this.print_file.Click += new System.EventHandler(this.print_file_Click);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // netWeight
            // 
            this.netWeight.FormattingEnabled = true;
            resources.ApplyResources(this.netWeight, "netWeight");
            this.netWeight.Name = "netWeight";
            this.netWeight.SelectedIndexChanged += new System.EventHandler(this.lotNo_SelectedIndexChanged);
            // 
            // grWeight
            // 
            this.grWeight.FormattingEnabled = true;
            resources.ApplyResources(this.grWeight, "grWeight");
            this.grWeight.Name = "grWeight";
            this.grWeight.SelectedIndexChanged += new System.EventHandler(this.printFile_SelectedIndexChanged);
            // 
            // qr_code
            // 
            resources.ApplyResources(this.qr_code, "qr_code");
            this.qr_code.Name = "qr_code";
            this.qr_code.Click += new System.EventHandler(this.qr_code_Click);
            // 
            // exitEntryForm
            // 
            resources.ApplyResources(this.exitEntryForm, "exitEntryForm");
            this.exitEntryForm.Name = "exitEntryForm";
            this.exitEntryForm.UseVisualStyleBackColor = true;
            this.exitEntryForm.Click += new System.EventHandler(this.exitForm1);
            // 
            // printQrCode
            // 
            resources.ApplyResources(this.printQrCode, "printQrCode");
            this.printQrCode.Name = "printQrCode";
            this.printQrCode.UseVisualStyleBackColor = true;
            this.printQrCode.Click += new System.EventHandler(this.printCode);
            // 
            // dateName
            // 
            resources.ApplyResources(this.dateName, "dateName");
            this.dateName.Name = "dateName";
            this.dateName.ValueChanged += new System.EventHandler(this.dateName_ValueChanged);
            // 
            // labels
            // 
            resources.ApplyResources(this.labels, "labels");
            this.labels.Name = "labels";
            // 
            // qrCode
            // 
            resources.ApplyResources(this.qrCode, "qrCode");
            this.qrCode.Name = "qrCode";
            this.qrCode.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // poNumber
            // 
            resources.ApplyResources(this.poNumber, "poNumber");
            this.poNumber.Name = "poNumber";
            this.poNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.poNumber);
            this.Controls.Add(this.qrCode);
            this.Controls.Add(this.labels);
            this.Controls.Add(this.dateName);
            this.Controls.Add(this.printQrCode);
            this.Controls.Add(this.exitEntryForm);
            this.Controls.Add(this.grWeight);
            this.Controls.Add(this.netWeight);
            this.Controls.Add(this.qr_code);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.print_file);
            this.Controls.Add(this.lot_no);
            this.Controls.Add(this.date_name);
            this.Controls.Add(this.bin_qty);
            this.Controls.Add(this.invoice_no);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.part);
            this.Controls.Add(this.vendor);
            this.Controls.Add(this.binQty);
            this.Controls.Add(this.invoiceName);
            this.Controls.Add(this.partName);
            this.Controls.Add(this.partCode);
            this.Controls.Add(this.vendorCode);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.labels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vendorCode;
        private System.Windows.Forms.TextBox partCode;
        private System.Windows.Forms.TextBox partName;
        private System.Windows.Forms.TextBox invoiceName;
        private System.Windows.Forms.TextBox binQty;
        private System.Windows.Forms.Label vendor;
        private System.Windows.Forms.Label part;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label invoice_no;
        private System.Windows.Forms.Label bin_qty;
        private System.Windows.Forms.Label date_name;
        private System.Windows.Forms.Label lot_no;
        private System.Windows.Forms.Label print_file;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox netWeight;
        private System.Windows.Forms.ComboBox grWeight;
        private System.Windows.Forms.Label qr_code;
        private System.Windows.Forms.Button exitEntryForm;
        private System.Windows.Forms.Button printQrCode;
        private System.Windows.Forms.DateTimePicker dateName;
        private System.Windows.Forms.NumericUpDown labels;
        private System.Windows.Forms.Label qrCode;
        private System.Windows.Forms.TextBox poNumber;
        private System.Windows.Forms.Label label1;
    }
}

