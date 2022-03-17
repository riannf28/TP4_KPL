using System;
using System.Collections.Generic;
using System.Text;

namespace tpmodul4_1302200040
{
    class DataGeneric
    {
        public void Data<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        public void PrintData()
        {
            String X, Y;
            X = "1302200040";
            Y = "";
            Data<String>(ref X, ref Y);
            Console.WriteLine("Data yang tersimpan adalah : " + Y);
        }
    }
}

