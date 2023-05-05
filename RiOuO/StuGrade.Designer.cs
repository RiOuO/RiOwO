namespace Lab_StuGrade
{
    partial class StuGrade
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
            this.txtMath = new System.Windows.Forms.TextBox();
            this.txtEn = new System.Windows.Forms.TextBox();
            this.btnAddStudentData = new System.Windows.Forms.Button();
            this.btnRandomSave = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRando20 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.En = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Math = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Average = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Min = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Max = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(12, 26);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(57, 20);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名：";
            // 
            // labCn
            // 
            this.labCn.AutoSize = true;
            this.labCn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCn.Location = new System.Drawing.Point(12, 75);
            this.labCn.Name = "labCn";
            this.labCn.Size = new System.Drawing.Size(57, 20);
            this.labCn.TabIndex = 1;
            this.labCn.Text = "國文：";
            // 
            // labEn
            // 
            this.labEn.AutoSize = true;
            this.labEn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEn.Location = new System.Drawing.Point(12, 126);
            this.labEn.Name = "labEn";
            this.labEn.Size = new System.Drawing.Size(57, 20);
            this.labEn.TabIndex = 2;
            this.labEn.Text = "英文：";
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.Location = new System.Drawing.Point(12, 176);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(57, 20);
            this.labMath.TabIndex = 3;
            this.labMath.Text = "數學：";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(75, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(75, 29);
            this.txtName.TabIndex = 4;
            // 
            // txtCn
            // 
            this.txtCn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCn.Location = new System.Drawing.Point(75, 72);
            this.txtCn.Name = "txtCn";
            this.txtCn.Size = new System.Drawing.Size(75, 29);
            this.txtCn.TabIndex = 5;
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMath.Location = new System.Drawing.Point(75, 172);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(75, 29);
            this.txtMath.TabIndex = 7;
            // 
            // txtEn
            // 
            this.txtEn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEn.Location = new System.Drawing.Point(75, 123);
            this.txtEn.Name = "txtEn";
            this.txtEn.Size = new System.Drawing.Size(75, 29);
            this.txtEn.TabIndex = 6;
            // 
            // btnAddStudentData
            // 
            this.btnAddStudentData.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddStudentData.Location = new System.Drawing.Point(25, 219);
            this.btnAddStudentData.Name = "btnAddStudentData";
            this.btnAddStudentData.Size = new System.Drawing.Size(116, 34);
            this.btnAddStudentData.TabIndex = 8;
            this.btnAddStudentData.Text = "加入學生資料";
            this.btnAddStudentData.UseVisualStyleBackColor = true;
            this.btnAddStudentData.Click += new System.EventHandler(this.btnAddStudentData_Click);
            // 
            // btnRandomSave
            // 
            this.btnRandomSave.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRandomSave.Location = new System.Drawing.Point(25, 262);
            this.btnRandomSave.Name = "btnRandomSave";
            this.btnRandomSave.Size = new System.Drawing.Size(116, 34);
            this.btnRandomSave.TabIndex = 9;
            this.btnRandomSave.Text = "隨機儲存資料";
            this.btnRandomSave.UseVisualStyleBackColor = true;
            this.btnRandomSave.Click += new System.EventHandler(this.btnRandomSave_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Enabled = false;
            this.btnStatistics.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStatistics.Location = new System.Drawing.Point(25, 304);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(116, 34);
            this.btnStatistics.TabIndex = 10;
            this.btnStatistics.Text = "各科統計";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.Location = new System.Drawing.Point(25, 369);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(116, 34);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "重設所有資料";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRando20
            // 
            this.btnRando20.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRando20.Location = new System.Drawing.Point(25, 407);
            this.btnRando20.Name = "btnRando20";
            this.btnRando20.Size = new System.Drawing.Size(116, 34);
            this.btnRando20.TabIndex = 12;
            this.btnRando20.Text = "隨機加入20筆資料";
            this.btnRando20.UseVisualStyleBackColor = true;
            this.btnRando20.Click += new System.EventHandler(this.btnRando20_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.BackgroundImageTiled = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Cn,
            this.En,
            this.Math,
            this.total,
            this.Average,
            this.Min,
            this.Max});
            this.listView1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listView1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(166, 26);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(511, 278);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Text = "姓名";
            // 
            // Cn
            // 
            this.Cn.Text = "國文";
            this.Cn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // En
            // 
            this.En.Text = "英文";
            this.En.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Math
            // 
            this.Math.Text = "數學";
            this.Math.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // total
            // 
            this.total.Text = "總分";
            this.total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Average
            // 
            this.Average.Text = "平均";
            this.Average.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Average.Width = 59;
            // 
            // Min
            // 
            this.Min.Text = "最低";
            this.Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Max
            // 
            this.Max.Text = "最高";
            this.Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // listView2
            // 
            this.listView2.BackgroundImageTiled = true;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView2.Enabled = false;
            this.listView2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(166, 310);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(511, 131);
            this.listView2.TabIndex = 14;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // StuGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(689, 463);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnRando20);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnRandomSave);
            this.Controls.Add(this.btnAddStudentData);
            this.Controls.Add(this.txtEn);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtCn);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.labEn);
            this.Controls.Add(this.labCn);
            this.Controls.Add(this.labName);
            this.Text = "Lab_StuGrade";
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
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.TextBox txtEn;
        private System.Windows.Forms.Button btnAddStudentData;
        private System.Windows.Forms.Button btnRandomSave;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRando20;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Cn;
        private System.Windows.Forms.ColumnHeader En;
        private System.Windows.Forms.ColumnHeader Math;
        private System.Windows.Forms.ColumnHeader total;
        private System.Windows.Forms.ColumnHeader Average;
        private System.Windows.Forms.ColumnHeader Min;
        private System.Windows.Forms.ColumnHeader Max;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

