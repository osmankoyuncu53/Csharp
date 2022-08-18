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
    public partial class carStatusPage : Form
    {
        public carStatusPage()
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

        private void carAddTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carTransactionsPage go = new carTransactionsPage();
            go.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginPage go = new loginPage();
            go.Show();
            this.Hide();
        }

        private void carStatusPage_Load(object sender, EventArgs e)
        {
            dataGridAll.DataSource = conn.Cars.ToList();

            var query = from item in conn.rentACars
                            join item2 in conn.Cars on item.car_id equals (item2.car_id)
                            where item2.car_info.Equals("Busy")
                            select new
                            {
                                item.rentACar_id,
                                item2.car_plakaNumber,
                                item.rent_purchaseDate,
                                item.rent_deliveryDate,
                                item2.car_info,
                                item.car_id,
                                item.customer_id
                            };
            dataGridBusy.DataSource = query.ToList();

            var queryFree = from item in conn.rentACars
                        join item2 in conn.Cars on item.car_id equals (item2.car_id)
                        where item2.car_info.Equals("Free")
                        select new
                        {
                            item.rentACar_id,
                            item2.car_plakaNumber,
                            item.rent_purchaseDate,
                            item.rent_deliveryDate,
                            item2.car_info,
                            item.car_id,
                            item.customer_id
                        };

            dataGridFree.DataSource = queryFree.ToList();
        }

        private void dataGridAll_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridAll.Rows[e.RowIndex].Cells[0].Value.ToString(); // globale id ye id atadım.
        }

        private void dataGridBusy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridBusy.Rows[e.RowIndex].Cells[0].Value.ToString(); // globale id ye id atadım.
        }

        private void dataGridFree_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridFree.Rows[e.RowIndex].Cells[0].Value.ToString(); // globale id ye id atadım.
        }

        private void pic_findAll_Click(object sender, EventArgs e)
        {
            dataGridFree.DataSource = conn.Cars.Where(p => p.car_plakaNumber.Equals(txt_findAll.Text)).ToList();
        }

        private void pic_findFree_Click(object sender, EventArgs e)
        {
            dataGridFree.DataSource = conn.Cars.Where(p => p.car_plakaNumber.Equals(txt_findFree.Text)&& p.car_info.Equals("Free")).ToList();
        }

        private void pic_findBusy_Click(object sender, EventArgs e)
        {
            dataGridBusy.DataSource = conn.Cars.Where(p => p.car_plakaNumber.Equals(txt_findBusy.Text) && p.car_info.Equals("Busy")).ToList();
        }
    }
}
