using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Kelner
    {
        public string log = "kel";
        public string pass = "123";
        public Kelner() { }
        public void Make() {
            MainWindow x = new MainWindow();
            x.Show();
            x.But1.Visibility=System.Windows.Visibility.Hidden;
            x.But2.Visibility = System.Windows.Visibility.Hidden;
            x.But3.Visibility = System.Windows.Visibility.Hidden;
            x.But4.Visibility = System.Windows.Visibility.Hidden;
        }
    }
}
