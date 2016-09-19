using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animals
{
    public class Cat : Animal
    {

        public Cat()
        {
            base.Name = "Cat One";
        }

        public NewAnimal Process(Animal A, Animal B)
        {
            NewAnimal output = new NewAnimal();
            return output;
        }
    }
}
