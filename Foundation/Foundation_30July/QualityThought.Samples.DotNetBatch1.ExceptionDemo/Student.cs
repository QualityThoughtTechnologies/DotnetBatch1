using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityThought.Samples.DotNetBatch1.ExceptionDemo
{
    class Student
    {
        public string Name { get; set; }

        /// <summary>
        /// This shows details
        /// </summary>
        /// <exception cref="InvalidOperationException">
        /// An Invalid Operation Exception is thrown when name is empty
        /// </exception>
        public void GetDetails()
        {
            if(string.IsNullOrWhiteSpace(Name))
            {
                throw new NameNotIntializedException("Please Enter a valid Name"," Test names are test,test2");
            }
        }
    }
}
