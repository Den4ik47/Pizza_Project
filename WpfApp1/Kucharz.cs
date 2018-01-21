using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Kucharz
    {
        public string log = "kucz";
        public string pass = "234";
        public Kucharz() { }
        public void Make()
        {
            MainWindow x = new MainWindow();
            x.pirw.Visibility = System.Windows.Visibility.Hidden;
            x.dwa.Visibility = System.Windows.Visibility.Hidden;
            x.trzy.Visibility = System.Windows.Visibility.Hidden;
            x.cztery.Visibility = System.Windows.Visibility.Hidden;
            x.piec.Visibility = System.Windows.Visibility.Hidden;
            x.szec.Visibility = System.Windows.Visibility.Hidden;
            x.Show();
        }
    }
}
