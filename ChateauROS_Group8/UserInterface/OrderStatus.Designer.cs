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
            this.pbox_ChapeauLogo = new System.Windows.Forms.PictureBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.Orderlistlbl = new System.Windows.Forms.ListView();
            this.namedish = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderItemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastChange = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.requeststxt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prepbtn = new System.Windows.Forms.Button();
            this.rdybtn = new System.Windows.Forms.Button();
            this.TableID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pbox_ChapeauLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbox_ChapeauLogo
            // 
            this.pbox_ChapeauLogo.Image = global::UserInterface.Properties.Resources.ChapeauLogo;
            this.pbox_ChapeauLogo.Location = new System.Drawing.Point(10, 11);
            this.pbox_ChapeauLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbox_ChapeauLogo.Name = "pbox_ChapeauLogo";
            this.pbox_ChapeauLogo.Size = new System.Drawing.Size(198, 105);
            this.pbox_ChapeauLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_ChapeauLogo.TabIndex = 4;
            this.pbox_ChapeauLogo.TabStop = false;
            // 
            // lbl_status
            // 
            this.lbl_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(226)))), ((int)(((byte)(130)))));
            this.lbl_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(316, 29);
            this.lbl_status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(479, 48);
            this.lbl_status.TabIndex = 15;
            this.lbl_status.Text = "Orders Pending Preparation: Kitchen";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_status.Click += new System.EventHandler(this.lbl_bill_Click);
            // 
            // Orderlistlbl
            // 
            this.Orderlistlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Orderlistlbl.BackgroundImageTiled = true;
            this.Orderlistlbl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.namedish,
            this.Qty,
            this.OrderID,
            this.status,
            this.LastChange,
            this.OrderItemID,
            this.TableID});
            this.Orderlistlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Orderlistlbl.ForeColor = System.Drawing.Color.Black;
            this.Orderlistlbl.FullRowSelect = true;
            this.Orderlistlbl.HideSelection = false;
            this.Orderlistlbl.Location = new System.Drawing.Point(10, 121);
            this.Orderlistlbl.Name = "Orderlistlbl";
            this.Orderlistlbl.Size = new System.Drawing.Size(785, 379);
            this.Orderlistlbl.TabIndex = 12;
            this.Orderlistlbl.UseCompatibleStateImageBehavior = false;
            this.Orderlistlbl.View = System.Windows.Forms.View.Details;
            this.Orderlistlbl.SelectedIndexChanged += new System.EventHandler(this.Orderlistlbl_SelectedIndexChanged);
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
            // OrderItemID
            // 
            this.OrderItemID.Text = "Order Item ID";
            this.OrderItemID.Width = 102;
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
            // requeststxt
            // 
            this.requeststxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requeststxt.Location = new System.Drawing.Point(813, 159);
            this.requeststxt.Name = "requeststxt";
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
            this.label1.Location = new System.Drawing.Point(813, 121);
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
            this.prepbtn.Location = new System.Drawing.Point(813, 353);
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
            this.rdybtn.Location = new System.Drawing.Point(813, 428);
            this.rdybtn.Name = "rdybtn";
            this.rdybtn.Size = new System.Drawing.Size(191, 57);
            this.rdybtn.TabIndex = 18;
            this.rdybtn.Text = "Change to Ready";
            this.rdybtn.UseVisualStyleBackColor = false;
            // 
            // TableID
            // 
            this.TableID.Text = "Table ID";
            this.TableID.Width = 177;
            // 
            // OrderStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1025, 537);
            this.Controls.Add(this.rdybtn);
            this.Controls.Add(this.prepbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.requeststxt);
            this.Controls.Add(this.Orderlistlbl);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.pbox_ChapeauLogo);
            this.Name = "OrderStatus";
            this.Text = "OrderStatus";
            this.Load += new System.EventHandler(this.OrderStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_ChapeauLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox_ChapeauLogo;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.ListView Orderlistlbl;
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
    }
}