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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Logowanie.xaml
    /// </summary>
    public partial class Logowanie : Window
    {
        Kucharz kuczarz = new Kucharz();
        Kelner kelner = new Kelner();
        Admin admin = new Admin();
        MainWindow powrot = new MainWindow();
        public Logowanie()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text == admin.log && Pass1.Password == admin.password)
            {
                admin.Make();
                this.Hide();
            }
            if (TextBox1.Text==kelner.log&&Pass1.Password==kelner.pass) { kelner.Make();
                this.Hide();
            }
            if (TextBox1.Text == kuczarz.log && Pass1.Password == kuczarz.pass) { kuczarz.Make();
                this.Hide();
            }
            else { MessageBox.Show("Log albo password nie prawidlowy"); }
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            powrot.Show();           
            
        }
    }
}
