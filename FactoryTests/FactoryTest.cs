using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FactoryPattern;
using Shapes;
using Cars;
using Animals;

namespace FactoryTests
{
    [TestClass]
    public class FactoryTest
    {
        [TestMethod]
        public void FactoryReturnsCircleAsShape()
        {
            Factory<Shape> factory = new Factory<Shape>();

            var circle = new Circle();
            var factorycircle = factory.CreateObject(typeof(Circle));

            Assert.AreEqual(circle.GetType(), factorycircle.GetType());
            Assert.IsInstanceOfType(circle, factorycircle.GetType());
        }

        [TestMethod]
        public void FactoryReturnsBMWAsCar()
        {
            Factory<Car> factory = new Factory<Car>();

            var bmw = new BMW();
            var factorybmw = factory.CreateObject(typeof(BMW));

            Assert.AreEqual(bmw.GetType(), factorybmw.GetType());
            Assert.IsInstanceOfType(bmw, factorybmw.GetType());
        }

        [TestMethod]
        public void FactoryReturnsDogAsAnimal()
        {
            Factory<Animal> factory = new Factory<Animal>();

            var dog = new Dog();
            var factorydog = factory.CreateObject(typeof(Dog));

            Assert.AreEqual(dog.GetType(), factorydog.GetType());
            Assert.IsInstanceOfType(dog, factorydog.GetType());
        }
    }
}
