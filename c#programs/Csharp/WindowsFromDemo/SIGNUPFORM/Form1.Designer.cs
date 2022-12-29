using System.Runtime.InteropServices;

namespace SIGNUPFORM
{
    partial class Form1
    {
        private const string V = "signup";
       

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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Mobile = new System.Windows.Forms.TextBox();
            this.Sex1 = new System.Windows.Forms.RadioButton();
            this.Sex2 = new System.Windows.Forms.RadioButton();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.Location = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mobile";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sex";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "DOB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Location";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btn
            // 
            this.btn.AutoSize = true;
            this.btn.Location = new System.Drawing.Point(282, 314);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(59, 20);
            this.btn.TabIndex = 6;
            this.btn.Text = "Submit";
            this.btn.Click += new System.EventHandler(this.label7_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(554, 347);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 20);
            this.result.TabIndex = 7;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(310, 33);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(100, 26);
            this.Name.TabIndex = 8;
            this.Name.Text = "vimala";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(310, 70);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(100, 26);
            this.Email.TabIndex = 9;
            // 
            // Mobile
            // 
            this.Mobile.Location = new System.Drawing.Point(310, 117);
            this.Mobile.Name = "Mobile";
            this.Mobile.Size = new System.Drawing.Size(100, 26);
            this.Mobile.TabIndex = 10;
            // 
            // Sex1
            // 
            this.Sex1.AutoSize = true;
            this.Sex1.Location = new System.Drawing.Point(273, 166);
            this.Sex1.Name = "Sex1";
            this.Sex1.Size = new System.Drawing.Size(68, 24);
            this.Sex1.TabIndex = 11;
            this.Sex1.TabStop = true;
            this.Sex1.Text = "male";
            this.Sex1.UseVisualStyleBackColor = true;
            // 
            // Sex2
            // 
            this.Sex2.AutoSize = true;
            this.Sex2.Location = new System.Drawing.Point(347, 166);
            this.Sex2.Name = "Sex2";
            this.Sex2.Size = new System.Drawing.Size(82, 24);
            this.Sex2.TabIndex = 12;
            this.Sex2.TabStop = true;
            this.Sex2.Text = "female";
            this.Sex2.UseVisualStyleBackColor = true;
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(253, 210);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(200, 26);
            this.dob.TabIndex = 13;
            // 
            // Location
            // 
            this.Location.FormattingEnabled = true;
            this.Location.Items.AddRange(new object[] {
            "Andhra Pradesh",
            "karnataka",
            "Tamilnadu",
            "kerala"});
            this.Location.Location = new System.Drawing.Point(289, 261);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(121, 28);
            this.Location.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.Sex2);
            this.Controls.Add(this.Sex1);
            this.Controls.Add(this.Mobile);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.result);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            //this.Name = "Form1";
            this.Text = "SIGNUP FORM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label btn;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Mobile;
        private System.Windows.Forms.RadioButton Sex1;
        private System.Windows.Forms.RadioButton Sex2;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.ComboBox Location;

        public static string V1 => V;
    }
}

