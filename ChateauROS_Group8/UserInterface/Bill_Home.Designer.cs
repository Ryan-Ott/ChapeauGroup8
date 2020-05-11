namespace UserInterface
{
    partial class Bill_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill_Home));
            this.main_pnl = new System.Windows.Forms.Panel();
            this.lbl_bill = new System.Windows.Forms.Label();
            this.pnl_layout = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_billID = new System.Windows.Forms.Label();
            this.lbl_orderID = new System.Windows.Forms.Label();
            this.lbl_tableID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_emID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.listView_Items = new System.Windows.Forms.ListView();
            this.menuItemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dishName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_totalNoVAT = new System.Windows.Forms.Label();
            this.lbl_VAT = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_correct = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.main_pnl.SuspendLayout();
            this.pnl_layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // main_pnl
            // 
            this.main_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.main_pnl.Controls.Add(this.button1);
            this.main_pnl.Controls.Add(this.btn_modify);
            this.main_pnl.Controls.Add(this.btn_correct);
            this.main_pnl.Controls.Add(this.pnl_layout);
            this.main_pnl.Location = new System.Drawing.Point(28, 48);
            this.main_pnl.Name = "main_pnl";
            this.main_pnl.Size = new System.Drawing.Size(737, 496);
            this.main_pnl.TabIndex = 0;
            // 
            // lbl_bill
            // 
            this.lbl_bill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bill.Location = new System.Drawing.Point(28, 17);
            this.lbl_bill.Name = "lbl_bill";
            this.lbl_bill.Size = new System.Drawing.Size(125, 62);
            this.lbl_bill.TabIndex = 0;
            this.lbl_bill.Text = "BILL";
            this.lbl_bill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_layout
            // 
            this.pnl_layout.AutoScroll = true;
            this.pnl_layout.BackColor = System.Drawing.Color.White;
            this.pnl_layout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_layout.Controls.Add(this.label5);
            this.pnl_layout.Controls.Add(this.label7);
            this.pnl_layout.Controls.Add(this.label8);
            this.pnl_layout.Controls.Add(this.lbl_totalNoVAT);
            this.pnl_layout.Controls.Add(this.lbl_VAT);
            this.pnl_layout.Controls.Add(this.lbl_total);
            this.pnl_layout.Controls.Add(this.listView_Items);
            this.pnl_layout.Controls.Add(this.lbl_Date);
            this.pnl_layout.Controls.Add(this.label6);
            this.pnl_layout.Controls.Add(this.lbl_emID);
            this.pnl_layout.Controls.Add(this.label4);
            this.pnl_layout.Controls.Add(this.lbl_tableID);
            this.pnl_layout.Controls.Add(this.lbl_orderID);
            this.pnl_layout.Controls.Add(this.lbl_billID);
            this.pnl_layout.Controls.Add(this.label1);
            this.pnl_layout.Controls.Add(this.label2);
            this.pnl_layout.Controls.Add(this.label3);
            this.pnl_layout.Controls.Add(this.pictureBox1);
            this.pnl_layout.Location = new System.Drawing.Point(19, 47);
            this.pnl_layout.Name = "pnl_layout";
            this.pnl_layout.Size = new System.Drawing.Size(426, 425);
            this.pnl_layout.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(160, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 55);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Receipt";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Order";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Table";
            // 
            // lbl_billID
            // 
            this.lbl_billID.AutoSize = true;
            this.lbl_billID.Location = new System.Drawing.Point(98, 73);
            this.lbl_billID.Name = "lbl_billID";
            this.lbl_billID.Size = new System.Drawing.Size(51, 20);
            this.lbl_billID.TabIndex = 4;
            this.lbl_billID.Text = "label4";
            // 
            // lbl_orderID
            // 
            this.lbl_orderID.AutoSize = true;
            this.lbl_orderID.Location = new System.Drawing.Point(98, 99);
            this.lbl_orderID.Name = "lbl_orderID";
            this.lbl_orderID.Size = new System.Drawing.Size(51, 20);
            this.lbl_orderID.TabIndex = 5;
            this.lbl_orderID.Text = "label5";
            // 
            // lbl_tableID
            // 
            this.lbl_tableID.AutoSize = true;
            this.lbl_tableID.Location = new System.Drawing.Point(98, 125);
            this.lbl_tableID.Name = "lbl_tableID";
            this.lbl_tableID.Size = new System.Drawing.Size(51, 20);
            this.lbl_tableID.TabIndex = 6;
            this.lbl_tableID.Text = "label6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Employee";
            // 
            // lbl_emID
            // 
            this.lbl_emID.AutoSize = true;
            this.lbl_emID.Location = new System.Drawing.Point(346, 73);
            this.lbl_emID.Name = "lbl_emID";
            this.lbl_emID.Size = new System.Drawing.Size(51, 20);
            this.lbl_emID.TabIndex = 8;
            this.lbl_emID.Text = "label5";
            this.lbl_emID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Date";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(346, 99);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(51, 20);
            this.lbl_Date.TabIndex = 10;
            this.lbl_Date.Text = "label7";
            // 
            // listView_Items
            // 
            this.listView_Items.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_Items.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.menuItemID,
            this.dishName,
            this.price});
            this.listView_Items.HideSelection = false;
            this.listView_Items.Location = new System.Drawing.Point(26, 157);
            this.listView_Items.Name = "listView_Items";
            this.listView_Items.Size = new System.Drawing.Size(371, 152);
            this.listView_Items.TabIndex = 11;
            this.listView_Items.UseCompatibleStateImageBehavior = false;
            this.listView_Items.View = System.Windows.Forms.View.Details;
            // 
            // menuItemID
            // 
            this.menuItemID.Text = "ID";
            this.menuItemID.Width = 44;
            // 
            // dishName
            // 
            this.dishName.Text = "Item";
            this.dishName.Width = 245;
            // 
            // price
            // 
            this.price.Text = "Price(€)";
            this.price.Width = 81;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "TOTAL (VAT excl.)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "VAT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "TOTAL";
            // 
            // lbl_totalNoVAT
            // 
            this.lbl_totalNoVAT.AutoSize = true;
            this.lbl_totalNoVAT.Location = new System.Drawing.Point(346, 328);
            this.lbl_totalNoVAT.Name = "lbl_totalNoVAT";
            this.lbl_totalNoVAT.Size = new System.Drawing.Size(51, 20);
            this.lbl_totalNoVAT.TabIndex = 5;
            this.lbl_totalNoVAT.Text = "label9";
            // 
            // lbl_VAT
            // 
            this.lbl_VAT.AutoSize = true;
            this.lbl_VAT.Location = new System.Drawing.Point(337, 354);
            this.lbl_VAT.Name = "lbl_VAT";
            this.lbl_VAT.Size = new System.Drawing.Size(60, 20);
            this.lbl_VAT.TabIndex = 6;
            this.lbl_VAT.Text = "label10";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(337, 380);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(60, 20);
            this.lbl_total.TabIndex = 7;
            this.lbl_total.Text = "label11";
            // 
            // btn_correct
            // 
            this.btn_correct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_correct.Location = new System.Drawing.Point(479, 47);
            this.btn_correct.Name = "btn_correct";
            this.btn_correct.Size = new System.Drawing.Size(221, 59);
            this.btn_correct.TabIndex = 1;
            this.btn_correct.Text = "ORDER CORRECT";
            this.btn_correct.UseVisualStyleBackColor = true;
            // 
            // btn_modify
            // 
            this.btn_modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modify.Location = new System.Drawing.Point(479, 121);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(221, 56);
            this.btn_modify.TabIndex = 2;
            this.btn_modify.Text = "MODIFY ORDER";
            this.btn_modify.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(600, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "CANCEL";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Bill_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 574);
            this.Controls.Add(this.lbl_bill);
            this.Controls.Add(this.main_pnl);
            this.Name = "Bill_Home";
            this.Text = "Bill_Home";
            this.Load += new System.EventHandler(this.Bill_Home_Load);
            this.main_pnl.ResumeLayout(false);
            this.pnl_layout.ResumeLayout(false);
            this.pnl_layout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_pnl;
        private System.Windows.Forms.Panel pnl_layout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_bill;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_totalNoVAT;
        private System.Windows.Forms.Label lbl_VAT;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.ListView listView_Items;
        private System.Windows.Forms.ColumnHeader menuItemID;
        private System.Windows.Forms.ColumnHeader dishName;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_emID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_tableID;
        private System.Windows.Forms.Label lbl_orderID;
        private System.Windows.Forms.Label lbl_billID;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Button btn_correct;
        private System.Windows.Forms.Button button1;
    }
}