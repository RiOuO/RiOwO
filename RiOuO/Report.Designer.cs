namespace Lab_Loan
{
    partial class Report
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
            this.labReMoney = new System.Windows.Forms.Label();
            this.labReYear = new System.Windows.Forms.Label();
            this.labReRate = new System.Windows.Forms.Label();
            this.labRePMTMon = new System.Windows.Forms.Label();
            this.labReTotal = new System.Windows.Forms.Label();
            this.txtReYear = new System.Windows.Forms.TextBox();
            this.txtReYearRate = new System.Windows.Forms.TextBox();
            this.txtRePMTMon = new System.Windows.Forms.TextBox();
            this.txtReTotal = new System.Windows.Forms.TextBox();
            this.btnEmail = new System.Windows.Forms.Button();
            this.txtReMoney = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labReMoney
            // 
            this.labReMoney.AutoSize = true;
            this.labReMoney.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labReMoney.Location = new System.Drawing.Point(68, 47);
            this.labReMoney.Name = "labReMoney";
            this.labReMoney.Size = new System.Drawing.Size(90, 19);
            this.labReMoney.TabIndex = 0;
            this.labReMoney.Text = "貸款金額:";
            // 
            // labReYear
            // 
            this.labReYear.AutoSize = true;
            this.labReYear.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labReYear.Location = new System.Drawing.Point(68, 99);
            this.labReYear.Name = "labReYear";
            this.labReYear.Size = new System.Drawing.Size(83, 19);
            this.labReYear.TabIndex = 1;
            this.labReYear.Text = "期限(年):";
            // 
            // labReRate
            // 
            this.labReRate.AutoSize = true;
            this.labReRate.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labReRate.Location = new System.Drawing.Point(68, 150);
            this.labReRate.Name = "labReRate";
            this.labReRate.Size = new System.Drawing.Size(79, 19);
            this.labReRate.TabIndex = 2;
            this.labReRate.Text = "利率(%):";
            // 
            // labRePMTMon
            // 
            this.labRePMTMon.AutoSize = true;
            this.labRePMTMon.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labRePMTMon.Location = new System.Drawing.Point(68, 204);
            this.labRePMTMon.Name = "labRePMTMon";
            this.labRePMTMon.Size = new System.Drawing.Size(71, 19);
            this.labRePMTMon.TabIndex = 3;
            this.labRePMTMon.Text = "月付款:";
            // 
            // labReTotal
            // 
            this.labReTotal.AutoSize = true;
            this.labReTotal.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labReTotal.Location = new System.Drawing.Point(68, 252);
            this.labReTotal.Name = "labReTotal";
            this.labReTotal.Size = new System.Drawing.Size(71, 19);
            this.labReTotal.TabIndex = 4;
            this.labReTotal.Text = "總付款:";
            // 
            // txtReYear
            // 
            this.txtReYear.Location = new System.Drawing.Point(172, 96);
            this.txtReYear.Name = "txtReYear";
            this.txtReYear.ReadOnly = true;
            this.txtReYear.Size = new System.Drawing.Size(100, 22);
            this.txtReYear.TabIndex = 5;
            // 
            // txtReYearRate
            // 
            this.txtReYearRate.Location = new System.Drawing.Point(172, 147);
            this.txtReYearRate.Name = "txtReYearRate";
            this.txtReYearRate.ReadOnly = true;
            this.txtReYearRate.Size = new System.Drawing.Size(100, 22);
            this.txtReYearRate.TabIndex = 6;
            // 
            // txtRePMTMon
            // 
            this.txtRePMTMon.Location = new System.Drawing.Point(172, 201);
            this.txtRePMTMon.Name = "txtRePMTMon";
            this.txtRePMTMon.ReadOnly = true;
            this.txtRePMTMon.Size = new System.Drawing.Size(100, 22);
            this.txtRePMTMon.TabIndex = 7;
            // 
            // txtReTotal
            // 
            this.txtReTotal.Location = new System.Drawing.Point(172, 249);
            this.txtReTotal.Name = "txtReTotal";
            this.txtReTotal.ReadOnly = true;
            this.txtReTotal.Size = new System.Drawing.Size(100, 22);
            this.txtReTotal.TabIndex = 8;
            // 
            // btnEmail
            // 
            this.btnEmail.Location = new System.Drawing.Point(98, 303);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(114, 43);
            this.btnEmail.TabIndex = 9;
            this.btnEmail.Text = "Email";
            this.btnEmail.UseVisualStyleBackColor = true;
            // 
            // txtReMoney
            // 
            this.txtReMoney.Location = new System.Drawing.Point(172, 44);
            this.txtReMoney.Name = "txtReMoney";
            this.txtReMoney.ReadOnly = true;
            this.txtReMoney.Size = new System.Drawing.Size(100, 22);
            this.txtReMoney.TabIndex = 10;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 372);
            this.Controls.Add(this.txtReMoney);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.txtReTotal);
            this.Controls.Add(this.txtRePMTMon);
            this.Controls.Add(this.txtReYearRate);
            this.Controls.Add(this.txtReYear);
            this.Controls.Add(this.labReTotal);
            this.Controls.Add(this.labRePMTMon);
            this.Controls.Add(this.labReRate);
            this.Controls.Add(this.labReYear);
            this.Controls.Add(this.labReMoney);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labReMoney;
        private System.Windows.Forms.Label labReYear;
        private System.Windows.Forms.Label labReRate;
        private System.Windows.Forms.Label labRePMTMon;
        private System.Windows.Forms.Label labReTotal;
        private System.Windows.Forms.TextBox txtReYear;
        private System.Windows.Forms.TextBox txtReYearRate;
        private System.Windows.Forms.TextBox txtRePMTMon;
        private System.Windows.Forms.TextBox txtReTotal;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.TextBox txtReMoney;
    }
}