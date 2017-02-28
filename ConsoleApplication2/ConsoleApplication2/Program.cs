using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SquareApplication
{
    class Square
    {
        //number variables
        double length;
        double width;

        public void AcceptDetails()
        {
            length = 3.5;
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
            Console.WriteLine("3.5 :");
            int Number = Convert.ToInt16(Console.ReadLine());
            ReadKey();

        }
    }
        class ExecuteSquare
      {
        static void Main(string[] args)
        {  
            Square = s new Square("length * width");
            s.AcceptDetails();
            s.Display();
            Console.ReadLine();
        }
           
      }

    }
