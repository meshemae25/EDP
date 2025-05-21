namespace Shoe_Collection
{
    partial class frmMain
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.orderitems = new System.Windows.Forms.Panel();
            this.dgvorderitems = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.recentlyactivity = new System.Windows.Forms.Panel();
            this.dgvrecentlyact = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TotalOrders = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalSuppliers = new System.Windows.Forms.Panel();
            this.lblTotalSuppliers = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalShoes = new System.Windows.Forms.Panel();
            this.lblTotalShoes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnorderitems = new System.Windows.Forms.Button();
            this.btnshoeowner = new System.Windows.Forms.Button();
            this.btnshoesupplier = new System.Windows.Forms.Button();
            this.btnorders = new System.Windows.Forms.Button();
            this.btnowner = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnsupplier = new System.Windows.Forms.Button();
            this.btnshoes = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.orderitems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvorderitems)).BeginInit();
            this.recentlyactivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrecentlyact)).BeginInit();
            this.lblTotalSales.SuspendLayout();
            this.TotalOrders.SuspendLayout();
            this.TotalSuppliers.SuspendLayout();
            this.TotalShoes.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 24);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1014, 467);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Lavender;
            this.panel4.Controls.Add(this.orderitems);
            this.panel4.Controls.Add(this.recentlyactivity);
            this.panel4.Controls.Add(this.lblTotalSales);
            this.panel4.Controls.Add(this.TotalOrders);
            this.panel4.Controls.Add(this.TotalSuppliers);
            this.panel4.Controls.Add(this.TotalShoes);
            this.panel4.Location = new System.Drawing.Point(177, 47);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(834, 442);
            this.panel4.TabIndex = 2;
            // 
            // orderitems
            // 
            this.orderitems.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.orderitems.Controls.Add(this.dgvorderitems);
            this.orderitems.Controls.Add(this.label14);
            this.orderitems.Location = new System.Drawing.Point(505, 159);
            this.orderitems.Name = "orderitems";
            this.orderitems.Size = new System.Drawing.Size(302, 249);
            this.orderitems.TabIndex = 5;
            this.orderitems.Paint += new System.Windows.Forms.PaintEventHandler(this.orderitems_Paint);
            // 
            // dgvorderitems
            // 
            this.dgvorderitems.AccessibleName = "orderitems";
            this.dgvorderitems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvorderitems.Location = new System.Drawing.Point(13, 40);
            this.dgvorderitems.Name = "dgvorderitems";
            this.dgvorderitems.Size = new System.Drawing.Size(274, 197);
            this.dgvorderitems.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(10, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 15);
            this.label14.TabIndex = 4;
            this.label14.Text = "Order Items";
            // 
            // recentlyactivity
            // 
            this.recentlyactivity.BackColor = System.Drawing.Color.Lavender;
            this.recentlyactivity.Controls.Add(this.dgvrecentlyact);
            this.recentlyactivity.Controls.Add(this.label9);
            this.recentlyactivity.Location = new System.Drawing.Point(29, 159);
            this.recentlyactivity.Name = "recentlyactivity";
            this.recentlyactivity.Size = new System.Drawing.Size(457, 261);
            this.recentlyactivity.TabIndex = 4;
            this.recentlyactivity.Paint += new System.Windows.Forms.PaintEventHandler(this.recentlyactivity_Paint);
            // 
            // dgvrecentlyact
            // 
            this.dgvrecentlyact.AccessibleName = "dgvrecentlyact";
            this.dgvrecentlyact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrecentlyact.Location = new System.Drawing.Point(16, 40);
            this.dgvrecentlyact.Name = "dgvrecentlyact";
            this.dgvrecentlyact.Size = new System.Drawing.Size(425, 206);
            this.dgvrecentlyact.TabIndex = 3;
            this.dgvrecentlyact.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvrecentlyact_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Recent Activity";
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.BackColor = System.Drawing.Color.DarkOrange;
            this.lblTotalSales.Controls.Add(this.label8);
            this.lblTotalSales.Controls.Add(this.label4);
            this.lblTotalSales.Location = new System.Drawing.Point(626, 36);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(181, 101);
            this.lblTotalSales.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(74, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 28);
            this.label8.TabIndex = 6;
            this.label8.Text = "110";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Sales";
            // 
            // TotalOrders
            // 
            this.TotalOrders.BackColor = System.Drawing.Color.DeepPink;
            this.TotalOrders.Controls.Add(this.label7);
            this.TotalOrders.Controls.Add(this.label3);
            this.TotalOrders.Location = new System.Drawing.Point(427, 36);
            this.TotalOrders.Name = "TotalOrders";
            this.TotalOrders.Size = new System.Drawing.Size(181, 101);
            this.TotalOrders.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(73, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Orders";
            // 
            // TotalSuppliers
            // 
            this.TotalSuppliers.BackColor = System.Drawing.Color.DarkTurquoise;
            this.TotalSuppliers.Controls.Add(this.lblTotalSuppliers);
            this.TotalSuppliers.Controls.Add(this.label2);
            this.TotalSuppliers.Location = new System.Drawing.Point(228, 36);
            this.TotalSuppliers.Name = "TotalSuppliers";
            this.TotalSuppliers.Size = new System.Drawing.Size(181, 101);
            this.TotalSuppliers.TabIndex = 1;
            // 
            // lblTotalSuppliers
            // 
            this.lblTotalSuppliers.AutoSize = true;
            this.lblTotalSuppliers.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSuppliers.ForeColor = System.Drawing.Color.Black;
            this.lblTotalSuppliers.Location = new System.Drawing.Point(76, 46);
            this.lblTotalSuppliers.Name = "lblTotalSuppliers";
            this.lblTotalSuppliers.Size = new System.Drawing.Size(24, 28);
            this.lblTotalSuppliers.TabIndex = 2;
            this.lblTotalSuppliers.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Suppliers";
            // 
            // TotalShoes
            // 
            this.TotalShoes.BackColor = System.Drawing.Color.DodgerBlue;
            this.TotalShoes.Controls.Add(this.lblTotalShoes);
            this.TotalShoes.Controls.Add(this.label1);
            this.TotalShoes.Location = new System.Drawing.Point(29, 36);
            this.TotalShoes.Name = "TotalShoes";
            this.TotalShoes.Size = new System.Drawing.Size(181, 101);
            this.TotalShoes.TabIndex = 0;
            // 
            // lblTotalShoes
            // 
            this.lblTotalShoes.AutoSize = true;
            this.lblTotalShoes.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalShoes.ForeColor = System.Drawing.Color.Black;
            this.lblTotalShoes.Location = new System.Drawing.Point(70, 46);
            this.lblTotalShoes.Name = "lblTotalShoes";
            this.lblTotalShoes.Size = new System.Drawing.Size(36, 28);
            this.lblTotalShoes.TabIndex = 1;
            this.lblTotalShoes.Text = "32";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Shoes";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumPurple;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(172, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(842, 42);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnorderitems);
            this.panel1.Controls.Add(this.btnshoeowner);
            this.panel1.Controls.Add(this.btnshoesupplier);
            this.panel1.Controls.Add(this.btnorders);
            this.panel1.Controls.Add(this.btnowner);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnsupplier);
            this.panel1.Controls.Add(this.btnshoes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 467);
            this.panel1.TabIndex = 0;
            // 
            // btnorderitems
            // 
            this.btnorderitems.BackColor = System.Drawing.Color.MediumPurple;
            this.btnorderitems.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnorderitems.FlatAppearance.BorderSize = 0;
            this.btnorderitems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnorderitems.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorderitems.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnorderitems.Location = new System.Drawing.Point(-2, 376);
            this.btnorderitems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnorderitems.Name = "btnorderitems";
            this.btnorderitems.Size = new System.Drawing.Size(171, 30);
            this.btnorderitems.TabIndex = 4;
            this.btnorderitems.Text = "Order Items";
            this.btnorderitems.UseVisualStyleBackColor = false;
            this.btnorderitems.Click += new System.EventHandler(this.btnorderitems_Click);
            // 
            // btnshoeowner
            // 
            this.btnshoeowner.BackColor = System.Drawing.Color.MediumPurple;
            this.btnshoeowner.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnshoeowner.FlatAppearance.BorderSize = 0;
            this.btnshoeowner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnshoeowner.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshoeowner.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnshoeowner.Location = new System.Drawing.Point(-2, 331);
            this.btnshoeowner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnshoeowner.Name = "btnshoeowner";
            this.btnshoeowner.Size = new System.Drawing.Size(171, 30);
            this.btnshoeowner.TabIndex = 4;
            this.btnshoeowner.Text = "Shoe Owner";
            this.btnshoeowner.UseVisualStyleBackColor = false;
            this.btnshoeowner.Click += new System.EventHandler(this.btnshoeowner_Click);
            // 
            // btnshoesupplier
            // 
            this.btnshoesupplier.BackColor = System.Drawing.Color.MediumPurple;
            this.btnshoesupplier.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnshoesupplier.FlatAppearance.BorderSize = 0;
            this.btnshoesupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnshoesupplier.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshoesupplier.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnshoesupplier.Location = new System.Drawing.Point(-2, 287);
            this.btnshoesupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnshoesupplier.Name = "btnshoesupplier";
            this.btnshoesupplier.Size = new System.Drawing.Size(171, 30);
            this.btnshoesupplier.TabIndex = 4;
            this.btnshoesupplier.Text = "Shoe Supplier";
            this.btnshoesupplier.UseVisualStyleBackColor = false;
            this.btnshoesupplier.Click += new System.EventHandler(this.btnshoesupplier_Click);
            // 
            // btnorders
            // 
            this.btnorders.BackColor = System.Drawing.Color.MediumPurple;
            this.btnorders.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnorders.FlatAppearance.BorderSize = 0;
            this.btnorders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnorders.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorders.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnorders.Location = new System.Drawing.Point(1, 243);
            this.btnorders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnorders.Name = "btnorders";
            this.btnorders.Size = new System.Drawing.Size(171, 30);
            this.btnorders.TabIndex = 3;
            this.btnorders.Text = "Orders";
            this.btnorders.UseVisualStyleBackColor = false;
            this.btnorders.Click += new System.EventHandler(this.btnorders_Click);
            // 
            // btnowner
            // 
            this.btnowner.BackColor = System.Drawing.Color.MediumPurple;
            this.btnowner.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnowner.FlatAppearance.BorderSize = 0;
            this.btnowner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnowner.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnowner.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnowner.Location = new System.Drawing.Point(-1, 199);
            this.btnowner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnowner.Name = "btnowner";
            this.btnowner.Size = new System.Drawing.Size(171, 30);
            this.btnowner.TabIndex = 2;
            this.btnowner.Text = "Owner";
            this.btnowner.UseVisualStyleBackColor = false;
            this.btnowner.Click += new System.EventHandler(this.btnowner_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Shoe_Collection.Properties.Resources.sdaf_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(42, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnsupplier
            // 
            this.btnsupplier.BackColor = System.Drawing.Color.MediumPurple;
            this.btnsupplier.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnsupplier.FlatAppearance.BorderSize = 0;
            this.btnsupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsupplier.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupplier.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnsupplier.Location = new System.Drawing.Point(-2, 152);
            this.btnsupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsupplier.Name = "btnsupplier";
            this.btnsupplier.Size = new System.Drawing.Size(171, 30);
            this.btnsupplier.TabIndex = 1;
            this.btnsupplier.Text = "Suppliers";
            this.btnsupplier.UseVisualStyleBackColor = false;
            this.btnsupplier.Click += new System.EventHandler(this.btnsupplier_Click);
            // 
            // btnshoes
            // 
            this.btnshoes.BackColor = System.Drawing.Color.MediumPurple;
            this.btnshoes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnshoes.FlatAppearance.BorderSize = 0;
            this.btnshoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnshoes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshoes.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnshoes.Location = new System.Drawing.Point(-2, 105);
            this.btnshoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnshoes.Name = "btnshoes";
            this.btnshoes.Size = new System.Drawing.Size(171, 30);
            this.btnshoes.TabIndex = 0;
            this.btnshoes.Text = "Shoes";
            this.btnshoes.UseVisualStyleBackColor = false;
            this.btnshoes.Click += new System.EventHandler(this.btnshoes_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1014, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1014, 491);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.orderitems.ResumeLayout(false);
            this.orderitems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvorderitems)).EndInit();
            this.recentlyactivity.ResumeLayout(false);
            this.recentlyactivity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrecentlyact)).EndInit();
            this.lblTotalSales.ResumeLayout(false);
            this.lblTotalSales.PerformLayout();
            this.TotalOrders.ResumeLayout(false);
            this.TotalOrders.PerformLayout();
            this.TotalSuppliers.ResumeLayout(false);
            this.TotalSuppliers.PerformLayout();
            this.TotalShoes.ResumeLayout(false);
            this.TotalShoes.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnshoes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnorders;
        private System.Windows.Forms.Button btnowner;
        private System.Windows.Forms.Button btnsupplier;
        private System.Windows.Forms.Button btnorderitems;
        private System.Windows.Forms.Button btnshoeowner;
        private System.Windows.Forms.Button btnshoesupplier;
        private System.Windows.Forms.Panel orderitems;
        private System.Windows.Forms.Panel recentlyactivity;
        private System.Windows.Forms.Panel lblTotalSales;
        private System.Windows.Forms.Panel TotalOrders;
        private System.Windows.Forms.Panel TotalSuppliers;
        private System.Windows.Forms.Panel TotalShoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalShoes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalSuppliers;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvorderitems;
        private System.Windows.Forms.DataGridView dgvrecentlyact;
    }
}