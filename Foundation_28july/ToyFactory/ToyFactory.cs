using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyFactory
{
    public static class ToyFactory
    {
        public static IToy Create(ToyEnum toyType)
        {
            IToy toyToBeCreated = null;
            switch(toyType)
            {
                case ToyEnum.Animal:
                    toyToBeCreated = new AnimalToy();
                    break;
                case ToyEnum.Electrical:
                    toyToBeCreated = new ElectricalToy();
                    break;
                case ToyEnum.Remote:
                    toyToBeCreated = new RemoteToy();
                    break;
            }
            return toyToBeCreated;
        }
    }
}
