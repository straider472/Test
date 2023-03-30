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
using System.IO;

namespace Login
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string link = @"D:/login.txt";
            string link_2 = @"D:/pass.txt";
            string login_1 = login.Text;
            string pass_1 = pass.Text;
            string log = "";
            string ps = "";
            using (StreamReader sr = new StreamReader(link))
            {
                log = sr.ReadToEnd();
            }
            using (StreamReader sr = new StreamReader(link_2))
            {
                ps = sr.ReadToEnd();
            }

            if (login_1==log & pass_1==ps)
            {
                MessageBoxResult result = MessageBox.Show("Продолжить?", "Хз", MessageBoxButton.YesNo);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        MessageBox.Show("Да");
                        break;
                    case MessageBoxResult.No:
                        MessageBox.Show("Нет");
                        break;
                }

            }
            else
            {
            MessageBox.Show("Неверный логин или пароль!");
            }

        }
    }
}
