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
            this.SuspendLayout();
            // 
            // resBtn
            // 
            this.resBtn.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.resBtn.Location = new System.Drawing.Point(58, 135);
            this.resBtn.Margin = new System.Windows.Forms.Padding(6);
            this.resBtn.Name = "resBtn";
            this.resBtn.Size = new System.Drawing.Size(258, 44);
            this.resBtn.TabIndex = 0;
            this.resBtn.Text = "Reserve this table";
            this.resBtn.UseVisualStyleBackColor = true;
            // 
            // availBtn
            // 
            this.availBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.availBtn.Location = new System.Drawing.Point(192, 209);
            this.availBtn.Margin = new System.Windows.Forms.Padding(6);
            this.availBtn.Name = "availBtn";
            this.availBtn.Size = new System.Drawing.Size(278, 44);
            this.availBtn.TabIndex = 1;
            this.availBtn.Text = "Cancel (Make Available)";
            this.availBtn.UseVisualStyleBackColor = true;
            // 
            // busyBtn
            // 
            this.busyBtn.DialogResult = System.Windows.Forms.DialogResult.No;
            this.busyBtn.Location = new System.Drawing.Point(362, 135);
            this.busyBtn.Margin = new System.Windows.Forms.Padding(6);
            this.busyBtn.Name = "busyBtn";
            this.busyBtn.Size = new System.Drawing.Size(216, 44);
            this.busyBtn.TabIndex = 2;
            this.busyBtn.Text = "Occupy this table";
            this.busyBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "What would you like to do?";
            // 
            // btn_TakeNewOrder
            // 
            this.btn_TakeNewOrder.Location = new System.Drawing.Point(58, 279);
            this.btn_TakeNewOrder.Name = "btn_TakeNewOrder";
            this.btn_TakeNewOrder.Size = new System.Drawing.Size(191, 41);
            this.btn_TakeNewOrder.TabIndex = 4;
            this.btn_TakeNewOrder.Text = "Take New Order";
            this.btn_TakeNewOrder.UseVisualStyleBackColor = true;
            this.btn_TakeNewOrder.Click += new System.EventHandler(this.btn_TakeNewOrder_Click);
            // 
            // CustomDialogBoxforTableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 350);
            this.Controls.Add(this.btn_TakeNewOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.busyBtn);
            this.Controls.Add(this.availBtn);
            this.Controls.Add(this.resBtn);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(696, 421);
            this.MinimumSize = new System.Drawing.Size(696, 421);
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
    }
}