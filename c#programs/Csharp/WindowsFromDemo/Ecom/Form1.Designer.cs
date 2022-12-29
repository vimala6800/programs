namespace Ecom
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
            this.btn = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.Label();
            this.purchaseamount = new System.Windows.Forms.TextBox();
            this.prime = new System.Windows.Forms.CheckBox();
            this.PurchaseAmount1 = new System.Windows.Forms.Label();
            this.NetAmount = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Purchase Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Are you a Prime Member";
            // 
            // btn
            // 
            this.btn.AutoSize = true;
            this.btn.Location = new System.Drawing.Point(337, 170);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 20);
            this.btn.TabIndex = 2;
            this.btn.Text = "Calculate";
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // Discount
            // 
            this.Discount.AutoSize = true;
            this.Discount.Location = new System.Drawing.Point(271, 294);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(72, 20);
            this.Discount.TabIndex = 3;
            this.Discount.Text = "Discount";
            // 
            // purchaseamount
            // 
            this.purchaseamount.Location = new System.Drawing.Point(368, 61);
            this.purchaseamount.Name = "purchaseamount";
            this.purchaseamount.Size = new System.Drawing.Size(100, 26);
            this.purchaseamount.TabIndex = 4;
            // 
            // prime
            // 
            this.prime.AutoSize = true;
            this.prime.Location = new System.Drawing.Point(368, 111);
            this.prime.Name = "prime";
            this.prime.Size = new System.Drawing.Size(63, 24);
            this.prime.TabIndex = 5;
            this.prime.Text = "Yes";
            this.prime.UseVisualStyleBackColor = true;
            // 
            // PurchaseAmount1
            // 
            this.PurchaseAmount1.AutoSize = true;
            this.PurchaseAmount1.Location = new System.Drawing.Point(271, 243);
            this.PurchaseAmount1.Name = "PurchaseAmount1";
            this.PurchaseAmount1.Size = new System.Drawing.Size(136, 20);
            this.PurchaseAmount1.TabIndex = 6;
            this.PurchaseAmount1.Text = "Purchase Amount";
            // 
            // NetAmount
            // 
            this.NetAmount.AutoSize = true;
            this.NetAmount.Location = new System.Drawing.Point(271, 349);
            this.NetAmount.Name = "NetAmount";
            this.NetAmount.Size = new System.Drawing.Size(94, 20);
            this.NetAmount.TabIndex = 7;
            this.NetAmount.Text = "Net Amount";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(376, 119);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 20);
            this.result.TabIndex = 8;
            this.result.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.NetAmount);
            this.Controls.Add(this.PurchaseAmount1);
            this.Controls.Add(this.prime);
            this.Controls.Add(this.purchaseamount);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ecom";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label btn;
        private System.Windows.Forms.Label Discount;
        private System.Windows.Forms.TextBox purchaseamount;
        private System.Windows.Forms.CheckBox prime;
        private System.Windows.Forms.Label PurchaseAmount1;
        private System.Windows.Forms.Label NetAmount;
        private System.Windows.Forms.Label result;
    }
}

