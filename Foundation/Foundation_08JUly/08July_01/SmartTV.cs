using _08july_01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08July_01
{
    class SmartTV:TV
    {
        private string internetConnectivity;
        //public SmartTV():base(null,null)
        //{

        //}

        public SmartTV(string remote,string powerSupply,string internetConnectivity):
            base(remote,powerSupply)
        {
            this.internetConnectivity = internetConnectivity;
        }

        public new void Log()
        {
            Console.WriteLine(internetConnectivity);
        }
        

    }
}
