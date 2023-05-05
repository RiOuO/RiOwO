namespace Lab_Loan
{
    partial class Loan
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
            this.labMoney = new System.Windows.Forms.Label();
            this.labYear = new System.Windows.Forms.Label();
            this.labYearRate = new System.Windows.Forms.Label();
            this.labFirst = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtYearRate = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.btnMonPMT = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labMoney
            // 
            this.labMoney.AutoSize = true;
            this.labMoney.Location = new System.Drawing.Point(46, 42);
            this.labMoney.Name = "labMoney";
            this.labMoney.Size = new System.Drawing.Size(53, 12);
            this.labMoney.TabIndex = 0;
            this.labMoney.Text = "貸款金額";
            // 
            // labYear
            // 
            this.labYear.AutoSize = true;
            this.labYear.Location = new System.Drawing.Point(46, 91);
            this.labYear.Name = "labYear";
            this.labYear.Size = new System.Drawing.Size(49, 12);
            this.labYear.TabIndex = 1;
            this.labYear.Text = "期限(年)";
            // 
            // labYearRate
            // 
            this.labYearRate.AutoSize = true;
            this.labYearRate.Location = new System.Drawing.Point(46, 140);
            this.labYearRate.Name = "labYearRate";
            this.labYearRate.Size = new System.Drawing.Size(58, 12);
            this.labYearRate.TabIndex = 2;
            this.labYearRate.Text = "年利率(%)";
            // 
            // labFirst
            // 
            this.labFirst.AutoSize = true;
            this.labFirst.Location = new System.Drawing.Point(46, 196);
            this.labFirst.Name = "labFirst";
            this.labFirst.Size = new System.Drawing.Size(41, 12);
            this.labFirst.TabIndex = 3;
            this.labFirst.Text = "頭期款";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(244, 189);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(100, 22);
            this.txtFirst.TabIndex = 4;
            this.txtFirst.Text = "0";
            // 
            // txtYearRate
            // 
            this.txtYearRate.Location = new System.Drawing.Point(244, 133);
            this.txtYearRate.Name = "txtYearRate";
            this.txtYearRate.Size = new System.Drawing.Size(100, 22);
            this.txtYearRate.TabIndex = 5;
            this.txtYearRate.Text = "10";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(244, 84);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 22);
            this.txtYear.TabIndex = 6;
            this.txtYear.Text = "2";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(244, 35);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(100, 22);
            this.txtMoney.TabIndex = 7;
            this.txtMoney.Text = "100000";
            // 
            // btnMonPMT
            // 
            this.btnMonPMT.Location = new System.Drawing.Point(48, 321);
            this.btnMonPMT.Name = "btnMonPMT";
            this.btnMonPMT.Size = new System.Drawing.Size(75, 23);
            this.btnMonPMT.TabIndex = 8;
            this.btnMonPMT.Text = "PMT(月付)";
            this.btnMonPMT.UseVisualStyleBackColor = true;
            this.btnMonPMT.Click += new System.EventHandler(this.btnMonPMT_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(173, 321);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(75, 23);
            this.btnTotal.TabIndex = 9;
            this.btnTotal.Text = "總付款";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(291, 321);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 10;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 453);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnMonPMT);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtYearRate);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.labFirst);
            this.Controls.Add(this.labYearRate);
            this.Controls.Add(this.labYear);
            this.Controls.Add(this.labMoney);
            this.Name = "Loan";
            this.Text = "貸款金額計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labMoney;
        private System.Windows.Forms.Label labYear;
        private System.Windows.Forms.Label labYearRate;
        private System.Windows.Forms.Label labFirst;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtYearRate;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Button btnMonPMT;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnReport;
    }
}

