namespace AutoGallery
{
    partial class rentACarPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rentACarPage));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pic_continue = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pic_findPlakaNo = new System.Windows.Forms.PictureBox();
            this.txt_findFree = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_continue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_findPlakaNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pic_continue);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.pic_findPlakaNo);
            this.groupBox4.Controls.Add(this.txt_findFree);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(17, 47);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1128, 390);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Free Car List";
            // 
            // pic_continue
            // 
            this.pic_continue.Image = ((System.Drawing.Image)(resources.GetObject("pic_continue.Image")));
            this.pic_continue.Location = new System.Drawing.Point(969, 319);
            this.pic_continue.Name = "pic_continue";
            this.pic_continue.Size = new System.Drawing.Size(126, 51);
            this.pic_continue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_continue.TabIndex = 29;
            this.pic_continue.TabStop = false;
            this.pic_continue.Click += new System.EventHandler(this.pic_continue_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Plaka Number:";
            // 
            // pic_findPlakaNo
            // 
            this.pic_findPlakaNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pic_findPlakaNo.Image = ((System.Drawing.Image)(resources.GetObject("pic_findPlakaNo.Image")));
            this.pic_findPlakaNo.Location = new System.Drawing.Point(307, 21);
            this.pic_findPlakaNo.Name = "pic_findPlakaNo";
            this.pic_findPlakaNo.Size = new System.Drawing.Size(82, 31);
            this.pic_findPlakaNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_findPlakaNo.TabIndex = 3;
            this.pic_findPlakaNo.TabStop = false;
            this.pic_findPlakaNo.Click += new System.EventHandler(this.pic_findPlakaNo_Click);
            // 
            // txt_findFree
            // 
            this.txt_findFree.Location = new System.Drawing.Point(148, 26);
            this.txt_findFree.Name = "txt_findFree";
            this.txt_findFree.Size = new System.Drawing.Size(153, 22);
            this.txt_findFree.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1058, 228);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            this.menuStrip1.Size = new System.Drawing.Size(1159, 28);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("homeToolStripMenuItem.Image")));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // customerTransactionsToolStripMenuItem
            // 
            this.customerTransactionsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("customerTransactionsToolStripMenuItem.Image")));
            this.customerTransactionsToolStripMenuItem.Name = "customerTransactionsToolStripMenuItem";
            this.customerTransactionsToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
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
            this.carTransactionsToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.carTransactionsToolStripMenuItem.Text = "Car Transactions";
            // 
            // carAddTransactionsToolStripMenuItem
            // 
            this.carAddTransactionsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("carAddTransactionsToolStripMenuItem.Image")));
            this.carAddTransactionsToolStripMenuItem.Name = "carAddTransactionsToolStripMenuItem";
            this.carAddTransactionsToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.carAddTransactionsToolStripMenuItem.Text = "Car Add ";
            this.carAddTransactionsToolStripMenuItem.Click += new System.EventHandler(this.carAddTransactionsToolStripMenuItem_Click);
            // 
            // carStatusToolStripMenuItem
            // 
            this.carStatusToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("carStatusToolStripMenuItem.Image")));
            this.carStatusToolStripMenuItem.Name = "carStatusToolStripMenuItem";
            this.carStatusToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
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
            this.rentTransactionsToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.rentTransactionsToolStripMenuItem.Text = "Rent Transactions";
            // 
            // rentACarToolStripMenuItem
            // 
            this.rentACarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rentACarToolStripMenuItem.Image")));
            this.rentACarToolStripMenuItem.Name = "rentACarToolStripMenuItem";
            this.rentACarToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.rentACarToolStripMenuItem.Text = "Rent A Car";
            this.rentACarToolStripMenuItem.Click += new System.EventHandler(this.rentACarToolStripMenuItem_Click);
            // 
            // removeRentACarToolStripMenuItem
            // 
            this.removeRentACarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removeRentACarToolStripMenuItem.Image")));
            this.removeRentACarToolStripMenuItem.Name = "removeRentACarToolStripMenuItem";
            this.removeRentACarToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.removeRentACarToolStripMenuItem.Text = "Back Rent A Car";
            this.removeRentACarToolStripMenuItem.Click += new System.EventHandler(this.removeRentACarToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportToolStripMenuItem.Image")));
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(389, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(353, 19);
            this.label14.TabIndex = 0;
            this.label14.Text = "© 2022 All Rights Reserved, Osman Koyuncu®";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label14);
            this.panel2.Location = new System.Drawing.Point(12, 475);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1128, 45);
            this.panel2.TabIndex = 28;
            // 
            // rentACarPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 532);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.Name = "rentACarPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rentACarPage";
            this.Load += new System.EventHandler(this.rentACarPage_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_continue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_findPlakaNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pic_findPlakaNo;
        private System.Windows.Forms.TextBox txt_findFree;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customerTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentACarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic_continue;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeRentACarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carAddTransactionsToolStripMenuItem;
    }
}