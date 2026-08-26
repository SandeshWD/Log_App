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
                Quantity = 0,
                Price = 800
            });

            products.Add(new Product
            {
                Name = "Brownie",
                Quantity = 0,
                Price = 100
            });

            ProductDataGrid.ItemsSource = products;
        }

        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            string name = NewItem.Text;
            decimal price = decimal.Parse(PriceTextBox.Text);
        }

        private void IncreaseQuantity_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            Product product = (Product)button.DataContext;

            product.Quantity++;

            ProductDataGrid.Items.Refresh();
        }
        private void DecreaseQuantity_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            Product product = (Product)button.DataContext;

            if (product.Quantity >= 1)
            {
                product.Quantity--;
            }

            ProductDataGrid.Items.Refresh();
        }
    }
}