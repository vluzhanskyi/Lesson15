using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson15
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer();

            Thread thred1 = new Thread(p.Talk);
            thred1.Start();
            thred1.Abort();
            Thread thred2 = new Thread(p.Is);
            thred2.Start();
            thred2.Abort();
            Thread thred3 = new Thread(p.Cheap);
            thred3.Start();
            thred3.Abort();
            Console.ReadKey();
        }
    }
}
