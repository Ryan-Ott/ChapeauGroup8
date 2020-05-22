namespace UserInterface
{
    partial class Order_MenuSelect
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
            this.btn_Home = new System.Windows.Forms.Button();
            this.pbox_ChapeauLogo = new System.Windows.Forms.PictureBox();
            this.pnl_MenuSelect = new System.Windows.Forms.Panel();
            this.lbl_MenuSelect = new System.Windows.Forms.Label();
            this.btn_Order = new System.Windows.Forms.Button();
            this.gbx_Lunch = new System.Windows.Forms.GroupBox();
            this.gbx_Drinks = new System.Windows.Forms.GroupBox();
            this.gbx_Dinner = new System.Windows.Forms.GroupBox();
            this.btn_LunchMain = new System.Windows.Forms.Button();
            this.btn_Specials = new System.Windows.Forms.Button();
            this.btn_Bites = new System.Windows.Forms.Button();
            this.btn_Starters = new System.Windows.Forms.Button();
            this.btn_Mains = new System.Windows.Forms.Button();
            this.btn_Desserts = new System.Windows.Forms.Button();
            this.btn_SoftDrinks = new System.Windows.Forms.Button();
            this.btn_HotDrinks = new System.Windows.Forms.Button();
            this.btn_Beers = new System.Windows.Forms.Button();
            this.btn_Wines = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_ChapeauLogo)).BeginInit();
            this.pnl_MenuSelect.SuspendLayout();
            this.gbx_Lunch.SuspendLayout();
            this.gbx_Drinks.SuspendLayout();
            this.gbx_Dinner.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.Gold;
            this.btn_Home.Location = new System.Drawing.Point(432, 20);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(160, 40);
            this.btn_Home.TabIndex = 1;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // pbox_ChapeauLogo
            // 
            this.pbox_ChapeauLogo.Image = global::UserInterface.Properties.Resources.ChapeauLogo;
            this.pbox_ChapeauLogo.Location = new System.Drawing.Point(62, 9);
            this.pbox_ChapeauLogo.Name = "pbox_ChapeauLogo";
            this.pbox_ChapeauLogo.Size = new System.Drawing.Size(140, 75);
            this.pbox_ChapeauLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_ChapeauLogo.TabIndex = 4;
            this.pbox_ChapeauLogo.TabStop = false;
            // 
            // pnl_MenuSelect
            // 
            this.pnl_MenuSelect.BackColor = System.Drawing.Color.AliceBlue;
            this.pnl_MenuSelect.Controls.Add(this.gbx_Dinner);
            this.pnl_MenuSelect.Controls.Add(this.gbx_Drinks);
            this.pnl_MenuSelect.Controls.Add(this.gbx_Lunch);
            this.pnl_MenuSelect.Controls.Add(this.lbl_MenuSelect);
            this.pnl_MenuSelect.Location = new System.Drawing.Point(62, 90);
            this.pnl_MenuSelect.Name = "pnl_MenuSelect";
            this.pnl_MenuSelect.Size = new System.Drawing.Size(900, 650);
            this.pnl_MenuSelect.TabIndex = 5;
            // 
            // lbl_MenuSelect
            // 
            this.lbl_MenuSelect.AutoSize = true;
            this.lbl_MenuSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MenuSelect.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_MenuSelect.Location = new System.Drawing.Point(280, 6);
            this.lbl_MenuSelect.Name = "lbl_MenuSelect";
            this.lbl_MenuSelect.Size = new System.Drawing.Size(338, 63);
            this.lbl_MenuSelect.TabIndex = 11;
            this.lbl_MenuSelect.Text = "Menu Select";
            // 
            // btn_Order
            // 
            this.btn_Order.BackColor = System.Drawing.Color.Gold;
            this.btn_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Order.Location = new System.Drawing.Point(802, 60);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(160, 60);
            this.btn_Order.TabIndex = 12;
            this.btn_Order.Text = "Order";
            this.btn_Order.UseVisualStyleBackColor = false;
            this.btn_Order.Click += new System.EventHandler(this.btn_Order_Click);
            // 
            // gbx_Lunch
            // 
            this.gbx_Lunch.BackColor = System.Drawing.Color.DarkSlateGray;
            this.gbx_Lunch.Controls.Add(this.btn_Bites);
            this.gbx_Lunch.Controls.Add(this.btn_Specials);
            this.gbx_Lunch.Controls.Add(this.btn_LunchMain);
            this.gbx_Lunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_Lunch.ForeColor = System.Drawing.Color.Gold;
            this.gbx_Lunch.Location = new System.Drawing.Point(40, 100);
            this.gbx_Lunch.Name = "gbx_Lunch";
            this.gbx_Lunch.Size = new System.Drawing.Size(250, 500);
            this.gbx_Lunch.TabIndex = 12;
            this.gbx_Lunch.TabStop = false;
            this.gbx_Lunch.Text = "Lunch";
            // 
            // gbx_Drinks
            // 
            this.gbx_Drinks.BackColor = System.Drawing.Color.DarkSlateGray;
            this.gbx_Drinks.Controls.Add(this.btn_Wines);
            this.gbx_Drinks.Controls.Add(this.btn_Beers);
            this.gbx_Drinks.Controls.Add(this.btn_HotDrinks);
            this.gbx_Drinks.Controls.Add(this.btn_SoftDrinks);
            this.gbx_Drinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_Drinks.ForeColor = System.Drawing.Color.Gold;
            this.gbx_Drinks.Location = new System.Drawing.Point(615, 100);
            this.gbx_Drinks.Name = "gbx_Drinks";
            this.gbx_Drinks.Size = new System.Drawing.Size(250, 500);
            this.gbx_Drinks.TabIndex = 13;
            this.gbx_Drinks.TabStop = false;
            this.gbx_Drinks.Text = " Drinks";
            // 
            // gbx_Dinner
            // 
            this.gbx_Dinner.BackColor = System.Drawing.Color.DarkSlateGray;
            this.gbx_Dinner.Controls.Add(this.btn_Desserts);
            this.gbx_Dinner.Controls.Add(this.btn_Mains);
            this.gbx_Dinner.Controls.Add(this.btn_Starters);
            this.gbx_Dinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_Dinner.ForeColor = System.Drawing.Color.Gold;
            this.gbx_Dinner.Location = new System.Drawing.Point(325, 100);
            this.gbx_Dinner.Name = "gbx_Dinner";
            this.gbx_Dinner.Size = new System.Drawing.Size(250, 500);
            this.gbx_Dinner.TabIndex = 14;
            this.gbx_Dinner.TabStop = false;
            this.gbx_Dinner.Text = "Dinner";
            // 
            // btn_LunchMain
            // 
            this.btn_LunchMain.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_LunchMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LunchMain.ForeColor = System.Drawing.Color.Gold;
            this.btn_LunchMain.Location = new System.Drawing.Point(48, 81);
            this.btn_LunchMain.Name = "btn_LunchMain";
            this.btn_LunchMain.Size = new System.Drawing.Size(160, 80);
            this.btn_LunchMain.TabIndex = 0;
            this.btn_LunchMain.Text = "Lunch Main";
            this.btn_LunchMain.UseVisualStyleBackColor = false;
            this.btn_LunchMain.Click += new System.EventHandler(this.btn_LunchMain_Click);
            // 
            // btn_Specials
            // 
            this.btn_Specials.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_Specials.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Specials.ForeColor = System.Drawing.Color.Gold;
            this.btn_Specials.Location = new System.Drawing.Point(48, 225);
            this.btn_Specials.Name = "btn_Specials";
            this.btn_Specials.Size = new System.Drawing.Size(160, 80);
            this.btn_Specials.TabIndex = 1;
            this.btn_Specials.Text = "Specials";
            this.btn_Specials.UseVisualStyleBackColor = false;
            this.btn_Specials.Click += new System.EventHandler(this.btn_Specials_Click);
            // 
            // btn_Bites
            // 
            this.btn_Bites.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_Bites.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bites.ForeColor = System.Drawing.Color.Gold;
            this.btn_Bites.Location = new System.Drawing.Point(48, 376);
            this.btn_Bites.Name = "btn_Bites";
            this.btn_Bites.Size = new System.Drawing.Size(160, 80);
            this.btn_Bites.TabIndex = 2;
            this.btn_Bites.Text = "Bites";
            this.btn_Bites.UseVisualStyleBackColor = false;
            this.btn_Bites.Click += new System.EventHandler(this.btn_Bites_Click);
            // 
            // btn_Starters
            // 
            this.btn_Starters.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_Starters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Starters.ForeColor = System.Drawing.Color.Gold;
            this.btn_Starters.Location = new System.Drawing.Point(46, 81);
            this.btn_Starters.Name = "btn_Starters";
            this.btn_Starters.Size = new System.Drawing.Size(160, 80);
            this.btn_Starters.TabIndex = 1;
            this.btn_Starters.Text = "Starters";
            this.btn_Starters.UseVisualStyleBackColor = false;
            this.btn_Starters.Click += new System.EventHandler(this.btn_Starters_Click);
            // 
            // btn_Mains
            // 
            this.btn_Mains.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_Mains.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mains.ForeColor = System.Drawing.Color.Gold;
            this.btn_Mains.Location = new System.Drawing.Point(46, 225);
            this.btn_Mains.Name = "btn_Mains";
            this.btn_Mains.Size = new System.Drawing.Size(160, 80);
            this.btn_Mains.TabIndex = 2;
            this.btn_Mains.Text = "Mains";
            this.btn_Mains.UseVisualStyleBackColor = false;
            this.btn_Mains.Click += new System.EventHandler(this.btn_Mains_Click);
            // 
            // btn_Desserts
            // 
            this.btn_Desserts.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_Desserts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Desserts.ForeColor = System.Drawing.Color.Gold;
            this.btn_Desserts.Location = new System.Drawing.Point(46, 376);
            this.btn_Desserts.Name = "btn_Desserts";
            this.btn_Desserts.Size = new System.Drawing.Size(160, 80);
            this.btn_Desserts.TabIndex = 3;
            this.btn_Desserts.Text = "Desserts";
            this.btn_Desserts.UseVisualStyleBackColor = false;
            this.btn_Desserts.Click += new System.EventHandler(this.btn_Desserts_Click);
            // 
            // btn_SoftDrinks
            // 
            this.btn_SoftDrinks.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_SoftDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SoftDrinks.ForeColor = System.Drawing.Color.Gold;
            this.btn_SoftDrinks.Location = new System.Drawing.Point(49, 81);
            this.btn_SoftDrinks.Name = "btn_SoftDrinks";
            this.btn_SoftDrinks.Size = new System.Drawing.Size(160, 80);
            this.btn_SoftDrinks.TabIndex = 1;
            this.btn_SoftDrinks.Text = "Soft Drinks";
            this.btn_SoftDrinks.UseVisualStyleBackColor = false;
            this.btn_SoftDrinks.Click += new System.EventHandler(this.btn_SoftDrinks_Click);
            // 
            // btn_HotDrinks
            // 
            this.btn_HotDrinks.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_HotDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HotDrinks.ForeColor = System.Drawing.Color.Gold;
            this.btn_HotDrinks.Location = new System.Drawing.Point(49, 182);
            this.btn_HotDrinks.Name = "btn_HotDrinks";
            this.btn_HotDrinks.Size = new System.Drawing.Size(160, 80);
            this.btn_HotDrinks.TabIndex = 2;
            this.btn_HotDrinks.Text = "Hot Drinks";
            this.btn_HotDrinks.UseVisualStyleBackColor = false;
            this.btn_HotDrinks.Click += new System.EventHandler(this.btn_HotDrinks_Click);
            // 
            // btn_Beers
            // 
            this.btn_Beers.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_Beers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Beers.ForeColor = System.Drawing.Color.Gold;
            this.btn_Beers.Location = new System.Drawing.Point(49, 279);
            this.btn_Beers.Name = "btn_Beers";
            this.btn_Beers.Size = new System.Drawing.Size(160, 80);
            this.btn_Beers.TabIndex = 3;
            this.btn_Beers.Text = "Beers";
            this.btn_Beers.UseVisualStyleBackColor = false;
            this.btn_Beers.Click += new System.EventHandler(this.btn_Beers_Click);
            // 
            // btn_Wines
            // 
            this.btn_Wines.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_Wines.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Wines.ForeColor = System.Drawing.Color.Gold;
            this.btn_Wines.Location = new System.Drawing.Point(49, 376);
            this.btn_Wines.Name = "btn_Wines";
            this.btn_Wines.Size = new System.Drawing.Size(160, 80);
            this.btn_Wines.TabIndex = 4;
            this.btn_Wines.Text = "Wines";
            this.btn_Wines.UseVisualStyleBackColor = false;
            this.btn_Wines.Click += new System.EventHandler(this.btn_Wines_Click);
            // 
            // Order_MenuSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1024, 769);
            this.Controls.Add(this.pbox_ChapeauLogo);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.btn_Order);
            this.Controls.Add(this.pnl_MenuSelect);
            this.Name = "Order_MenuSelect";
            this.Text = "Order_MenuSelect";
            ((System.ComponentModel.ISupportInitialize)(this.pbox_ChapeauLogo)).EndInit();
            this.pnl_MenuSelect.ResumeLayout(false);
            this.pnl_MenuSelect.PerformLayout();
            this.gbx_Lunch.ResumeLayout(false);
            this.gbx_Drinks.ResumeLayout(false);
            this.gbx_Dinner.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.PictureBox pbox_ChapeauLogo;
        private System.Windows.Forms.Panel pnl_MenuSelect;
        private System.Windows.Forms.Label lbl_MenuSelect;
        private System.Windows.Forms.Button btn_Order;
        private System.Windows.Forms.GroupBox gbx_Lunch;
        private System.Windows.Forms.GroupBox gbx_Dinner;
        private System.Windows.Forms.GroupBox gbx_Drinks;
        private System.Windows.Forms.Button btn_Desserts;
        private System.Windows.Forms.Button btn_Mains;
        private System.Windows.Forms.Button btn_Starters;
        private System.Windows.Forms.Button btn_Wines;
        private System.Windows.Forms.Button btn_Beers;
        private System.Windows.Forms.Button btn_HotDrinks;
        private System.Windows.Forms.Button btn_SoftDrinks;
        private System.Windows.Forms.Button btn_Bites;
        private System.Windows.Forms.Button btn_Specials;
        private System.Windows.Forms.Button btn_LunchMain;
    }
}