using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animals
{
    public class Dog : Animal
    {
        public Dog()
        {
            base.Name = "Dog One";
        }

        public NewAnimal Process(Animal A, Animal B)
        {
            NewAnimal output = new NewAnimal();
            return output;
        }
    }
}
