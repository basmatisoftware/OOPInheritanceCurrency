using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyAM
{
    public class Bill : Currency  //A derived class
    {
        //Properties
        public float Height;
        public float Width;
        public string Color;

        //Constructor
        public Bill(string name, string countryCode, float value, float height, float width, string color) : base(name, countryCode, value)
        {
            //These are assigned via the :base( ) constructor and aren't needed here
            //Name = name;        
            //CountryCode = countryCode;
            //Value = value;
            Height = height;
            Width = width;
            Color = color;
        }

        public new void Describe()
        {
            Console.WriteLine("::::BILL::::");
            base.Describe();
            Console.WriteLine($"\tColor: {Color}\n\tDims: {Height} x {Width}");
        }

    }
}
