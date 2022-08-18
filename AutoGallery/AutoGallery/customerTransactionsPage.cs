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
    public partial class customerTransactionsPage : Form
    {
        public customerTransactionsPage()
        {
            InitializeComponent();
        }

        string id;
        Context conn = new Context();

        private void customerTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customerTransactionsPage go = new customerTransactionsPage();
            go.Show();
            this.Hide();
        }


        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homePage go = new homePage();
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

        
        private void btn_imagesChoose_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string insertImage = "C:/Users/osman/source/repos/AutoGallery/AutoGallery/images";

                    pic_customerImages.ImageLocation = openFileDialog1.FileName;

                    string target = Path.Combine(insertImage, Path.GetFileName(openFileDialog1.FileName));
                    File.Copy(openFileDialog1.FileName, target);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception caught: " + ex, "Attention!");
            }
        }

        private void customerTransactionsPage_Load(object sender, EventArgs e)
        {
            list();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id=dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(); // globale id ye id atadım.

            txt_tcNo.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_name.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_surname.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_dateOfBirth.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_job.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_phoneNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_mail.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txt_adress.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            txt_driverLicenseNo.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            txt_licenseType.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            txt_note.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            pic_customerImages.ImageLocation = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
        }

        private void pic_select_Click(object sender, EventArgs e)
        {
            list();
        }

        private void pic_find_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conn.Customers.Where(p => p.customer_tcNo.Equals(txt_findTcNo.Text)).ToList();
        }

        private void pic_insert_Click(object sender, EventArgs e)
        {
            var insert = new Customer
            {
                customer_tcNo = txt_tcNo.Text,
                customer_name = txt_name.Text,
                customer_surname = txt_surname.Text,
                customer_dateOfBirth = txt_dateOfBirth.Text,
                customer_job = txt_job.Text,
                customer_phoneNumber = txt_phoneNumber.Text,
                customer_email = txt_mail.Text,
                customer_adress = txt_adress.Text,
                customer_driverLicense = txt_driverLicenseNo.Text,
                customer_licenseType = txt_licenseType.Text,
                customer_note = txt_note.Text,
                customer_image = openFileDialog1.FileName,
            };
            conn.Add(insert);


            if (conn.SaveChanges() == 0)
                MessageBox.Show("Customer Not Added..", "Info!");
            else
            {
                MessageBox.Show("Customer Added.", "Info");
                list();
            }
        }
        private void pic_update_Click(object sender, EventArgs e)
        {
            var update = conn.Customers.Find(int.Parse(id));

            if (openFileDialog1.FileName == "openFileDialog1")
            {
                update.customer_tcNo = txt_tcNo.Text;
                update.customer_name = txt_name.Text;
                update.customer_surname = txt_surname.Text;
                update.customer_dateOfBirth = txt_dateOfBirth.Text;
                update.customer_job = txt_job.Text;
                update.customer_phoneNumber = txt_phoneNumber.Text;
                update.customer_email = txt_mail.Text;
                update.customer_adress = txt_adress.Text;
                update.customer_driverLicense = txt_driverLicenseNo.Text;
                update.customer_licenseType = txt_licenseType.Text;
                update.customer_note = txt_note.Text;
            }
            else
            {
                update.customer_tcNo = txt_tcNo.Text;
                update.customer_name = txt_name.Text;
                update.customer_surname = txt_surname.Text;
                update.customer_dateOfBirth = txt_dateOfBirth.Text;
                update.customer_job = txt_job.Text;
                update.customer_phoneNumber = txt_phoneNumber.Text;
                update.customer_email = txt_mail.Text;
                update.customer_adress = txt_adress.Text;
                update.customer_driverLicense = txt_driverLicenseNo.Text;
                update.customer_licenseType = txt_licenseType.Text;
                update.customer_note = txt_note.Text;
                update.customer_image = openFileDialog1.FileName;
            }

            if (conn.SaveChanges() == 0)
                MessageBox.Show("Customer Not Update..", "Info!");
            else
            {
                MessageBox.Show("Customer Update.", "Info");
                list();
            }  
        }

        private void pic_drop_Click(object sender, EventArgs e)
        {
            var delete = conn.Customers.Find(int.Parse(id));

            conn.Customers.Remove(delete);

            if (conn.SaveChanges() == 0)
                MessageBox.Show("Customer Not Delete..", "Info!");
            else
            {
                MessageBox.Show("Customer Delete.", "Info");
                list();
            }
                
        }
        public void list()
        {
            dataGridView1.DataSource = conn.Customers.ToList();
        }
    }
}
