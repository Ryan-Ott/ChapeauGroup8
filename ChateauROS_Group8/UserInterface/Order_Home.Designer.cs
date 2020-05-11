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
            this.trv_AllMenuItems = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // trv_AllMenuItems
            // 
            this.trv_AllMenuItems.BackColor = System.Drawing.Color.LemonChiffon;
            this.trv_AllMenuItems.Location = new System.Drawing.Point(13, 72);
            this.trv_AllMenuItems.Name = "trv_AllMenuItems";
            this.trv_AllMenuItems.Size = new System.Drawing.Size(350, 613);
            this.trv_AllMenuItems.TabIndex = 0;
            this.trv_AllMenuItems.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trv_AllMenuItems_AfterSelect);
            // 
            // Order_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(998, 697);
            this.Controls.Add(this.trv_AllMenuItems);
            this.Name = "Order_Home";
            this.Text = "Order_Home";
            this.Load += new System.EventHandler(this.Order_Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trv_AllMenuItems;
    }
}