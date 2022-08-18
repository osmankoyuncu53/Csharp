namespace arsiv_odasi
{
    partial class evrakForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(evrakForm));
            this.cmb_dosyaAdi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_sil = new System.Windows.Forms.PictureBox();
            this.btn_guncelle = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ekle = new System.Windows.Forms.PictureBox();
            this.txt_evrakAdi = new System.Windows.Forms.TextBox();
            this.btn_listele = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_konu = new System.Windows.Forms.TextBox();
            this.rad_durumDevam = new System.Windows.Forms.RadioButton();
            this.rad_durumBitti = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_silGuncelleID = new System.Windows.Forms.Label();
            this.lbl_cmbSelectID = new System.Windows.Forms.Label();
            this.btn_geri = new System.Windows.Forms.PictureBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_guncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ekle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_listele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_geri)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_dosyaAdi
            // 
            this.cmb_dosyaAdi.FormattingEnabled = true;
            this.cmb_dosyaAdi.Location = new System.Drawing.Point(164, 175);
            this.cmb_dosyaAdi.Name = "cmb_dosyaAdi";
            this.cmb_dosyaAdi.Size = new System.Drawing.Size(121, 24);
            this.cmb_dosyaAdi.TabIndex = 78;
            this.cmb_dosyaAdi.SelectedIndexChanged += new System.EventHandler(this.cmb_dosyaAdi_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(11, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 79;
            this.label7.Text = "Dosya Adı:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 82);
            this.panel1.TabIndex = 69;
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
            this.label1.Text = "EVRAK AYARLARI";
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
            // btn_sil
            // 
            this.btn_sil.Image = ((System.Drawing.Image)(resources.GetObject("btn_sil.Image")));
            this.btn_sil.Location = new System.Drawing.Point(567, 256);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(69, 33);
            this.btn_sil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_sil.TabIndex = 74;
            this.btn_sil.TabStop = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Image = ((System.Drawing.Image)(resources.GetObject("btn_guncelle.Image")));
            this.btn_guncelle.Location = new System.Drawing.Point(567, 217);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(69, 33);
            this.btn_guncelle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_guncelle.TabIndex = 73;
            this.btn_guncelle.TabStop = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(564, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 71;
            this.label3.Text = "ISLEMLER";
            // 
            // btn_ekle
            // 
            this.btn_ekle.Image = ((System.Drawing.Image)(resources.GetObject("btn_ekle.Image")));
            this.btn_ekle.Location = new System.Drawing.Point(567, 178);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(69, 33);
            this.btn_ekle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_ekle.TabIndex = 70;
            this.btn_ekle.TabStop = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // txt_evrakAdi
            // 
            this.txt_evrakAdi.Location = new System.Drawing.Point(164, 135);
            this.txt_evrakAdi.Name = "txt_evrakAdi";
            this.txt_evrakAdi.Size = new System.Drawing.Size(141, 22);
            this.txt_evrakAdi.TabIndex = 77;
            // 
            // btn_listele
            // 
            this.btn_listele.Image = ((System.Drawing.Image)(resources.GetObject("btn_listele.Image")));
            this.btn_listele.Location = new System.Drawing.Point(567, 295);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(69, 33);
            this.btn_listele.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_listele.TabIndex = 75;
            this.btn_listele.TabStop = false;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 80;
            this.label2.Text = "Evrak Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(11, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 82;
            this.label5.Text = "Evrak Durumu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(11, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 83;
            this.label6.Text = "Konu:";
            // 
            // txt_konu
            // 
            this.txt_konu.Location = new System.Drawing.Point(164, 214);
            this.txt_konu.Name = "txt_konu";
            this.txt_konu.Size = new System.Drawing.Size(141, 22);
            this.txt_konu.TabIndex = 87;
            // 
            // rad_durumDevam
            // 
            this.rad_durumDevam.Location = new System.Drawing.Point(164, 254);
            this.rad_durumDevam.Name = "rad_durumDevam";
            this.rad_durumDevam.Size = new System.Drawing.Size(121, 19);
            this.rad_durumDevam.TabIndex = 88;
            this.rad_durumDevam.TabStop = true;
            this.rad_durumDevam.Text = "Devam Ediyor";
            this.rad_durumDevam.UseVisualStyleBackColor = true;
            // 
            // rad_durumBitti
            // 
            this.rad_durumBitti.Location = new System.Drawing.Point(291, 254);
            this.rad_durumBitti.Name = "rad_durumBitti";
            this.rad_durumBitti.Size = new System.Drawing.Size(93, 19);
            this.rad_durumBitti.TabIndex = 89;
            this.rad_durumBitti.TabStop = true;
            this.rad_durumBitti.Text = "Bitti";
            this.rad_durumBitti.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 334);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(627, 169);
            this.dataGridView1.TabIndex = 95;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lbl_silGuncelleID
            // 
            this.lbl_silGuncelleID.AutoSize = true;
            this.lbl_silGuncelleID.Location = new System.Drawing.Point(415, 147);
            this.lbl_silGuncelleID.Name = "lbl_silGuncelleID";
            this.lbl_silGuncelleID.Size = new System.Drawing.Size(46, 17);
            this.lbl_silGuncelleID.TabIndex = 96;
            this.lbl_silGuncelleID.Text = "label8";
            this.lbl_silGuncelleID.Visible = false;
            // 
            // lbl_cmbSelectID
            // 
            this.lbl_cmbSelectID.AutoSize = true;
            this.lbl_cmbSelectID.Location = new System.Drawing.Point(415, 194);
            this.lbl_cmbSelectID.Name = "lbl_cmbSelectID";
            this.lbl_cmbSelectID.Size = new System.Drawing.Size(46, 17);
            this.lbl_cmbSelectID.TabIndex = 97;
            this.lbl_cmbSelectID.Text = "label9";
            this.lbl_cmbSelectID.Visible = false;
            // 
            // btn_geri
            // 
            this.btn_geri.Image = ((System.Drawing.Image)(resources.GetObject("btn_geri.Image")));
            this.btn_geri.Location = new System.Drawing.Point(-38, 90);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(120, 32);
            this.btn_geri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_geri.TabIndex = 98;
            this.btn_geri.TabStop = false;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(261, 295);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 101;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Visible = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // evrakForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 515);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.lbl_cmbSelectID);
            this.Controls.Add(this.lbl_silGuncelleID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rad_durumBitti);
            this.Controls.Add(this.rad_durumDevam);
            this.Controls.Add(this.txt_konu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_dosyaAdi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_evrakAdi);
            this.Controls.Add(this.btn_listele);
            this.Name = "evrakForm";
            this.Text = "evrakForm";
            this.Load += new System.EventHandler(this.evrakForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_guncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ekle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_listele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_geri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_dosyaAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btn_sil;
        private System.Windows.Forms.PictureBox btn_guncelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btn_ekle;
        private System.Windows.Forms.TextBox txt_evrakAdi;
        private System.Windows.Forms.PictureBox btn_listele;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_konu;
        private System.Windows.Forms.RadioButton rad_durumDevam;
        private System.Windows.Forms.RadioButton rad_durumBitti;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_silGuncelleID;
        private System.Windows.Forms.Label lbl_cmbSelectID;
        private System.Windows.Forms.PictureBox btn_geri;
        public System.Windows.Forms.Button btn_next;
    }
}