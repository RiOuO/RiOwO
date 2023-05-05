namespace Lab_Hello
{
    partial class Hello
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hello));
            this.labCnName = new System.Windows.Forms.Label();
            this.labEnName = new System.Windows.Forms.Label();
            this.labSex = new System.Windows.Forms.Label();
            this.labCon = new System.Windows.Forms.Label();
            this.txtCnName = new System.Windows.Forms.TextBox();
            this.txtEnName = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtCon = new System.Windows.Forms.TextBox();
            this.btnHello = new System.Windows.Forms.Button();
            this.btnHi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labCnName
            // 
            this.labCnName.AutoSize = true;
            this.labCnName.BackColor = System.Drawing.SystemColors.Control;
            this.labCnName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labCnName.Location = new System.Drawing.Point(34, 57);
            this.labCnName.Name = "labCnName";
            this.labCnName.Size = new System.Drawing.Size(32, 12);
            this.labCnName.TabIndex = 0;
            this.labCnName.Text = "姓名:";
            // 
            // labEnName
            // 
            this.labEnName.AutoSize = true;
            this.labEnName.BackColor = System.Drawing.SystemColors.Control;
            this.labEnName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labEnName.Location = new System.Drawing.Point(34, 99);
            this.labEnName.Name = "labEnName";
            this.labEnName.Size = new System.Drawing.Size(56, 12);
            this.labEnName.TabIndex = 1;
            this.labEnName.Text = "英文姓名:";
            // 
            // labSex
            // 
            this.labSex.AutoSize = true;
            this.labSex.BackColor = System.Drawing.SystemColors.Control;
            this.labSex.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labSex.Location = new System.Drawing.Point(34, 132);
            this.labSex.Name = "labSex";
            this.labSex.Size = new System.Drawing.Size(32, 12);
            this.labSex.TabIndex = 2;
            this.labSex.Text = "性別:";
            // 
            // labCon
            // 
            this.labCon.AutoSize = true;
            this.labCon.BackColor = System.Drawing.SystemColors.Control;
            this.labCon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labCon.Location = new System.Drawing.Point(34, 170);
            this.labCon.Name = "labCon";
            this.labCon.Size = new System.Drawing.Size(32, 12);
            this.labCon.TabIndex = 3;
            this.labCon.Text = "星座:";
            // 
            // txtCnName
            // 
            this.txtCnName.Location = new System.Drawing.Point(117, 54);
            this.txtCnName.Name = "txtCnName";
            this.txtCnName.Size = new System.Drawing.Size(100, 22);
            this.txtCnName.TabIndex = 4;
            // 
            // txtEnName
            // 
            this.txtEnName.Location = new System.Drawing.Point(117, 91);
            this.txtEnName.Name = "txtEnName";
            this.txtEnName.Size = new System.Drawing.Size(100, 22);
            this.txtEnName.TabIndex = 5;
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(117, 129);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(100, 22);
            this.txtSex.TabIndex = 6;
            // 
            // txtCon
            // 
            this.txtCon.Location = new System.Drawing.Point(117, 166);
            this.txtCon.Name = "txtCon";
            this.txtCon.Size = new System.Drawing.Size(100, 22);
            this.txtCon.TabIndex = 7;
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(36, 227);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(75, 23);
            this.btnHello.TabIndex = 8;
            this.btnHello.Text = "Say Hello!";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // btnHi
            // 
            this.btnHi.Location = new System.Drawing.Point(142, 227);
            this.btnHi.Name = "btnHi";
            this.btnHi.Size = new System.Drawing.Size(75, 23);
            this.btnHi.TabIndex = 9;
            this.btnHi.Text = "Say Hi!";
            this.btnHi.UseVisualStyleBackColor = true;
            this.btnHi.Click += new System.EventHandler(this.btnHi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(493, 327);
            this.Controls.Add(this.btnHi);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.txtCon);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtEnName);
            this.Controls.Add(this.txtCnName);
            this.Controls.Add(this.labCon);
            this.Controls.Add(this.labSex);
            this.Controls.Add(this.labEnName);
            this.Controls.Add(this.labCnName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCnName;
        private System.Windows.Forms.Label labEnName;
        private System.Windows.Forms.Label labSex;
        private System.Windows.Forms.Label labCon;
        private System.Windows.Forms.TextBox txtCnName;
        private System.Windows.Forms.TextBox txtEnName;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtCon;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Button btnHi;
    }
}

