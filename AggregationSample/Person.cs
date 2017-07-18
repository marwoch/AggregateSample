using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationSample
{
    class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
    //inherits from person
    class Learner : Person
    {
        public string HomeRoom { get; set; }
    }
    //inherits from person
    class Instructor : Person
    {
        public string OfficeLocation { get; set; }
    }
}
