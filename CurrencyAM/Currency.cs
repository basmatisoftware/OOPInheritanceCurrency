using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyAM
{
    public abstract class Currency   //BASE CLASS -- abstrace means we cannot directly create objects, but can create derived classes from it.
    {
        //Properties
        public string Name;
        public string CountryCode; //2 characters, US, CA, EU, MX
        public float Value;

        //Constructors
        public Currency()
        {
            Console.WriteLine("Currency Created");
        }

        public Currency(string name, string countryCode, float value)
        {
            Name = name;
            CountryCode = countryCode;
            Value = value;
        }

        public void Describe()
        {
            Console.WriteLine($"Description for {Name}:");
            Console.WriteLine($"\tCountry Code: {CountryCode}");
            Console.WriteLine($"\tValue: {Value}");

        }

        //public abstract void ifWall(); //This will required each derived class to have this method!
    }
}
