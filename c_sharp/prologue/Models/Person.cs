using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prologue.Models
{
    public class Person
    {
        public string Name {get; set;} = string.Empty;
        public int Age {get; set;}

        public void Show() {
            Console.
            WriteLine($"Hello, my name is {Name} and I'm {Age} age!");
        }
        
    }
}