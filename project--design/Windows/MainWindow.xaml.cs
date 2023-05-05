using project__design.Windows;
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

namespace project__design {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, RoutedEventArgs e) {
            if (new Authentication(textboxAccount.Text, textboxPassword.Text).Send()) {
                Window1 window1 = new Window1();
                window1.Show(); 
                this.Close();
            }
            else {
                labelAlert.Content = "用户名或密码错误！";
            }
        }
    }
}

class Authentication {
    public String Username { get; set; }
    public String Password { get; set; }
    public Authentication(String user, String pwd) {
        Username = user;
        Password = pwd;
    }
    public bool Send() {   //如果认证成功返回true
        return true;
    }
}
