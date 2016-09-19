using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animals
{
    public class Animal
    {
        public string Name { get; set; }

        public Animal()
        {

        }

        public abstract NewAnimal Process(Animal A, Animal B);
    }
}
