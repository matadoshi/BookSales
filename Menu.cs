using System;
using System.Collections.Generic;
using System.Text;

namespace BookMarke
{
    class Menu
    {
        
        public void MenuBar()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1.Add Book to DataBase. ");
                Console.WriteLine("2.Sell product");
                Console.WriteLine("3.Change product info");
                Console.WriteLine("4.Delete product");
                Console.WriteLine("5.Show Income");
                Console.WriteLine("6.Show Anbar");
                Console.WriteLine("7.Exit");
              
              int.TryParse(Console.ReadLine(), out int choice);

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Enter Book Id-");
                        int.TryParse(Console.ReadLine(), out int id);
                        Console.Write("Enter Book Name-");
                        string name = Console.ReadLine()??"";
                        Console.Write("Enter Book Pagesize - ");
                       int.TryParse(Console.ReadLine(), out int pagesize);
                        Console.Write("Enter Book Price-");
                        double.TryParse(Console.ReadLine(),out double price);
                        Console.Write("Enter Book Stock Size-");
                        int.TryParse(Console.ReadLine(), out int inStock);
                        Console.Write("Enter Book Genre-");
                        string genre=Console.ReadLine()??"";
                        Book book = new Book(id, name, pagesize, price,inStock,genre);
                        DataBase.AddDb(book);
                        Console.ReadLine();
                        break;
                        
                    case 6:
                        Console.Clear();
                        DataBase.ShowAnbar();
                        Console.ReadLine();
                        break;



                }   
            }
         

        }
        
        public void ChangeProductInfo()
        {

            Console.WriteLine("1.Change Name");
            Console.WriteLine("2.Change Genre");
            Console.WriteLine("3.Change Pagesize");
            Console.WriteLine("4.Change StockSize");
            Console.WriteLine("5.Change Price");

        }

    }
}
