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
    /// Логика взаимодействия для DataPage.xaml
    /// </summary>
    public partial class DataPage : Page
    {
        List<Product> products;
        List<Category> categories;
        public DataPage()
        {
            InitializeComponent();

            products = AppConnect.model1.Product.ToList();
            categories = AppConnect.model1.Category.ToList();

            ProductList.ItemsSource = products;

            if (LoginPage.loginedUser != null && LoginPage.loginedUser.UserID != 0)
            {
                loginedName.Visibility = Visibility.Visible;
                loginedName.Text = LoginPage.loginedUser.UserName.ToString();

                Filterbox.Items.Add("Сортировать");
                foreach (var item in categories)
                {
                    Filterbox.Items.Add(item.category1);
                }
                Filterbox.SelectedIndex = 0;


                Sortbox.Items.Add("Фильтовать");
                Sortbox.Items.Add("По возрастанию");
                Sortbox.Items.Add("По убыванию");

                Sortbox.SelectedIndex = 0;

            }
            else
            {
                loginLink.Visibility = Visibility.Visible;
            }
            
        }

        private void loginLink_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrame.GoBack();
        }

        public List<Product> SortFilterSearch()
        {
            //if (Sortbox.SelectedIndex != 0)
            //{
            //    products = products.OrderBy(products.);
            //}
            

            return products;
        }
    }
}
