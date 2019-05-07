using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{


    class UsingDecl
    {
        class MyDisposable : IDisposable
        {
            public void Dispose()
            {
            }
        }


        void Something()
        {
            using var disp = new MyDisposable();

        }

    }
}
