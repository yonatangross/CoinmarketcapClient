﻿using System.Linq;
using FluentAssertions;
using NoobsMuc.Coinmarketcap.Client;
using NUnit.Framework;


namespace CoinCapClient.Test
{
    [TestFixture()]
    public class IntegrationTest
    {
        [Test]
        public void GetCurrency_Nothing_ReturnAll()
        {
            ICoinmarketcapClient m_Sut = new CoinmarketcapClient();
            var retValue = m_Sut.GetCurrencies();
            retValue.Count().Should().BeGreaterThan(900);
        }

        [Test]
        public void GetCurrency_Using200_Return200Entries()
        {
            ICoinmarketcapClient m_Sut = new CoinmarketcapClient();
            var retValue = m_Sut.GetCurrencies(200);
            retValue.Count().Should().Be(200);
        }

        [Test]
        public void GetCurrency_UsingJPY_Return200Entries()
        {
            ICoinmarketcapClient m_Sut = new CoinmarketcapClient();
            var retValue = m_Sut.GetCurrencies("JPY");
            retValue.Count().Should().BeGreaterThan(900);
        }

        [Test]
        public void GetCurrency_UsingJPYAnd200_Return200Entries()
        {
            ICoinmarketcapClient m_Sut = new CoinmarketcapClient();
            var retValue = m_Sut.GetCurrencies(200,"JPY");
            retValue.Count().Should().Be(200);
        }
    }
}