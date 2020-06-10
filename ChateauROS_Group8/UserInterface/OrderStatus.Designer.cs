namespace UserInterface
{
    partial class OrderStatus
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
            this.components = new System.ComponentModel.Container();
            this.kitchenlbl = new System.Windows.Forms.Label();
            this.Corderview = new System.Windows.Forms.ListView();
            this.namedish = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastChange = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderItemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TableID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.requeststxt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prepbtn = new System.Windows.Forms.Button();
            this.rdybtn = new System.Windows.Forms.Button();
            this.rdytablcontrol = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Ordersview = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Barlbl = new System.Windows.Forms.Label();
            this.serverlbl = new System.Windows.Forms.Label();
            this.Crossmarkpic = new System.Windows.Forms.PictureBox();
            this.Checkmarkpic = new System.Windows.Forms.PictureBox();
            this.pbox_ChapeauLogo = new System.Windows.Forms.PictureBox();
            this.autorefresh = new System.Windows.Forms.Timer(this.components);
            this.rdytablcontrol.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Crossmarkpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Checkmarkpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_ChapeauLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // kitchenlbl
            // 
            this.kitchenlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(226)))), ((int)(((byte)(130)))));
            this.kitchenlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kitchenlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitchenlbl.Location = new System.Drawing.Point(326, 33);
            this.kitchenlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kitchenlbl.Name = "kitchenlbl";
            this.kitchenlbl.Size = new System.Drawing.Size(479, 48);
            this.kitchenlbl.TabIndex = 15;
            this.kitchenlbl.Text = "Orders Status: Kitchen";
            this.kitchenlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.kitchenlbl.Click += new System.EventHandler(this.lbl_bill_Click);
            // 
            // Corderview
            // 
            this.Corderview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Corderview.BackgroundImageTiled = true;
            this.Corderview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.namedish,
            this.Qty,
            this.OrderID,
            this.status,
            this.LastChange,
            this.OrderItemID,
            this.TableID});
            this.Corderview.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Corderview.ForeColor = System.Drawing.Color.Black;
            this.Corderview.FullRowSelect = true;
            this.Corderview.HideSelection = false;
            this.Corderview.Location = new System.Drawing.Point(0, 0);
            this.Corderview.Name = "Corderview";
            this.Corderview.Size = new System.Drawing.Size(768, 431);
            this.Corderview.TabIndex = 12;
            this.Corderview.UseCompatibleStateImageBehavior = false;
            this.Corderview.View = System.Windows.Forms.View.Details;
            this.Corderview.SelectedIndexChanged += new System.EventHandler(this.Corderview_SelectedIndexChanged);
            // 
            // namedish
            // 
            this.namedish.Text = "Dish Name";
            this.namedish.Width = 173;
            // 
            // Qty
            // 
            this.Qty.Text = "Quantity";
            this.Qty.Width = 73;
            // 
            // OrderID
            // 
            this.OrderID.Text = "Order ID";
            this.OrderID.Width = 70;
            // 
            // status
            // 
            this.status.Text = "Order Status";
            this.status.Width = 98;
            // 
            // LastChange
            // 
            this.LastChange.Text = "Last State Change";
            this.LastChange.Width = 139;
            // 
            // OrderItemID
            // 
            this.OrderItemID.Text = "Order Item ID";
            this.OrderItemID.Width = 102;
            // 
            // TableID
            // 
            this.TableID.Text = "Table ID";
            this.TableID.Width = 177;
            // 
            // requeststxt
            // 
            this.requeststxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requeststxt.Location = new System.Drawing.Point(832, 159);
            this.requeststxt.Name = "requeststxt";
            this.requeststxt.ReadOnly = true;
            this.requeststxt.Size = new System.Drawing.Size(191, 168);
            this.requeststxt.TabIndex = 14;
            this.requeststxt.Text = "";
            this.requeststxt.TextChanged += new System.EventHandler(this.requeststxt_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(226)))), ((int)(((byte)(130)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(832, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 35);
            this.label1.TabIndex = 16;
            this.label1.Text = "Order Comments:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prepbtn
            // 
            this.prepbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(226)))), ((int)(((byte)(130)))));
            this.prepbtn.Location = new System.Drawing.Point(832, 354);
            this.prepbtn.Name = "prepbtn";
            this.prepbtn.Size = new System.Drawing.Size(191, 57);
            this.prepbtn.TabIndex = 17;
            this.prepbtn.Text = "Change to Preparing";
            this.prepbtn.UseVisualStyleBackColor = false;
            this.prepbtn.Click += new System.EventHandler(this.prepbtn_Click);
            // 
            // rdybtn
            // 
            this.rdybtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(226)))), ((int)(((byte)(130)))));
            this.rdybtn.Location = new System.Drawing.Point(832, 428);
            this.rdybtn.Name = "rdybtn";
            this.rdybtn.Size = new System.Drawing.Size(191, 57);
            this.rdybtn.TabIndex = 18;
            this.rdybtn.Text = "Change to Ready";
            this.rdybtn.UseVisualStyleBackColor = false;
            this.rdybtn.Click += new System.EventHandler(this.rdybtn_Click);
            // 
            // rdytablcontrol
            // 
            this.rdytablcontrol.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.rdytablcontrol.Controls.Add(this.tabPage1);
            this.rdytablcontrol.Controls.Add(this.tabPage2);
            this.rdytablcontrol.Location = new System.Drawing.Point(10, 107);
            this.rdytablcontrol.Multiline = true;
            this.rdytablcontrol.Name = "rdytablcontrol";
            this.rdytablcontrol.SelectedIndex = 0;
            this.rdytablcontrol.Size = new System.Drawing.Size(795, 439);
            this.rdytablcontrol.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Ordersview);
            this.tabPage1.Location = new System.Drawing.Point(23, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 431);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Orders";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Ordersview
            // 
            this.Ordersview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ordersview.BackgroundImageTiled = true;
            this.Ordersview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.Ordersview.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ordersview.ForeColor = System.Drawing.Color.Black;
            this.Ordersview.FullRowSelect = true;
            this.Ordersview.HideSelection = false;
            this.Ordersview.Location = new System.Drawing.Point(0, 0);
            this.Ordersview.Name = "Ordersview";
            this.Ordersview.Size = new System.Drawing.Size(768, 431);
            this.Ordersview.TabIndex = 13;
            this.Ordersview.UseCompatibleStateImageBehavior = false;
            this.Ordersview.View = System.Windows.Forms.View.Details;
            this.Ordersview.SelectedIndexChanged += new System.EventHandler(this.Ordersview_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Dish Name";
            this.columnHeader1.Width = 173;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantity";
            this.columnHeader2.Width = 73;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Order ID";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Order Status";
            this.columnHeader4.Width = 98;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Last State Change";
            this.columnHeader5.Width = 139;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Order Item ID";
            this.columnHeader6.Width = 102;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Table ID";
            this.columnHeader7.Width = 177;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Corderview);
            this.tabPage2.Location = new System.Drawing.Point(23, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 431);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Completed Orders";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Barlbl
            // 
            this.Barlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(226)))), ((int)(((byte)(130)))));
            this.Barlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Barlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barlbl.Location = new System.Drawing.Point(326, 33);
            this.Barlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Barlbl.Name = "Barlbl";
            this.Barlbl.Size = new System.Drawing.Size(479, 48);
            this.Barlbl.TabIndex = 20;
            this.Barlbl.Text = "Orders Status: Bar";
            this.Barlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serverlbl
            // 
            this.serverlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(226)))), ((int)(((byte)(130)))));
            this.serverlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serverlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverlbl.Location = new System.Drawing.Point(326, 33);
            this.serverlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.serverlbl.Name = "serverlbl";
            this.serverlbl.Size = new System.Drawing.Size(479, 48);
            this.serverlbl.TabIndex = 21;
            this.serverlbl.Text = "Orders Status: Waiter";
            this.serverlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Crossmarkpic
            // 
            this.Crossmarkpic.Image = global::UserInterface.Properties.Resources.CrossMark;
            this.Crossmarkpic.Location = new System.Drawing.Point(892, 484);
            this.Crossmarkpic.Margin = new System.Windows.Forms.Padding(2);
            this.Crossmarkpic.Name = "Crossmarkpic";
            this.Crossmarkpic.Size = new System.Drawing.Size(65, 62);
            this.Crossmarkpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Crossmarkpic.TabIndex = 23;
            this.Crossmarkpic.TabStop = false;
            // 
            // Checkmarkpic
            // 
            this.Checkmarkpic.Image = global::UserInterface.Properties.Resources.CheckMark;
            this.Checkmarkpic.Location = new System.Drawing.Point(892, 484);
            this.Checkmarkpic.Margin = new System.Windows.Forms.Padding(2);
            this.Checkmarkpic.Name = "Checkmarkpic";
            this.Checkmarkpic.Size = new System.Drawing.Size(65, 62);
            this.Checkmarkpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Checkmarkpic.TabIndex = 22;
            this.Checkmarkpic.TabStop = false;
            // 
            // pbox_ChapeauLogo
            // 
            this.pbox_ChapeauLogo.Image = global::UserInterface.Properties.Resources.ChapeauLogo;
            this.pbox_ChapeauLogo.Location = new System.Drawing.Point(16, -6);
            this.pbox_ChapeauLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbox_ChapeauLogo.Name = "pbox_ChapeauLogo";
            this.pbox_ChapeauLogo.Size = new System.Drawing.Size(198, 105);
            this.pbox_ChapeauLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_ChapeauLogo.TabIndex = 4;
            this.pbox_ChapeauLogo.TabStop = false;
            // 
            // autorefresh
            // 
            this.autorefresh.Enabled = true;
            this.autorefresh.Interval = 60000;
            this.autorefresh.Tick += new System.EventHandler(this.autorefresh_Tick);
            // 
            // OrderStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1044, 563);
            this.Controls.Add(this.Crossmarkpic);
            this.Controls.Add(this.Checkmarkpic);
            this.Controls.Add(this.serverlbl);
            this.Controls.Add(this.Barlbl);
            this.Controls.Add(this.rdybtn);
            this.Controls.Add(this.prepbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.requeststxt);
            this.Controls.Add(this.kitchenlbl);
            this.Controls.Add(this.pbox_ChapeauLogo);
            this.Controls.Add(this.rdytablcontrol);
            this.Name = "OrderStatus";
            this.Text = "OrderStatus";
            this.Load += new System.EventHandler(this.OrderStatus_Load);
            this.rdytablcontrol.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Crossmarkpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Checkmarkpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_ChapeauLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox_ChapeauLogo;
        private System.Windows.Forms.Label kitchenlbl;
        private System.Windows.Forms.ListView Corderview;
        private System.Windows.Forms.ColumnHeader namedish;
        private System.Windows.Forms.ColumnHeader Qty;
        private System.Windows.Forms.ColumnHeader OrderItemID;
        private System.Windows.Forms.ColumnHeader OrderID;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.ColumnHeader LastChange;
        private System.Windows.Forms.RichTextBox requeststxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button prepbtn;
        private System.Windows.Forms.Button rdybtn;
        private System.Windows.Forms.ColumnHeader TableID;
        private System.Windows.Forms.TabControl rdytablcontrol;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView Ordersview;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label Barlbl;
        private System.Windows.Forms.Label serverlbl;
        private System.Windows.Forms.PictureBox Checkmarkpic;
        private System.Windows.Forms.PictureBox Crossmarkpic;
        private System.Windows.Forms.Timer autorefresh;
    }
}