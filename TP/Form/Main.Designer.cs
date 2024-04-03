namespace TP
{
    partial class Main
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(584, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 130);
            this.button1.TabIndex = 0;
            this.button1.Text = "발주";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Order_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(830, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 130);
            this.button2.TabIndex = 1;
            this.button2.Text = "반품";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Return_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(830, 145);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 130);
            this.button3.TabIndex = 2;
            this.button3.Text = "재고";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Stock_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(25, 325);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(227, 100);
            this.button4.TabIndex = 3;
            this.button4.Text = "설정";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.setting_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 11);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(240, 130);
            this.button5.TabIndex = 4;
            this.button5.Text = "판매";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.sale_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(258, 11);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(240, 130);
            this.button6.TabIndex = 5;
            this.button6.Text = "영수증 조회";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.receipt_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(258, 325);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(219, 100);
            this.button7.TabIndex = 6;
            this.button7.Text = "마감";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.finish_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 145);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(240, 130);
            this.button8.TabIndex = 7;
            this.button8.Text = "이익률 조회";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.rateofreturn_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(258, 145);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(240, 130);
            this.button9.TabIndex = 8;
            this.button9.Text = "판매실적 조회";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.salesfigures_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(584, 145);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(240, 130);
            this.button10.TabIndex = 9;
            this.button10.Text = "물품상세 조회";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.productinformation_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1087, 436);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}