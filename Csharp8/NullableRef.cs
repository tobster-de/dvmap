using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class NullableRef
    {
        interface IWeapon
        {
            void Reload();
        }

#nullable enable
        private void Nullable()
        {
            IWeapon? canBeNull;
            IWeapon cantBeNull;

            canBeNull = null;         // no warning
            cantBeNull = null;        // warning
            cantBeNull = canBeNull;   // warning

            canBeNull.Reload();       // warning
            cantBeNull.Reload();      // no warning

            if (canBeNull != null)
            {
                canBeNull.Reload();  // no warning
            }
        }
#nullable restore
    }
}
