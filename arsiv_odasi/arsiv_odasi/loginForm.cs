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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=arsiv;Integrated Security=True");

        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand queryKontrol = new SqlCommand("SELECT * FROM admin WHERE admin_adi='"+txt_kullaniciAd.Text+"' and admin_sifre='"+txt_sifre.Text+"'", conn);
            SqlDataReader dr = queryKontrol.ExecuteReader();
            if (dr.Read())
            {
                genelForm genelForm = new genelForm();
                genelForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Girilen Bİlgiler Hatalı...","Uyarı!");
            }
            
            conn.Close();

        }

        private void link_sifreUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            conn.Open();
            SqlCommand querySifre = new SqlCommand("SELECT * FROM admin WHERE admin_adi='" + txt_kullaniciAd.Text + "'",conn);
            SqlDataReader dr = querySifre.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show(dr["admin_sifre"].ToString(),"Şifreniz!");
            }
            conn.Close();
        }
    }
}
