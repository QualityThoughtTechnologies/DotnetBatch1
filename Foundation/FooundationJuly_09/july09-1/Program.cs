
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace july09_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ElectricToy e = new ElectricToy();
            e.Run();
            e.MakeSound();
                
            Display(e);
            
            Toy tOld = new Toy();
//            tOld.isAnimal = true;
            Display(tOld);
            //tOld.Run();
            //tOld.MakeSound(); 

            Toy t=new ElectricToy();
            Display(t);
            //t.Run();
            //t.MakeSound();
        }
        static void Display(Toy e)
        {
            e.Run();
            e.MakeSound();
        }
    }
}
