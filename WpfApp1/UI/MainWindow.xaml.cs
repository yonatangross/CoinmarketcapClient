namespace WpfApp1.UI
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Documents;
    using System.Windows.Input;

    using Coinmarketcap.Client;

    using WpfApp1.Business;

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
            this.MainWindow1.MouseDown += this.MainWindow_MouseDown;
        }

        private void MainWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void ButtonPopulateGrid_Click(object sender, RoutedEventArgs e)
        {
            if (this.ListBoxCurrencies.SelectedItem != null)
            {
                string newConvertCurrency = this.ListBoxCurrencies.SelectedItem.ToString();
                if (newConvertCurrency != this.r_ClientData.convertCurrency)
                {
                    Task<IEnumerable<Currency>> currenciesTask = this.r_ClientData.client.GetCurrencies2(100, newConvertCurrency);
                    currenciesTask.ContinueWith(
                        i_CurrenciesTask => 
                            {
                                IEnumerable<Currency> currencies = i_CurrenciesTask.Result;
                                DataGridCurrencies.ItemsSource = currencies;
                            },
                        TaskScheduler.FromCurrentSynchronizationContext());
                }
            }
        }
    }
}
