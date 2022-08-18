using AutoGallery.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoGallery
{
    public partial class carAddPage : Form
    {
        public carAddPage()
        {
            InitializeComponent();
        }

        Context conn = new Context();

        private void pic_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btn_imagesChoose_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string insertImage = "C:/Users/osman/source/repos/AutoGallery/AutoGallery/images";

                    pic_carImages.ImageLocation = openFileDialog1.FileName;

                    string target = Path.Combine(insertImage, Path.GetFileName(openFileDialog1.FileName));
                    File.Copy(openFileDialog1.FileName, target);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception caught: " + ex, "Attention!");
            }
        }
        private void pic_insert_Click(object sender, EventArgs e)
        {
            var insert = new Car
            {
                car_plakaNumber = txt_plakaNo.Text,
                car_brand = txt_brand.Text,
                car_model = txt_model.Text,
                car_year = txt_year.Text,
                car_fuel = cmb_fuel.Text,
                car_gear = cmb_gear.Text,
                car_km = txt_km.Text,
                car_driverLicense = cmb_driverLicense.Text,
                car_traction = cmb_traction.Text,
                car_door = cmb_door.Text,
                car_color = cmb_color.Text,
                car_damage = cmb_damage.Text,
                car_money = txt_money.Text,
                car_image = openFileDialog1.FileName,
                car_info = "Free",
            };
            conn.Add(insert);


            if (conn.SaveChanges() == 0)
                MessageBox.Show("Car Not Added..", "Info!");
            else
            {
                MessageBox.Show("Car Added.", "Info");
            }
        }
        
        
    }
}
