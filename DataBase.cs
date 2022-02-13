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
            foreach (var item in Db)
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
                            item.Value.Name=new_value;
                            break;
                        }

                    }
                    break;
                case 'g':
                    foreach (KeyValuePair<int, Book> item in Db)
                    {
                        if (item.Key == id)
                        {
                            item.Value.Genre = new_value;
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
                            item.Value.PageSize = new_value;
                            break;
                        }

                    }
                    break;
                case 's':
                    foreach (KeyValuePair<int, Book> item in Db)
                    {
                        if (item.Key == id)
                        {
                            item.Value.InStock = new_value;
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
                   item.Value.Price =new_price;    
                }
            }
        }   
   



        }
}
