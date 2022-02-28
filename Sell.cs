using System;
using System.Collections.Generic;
using System.Text;

namespace BookMarke
{
    internal class Sell
    {

        private static double _income=0;
        public static double Income
        {
            get
            {
                Console.WriteLine("Enter Password Kassa");
                string password = Console.ReadLine()??"";
                if (password == "4321")
                {
                    return _income;
                }
                else
                {
                    Console.WriteLine("Ogruuuuu!");
                    return 0;

                }
            }
            set
            {
                _income += value;

            }
        }
        public static void SellBook(int id,int count)
        {
            foreach (var item in DataBase.Db)
            {
                if (item.Key == id)
                {
                    if (item.Value.InStock >= count)
                    {
                        item.Value.InStock -= count;
                    
                        Income = item.Value.Price * count;
                        Console.WriteLine($"{item.Value.Name} book  has been sold in {count} size!\n" +
                           $"{item.Value.Name} book InStock - {item.Value.InStock}");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("We don't have enough book to sell!!");
                        Console.ReadLine();
                    }
                }
               

                
            }
        }
        public static void ShowInfo()
        {
            Console.WriteLine($"{Income} azn");
        }
        
    }
    
}
