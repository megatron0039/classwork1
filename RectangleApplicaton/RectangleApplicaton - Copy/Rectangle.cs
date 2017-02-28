using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace RectangleApplicaton
{
    class Rectangle
    {
        //number variables 
        double length;
        double width; 

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
            Console.WriteLine("Width :  {0}", width);
            Console.WriteLine("Area : {0}", GetArea());
            ReadKey();
        }
    }
        class ExcuteRetangle
     {
          static void Main(string[] args)
              {
                Rectangle r = new Rectangle();
                r.AcceptDetails();
                r.Display();
                Console.ReadLine();
              }

          }

     }
 

