namespace SimpleCalculator
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.opr = new System.Windows.Forms.MaskedTextBox();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Number1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "operator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Number2";
            // 
            // btn
            // 
            this.btn.AutoSize = true;
            this.btn.Location = new System.Drawing.Point(305, 245);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(59, 20);
            this.btn.TabIndex = 3;
            this.btn.Text = "Submit";
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(604, 272);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 20);
            this.result.TabIndex = 4;
            // 
            // opr
            // 
            this.opr.Location = new System.Drawing.Point(330, 120);
            this.opr.Name = "opr";
            this.opr.Size = new System.Drawing.Size(100, 26);
            this.opr.TabIndex = 5;
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(330, 63);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(100, 26);
            this.num1.TabIndex = 6;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(330, 172);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(100, 26);
            this.num2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.opr);
            this.Controls.Add(this.result);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Simple Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label btn;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.MaskedTextBox opr;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
    }
}

