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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OrderStatus_txt = new System.Windows.Forms.Label();
            this.pbox_ChapeauLogo = new System.Windows.Forms.PictureBox();
            this.Orderlistlbl = new System.Windows.Forms.ListView();
            this.OrderItemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Req = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastChange = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pbox_ChapeauLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // OrderStatus_txt
            // 
            this.OrderStatus_txt.AutoSize = true;
            this.OrderStatus_txt.BackColor = System.Drawing.Color.White;
            this.OrderStatus_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderStatus_txt.ForeColor = System.Drawing.Color.Black;
            this.OrderStatus_txt.Location = new System.Drawing.Point(294, 83);
            this.OrderStatus_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OrderStatus_txt.Name = "OrderStatus_txt";
            this.OrderStatus_txt.Size = new System.Drawing.Size(180, 31);
            this.OrderStatus_txt.TabIndex = 11;
            this.OrderStatus_txt.Text = "Order Status";
            // 
            // pbox_ChapeauLogo
            // 
            this.pbox_ChapeauLogo.Image = global::UserInterface.Properties.Resources.ChapeauLogo;
            this.pbox_ChapeauLogo.Location = new System.Drawing.Point(23, 21);
            this.pbox_ChapeauLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbox_ChapeauLogo.Name = "pbox_ChapeauLogo";
            this.pbox_ChapeauLogo.Size = new System.Drawing.Size(70, 39);
            this.pbox_ChapeauLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_ChapeauLogo.TabIndex = 4;
            this.pbox_ChapeauLogo.TabStop = false;
            // 
            // Orderlistlbl
            // 
            this.Orderlistlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Orderlistlbl.BackgroundImageTiled = true;
            this.Orderlistlbl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderItemID,
            this.OrderID,
            this.name,
            this.Qty,
            this.Req,
            this.status,
            this.LastChange});
            this.Orderlistlbl.FullRowSelect = true;
            this.Orderlistlbl.HideSelection = false;
            this.Orderlistlbl.Location = new System.Drawing.Point(1, 131);
            this.Orderlistlbl.Name = "Orderlistlbl";
            this.Orderlistlbl.Size = new System.Drawing.Size(798, 255);
            this.Orderlistlbl.TabIndex = 12;
            this.Orderlistlbl.UseCompatibleStateImageBehavior = false;
            this.Orderlistlbl.View = System.Windows.Forms.View.Details;
            this.Orderlistlbl.SelectedIndexChanged += new System.EventHandler(this.Orderlistlbl_SelectedIndexChanged);
            // 
            // OrderItemID
            // 
            this.OrderItemID.Text = "Order Item ID";
            this.OrderItemID.Width = 106;
            // 
            // OrderID
            // 
            this.OrderID.Text = "Order ID";
            this.OrderID.Width = 100;
            // 
            // Qty
            // 
            this.Qty.DisplayIndex = 2;
            this.Qty.Text = "Quantity";
            this.Qty.Width = 93;
            // 
            // Req
            // 
            this.Req.DisplayIndex = 3;
            this.Req.Text = "Requests";
            this.Req.Width = 128;
            // 
            // status
            // 
            this.status.DisplayIndex = 4;
            this.status.Text = "Order Status";
            this.status.Width = 106;
            // 
            // LastChange
            // 
            this.LastChange.DisplayIndex = 5;
            this.LastChange.Text = "Last State Change";
            this.LastChange.Width = 131;
            // 
            // name
            // 
            this.name.DisplayIndex = 6;
            this.name.Text = "Dish Name";
            this.name.Width = 91;
            // 
            // OrderStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(822, 412);
            this.Controls.Add(this.Orderlistlbl);
            this.Controls.Add(this.OrderStatus_txt);
            this.Controls.Add(this.pbox_ChapeauLogo);
            this.Name = "OrderStatus";
            this.Text = "OrderStatus";
            this.Load += new System.EventHandler(this.OrderStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_ChapeauLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox_ChapeauLogo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label OrderStatus_txt;
        private System.Windows.Forms.ListView Orderlistlbl;
        private System.Windows.Forms.ColumnHeader OrderItemID;
        private System.Windows.Forms.ColumnHeader OrderID;
        private System.Windows.Forms.ColumnHeader Qty;
        public System.Windows.Forms.ColumnHeader Req;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.ColumnHeader LastChange;
        private System.Windows.Forms.ColumnHeader name;
    }
}