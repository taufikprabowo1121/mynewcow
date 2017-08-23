using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewCow
{
  public class MyNewCow
    {
        private string name;
        private int numberofFoot = 4;
        private int age = 0;

       public void ChangeName(String NewName)
        {
            name = NewName;
        }
        public string LookingName()
        {
            return name;
        }
        public int LookingFootNumber()
        {
            return numberofFoot;
        }
        public int LihatUmur()
        {
            return age;
        }
        public void Makan()
        {
            Console.WriteLine("{0} Sedang Makan :", name);
        }
        public void Jalan()
        {
            Console.WriteLine("{0} Sedang Jalan :", name);

        }
        public void Bobo()
        {
            Console.WriteLine("{0} Sedang Bobo :", name);
        }
    }
}
