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
                int value;
                //int value = int.Parse(Console.ReadLine());
                if(!int.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine("Enter valid Value");
                   // continue;
                    break;
                }
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
                        DisplayRemoteWork(toy as IRemoteWork);
                        DisplayToy(toy);
                        StopWork(toy as IWork);
                    }
                    else 
                    {
                        Console.WriteLine("Electrical");
                        //DisplayWork(toy as IWork);
                        StartWork(toy as IWork);
                        DisplayToy(toy);
                        StopWork(toy as IWork);
 
                    }
                }
                else
                {
                    Console.WriteLine("Animal");
                    DisplayToy(toy);
                }

            } while (toBeContinue);
        }

        static void DisplayWork(IWork work)
        {
            StartWork(work);
            StopWork(work);
        }

        private static void StopWork(IWork work)
        {
            work.Stop();
        }

        private static void StartWork(IWork work)
        {
            work.Start();
        }

        static void DisplayRemoteWork(IRemoteWork remoteWork)
        {
            StartWork(remoteWork);
            remoteWork.ControlUsingRemote();
            
        }
        

        static void DisplayToy(IToy toy)
        {
            toy.MakeSound();
        }
    }
}
