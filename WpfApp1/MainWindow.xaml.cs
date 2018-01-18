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

namespace WpfApp1
{
    using WpfApp1.Logic;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private readonly ClientData r_ClientData = new ClientData();

        public MainWindow()
        {
            InitializeComponent();

            this.ListBoxCurrencies.ItemsSource = this.r_ClientData.client.GetConvertCurrencyList();

        }

        private void populateCryptoGrid()
        {
            if (this.ListBoxCurrencies.SelectedItem != null)
            {
                string newConvertCurrency = ListBoxCurrencies.SelectedItem.ToString();
                if (newConvertCurrency != this.r_ClientData.convertCurrency)
                {
                    this.r_ClientData.CryptCurrenciesList = this.r_ClientData.client.GetCurrencies(100, newConvertCurrency);
                    this.DataGridCurrencies.ItemsSource = this.r_ClientData.CryptCurrenciesList;
                }
            }
        }

        private void ButtonPopulateGrid_Click_1(object sender, RoutedEventArgs e)
        {
            this.populateCryptoGrid();
        }
    }
}
