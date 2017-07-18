using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO get all books here...
            List<Book> books1 = new GetAllBooks();

            Student s = new Student();

            Book b = new Book()
            {
                Isbn = "abc",
                Price = 5,
                Title = "my book!"
            };

            s.Books.Add(b);
            //s.Books = null;

            //demo of inheiritence a learner or instructor is a person
            Person p = new Person();
            Learner l = new Learner();
            Instructor i = new Instructor();
            DisplayPerson(p);
            DisplayPerson(l);
            DisplayPerson(i);

        }

        private void SomeMethod(object a)
        {
            Student s = (Student)a;
            double d = (Double)a;
        }

        private static void DisplayPerson(Person per)
        {
            if (per is Learner)
            {
                Learner l = per as Learner;
            }
            Console.WriteLine($"{per.FirstName} {per.LastName}");
            Console.ReadKey();
        }


    }
}
