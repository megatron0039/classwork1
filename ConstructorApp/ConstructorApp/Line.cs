using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorApp
{
    class Line
    {
        private double length; //Length of a line

        public Line()
        {
            Console.WriteLine("Object is the being created");

        }

        public void SetLength(double len)
        {
            length = len;

        }


        public double GetLength()
        {
            return length;


        }
        static void Main(string[] args)
        {

            Line line = new Line();

            //set line length
            line.SetLength(6.0);
            Console.WriteLine("Length of line : {0}", line.GetLength());
            Console.ReadKey();
        }
    }
}
