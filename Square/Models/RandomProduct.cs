using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Square.Models
{
    public class Testvalue
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public Testvalue(string name, int value)
        {
            Name = name;
            Value = value;

        }

        public int RandomProduct(int Testvalue)
        {
            Random rnd = new Random();
            int prod = rnd.Next();
            return (Testvalue * prod);

        }

   
    }

}
