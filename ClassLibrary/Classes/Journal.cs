using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Classes
{
    public class Journal:Product
    {
        public string Company;

        public override void GetInfo()
        {
            Console.WriteLine($"Name: {Name} - Price: {Price} - Company: {Company}");
        }
    }
}
