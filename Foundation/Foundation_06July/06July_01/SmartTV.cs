using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06July_01
{
    class SmartTV
    {
        private string remote;
        private string powerSupply;
        public SmartTV():this("LG","AC")
        {
            
        }

        public SmartTV(string remote,string powerSupply)
        {
            this.remote = remote;
            this.powerSupply = powerSupply;
        }

        public SmartTV(string remote):this(remote,"AC")
        {
            
           
        }

        public void Log()
        {
            Console.WriteLine("Remote is {0}", remote);
            Console.WriteLine("Pwer Supply is {0}", powerSupply);
        }
    }
}
