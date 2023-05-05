using project__design.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Schema;

namespace project__design.Windows {
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window {
        List<Button> buttonList = new List<Button>();
        public Window1() {
            InitializeComponent();
            buttonList.Add(buttonOne);
            buttonList.Add(buttonTwo);
            buttonList.Add(buttonThree);
            buttonList.Add(buttonFore);
            buttonList.Add(buttonFive);
            buttonList.Add(buttonSix);
            buttonList.Add(buttonSeven);
        }

        
        private void buttonOne_Click(object sender, RoutedEventArgs e) {
            Page1 page1 = new Page1();
            ContentControl.Content = new Frame() {
                Content = page1
            };
            foreach (var bu in buttonList) {
                bu.FontSize = 16;
            }
            buttonOne.FontSize = 20;
        }

        private void buttonTwo_Click(object sender, RoutedEventArgs e) {
            Page2 page2 = new Page2();
            ContentControl.Content = new Frame() {
                Content = page2
            };
            foreach (var bu in buttonList) {
                bu.FontSize = 16;
            }
            buttonTwo.FontSize = 20;
        }

        private void buttonThree_Click(object sender, RoutedEventArgs e) {
            Page3 page3 = new Page3();
            ContentControl.Content = new Frame() {
                Content = page3
            };
            foreach (var bu in buttonList) {
                bu.FontSize = 16;
            }
            buttonThree.FontSize = 20;
        }

        private void buttonFore_Click(object sender, RoutedEventArgs e) {
            Page4 page4 = new Page4();
            ContentControl.Content = new Frame() {
                Content = page4
            };
            foreach (var bu in buttonList) {
                bu.FontSize = 16;
            }
            buttonFore.FontSize = 20;
        }

        private void buttonFive_Click(object sender, RoutedEventArgs e) {
            Page5 page5 = new Page5();
            ContentControl.Content = new Frame() {
                Content = page5
            };
            foreach (var bu in buttonList) {
                bu.FontSize = 16;
            }
            buttonFive.FontSize = 20;
        }

        private void buttonSix_Click(object sender, RoutedEventArgs e) {
            Page6 page6 = new Page6();
            ContentControl.Content = new Frame() {
                Content = page6
            };
            foreach (var bu in buttonList) {
                bu.FontSize = 16;
            }
            buttonSix.FontSize = 20;
        }

        private void buttonSeven_Click(object sender, RoutedEventArgs e) {
            Page7 page7 = new Page7();
            ContentControl.Content = new Frame() {
                Content = page7
            };
            foreach (var bu in buttonList) {
                bu.FontSize = 16;
            }
            buttonSeven.FontSize = 20;
        }

    }
}
