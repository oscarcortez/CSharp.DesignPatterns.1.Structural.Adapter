using models;
using System;

namespace CSharp.DesignPatterns.Structural.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //without adapter
            Console.WriteLine("without adapter");
            Meat unknown = new("Beef");
            unknown.LoadData();

            //Adapted
            Console.WriteLine();
            Console.WriteLine("with adapter");
            MeatDetails beef = new("Beef");
            beef.LoadData();

            MeatDetails turkey = new("Turkey");
            turkey.LoadData();

            MeatDetails chicken = new("Chicken");
            chicken.LoadData();

            Console.ReadKey();
        }
    }
}
