using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Animals;

namespace FactoryPattern
{
    public static class StaticFactories
    {
        public static Factory<Animal> AnimalFactory = new Factory<Animal>();
    }
}
