using System;

namespace CurrencyAM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Currency");
            Coin USDime = new Coin("Dime", "US", 0.10f, 17.92f, "Cupro-Nickel");
            USDime.Describe();
            Bill CA5Dollar = new Bill("Canadian 5 Dollar", "CA", 5.00f, 70, 150.00f, "Light Blue");
            CA5Dollar.Describe();
            
        }
    }
}
