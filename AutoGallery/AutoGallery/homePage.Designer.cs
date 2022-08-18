namespace AutoGallery
{
    partial class homePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homePage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customerTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carAddTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentACarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 541);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 45);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(306, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "© 2022 All Rights Reserved, Osman Koyuncu®";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(958, 558);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
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
            this.carAddTransactionsToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.carAddTransactionsToolStripMenuItem.Text = "Car Add";
            this.carAddTransactionsToolStripMenuItem.Click += new System.EventHandler(this.carAddTransactionsToolStripMenuItem_Click);
            // 
            // carStatusToolStripMenuItem
            // 
            this.carStatusToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("carStatusToolStripMenuItem.Image")));
            this.carStatusToolStripMenuItem.Name = "carStatusToolStripMenuItem";
            this.carStatusToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.carStatusToolStripMenuItem.Text = "Car Status";
            this.carStatusToolStripMenuItem.Click += new System.EventHandler(this.carStatusToolStripMenuItem_Click);
            // 
            // rentTransactionsToolStripMenuItem
            // 
            this.rentTransactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rentACarToolStripMenuItem,
            this.toolStripMenuItem1});
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
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(162, 26);
            this.toolStripMenuItem1.Text = "Back Rent A Car";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(958, 28);
            this.menuStrip1.TabIndex = 9;
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
            // homePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 586);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "homePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "homePage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem customerTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentACarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carAddTransactionsToolStripMenuItem;
    }
}