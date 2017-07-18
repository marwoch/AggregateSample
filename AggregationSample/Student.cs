using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationSample
{
    class Student
    {
        private List<Book> _books;

        public Student()
        {
            Books = new List<Book>();
        }

        public int StudentID { get; set; } //0

        public string Name { get; set; } //null

        
        public List<Book> Books
        {
            get { return _books; }
            set
            {
                if (value == null)
                    throw new NullReferenceException();

                _books = value;
            }
            
        }
    }

    class Book
    {
        public string Isbn { get; set; }

        public double Price { get; set; }

        public string Title { get; set; }
    }
}



