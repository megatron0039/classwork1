using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace RectangleApplicaton
{
        //Add classes 1st, collapse all classes not being used.
        

    class Rectangle
    {
        //Member variables 
        public double length;
        public double width;

        public void AcceptDetails()
        {
            length = 4.5;
            width = 3.5;
        }
        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length : {0}", length);
            Console.WriteLine("Width : {0}", width);
            Console.WriteLine("Area : {0}", GetArea());
            ReadKey();
        }
    }

    class Square
    {
        //Member variables
        //globally accessible
        public double length;
        public double width;


        public void AcceptDetails()
        {
            length = 4.5;
            width = 4.5;
        }
        public double GetArea()
        {

            return length * width;
        }

        public void Display()
        {

            Console.WriteLine("Length : {0}", length);
            Console.WriteLine("Width : {0}", width);
            Console.WriteLine("Area : {0}", GetArea());
            ReadKey();
        }
        class Triangle
        {
            //Member variables
            public double length;
            public double width;

            public void AcceptDetails()
            {
                length = 4.5;
                width = 3.5;
            }

            public double GetArea()

            {
                return length + length + width;

            }

        }

        class Octagon
        {
            //Member variables
            public double length;
            public double width;

            public void AcceptDetails()
            {

                length = 4.5;
                width = 3.5;
            }

            public double GetArea()
            {
                return length * width;


            }

        }

        //main method is here
        class ExcuteRetangle
        {
            static void Main(string[] args)
            {
                Rectangle r = new Rectangle();
                Square s = new Square();
                Triangle t = new Triangle();
                Octagon o = new Octagon();

                r.length = 4.5;
                r.width = 3.5;
                r.AcceptDetails();
                r.Display();
                Console.WriteLine("Total area : {0}", r.GetArea());
                Console.ReadKey();

                s.length = 4.5;
                s.width = 3.5;
                s.AcceptDetails();
                s.Display();
                Console.ReadLine();


            }
        }
    }
}

