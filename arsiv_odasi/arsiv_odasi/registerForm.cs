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
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=arsiv;Integrated Security=True");
        private void btn_kayitOl_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_kullaniciAd.Text) || string.IsNullOrEmpty(txt_sifre.Text) || string.IsNullOrEmpty(txt_sifreTekrar.Text)|| string.IsNullOrEmpty(txt_mailAdress.Text))
            {
                MessageBox.Show("Boş Alanları Doldurunuz.", "Uyarı");
            }
            else
            {
                if (txt_sifre.Text == txt_sifreTekrar.Text)
                {
                    conn.Open();
                    SqlCommand queryInsert = new SqlCommand("INSERT INTO admin(admin_adi,admin_sifre,admin_mail) VALUES('" + txt_kullaniciAd.Text + "','" + txt_sifre.Text + "','" + txt_mailAdress.Text + "')", conn);
                    queryInsert.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Kayıt Olma Başarılı...", "Uyarı!");
                    loginForm loginForm = new loginForm();
                    loginForm.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Şifreler Uyuşmuyor.", "Uyarı");
                    txt_sifreTekrar.Clear();
                }
            }
        }
    }
}
