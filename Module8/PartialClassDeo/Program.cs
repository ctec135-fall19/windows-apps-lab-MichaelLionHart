using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDeo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass(123);
            mc.printState();
        }
    }
}
