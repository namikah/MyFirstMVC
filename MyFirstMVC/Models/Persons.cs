using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstMVC.Models
{
    public class Persons
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname} ({Age})";
        }
    }
}
