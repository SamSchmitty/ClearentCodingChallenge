using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardInterestCalculator
{
    class Wallet
    {
        #region Fields
        List<CreditCard> _creditCards;
        #endregion Fields

        #region Constructors
        public Wallet()
        {
            _creditCards = new List<CreditCard>();
        }

        public Wallet(List<CreditCard> creditCards)
        {
            _creditCards = creditCards;
        }
        #endregion Constructors

        #region Methods
        public void AddCard(string cardType, double balance)
        {
            _creditCards.Add(new CreditCard(cardType, balance));
        }

        public double CalculateBalance()
        {
            double balanceSum = 0;
            
            foreach(CreditCard card in _creditCards)
            {
                card.CalculateBalance();
                balanceSum += card.Balance;
            }

            return balanceSum;
        }
        #endregion Methods
    }
}
