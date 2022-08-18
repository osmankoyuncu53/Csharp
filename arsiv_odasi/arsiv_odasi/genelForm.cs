using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace arsiv_odasi
{
    public partial class genelForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=arsiv;Integrated Security=True");
        public genelForm()
        {
            InitializeComponent();
        }
        cmbClass cmbClass = new cmbClass();
        genelClass genelClass = new genelClass();

        void temizle()
        {
            cmb_odaAdi.Text = "";
            cmb_bolumAdi.Text = "";
            cmb_rafAdi.Text = "";
            cmb_klasorAdi.Text = "";
            cmb_dosyAdi.Text = "";
            cmb_evrakAdi.Text = "";
        }
        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            genelForm go = new genelForm();
            go.Show();
            this.Hide();
        }

        private void odaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            odaForm go = new odaForm();
            go.Show();
            this.Hide();
        }

        private void bölümToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bolumForm go = new bolumForm();
            go.Show();
            this.Hide();
        }

        private void rafToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rafForm go = new rafForm();
            go.Show();
            this.Hide();
        }

        private void klasörToolStripMenuItem_Click(object sender, EventArgs e)
        {
            klasorForm go = new klasorForm();
            go.Show();
            this.Hide();
        }

        private void dosyaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyaForm go = new dosyaForm();
            go.Show();
            this.Hide();
        }

        private void evrakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            evrakForm go = new evrakForm();
            go.Show();
            this.Hide();
        }

        private void btn_getir_Click(object sender, EventArgs e)
        {
            genelClass.insert("INSERT INTO secim(secim_odaAdi,secim_bolumAdi,secim_rafAdi,secim_klasorAdi,secim_dosyaAdi,secim_evrakAdi) values('"+cmb_odaAdi.Text+"','"+cmb_bolumAdi.Text+"','"+cmb_rafAdi.Text+"','"+cmb_klasorAdi.Text+"','"+cmb_dosyAdi.Text+"','"+cmb_evrakAdi.Text+"')");

            genelClass.select("select * from secim",dataGridView1);

        }

        private void genelForm_Load(object sender, EventArgs e)
        {
            cmbClass.cmb_doldur("SELECT * FROM oda", cmb_odaAdi,"oda_adi");
            cmbClass.cmb_doldur("SELECT * FROM bolum", cmb_bolumAdi,"bolum_adi");
            cmbClass.cmb_doldur("SELECT * FROM raf", cmb_rafAdi,"raf_adi");
            cmbClass.cmb_doldur("SELECT * FROM klasor", cmb_klasorAdi,"klasor_adi");
            cmbClass.cmb_doldur("SELECT * FROM dosya", cmb_dosyAdi,"dosya_adi");
            cmbClass.cmb_doldur("SELECT * FROM evrak", cmb_evrakAdi,"evrak_adi");

            cmb_bolumAdi.Enabled = false;
            cmb_rafAdi.Enabled = false;
            cmb_klasorAdi.Enabled = false;
            cmb_dosyAdi.Enabled = false;
        }
        private void cmb_odaAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbClass.secilenVerininIdBul("select oda_id from oda where oda_adi='" + cmb_odaAdi.Text + "'", lbl_cmbSelectID,"oda_id");

            cmb_bolumAdi.Items.Clear();
            cmb_rafAdi.Items.Clear();
            cmb_klasorAdi.Items.Clear();
            cmb_dosyAdi.Items.Clear();
            cmb_evrakAdi.Items.Clear();

            cmbClass.cmb_doldur("SELECT bolum_adi FROM bolum WHERE oda_id='" + lbl_cmbSelectID.Text + "'", cmb_bolumAdi,"bolum_adi");
            cmb_bolumAdi.Enabled = true;
            if (cmb_bolumAdi.Items.Count==0)
            {
                MessageBox.Show("Girilen Odaya Ait Bölüm Bulunamamaktadır!", "Uyarı");
            }
            
        }

        private void cmb_bolumAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbClass.secilenVerininIdBul("select bolum_id from bolum where bolum_adi='" + cmb_bolumAdi.Text + "'", lbl_cmbSelectID,"bolum_id");

            cmb_rafAdi.Items.Clear();
            cmb_klasorAdi.Items.Clear();
            cmb_dosyAdi.Items.Clear();
            cmb_evrakAdi.Items.Clear();

            cmbClass.cmb_doldur("SELECT raf_adi FROM raf WHERE bolum_id='" + lbl_cmbSelectID.Text + "'", cmb_rafAdi,"raf_adi");
            cmb_rafAdi.Enabled = true;

            if (cmb_bolumAdi.Items.Count == 0)
            {
                MessageBox.Show("Girilen Odaya Ait Raf Bulunamamaktadır!", "Uyarı");
            }
        }

        private void cmb_rafAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbClass.secilenVerininIdBul("select raf_id from raf where raf_adi='" + cmb_rafAdi.Text + "'", lbl_cmbSelectID, "raf_id");

            cmb_klasorAdi.Items.Clear();
            cmb_dosyAdi.Items.Clear();
            cmb_evrakAdi.Items.Clear();


            cmbClass.cmb_doldur("SELECT klasor_adi FROM klasor WHERE raf_id='" + lbl_cmbSelectID.Text + "'", cmb_klasorAdi, "klasor_adi");
            cmb_klasorAdi.Enabled = true;

            if (cmb_bolumAdi.Items.Count == 0)
            {
                MessageBox.Show("Girilen Odaya Ait Raf Bulunamamaktadır!", "Uyarı");
            }

        }
        private void cmb_klasorAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbClass.secilenVerininIdBul("select klasor_id from klasor where klasor_adi='" + cmb_klasorAdi.Text + "'", lbl_cmbSelectID, "klasor_id");

            cmb_dosyAdi.Items.Clear();
            cmb_evrakAdi.Items.Clear();

            cmbClass.cmb_doldur("SELECT dosya_adi FROM dosya WHERE klasor_id='" + lbl_cmbSelectID.Text + "'", cmb_dosyAdi, "dosya_adi");
            cmb_dosyAdi.Enabled = true;

            if (cmb_bolumAdi.Items.Count == 0)
            {
                MessageBox.Show("Girilen Odaya Ait Raf Bulunamamaktadır!", "Uyarı");
            }
        }

        private void cmb_dosyAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbClass.secilenVerininIdBul("select dosya_id from dosya where dosya_adi='" + cmb_dosyAdi.Text + "'", lbl_cmbSelectID, "dosya_id");

            cmb_evrakAdi.Items.Clear();

            cmbClass.cmb_doldur("SELECT evrak_adi FROM evrak WHERE dosya_id='" + lbl_cmbSelectID.Text + "'", cmb_evrakAdi, "evrak_adi");
           

            if (cmb_bolumAdi.Items.Count == 0)
            {
                MessageBox.Show("Girilen Odaya Ait Raf Bulunamamaktadır!", "Uyarı");
            }
        }

        private void cmb_evrakAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbClass.secilenVerininIdBul("select evrak_id from evrak where evrak_adi='" + cmb_evrakAdi.Text + "'", lbl_cmbSelectID, "evrak_id");
            genelClass.select("SELECT * FROM evrak WHERE evrak_id='"+lbl_cmbSelectID.Text+"'",dataGridView1);

        }

        private void btn_doldur_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("select * from evrak INNER JOIN dosya on evrak.dosya_id=dosya.dosya_id INNER JOIN klasor ON klasor.klasor_id=dosya.klasor_id INNER JOIN raf ON raf.raf_id=klasor.raf_id INNER JOIN bolum ON bolum.bolum_id=raf.bolum_id INNER JOIN oda ON bolum.oda_id=oda.oda_id WHERE evrak_id='" + lbl_cmbSelectID.Text + "'", conn);
            SqlDataReader oku = komut.ExecuteReader();

            if (oku.Read())
            {
                cmb_odaAdi.Text = oku["oda_adi"].ToString();
                cmb_bolumAdi.Text = oku["bolum_adi"].ToString();
                cmb_rafAdi.Text = oku["raf_adi"].ToString();
                cmb_klasorAdi.Text = oku["klasor_adi"].ToString();
                cmb_dosyAdi.Text = oku["dosya_adi"].ToString();
                cmb_evrakAdi.Text = oku["evrak_adi"].ToString();
            }

            conn.Close();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void arşiveEklemeSihirbazıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            odaForm go = new odaForm();
            go.btn_next.Visible = true;
            go.Show();
            this.Hide();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void genelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
