﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10july_02
{
    class CRTMonitor:Monitor
    {
        public override void Start()
        {
            Console.WriteLine("CRT Monitor Started");
        }

        public override void Stop()
        {
            Console.WriteLine("CRT Monitor Stopped");

        }

        public override void Identify()
        {
            Console.WriteLine("CRT Monitor ");
        }
    }
}
