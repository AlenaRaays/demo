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
        public DataPage()
        {
            InitializeComponent();

            products = AppConnect.modelS.Product.ToList();
            ProductList.ItemsSource = products;

            if (LoginPage.loginedUser != null)
            {

            }
        }
    }
}
