using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace _07.Timer
{
    public class Test
    {
        static void Main()
        {
            int i = 0;

            Console.WriteLine("Start timer result: " + i);
            Timer t = new Timer(delegate() { i++; Console.WriteLine(i); }, 500);

            t.Start();
            // timer working 5 seconds
            Thread.Sleep((int)3000);
            t.Stop();
            Console.WriteLine("Stop timer result: " + i);
        }
    }
}

