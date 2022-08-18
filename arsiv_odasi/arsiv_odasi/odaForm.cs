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
    public partial class odaForm : Form
    {
        public odaForm()
        {
            InitializeComponent();
        }
        genelClass genelClass = new genelClass();
        private void btn_ekle_Click(object sender, EventArgs e)
        {
          
            if (string.IsNullOrEmpty(txt_odaAdi.Text))
            {
                MessageBox.Show("Boş Alanı Doldur...");
            }
            else
            {
                genelClass.insert("INSERT INTO oda(oda_adi) VALUES('" + txt_odaAdi.Text + "')");
                genelClass.select("SELECT * FROM oda", dataGridView1);
            }
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM oda";

            genelClass.select(query,dataGridView1);
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                genelClass.delete("DELETE FROM oda WHERE oda_id=@id",id);
                genelClass.select("SELECT * FROM oda", dataGridView1);
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_odaAdi.Text))
            {
                MessageBox.Show("Boş Alanı Doldur...");
            }
            else
            {
                string id = label2.Text;

                genelClass.update("UPDATE oda SET oda_adi=@ad WHERE oda_id='" + id + "'", txt_odaAdi.Text);
                genelClass.select("SELECT * FROM oda", dataGridView1);
            }
            
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_odaAdi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            genelForm go = new genelForm();
            go.Show();
            this.Hide();
        }

        private void odaForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (txt_odaAdi.Text == "")
            {
                MessageBox.Show("Devam Etmek İçin Texti Doldurunuz!", "Uyarı!");
            }
            else
            {
                bolumForm go = new bolumForm();
                go.btn_next.Visible = true;
                go.Show();
                this.Hide();
            }
            
        }
    }
}
