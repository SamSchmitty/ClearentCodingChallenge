using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreditCardInterestCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallet.Tests
{
    [TestClass()]
    public class WalletTests
    {
        [TestMethod()]
        public void CalculateInterestTest()
        {
            List<CreditCardInterestCalculator.CreditCard> creditCards = new List<CreditCardInterestCalculator.CreditCard>();
            creditCards.Add(new CreditCardInterestCalculator.CreditCard("Visa", 100));
            creditCards.Add(new CreditCardInterestCalculator.CreditCard("MC", 100));

            CreditCardInterestCalculator.Wallet wallet = new CreditCardInterestCalculator.Wallet(creditCards);
            wallet.AddCard("Discover", 100);

            double walletInterest = wallet.CalculateInterest();

            Assert.AreEqual((double)16, walletInterest);
        }
    }
}