using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gittest2
{
    using mylib;

    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello git");
            var owner = new Person() { Name = "Musse" };
            var pet = new Pet() { Owner = owner, Name = "Pluto" };

        }
    }
}
