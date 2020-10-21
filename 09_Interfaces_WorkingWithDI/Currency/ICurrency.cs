using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces_WorkingWithDI.Currency
{
    public interface ICurrency
    {
        //Name - What the currancy is called
        string Name { get; }
        
        // Value - What the currancy is worth
         decimal Value { get; }

    }
}
