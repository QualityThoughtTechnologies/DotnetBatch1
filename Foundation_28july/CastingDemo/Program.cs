using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyFactory;

namespace CastingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool toBeContinue = true;
            do
            {
                Console.WriteLine("Enter your choice 0,1,2");

                int value = int.Parse(Console.ReadLine());
                ToyEnum toyType;
                if(value==0)
                {
                    toyType = ToyEnum.Animal;
                }
                else if(value==1)
                {
                    toyType = ToyEnum.Electrical;

                }
                else
                {
                    toyType = ToyEnum.Remote;
                }
                IToy toy = ToyFactory.ToyFactory.Create(toyType);
                if(toy is IWork)
                {
                    if(toy is IRemoteWork)
                    {
                        Console.WriteLine("Remote");
                    }
                    else 
                    {
                        Console.WriteLine("Electrical");
 
                    }
                }
                else
                {
                    Console.WriteLine("Animal");
                }

            } while (toBeContinue);
        }
    }
}
