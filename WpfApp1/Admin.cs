using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Admin
    {
        public string log = "Administration";
        public string password = "123";
        public Admin() { }
        public void Make(){
            MainWindow open = new MainWindow();
            open.Show();
}

    }
}
