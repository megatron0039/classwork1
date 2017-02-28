using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{

    //Base Class
    class Shape
    {
        protected int width;
        protected int height;

        public void SetWidth(int w)
        {
            width = w;

        }

        public void SetHeight(int h)

        {
            height = h;
        }
    }
    //derived class below named Rectangle

     class Rectangle : Shape
    {


         public int GetArea()
        {

         return (width * height);
        }


    }
     class RetangleTester

    {
        static void Main(string[] args)
        {

         Rectangle r = new Rectangle();

          r.SetWidth(5);
          r.SetHeight(7);

          //Print the area of the object.
          Console.WriteLine("Total area: {0}", r.GetArea());
          Console.ReadKey();
        }
    }
}
