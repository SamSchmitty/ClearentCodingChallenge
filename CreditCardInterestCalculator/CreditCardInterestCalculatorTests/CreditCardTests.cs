using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreditCardInterestCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard.Tests
{
    [TestClass()]
    public class CreditCardTests
    {
        [TestMethod()]
        public void CalculateInterestTest()
        {
            CreditCardInterestCalculator.CreditCard visa = new CreditCardInterestCalculator.CreditCard("Visa", 100);
            CreditCardInterestCalculator.CreditCard MC = new CreditCardInterestCalculator.CreditCard("MC", 100);
            CreditCardInterestCalculator.CreditCard Discovery = new CreditCardInterestCalculator.CreditCard("Discover", 100);

            double visaInterest = visa.CalculateInterest();
            double mcInterest = MC.CalculateInterest();
            double discoveryInterest = Discovery.CalculateInterest();

            Assert.AreEqual((double)10, visaInterest);
            Assert.AreEqual((double)5, mcInterest);
            Assert.AreEqual((double)1, discoveryInterest);
        }
    }
}