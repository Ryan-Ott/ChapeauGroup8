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
            this.pnl_cash_payment = new System.Windows.Forms.Panel();
            this.pnl_pin_payment = new System.Windows.Forms.Panel();
            this.cb_tips = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_changes_amount = new System.Windows.Forms.Label();
            this.txt_received = new System.Windows.Forms.TextBox();
            this.received = new System.Windows.Forms.Label();
            this.pnl_Summary = new System.Windows.Forms.Panel();
            this.cash_rb = new System.Windows.Forms.RadioButton();
            this.lbl_Sum_Total = new System.Windows.Forms.Label();
            this.lbl_Sum_VAT = new System.Windows.Forms.Label();
            this.lbl_Sum_TotalNoVAT = new System.Windows.Forms.Label();
            this.card_rb = new System.Windows.Forms.RadioButton();
            this.Pin_rb = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_correct = new System.Windows.Forms.Button();
            this.pnl_layout = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_totalNoVAT = new System.Windows.Forms.Label();
            this.lbl_VAT = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.listView_Items = new System.Windows.Forms.ListView();
            this.menuItemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dishName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quatity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_Date = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_emID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_tableID = new System.Windows.Forms.Label();
            this.lbl_orderID = new System.Windows.Forms.Label();
            this.lbl_billID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_bill = new System.Windows.Forms.Label();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_pin_tips = new System.Windows.Forms.TextBox();
            this.complete_btn = new System.Windows.Forms.Button();
            this.pnl_card_payment = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.cardType_combo = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_card_tips = new System.Windows.Forms.TextBox();
            this.main_pnl.SuspendLayout();
            this.pnl_cash_payment.SuspendLayout();
            this.pnl_pin_payment.SuspendLayout();
            this.pnl_Summary.SuspendLayout();
            this.pnl_layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_card_payment.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_pnl
            // 
            this.main_pnl.BackColor = System.Drawing.Color.White;
            this.main_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.main_pnl.Controls.Add(this.pnl_pin_payment);
            this.main_pnl.Controls.Add(this.complete_btn);
            this.main_pnl.Controls.Add(this.pnl_cash_payment);
            this.main_pnl.Controls.Add(this.pnl_Summary);
            this.main_pnl.Controls.Add(this.cancel_btn);
            this.main_pnl.Controls.Add(this.btn_modify);
            this.main_pnl.Controls.Add(this.btn_correct);
            this.main_pnl.Controls.Add(this.pnl_layout);
            this.main_pnl.Location = new System.Drawing.Point(28, 48);
            this.main_pnl.Name = "main_pnl";
            this.main_pnl.Size = new System.Drawing.Size(855, 573);
            this.main_pnl.TabIndex = 0;
            // 
            // pnl_cash_payment
            // 
            this.pnl_cash_payment.Controls.Add(this.confirm_btn);
            this.pnl_cash_payment.Controls.Add(this.cb_tips);
            this.pnl_cash_payment.Controls.Add(this.label13);
            this.pnl_cash_payment.Controls.Add(this.lbl_changes_amount);
            this.pnl_cash_payment.Controls.Add(this.txt_received);
            this.pnl_cash_payment.Controls.Add(this.received);
            this.pnl_cash_payment.Location = new System.Drawing.Point(561, 274);
            this.pnl_cash_payment.Name = "pnl_cash_payment";
            this.pnl_cash_payment.Size = new System.Drawing.Size(277, 203);
            this.pnl_cash_payment.TabIndex = 11;
            // 
            // pnl_pin_payment
            // 
            this.pnl_pin_payment.Controls.Add(this.pnl_card_payment);
            this.pnl_pin_payment.Controls.Add(this.txt_pin_tips);
            this.pnl_pin_payment.Controls.Add(this.label14);
            this.pnl_pin_payment.Location = new System.Drawing.Point(561, 274);
            this.pnl_pin_payment.Name = "pnl_pin_payment";
            this.pnl_pin_payment.Size = new System.Drawing.Size(277, 203);
            this.pnl_pin_payment.TabIndex = 16;
            // 
            // cb_tips
            // 
            this.cb_tips.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tips.Location = new System.Drawing.Point(170, 113);
            this.cb_tips.Name = "cb_tips";
            this.cb_tips.Size = new System.Drawing.Size(104, 61);
            this.cb_tips.TabIndex = 14;
            this.cb_tips.Text = "changes kept as tip";
            this.cb_tips.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "Changes :";
            // 
            // lbl_changes_amount
            // 
            this.lbl_changes_amount.AutoSize = true;
            this.lbl_changes_amount.Location = new System.Drawing.Point(206, 90);
            this.lbl_changes_amount.Name = "lbl_changes_amount";
            this.lbl_changes_amount.Size = new System.Drawing.Size(60, 20);
            this.lbl_changes_amount.TabIndex = 2;
            this.lbl_changes_amount.Text = "label14";
            // 
            // txt_received
            // 
            this.txt_received.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(226)))), ((int)(((byte)(130)))));
            this.txt_received.Location = new System.Drawing.Point(165, 0);
            this.txt_received.Name = "txt_received";
            this.txt_received.Size = new System.Drawing.Size(101, 26);
            this.txt_received.TabIndex = 13;
            // 
            // received
            // 
            this.received.AutoSize = true;
            this.received.Location = new System.Drawing.Point(9, 3);
            this.received.Name = "received";
            this.received.Size = new System.Drawing.Size(143, 20);
            this.received.TabIndex = 12;
            this.received.Text = "Amount Received :";
            // 
            // pnl_Summary
            // 
            this.pnl_Summary.Controls.Add(this.cash_rb);
            this.pnl_Summary.Controls.Add(this.lbl_Sum_Total);
            this.pnl_Summary.Controls.Add(this.lbl_Sum_VAT);
            this.pnl_Summary.Controls.Add(this.lbl_Sum_TotalNoVAT);
            this.pnl_Summary.Controls.Add(this.card_rb);
            this.pnl_Summary.Controls.Add(this.Pin_rb);
            this.pnl_Summary.Controls.Add(this.label12);
            this.pnl_Summary.Controls.Add(this.label11);
            this.pnl_Summary.Controls.Add(this.label10);
            this.pnl_Summary.Controls.Add(this.label9);
            this.pnl_Summary.Location = new System.Drawing.Point(561, 47);
            this.pnl_Summary.Name = "pnl_Summary";
            this.pnl_Summary.Size = new System.Drawing.Size(277, 221);
            this.pnl_Summary.TabIndex = 1;
            // 
            // cash_rb
            // 
            this.cash_rb.AutoSize = true;
            this.cash_rb.Location = new System.Drawing.Point(13, 170);
            this.cash_rb.Name = "cash_rb";
            this.cash_rb.Size = new System.Drawing.Size(71, 24);
            this.cash_rb.TabIndex = 10;
            this.cash_rb.TabStop = true;
            this.cash_rb.Text = "Cash";
            this.cash_rb.UseVisualStyleBackColor = true;
            this.cash_rb.CheckedChanged += new System.EventHandler(this.cash_rb_CheckedChanged);
            // 
            // lbl_Sum_Total
            // 
            this.lbl_Sum_Total.AutoSize = true;
            this.lbl_Sum_Total.Location = new System.Drawing.Point(206, 99);
            this.lbl_Sum_Total.Name = "lbl_Sum_Total";
            this.lbl_Sum_Total.Size = new System.Drawing.Size(60, 20);
            this.lbl_Sum_Total.TabIndex = 9;
            this.lbl_Sum_Total.Text = "label15";
            // 
            // lbl_Sum_VAT
            // 
            this.lbl_Sum_VAT.AutoSize = true;
            this.lbl_Sum_VAT.Location = new System.Drawing.Point(206, 62);
            this.lbl_Sum_VAT.Name = "lbl_Sum_VAT";
            this.lbl_Sum_VAT.Size = new System.Drawing.Size(60, 20);
            this.lbl_Sum_VAT.TabIndex = 8;
            this.lbl_Sum_VAT.Text = "label14";
            // 
            // lbl_Sum_TotalNoVAT
            // 
            this.lbl_Sum_TotalNoVAT.AutoSize = true;
            this.lbl_Sum_TotalNoVAT.Location = new System.Drawing.Point(206, 21);
            this.lbl_Sum_TotalNoVAT.Name = "lbl_Sum_TotalNoVAT";
            this.lbl_Sum_TotalNoVAT.Size = new System.Drawing.Size(60, 20);
            this.lbl_Sum_TotalNoVAT.TabIndex = 7;
            this.lbl_Sum_TotalNoVAT.Text = "label13";
            // 
            // card_rb
            // 
            this.card_rb.AutoSize = true;
            this.card_rb.Location = new System.Drawing.Point(152, 170);
            this.card_rb.Name = "card_rb";
            this.card_rb.Size = new System.Drawing.Size(114, 24);
            this.card_rb.TabIndex = 6;
            this.card_rb.TabStop = true;
            this.card_rb.Text = "Credit Card";
            this.card_rb.UseVisualStyleBackColor = true;
            this.card_rb.CheckedChanged += new System.EventHandler(this.card_rb_CheckedChanged);
            // 
            // Pin_rb
            // 
            this.Pin_rb.AutoSize = true;
            this.Pin_rb.Location = new System.Drawing.Point(90, 170);
            this.Pin_rb.Name = "Pin_rb";
            this.Pin_rb.Size = new System.Drawing.Size(56, 24);
            this.Pin_rb.TabIndex = 5;
            this.Pin_rb.TabStop = true;
            this.Pin_rb.Text = "Pin";
            this.Pin_rb.UseVisualStyleBackColor = true;
            this.Pin_rb.CheckedChanged += new System.EventHandler(this.Pin_rb_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Select Payment Method : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "TOTAL :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "VAT :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "TOTAL (VAT excl.) :";
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(215)))), ((int)(((byte)(217)))));
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Location = new System.Drawing.Point(738, 494);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(100, 54);
            this.cancel_btn.TabIndex = 3;
            this.cancel_btn.Text = "CANCEL";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(129)))), ((int)(((byte)(153)))));
            this.btn_modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modify.ForeColor = System.Drawing.Color.White;
            this.btn_modify.Location = new System.Drawing.Point(591, 126);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(221, 56);
            this.btn_modify.TabIndex = 2;
            this.btn_modify.Text = "MODIFY ORDER";
            this.btn_modify.UseVisualStyleBackColor = false;
            // 
            // btn_correct
            // 
            this.btn_correct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(226)))), ((int)(((byte)(130)))));
            this.btn_correct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_correct.Location = new System.Drawing.Point(591, 47);
            this.btn_correct.Name = "btn_correct";
            this.btn_correct.Size = new System.Drawing.Size(221, 59);
            this.btn_correct.TabIndex = 1;
            this.btn_correct.Text = "ORDER CORRECT";
            this.btn_correct.UseVisualStyleBackColor = false;
            this.btn_correct.Click += new System.EventHandler(this.btn_correct_Click);
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
            this.pnl_layout.Size = new System.Drawing.Size(527, 501);
            this.pnl_layout.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "TOTAL (VAT excl.)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "VAT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 448);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "TOTAL";
            // 
            // lbl_totalNoVAT
            // 
            this.lbl_totalNoVAT.AutoSize = true;
            this.lbl_totalNoVAT.Location = new System.Drawing.Point(475, 396);
            this.lbl_totalNoVAT.Name = "lbl_totalNoVAT";
            this.lbl_totalNoVAT.Size = new System.Drawing.Size(31, 20);
            this.lbl_totalNoVAT.TabIndex = 5;
            this.lbl_totalNoVAT.Text = "0 €";
            this.lbl_totalNoVAT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_VAT
            // 
            this.lbl_VAT.AutoSize = true;
            this.lbl_VAT.Location = new System.Drawing.Point(475, 422);
            this.lbl_VAT.Name = "lbl_VAT";
            this.lbl_VAT.Size = new System.Drawing.Size(31, 20);
            this.lbl_VAT.TabIndex = 6;
            this.lbl_VAT.Text = "0 €";
            this.lbl_VAT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(475, 448);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(31, 20);
            this.lbl_total.TabIndex = 7;
            this.lbl_total.Text = "0 €";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listView_Items
            // 
            this.listView_Items.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_Items.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.menuItemID,
            this.dishName,
            this.quatity,
            this.price});
            this.listView_Items.HideSelection = false;
            this.listView_Items.Location = new System.Drawing.Point(18, 220);
            this.listView_Items.Name = "listView_Items";
            this.listView_Items.Size = new System.Drawing.Size(488, 152);
            this.listView_Items.TabIndex = 11;
            this.listView_Items.UseCompatibleStateImageBehavior = false;
            this.listView_Items.View = System.Windows.Forms.View.Details;
            this.listView_Items.SelectedIndexChanged += new System.EventHandler(this.listView_Items_SelectedIndexChanged);
            // 
            // menuItemID
            // 
            this.menuItemID.Text = "ID";
            this.menuItemID.Width = 44;
            // 
            // dishName
            // 
            this.dishName.Text = "Item";
            this.dishName.Width = 257;
            // 
            // quatity
            // 
            this.quatity.Text = "Quantity";
            this.quatity.Width = 77;
            // 
            // price
            // 
            this.price.Text = "Price(€)";
            this.price.Width = 81;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(369, 158);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(137, 20);
            this.lbl_Date.TabIndex = 10;
            this.lbl_Date.Text = "00/00/0000  00:00";
            this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Date";
            // 
            // lbl_emID
            // 
            this.lbl_emID.AutoSize = true;
            this.lbl_emID.Location = new System.Drawing.Point(369, 132);
            this.lbl_emID.Name = "lbl_emID";
            this.lbl_emID.Size = new System.Drawing.Size(51, 20);
            this.lbl_emID.TabIndex = 8;
            this.lbl_emID.Text = "label5";
            this.lbl_emID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Employee";
            // 
            // lbl_tableID
            // 
            this.lbl_tableID.AutoSize = true;
            this.lbl_tableID.Location = new System.Drawing.Point(90, 184);
            this.lbl_tableID.Name = "lbl_tableID";
            this.lbl_tableID.Size = new System.Drawing.Size(51, 20);
            this.lbl_tableID.TabIndex = 6;
            this.lbl_tableID.Text = "label6";
            // 
            // lbl_orderID
            // 
            this.lbl_orderID.AutoSize = true;
            this.lbl_orderID.Location = new System.Drawing.Point(90, 158);
            this.lbl_orderID.Name = "lbl_orderID";
            this.lbl_orderID.Size = new System.Drawing.Size(51, 20);
            this.lbl_orderID.TabIndex = 5;
            this.lbl_orderID.Text = "label5";
            // 
            // lbl_billID
            // 
            this.lbl_billID.AutoSize = true;
            this.lbl_billID.Location = new System.Drawing.Point(90, 132);
            this.lbl_billID.Name = "lbl_billID";
            this.lbl_billID.Size = new System.Drawing.Size(51, 20);
            this.lbl_billID.TabIndex = 4;
            this.lbl_billID.Text = "label4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Receipt";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Order";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Table";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(198, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 91);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_bill
            // 
            this.lbl_bill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(226)))), ((int)(((byte)(130)))));
            this.lbl_bill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bill.Location = new System.Drawing.Point(28, 17);
            this.lbl_bill.Name = "lbl_bill";
            this.lbl_bill.Size = new System.Drawing.Size(125, 62);
            this.lbl_bill.TabIndex = 0;
            this.lbl_bill.Text = "BILL";
            this.lbl_bill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirm_btn
            // 
            this.confirm_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(129)))), ((int)(((byte)(153)))));
            this.confirm_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_btn.ForeColor = System.Drawing.Color.White;
            this.confirm_btn.Location = new System.Drawing.Point(177, 35);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(89, 33);
            this.confirm_btn.TabIndex = 15;
            this.confirm_btn.Text = "CONFIRM";
            this.confirm_btn.UseVisualStyleBackColor = false;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Tips :";
            // 
            // txt_pin_tips
            // 
            this.txt_pin_tips.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(226)))), ((int)(((byte)(130)))));
            this.txt_pin_tips.Location = new System.Drawing.Point(165, 20);
            this.txt_pin_tips.Name = "txt_pin_tips";
            this.txt_pin_tips.Size = new System.Drawing.Size(100, 26);
            this.txt_pin_tips.TabIndex = 1;
            // 
            // complete_btn
            // 
            this.complete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(129)))), ((int)(((byte)(153)))));
            this.complete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complete_btn.ForeColor = System.Drawing.Color.White;
            this.complete_btn.Location = new System.Drawing.Point(561, 495);
            this.complete_btn.Name = "complete_btn";
            this.complete_btn.Size = new System.Drawing.Size(125, 53);
            this.complete_btn.TabIndex = 15;
            this.complete_btn.Text = "COMPLETE";
            this.complete_btn.UseVisualStyleBackColor = false;
            this.complete_btn.Click += new System.EventHandler(this.complete_btn_Click);
            // 
            // pnl_card_payment
            // 
            this.pnl_card_payment.Controls.Add(this.txt_card_tips);
            this.pnl_card_payment.Controls.Add(this.label16);
            this.pnl_card_payment.Controls.Add(this.cardType_combo);
            this.pnl_card_payment.Controls.Add(this.label15);
            this.pnl_card_payment.Location = new System.Drawing.Point(34, 20);
            this.pnl_card_payment.Name = "pnl_card_payment";
            this.pnl_card_payment.Size = new System.Drawing.Size(277, 203);
            this.pnl_card_payment.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Select card type :";
            // 
            // cardType_combo
            // 
            this.cardType_combo.FormattingEnabled = true;
            this.cardType_combo.Items.AddRange(new object[] {
            "VISA",
            "AMEX"});
            this.cardType_combo.Location = new System.Drawing.Point(145, 20);
            this.cardType_combo.Name = "cardType_combo";
            this.cardType_combo.Size = new System.Drawing.Size(121, 28);
            this.cardType_combo.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 20);
            this.label16.TabIndex = 2;
            this.label16.Text = "Tips :";
            // 
            // txt_card_tips
            // 
            this.txt_card_tips.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(226)))), ((int)(((byte)(130)))));
            this.txt_card_tips.Location = new System.Drawing.Point(166, 74);
            this.txt_card_tips.Name = "txt_card_tips";
            this.txt_card_tips.Size = new System.Drawing.Size(100, 26);
            this.txt_card_tips.TabIndex = 3;
            // 
            // Bill_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(215)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(913, 651);
            this.Controls.Add(this.lbl_bill);
            this.Controls.Add(this.main_pnl);
            this.Name = "Bill_Home";
            this.Text = "Bill_Home";
            this.Load += new System.EventHandler(this.Bill_Home_Load);
            this.main_pnl.ResumeLayout(false);
            this.pnl_cash_payment.ResumeLayout(false);
            this.pnl_cash_payment.PerformLayout();
            this.pnl_pin_payment.ResumeLayout(false);
            this.pnl_pin_payment.PerformLayout();
            this.pnl_Summary.ResumeLayout(false);
            this.pnl_Summary.PerformLayout();
            this.pnl_layout.ResumeLayout(false);
            this.pnl_layout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_card_payment.ResumeLayout(false);
            this.pnl_card_payment.PerformLayout();
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
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Panel pnl_Summary;
        private System.Windows.Forms.RadioButton card_rb;
        private System.Windows.Forms.RadioButton Pin_rb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_Sum_Total;
        private System.Windows.Forms.Label lbl_Sum_VAT;
        private System.Windows.Forms.Label lbl_Sum_TotalNoVAT;
        private System.Windows.Forms.ColumnHeader quatity;
        private System.Windows.Forms.RadioButton cash_rb;
        private System.Windows.Forms.Panel pnl_cash_payment;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_changes_amount;
        private System.Windows.Forms.TextBox txt_received;
        private System.Windows.Forms.Label received;
        private System.Windows.Forms.CheckBox cb_tips;
        private System.Windows.Forms.Panel pnl_pin_payment;
        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.TextBox txt_pin_tips;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button complete_btn;
        private System.Windows.Forms.Panel pnl_card_payment;
        private System.Windows.Forms.TextBox txt_card_tips;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cardType_combo;
        private System.Windows.Forms.Label label15;
    }
}