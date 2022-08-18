using AutoGallery.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoGallery
{
    public partial class rentACarPage2 : Form
    {
        public rentACarPage2()
        {
            InitializeComponent();
        }
        Context conn = new Context();

        string customer_id;
       
        private void txt_tc_TextChanged(object sender, EventArgs e)
        {
            var query = conn.Customers.SingleOrDefault(p => p.customer_tcNo.Equals(txt_tc.Text));
           
            if (txt_tc.Text.Length == 11)
            {
                customer_id = query.customer_id.ToString();

                txt_name.Text = query.customer_name.ToString();
                txt_surname.Text = query.customer_surname.ToString();
                txt_phone.Text = query.customer_phoneNumber.ToString();
            }
        }
        
        private void btn_kirayaVer_Click(object sender, EventArgs e)
        {
            
            var insert = new RentACar
            {
                rent_purchaseDate = DateTime.Parse(date_purchase.Text),
                rent_deliveryDate = DateTime.Parse(date_delivery.Text),
                rent_totalMoney = float.Parse(txt_total.Text),
                car_id = int.Parse(lbl_carId.Text),
                customer_id = int.Parse(customer_id),
             
            };
            conn.Add(insert);

            if (conn.SaveChanges() == 0)
                MessageBox.Show("Rent A Car Not Added..", "Info!");
            else
            {
                MessageBox.Show("Rent A Car Added.", "Info");


                var update = conn.Cars.Find(int.Parse(lbl_carId.Text));

                update.car_info = "Busy";

                if (conn.SaveChanges() == 0)
                    MessageBox.Show("Car Not Busy..", "Info!");
                else
                {
                    MessageBox.Show("Car Busy..", "Info");
                }
            }
        }

        private void pic_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
