namespace OutInputSystem
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.AddProductButton = new System.Windows.Forms.Button();
            this.AddSalesManButton = new System.Windows.Forms.Button();
            this.AddProcurementFormbutton = new System.Windows.Forms.Button();
            this.addSellingButton = new System.Windows.Forms.Button();
            this.searchSalesSellabutton = new System.Windows.Forms.Button();
            this.searchStuckButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(35, 30);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(148, 58);
            this.AddProductButton.TabIndex = 0;
            this.AddProductButton.Text = "新增貨品";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // AddSalesManButton
            // 
            this.AddSalesManButton.Location = new System.Drawing.Point(35, 110);
            this.AddSalesManButton.Name = "AddSalesManButton";
            this.AddSalesManButton.Size = new System.Drawing.Size(148, 58);
            this.AddSalesManButton.TabIndex = 1;
            this.AddSalesManButton.Text = "新增銷售人員";
            this.AddSalesManButton.UseVisualStyleBackColor = true;
            this.AddSalesManButton.Click += new System.EventHandler(this.AddSalesManButton_Click);
            // 
            // AddProcurementFormbutton
            // 
            this.AddProcurementFormbutton.Location = new System.Drawing.Point(35, 188);
            this.AddProcurementFormbutton.Name = "AddProcurementFormbutton";
            this.AddProcurementFormbutton.Size = new System.Drawing.Size(148, 58);
            this.AddProcurementFormbutton.TabIndex = 2;
            this.AddProcurementFormbutton.Text = "新增進貨資料";
            this.AddProcurementFormbutton.UseVisualStyleBackColor = true;
            this.AddProcurementFormbutton.Click += new System.EventHandler(this.AddProcurementFormbutton_Click);
            // 
            // addSellingButton
            // 
            this.addSellingButton.Location = new System.Drawing.Point(35, 266);
            this.addSellingButton.Name = "addSellingButton";
            this.addSellingButton.Size = new System.Drawing.Size(148, 58);
            this.addSellingButton.TabIndex = 3;
            this.addSellingButton.Text = "新增出貨資料";
            this.addSellingButton.UseVisualStyleBackColor = true;
            this.addSellingButton.Click += new System.EventHandler(this.addSellingButton_Click);
            // 
            // searchSalesSellabutton
            // 
            this.searchSalesSellabutton.Location = new System.Drawing.Point(208, 30);
            this.searchSalesSellabutton.Name = "searchSalesSellabutton";
            this.searchSalesSellabutton.Size = new System.Drawing.Size(163, 58);
            this.searchSalesSellabutton.TabIndex = 4;
            this.searchSalesSellabutton.Text = "查詢銷售人員出貨";
            this.searchSalesSellabutton.UseVisualStyleBackColor = true;
            this.searchSalesSellabutton.Click += new System.EventHandler(this.searchSalesSellabutton_Click);
            // 
            // searchStuckButton
            // 
            this.searchStuckButton.Location = new System.Drawing.Point(208, 110);
            this.searchStuckButton.Name = "searchStuckButton";
            this.searchStuckButton.Size = new System.Drawing.Size(163, 58);
            this.searchStuckButton.TabIndex = 6;
            this.searchStuckButton.Text = "查詢庫存總表";
            this.searchStuckButton.UseVisualStyleBackColor = true;
            this.searchStuckButton.Click += new System.EventHandler(this.searchStuckButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchStuckButton);
            this.Controls.Add(this.searchSalesSellabutton);
            this.Controls.Add(this.addSellingButton);
            this.Controls.Add(this.AddProcurementFormbutton);
            this.Controls.Add(this.AddSalesManButton);
            this.Controls.Add(this.AddProductButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button AddSalesManButton;
        private System.Windows.Forms.Button AddProcurementFormbutton;
        private System.Windows.Forms.Button addSellingButton;
        private System.Windows.Forms.Button searchSalesSellabutton;
        private System.Windows.Forms.Button searchStuckButton;
    }
}

