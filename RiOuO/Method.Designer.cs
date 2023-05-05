namespace Lab_Method
{
    partial class Method
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
            this.labNumber = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.labResult = new System.Windows.Forms.Label();
            this.labResultOutPut = new System.Windows.Forms.Label();
            this.btnEven = new System.Windows.Forms.Button();
            this.btnArr = new System.Windows.Forms.Button();
            this.btnArrEven = new System.Windows.Forms.Button();
            this.btnArrTotal = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStrEande = new System.Windows.Forms.Button();
            this.btn1and0 = new System.Windows.Forms.Button();
            this.btn1010 = new System.Windows.Forms.Button();
            this.btnloto = new System.Windows.Forms.Button();
            this.btnTree = new System.Windows.Forms.Button();
            this.txtTree = new System.Windows.Forms.TextBox();
            this.btn100To2 = new System.Windows.Forms.Button();
            this.btn99 = new System.Windows.Forms.Button();
            this.btnFor = new System.Windows.Forms.Button();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtStep = new System.Windows.Forms.TextBox();
            this.labF = new System.Windows.Forms.Label();
            this.labTo = new System.Windows.Forms.Label();
            this.labStep = new System.Windows.Forms.Label();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnDo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labNumber
            // 
            this.labNumber.AutoSize = true;
            this.labNumber.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNumber.Location = new System.Drawing.Point(12, 27);
            this.labNumber.Name = "labNumber";
            this.labNumber.Size = new System.Drawing.Size(89, 24);
            this.labNumber.TabIndex = 0;
            this.labNumber.Text = "Number:";
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNumber.Location = new System.Drawing.Point(103, 27);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 29);
            this.txtNumber.TabIndex = 1;
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labResult.Location = new System.Drawing.Point(12, 303);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(70, 24);
            this.labResult.TabIndex = 2;
            this.labResult.Text = "Result:";
            // 
            // labResultOutPut
            // 
            this.labResultOutPut.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labResultOutPut.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labResultOutPut.Location = new System.Drawing.Point(88, 307);
            this.labResultOutPut.Name = "labResultOutPut";
            this.labResultOutPut.Size = new System.Drawing.Size(682, 194);
            this.labResultOutPut.TabIndex = 3;
            this.labResultOutPut.Text = "結果";
            // 
            // btnEven
            // 
            this.btnEven.AutoSize = true;
            this.btnEven.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEven.Location = new System.Drawing.Point(16, 78);
            this.btnEven.Name = "btnEven";
            this.btnEven.Size = new System.Drawing.Size(187, 30);
            this.btnEven.TabIndex = 4;
            this.btnEven.Text = "輸入的為偶數還是奇數?";
            this.btnEven.UseVisualStyleBackColor = true;
            this.btnEven.Click += new System.EventHandler(this.btnEven_Click);
            // 
            // btnArr
            // 
            this.btnArr.AutoSize = true;
            this.btnArr.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnArr.Location = new System.Drawing.Point(16, 126);
            this.btnArr.Name = "btnArr";
            this.btnArr.Size = new System.Drawing.Size(187, 30);
            this.btnArr.TabIndex = 5;
            this.btnArr.Text = "陣列arr最大最小值";
            this.btnArr.UseVisualStyleBackColor = true;
            this.btnArr.Click += new System.EventHandler(this.btnArr_Click);
            // 
            // btnArrEven
            // 
            this.btnArrEven.AutoSize = true;
            this.btnArrEven.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnArrEven.Location = new System.Drawing.Point(16, 172);
            this.btnArrEven.Name = "btnArrEven";
            this.btnArrEven.Size = new System.Drawing.Size(187, 30);
            this.btnArrEven.TabIndex = 6;
            this.btnArrEven.Text = "陣列arr統計奇偶數";
            this.btnArrEven.UseVisualStyleBackColor = true;
            this.btnArrEven.Click += new System.EventHandler(this.btnArrEven_Click);
            // 
            // btnArrTotal
            // 
            this.btnArrTotal.AutoSize = true;
            this.btnArrTotal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnArrTotal.Location = new System.Drawing.Point(16, 219);
            this.btnArrTotal.Name = "btnArrTotal";
            this.btnArrTotal.Size = new System.Drawing.Size(187, 30);
            this.btnArrTotal.TabIndex = 7;
            this.btnArrTotal.Text = "陣列arr加總值";
            this.btnArrTotal.UseVisualStyleBackColor = true;
            this.btnArrTotal.Click += new System.EventHandler(this.btnArrTotal_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(16, 263);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(187, 30);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "清空結果欄位";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(220, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "陣列str最長的名字";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStrEande
            // 
            this.btnStrEande.AutoSize = true;
            this.btnStrEande.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStrEande.Location = new System.Drawing.Point(220, 126);
            this.btnStrEande.Name = "btnStrEande";
            this.btnStrEande.Size = new System.Drawing.Size(187, 30);
            this.btnStrEande.TabIndex = 10;
            this.btnStrEande.Text = "陣列有E,e的傢伙";
            this.btnStrEande.UseVisualStyleBackColor = true;
            this.btnStrEande.Click += new System.EventHandler(this.btnStrEande_Click);
            // 
            // btn1and0
            // 
            this.btn1and0.AutoSize = true;
            this.btn1and0.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn1and0.Location = new System.Drawing.Point(220, 172);
            this.btn1and0.Name = "btn1and0";
            this.btn1and0.Size = new System.Drawing.Size(187, 30);
            this.btn1and0.TabIndex = 11;
            this.btn1and0.Text = "二維陣列邊1,內0";
            this.btn1and0.UseVisualStyleBackColor = true;
            this.btn1and0.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn1010
            // 
            this.btn1010.AutoSize = true;
            this.btn1010.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn1010.Location = new System.Drawing.Point(220, 219);
            this.btn1010.Name = "btn1010";
            this.btn1010.Size = new System.Drawing.Size(187, 30);
            this.btn1010.TabIndex = 12;
            this.btn1010.Text = "二維陣列1010";
            this.btn1010.UseVisualStyleBackColor = true;
            this.btn1010.Click += new System.EventHandler(this.btn1010_Click);
            // 
            // btnloto
            // 
            this.btnloto.AutoSize = true;
            this.btnloto.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnloto.Location = new System.Drawing.Point(423, 78);
            this.btnloto.Name = "btnloto";
            this.btnloto.Size = new System.Drawing.Size(187, 30);
            this.btnloto.TabIndex = 13;
            this.btnloto.Text = "樂透號碼不重複";
            this.btnloto.UseVisualStyleBackColor = true;
            this.btnloto.Click += new System.EventHandler(this.btnloto_Click);
            // 
            // btnTree
            // 
            this.btnTree.AutoSize = true;
            this.btnTree.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTree.Location = new System.Drawing.Point(423, 126);
            this.btnTree.Name = "btnTree";
            this.btnTree.Size = new System.Drawing.Size(187, 30);
            this.btnTree.TabIndex = 14;
            this.btnTree.Text = "直角聖誕樹";
            this.btnTree.UseVisualStyleBackColor = true;
            this.btnTree.Click += new System.EventHandler(this.btnTree_Click);
            // 
            // txtTree
            // 
            this.txtTree.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTree.Location = new System.Drawing.Point(627, 128);
            this.txtTree.Name = "txtTree";
            this.txtTree.Size = new System.Drawing.Size(100, 29);
            this.txtTree.TabIndex = 15;
            // 
            // btn100To2
            // 
            this.btn100To2.AutoSize = true;
            this.btn100To2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn100To2.Location = new System.Drawing.Point(423, 172);
            this.btn100To2.Name = "btn100To2";
            this.btn100To2.Size = new System.Drawing.Size(187, 30);
            this.btn100To2.TabIndex = 16;
            this.btn100To2.Text = "100的二進位";
            this.btn100To2.UseVisualStyleBackColor = true;
            this.btn100To2.Click += new System.EventHandler(this.btn100To2_Click);
            // 
            // btn99
            // 
            this.btn99.AutoSize = true;
            this.btn99.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn99.Location = new System.Drawing.Point(423, 219);
            this.btn99.Name = "btn99";
            this.btn99.Size = new System.Drawing.Size(187, 30);
            this.btn99.TabIndex = 17;
            this.btn99.Text = "九九乘法表";
            this.btn99.UseVisualStyleBackColor = true;
            this.btn99.Click += new System.EventHandler(this.btn99_Click);
            // 
            // btnFor
            // 
            this.btnFor.AutoSize = true;
            this.btnFor.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFor.Location = new System.Drawing.Point(220, 263);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(51, 30);
            this.btnFor.TabIndex = 18;
            this.btnFor.Text = "For";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFDW_Click);
            // 
            // txtFrom
            // 
            this.txtFrom.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtFrom.Location = new System.Drawing.Point(468, 263);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(42, 29);
            this.txtFrom.TabIndex = 19;
            // 
            // txtTo
            // 
            this.txtTo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTo.Location = new System.Drawing.Point(534, 263);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(42, 29);
            this.txtTo.TabIndex = 20;
            // 
            // txtStep
            // 
            this.txtStep.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStep.Location = new System.Drawing.Point(613, 263);
            this.txtStep.Name = "txtStep";
            this.txtStep.Size = new System.Drawing.Size(42, 29);
            this.txtStep.TabIndex = 21;
            // 
            // labF
            // 
            this.labF.AutoSize = true;
            this.labF.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labF.Location = new System.Drawing.Point(426, 270);
            this.labF.Name = "labF";
            this.labF.Size = new System.Drawing.Size(40, 17);
            this.labF.TabIndex = 22;
            this.labF.Text = "From";
            // 
            // labTo
            // 
            this.labTo.AutoSize = true;
            this.labTo.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTo.Location = new System.Drawing.Point(511, 269);
            this.labTo.Name = "labTo";
            this.labTo.Size = new System.Drawing.Size(23, 17);
            this.labTo.TabIndex = 23;
            this.labTo.Text = "To";
            // 
            // labStep
            // 
            this.labStep.AutoSize = true;
            this.labStep.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labStep.Location = new System.Drawing.Point(578, 269);
            this.labStep.Name = "labStep";
            this.labStep.Size = new System.Drawing.Size(35, 17);
            this.labStep.TabIndex = 24;
            this.labStep.Text = "Step";
            // 
            // btnWhile
            // 
            this.btnWhile.AutoSize = true;
            this.btnWhile.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWhile.Location = new System.Drawing.Point(284, 263);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(62, 30);
            this.btnWhile.TabIndex = 25;
            this.btnWhile.Text = "While";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnDo
            // 
            this.btnDo.AutoSize = true;
            this.btnDo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDo.Location = new System.Drawing.Point(356, 263);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(51, 30);
            this.btnDo.TabIndex = 26;
            this.btnDo.Text = "Do";
            this.btnDo.UseVisualStyleBackColor = true;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // Method
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.labStep);
            this.Controls.Add(this.labTo);
            this.Controls.Add(this.labF);
            this.Controls.Add(this.txtStep);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.btn99);
            this.Controls.Add(this.btn100To2);
            this.Controls.Add(this.txtTree);
            this.Controls.Add(this.btnTree);
            this.Controls.Add(this.btnloto);
            this.Controls.Add(this.btn1010);
            this.Controls.Add(this.btn1and0);
            this.Controls.Add(this.btnStrEande);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnArrTotal);
            this.Controls.Add(this.btnArrEven);
            this.Controls.Add(this.btnArr);
            this.Controls.Add(this.btnEven);
            this.Controls.Add(this.labResultOutPut);
            this.Controls.Add(this.labResult);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.labNumber);
            this.Name = "Method";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNumber;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label labResult;
        private System.Windows.Forms.Label labResultOutPut;
        private System.Windows.Forms.Button btnEven;
        private System.Windows.Forms.Button btnArr;
        private System.Windows.Forms.Button btnArrEven;
        private System.Windows.Forms.Button btnArrTotal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStrEande;
        private System.Windows.Forms.Button btn1and0;
        private System.Windows.Forms.Button btn1010;
        private System.Windows.Forms.Button btnloto;
        private System.Windows.Forms.Button btnTree;
        private System.Windows.Forms.TextBox txtTree;
        private System.Windows.Forms.Button btn100To2;
        private System.Windows.Forms.Button btn99;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtStep;
        private System.Windows.Forms.Label labF;
        private System.Windows.Forms.Label labTo;
        private System.Windows.Forms.Label labStep;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnDo;
    }
}

