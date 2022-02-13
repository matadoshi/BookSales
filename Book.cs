using System;
using System.Collections.Generic;
using System.Text;

namespace BookMarke
{
    class Book
    {

        public int Id;
        public string Name;
        public int PageSize;
        public string Genre;
        public double Price;
        public int InStock;

        public Book(int id, string name)
        {
            Id = id;
            Name = name;
            Console.WriteLine("New Book Created");
        }

        public Book(int id,string name,int pagesize,double price,int inStock):this(id,name)
        {
            PageSize = pagesize;
            Price = price;
            InStock = inStock;

        }
        public Book(int id, string name, int pagesize, double price, int inStock,string genre):this(id,name,pagesize,price,inStock)
        {
            Genre = genre;
           
        }



    }
}
