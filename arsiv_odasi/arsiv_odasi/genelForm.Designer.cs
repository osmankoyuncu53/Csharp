namespace arsiv_odasi
{
    partial class genelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(genelForm));
            this.cmb_bolumAdi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anasayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arşiveEklemeSihirbazıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evrakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klasörToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rafToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_klasorAdi = new System.Windows.Forms.ComboBox();
            this.cmb_dosyAdi = new System.Windows.Forms.ComboBox();
            this.cmb_evrakAdi = new System.Windows.Forms.ComboBox();
            this.cmb_rafAdi = new System.Windows.Forms.ComboBox();
            this.btn_getir = new System.Windows.Forms.PictureBox();
            this.cmb_odaAdi = new System.Windows.Forms.ComboBox();
            this.lbl_cmbSelectID = new System.Windows.Forms.Label();
            this.btn_doldur = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_getir)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_bolumAdi
            // 
            this.cmb_bolumAdi.FormattingEnabled = true;
            this.cmb_bolumAdi.Location = new System.Drawing.Point(118, 164);
            this.cmb_bolumAdi.Name = "cmb_bolumAdi";
            this.cmb_bolumAdi.Size = new System.Drawing.Size(198, 24);
            this.cmb_bolumAdi.TabIndex = 34;
            this.cmb_bolumAdi.SelectedIndexChanged += new System.EventHandler(this.cmb_bolumAdi_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(10, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Bolum Adı:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 106);
            this.panel1.TabIndex = 24;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anasayfaToolStripMenuItem,
            this.arşiveEklemeSihirbazıToolStripMenuItem,
            this.localEklemeToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 78);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(798, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "Arşive Ekleme Sihirbazı";
            // 
            // anasayfaToolStripMenuItem
            // 
            this.anasayfaToolStripMenuItem.Name = "anasayfaToolStripMenuItem";
            this.anasayfaToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.anasayfaToolStripMenuItem.Text = "Anasayfa";
            this.anasayfaToolStripMenuItem.Click += new System.EventHandler(this.anasayfaToolStripMenuItem_Click);
            // 
            // arşiveEklemeSihirbazıToolStripMenuItem
            // 
            this.arşiveEklemeSihirbazıToolStripMenuItem.Name = "arşiveEklemeSihirbazıToolStripMenuItem";
            this.arşiveEklemeSihirbazıToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.arşiveEklemeSihirbazıToolStripMenuItem.Text = "Arşive Ekleme Sihirbazı";
            this.arşiveEklemeSihirbazıToolStripMenuItem.Click += new System.EventHandler(this.arşiveEklemeSihirbazıToolStripMenuItem_Click);
            // 
            // localEklemeToolStripMenuItem
            // 
            this.localEklemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.evrakToolStripMenuItem,
            this.dosyaToolStripMenuItem,
            this.klasörToolStripMenuItem,
            this.rafToolStripMenuItem,
            this.bölümToolStripMenuItem,
            this.odaToolStripMenuItem});
            this.localEklemeToolStripMenuItem.Name = "localEklemeToolStripMenuItem";
            this.localEklemeToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.localEklemeToolStripMenuItem.Text = "Local Ekleme";
            // 
            // evrakToolStripMenuItem
            // 
            this.evrakToolStripMenuItem.Name = "evrakToolStripMenuItem";
            this.evrakToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.evrakToolStripMenuItem.Text = "Evrak";
            this.evrakToolStripMenuItem.Click += new System.EventHandler(this.evrakToolStripMenuItem_Click);
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            this.dosyaToolStripMenuItem.Click += new System.EventHandler(this.dosyaToolStripMenuItem_Click);
            // 
            // klasörToolStripMenuItem
            // 
            this.klasörToolStripMenuItem.Name = "klasörToolStripMenuItem";
            this.klasörToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.klasörToolStripMenuItem.Text = "Klasör";
            this.klasörToolStripMenuItem.Click += new System.EventHandler(this.klasörToolStripMenuItem_Click);
            // 
            // rafToolStripMenuItem
            // 
            this.rafToolStripMenuItem.Name = "rafToolStripMenuItem";
            this.rafToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.rafToolStripMenuItem.Text = "Raf";
            this.rafToolStripMenuItem.Click += new System.EventHandler(this.rafToolStripMenuItem_Click);
            // 
            // bölümToolStripMenuItem
            // 
            this.bölümToolStripMenuItem.Name = "bölümToolStripMenuItem";
            this.bölümToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.bölümToolStripMenuItem.Text = "Bölüm";
            this.bölümToolStripMenuItem.Click += new System.EventHandler(this.bölümToolStripMenuItem_Click);
            // 
            // odaToolStripMenuItem
            // 
            this.odaToolStripMenuItem.Name = "odaToolStripMenuItem";
            this.odaToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.odaToolStripMenuItem.Text = "Oda ";
            this.odaToolStripMenuItem.Click += new System.EventHandler(this.odaToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(266, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(414, 79);
            this.label1.TabIndex = 2;
            this.label1.Text = "BİLGİLER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(10, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Oda Adı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 345);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(620, 126);
            this.dataGridView1.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(13, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Evrak Adı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(12, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Dosya Adı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(12, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Klasor Adı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(12, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Raf Adı:";
            // 
            // cmb_klasorAdi
            // 
            this.cmb_klasorAdi.FormattingEnabled = true;
            this.cmb_klasorAdi.Location = new System.Drawing.Point(118, 238);
            this.cmb_klasorAdi.Name = "cmb_klasorAdi";
            this.cmb_klasorAdi.Size = new System.Drawing.Size(198, 24);
            this.cmb_klasorAdi.TabIndex = 39;
            this.cmb_klasorAdi.SelectedIndexChanged += new System.EventHandler(this.cmb_klasorAdi_SelectedIndexChanged);
            // 
            // cmb_dosyAdi
            // 
            this.cmb_dosyAdi.FormattingEnabled = true;
            this.cmb_dosyAdi.Location = new System.Drawing.Point(118, 272);
            this.cmb_dosyAdi.Name = "cmb_dosyAdi";
            this.cmb_dosyAdi.Size = new System.Drawing.Size(198, 24);
            this.cmb_dosyAdi.TabIndex = 40;
            this.cmb_dosyAdi.SelectedIndexChanged += new System.EventHandler(this.cmb_dosyAdi_SelectedIndexChanged);
            // 
            // cmb_evrakAdi
            // 
            this.cmb_evrakAdi.FormattingEnabled = true;
            this.cmb_evrakAdi.Location = new System.Drawing.Point(118, 308);
            this.cmb_evrakAdi.Name = "cmb_evrakAdi";
            this.cmb_evrakAdi.Size = new System.Drawing.Size(207, 24);
            this.cmb_evrakAdi.TabIndex = 41;
            this.cmb_evrakAdi.SelectedIndexChanged += new System.EventHandler(this.cmb_evrakAdi_SelectedIndexChanged);
            // 
            // cmb_rafAdi
            // 
            this.cmb_rafAdi.FormattingEnabled = true;
            this.cmb_rafAdi.Location = new System.Drawing.Point(118, 205);
            this.cmb_rafAdi.Name = "cmb_rafAdi";
            this.cmb_rafAdi.Size = new System.Drawing.Size(198, 24);
            this.cmb_rafAdi.TabIndex = 42;
            this.cmb_rafAdi.SelectedIndexChanged += new System.EventHandler(this.cmb_rafAdi_SelectedIndexChanged);
            // 
            // btn_getir
            // 
            this.btn_getir.Image = ((System.Drawing.Image)(resources.GetObject("btn_getir.Image")));
            this.btn_getir.Location = new System.Drawing.Point(331, 299);
            this.btn_getir.Name = "btn_getir";
            this.btn_getir.Size = new System.Drawing.Size(65, 40);
            this.btn_getir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_getir.TabIndex = 43;
            this.btn_getir.TabStop = false;
            this.btn_getir.Click += new System.EventHandler(this.btn_getir_Click);
            // 
            // cmb_odaAdi
            // 
            this.cmb_odaAdi.FormattingEnabled = true;
            this.cmb_odaAdi.Location = new System.Drawing.Point(118, 129);
            this.cmb_odaAdi.Name = "cmb_odaAdi";
            this.cmb_odaAdi.Size = new System.Drawing.Size(198, 24);
            this.cmb_odaAdi.TabIndex = 44;
            this.cmb_odaAdi.SelectedIndexChanged += new System.EventHandler(this.cmb_odaAdi_SelectedIndexChanged);
            // 
            // lbl_cmbSelectID
            // 
            this.lbl_cmbSelectID.AutoSize = true;
            this.lbl_cmbSelectID.Location = new System.Drawing.Point(409, 164);
            this.lbl_cmbSelectID.Name = "lbl_cmbSelectID";
            this.lbl_cmbSelectID.Size = new System.Drawing.Size(46, 17);
            this.lbl_cmbSelectID.TabIndex = 45;
            this.lbl_cmbSelectID.Text = "label3";
            this.lbl_cmbSelectID.Visible = false;
            // 
            // btn_doldur
            // 
            this.btn_doldur.Location = new System.Drawing.Point(412, 308);
            this.btn_doldur.Name = "btn_doldur";
            this.btn_doldur.Size = new System.Drawing.Size(92, 23);
            this.btn_doldur.TabIndex = 46;
            this.btn_doldur.Text = "Doldur";
            this.btn_doldur.UseVisualStyleBackColor = true;
            this.btn_doldur.Click += new System.EventHandler(this.btn_doldur_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(412, 275);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(92, 23);
            this.btn_temizle.TabIndex = 47;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // genelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 500);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_doldur);
            this.Controls.Add(this.lbl_cmbSelectID);
            this.Controls.Add(this.cmb_odaAdi);
            this.Controls.Add(this.btn_getir);
            this.Controls.Add(this.cmb_rafAdi);
            this.Controls.Add(this.cmb_evrakAdi);
            this.Controls.Add(this.cmb_dosyAdi);
            this.Controls.Add(this.cmb_klasorAdi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_bolumAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Name = "genelForm";
            this.Text = "genelForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.genelForm_FormClosing);
            this.Load += new System.EventHandler(this.genelForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_getir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_bolumAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_klasorAdi;
        private System.Windows.Forms.ComboBox cmb_dosyAdi;
        private System.Windows.Forms.ComboBox cmb_evrakAdi;
        private System.Windows.Forms.ComboBox cmb_rafAdi;
        private System.Windows.Forms.PictureBox btn_getir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anasayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arşiveEklemeSihirbazıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evrakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klasörToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rafToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bölümToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmb_odaAdi;
        private System.Windows.Forms.Label lbl_cmbSelectID;
        private System.Windows.Forms.Button btn_doldur;
        private System.Windows.Forms.Button btn_temizle;
    }
}