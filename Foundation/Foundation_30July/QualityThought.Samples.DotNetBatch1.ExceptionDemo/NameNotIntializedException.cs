using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityThought.Samples.DotNetBatch1.ExceptionDemo
{
    public class NameNotIntializedException:Exception
    {
        public NameNotIntializedException(string message,string testMessage):base(message+testMessage)
        {

        }
    }
}
