using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodechefPractise
{
    internal class Triangle
    {
        int angle1, angle2, angle3, a,b,c ;
        double Tbase, height;


        public void SumOfTriangle()
        {
            Console.WriteLine("Enter three angles: ");
            angle1= Convert.ToInt32(Console.ReadLine());
            angle2= Convert.ToInt32(Console.ReadLine());
            angle3= Convert.ToInt32(Console.ReadLine());

            int sumAngle= angle1+angle2+angle3;
            Console.WriteLine($"Sum of angle of triangle is {sumAngle}\n");

            Console.WriteLine("--- Check Whether it is Triangle or Quadtrilateral ---\n");

            if(sumAngle == 180)
            {
                Console.WriteLine("It is a Triangle.");
            }
            else if(sumAngle == 360)
            {
                Console.WriteLine("It is a Quadrilateral.");
            }
            else
            {
                Console.WriteLine("It is neither a valid triangle nor a valid quadrilateral.");
            }
        }
        public void CalAreaPerimeter()
        {
            double area, peri;
            Console.WriteLine("\n--- Calculate area ---");
            Console.WriteLine("Enter the base and the height of the triangle:");
            Tbase = Convert.ToDouble(Console.ReadLine());
            height = Convert.ToDouble(Console.ReadLine());

            area= (0.5)*(Tbase*height);
            Console.WriteLine($"Area of triangle is: {area}");


            Console.WriteLine("\n--- Calculate perimeter ---");
            Console.WriteLine("Enter three sides of the tiangle: ");
            a= Convert.ToInt32(Console.ReadLine()) ;
            b= Convert.ToInt32(Console.ReadLine()) ;
            c = Convert.ToInt32(Console.ReadLine());

            peri = a + b + c;
            Console.WriteLine($"Perimeter of triangle is: {peri} ");
        }
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            triangle.SumOfTriangle();
            triangle.CalAreaPerimeter();

            Console.ReadKey();
        }
    }
}
