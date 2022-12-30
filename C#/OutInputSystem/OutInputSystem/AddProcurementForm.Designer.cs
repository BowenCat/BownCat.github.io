namespace OutInputSystem
{
    partial class AddProcurementForm
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
            this.ProductsListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InputDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.QtyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.UniPriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Addbutton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QtyNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UniPriceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "貨品選擇";
            // 
            // ProductsListBox
            // 
            this.ProductsListBox.FormattingEnabled = true;
            this.ProductsListBox.ItemHeight = 18;
            this.ProductsListBox.Location = new System.Drawing.Point(41, 75);
            this.ProductsListBox.Name = "ProductsListBox";
            this.ProductsListBox.Size = new System.Drawing.Size(158, 130);
            this.ProductsListBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "進貨日期";
            // 
            // InputDateTimePicker
            // 
            this.InputDateTimePicker.Location = new System.Drawing.Point(41, 262);
            this.InputDateTimePicker.Name = "InputDateTimePicker";
            this.InputDateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.InputDateTimePicker.TabIndex = 3;
            // 
            // QtyNumericUpDown
            // 
            this.QtyNumericUpDown.Location = new System.Drawing.Point(220, 75);
            this.QtyNumericUpDown.Name = "QtyNumericUpDown";
            this.QtyNumericUpDown.Size = new System.Drawing.Size(120, 29);
            this.QtyNumericUpDown.TabIndex = 4;
            // 
            // UniPriceNumericUpDown
            // 
            this.UniPriceNumericUpDown.Location = new System.Drawing.Point(220, 176);
            this.UniPriceNumericUpDown.Name = "UniPriceNumericUpDown";
            this.UniPriceNumericUpDown.Size = new System.Drawing.Size(120, 29);
            this.UniPriceNumericUpDown.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "進貨數量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "單價";
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(46, 310);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(153, 61);
            this.Addbutton.TabIndex = 8;
            this.Addbutton.Text = "新增";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(239, 310);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(153, 61);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "關閉視窗";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AddProcurementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UniPriceNumericUpDown);
            this.Controls.Add(this.QtyNumericUpDown);
            this.Controls.Add(this.InputDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductsListBox);
            this.Controls.Add(this.label1);
            this.Name = "AddProcurementForm";
            this.Text = "AddProcurementForm";
            this.Load += new System.EventHandler(this.AddProcurementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QtyNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UniPriceNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ProductsListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker InputDateTimePicker;
        private System.Windows.Forms.NumericUpDown QtyNumericUpDown;
        private System.Windows.Forms.NumericUpDown UniPriceNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button CloseButton;
    }
}