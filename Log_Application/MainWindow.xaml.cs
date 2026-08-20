using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.Generic;

namespace Log_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Product> products = new List<Product>();
        public MainWindow()
        {
            InitializeComponent();

            products.Add(new Product
            {
                Name = "Chocolate Cake",
                Quantity = 2,
                Price = 800
            });

            products.Add(new Product
            {
                Name = "Brownie",
                Quantity = 3,
                Price = 100
            });

            ProductDataGrid.ItemsSource = products;
        }
    }
}