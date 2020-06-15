using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardInterestCalculator
{
    public class Person
    {
        #region Fields
        private List<Wallet> _wallets;
        private string _name;
        #endregion Fields

        #region Properties
        public List<Wallet> Wallets
        {
            get
            {
                return _wallets;
            }
        }

        public string Name
        {
            get 
            {
                return _name;
            }
        }
        #endregion Properties

        #region Constructors
        public Person(string name)
        {
            _wallets = new List<Wallet>();
            _name = name;
        }

        public Person(List<Wallet> newWallets, string name)
        {
            _wallets = newWallets;
            _name = name;
        }
        #endregion Constructors

        #region Methods
        public void AddWallet (Wallet newWallet)
        {
            Wallets.Add(newWallet);
        }

        public double CalculateInterest()
        {
            Console.WriteLine($"Interest calculation for {Name}");

            double sumInterest = 0.0;
            double interestPerWallet = 0.0;
            int walletCount = 1;
            foreach(Wallet wallet in Wallets)
            {
                Console.WriteLine($"Interest for wallet {walletCount}:");
                interestPerWallet = wallet.CalculateInterest();
                Console.WriteLine($"total interest for wallet {walletCount} is {interestPerWallet:C}");
                walletCount++;
                
                sumInterest += interestPerWallet;
            }

            return sumInterest;
        }
        #endregion Methods
    }
}
