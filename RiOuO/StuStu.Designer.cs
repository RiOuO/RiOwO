namespace Lab_StuStu
{
    partial class Frm_StuStu
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
            this.labName = new System.Windows.Forms.Label();
            this.labCn = new System.Windows.Forms.Label();
            this.labEn = new System.Windows.Forms.Label();
            this.labMath = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCn = new System.Windows.Forms.TextBox();
            this.txtEn = new System.Windows.Forms.TextBox();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLook = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.groupChen = new System.Windows.Forms.GroupBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.groupChen.SuspendLayout();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(16, 42);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(57, 20);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名：";
            // 
            // labCn
            // 
            this.labCn.AutoSize = true;
            this.labCn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCn.Location = new System.Drawing.Point(16, 92);
            this.labCn.Name = "labCn";
            this.labCn.Size = new System.Drawing.Size(57, 20);
            this.labCn.TabIndex = 1;
            this.labCn.Text = "國文：";
            // 
            // labEn
            // 
            this.labEn.AutoSize = true;
            this.labEn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEn.Location = new System.Drawing.Point(16, 139);
            this.labEn.Name = "labEn";
            this.labEn.Size = new System.Drawing.Size(57, 20);
            this.labEn.TabIndex = 2;
            this.labEn.Text = "英文：";
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.Location = new System.Drawing.Point(16, 192);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(57, 20);
            this.labMath.TabIndex = 3;
            this.labMath.Text = "數學：";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(97, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 33);
            this.txtName.TabIndex = 4;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCn
            // 
            this.txtCn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCn.Location = new System.Drawing.Point(97, 92);
            this.txtCn.Name = "txtCn";
            this.txtCn.Size = new System.Drawing.Size(100, 33);
            this.txtCn.TabIndex = 5;
            this.txtCn.Text = "0";
            this.txtCn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEn
            // 
            this.txtEn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEn.Location = new System.Drawing.Point(97, 139);
            this.txtEn.Name = "txtEn";
            this.txtEn.Size = new System.Drawing.Size(100, 33);
            this.txtEn.TabIndex = 6;
            this.txtEn.Text = "0";
            this.txtEn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMath
            // 
            this.txtMath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMath.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMath.Location = new System.Drawing.Point(97, 192);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(100, 33);
            this.txtMath.TabIndex = 7;
            this.txtMath.Text = "0";
            this.txtMath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(14, 282);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 31);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLook
            // 
            this.btnLook.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLook.Location = new System.Drawing.Point(97, 282);
            this.btnLook.Name = "btnLook";
            this.btnLook.Size = new System.Drawing.Size(119, 31);
            this.btnLook.TabIndex = 9;
            this.btnLook.Text = "顯示儲存內容";
            this.btnLook.UseVisualStyleBackColor = true;
            this.btnLook.Click += new System.EventHandler(this.btnLook_Click);
            // 
            // btnTop
            // 
            this.btnTop.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTop.Location = new System.Drawing.Point(333, 282);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(164, 31);
            this.btnTop.TabIndex = 10;
            this.btnTop.Text = "最高分/最低分科目";
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // groupChen
            // 
            this.groupChen.Controls.Add(this.txt2);
            this.groupChen.Controls.Add(this.txt1);
            this.groupChen.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupChen.Location = new System.Drawing.Point(223, 16);
            this.groupChen.Name = "groupChen";
            this.groupChen.Size = new System.Drawing.Size(348, 256);
            this.groupChen.TabIndex = 11;
            this.groupChen.TabStop = false;
            this.groupChen.Text = "成績";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(6, 163);
            this.txt2.Multiline = true;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(336, 87);
            this.txt2.TabIndex = 13;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(6, 26);
            this.txt1.Multiline = true;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(336, 131);
            this.txt1.TabIndex = 12;
            // 
            // Frm_StuStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 325);
            this.Controls.Add(this.groupChen);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.btnLook);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEn);
            this.Controls.Add(this.txtCn);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.labEn);
            this.Controls.Add(this.labCn);
            this.Controls.Add(this.labName);
            this.Name = "Frm_StuStu";
            this.Text = "StuStu";
            this.groupChen.ResumeLayout(false);
            this.groupChen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labCn;
        private System.Windows.Forms.Label labEn;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCn;
        private System.Windows.Forms.TextBox txtEn;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLook;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.GroupBox groupChen;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
    }
}

