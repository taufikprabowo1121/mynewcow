using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewCow
{
    class Program
    {
        static void Main(string[] args)
        {
            MyNewCow sapi = new MyNewCow();
            sapi.ChangeName("Unyil");

            Console.WriteLine("My cow name is {0}.", sapi.LookingName());
            Console.WriteLine("The number of feet are {0}", sapi.LookingFootNumber());
            Console.WriteLine("The age is {0}", sapi.LihatUmur());

            sapi.Jalan();
            sapi.Makan();
            sapi.Bobo();
            Console.ReadKey();
        }
    }
}
