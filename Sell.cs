using System;
using System.Collections.Generic;
using System.Text;

namespace BookMarke
{
    internal class Sell
    {

        private double _income=0;
        public double InCome
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
        
    }
    
}
