using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticLocalFunction slf = new StaticLocalFunction();

            slf.MethodWithStaticLocalFunction(4711);
        }
    }
}
