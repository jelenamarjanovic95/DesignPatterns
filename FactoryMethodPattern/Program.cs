using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    //Product
    public abstract class ISavingsAccount
    {
        public decimal Balance { get; set; }
    }

    //Concrete product
    public class CitiSavingsAccount : ISavingsAccount
    {
        public CitiSavingsAccount()
        {
            Balance = 5000;
        }
    }

    //Concrete product
    public class NationalSavingsAccount : ISavingsAccount
    {
        public NationalSavingsAccount()
        {
            Balance = 2000;
        }
    }

    //Creator
    interface ICreditUnionFactory
    {
        ISavingsAccount GetSavingsAccount(string acctno);
    }

    //Concrete creator
    public class SavingsAccountFactory : ICreditUnionFactory
    {
        public ISavingsAccount GetSavingsAccount(string acctno)
        {
            if (acctno.Contains("CITI"))
            {
                return new CitiSavingsAccount();
            }
            else if (acctno.Contains("NATIONAL"))
            {
                return new NationalSavingsAccount();
            }
            else
            {
                throw new ArgumentException("INVALID ACCOUNT NUMBER");
            }
        }
    }
    class Program
    {   
        
        static void Main(string[] args)
        {
 
            ICreditUnionFactory f = new SavingsAccountFactory();
            var cityAcct = f.GetSavingsAccount("CITI 003");
            var nationalAcct = f.GetSavingsAccount("NATIONAL 003");

            Console.WriteLine($"My citi savings account is ${cityAcct.Balance} and national account ${nationalAcct.Balance}");
        }
    }
}
