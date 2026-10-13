using demo.Entities;
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

namespace demo.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        List<User> users = AppConnect.model1.User.ToList();
        public static LoginedUser loginedUser = new LoginedUser();

        public LoginPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var user = users.FirstOrDefault(x => x.login == logintxt.Text);

            if (user != null)
            {
                loginedUser = new LoginedUser()
                {
                    UserID = user.id,
                    UserName = user.name + " " + user.secondName + " " + user.lastName,
                    RoleID = user.idRole
                };

                MessageBox.Show($"Авторизация успешна! Здравствуйте {user.secondName} {user.name}");
                MainWindow.MainFrame.Navigate(new Pages.DataPage());
            }
            else
            {
                MessageBox.Show("Здравствуйте, неавтаризованный пользователь!");
                MainWindow.MainFrame.Navigate(new Pages.DataPage());
            }
        }
    }
}
