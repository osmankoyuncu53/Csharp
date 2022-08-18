namespace AutoGallery
{
    partial class carStatusPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(carStatusPage));
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pic_findAll = new System.Windows.Forms.PictureBox();
            this.txt_findAll = new System.Windows.Forms.TextBox();
            this.dataGridAll = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carAddTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentACarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeRentACarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_findFree = new System.Windows.Forms.PictureBox();
            this.txt_findFree = new System.Windows.Forms.TextBox();
            this.dataGridFree = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_findBusy = new System.Windows.Forms.PictureBox();
            this.txt_findBusy = new System.Windows.Forms.TextBox();
            this.dataGridBusy = new System.Windows.Forms.DataGridView();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_findAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAll)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_findFree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFree)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_findBusy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBusy)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "Plaka Number:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.pic_findAll);
            this.groupBox4.Controls.Add(this.txt_findAll);
            this.groupBox4.Controls.Add(this.dataGridAll);
            this.groupBox4.Location = new System.Drawing.Point(22, 46);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1413, 313);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "All Car List";
            // 
            // pic_findAll
            // 
            this.pic_findAll.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pic_findAll.Image = ((System.Drawing.Image)(resources.GetObject("pic_findAll.Image")));
            this.pic_findAll.Location = new System.Drawing.Point(307, 21);
            this.pic_findAll.Name = "pic_findAll";
            this.pic_findAll.Size = new System.Drawing.Size(82, 31);
            this.pic_findAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_findAll.TabIndex = 3;
            this.pic_findAll.TabStop = false;
            this.pic_findAll.Click += new System.EventHandler(this.pic_findAll_Click);
            // 
            // txt_findAll
            // 
            this.txt_findAll.Location = new System.Drawing.Point(148, 26);
            this.txt_findAll.Name = "txt_findAll";
            this.txt_findAll.Size = new System.Drawing.Size(153, 22);
            this.txt_findAll.TabIndex = 2;
            // 
            // dataGridAll
            // 
            this.dataGridAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAll.Location = new System.Drawing.Point(37, 64);
            this.dataGridAll.Name = "dataGridAll";
            this.dataGridAll.RowHeadersWidth = 51;
            this.dataGridAll.RowTemplate.Height = 24;
            this.dataGridAll.Size = new System.Drawing.Size(1370, 228);
            this.dataGridAll.TabIndex = 1;
            this.dataGridAll.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAll_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.customerTransactionsToolStripMenuItem,
            this.carTransactionsToolStripMenuItem,
            this.rentTransactionsToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1458, 28);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("homeToolStripMenuItem.Image")));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // customerTransactionsToolStripMenuItem
            // 
            this.customerTransactionsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("customerTransactionsToolStripMenuItem.Image")));
            this.customerTransactionsToolStripMenuItem.Name = "customerTransactionsToolStripMenuItem";
            this.customerTransactionsToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.customerTransactionsToolStripMenuItem.Text = "Customer Transactions";
            this.customerTransactionsToolStripMenuItem.Click += new System.EventHandler(this.customerTransactionsToolStripMenuItem_Click);
            // 
            // carTransactionsToolStripMenuItem
            // 
            this.carTransactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carAddTransactionsToolStripMenuItem,
            this.carStatusToolStripMenuItem});
            this.carTransactionsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("carTransactionsToolStripMenuItem.Image")));
            this.carTransactionsToolStripMenuItem.Name = "carTransactionsToolStripMenuItem";
            this.carTransactionsToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.carTransactionsToolStripMenuItem.Text = "Car Transactions";
            // 
            // carAddTransactionsToolStripMenuItem
            // 
            this.carAddTransactionsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("carAddTransactionsToolStripMenuItem.Image")));
            this.carAddTransactionsToolStripMenuItem.Name = "carAddTransactionsToolStripMenuItem";
            this.carAddTransactionsToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.carAddTransactionsToolStripMenuItem.Text = "Car Add";
            this.carAddTransactionsToolStripMenuItem.Click += new System.EventHandler(this.carAddTransactionsToolStripMenuItem_Click);
            // 
            // carStatusToolStripMenuItem
            // 
            this.carStatusToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("carStatusToolStripMenuItem.Image")));
            this.carStatusToolStripMenuItem.Name = "carStatusToolStripMenuItem";
            this.carStatusToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.carStatusToolStripMenuItem.Text = "Car Status";
            this.carStatusToolStripMenuItem.Click += new System.EventHandler(this.carStatusToolStripMenuItem_Click);
            // 
            // rentTransactionsToolStripMenuItem
            // 
            this.rentTransactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rentACarToolStripMenuItem,
            this.removeRentACarToolStripMenuItem});
            this.rentTransactionsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rentTransactionsToolStripMenuItem.Image")));
            this.rentTransactionsToolStripMenuItem.Name = "rentTransactionsToolStripMenuItem";
            this.rentTransactionsToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.rentTransactionsToolStripMenuItem.Text = "Rent Transactions";
            // 
            // rentACarToolStripMenuItem
            // 
            this.rentACarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rentACarToolStripMenuItem.Image")));
            this.rentACarToolStripMenuItem.Name = "rentACarToolStripMenuItem";
            this.rentACarToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.rentACarToolStripMenuItem.Text = "Rent A Car";
            this.rentACarToolStripMenuItem.Click += new System.EventHandler(this.rentACarToolStripMenuItem_Click);
            // 
            // removeRentACarToolStripMenuItem
            // 
            this.removeRentACarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removeRentACarToolStripMenuItem.Image")));
            this.removeRentACarToolStripMenuItem.Name = "removeRentACarToolStripMenuItem";
            this.removeRentACarToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.removeRentACarToolStripMenuItem.Text = "Back Rent A Car";
            this.removeRentACarToolStripMenuItem.Click += new System.EventHandler(this.removeRentACarToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportToolStripMenuItem.Image")));
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label14);
            this.panel2.Location = new System.Drawing.Point(0, 724);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1458, 45);
            this.panel2.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(530, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(296, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "© 2022 All Rights Reserved, Osman Koyuncu®";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pic_findFree);
            this.groupBox1.Controls.Add(this.txt_findFree);
            this.groupBox1.Controls.Add(this.dataGridFree);
            this.groupBox1.Location = new System.Drawing.Point(22, 378);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 313);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Free Car List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Plaka Number:";
            // 
            // pic_findFree
            // 
            this.pic_findFree.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pic_findFree.Image = ((System.Drawing.Image)(resources.GetObject("pic_findFree.Image")));
            this.pic_findFree.Location = new System.Drawing.Point(307, 21);
            this.pic_findFree.Name = "pic_findFree";
            this.pic_findFree.Size = new System.Drawing.Size(82, 31);
            this.pic_findFree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_findFree.TabIndex = 3;
            this.pic_findFree.TabStop = false;
            this.pic_findFree.Click += new System.EventHandler(this.pic_findFree_Click);
            // 
            // txt_findFree
            // 
            this.txt_findFree.Location = new System.Drawing.Point(148, 26);
            this.txt_findFree.Name = "txt_findFree";
            this.txt_findFree.Size = new System.Drawing.Size(153, 22);
            this.txt_findFree.TabIndex = 2;
            // 
            // dataGridFree
            // 
            this.dataGridFree.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFree.Location = new System.Drawing.Point(37, 64);
            this.dataGridFree.Name = "dataGridFree";
            this.dataGridFree.RowHeadersWidth = 51;
            this.dataGridFree.RowTemplate.Height = 24;
            this.dataGridFree.Size = new System.Drawing.Size(654, 228);
            this.dataGridFree.TabIndex = 1;
            this.dataGridFree.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFree_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.pic_findBusy);
            this.groupBox2.Controls.Add(this.txt_findBusy);
            this.groupBox2.Controls.Add(this.dataGridBusy);
            this.groupBox2.Location = new System.Drawing.Point(744, 378);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(691, 313);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busy Car List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Plaka Number:";
            // 
            // pic_findBusy
            // 
            this.pic_findBusy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pic_findBusy.Image = ((System.Drawing.Image)(resources.GetObject("pic_findBusy.Image")));
            this.pic_findBusy.Location = new System.Drawing.Point(307, 21);
            this.pic_findBusy.Name = "pic_findBusy";
            this.pic_findBusy.Size = new System.Drawing.Size(82, 31);
            this.pic_findBusy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_findBusy.TabIndex = 3;
            this.pic_findBusy.TabStop = false;
            this.pic_findBusy.Click += new System.EventHandler(this.pic_findBusy_Click);
            // 
            // txt_findBusy
            // 
            this.txt_findBusy.Location = new System.Drawing.Point(148, 26);
            this.txt_findBusy.Name = "txt_findBusy";
            this.txt_findBusy.Size = new System.Drawing.Size(153, 22);
            this.txt_findBusy.TabIndex = 2;
            // 
            // dataGridBusy
            // 
            this.dataGridBusy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBusy.Location = new System.Drawing.Point(37, 64);
            this.dataGridBusy.Name = "dataGridBusy";
            this.dataGridBusy.RowHeadersWidth = 51;
            this.dataGridBusy.RowTemplate.Height = 24;
            this.dataGridBusy.Size = new System.Drawing.Size(654, 228);
            this.dataGridBusy.TabIndex = 1;
            this.dataGridBusy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBusy_CellClick);
            // 
            // carStatusPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1458, 786);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.menuStrip1);
            this.Name = "carStatusPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "carStatusPage";
            this.Load += new System.EventHandler(this.carStatusPage_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_findAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAll)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_findFree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFree)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_findBusy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBusy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pic_findAll;
        private System.Windows.Forms.TextBox txt_findAll;
        private System.Windows.Forms.DataGridView dataGridAll;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customerTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentACarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_findFree;
        private System.Windows.Forms.TextBox txt_findFree;
        private System.Windows.Forms.DataGridView dataGridFree;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pic_findBusy;
        private System.Windows.Forms.TextBox txt_findBusy;
        private System.Windows.Forms.DataGridView dataGridBusy;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeRentACarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carAddTransactionsToolStripMenuItem;
    }
}