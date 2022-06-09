using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Classes
{
    public class Library
    {
        public Library()
        {
            products = new Product[0];
        }
        public Product[] products;

        public void AddProduct(Product product)
        {
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = product;
        }

        public int GetJournalsCount()
        {
            int count = 0;
            foreach (var item in products)
            {
                if (item is Journal)
                {
                    count++;
                }
            }
            return count;

        }public int GetBooksCount()
        {
            int count = 0;
            foreach (var item in products)
            {
                if (item is Book)
                {
                    count++;
                }
            }
            return count;
        }

        public Product[] GetProduct(bool isBook)
        {
            int count = 0;
            Product[] prdct = new Product[0];
            foreach (var item in products)
            {
                if (item is Book)
                {
                    count++;
                    isBook = true;
                }
            }
            if (count == 0)
            {
                isBook = false;
            }
            if (isBook)
            {
                foreach (var item in products)
                {
                    if (item is Book)
                    {
                        Array.Resize(ref prdct, prdct.Length + 1);
                        prdct[prdct.Length - 1] = item;
                    }
                }
                return prdct;
            }
            else
            {
                foreach (var item in products)
                {
                    if (item is Journal)
                    {
                        Array.Resize(ref prdct, prdct.Length + 1);
                        prdct[prdct.Length - 1] = item;
                    }
                }
                return prdct;
            }
        }





    }
}
