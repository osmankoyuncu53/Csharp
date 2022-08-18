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
    public partial class homePage : Form
    {
        public homePage()
        {
            InitializeComponent();
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
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

        
    }
}
