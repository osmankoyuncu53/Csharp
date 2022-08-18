using AutoGallery.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using AutoGallery.Entity;

namespace AutoGallery
{
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
        }

        Admin admin = new Admin();
        private void pic_enter_Click(object sender, EventArgs e)
        {
            if(txt_username.Text=="" && txt_password.Text == "")
            {
                MessageBox.Show("Fill in the blanks...", "Attention!");
            }
            else
            {
                MessageBox.Show("Checking Information.", "Info");
                Thread.Sleep(2000);

                if (admin.loginControl(txt_username, txt_password)==true)
                {
                    homePage go = new homePage();
                    go.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Check the entered information!", "Attention!");
                    txt_username.Clear();
                    txt_password.Clear();
                }
            }
        }

        private void link_signUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registerPage go = new registerPage();
            go.Show();
            this.Hide();
        }

        private void link_forgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txt_username.Text == "")
            {
                lbl_durum.Visible = true;
                lbl_durum.ForeColor = Color.Red;
                lbl_durum.Text = "Please Enter UserName!";
            }
            else
            {
                admin.forgotPassword(txt_username);
            }
            
        }
    }
}
