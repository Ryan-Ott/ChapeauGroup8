﻿namespace UserInterface
{
    partial class Order_MenuItemSelect
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
            this.btn_Home = new System.Windows.Forms.Button();
            this.pnl_ItemSelect = new System.Windows.Forms.Panel();
            this.liv_MenuItems = new System.Windows.Forms.ListView();
            this.btn_AddItem = new System.Windows.Forms.Button();
            this.lbl_ItemSelect = new System.Windows.Forms.Label();
            this.lbl_Menu_Category = new System.Windows.Forms.Label();
            this.nud_ItemCount = new System.Windows.Forms.NumericUpDown();
            this.liv_CurrentOrder = new System.Windows.Forms.ListView();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Menus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_ChapeauLogo)).BeginInit();
            this.pnl_ItemSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ItemCount)).BeginInit();
            this.SuspendLayout();
            // 
            // pbox_ChapeauLogo
            // 
            this.pbox_ChapeauLogo.Image = global::UserInterface.Properties.Resources.ChapeauLogo;
            this.pbox_ChapeauLogo.Location = new System.Drawing.Point(31, 10);
            this.pbox_ChapeauLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbox_ChapeauLogo.Name = "pbox_ChapeauLogo";
            this.pbox_ChapeauLogo.Size = new System.Drawing.Size(70, 39);
            this.pbox_ChapeauLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_ChapeauLogo.TabIndex = 6;
            this.pbox_ChapeauLogo.TabStop = false;
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.Gold;
            this.btn_Home.Location = new System.Drawing.Point(216, 15);
            this.btn_Home.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(80, 21);
            this.btn_Home.TabIndex = 4;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = false;
            // 
            // pnl_ItemSelect
            // 
            this.pnl_ItemSelect.BackColor = System.Drawing.Color.AliceBlue;
            this.pnl_ItemSelect.Controls.Add(this.liv_MenuItems);
            this.pnl_ItemSelect.Controls.Add(this.btn_AddItem);
            this.pnl_ItemSelect.Controls.Add(this.lbl_ItemSelect);
            this.pnl_ItemSelect.Controls.Add(this.lbl_Menu_Category);
            this.pnl_ItemSelect.Controls.Add(this.nud_ItemCount);
            this.pnl_ItemSelect.Controls.Add(this.liv_CurrentOrder);
            this.pnl_ItemSelect.Controls.Add(this.btn_Submit);
            this.pnl_ItemSelect.Controls.Add(this.btn_Menus);
            this.pnl_ItemSelect.Location = new System.Drawing.Point(31, 51);
            this.pnl_ItemSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_ItemSelect.Name = "pnl_ItemSelect";
            this.pnl_ItemSelect.Size = new System.Drawing.Size(450, 338);
            this.pnl_ItemSelect.TabIndex = 5;
            // 
            // liv_MenuItems
            // 
            this.liv_MenuItems.FullRowSelect = true;
            this.liv_MenuItems.GridLines = true;
            this.liv_MenuItems.HideSelection = false;
            this.liv_MenuItems.Location = new System.Drawing.Point(17, 57);
            this.liv_MenuItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.liv_MenuItems.Name = "liv_MenuItems";
            this.liv_MenuItems.Size = new System.Drawing.Size(202, 217);
            this.liv_MenuItems.TabIndex = 12;
            this.liv_MenuItems.UseCompatibleStateImageBehavior = false;
            this.liv_MenuItems.View = System.Windows.Forms.View.Details;
            // 
            // btn_AddItem
            // 
            this.btn_AddItem.BackColor = System.Drawing.Color.Gold;
            this.btn_AddItem.Location = new System.Drawing.Point(137, 296);
            this.btn_AddItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_AddItem.Name = "btn_AddItem";
            this.btn_AddItem.Size = new System.Drawing.Size(80, 21);
            this.btn_AddItem.TabIndex = 11;
            this.btn_AddItem.Text = "Add";
            this.btn_AddItem.UseVisualStyleBackColor = false;
            // 
            // lbl_ItemSelect
            // 
            this.lbl_ItemSelect.AutoSize = true;
            this.lbl_ItemSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemSelect.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_ItemSelect.Location = new System.Drawing.Point(150, 3);
            this.lbl_ItemSelect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ItemSelect.Name = "lbl_ItemSelect";
            this.lbl_ItemSelect.Size = new System.Drawing.Size(161, 31);
            this.lbl_ItemSelect.TabIndex = 10;
            this.lbl_ItemSelect.Text = "Item Select";
            this.lbl_ItemSelect.Click += new System.EventHandler(this.lbl_ItemSelect_Click);
            // 
            // lbl_Menu_Category
            // 
            this.lbl_Menu_Category.AutoSize = true;
            this.lbl_Menu_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Menu_Category.Location = new System.Drawing.Point(2, 3);
            this.lbl_Menu_Category.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Menu_Category.Name = "lbl_Menu_Category";
            this.lbl_Menu_Category.Size = new System.Drawing.Size(146, 13);
            this.lbl_Menu_Category.TabIndex = 9;
            this.lbl_Menu_Category.Text = "CHANGE THIS IN CODE";
            // 
            // nud_ItemCount
            // 
            this.nud_ItemCount.Location = new System.Drawing.Point(24, 300);
            this.nud_ItemCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nud_ItemCount.Name = "nud_ItemCount";
            this.nud_ItemCount.Size = new System.Drawing.Size(60, 20);
            this.nud_ItemCount.TabIndex = 1;
            // 
            // liv_CurrentOrder
            // 
            this.liv_CurrentOrder.FullRowSelect = true;
            this.liv_CurrentOrder.GridLines = true;
            this.liv_CurrentOrder.HideSelection = false;
            this.liv_CurrentOrder.Location = new System.Drawing.Point(232, 57);
            this.liv_CurrentOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.liv_CurrentOrder.Name = "liv_CurrentOrder";
            this.liv_CurrentOrder.Size = new System.Drawing.Size(202, 217);
            this.liv_CurrentOrder.TabIndex = 6;
            this.liv_CurrentOrder.UseCompatibleStateImageBehavior = false;
            this.liv_CurrentOrder.View = System.Windows.Forms.View.Details;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.Gold;
            this.btn_Submit.Location = new System.Drawing.Point(345, 296);
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
            this.btn_Menus.Location = new System.Drawing.Point(232, 296);
            this.btn_Menus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Menus.Name = "btn_Menus";
            this.btn_Menus.Size = new System.Drawing.Size(80, 21);
            this.btn_Menus.TabIndex = 2;
            this.btn_Menus.Text = "Menus";
            this.btn_Menus.UseVisualStyleBackColor = false;
            // 
            // Order_MenuItemSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(512, 400);
            this.Controls.Add(this.pbox_ChapeauLogo);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.pnl_ItemSelect);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Order_MenuItemSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Order_MenuItemSelect";
            ((System.ComponentModel.ISupportInitialize)(this.pbox_ChapeauLogo)).EndInit();
            this.pnl_ItemSelect.ResumeLayout(false);
            this.pnl_ItemSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ItemCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox_ChapeauLogo;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Panel pnl_ItemSelect;
        private System.Windows.Forms.Label lbl_ItemSelect;
        private System.Windows.Forms.Label lbl_Menu_Category;
        private System.Windows.Forms.NumericUpDown nud_ItemCount;
        private System.Windows.Forms.ListView liv_CurrentOrder;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Menus;
        private System.Windows.Forms.ListView liv_MenuItems;
        private System.Windows.Forms.Button btn_AddItem;
    }
}