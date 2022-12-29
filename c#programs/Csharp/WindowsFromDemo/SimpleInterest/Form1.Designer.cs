namespace SimpleInterest
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Label();
            this.silb1 = new System.Windows.Forms.Label();
            this.principle = new System.Windows.Forms.TextBox();
            this.roi = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Principle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Rate Of Interest";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Time";
            // 
            // btn
            // 
            this.btn.AutoSize = true;
            this.btn.Location = new System.Drawing.Point(323, 237);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 20);
            this.btn.TabIndex = 3;
            this.btn.Text = "Calculate";
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // silb1
            // 
            this.silb1.AutoSize = true;
            this.silb1.Location = new System.Drawing.Point(601, 279);
            this.silb1.Name = "silb1";
            this.silb1.Size = new System.Drawing.Size(0, 20);
            this.silb1.TabIndex = 4;
            // 
            // principle
            // 
            this.principle.Location = new System.Drawing.Point(391, 64);
            this.principle.Name = "principle";
            this.principle.Size = new System.Drawing.Size(100, 26);
            this.principle.TabIndex = 6;
            // 
            // roi
            // 
            this.roi.Location = new System.Drawing.Point(391, 107);
            this.roi.Name = "roi";
            this.roi.Size = new System.Drawing.Size(100, 26);
            this.roi.TabIndex = 7;
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(391, 161);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(100, 26);
            this.time.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.time);
            this.Controls.Add(this.roi);
            this.Controls.Add(this.principle);
            this.Controls.Add(this.silb1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Simple Interest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label btn;
        private System.Windows.Forms.Label silb1;
        private System.Windows.Forms.TextBox principle;
        private System.Windows.Forms.TextBox roi;
        private System.Windows.Forms.TextBox time;
    }
}

