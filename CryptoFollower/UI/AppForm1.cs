namespace CryptoFollower.UI
{
    using System;
    using System.Windows.Forms;

    using CryptoFollower.Logic;

    public partial class Form1 : Form
    {
        private readonly ClientData r_ClientData = new ClientData();

        public Form1()
        {
            this.InitializeComponent();


            this.listBoxCurrencies.DataSource = this.r_ClientData.client.GetConvertCurrencyList();
      
        }

        private void buttonPopulateGrid_Click(object sender, EventArgs e)
        {
            this.populateCryptoGrid();
        }

        private void populateCryptoGrid()
        {
            string newConvertCurrency = this.listBoxCurrencies.SelectedItem.ToString();
            if (newConvertCurrency != this.r_ClientData.convertCurrency)
            {
                this.r_ClientData.CryptCurrenciesList = this.r_ClientData.client.GetCurrencies(100, newConvertCurrency);
                this.dataGridViewCryptoCurrencies.DataSource = this.r_ClientData.CryptCurrenciesList;
                this.dataGridViewCryptoCurrencies.Show();
            }
        }
    }
}
