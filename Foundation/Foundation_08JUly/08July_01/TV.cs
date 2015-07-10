using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08july_01
{
    class TV
    {
        private string remote;
        private string powerSupply;
        //private string soundSystem;
        
        public TV(string remote, string powerSupply)
        {
            this.remote = remote;
            this.powerSupply = powerSupply;
        }


        public void Log()
        {
            //Console.WriteLine("Remote is {0}", remote);
            //Console.WriteLine("Pwer Supply is {0}", powerSupply);
            //Console.WriteLine("Sound System is "+this.SoundSystem);
            Log(true, true, true);
        }

        private void Log(bool isRemote, bool isPowerSupply, bool isSoundSystem)
        {
            if (isRemote)
            {
                Console.WriteLine("Remote is {0}", remote);
            }
            if (isPowerSupply)
            {
                Console.WriteLine("Power Supply is {0}", powerSupply);
            }
            if (isSoundSystem)
            {
                Console.WriteLine("Sound System is " + this.SoundSystem);
            }

        }

        public void Log(bool isRemote)
        {
            Log(true, false, false);
        }

        //public void SetSoundSystem(string soundSystem)
        //{
        //    this.soundSystem = soundSystem;
        //}

        //public string GetSoundSystem()
        //{            
        //    return this.soundSystem;
        //}

        //public string SoundSystem
        //{
        //    get
        //    {
        //        return this.soundSystem;
        //    }
        //    set
        //    {
        //        this.soundSystem = value;
        //    }
        //}
        public string SoundSystem { set; get; }
    }
}
