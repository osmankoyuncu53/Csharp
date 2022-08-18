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
    public partial class evrakForm : Form
    {
        public evrakForm()
        {
            InitializeComponent();
        }

        genelClass genelClass = new genelClass();
        cmbClass cmbClass = new cmbClass();

        private void evrakForm_Load(object sender, EventArgs e)
        {
            cmbClass.cmb_doldur("SELECT * FROM dosya", cmb_dosyaAdi,"dosya_adi");
        }

        private void cmb_dosyaAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbClass.secilenVerininIdBul("select dosya_id from dosya where dosya_adi='" + cmb_dosyaAdi.Text + "'", lbl_cmbSelectID,"dosya_id");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_silGuncelleID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_evrakAdi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_konu.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            bool evrakDurum=false;
            if (rad_durumDevam.Checked)
            {
                evrakDurum = true;
            }
            else if(rad_durumBitti.Checked)
            {
                evrakDurum = false;
            }
            else
            {
                MessageBox.Show("Bir Durum Seçiniz...", "Uyarı!");
            }

            if (string.IsNullOrEmpty(txt_evrakAdi.Text) || string.IsNullOrEmpty(cmb_dosyaAdi.Text) || string.IsNullOrEmpty(txt_konu.Text))
            {
                MessageBox.Show("Boş Alanı Doldur...");
            }
            else
            {
                genelClass.insert("INSERT INTO evrak(evrak_adi,dosya_id,evrak_konu,evrak_durumu,evrak_girisTarihi,evrak_duzenlemeTarihi) VALUES('" + txt_evrakAdi.Text + "','" + lbl_cmbSelectID.Text + "','"+txt_konu.Text+"','"+evrakDurum.ToString()+"','"+DateTime.Now.ToString()+"','"+null+"')");
                genelClass.select("SELECT * FROM evrak", dataGridView1);
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            bool evrakDurum = true;
            if (rad_durumDevam.Checked)
            {
                evrakDurum = true;
            }
            else if (rad_durumBitti.Checked)
            {
                evrakDurum = false;
            }
            else
            {
                MessageBox.Show("Bir Durum Seçiniz...", "Uyarı!");
            }

            if (string.IsNullOrEmpty(txt_evrakAdi.Text) || string.IsNullOrEmpty(cmb_dosyaAdi.Text) || string.IsNullOrEmpty(txt_konu.Text))
            {
                MessageBox.Show("Boş Alanı Doldur...");
            }
            else
            {
                string id = lbl_silGuncelleID.Text;

                genelClass.update("UPDATE evrak SET evrak_adi=@ad,dosya_id='" + lbl_cmbSelectID.Text + "',evrak_konu='"+txt_konu.Text+"',evrak_durumu='"+evrakDurum.ToString()+"',evrak_duzenlemeTarihi='"+DateTime.Now.ToString()+"' WHERE evrak_id='" + id + "'", txt_evrakAdi.Text);
                genelClass.select("SELECT * FROM evrak", dataGridView1);
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                genelClass.delete("DELETE FROM evrak WHERE evrak_id=@id", id);

                genelClass.select("SELECT * FROM evrak", dataGridView1);
            }
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            genelClass.select("SELECT * FROM evrak", dataGridView1);
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            genelForm go = new genelForm();
            go.Show();
            this.Hide();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (txt_evrakAdi.Text == "" && cmb_dosyaAdi.Text == "" && txt_konu.Text=="")
            {
                MessageBox.Show("Devam Etmek İçin Texti Doldurunuz!", "Uyarı!");
            }
            else
            {
                genelForm go = new genelForm();
                go.Show();
                this.Hide();
            }
            
        }
    }
}
