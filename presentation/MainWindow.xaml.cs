using Business;
using Data;
using Entity;
using System.Windows;
using System.Windows.Controls;

namespace presentation
{
    public partial class MainWindow : Window
    {
        BProduct bProduct = new BProduct();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Products> products = bProduct.Get();

            // Asignar la lista de productos al DataGrid
            dgCustomer.ItemsSource = products;


        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }
    }
}
