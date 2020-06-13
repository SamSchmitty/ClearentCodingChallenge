using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardInterestCalculator
{
    class CreditCard
    {
        #region Fields
        //Dictionary<Credit Type, interest rate>
        private Dictionary<string, float> _creditCardTypesWithInterestRate;
        private double _balance;
        private float _interestRate;
        private string _cardType;
        #endregion Fields

        #region Properties
        public Dictionary<string, float> CreditCardTypesWithInterestRate
        {
            get 
            {
                if(_creditCardTypesWithInterestRate == null)
                {
                    _creditCardTypesWithInterestRate = new Dictionary<string, float>();
                    _creditCardTypesWithInterestRate.Add("Visa", .1f);
                    _creditCardTypesWithInterestRate.Add("MC", .05f);
                    _creditCardTypesWithInterestRate.Add("Discover", .01f);
                }

                return _creditCardTypesWithInterestRate;
            }
        }

        public float InterestRate
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
