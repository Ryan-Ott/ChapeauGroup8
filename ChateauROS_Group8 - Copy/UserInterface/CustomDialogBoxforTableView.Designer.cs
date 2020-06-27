namespace UserInterface
{
    partial class CustomDialogBoxforTableView
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
            this.resBtn = new System.Windows.Forms.Button();
            this.availBtn = new System.Windows.Forms.Button();
            this.busyBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_TakeNewOrder = new System.Windows.Forms.Button();
            this.btn_PayOrder = new System.Windows.Forms.Button();
            this.pbox_ChapeauLogo = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Button();
            this.displayOrderBtn = new System.Windows.Forms.Button();
            this.lblTable = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_ChapeauLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // resBtn
            // 
            this.resBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(226)))), ((int)(((byte)(130)))));
            this.resBtn.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.resBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resBtn.Location = new System.Drawing.Point(46, 167);
            this.resBtn.Name = "resBtn";
            this.resBtn.Size = new System.Drawing.Size(126, 50);
            this.resBtn.TabIndex = 0;
            this.resBtn.Text = "Reserve this table";
            this.resBtn.UseVisualStyleBackColor = false;
            // 
            // availBtn
            // 
            this.availBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(226)))), ((int)(((byte)(130)))));
            this.availBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.availBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availBtn.Location = new System.Drawing.Point(178, 167);
            this.availBtn.Name = "availBtn";
            this.availBtn.Size = new System.Drawing.Size(149, 50);
            this.availBtn.TabIndex = 1;
            this.availBtn.Text = "Mark Table as Available";
            this.availBtn.UseVisualStyleBackColor = false;
            // 
            // busyBtn
            // 
            this.busyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(226)))), ((int)(((byte)(130)))));
            this.busyBtn.DialogResult = System.Windows.Forms.DialogResult.No;
            this.busyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busyBtn.Location = new System.Drawing.Point(333, 167);
            this.busyBtn.Name = "busyBtn";
            this.busyBtn.Size = new System.Drawing.Size(126, 50);
            this.busyBtn.TabIndex = 2;
            this.busyBtn.Text = "Occupy this table";
            this.busyBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "What would you like to do?";
            // 
            // btn_TakeNewOrder
            // 
            this.btn_TakeNewOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(129)))), ((int)(((byte)(153)))));
            this.btn_TakeNewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TakeNewOrder.ForeColor = System.Drawing.Color.White;
            this.btn_TakeNewOrder.Location = new System.Drawing.Point(10, 221);
            this.btn_TakeNewOrder.Margin = new System.Windows.Forms.Padding(1);
            this.btn_TakeNewOrder.Name = "btn_TakeNewOrder";
            this.btn_TakeNewOrder.Size = new System.Drawing.Size(150, 41);
            this.btn_TakeNewOrder.TabIndex = 4;
            this.btn_TakeNewOrder.Text = "Take New Order";
            this.btn_TakeNewOrder.UseVisualStyleBackColor = false;
            this.btn_TakeNewOrder.Click += new System.EventHandler(this.btn_TakeNewOrder_Click);
            // 
            // btn_PayOrder
            // 
            this.btn_PayOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(129)))), ((int)(((byte)(153)))));
            this.btn_PayOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PayOrder.ForeColor = System.Drawing.Color.White;
            this.btn_PayOrder.Location = new System.Drawing.Point(163, 222);
            this.btn_PayOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btn_PayOrder.Name = "btn_PayOrder";
            this.btn_PayOrder.Size = new System.Drawing.Size(139, 41);
            this.btn_PayOrder.TabIndex = 5;
            this.btn_PayOrder.Text = "Pay Order";
            this.btn_PayOrder.UseVisualStyleBackColor = false;
            this.btn_PayOrder.Click += new System.EventHandler(this.btn_PayOrder_Click);
            // 
            // pbox_ChapeauLogo
            // 
            this.pbox_ChapeauLogo.Image = global::UserInterface.Properties.Resources.ChapeauLogo;
            this.pbox_ChapeauLogo.Location = new System.Drawing.Point(11, 11);
            this.pbox_ChapeauLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbox_ChapeauLogo.Name = "pbox_ChapeauLogo";
            this.pbox_ChapeauLogo.Size = new System.Drawing.Size(100, 52);
            this.pbox_ChapeauLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_ChapeauLogo.TabIndex = 6;
            this.pbox_ChapeauLogo.TabStop = false;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(204, 354);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 7;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // displayOrderBtn
            // 
            this.displayOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(129)))), ((int)(((byte)(153)))));
            this.displayOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayOrderBtn.ForeColor = System.Drawing.Color.White;
            this.displayOrderBtn.Location = new System.Drawing.Point(306, 222);
            this.displayOrderBtn.Margin = new System.Windows.Forms.Padding(2);
            this.displayOrderBtn.Name = "displayOrderBtn";
            this.displayOrderBtn.Size = new System.Drawing.Size(177, 52);
            this.displayOrderBtn.TabIndex = 8;
            this.displayOrderBtn.Text = "Display Current Order for this Table";
            this.displayOrderBtn.UseVisualStyleBackColor = false;
            this.displayOrderBtn.Click += new System.EventHandler(this.displayOrderBtn_Click);
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(447, 13);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(25, 13);
            this.lblTable.TabIndex = 9;
            this.lblTable.Text = "___";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Table Number:";
            // 
            // CustomDialogBoxforTableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(215)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(512, 389);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.displayOrderBtn);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pbox_ChapeauLogo);
            this.Controls.Add(this.btn_PayOrder);
            this.Controls.Add(this.btn_TakeNewOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.busyBtn);
            this.Controls.Add(this.availBtn);
            this.Controls.Add(this.resBtn);
            this.MaximumSize = new System.Drawing.Size(528, 428);
            this.MinimumSize = new System.Drawing.Size(357, 240);
            this.Name = "CustomDialogBoxforTableView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Table Action";
            this.Load += new System.EventHandler(this.CustomDialogBoxforTableView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_ChapeauLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resBtn;
        private System.Windows.Forms.Button availBtn;
        private System.Windows.Forms.Button busyBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_TakeNewOrder;
        private System.Windows.Forms.Button btn_PayOrder;
        private System.Windows.Forms.PictureBox pbox_ChapeauLogo;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button displayOrderBtn;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label label3;
    }
}