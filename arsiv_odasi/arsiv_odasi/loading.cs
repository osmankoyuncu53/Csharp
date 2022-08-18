using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arsiv_odasi
{
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }
        int saniye=0;
        private void loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1000;
                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;

            if(saniye<9)
            {
                
            }
            else
            {
                timer1.Stop();
                loginForm go = new loginForm();
                go.Show();
                this.Hide();
            }
        }
    }
}
