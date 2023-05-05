using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class POS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS));
            this.picBeer = new System.Windows.Forms.PictureBox();
            this.labMenu = new System.Windows.Forms.Label();
            this.picShochu = new System.Windows.Forms.PictureBox();
            this.picWihsky = new System.Windows.Forms.PictureBox();
            this.picWine = new System.Windows.Forms.PictureBox();
            this.labTotalPrice = new System.Windows.Forms.Label();
            this.labCash = new System.Windows.Forms.Label();
            this.labPayment = new System.Windows.Forms.Label();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnCard = new System.Windows.Forms.Button();
            this.lab10off = new System.Windows.Forms.Label();
            this.labList = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.labBeer = new System.Windows.Forms.Label();
            this.labShochu = new System.Windows.Forms.Label();
            this.labWihsky = new System.Windows.Forms.Label();
            this.labWine = new System.Windows.Forms.Label();
            this.listTo = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBeer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShochu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWihsky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWine)).BeginInit();
            this.SuspendLayout();
            // 
            // picBeer
            // 
            this.picBeer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBeer.BackgroundImage")));
            this.picBeer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBeer.Location = new System.Drawing.Point(27, 47);
            this.picBeer.Name = "picBeer";
            this.picBeer.Size = new System.Drawing.Size(59, 79);
            this.picBeer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBeer.TabIndex = 0;
            this.picBeer.TabStop = false;
            this.picBeer.Click += new System.EventHandler(this.picBeer_Click);
            // 
            // labMenu
            // 
            this.labMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.labMenu.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMenu.Location = new System.Drawing.Point(11, 11);
            this.labMenu.Name = "labMenu";
            this.labMenu.Size = new System.Drawing.Size(183, 277);
            this.labMenu.TabIndex = 4;
            this.labMenu.Text = "菜單 Menu";
            // 
            // picShochu
            // 
            this.picShochu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picShochu.BackgroundImage")));
            this.picShochu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picShochu.Location = new System.Drawing.Point(116, 47);
            this.picShochu.Name = "picShochu";
            this.picShochu.Size = new System.Drawing.Size(59, 79);
            this.picShochu.TabIndex = 5;
            this.picShochu.TabStop = false;
            this.picShochu.Click += new System.EventHandler(this.picShochu_Click);
            // 
            // picWihsky
            // 
            this.picWihsky.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picWihsky.BackgroundImage")));
            this.picWihsky.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picWihsky.Location = new System.Drawing.Point(27, 168);
            this.picWihsky.Name = "picWihsky";
            this.picWihsky.Size = new System.Drawing.Size(59, 79);
            this.picWihsky.TabIndex = 6;
            this.picWihsky.TabStop = false;
            this.picWihsky.Click += new System.EventHandler(this.picWihsky_Click);
            // 
            // picWine
            // 
            this.picWine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picWine.BackgroundImage")));
            this.picWine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picWine.Location = new System.Drawing.Point(115, 166);
            this.picWine.Name = "picWine";
            this.picWine.Size = new System.Drawing.Size(59, 79);
            this.picWine.TabIndex = 7;
            this.picWine.TabStop = false;
            this.picWine.Click += new System.EventHandler(this.picWine_Click);
            // 
            // labTotalPrice
            // 
            this.labTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labTotalPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.labTotalPrice.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTotalPrice.Location = new System.Drawing.Point(200, 11);
            this.labTotalPrice.Name = "labTotalPrice";
            this.labTotalPrice.Size = new System.Drawing.Size(172, 72);
            this.labTotalPrice.TabIndex = 8;
            this.labTotalPrice.Text = "總金額 Total Price";
            // 
            // labCash
            // 
            this.labCash.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labCash.BackColor = System.Drawing.SystemColors.MenuText;
            this.labCash.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCash.ForeColor = System.Drawing.SystemColors.Control;
            this.labCash.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labCash.Location = new System.Drawing.Point(210, 48);
            this.labCash.Name = "labCash";
            this.labCash.Size = new System.Drawing.Size(152, 23);
            this.labCash.TabIndex = 9;
            this.labCash.Text = "NT$0";
            this.labCash.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labPayment
            // 
            this.labPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labPayment.Cursor = System.Windows.Forms.Cursors.Default;
            this.labPayment.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPayment.Location = new System.Drawing.Point(376, 11);
            this.labPayment.Name = "labPayment";
            this.labPayment.Size = new System.Drawing.Size(150, 72);
            this.labPayment.TabIndex = 10;
            this.labPayment.Text = "付款方式";
            // 
            // btnCash
            // 
            this.btnCash.Location = new System.Drawing.Point(389, 39);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(50, 23);
            this.btnCash.TabIndex = 11;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnCard
            // 
            this.btnCard.Location = new System.Drawing.Point(458, 39);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(50, 23);
            this.btnCard.TabIndex = 12;
            this.btnCard.Text = "信用卡";
            this.btnCard.UseVisualStyleBackColor = true;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // lab10off
            // 
            this.lab10off.AutoSize = true;
            this.lab10off.Location = new System.Drawing.Point(411, 67);
            this.lab10off.Name = "lab10off";
            this.lab10off.Size = new System.Drawing.Size(71, 12);
            this.lab10off.TabIndex = 13;
            this.lab10off.Text = "信用卡享9折";
            // 
            // labList
            // 
            this.labList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labList.Cursor = System.Windows.Forms.Cursors.Default;
            this.labList.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labList.Location = new System.Drawing.Point(200, 96);
            this.labList.Name = "labList";
            this.labList.Size = new System.Drawing.Size(326, 192);
            this.labList.TabIndex = 14;
            this.labList.Text = "購物清單 List";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Location = new System.Drawing.Point(413, 252);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 28);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "清除清單";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // labBeer
            // 
            this.labBeer.AutoSize = true;
            this.labBeer.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labBeer.Location = new System.Drawing.Point(27, 131);
            this.labBeer.Name = "labBeer";
            this.labBeer.Size = new System.Drawing.Size(59, 32);
            this.labBeer.TabIndex = 17;
            this.labBeer.Text = "啤酒 Beer\nNT120元";
            // 
            // labShochu
            // 
            this.labShochu.AutoSize = true;
            this.labShochu.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShochu.Location = new System.Drawing.Point(107, 130);
            this.labShochu.Name = "labShochu";
            this.labShochu.Size = new System.Drawing.Size(76, 32);
            this.labShochu.TabIndex = 18;
            this.labShochu.Text = "燒酒 Shochu\nNT180元";
            // 
            // labWihsky
            // 
            this.labWihsky.AutoSize = true;
            this.labWihsky.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labWihsky.Location = new System.Drawing.Point(25, 250);
            this.labWihsky.Name = "labWihsky";
            this.labWihsky.Size = new System.Drawing.Size(85, 32);
            this.labWihsky.TabIndex = 19;
            this.labWihsky.Text = "威士忌 Wihsky\nNT350元";
            // 
            // labWine
            // 
            this.labWine.AutoSize = true;
            this.labWine.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labWine.Location = new System.Drawing.Point(117, 251);
            this.labWine.Name = "labWine";
            this.labWine.Size = new System.Drawing.Size(57, 32);
            this.labWine.TabIndex = 20;
            this.labWine.Text = "紅酒\nNT320元";
            // 
            // listTo
            // 
            this.listTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listTo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listTo.FormattingEnabled = true;
            this.listTo.ItemHeight = 20;
            this.listTo.Items.AddRange(new object[] {
            "尚未點餐"});
            this.listTo.Location = new System.Drawing.Point(205, 122);
            this.listTo.Name = "listTo";
            this.listTo.Size = new System.Drawing.Size(314, 120);
            this.listTo.TabIndex = 22;
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 302);
            this.Controls.Add(this.listTo);
            this.Controls.Add(this.labWine);
            this.Controls.Add(this.labWihsky);
            this.Controls.Add(this.labShochu);
            this.Controls.Add(this.labBeer);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.labList);
            this.Controls.Add(this.lab10off);
            this.Controls.Add(this.btnCard);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.labPayment);
            this.Controls.Add(this.labCash);
            this.Controls.Add(this.labTotalPrice);
            this.Controls.Add(this.picWine);
            this.Controls.Add(this.picWihsky);
            this.Controls.Add(this.picShochu);
            this.Controls.Add(this.picBeer);
            this.Controls.Add(this.labMenu);
            this.Name = "POS";
            this.Text = "Ri_POS";
            ((System.ComponentModel.ISupportInitialize)(this.picBeer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShochu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWihsky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBeer;
        private System.Windows.Forms.Label labMenu;
        private System.Windows.Forms.PictureBox picShochu;
        private System.Windows.Forms.PictureBox picWihsky;
        private System.Windows.Forms.PictureBox picWine;
        private System.Windows.Forms.Label labTotalPrice;
        private System.Windows.Forms.Label labCash;
        private System.Windows.Forms.Label labPayment;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Label lab10off;
        private System.Windows.Forms.Label labList;
        private System.Windows.Forms.Button btnDelete;
        private Label labBeer;
        private Label labShochu;
        private Label labWihsky;
        private Label labWine;
        private ListBox listTo;
    }
}

