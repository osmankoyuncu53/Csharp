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
using System.Threading;

namespace AutoGallery
{
    public partial class registerPage : Form
    {
        public registerPage()
        {
            InitializeComponent();
        }
        Admin admin = new Admin();
        private void link_SıgnIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginPage go = new loginPage();
            go.Show();
            this.Hide();
        }

        private void pic_registerAdd_Click(object sender, EventArgs e)
        {
            if(txt_username.Text=="" || txt_mail.Text=="" || txt_password.Text == "")
            {
                MessageBox.Show("Fill in the blanks...", "Attention!");
            }
            else
            {
                if (admin.registerControl(txt_username, txt_mail) == true)
                {
                    MessageBox.Show("There is a registered user name or e-mail in the system.", "Attention!");
                }
                else
                {
                    if (txt_password.Text != txt_passwordAgain.Text)
                    {
                        MessageBox.Show("Passwords Do Not Match.", "Attention!");
                    }
                    else
                    {
                        admin.registerAdd(txt_username, txt_mail, txt_password);
                        Thread.Sleep(1000);

                        loginPage go = new loginPage();
                        go.Show();
                        this.Hide();
                    }
                }
            }
        }
    }
}
