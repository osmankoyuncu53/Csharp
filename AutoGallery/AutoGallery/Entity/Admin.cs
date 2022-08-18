using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace AutoGallery.Entity
{
    class Admin
    {
        [Key]
        public int admin_id { get; set; }
        public string admin_userName { get; set; }
        public string admin_mail { get; set; }
        public string admin_password { get; set; }

        Context conn = new Context();
        public void registerAdd(TextBox txt_userName, TextBox txt_mail, TextBox txt_password)
        {
            var insert = new Admin
            {
                admin_userName = txt_userName.Text,
                admin_mail = txt_mail.Text,
                admin_password = txt_password.Text,
            };

            conn.Add(insert);

            if (conn.SaveChanges() == 0)
                MessageBox.Show("Admin Not Added..", "Info!");
            else
            {
                MessageBox.Show("Admin Added.", "Info");
            }
        }

        public bool registerControl(TextBox txt_userName, TextBox txt_mail)
        {
            var query = from t1 in conn.Admins.Where(p => p.admin_userName == txt_userName.Text || p.admin_mail==txt_mail.Text) select t1;

            if (query.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool loginControl(TextBox txt_userName, TextBox txt_password)
        {
            var query = from t1 in conn.Admins.Where(p => p.admin_userName == txt_userName.Text && p.admin_password == txt_password.Text) select t1;

            if (query.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void forgotPassword(TextBox txt_username)
        {
            var query = conn.Admins.SingleOrDefault(p => p.admin_userName.Equals(txt_username.Text));

            MessageBox.Show("Password: " +query.admin_password.ToString(), "Info");

           

           
         
        }
    }   
}
