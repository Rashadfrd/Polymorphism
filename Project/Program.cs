using ClassLibrary.Classes;
using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Library kitabxana = new Library();
            Journal journal1 = new Journal
            {
                Name = "Cirtdan",
                Company = "Akifoglu",
                Price = 110,
            };            
            Journal journal2 = new Journal
            {
                Name = "Dede Qorqud",
                Company = "Akifoglu",
                Price = 150,
            };            
            Journal journal3 = new Journal
            {
                Name = "Basat ve Tepegoz",
                Company = "Akifoglu",
                Price = 100,
            };
            Book book1 = new Book
            {
                Name = "Spiderman",
                Author = "Cristiano Messi",
                Genre = "Comics",
                Price = 200
            };




            string input;

            do
            {
                Console.WriteLine("1. Mehsul elave edin:");
                Console.WriteLine("2. Jurnallarin sayini gorun:");
                Console.WriteLine("3. Kitablarin sayini gorun:");
                Console.WriteLine("4. Spesifik  mehsul siyahisini gorun:");
                Console.WriteLine("5. Menudan cixin:");
                input = Console.ReadLine();
                switch (input)
                {

                    case "1":
                        kitabxana.AddProduct(journal1);
                        kitabxana.AddProduct(journal2);
                        kitabxana.AddProduct(journal3);
                        kitabxana.AddProduct(book1);
                        break;
                    case "2":
                        Console.Write("Jurnal sayi: ");
                        Console.WriteLine(kitabxana.GetJournalsCount());
                        break;
                    case "3":
                        Console.Write("Kitab sayi: ");
                        Console.WriteLine(kitabxana.GetBooksCount());
                        break;
                    case "4":
                        Console.WriteLine("Secilmis product siyahisi:");
                        bool check = true;
                        Product[] result = kitabxana.GetProduct(check);
                        foreach (var item in result)
                        {
                            item.GetInfo();
                        }
                        break;

                }

                } while (input != "5");
        }
    }
}
