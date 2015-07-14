using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwardeLibrary
{
    /// <summary>
    /// This interface represents the hardwared device
    /// </summary>
    public interface IHardwareDevice
    {
        /// <summary>
        /// This method should describe the hardware
        /// </summary>
        /// <returns></returns>
        string Describe();

        /// <summary>
        /// Manufacturer Details
        /// </summary>
        string Manufacturer { set; get; }

        /// <summary>
        /// Industry Name 
        /// </summary>
        string IndustryName { set; get; }
    }
}
