using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreditCardInterestCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person.Tests
{
    [TestClass()]
    public class PersonTests
    {
        [TestMethod()]
        public void CalculateInterestTest()
        {
            List<CreditCardInterestCalculator.CreditCard> creditCards1 = new List<CreditCardInterestCalculator.CreditCard>();
            creditCards1.Add(new CreditCardInterestCalculator.CreditCard("Visa", 100));
            creditCards1.Add(new CreditCardInterestCalculator.CreditCard("MC", 100));

            List<CreditCardInterestCalculator.CreditCard> creditCards2 = new List<CreditCardInterestCalculator.CreditCard>();
            creditCards2.Add(new CreditCardInterestCalculator.CreditCard("Discover", 100));

            List<CreditCardInterestCalculator.Wallet> wallets = new List<CreditCardInterestCalculator.Wallet>();
            wallets.Add(new CreditCardInterestCalculator.Wallet(creditCards1));
            wallets.Add(new CreditCardInterestCalculator.Wallet(creditCards2));


            CreditCardInterestCalculator.Person person = new CreditCardInterestCalculator.Person(wallets, "Person");

            double personInterest = person.CalculateInterest();

            Assert.AreEqual((double)16, personInterest);
        }
    }
}