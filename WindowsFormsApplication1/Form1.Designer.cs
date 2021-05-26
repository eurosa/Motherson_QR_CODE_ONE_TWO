namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.date_name = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.exitEntryForm = new System.Windows.Forms.Button();
            this.printQrCode = new System.Windows.Forms.Button();
            this.dateName = new System.Windows.Forms.DateTimePicker();
            this.labels = new System.Windows.Forms.NumericUpDown();
            this.qrCode = new System.Windows.Forms.Label();
            this.orange = new System.Windows.Forms.Label();
            this.reference = new System.Windows.Forms.Label();
            this.part_no = new System.Windows.Forms.TextBox();
            this.shift_name = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.labels)).BeginInit();
            this.SuspendLayout();
            // 
            // date_name
            // 
            resources.ApplyResources(this.date_name, "date_name");
            this.date_name.Name = "date_name";
            this.date_name.Click += new System.EventHandler(this.label6_Click);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            this.label9.Click += new System.EventHandler(this.label9_Click);
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
            // orange
            // 
            resources.ApplyResources(this.orange, "orange");
            this.orange.Name = "orange";
            this.orange.Click += new System.EventHandler(this.label2_Click);
            // 
            // reference
            // 
            resources.ApplyResources(this.reference, "reference");
            this.reference.Name = "reference";
            this.reference.Click += new System.EventHandler(this.label1_Click);
            // 
            // part_no
            // 
            resources.ApplyResources(this.part_no, "part_no");
            this.part_no.Name = "part_no";
            this.part_no.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // shift_name
            // 
            resources.ApplyResources(this.shift_name, "shift_name");
            this.shift_name.Name = "shift_name";
            this.shift_name.TextChanged += new System.EventHandler(this.partCode_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.qrCode);
            this.Controls.Add(this.labels);
            this.Controls.Add(this.dateName);
            this.Controls.Add(this.printQrCode);
            this.Controls.Add(this.exitEntryForm);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.date_name);
            this.Controls.Add(this.orange);
            this.Controls.Add(this.reference);
            this.Controls.Add(this.shift_name);
            this.Controls.Add(this.part_no);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.labels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label date_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button exitEntryForm;
        private System.Windows.Forms.Button printQrCode;
        private System.Windows.Forms.DateTimePicker dateName;
        private System.Windows.Forms.NumericUpDown labels;
        private System.Windows.Forms.Label qrCode;
        private System.Windows.Forms.Label orange;
        private System.Windows.Forms.Label reference;
        private System.Windows.Forms.TextBox part_no;
        private System.Windows.Forms.TextBox shift_name;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}

