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
    /// Interaction logic for Sign_Up.xaml
    /// </summary>
    public partial class Sign_Up : Page
    {
        FacultysEntities db = new FacultysEntities();
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (IsValid(PASS_TXT.Text))
            {
                if (Com_name.Text == "User")
                {
                    user_login use = new user_login();
                    use.user_namee = UserrrN_txt.Text;
                    use.passwordd = PASS_TXT.Text;
                    if (use.passwordd == confp_txt.Text)
                    {
                        db.user_login.Add(use);
                        db.SaveChanges();
                        MessageBox.Show("User Adedd Succ");
                    }
                    else
                        MessageBox.Show("Please enter password Correct");

                }
            }
            if (IsValid(PASS_TXT.Text))
            {
                if (Com_name.Text == "Admin")
                {
                    Adminn add = new Adminn();
                    add.user_namee = UserrrN_txt.Text;
                    add.pass = PASS_TXT.Text;
                    if (add.pass == confp_txt.Text)
                    {
                        db.Adminns.Add(add);
                        db.SaveChanges();
                        MessageBox.Show("Admin Adedd Succ");
                    }
                    else
                        MessageBox.Show("Please enter password Correct");
                }
            }
                else
                    MessageBox.Show("The Name Should Be Contain (Uppercase , LowerCase , Number , Spatiel Character ");
            

            
          
            bool IsValid(String Pass)
            {
                bool upper, lower, num, sympole;
                upper = lower = num = sympole = false;
                string spatiel = "!@#$%^&*()";
                foreach (char c in Pass)
                {
                    if (c >= 'A' && c <= 'Z')
                    {
                        upper = true;
                    }
                    else if (c >= 'a' && c <= 'z')
                    {
                        lower = true;
                    }
                    else if (c >= '0' && c <= '9')
                    {
                        num = true;
                    }
                    else if (spatiel.Contains(c))
                    {
                        sympole = true;
                    }
                }
                return upper && lower && num && sympole;
            }

        }
    }
}
