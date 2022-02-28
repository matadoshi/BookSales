using System;
using System.Collections.Generic;
using System.Text;

namespace BookMarke
{
    class DataBase
    {
        public static Dictionary<int,Book> Db =new Dictionary<int, Book>();
        public static void AddDb(Book item) 
        {
            Db.Add(item.Id, item);
        
        
        }
        public static void ShowAnbar()
        {
            foreach (KeyValuePair<int,Book> item in Db)
            {
                Console.Write($"Id.{item.Key}\nProduct Name: {item.Value.Name}\nProduct Price: {item.Value.Price}\n" +
                     $"PageSize: {item.Value.PageSize}\nProduct size in Stock: {item.Value.InStock}\nBook Genre: {item.Value.Genre}\n");
            }
        }
        public static void ChangeInfo(int id,string new_value,char choice)
        {
            switch (choice)
            {
                case 'n':
                    foreach (KeyValuePair<int,Book> item in Db)
                    {   if(item.Key == id)
                        {
                            Console.WriteLine($"{item.Value.Name} book  has been changed {new_value}");
                          

                            item.Value.Name=new_value;
                            Console.ReadLine();
                            break;
                        }
                      


                    }
                    break;
                case 'g':
                    foreach (KeyValuePair<int, Book> item in Db)
                    {
                        if (item.Key == id)
                        {

                            Console.WriteLine($"{item.Value.Genre} book  has been changed {new_value}");
                            item.Value.Genre = new_value;
                            Console.ReadLine();
                            break;
                        }

                    }
                    break;
            }
        }
        public static void ChangeInfo(int id, int new_value, char choice)
        {
            switch (choice)
            {
                case 'p':
                    foreach (KeyValuePair<int, Book> item in Db)
                    {
                        if (item.Key == id)
                        {

                            Console.WriteLine($"{item.Value.PageSize} book  has been changed {new_value}");

                            item.Value.PageSize = new_value;

                            Console.ReadLine();
                            break;
                        }

                    }
                    break;
                case 's':
                    foreach (KeyValuePair<int, Book> item in Db)
                    {
                        if (item.Key == id)
                        {

                            Console.WriteLine($"{item.Value.InStock} book  has been changed {new_value}");
                            item.Value.InStock = new_value;
                            Console.ReadLine();
                            break;
                        }

                    }
                     break;
            }
        }
        public static void ChangeInfo(int id, double new_price)
        {
            foreach (KeyValuePair<int, Book> item in Db)
            {
                if (item.Key == id)
                {
                    Console.WriteLine($"{item.Value.Price} book  has been changed {new_price}");
                    item.Value.Price =new_price;
                    Console.ReadLine();
                }
            }
        }   
        public static void DeleteProduct(int id)
        {
            Db.Remove(id);
            Console.WriteLine("Product Deleted.");
            Console.ReadLine();
        }
    }
}
