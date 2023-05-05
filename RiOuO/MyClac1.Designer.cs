namespace MyClac
{
    partial class MyClac1
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
            this.btnChen = new System.Windows.Forms.Button();
            this.btnZen = new System.Windows.Forms.Button();
            this.btnCha = new System.Windows.Forms.Button();
            this.btnChu = new System.Windows.Forms.Button();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.labNumber1 = new System.Windows.Forms.Label();
            this.labNumber2 = new System.Windows.Forms.Label();
            this.labResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChen
            // 
            this.btnChen.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnChen.Location = new System.Drawing.Point(124, 139);
            this.btnChen.Name = "btnChen";
            this.btnChen.Size = new System.Drawing.Size(48, 33);
            this.btnChen.TabIndex = 0;
            this.btnChen.Text = "*";
            this.btnChen.UseVisualStyleBackColor = true;
            this.btnChen.Click += new System.EventHandler(this.btnChen_Click);
            // 
            // btnZen
            // 
            this.btnZen.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnZen.Location = new System.Drawing.Point(70, 139);
            this.btnZen.Name = "btnZen";
            this.btnZen.Size = new System.Drawing.Size(48, 33);
            this.btnZen.TabIndex = 1;
            this.btnZen.Text = "-";
            this.btnZen.UseVisualStyleBackColor = true;
            this.btnZen.Click += new System.EventHandler(this.btnZen_Click);
            // 
            // btnCha
            // 
            this.btnCha.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCha.Location = new System.Drawing.Point(16, 139);
            this.btnCha.Name = "btnCha";
            this.btnCha.Size = new System.Drawing.Size(48, 33);
            this.btnCha.TabIndex = 2;
            this.btnCha.Text = "+";
            this.btnCha.UseVisualStyleBackColor = true;
            this.btnCha.Click += new System.EventHandler(this.btnCha_Click);
            // 
            // btnChu
            // 
            this.btnChu.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnChu.Location = new System.Drawing.Point(178, 139);
            this.btnChu.Name = "btnChu";
            this.btnChu.Size = new System.Drawing.Size(48, 33);
            this.btnChu.TabIndex = 3;
            this.btnChu.Text = "/";
            this.btnChu.UseVisualStyleBackColor = true;
            this.btnChu.Click += new System.EventHandler(this.btnChu_Click);
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(116, 55);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(100, 22);
            this.txtNumber1.TabIndex = 4;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(116, 101);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(100, 22);
            this.txtNumber2.TabIndex = 5;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(116, 185);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 22);
            this.txtResult.TabIndex = 6;
            // 
            // labNumber1
            // 
            this.labNumber1.AutoSize = true;
            this.labNumber1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNumber1.Location = new System.Drawing.Point(10, 52);
            this.labNumber1.Name = "labNumber1";
            this.labNumber1.Size = new System.Drawing.Size(96, 24);
            this.labNumber1.TabIndex = 7;
            this.labNumber1.Text = "Number1";
            // 
            // labNumber2
            // 
            this.labNumber2.AutoSize = true;
            this.labNumber2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNumber2.Location = new System.Drawing.Point(12, 101);
            this.labNumber2.Name = "labNumber2";
            this.labNumber2.Size = new System.Drawing.Size(96, 24);
            this.labNumber2.TabIndex = 8;
            this.labNumber2.Text = "Number2";
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labResult.Location = new System.Drawing.Point(25, 185);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(66, 24);
            this.labResult.TabIndex = 9;
            this.labResult.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 249);
            this.Controls.Add(this.labResult);
            this.Controls.Add(this.labNumber2);
            this.Controls.Add(this.labNumber1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.btnChu);
            this.Controls.Add(this.btnCha);
            this.Controls.Add(this.btnZen);
            this.Controls.Add(this.btnChen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChen;
        private System.Windows.Forms.Button btnZen;
        private System.Windows.Forms.Button btnCha;
        private System.Windows.Forms.Button btnChu;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label labNumber1;
        private System.Windows.Forms.Label labNumber2;
        private System.Windows.Forms.Label labResult;
    }
}

