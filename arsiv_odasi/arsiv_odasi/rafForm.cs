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
    public partial class rafForm : Form
    {
        public rafForm()
        {
            InitializeComponent();
        }
        genelClass genelClass = new genelClass();
        cmbClass cmbClass = new cmbClass();

        private void rafForm_Load(object sender, EventArgs e)
        {
            cmbClass.cmb_doldur("SELECT * FROM bolum", cmb_bolumAdi,"bolum_adi");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_silGuncelleID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_rafAdi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void cmb_bolumAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbClass.secilenVerininIdBul("select bolum_id from bolum where bolum_adi='" + cmb_bolumAdi.Text + "'", lbl_cmbSelectID,"bolum_id");
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_rafAdi.Text) || string.IsNullOrEmpty(cmb_bolumAdi.Text))
            {
                MessageBox.Show("Boş Alanı Doldur...");
            }
            else
            {
                genelClass.insert("INSERT INTO raf(raf_adi,bolum_id) VALUES('" + txt_rafAdi.Text + "','" + lbl_cmbSelectID.Text + "')");
                genelClass.select("SELECT * FROM raf", dataGridView1);
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_rafAdi.Text))
            {
                MessageBox.Show("Boş Alanı Doldur...");
            }
            else
            {
                string id = lbl_silGuncelleID.Text;

                genelClass.update("UPDATE raf SET raf_adi=@ad,bolum_id='" + lbl_cmbSelectID.Text + "' WHERE raf_id='" + id + "'", txt_rafAdi.Text);
                genelClass.select("SELECT * FROM raf", dataGridView1);
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                genelClass.delete("DELETE FROM raf WHERE raf_id=@id", id);

                genelClass.select("SELECT * FROM raf", dataGridView1);
            }
        }

        private void ben_listele_Click(object sender, EventArgs e)
        {
            genelClass.select("SELECT * FROM raf", dataGridView1);
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            genelForm go = new genelForm();
            go.Show();
            this.Hide();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (txt_rafAdi.Text == "" && cmb_bolumAdi.Text == "")
            {
                MessageBox.Show("Devam Etmek İçin Texti Doldurunuz!", "Uyarı!");
            }
            else
            {
                klasorForm go = new klasorForm();
                go.btn_next.Visible = true;
                go.Show();
                this.Hide();
            }
            
        }
    }
}
