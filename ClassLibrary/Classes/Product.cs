using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Classes
{
    public abstract class Product
    {
        public string Name;
        public double Price;

        public virtual void GetInfo()
        {
            Console.WriteLine($"Name: {Name} - Price: {Price}");
        }

    }
}
