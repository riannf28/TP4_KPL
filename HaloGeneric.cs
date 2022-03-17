using System;
using System.Collections.Generic;
using System.Text;

namespace tpmodul4_1302200040
{
    class HaloGeneric<T>
    {
        public void SapaUser<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        } 
    }
}
