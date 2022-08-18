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
    public partial class removeRentACarPage : Form
    {
        public removeRentACarPage()
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

        private void removeRentACarPage_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conn.Cars.Where(p => p.car_info == "Busy").ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void pic_select_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conn.Cars.Where(p => p.car_info == "Busy").ToList();
        }

        private void pic_find_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conn.Cars.Where(p => p.car_plakaNumber.Equals(txt_find.Text) && p.car_info.Equals("Busy")).ToList();
        }

        private void pic_update_Click(object sender, EventArgs e)
        {
            var update = conn.Cars.Find(int.Parse(id));

            update.car_info = "Free";

            if (conn.SaveChanges() == 0)
                MessageBox.Show("Car Not Free..", "Info!");
            else
            {
                MessageBox.Show("Car Free..", "Info");
                dataGridView1.DataSource = conn.Cars.Where(p => p.car_plakaNumber.Equals(txt_find.Text) && p.car_info.Equals("Busy")).ToList();
            }
        }
    }
}
