using HeadFirstDesignPattern.TenthChapter;
using System;

namespace HeadFirstDesignPattern.EvelethChapter
{
    internal class GumballMachineTestDrive
    {
        public static void Main(string[] args)
        {
            int count = 0;

            if (args.Length < 2)
            {
                Console.WriteLine("GumballMachine  <name>  <invetory>");
                throw new Exception();
            }

            count = int.Parse(args[1]);
            GumballMachine gumballMachine = new GumballMachine(args[0], count);

            GumballMonitor monitor = new GumballMonitor(gumballMachine);

            monitor.Report();
        }
    }
}
