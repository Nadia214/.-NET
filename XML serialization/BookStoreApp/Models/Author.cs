using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string Name { get; set; }

        private int cnt;
        public int TotalBooks
        {
            get
            {
                return this.cnt;
            }
            set
            {
                if (value < 0)
                {

                    throw new ArgumentOutOfRangeException("cant be negative or 0\n");
                }
                else
                {
                    // Valid value.
                    this.cnt = value;
                }
            }
        }

        public DateTime DateOfBirth { get; set; }
        public int Age
        { // Auto-calculated property
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
        public int InfoId;
        public BookAdditionalInfo Info;
        public List<Book> Books { get; set; }

        public Author()
        {
            this.Books = new List<Book>();

        }

        public Author(int id, String name,int totalBook, DateTime dob)
        {
            this.Books = new List<Book>();
            this.ID = id;
            this.Name = name;
            this.cnt = totalBook;
            this.DateOfBirth = dob;

        }

        public Author(int id, String name, int totalBook, DateTime dob, BookAdditionalInfo info, List<Book> books)
        {
            this.Books = new List<Book>();
            this.ID = id;
            this.Name = name;
            this.cnt = totalBook;
            this.DateOfBirth = dob;
            this.Info = info;
            this.InfoId = info.ID;
            this.Books.AddRange(books);

        }

        //An overridden ToString method.
        public override string ToString()
        {
            return $"AuthoId :{this.ID}\n" +
                   $"AuthorNane :{this.Name}\n" +
                   $"AuthorEmail:{this.Info.Email}\n";
        }
    }

    public class BookAdditionalInfo
    {
        public int ID { get; set; }
        public string Colledge { get; set; }
        public string University { get; set; }
        public string Email { get; set; }


    }
}
