using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardInterestCalculator
{
    public class CreditCard
    {
        #region Fields
        //Dictionary<Credit Type, interest rate>
        private Dictionary<string, double> _creditCardTypesWithInterestRate;
        private double _balance;
        private double _interestRate;
        private string _cardType;
        #endregion Fields

        #region Properties
        public Dictionary<string, double> CreditCardTypesWithInterestRate
        {
            get 
            {
                if(_creditCardTypesWithInterestRate == null)
                {
                    _creditCardTypesWithInterestRate = new Dictionary<string, double>();
                    _creditCardTypesWithInterestRate.Add("Visa", .1);
                    _creditCardTypesWithInterestRate.Add("MC", .05);
                    _creditCardTypesWithInterestRate.Add("Discover", .01);
                }

                return _creditCardTypesWithInterestRate;
            }
        }

        public double InterestRate
        {
            get 
            {
                return _interestRate;
            }
        }

        public string CardType
        {
            get 
            {
                return _cardType;
            }
        }

        public double Balance
        {
            get 
            {
                return _balance;
            }
        }
        #endregion Properties

        #region Constructor
        public CreditCard(string cardType, double balance)
        {
            if(CreditCardTypesWithInterestRate.ContainsKey(cardType))
            {
                _cardType = cardType;
                _interestRate = CreditCardTypesWithInterestRate[_cardType];
                _balance = balance;
            }
            else
            {
                throw new Exception($"Provided card type {cardType} was not found in valid card types");
            }
        }
        #endregion Constructor

        #region Methods
        public double CalculateInterest()
        {
            return (_balance * _interestRate);
        }
        #endregion Methods
    }
}
