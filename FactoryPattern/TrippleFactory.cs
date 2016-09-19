using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    public class TrippleFactory
    {
        //public Func<Type, Type, Type> map = new Func<Type, Type, Type>();
        public Dictionary<Type, Pair<Type, Type>> map = new Dictionary<Type, Pair<Type, Type>>();
        
        public TrippleFactory()
        {
            //Get the static map of all animals

            //loop through each object and build a pair

            //then save the final values into the map in this class
        }

        public Type GetMapping(Type A, Type B)
        {
            Pair<Type, Type> p = map[A];
            Type output = p.map[B];
            return output;
        }
    }



    public class Pair<T, U>
    {
        public Dictionary<T, U> map = new Dictionary<T,U>();

        public Pair()
        {
        
        }
    }
}
