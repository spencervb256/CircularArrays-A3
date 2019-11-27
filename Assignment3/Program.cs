using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {

            CircularArray<String> Demo;
            int numelemnts = 5;
            Demo = new CircularArray<String>(numelemnts);

            //Demo.Delete();
            Demo.AddFront("Richard", 1);

            //Demo.removeFront(); works by itself on a line, the result just doesn't go anywhere.
            //Demo.GetFront();
            //Demo.Delete();
            Demo.AddFront("Brian", 2);


            //CHECK THAT BRIAN GETS ADDED IN FRONT OF RICHARD

            /*Demo.AddBack("Bonnie");
            //Demo.GetFront();
            Demo.AddBack("Sabine");
            Demo.AddBack("Jamie");
            Demo.AddBack("Wenying");
            Demo.AddBack("Omar");
            //Console.WriteLine(Demo.GetFront());

            Demo.Grow(numelemnts * 2);

            Demo.AddBack("Wenying");
            Demo.AddBack("Omar");

    */

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Demo.GetFront());
                Demo.Delete();
            }


            Console.ReadLine();
        }
    }
}
