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
    public partial class dosyaForm : Form
    {
        public dosyaForm()
        {
            InitializeComponent();
        }

        genelClass genelClass = new genelClass();
        cmbClass cmbClass = new cmbClass();

        private void dosyaForm_Load(object sender, EventArgs e)
        {
            cmbClass.cmb_doldur("SELECT * FROM klasor", cmb_klasorAdi,"klasor_adi");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_silGuncelleID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_dosyaAdi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void cmb_klasorAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbClass.secilenVerininIdBul("select klasor_id from klasor where klasor_adi='" + cmb_klasorAdi.Text + "'", lbl_cmbSelectID,"klasor_id");
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_dosyaAdi.Text) || string.IsNullOrEmpty(cmb_klasorAdi.Text))
            {
                MessageBox.Show("Boş Alanı Doldur...");
            }
            else
            {
                genelClass.insert("INSERT INTO dosya(dosya_adi,klasor_id) VALUES('" + txt_dosyaAdi.Text + "','" + lbl_cmbSelectID.Text + "')");
                genelClass.select("SELECT * FROM dosya", dataGridView1);
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_dosyaAdi.Text))
            {
                MessageBox.Show("Boş Alanı Doldur...");
            }
            else
            {
                string id = lbl_silGuncelleID.Text;

                genelClass.update("UPDATE dosya SET dosya_adi=@ad,klasor_id='" + lbl_cmbSelectID.Text + "' WHERE dosya_id='" + id + "'", txt_dosyaAdi.Text);
                genelClass.select("SELECT * FROM dosya", dataGridView1);
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                genelClass.delete("DELETE FROM dosya WHERE dosya_id=@id", id);

                genelClass.select("SELECT * FROM dosya", dataGridView1);
            }
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            genelClass.select("SELECT * FROM dosya", dataGridView1);
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            genelForm go = new genelForm();
            go.Show();
            this.Hide();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (txt_dosyaAdi.Text == "" && cmb_klasorAdi.Text == "")
            {
                MessageBox.Show("Devam Etmek İçin Texti Doldurunuz!", "Uyarı!");
            }
            else
            {
                evrakForm go = new evrakForm();
                go.btn_next.Visible = true;
                go.Show();
                this.Hide();
            }
        }
    }
}
