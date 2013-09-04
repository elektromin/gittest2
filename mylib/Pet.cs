using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mylib
{
    public class Pet
    {
        public Person Owner { get; set; }

        public string Name { get; set; }
    }

    public class Person
    {
        public string Name { get; set; }
    }
}
