namespace Lab_Alarm
{
    partial class Alam
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
            this.components = new System.ComponentModel.Container();
            this.gbSelect = new System.Windows.Forms.GroupBox();
            this.labTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtHH = new System.Windows.Forms.TextBox();
            this.txtmm = new System.Windows.Forms.TextBox();
            this.txtss = new System.Windows.Forms.TextBox();
            this.labNo1 = new System.Windows.Forms.Label();
            this.labNo2 = new System.Windows.Forms.Label();
            this.labAlarmTime = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.gbSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSelect
            // 
            this.gbSelect.Controls.Add(this.btnSet);
            this.gbSelect.Controls.Add(this.labAlarmTime);
            this.gbSelect.Controls.Add(this.labNo2);
            this.gbSelect.Controls.Add(this.labNo1);
            this.gbSelect.Controls.Add(this.txtss);
            this.gbSelect.Controls.Add(this.txtmm);
            this.gbSelect.Controls.Add(this.txtHH);
            this.gbSelect.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbSelect.Location = new System.Drawing.Point(101, 130);
            this.gbSelect.Name = "gbSelect";
            this.gbSelect.Size = new System.Drawing.Size(575, 258);
            this.gbSelect.TabIndex = 0;
            this.gbSelect.TabStop = false;
            this.gbSelect.Text = "Select Time";
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTime.Location = new System.Drawing.Point(39, 57);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(124, 45);
            this.labTime.TabIndex = 1;
            this.labTime.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtHH
            // 
            this.txtHH.Location = new System.Drawing.Point(238, 133);
            this.txtHH.Name = "txtHH";
            this.txtHH.Size = new System.Drawing.Size(60, 39);
            this.txtHH.TabIndex = 2;
            // 
            // txtmm
            // 
            this.txtmm.Location = new System.Drawing.Point(330, 133);
            this.txtmm.Name = "txtmm";
            this.txtmm.Size = new System.Drawing.Size(60, 39);
            this.txtmm.TabIndex = 3;
            // 
            // txtss
            // 
            this.txtss.Location = new System.Drawing.Point(421, 133);
            this.txtss.Name = "txtss";
            this.txtss.Size = new System.Drawing.Size(60, 39);
            this.txtss.TabIndex = 4;
            // 
            // labNo1
            // 
            this.labNo1.AutoSize = true;
            this.labNo1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNo1.Location = new System.Drawing.Point(304, 133);
            this.labNo1.Name = "labNo1";
            this.labNo1.Size = new System.Drawing.Size(22, 35);
            this.labNo1.TabIndex = 2;
            this.labNo1.Text = ":";
            // 
            // labNo2
            // 
            this.labNo2.AutoSize = true;
            this.labNo2.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNo2.Location = new System.Drawing.Point(396, 133);
            this.labNo2.Name = "labNo2";
            this.labNo2.Size = new System.Drawing.Size(22, 35);
            this.labNo2.TabIndex = 5;
            this.labNo2.Text = ":";
            // 
            // labAlarmTime
            // 
            this.labAlarmTime.AutoSize = true;
            this.labAlarmTime.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAlarmTime.Location = new System.Drawing.Point(64, 137);
            this.labAlarmTime.Name = "labAlarmTime";
            this.labAlarmTime.Size = new System.Drawing.Size(141, 31);
            this.labAlarmTime.TabIndex = 2;
            this.labAlarmTime.Text = "AlarmTime";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(217, 194);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(148, 37);
            this.btnSet.TabIndex = 6;
            this.btnSet.Text = "Set Alarm";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labTime);
            this.Controls.Add(this.gbSelect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSelect.ResumeLayout(false);
            this.gbSelect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSelect;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtss;
        private System.Windows.Forms.TextBox txtmm;
        private System.Windows.Forms.TextBox txtHH;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label labAlarmTime;
        private System.Windows.Forms.Label labNo2;
        private System.Windows.Forms.Label labNo1;
    }
}

