using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace arsiv_odasi
{
    
    class genelClass
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=arsiv;Integrated Security=True");

        //insert
        public void insert(string sorgu)
        {
            conn.Open();
            SqlCommand queryInsert = new SqlCommand(sorgu, conn);
            queryInsert.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Ekleme İşlemi Başarılı...", "Uyarı!");
        }

        //select
        public void select(string sorgu, DataGridView dataGridView1)
        {
            conn.Open();
            
            SqlCommand querySelect = new SqlCommand(sorgu, conn);
            SqlDataAdapter adapt = new SqlDataAdapter(querySelect);

            DataSet ds = new DataSet();
            adapt.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            conn.Close();
        }
        //delete
        public void delete(string sorgu,int id)
        {
            conn.Open();
            SqlCommand queryDelete = new SqlCommand(sorgu,conn);
            queryDelete.Parameters.AddWithValue("@id", id);
            queryDelete.ExecuteNonQuery();
            conn.Close();
        }

        //update
        public void update(string sorgu, string ad)
        {
            conn.Open();
            SqlCommand queryUpdate = new SqlCommand(sorgu, conn);
          
            queryUpdate.Parameters.AddWithValue("@ad", ad);
            queryUpdate.ExecuteNonQuery();
            conn.Close();
        }


        //
        







    }
}
