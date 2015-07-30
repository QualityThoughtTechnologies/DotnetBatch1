using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QualityThought.Samples.DotNetBatch1.NamespaceLibrary.Sub2;
using NamespaceLibrary1 = QualityThought.Samples.DotNetBatch1.NamespaceLibrary1;

namespace QualityThought.Samples.DotNetBatch1.NamespaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            QualityThought.Samples.DotNetBatch1.NamespaceLibrary.Sub1.Test1 test1 = new NamespaceLibrary.Sub1.Test1();
            Test2 test2 = new Test2();
            QualityThought.Samples.DotNetBatch1.NamespaceLibrary1.Test2 test2FromOtherAssembly = new QualityThought.Samples.DotNetBatch1.NamespaceLibrary1.Test2();
            NamespaceLibrary1.Test2 testUsingAlias = new NamespaceLibrary1.Test2();
        }
    }
}
