using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Facultyyyyyy
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        FacultysEntities db = new FacultysEntities();
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Comb_login.Text=="User")
            {
                user_login us = new user_login();
                us = db.user_login.FirstOrDefault(x => x.user_namee == UserName_txt.Text);
                if (us.passwordd == Pass_txt.Text)
                {
                    user_page page = new user_page();
                    this.NavigationService.Navigate(page);
                }
                else
                    MessageBox.Show("Please enter the password agine");
            }
            else if (Comb_login.Text =="Admin")
            {
                Adminn ad = new Adminn();
                ad = db.Adminns.FirstOrDefault(x => x.user_namee == UserName_txt.Text);
                if (ad.pass == Pass_txt.Text)
                {
                    Admin_page add = new Admin_page();
                    this.NavigationService.Navigate(add);
                }
                else
                    MessageBox.Show("Please enter the password agine");
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Sign_Up si = new Sign_Up();
            this.NavigationService.Navigate(si);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Forget_Password forget = new Forget_Password();
            this.NavigationService.Navigate(forget);
        }
    }
}
