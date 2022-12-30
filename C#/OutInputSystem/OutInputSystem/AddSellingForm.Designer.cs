namespace OutInputSystem
{
    partial class AddSellingForm
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
            this.ProductsListBox = new System.Windows.Forms.ListBox();
            this.SalesManListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.outPutNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.uniPriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.outPutDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.outPutNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniPriceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsListBox
            // 
            this.ProductsListBox.FormattingEnabled = true;
            this.ProductsListBox.ItemHeight = 18;
            this.ProductsListBox.Location = new System.Drawing.Point(45, 93);
            this.ProductsListBox.Name = "ProductsListBox";
            this.ProductsListBox.Size = new System.Drawing.Size(129, 130);
            this.ProductsListBox.TabIndex = 0;
            // 
            // SalesManListBox
            // 
            this.SalesManListBox.FormattingEnabled = true;
            this.SalesManListBox.ItemHeight = 18;
            this.SalesManListBox.Location = new System.Drawing.Point(346, 93);
            this.SalesManListBox.Name = "SalesManListBox";
            this.SalesManListBox.Size = new System.Drawing.Size(126, 130);
            this.SalesManListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "貨品選擇";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "出貨數量";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "單價";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "銷售人員";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "出貨日期";
            // 
            // outPutNumericUpDown
            // 
            this.outPutNumericUpDown.Location = new System.Drawing.Point(197, 93);
            this.outPutNumericUpDown.Name = "outPutNumericUpDown";
            this.outPutNumericUpDown.Size = new System.Drawing.Size(120, 29);
            this.outPutNumericUpDown.TabIndex = 7;
            // 
            // uniPriceNumericUpDown
            // 
            this.uniPriceNumericUpDown.Location = new System.Drawing.Point(197, 194);
            this.uniPriceNumericUpDown.Name = "uniPriceNumericUpDown";
            this.uniPriceNumericUpDown.Size = new System.Drawing.Size(120, 29);
            this.uniPriceNumericUpDown.TabIndex = 8;
            // 
            // outPutDateTimePicker
            // 
            this.outPutDateTimePicker.Location = new System.Drawing.Point(45, 276);
            this.outPutDateTimePicker.Name = "outPutDateTimePicker";
            this.outPutDateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.outPutDateTimePicker.TabIndex = 9;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(98, 325);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(140, 51);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "新增出貨";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(279, 325);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(144, 51);
            this.closeButton.TabIndex = 11;
            this.closeButton.Text = "關閉視窗";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // AddSellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.outPutDateTimePicker);
            this.Controls.Add(this.uniPriceNumericUpDown);
            this.Controls.Add(this.outPutNumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SalesManListBox);
            this.Controls.Add(this.ProductsListBox);
            this.Name = "AddSellingForm";
            this.Text = "AddSellingForm";
            this.Load += new System.EventHandler(this.AddSellingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.outPutNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniPriceNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ProductsListBox;
        private System.Windows.Forms.ListBox SalesManListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown outPutNumericUpDown;
        private System.Windows.Forms.NumericUpDown uniPriceNumericUpDown;
        private System.Windows.Forms.DateTimePicker outPutDateTimePicker;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button closeButton;
    }
}