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

namespace UserApp
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }
        private void Button_Auth_Click(object sender, RoutedEventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string pass = passBox_1.Password.Trim();


            if (login.Length < 5)
            {
                textBoxLogin.ToolTip = "This field is entered incorrectly!";
                textBoxLogin.Background = Brushes.DarkRed;
            }
            else if (pass.Length < 5)
            {
                passBox_1.ToolTip = "This field is entered incorrectly!";
                passBox_1.Background = Brushes.DarkRed;
            }
            else
            {
                textBoxLogin.ToolTip = "";
                textBoxLogin.Background = Brushes.Transparent;
                passBox_1.ToolTip = "";
                passBox_1.Background = Brushes.Transparent;
            }
            User authUser = null;
            using (ApplicationContext db = new ApplicationContext())
            {
                authUser = db.Users.Where(b=> b.Login == login && b.Password == pass).FirstOrDefault();
            }
            if (authUser != null)
            {
                MessageBox.Show("Exelent!");
                UserPageWindow userPageWindow = new UserPageWindow();
                userPageWindow.Show();
                Hide();
            }
            else
                MessageBox.Show("Somthing incorect!");

        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }
    }
}
