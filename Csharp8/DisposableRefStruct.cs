using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class DisposableRefStruct
    {
        ref struct RefStruct
        {
            public int[] Data;

            public void Dispose()
            {
                // release unmanaged resources
            }
        }

        public void UseRefStruct()
        {
            using RefStruct refStruct = new RefStruct();

            using (RefStruct refStruct2 = new RefStruct())
            {

            }
        }
    }
}
