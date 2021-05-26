using System;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.qrCodeForm2 = new System.Windows.Forms.Button();
            this.exitForm2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // qrCodeForm2
            // 
            this.qrCodeForm2.Location = new System.Drawing.Point(87, 33);
            this.qrCodeForm2.Name = "qrCodeForm2";
            this.qrCodeForm2.Size = new System.Drawing.Size(116, 41);
            this.qrCodeForm2.TabIndex = 0;
            this.qrCodeForm2.Text = "QR CODE ONE";
            this.qrCodeForm2.UseVisualStyleBackColor = true;
            this.qrCodeForm2.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitForm2
            // 
            this.exitForm2.Location = new System.Drawing.Point(87, 180);
            this.exitForm2.Name = "exitForm2";
            this.exitForm2.Size = new System.Drawing.Size(116, 23);
            this.exitForm2.TabIndex = 2;
            this.exitForm2.Text = "Exit";
            this.exitForm2.UseVisualStyleBackColor = true;
            this.exitForm2.Click += new System.EventHandler(this.exitform2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "QRCODE TWO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(298, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitForm2);
            this.Controls.Add(this.qrCodeForm2);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Start Form";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

       
        #endregion

        private System.Windows.Forms.Button qrCodeForm2;
        private System.Windows.Forms.Button exitForm2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        internal static string databaseFilePath;
        private System.Windows.Forms.Button button1;
    }
}