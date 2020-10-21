using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces_Introduction.Fruits
{
    // An interface in C# contains definitions for a group of related functionalities
    //that a non-abstract class or a struct must implement.
    interface IFruit
    {
        string Name { get; }
        bool Peeled { get; }
        string Peel();
    }
}
