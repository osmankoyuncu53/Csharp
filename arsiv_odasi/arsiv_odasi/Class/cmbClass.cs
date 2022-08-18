using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace arsiv_odasi
{
    class cmbClass
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=arsiv;Integrated Security=True");
        //cmb veriCek

        // comboboxların içini doldurur
        public void cmb_doldur(string query_cmbDoldur, ComboBox cmb_odaID, string alanAdi)
        {
            conn.Open();

            SqlCommand query_cmbList = new SqlCommand(query_cmbDoldur, conn);
            SqlDataReader dr = query_cmbList.ExecuteReader();

            while (dr.Read())
            {
                cmb_odaID.Items.Add(dr[alanAdi]);
            }

            conn.Close();
        }

        // combobox seçilen itemin id sini alır
        public void secilenVerininIdBul(string query_cmbDoldur, Label lbl_id, string alanId)
        {
            conn.Open();

            SqlCommand query_cmbList = new SqlCommand(query_cmbDoldur, conn);

            SqlDataReader dr = query_cmbList.ExecuteReader();

            while (dr.Read())
            {
                lbl_id.Text = dr[alanId].ToString();
            }

            conn.Close();
        }

    }
}
