using System;

namespace tpmodul4_1302200040
{
    class Program
    {
        static void Main(string[] args)
        {
            String X, Y;
            X = "Rian";
            Y = "";
            HaloGeneric<String> halo = new HaloGeneric<string>();
            halo.SapaUser<String>(ref X, ref Y);
            Console.WriteLine("Halo User " + Y);

            DataGeneric data = new DataGeneric();
            data.PrintData();
        }
    }
}
