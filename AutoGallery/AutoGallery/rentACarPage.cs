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
    public partial class rentACarPage : Form
    {
        public rentACarPage()
        {
            InitializeComponent();
        }

        Context conn = new Context();
        string id;
        private void pic_continue_Click(object sender, EventArgs e)
        {
            rentACarPage2 go = new rentACarPage2();

            var query = conn.Cars.SingleOrDefault(p => p.car_id.Equals(int.Parse(id)));

            go.txt_plakaNo.Text = query.car_plakaNumber.ToString();
            go.txt_total.Text = query.car_money.ToString();
            go.txt_brand.Text = query.car_brand.ToString();
            go.txt_model.Text = query.car_model.ToString();
            go.txt_year.Text = query.car_year.ToString();
            go.lbl_carId.Text = query.car_id.ToString();
            go.Show();
        }

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

        private void pic_findPlakaNo_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conn.Cars.Where(p => p.car_plakaNumber.Equals(txt_findFree.Text) && p.car_info.Equals("Free")).ToList();
        }

        private void rentACarPage_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conn.Cars.Where(p => p.car_info.Equals("Free")).ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(); // globale id ye id atadım.
        }
    }
}
