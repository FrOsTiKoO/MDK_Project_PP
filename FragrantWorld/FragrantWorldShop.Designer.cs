namespace FragrantWorld
{
    partial class FragrantWorldShop
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            contextMenuStrip1 = new ContextMenuStrip(components);
            dataGridViewProducts = new DataGridView();
            ProductName = new DataGridViewTextBoxColumn();
            ProductDescription = new DataGridViewTextBoxColumn();
            ProductCost = new DataGridViewTextBoxColumn();
            OrderButton = new DataGridViewButtonColumn();
            menuStrip = new MenuStrip();
            account = new ToolStripMenuItem();
            profile = new ToolStripMenuItem();
            orders = new ToolStripMenuItem();
            personInfo = new ToolStripMenuItem();
            panel_Control = new ToolStripMenuItem();
            logOut = new ToolStripMenuItem();
            cart = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.BackgroundColor = Color.White;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { ProductName, ProductDescription, ProductCost, OrderButton });
            dataGridViewProducts.Dock = DockStyle.Fill;
            dataGridViewProducts.Location = new Point(0, 0);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.Size = new Size(895, 450);
            dataGridViewProducts.TabIndex = 1;
            dataGridViewProducts.CellContentClick += dataGridViewProducts_CellContentClick;
            dataGridViewProducts.CellFormatting += dataGridViewProducts_CellFormatting;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Название";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.Width = 125;
            // 
            // ProductDescription
            // 
            ProductDescription.HeaderText = "Описание";
            ProductDescription.MinimumWidth = 6;
            ProductDescription.Name = "ProductDescription";
            ProductDescription.Width = 125;
            // 
            // ProductCost
            // 
            ProductCost.HeaderText = "Цена";
            ProductCost.MinimumWidth = 6;
            ProductCost.Name = "ProductCost";
            ProductCost.Width = 125;
            // 
            // OrderButton
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.ForeColor = SystemColors.ActiveBorder;
            OrderButton.DefaultCellStyle = dataGridViewCellStyle1;
            OrderButton.HeaderText = "";
            OrderButton.MinimumWidth = 6;
            OrderButton.Name = "OrderButton";
            OrderButton.Text = "Заказать";
            OrderButton.UseColumnTextForButtonValue = true;
            OrderButton.Width = 125;
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.White;
            menuStrip.Dock = DockStyle.Right;
            menuStrip.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { account, cart });
            menuStrip.LayoutStyle = ToolStripLayoutStyle.Flow;
            menuStrip.Location = new Point(727, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.RightToLeft = RightToLeft.Yes;
            menuStrip.Size = new Size(168, 450);
            menuStrip.TabIndex = 4;
            menuStrip.Text = "menuStrip1";
            // 
            // account
            // 
            account.Alignment = ToolStripItemAlignment.Right;
            account.DropDownItems.AddRange(new ToolStripItem[] { profile, panel_Control, logOut });
            account.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            account.Name = "account";
            account.Size = new Size(79, 24);
            account.Text = "Аккаунт";
            // 
            // profile
            // 
            profile.DropDownItems.AddRange(new ToolStripItem[] { orders, personInfo });
            profile.Name = "profile";
            profile.Size = new Size(237, 26);
            profile.Text = "Профиль";
            profile.Click += FragrantWorldShop_Load;
            // 
            // orders
            // 
            orders.Name = "orders";
            orders.Size = new Size(224, 26);
            orders.Text = "Заказы";
            // 
            // personInfo
            // 
            personInfo.Name = "personInfo";
            personInfo.Size = new Size(224, 26);
            personInfo.Text = "Личные Данные";
            // 
            // panel_Control
            // 
            panel_Control.Name = "panel_Control";
            panel_Control.Size = new Size(237, 26);
            panel_Control.Text = "Панель управления";
            panel_Control.Click += panel_Control_Click;
            // 
            // logOut
            // 
            logOut.Name = "logOut";
            logOut.Size = new Size(237, 26);
            logOut.Text = "Выйти";
            logOut.Click += logOut_Click;
            // 
            // cart
            // 
            cart.Alignment = ToolStripItemAlignment.Right;
            cart.Name = "cart";
            cart.Size = new Size(83, 24);
            cart.Text = "Корзина";
            // 
            // FragrantWorldShop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 450);
            Controls.Add(menuStrip);
            Controls.Add(dataGridViewProducts);
            Name = "FragrantWorldShop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FragrandWorldShop";
            FormClosing += FragrantWorldShop_FormClosing;
            Load += FragrantWorldShop_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private DataGridView dataGridViewProducts;
        private MenuStrip menuStrip;
        private ToolStripMenuItem account;
        private ToolStripMenuItem profile;
        private ToolStripMenuItem orders;
        private ToolStripMenuItem personInfo;
        private ToolStripMenuItem panel_Control;
        private ToolStripMenuItem logOut;
        private ToolStripMenuItem cart;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductDescription;
        private DataGridViewTextBoxColumn ProductCost;
        private DataGridViewButtonColumn OrderButton;
    }
}