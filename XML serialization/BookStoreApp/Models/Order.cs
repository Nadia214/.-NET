
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.Models
{
    public class Order
    {
        public int OrderID { get; set; }
		public string Name { get; set; }

		public DateTime DateOfBirth { get; set; }
		public int CustomerAge
		{
			get
			{
				int age = DateTime.Now.Year - this.DateOfBirth.Year;

				if (DateTime.Now.DayOfYear < this.DateOfBirth.DayOfYear)
				{
					age--;
				}

				return age;
			}
		}
		public int CustomerID { get; set; }
		public CustomerAddress Address { get; set; }

		private int CategoryID;
		public int CategoryId {
			get
			{
				return this.CategoryID;
			}
			set
			{

				if (value < 0)
				{
					throw new Exception("catagory can be neagative");

				}
				else
				{
					this.CategoryID = value;
				}
			}
		}

		public List<Book> Books { get; set; }

		public Order()
		{
			this.Books = new List<Book>();

		}

		public Order(int orderID, String name, DateTime dob, int CategoryID)
		{
			this.Books = new List<Book>();
			this.OrderID = orderID;
			this.Name = name;
			this.DateOfBirth = dob;
			this.CategoryID = CategoryID;

		}

		public Order(int orderID, String name, DateTime dob, int CategoryID, CustomerAddress address, List<Book> books)
		{
			this.Books = new List<Book>();
			this.OrderID = orderID;
			this.Name = name;
			this.DateOfBirth = dob;
			this.CategoryID = CategoryID;
			this.Address = address;
			this.CustomerID = address.ID;
			this.Books = books;
		}

		public override string ToString()
		{
			return $"orderId :{this.OrderID}\n" +
				   $"CustomerName :{this.Name}\n" +
				   $"Age:{this.CustomerAge}\n" +
				   $"AddressLine:{this.Address.AddressLine}\n" +
				   $"city:{this.Address.City}\n" +
				   $"postelcode:{this.Address.PostalCode}\n";
				 
		}
	}

	public class CustomerAddress
	{
		public int ID { get; set; }
		public string AddressLine { get; set; }
		public string City { get; set; }
		public string PostalCode { get; set; }

	}
}
