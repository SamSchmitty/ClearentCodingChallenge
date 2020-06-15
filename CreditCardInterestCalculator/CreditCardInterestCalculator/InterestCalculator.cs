using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardInterestCalculator
{
    class InterestCalculator
    {
        static void Main(string[] args)
        {

            /* 1 person has 1 wallet and 3 cards(1 Visa, 1 MC 1 Discover) – Each Card has a balance of $100 –
                calculate the total interest(simple interest) for this person and per card.
            */
            Console.WriteLine("Case 1:");
            List<CreditCard> cardTypesCase1 = new List<CreditCard>();
            cardTypesCase1.Add(new CreditCard("Visa", 100));
            cardTypesCase1.Add(new CreditCard("MC", 100));
            cardTypesCase1.Add(new CreditCard("Discover", 100));

            List<Wallet> walletsCase1 = new List<Wallet>();
            walletsCase1.Add(new Wallet(cardTypesCase1));

            Person bob = new Person(walletsCase1, "bob");

            double bobInterest = bob.CalculateInterest();
            Console.WriteLine($"Total interest for bob is {bobInterest:C}");

            /* 1 person has 2 wallets Wallet 1 has a Visa and Discover, wallet 2 a MC - each card has $100 balance -
                calculate the total interest(simple interest) for this person and interest per wallet
            */
            Console.WriteLine("Case 2:");
            List<CreditCard> cardTypesWallet1 = new List<CreditCard>();
            cardTypesWallet1.Add(new CreditCard("Visa", 100));
            cardTypesWallet1.Add(new CreditCard("Discover", 100));

            List<CreditCard> cardTypesWallet2 = new List<CreditCard>();
            cardTypesWallet2.Add(new CreditCard("MC", 100));

            List<Wallet> walletsCase2 = new List<Wallet>();
            walletsCase2.Add(new Wallet(cardTypesWallet1));
            walletsCase2.Add(new Wallet(cardTypesWallet2));

            Person sally = new Person(walletsCase2, "Sally");

            double sallyInterest = sally.CalculateInterest();
            Console.WriteLine($"Total interest for Sally is {sallyInterest:C}");

            /* 2 people have 1 wallet each, person 1 has 1 wallet, with 2 cards MC and visa person 2
                has 1 wallet – 1 visa and 1 MC - each card has $100 balance - calculate the total
                interest(simple interest) for each person and interest per wallet
            */
            Console.WriteLine("Case 3:");

            List<CreditCard> cardTypesCase3Wallet1 = new List<CreditCard>();
            cardTypesCase3Wallet1.Add(new CreditCard("MC", 100));
            cardTypesCase3Wallet1.Add(new CreditCard("Visa", 100));

            List<Wallet> walletsCase3Person1 = new List<Wallet>();
            walletsCase3Person1.Add(new Wallet(cardTypesCase3Wallet1));

            Person jack = new Person(walletsCase3Person1, "Jack");

            List<CreditCard> cardTypesCase3Wallet2 = new List<CreditCard>();
            cardTypesCase3Wallet2.Add(new CreditCard("MC", 100));
            cardTypesCase3Wallet2.Add(new CreditCard("Visa", 100));

            List<Wallet> walletsCase3Person2 = new List<Wallet>();
            walletsCase3Person2.Add(new Wallet(cardTypesCase3Wallet2));

            Person jill = new Person(walletsCase3Person2, "Jill");

            double jackInterest = jack.CalculateInterest();
            double jillInterest = jill.CalculateInterest();

            Console.WriteLine($"Total interest for Jack is {jackInterest:C}");
            Console.WriteLine($"Total interest for Jill is {jillInterest:C}");

            //this is just here so that the console doens't close immediately and you can read the output. 
            string response;
            do
            {
                Console.WriteLine("Would you like to exit? (y/n)");
                response = Console.ReadLine();
            } while (response.Equals("n"));
        }
    }
}
