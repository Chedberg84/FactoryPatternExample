using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        public Circle()
        {
            base.Name = "Circle Object";
        }

        public Circle(string name)
        {
            base.Name = name;
        }

        public Circle(CircleData data)
        {
            base.Name = data.name_data;
        }
    }


    public class CircleData
    {
        public string name_data { get; set; }

        public CircleData(string name)
        {
            name_data = name;
        }
    }
}
