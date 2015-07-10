using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06July_01
{
    class TV
    {
        private string remote;
        private string powerSupply;
        //public TV()
        //{
        //    remote = "LG";
        //    powerSupply = "AC";
        //}

        public TV(string remote,string powerSupply)
        {
            this.remote = remote;
            this.powerSupply = powerSupply;
        }

        //public TV(string remote)
        //{
            
        //    this.remote = remote;
        //    powerSupply = "AC";
        //}

        public void Log()
        {
            Console.WriteLine("Remote is {0}", remote);
            Console.WriteLine("Pwer Supply is {0}", powerSupply);
        }
    }
}
