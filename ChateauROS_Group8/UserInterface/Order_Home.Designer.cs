namespace UserInterface
{
    partial class Order_Home
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
            this.pnl_OrderHome = new System.Windows.Forms.Panel();
            this.txtb_Requests = new System.Windows.Forms.TextBox();
            this.lbl_OrderView = new System.Windows.Forms.Label();
            this.lbl_TableID = new System.Windows.Forms.Label();
            this.nud_ItemCount = new System.Windows.Forms.NumericUpDown();
            this.nud_TableID = new System.Windows.Forms.NumericUpDown();
            this.liv_CurrentOrder = new System.Windows.Forms.ListView();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_AddComment = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Menus = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.pbox_ChapeauLogo = new System.Windows.Forms.PictureBox();
            this.pnl_OrderHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ItemCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_TableID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_ChapeauLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_OrderHome
            // 
            this.pnl_OrderHome.BackColor = System.Drawing.Color.AliceBlue;
            this.pnl_OrderHome.Controls.Add(this.txtb_Requests);
            this.pnl_OrderHome.Controls.Add(this.lbl_OrderView);
            this.pnl_OrderHome.Controls.Add(this.lbl_TableID);
            this.pnl_OrderHome.Controls.Add(this.nud_ItemCount);
            this.pnl_OrderHome.Controls.Add(this.nud_TableID);
            this.pnl_OrderHome.Controls.Add(this.liv_CurrentOrder);
            this.pnl_OrderHome.Controls.Add(this.btn_Delete);
            this.pnl_OrderHome.Controls.Add(this.btn_AddComment);
            this.pnl_OrderHome.Controls.Add(this.btn_Submit);
            this.pnl_OrderHome.Controls.Add(this.btn_Menus);
            this.pnl_OrderHome.Location = new System.Drawing.Point(31, 47);
            this.pnl_OrderHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_OrderHome.Name = "pnl_OrderHome";
            this.pnl_OrderHome.Size = new System.Drawing.Size(450, 338);
            this.pnl_OrderHome.TabIndex = 1;
            this.pnl_OrderHome.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_OrderHome_Paint);
            // 
            // txtb_Requests
            // 
            this.txtb_Requests.Location = new System.Drawing.Point(30, 135);
            this.txtb_Requests.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtb_Requests.Multiline = true;
            this.txtb_Requests.Name = "txtb_Requests";
            this.txtb_Requests.Size = new System.Drawing.Size(182, 85);
            this.txtb_Requests.TabIndex = 3;
            // 
            // lbl_OrderView
            // 
            this.lbl_OrderView.AutoSize = true;
            this.lbl_OrderView.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OrderView.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_OrderView.Location = new System.Drawing.Point(150, 3);
            this.lbl_OrderView.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_OrderView.Name = "lbl_OrderView";
            this.lbl_OrderView.Size = new System.Drawing.Size(159, 31);
            this.lbl_OrderView.TabIndex = 10;
            this.lbl_OrderView.Text = "Order View";
            // 
            // lbl_TableID
            // 
            this.lbl_TableID.AutoSize = true;
            this.lbl_TableID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TableID.Location = new System.Drawing.Point(28, 61);
            this.lbl_TableID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TableID.Name = "lbl_TableID";
            this.lbl_TableID.Size = new System.Drawing.Size(79, 13);
            this.lbl_TableID.TabIndex = 9;
            this.lbl_TableID.Text = "Select Table";
            // 
            // nud_ItemCount
            // 
            this.nud_ItemCount.Location = new System.Drawing.Point(150, 240);
            this.nud_ItemCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nud_ItemCount.Name = "nud_ItemCount";
            this.nud_ItemCount.Size = new System.Drawing.Size(60, 20);
            this.nud_ItemCount.TabIndex = 5;
            // 
            // nud_TableID
            // 
            this.nud_TableID.Location = new System.Drawing.Point(150, 60);
            this.nud_TableID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nud_TableID.Name = "nud_TableID";
            this.nud_TableID.Size = new System.Drawing.Size(60, 20);
            this.nud_TableID.TabIndex = 1;
            // 
            // liv_CurrentOrder
            // 
            this.liv_CurrentOrder.FullRowSelect = true;
            this.liv_CurrentOrder.GridLines = true;
            this.liv_CurrentOrder.HideSelection = false;
            this.liv_CurrentOrder.Location = new System.Drawing.Point(225, 57);
            this.liv_CurrentOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.liv_CurrentOrder.Name = "liv_CurrentOrder";
            this.liv_CurrentOrder.Size = new System.Drawing.Size(202, 262);
            this.liv_CurrentOrder.TabIndex = 6;
            this.liv_CurrentOrder.UseCompatibleStateImageBehavior = false;
            this.liv_CurrentOrder.View = System.Windows.Forms.View.Details;
            this.liv_CurrentOrder.SelectedIndexChanged += new System.EventHandler(this.liv_CurrentOrder_SelectedIndexChanged);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Lavender;
            this.btn_Delete.Location = new System.Drawing.Point(30, 296);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(80, 21);
            this.btn_Delete.TabIndex = 6;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // btn_AddComment
            // 
            this.btn_AddComment.BackColor = System.Drawing.Color.Lavender;
            this.btn_AddComment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_AddComment.Location = new System.Drawing.Point(30, 237);
            this.btn_AddComment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_AddComment.Name = "btn_AddComment";
            this.btn_AddComment.Size = new System.Drawing.Size(80, 21);
            this.btn_AddComment.TabIndex = 4;
            this.btn_AddComment.Text = "Add Comment";
            this.btn_AddComment.UseVisualStyleBackColor = false;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.Gold;
            this.btn_Submit.Location = new System.Drawing.Point(130, 296);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(80, 21);
            this.btn_Submit.TabIndex = 7;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            // 
            // btn_Menus
            // 
            this.btn_Menus.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_Menus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Menus.Location = new System.Drawing.Point(74, 92);
            this.btn_Menus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Menus.Name = "btn_Menus";
            this.btn_Menus.Size = new System.Drawing.Size(90, 31);
            this.btn_Menus.TabIndex = 2;
            this.btn_Menus.Text = "Menus";
            this.btn_Menus.UseVisualStyleBackColor = false;
            this.btn_Menus.Click += new System.EventHandler(this.btn_Menus_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.Gold;
            this.btn_Home.Location = new System.Drawing.Point(216, 10);
            this.btn_Home.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(80, 21);
            this.btn_Home.TabIndex = 0;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = false;
            // 
            // pbox_ChapeauLogo
            // 
            this.pbox_ChapeauLogo.Image = global::UserInterface.Properties.Resources.ChapeauLogo;
            this.pbox_ChapeauLogo.Location = new System.Drawing.Point(31, 5);
            this.pbox_ChapeauLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbox_ChapeauLogo.Name = "pbox_ChapeauLogo";
            this.pbox_ChapeauLogo.Size = new System.Drawing.Size(70, 39);
            this.pbox_ChapeauLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_ChapeauLogo.TabIndex = 3;
            this.pbox_ChapeauLogo.TabStop = false;
            // 
            // Order_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(512, 400);
            this.Controls.Add(this.pbox_ChapeauLogo);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.pnl_OrderHome);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Order_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Order_Home";
            this.Load += new System.EventHandler(this.Order_Home_Load);
            this.pnl_OrderHome.ResumeLayout(false);
            this.pnl_OrderHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ItemCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_TableID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_ChapeauLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_OrderHome;
        private System.Windows.Forms.NumericUpDown nud_ItemCount;
        private System.Windows.Forms.NumericUpDown nud_TableID;
        private System.Windows.Forms.ListView liv_CurrentOrder;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_AddComment;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Menus;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Label lbl_OrderView;
        private System.Windows.Forms.Label lbl_TableID;
        private System.Windows.Forms.TextBox txtb_Requests;
        private System.Windows.Forms.PictureBox pbox_ChapeauLogo;
    }
}