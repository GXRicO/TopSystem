using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSystem
{
    public abstract class Shape
    {
        public abstract void Draw();
    }
    public  class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Circle");
          
        }
    }
    public class Ellipse : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Ellipse") ;
        }
    }

    public class Triangle : Shape 
    {
        public override void Draw()
        {
            Console.WriteLine("Triangle");
        }
    }

    public class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Square");
        }
    }


    internal class Program
    {

        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[]
            {
                new Circle(),
                new Ellipse(),
                new Triangle(),
                new Square()
            };

            foreach (Shape shape in shapes) 
            {
                shape.Draw();
            }

        }
    }
}
