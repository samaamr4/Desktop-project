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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Facultyyyyyy
{
    /// <summary>
    /// Interaction logic for user_page.xaml
    /// </summary>
    public partial class user_page : Page
    {
        FacultysEntities db = new FacultysEntities();
        string Gender;
        
        public user_page()
        {
            InitializeComponent();
        }
    
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Userr us = new Userr();
            us.namee = name_txt.Text;
            us.gender = Gender;
            us.Addresss = addres_txt.Text;
            us.Age = int.Parse(age_txt.Text);
            us.Department = Dep_name.Text;
            db.Userrs.Add(us);
            db.SaveChanges();
            MessageBox.Show("Added Succ");
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Gender = "Male";
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            Gender = "Female";
        }
    }
}
