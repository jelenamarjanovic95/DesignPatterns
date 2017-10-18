using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //Abstract factory
    interface ICreditUnionFactory
    {
        ILoanAccount CreateLoanAcct();
        ILoanAccount CreateSavingsAcct();
    }
    //Concrete Factory
    public class CitiCreditUnionFactory : ICreditUnionFactory
    {
        public ILoanAccount CreateLoanAcct()
        {
            throw new NotImplementedException();
        }

        public ILoanAccount CreateSavingsAcct()
        {
            throw new NotImplementedException();
        }
    }
    //Concrete Factory
    public class NationalCreditUnionFactory : ICreditUnionFactory
    {
        public ILoanAccount CreateLoanAcct()
        {
            throw new NotImplementedException();
        }

        public ILoanAccount CreateSavingsAcct()
        {
            throw new NotImplementedException();
        }
    }
   
    //Abstract product
    interface ILoanAccount
    {

    }

    //Abstract product
    interface ISavingsAccount
    {

    }
    //Concrete product
    public class NationalLoanAcct : ILoanAccount
    {

    }
    //Concrete product
    public class CitiLoanAcct : ILoanAccount
    {

    }
    //Concrete product
    public class NationalSavingsAcct : ISavingsAccount
    {

    }
    //Concrete product
    public class CitiSavingsAcct : ISavingsAccount
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
