namespace WindowsFormsApplication1
{
    partial class Form4
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
            this.print_form4 = new System.Windows.Forms.Button();
            this.exit_form4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labels = new System.Windows.Forms.NumericUpDown();
            this.to_address = new System.Windows.Forms.ComboBox();
            this.from_address = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.labels)).BeginInit();
            this.SuspendLayout();
            // 
            // print_form4
            // 
            this.print_form4.Location = new System.Drawing.Point(76, 267);
            this.print_form4.Name = "print_form4";
            this.print_form4.Size = new System.Drawing.Size(75, 23);
            this.print_form4.TabIndex = 2;
            this.print_form4.Text = "Print";
            this.print_form4.UseVisualStyleBackColor = true;
            this.print_form4.Click += new System.EventHandler(this.printAddress);
            // 
            // exit_form4
            // 
            this.exit_form4.Location = new System.Drawing.Point(157, 269);
            this.exit_form4.Name = "exit_form4";
            this.exit_form4.Size = new System.Drawing.Size(91, 23);
            this.exit_form4.TabIndex = 3;
            this.exit_form4.Text = "Exit";
            this.exit_form4.UseVisualStyleBackColor = true;
            this.exit_form4.Click += new System.EventHandler(this.exitForm4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "TO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "FROM:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Labels:";
            // 
            // labels
            // 
            this.labels.Location = new System.Drawing.Point(76, 194);
            this.labels.Name = "labels";
            this.labels.Size = new System.Drawing.Size(172, 20);
            this.labels.TabIndex = 9;
            // 
            // to_address
            // 
            this.to_address.FormattingEnabled = true;
            this.to_address.Location = new System.Drawing.Point(76, 47);
            this.to_address.Name = "to_address";
            this.to_address.Size = new System.Drawing.Size(172, 21);
            this.to_address.TabIndex = 10;
            // 
            // from_address
            // 
            this.from_address.FormattingEnabled = true;
            this.from_address.Location = new System.Drawing.Point(76, 113);
            this.from_address.Name = "from_address";
            this.from_address.Size = new System.Drawing.Size(172, 21);
            this.from_address.TabIndex = 11;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 370);
            this.Controls.Add(this.from_address);
            this.Controls.Add(this.to_address);
            this.Controls.Add(this.labels);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit_form4);
            this.Controls.Add(this.print_form4);
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.Text = "Mailing Address";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.labels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button print_form4;
        private System.Windows.Forms.Button exit_form4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown labels;
        public System.Windows.Forms.ComboBox to_address;
        public System.Windows.Forms.ComboBox from_address;
    }
}