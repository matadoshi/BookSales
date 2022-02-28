using System;
using System.Collections.Generic;
using System.Text;

namespace BookMarke
{
    class Menu
    {
        public int Id;
        public void MenuBar()
        {
          
            Console.BackgroundColor = ConsoleColor.DarkRed;
           
            
      
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
                        Id = EnterId();
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
                        Book book = new Book(Id, name, pagesize, price,inStock,genre);
                        DataBase.AddDb(book);
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        Id = EnterId();
                        Console.Write("Enter book count-");
                        int.TryParse(Console.ReadLine(), out int count);
                        Sell.SellBook(Id, count);
                        break;

                    case 3:
                        Console.Clear();
                        Id=EnterId();
                        ChangeProductInfo(Id);
                        break;
                
                    case 4:
                        Console.Clear();
                        Id=EnterId();
                        DataBase.DeleteProduct(Id);
                        break;
                    case 5:
                 
                        Console.Clear();
                        Sell.ShowInfo();
                        Console.ReadLine();
                        break;


                    case 6:
                        Console.Clear();
                        DataBase.ShowAnbar();
                        Console.ReadLine();
                        break;
                    case 7:
                        return;
                    default:
                        Console.WriteLine("Seciminizi duzgun edin");
                        Console.ReadLine();
                        break;
                    
                }   
            }
         
        }
        
        public void ChangeProductInfo(int id)
        {
            foreach (var item in DataBase.Db)
            {
                if (item.Key == id)
                {
                    Console.Write($"Id.{item.Key}\nProduct Name: {item.Value.Name}\nProduct Price: {item.Value.Price}\n" +
                     $"PageSize: {item.Value.PageSize}\nProduct size in Stock: {item.Value.InStock}\nBook Genre: {item.Value.Genre}\n");
                }
            }

            Console.WriteLine("1.Change Name");
            Console.WriteLine("2.Change Genre");
            Console.WriteLine("3.Change Pagesize");
            Console.WriteLine("4.Change StockSize");
            Console.WriteLine("5.Change Price");
            string value;
            int value_integer;
            double price;


            int.TryParse(Console.ReadLine(), out int choice);


            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Enter Book Name");
                    value = Console.ReadLine()??"";
                    DataBase.ChangeInfo(id, value, 'n');
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Enter new Genre");
                    value = Console.ReadLine();
                    DataBase.ChangeInfo(id, value, 'g');
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Enter Page Size");
                    int.TryParse(Console.ReadLine(),out value_integer);
                    DataBase.ChangeInfo(id, value_integer, 'p');
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Enter New Stock Size");
                    int.TryParse(Console.ReadLine(),out value_integer);
                    DataBase.ChangeInfo(id, value_integer, 's');
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Enter Book Price");
                    double.TryParse(Console.ReadLine(), out price);
                    DataBase.ChangeInfo(id, price);
                    break;
            }

        }
       
        
        public int EnterId()
        {
            Console.Write("Enter Book Id-");
            int.TryParse(Console.ReadLine(), out int Id);
            return Id;
        }

    }
}
