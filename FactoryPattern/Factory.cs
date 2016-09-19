using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FactoryPattern
{
    public class Factory<T> where T : class
    {
        private Dictionary<string, Type> map =
            new Dictionary<string, Type>();

        //http://tranxcoder.wordpress.com/2008/07/11/a-generic-factory-in-c/
        public Factory()
        {
            Type[] types = Assembly.GetAssembly(typeof(T)).GetTypes();

            foreach (Type type in types)
            {
                if (!typeof(T).IsAssignableFrom(type) || type == typeof(T))
                {
                    continue; //keep searching through the assembly
                }

                //add to the map
                map.Add(type.Name, type);
            }
        }

        public T CreateObject(string shapeName, params object[] args)
        {
            return ActivatorCreateInstance(shapeName, args);
        }

        public T CreateObject(Type type, params object[] args)
        {
            return ActivatorCreateInstance(type.Name, args);
        }

        private T ActivatorCreateInstance(string Name, params object[] args)
        {
            try
            {
                return (T)Activator.CreateInstance(map[Name], args);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }

    }
}
