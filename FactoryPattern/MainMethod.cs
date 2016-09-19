using System;
using System.Collections.Generic;
using System.Linq;
using Animals;
using Cars;
using Shapes;

namespace FactoryPattern
{
    public static class MainMethod
    {

        public static void Main(string[] args)
        {
            var shapeFactory = new Factory<Shape>();
            
            Shape s = shapeFactory.CreateObject("Circle");
            Console.WriteLine("Shape = " + s.Name);
            
            Shape t = shapeFactory.CreateObject("Triangle");
            Console.WriteLine("Shape = " + t.Name);

            Shape z = shapeFactory.CreateObject(typeof(Circle), "Circle With Args!");
            Console.WriteLine("Shape = " + z.Name);
            Console.WriteLine(z.GetType());
            var zz = (Shape)z;
            Console.WriteLine(zz.GetType());

            Shape x = shapeFactory.CreateObject(typeof(Circle), new CircleData("CircleData Name Args!"));
            Console.WriteLine("Shape = " + x.Name);

            Console.WriteLine("");
            Console.WriteLine("");

            var animalFactory = new Factory<Animal>();

            Animal dog = animalFactory.CreateObject(typeof(Dog));
            Console.WriteLine("Animal = " + dog.Name);

            Console.WriteLine("");
            Console.WriteLine("");

            var carFactory = new Factory<Car>();

            Car car = carFactory.CreateObject(typeof(BMW));
            Console.WriteLine("Car = " + car.Name);

            TestMethod();

            Console.ReadLine();
        }

        //Test the building of a multi-map
        public static void TestMethod()
        {
            //use animal project for reflection
            StaticFactories.AnimalFactory.CreateObject();
        }
    }

    
}
