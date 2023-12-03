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
    /// Interaction logic for Admin_page.xaml
    /// </summary>
    public partial class Admin_page : Page
    {
        FacultysEntities db = new FacultysEntities();
        public Admin_page()
        {
            InitializeComponent();
           dg_name.ItemsSource = db.Userrs.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dg_name.ItemsSource = db.Userrs.ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Userr gg = new Userr();
            int bb = int.Parse(id_txt.Text);
            gg = db.Userrs.FirstOrDefault(x => x.id == bb);
            gg.Department=dep_txt.Text;
            db.Userrs.AddOrUpdate(gg);
            db.SaveChanges();
            MessageBox.Show("Department Updated Succ");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Userr us = new Userr();
            int add =int.Parse(id_txt.Text);
            us = db.Userrs.FirstOrDefault(x => x.id == add);
            db.Userrs.Remove(us);
            db.SaveChanges();
            MessageBox.Show("Record Deleted");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            if (id_txt.Text != "" && dep_txt.Text != "")
            {
                Userr kk = new Userr();
                int ff = int.Parse(id_txt.Text);
                dg_name.ItemsSource = db.Userrs.Where(x => x.id == ff && x.Department == dep_txt.Text).ToList();
            }
            else if (id_txt.Text != "" && dep_txt.Text == "")
            {
                Userr yy = new Userr();
                int pp = int.Parse(id_txt.Text);
                dg_name.ItemsSource = db.Userrs.Where(x => x.id == pp).ToList();
            }
            else if (id_txt.Text == "" && dep_txt.Text != "")
            {
                Userr ll = new Userr();
                dg_name.ItemsSource = db.Userrs.Where(x => x.Department == dep_txt.Text).ToList();
            }
            else
                MessageBox.Show("Please Enter the id or department");
        }
    }
}
