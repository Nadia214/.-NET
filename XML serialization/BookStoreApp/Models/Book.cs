using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
		private int BookQuantity;
		public int Quantity
		{
			get
			{
				return this.BookQuantity;
			}
			set
			{
				if (value < 0)
				{

					throw new ArgumentOutOfRangeException("book out of stock\n");
				}
				else
				{
					// Valid value.
					this.BookQuantity= value;
				}
			}
		}

		public double Price { get; set; }
		public int BookAuthorId { get; set; }

        public Author Author { get; set; }

        public List<Order> Orders { get; set; }

		public Book()
        {
			Orders = new List<Order>();
        }

		public Book(int id, string title, int quantity, double price)
		{
			Orders = new List<Order>();
			this.ID = id;
			this.Title = title;
			this.Quantity = quantity;
			this.Price = price;
		}

		public Book(int id, string title, int quantity, double price, Author author, List<Order> order)
		{
			Orders = new List<Order>();
			this.ID = id;
			this.Title = title;
			this.Quantity = quantity;
			this.Price = price;
			this.Author = author;
			this.BookAuthorId = author.ID;
			this.Orders = order;
		}

		//An overridden ToString method.
		public override string ToString()
		{
			return $"BookId :{this.ID}\n" +
				   $"BookNane :{this.Title}\n" +
				   $"Quantity:{this.Quantity}\n" +
				   $"price:{this.Price}\n";
		}
	}
}
