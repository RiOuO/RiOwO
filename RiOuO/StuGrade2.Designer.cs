namespace Lab_StuGrade2
{
    partial class StuGrade2
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
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAllDel = new System.Windows.Forms.Button();
            this.labIndex = new System.Windows.Forms.Label();
            this.txtIndex1 = new System.Windows.Forms.TextBox();
            this.txtIndex2 = new System.Windows.Forms.TextBox();
            this.lab1 = new System.Windows.Forms.Label();
            this.btnSerch = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.En = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Math = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Average = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Min = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Max = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnFinal = new System.Windows.Forms.Button();
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(12, 24);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(67, 24);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名：";
            // 
            // labCn
            // 
            this.labCn.AutoSize = true;
            this.labCn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCn.Location = new System.Drawing.Point(12, 65);
            this.labCn.Name = "labCn";
            this.labCn.Size = new System.Drawing.Size(67, 24);
            this.labCn.TabIndex = 1;
            this.labCn.Text = "國文：";
            // 
            // labEn
            // 
            this.labEn.AutoSize = true;
            this.labEn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEn.Location = new System.Drawing.Point(12, 106);
            this.labEn.Name = "labEn";
            this.labEn.Size = new System.Drawing.Size(67, 24);
            this.labEn.TabIndex = 2;
            this.labEn.Text = "英文：";
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.Location = new System.Drawing.Point(12, 147);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(67, 24);
            this.labMath.TabIndex = 3;
            this.labMath.Text = "數學：";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(85, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 33);
            this.txtName.TabIndex = 4;
            // 
            // txtCn
            // 
            this.txtCn.AcceptsReturn = true;
            this.txtCn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCn.Location = new System.Drawing.Point(85, 61);
            this.txtCn.Name = "txtCn";
            this.txtCn.Size = new System.Drawing.Size(100, 33);
            this.txtCn.TabIndex = 5;
            // 
            // txtEn
            // 
            this.txtEn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEn.Location = new System.Drawing.Point(85, 101);
            this.txtEn.Name = "txtEn";
            this.txtEn.Size = new System.Drawing.Size(100, 33);
            this.txtEn.TabIndex = 6;
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMath.Location = new System.Drawing.Point(85, 143);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(100, 33);
            this.txtMath.TabIndex = 7;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddStudent.Location = new System.Drawing.Point(36, 186);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(136, 29);
            this.btnAddStudent.TabIndex = 8;
            this.btnAddStudent.Text = "加入學生資料";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInsert.Location = new System.Drawing.Point(36, 224);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(136, 29);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "插入儲存資料";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDel.Location = new System.Drawing.Point(36, 261);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(136, 29);
            this.btnDel.TabIndex = 10;
            this.btnDel.Text = "移除資料";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAllDel
            // 
            this.btnAllDel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAllDel.Location = new System.Drawing.Point(36, 299);
            this.btnAllDel.Name = "btnAllDel";
            this.btnAllDel.Size = new System.Drawing.Size(136, 29);
            this.btnAllDel.TabIndex = 11;
            this.btnAllDel.Text = "清除所有資料";
            this.btnAllDel.UseVisualStyleBackColor = true;
            this.btnAllDel.Click += new System.EventHandler(this.btnAllDel_Click);
            // 
            // labIndex
            // 
            this.labIndex.AutoSize = true;
            this.labIndex.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labIndex.Location = new System.Drawing.Point(43, 342);
            this.labIndex.Name = "labIndex";
            this.labIndex.Size = new System.Drawing.Size(125, 17);
            this.labIndex.TabIndex = 12;
            this.labIndex.Text = "搜尋國文成績範圍：";
            // 
            // txtIndex1
            // 
            this.txtIndex1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtIndex1.Location = new System.Drawing.Point(36, 372);
            this.txtIndex1.Name = "txtIndex1";
            this.txtIndex1.Size = new System.Drawing.Size(43, 29);
            this.txtIndex1.TabIndex = 13;
            // 
            // txtIndex2
            // 
            this.txtIndex2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtIndex2.Location = new System.Drawing.Point(125, 372);
            this.txtIndex2.Name = "txtIndex2";
            this.txtIndex2.Size = new System.Drawing.Size(43, 29);
            this.txtIndex2.TabIndex = 14;
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab1.Location = new System.Drawing.Point(95, 378);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(14, 17);
            this.lab1.TabIndex = 15;
            this.lab1.Text = "-";
            // 
            // btnSerch
            // 
            this.btnSerch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSerch.Location = new System.Drawing.Point(36, 409);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(136, 29);
            this.btnSerch.TabIndex = 16;
            this.btnSerch.Text = "SERCH";
            this.btnSerch.UseVisualStyleBackColor = true;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Cn,
            this.En,
            this.Math,
            this.Total,
            this.Average,
            this.Min,
            this.Max});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(210, 20);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(501, 251);
            this.listView1.TabIndex = 17;
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
            // 
            // En
            // 
            this.En.Text = "英文";
            // 
            // Math
            // 
            this.Math.Text = "數學";
            // 
            // Total
            // 
            this.Total.Text = "總分";
            // 
            // Average
            // 
            this.Average.Text = "平均";
            // 
            // Min
            // 
            this.Min.Text = "最低";
            // 
            // Max
            // 
            this.Max.Text = "最大";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView2.Enabled = false;
            this.listView2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(210, 288);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(501, 120);
            this.listView2.TabIndex = 18;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // btnFinal
            // 
            this.btnFinal.Enabled = false;
            this.btnFinal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFinal.Location = new System.Drawing.Point(575, 414);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(136, 29);
            this.btnFinal.TabIndex = 19;
            this.btnFinal.Text = "各科統計";
            this.btnFinal.UseVisualStyleBackColor = true;
            this.btnFinal.Click += new System.EventHandler(this.btnFinal_Click);
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(210, 20);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(501, 251);
            this.listView3.TabIndex = 20;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            this.listView3.Visible = false;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "姓名";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "國文";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "英文";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "數學";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "總分";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "平均";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "最低";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "最大";
            // 
            // StuGrade2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 450);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.btnFinal);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSerch);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.txtIndex2);
            this.Controls.Add(this.txtIndex1);
            this.Controls.Add(this.labIndex);
            this.Controls.Add(this.btnAllDel);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEn);
            this.Controls.Add(this.txtCn);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.labEn);
            this.Controls.Add(this.labCn);
            this.Controls.Add(this.labName);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Lab_StuGrade2_Load);
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
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAllDel;
        private System.Windows.Forms.Label labIndex;
        private System.Windows.Forms.TextBox txtIndex1;
        private System.Windows.Forms.TextBox txtIndex2;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Button btnSerch;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Cn;
        private System.Windows.Forms.ColumnHeader En;
        private System.Windows.Forms.ColumnHeader Math;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.ColumnHeader Average;
        private System.Windows.Forms.ColumnHeader Min;
        private System.Windows.Forms.ColumnHeader Max;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button btnFinal;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}

