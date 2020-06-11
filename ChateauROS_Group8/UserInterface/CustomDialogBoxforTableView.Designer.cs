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
            this.SuspendLayout();
            // 
            // resBtn
            // 
            this.resBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(226)))), ((int)(((byte)(130)))));
            this.resBtn.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.resBtn.Location = new System.Drawing.Point(44, 108);
            this.resBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resBtn.Name = "resBtn";
            this.resBtn.Size = new System.Drawing.Size(170, 35);
            this.resBtn.TabIndex = 0;
            this.resBtn.Text = "Reserve this table";
            this.resBtn.UseVisualStyleBackColor = false;
            // 
            // availBtn
            // 
            this.availBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(226)))), ((int)(((byte)(130)))));
            this.availBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.availBtn.Location = new System.Drawing.Point(133, 167);
            this.availBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.availBtn.Name = "availBtn";
            this.availBtn.Size = new System.Drawing.Size(208, 35);
            this.availBtn.TabIndex = 1;
            this.availBtn.Text = "Cancel (Make Available)";
            this.availBtn.UseVisualStyleBackColor = false;
            // 
            // busyBtn
            // 
            this.busyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(226)))), ((int)(((byte)(130)))));
            this.busyBtn.DialogResult = System.Windows.Forms.DialogResult.No;
            this.busyBtn.Location = new System.Drawing.Point(272, 108);
            this.busyBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.busyBtn.Name = "busyBtn";
            this.busyBtn.Size = new System.Drawing.Size(170, 35);
            this.busyBtn.TabIndex = 2;
            this.busyBtn.Text = "Occupy this table";
            this.busyBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "What would you like to do?";
            // 
            // btn_TakeNewOrder
            // 
            this.btn_TakeNewOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(129)))), ((int)(((byte)(153)))));
            this.btn_TakeNewOrder.ForeColor = System.Drawing.Color.White;
            this.btn_TakeNewOrder.Location = new System.Drawing.Point(44, 223);
            this.btn_TakeNewOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btn_TakeNewOrder.Name = "btn_TakeNewOrder";
            this.btn_TakeNewOrder.Size = new System.Drawing.Size(170, 33);
            this.btn_TakeNewOrder.TabIndex = 4;
            this.btn_TakeNewOrder.Text = "Take New Order";
            this.btn_TakeNewOrder.UseVisualStyleBackColor = false;
            this.btn_TakeNewOrder.Click += new System.EventHandler(this.btn_TakeNewOrder_Click);
            // 
            // btn_PayOrder
            // 
            this.btn_PayOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(129)))), ((int)(((byte)(153)))));
            this.btn_PayOrder.ForeColor = System.Drawing.Color.White;
            this.btn_PayOrder.Location = new System.Drawing.Point(272, 223);
            this.btn_PayOrder.Name = "btn_PayOrder";
            this.btn_PayOrder.Size = new System.Drawing.Size(170, 33);
            this.btn_PayOrder.TabIndex = 5;
            this.btn_PayOrder.Text = "Pay Order";
            this.btn_PayOrder.UseVisualStyleBackColor = false;
            this.btn_PayOrder.Click += new System.EventHandler(this.btn_PayOrder_Click);
            // 
            // CustomDialogBoxforTableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(215)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(506, 292);
            this.Controls.Add(this.btn_PayOrder);
            this.Controls.Add(this.btn_TakeNewOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.busyBtn);
            this.Controls.Add(this.availBtn);
            this.Controls.Add(this.resBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(528, 348);
            this.MinimumSize = new System.Drawing.Size(528, 348);
            this.Name = "CustomDialogBoxforTableView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CustomDialogBoxforTableView";
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
    }
}