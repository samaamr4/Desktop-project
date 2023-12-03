using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Facultyyyyyy
{
    /// <summary>
    /// Interaction logic for Forget_Password.xaml
    /// </summary>
    public partial class Forget_Password : Page
    {
        FacultysEntities db = new FacultysEntities();
        public Forget_Password()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Co_txt.Text=="User")
            {
                user_login us = new user_login();
                us = db.user_login.FirstOrDefault(x => x.user_namee == user_txt.Text);
                us.passwordd = passw_txt.Text;
                db.user_login.AddOrUpdate(us);
                db.SaveChanges();
                MessageBox.Show("Password User Updated Succ");
            }
            if (Co_txt.Text=="Admin")
            {
                Adminn ad = new Adminn();
                ad = db.Adminns.FirstOrDefault(x => x.user_namee == user_txt.Text);
                ad.pass=passw_txt.Text;
                db.Adminns.AddOrUpdate(ad);
                db.SaveChanges();
                MessageBox.Show("Password Admin Updated Succ");
            }
            else if (Co_txt.Text=="")
            {
                MessageBox.Show("Please Choose Admin Or User");
            }
        }
    }
}
