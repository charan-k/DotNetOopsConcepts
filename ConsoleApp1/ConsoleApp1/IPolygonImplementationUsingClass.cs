using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concepts_Modules
{
    class Rectangle : IPolygon
    {

        // implementation of IPolygon interface
        public void calculateArea()
        {

            int l = 30;
            int b = 90;
            int area = l * b;
            Console.WriteLine("Area of Rectangle: " + area);
        }
    }

    class Square : IPolygon
    {

        // implementation of IPolygon interface
        public void calculateArea()
        {

            int l = 30;
            int area = l * l;
            Console.WriteLine("Area of Square: " + area);
        }
    }

}
