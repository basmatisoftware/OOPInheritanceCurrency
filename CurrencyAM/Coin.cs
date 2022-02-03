using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyAM
{
    public class Coin : Currency  //Derived Class from Coin Base Class...   derived : base
    {

        //Properties
        public float Diameter;
        public string Alloys;

        //Constructor that uses the base class constructor
       public Coin(string name, string countryCode, float value, float diameter, string alloys):base(name,countryCode,value)
        {
            //Name = name;
            //CountryCode = countryCode;
            //Value = value;
            Diameter = diameter;
            Alloys = alloys;

        }

        //Method
        public new void Describe()
        {
            Console.WriteLine("::::COIN::::");
            base.Describe();
            Console.WriteLine($"\tAlloys: {Alloys}\n\tDiameter: {Diameter}");

        }

        //public override void ifWall()
        //{ 
        
        //}
    }
}
