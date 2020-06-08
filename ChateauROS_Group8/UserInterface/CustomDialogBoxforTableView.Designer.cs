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
            this.SuspendLayout();
            // 
            // resBtn
            // 
            this.resBtn.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.resBtn.Location = new System.Drawing.Point(29, 70);
            this.resBtn.Name = "resBtn";
            this.resBtn.Size = new System.Drawing.Size(129, 23);
            this.resBtn.TabIndex = 0;
            this.resBtn.Text = "Reserve this table";
            this.resBtn.UseVisualStyleBackColor = true;
            // 
            // availBtn
            // 
            this.availBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.availBtn.Location = new System.Drawing.Point(91, 128);
            this.availBtn.Name = "availBtn";
            this.availBtn.Size = new System.Drawing.Size(139, 23);
            this.availBtn.TabIndex = 1;
            this.availBtn.Text = "Cancel (Make Available)";
            this.availBtn.UseVisualStyleBackColor = true;
            // 
            // busyBtn
            // 
            this.busyBtn.DialogResult = System.Windows.Forms.DialogResult.No;
            this.busyBtn.Location = new System.Drawing.Point(181, 70);
            this.busyBtn.Name = "busyBtn";
            this.busyBtn.Size = new System.Drawing.Size(108, 23);
            this.busyBtn.TabIndex = 2;
            this.busyBtn.Text = "Occupy this table";
            this.busyBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "What would you like to do?";
            // 
            // CustomDialogBoxforTableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 182);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.busyBtn);
            this.Controls.Add(this.availBtn);
            this.Controls.Add(this.resBtn);
            this.Name = "CustomDialogBoxforTableView";
            this.Text = "CustomDialogBoxforTableView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resBtn;
        private System.Windows.Forms.Button availBtn;
        private System.Windows.Forms.Button busyBtn;
        private System.Windows.Forms.Label label1;
    }
}