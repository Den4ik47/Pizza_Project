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
using WpfApp1.Abstract;
using System.Collections;
namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Pizza.xaml
    /// </summary>
    public partial class Pizza : Window
    {
        List<Pizzaz> list = new List<Pizzaz>();
        public Pizza()
        {
            InitializeComponent();
            list.Capacity = 1;
        }
        int sum = 0;
        ArrayList ArrayList = new ArrayList();
        
         
        private void Mar_Click_1(object sender, RoutedEventArgs e)
        {
            if (M.IsChecked == true && S.IsChecked == false && D.IsChecked == false)
            {
                string Value = "Margherita";
                Pizzaz pizzaz = new SmallCheapiest(Value);
                list.Add(pizzaz);
                sum += pizzaz.GetCost();
                Name.Content = pizzaz.Name;
                Suma.Content = sum;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PizzaDecorator pizzaz = new Corn(list[0]);
                Suma.Content = sum += pizzaz.GetCost();
                Name.Content = pizzaz.Name;
            }
            catch { }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                PizzaDecorator pizzaz = new Tomato(list[0]);
                Suma.Content = sum += pizzaz.GetCost();
                Name.Content = pizzaz.Name;
            }
            catch { }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                PizzaDecorator pizzaz = new Pepe(list[0]);
                Suma.Content = sum += pizzaz.GetCost();
                Name.Content = pizzaz.Name;
            }
            catch { }
            }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                PizzaDecorator pizzaz = new Chesse(list[0]);
                Suma.Content = sum += pizzaz.GetCost();
                Name.Content = pizzaz.Name;
            }
            catch { }
            }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                PizzaDecorator pizzaz = new Wolowina(list[0]);
                Suma.Content = sum += pizzaz.GetCost();
                Name.Content = pizzaz.Name;
            }
            catch { }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            try
            {
                PizzaDecorator pizzaz = new Wolowina(list[0]);
                Suma.Content = sum += pizzaz.GetCost();
                Name.Content = pizzaz.Name;
            }
            catch { }
        }
    }
    }

