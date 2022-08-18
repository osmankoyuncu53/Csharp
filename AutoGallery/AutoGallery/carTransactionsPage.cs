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
    public partial class carTransactionsPage : Form
    {
        public carTransactionsPage()
        {
            InitializeComponent();
        }

        Context conn = new Context();
        string id;
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homePage go = new homePage();
            go.Show();
            this.Hide();
        }

        private void customerTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customerTransactionsPage go = new customerTransactionsPage();
            go.Show();
            this.Hide();
        }

        private void carStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carStatusPage go = new carStatusPage();
            go.Show();
            this.Hide();
        }

        private void rentACarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rentACarPage go = new rentACarPage();
            go.Show();
            this.Hide();
        }

        private void removeRentACarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeRentACarPage go = new removeRentACarPage();
            go.Show();
            this.Hide();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportPage go = new reportPage();
            go.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginPage go = new loginPage();
            go.Show();
            this.Hide();
        }

        private void carAddTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carTransactionsPage go = new carTransactionsPage();
            go.Show();
            this.Hide();
        }
        private void pic_insert_Click(object sender, EventArgs e)
        {
            carAddPage go = new carAddPage();
            go.Show();
        }
        void list()
        {
            dataGridView1.DataSource = conn.Cars.ToList();
        }

        private void carTransactionsPage_Load(object sender, EventArgs e)
        {
            list();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(); // globale id ye id atadım.

                txt_plakaNo.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_brand.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_model.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_year.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmb_fuel.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                cmb_gear.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                txt_km.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                cmb_driverLicense.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                cmb_traction.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                cmb_door.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                cmb_color.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                cmb_damage.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
                txt_money.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
                pic_carImages.ImageLocation = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Exception caught: " + ex, "Attention!");
            }
        }

        private void pic_findButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conn.Cars.Where(p => p.car_plakaNumber.Equals(txt_findPlaka.Text)).ToList();
        }

        private void pic_update_Click(object sender, EventArgs e)
        {
            var update = conn.Cars.Find(int.Parse(id));

            if (openFileDialog1.FileName == "openFileDialog1")
            {
                update.car_plakaNumber = txt_plakaNo.Text;
                update.car_brand = txt_brand.Text;
                update.car_model = txt_model.Text;
                update.car_year = txt_year.Text;
                update.car_fuel = cmb_fuel.Text;
                update.car_gear = cmb_gear.Text;
                update.car_km = txt_km.Text;
                update.car_driverLicense = cmb_driverLicense.Text;
                update.car_traction = cmb_traction.Text;
                update.car_door = cmb_door.Text;
                update.car_color = cmb_color.Text;
                update.car_damage = cmb_damage.Text;
                update.car_money = txt_money.Text;
            }
            else
            {
                update.car_plakaNumber = txt_plakaNo.Text;
                update.car_brand = txt_brand.Text;
                update.car_model = txt_model.Text;
                update.car_year = txt_year.Text;
                update.car_fuel = cmb_fuel.Text;
                update.car_gear = cmb_gear.Text;
                update.car_km = txt_km.Text;
                update.car_driverLicense = cmb_driverLicense.Text;
                update.car_traction = cmb_traction.Text;
                update.car_door = cmb_door.Text;
                update.car_color = cmb_color.Text;
                update.car_damage = cmb_damage.Text;
                update.car_money = txt_money.Text;
                update.car_image = openFileDialog1.FileName;
            }

            if (conn.SaveChanges() == 0)
                MessageBox.Show("Cars Not Update..", "Info!");
            else
            {
                MessageBox.Show("Cars Update.", "Info");
                list();
            }
        }

        private void pic_delete_Click(object sender, EventArgs e)
        {
            var delete = conn.Cars.Find(int.Parse(id));

            conn.Cars.Remove(delete);

            if (conn.SaveChanges() == 0)
                MessageBox.Show("Customer Not Delete..", "Info!");
            else
            {
                MessageBox.Show("Customer Delete.", "Info");
                list();
            }
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

        private void pic_select_Click(object sender, EventArgs e)
        {
            list();
        }
    }
}
