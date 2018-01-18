namespace WpfApp1.UI
{
    using System.Windows;
    using System.Windows.Input;
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
            if(e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void populateCryptoGrid()
        {
            if (this.ListBoxCurrencies.SelectedItem != null)
            {
                string newConvertCurrency = this.ListBoxCurrencies.SelectedItem.ToString();
                if (newConvertCurrency != this.r_ClientData.convertCurrency)
                {
                    this.r_ClientData.CryptCurrenciesList = this.r_ClientData.client.GetCurrencies(100, newConvertCurrency);
                    this.DataGridCurrencies.ItemsSource = this.r_ClientData.CryptCurrenciesList;
                }
            }
        }

        private void ButtonPopulateGrid_Click(object sender, RoutedEventArgs e)
        {
            this.populateCryptoGrid();
        }
    }
}
