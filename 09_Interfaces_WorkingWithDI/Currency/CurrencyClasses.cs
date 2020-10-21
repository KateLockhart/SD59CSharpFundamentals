using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces_WorkingWithDI.Currency
{
    class Penny : ICurrency
    {
        // '>=' != '=>'
        public string Name => "Penny";

        public decimal Value
        {
            get
            {
                return .01m;
            }
        }
    }

    public class Dime : ICurrency
    {
        public string Name
        {
            get { return "Dime"; }
        }
        public decimal Value
        {
            get { return .1m; }
        }
    }

    public class Dollar : ICurrency
    {
        public string Name => "Dollar";
        public decimal Value => 1m;
    }

    public class ElectronicPayment : ICurrency
    {
        //add a constructor to set the vlaue of payment 
        public ElectronicPayment(decimal value)
        {
            Value = value;
        }


        public string Name => "Electronic Payment";
        public decimal Value { get; }
    }
}
