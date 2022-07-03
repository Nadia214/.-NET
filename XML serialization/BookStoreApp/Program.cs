using System;
using System.Collections.Generic;

using BookStoreApp.Models;
using System.IO;
using System.Xml.Serialization;


namespace BookStoreApp
{
    public class Program
    {

		static string root = "D:\\test\\";
		static void Main(string[] args)
        {


			if (!Directory.Exists(root))
				Directory.CreateDirectory(root);

			CustomerAddress customerAddress1 = new CustomerAddress();
			customerAddress1.ID = 1;
			customerAddress1.AddressLine = "403 road";
			customerAddress1.City = "ottowa";
			//==
			CustomerAddress customerAddress2 = new CustomerAddress();
			customerAddress2.ID = 2;
			customerAddress2.AddressLine = "410 road";
			customerAddress2.City = "salt city";
			//==
			CustomerAddress customerAddress3 = new CustomerAddress();
			customerAddress3.ID = 3;
			customerAddress3.AddressLine = "343 raod";
			customerAddress3.City = "toronto";

			Book book1 = new Book();
			book1.ID = 101;
			book1.Title = "hunter";
			book1.Quantity = 1000;
			book1.Price = 220.20;

			Book book2 = new Book();
			book2.ID = 102;
			book2.Title = "productivity";
			book2.Quantity = 1000;
			book2.Price = 320.20;

			Book book3 = new Book();
			book3.ID = 101;
			book3.Title = "new light";
			book3.Quantity = 1000;
			book3.Price = 400.20;

			List<Book> books = new List<Book>();
			books.Add(book1);
			books.Add(book2);
			books.Add(book3);

			Order order1 = new Order(1, "A", new DateTime(1995, 4, 29), 1, customerAddress1, books);
			Order order2 = new Order(2, "B", new DateTime(1994, 4, 7), 2, customerAddress2, books);
			Order order3 = new Order(3, "C", new DateTime(1995, 4, 12), 3, customerAddress3, books);


			List<Order> orderList = new List<Order>();
			try {

				Create(order1);
				Create(order2);
				Create(order3);
				// something change
				order1 = new Order(1, "A", new DateTime(1995, 4, 29), 2, customerAddress1, books);
				Update(order1);
				Delete(order2.OrderID.ToString());
				Order order = Get(order3.OrderID.ToString());
				
				orderList = GetAll();


			}
			catch {

				Console.WriteLine("	Error happened");

			}	

		}

		public static void Create(Order order)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Order));

			using (Stream stream = new FileStream($"{root}{order.OrderID}.xml", FileMode.Create))
			{
				serializer.Serialize(stream, order);
			}

			Console.WriteLine($"successfully created : {order.OrderID}");
		}

		public static Order Get(string OrderId)
		{
			string filename = $"{root}{OrderId}.xml";
			XmlSerializer serializer = new XmlSerializer(typeof(Order));

			if (File.Exists(filename))
			{
				using (Stream stream = new FileStream(filename, FileMode.Open))
				{
					Order order = (Order)serializer.Deserialize(stream);
					Console.WriteLine($"successfully deserialized:{order.OrderID}");
					return order;
				}

				
			}
			else
			{
				throw new Exception($"ERROR: Tried to load an account that does not exist ({OrderId}).");
			}
		}

		public static List<Order> GetAll()
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Order));
			string[] files = Directory.GetFiles(root);
			List<Order> orders = new List<Order>();

			foreach (string file in files)
			{
				using (Stream stream = new FileStream(file, FileMode.Open))
				{
					Order order = (Order)serializer.Deserialize(stream);
					Console.WriteLine("\nsuccessfully deserialized started");
					Console.WriteLine($"successfully deserialized:{order.OrderID}");
					orders.Add(order);
				}
			}
			Console.WriteLine("successfully deserialized ended\n");

			return orders;
		}

		public static void Update(Order order)
		{
			Console.WriteLine($"\nupdation start ::::--------{order.OrderID}");
			Delete(order.OrderID.ToString());
			Create(order);
			Console.WriteLine($"successfully updated:::::-------{order.OrderID}\n\n");
		}

		public static void Delete(string OrderID)
		{
			string filename = $"{root}{OrderID}.xml";

			if (File.Exists(filename))
			{
				File.Delete(filename);
				Console.WriteLine($"successfully deleted: {OrderID}");
			}
			else
				throw new Exception($"ERROR: Tried to delete an account that does not exist ({OrderID}).");
		}

	}
}
