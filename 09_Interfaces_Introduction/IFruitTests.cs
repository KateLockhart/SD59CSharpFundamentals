using System;
using System.Collections.Generic;
using System.Dynamic;
using _09_Interfaces_Introduction.Fruits;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _09_Interfaces_Intro
{
    [TestClass]
    public class IFruiteTests
    {
        [TestMethod]
        public void CallingInterfaceMethods()
        {
            IFruit banana = new Banana();
            var output = banana.Peel();
            Console.WriteLine(output);
            Console.WriteLine("The banana is peeled");
            Assert.IsTrue(banana.Peeled);
        }
        [TestMethod]
        public void InterfacesInCollections()
        {
            //arange
            var orange = new Orange();
            var fruitSalad = new List<IFruit>
            {
                new Banana(),
            new Grape(),
            orange
            };
            foreach (var fruit in fruitSalad)
            {
                Console.WriteLine($"{fruit.Name} {fruit.Peel()}");
                Assert.IsInstanceOfType(fruit, typeof(IFruit));
            }
            Console.WriteLine(orange.Squeeze());
        }

        private string GetFruitName(IFruit fruits)
        {
            return $"This fruit is called {fruits.Name}";
        }

        [TestMethod]
        public void InterfacesInMethods()
        {
            var grape = new Grape();
            var output = GetFruitName(grape);

            var strawberry = new Orange();
            var outputs = GetFruitName(strawberry);

            Console.WriteLine(output);
            Console.WriteLine(outputs);
            Assert.IsTrue(output.Contains("This fruit is called Grape"));
        }
        [TestMethod]
        public void TypeOfInstance()
        {
            var fruitSalad = new List<IFruit>
            {
                new Orange(true),
                new Orange(),
                new Grape(),
                new Orange(),
                new Banana(true),
                new Grape()
            };

            Console.WriteLine("Is the orange peeled");
            Console.WriteLine();

            foreach (var fruit in fruitSalad)
            {
                if (fruit is Orange orange)
                {
                    if (orange.Peeled)
                    {
                        Console.WriteLine("Is a peeled orange");
                        orange.Squeeze();
                    }
                    else
                    {
                        Console.WriteLine("Is an Orange");
                    }
                }
                else if (fruit.GetType() == typeof(Grape))
                {
                    Console.WriteLine("Is a Grape.");
                }
                else if (fruit.Peeled)
                {
                    Console.WriteLine("Is a peeled Banana.");
                }
                else
                {
                    Console.WriteLine("Is a Banana.");
                }
            }
        }
    }
}