﻿using System;

namespace HeadFirstDesignPattern.TenthChapter
{
    internal class GumballMachineTestDrive
    {
        //public static void Main(string[] args)
        //{
        //    GumballMachine gumballMachine = new GumballMachine(5);

        //    Console.WriteLine(gumballMachine);

        //    gumballMachine.InsertQuarter();
        //    gumballMachine.TurnCrank();

        //    Console.WriteLine(gumballMachine);

        //    gumballMachine.InsertQuarter();
        //    gumballMachine.EjectQuarter();
        //    gumballMachine.TurnCrank();

        //    Console.WriteLine(gumballMachine);

        //    gumballMachine.InsertQuarter();
        //    gumballMachine.TurnCrank();
        //    gumballMachine.InsertQuarter();
        //    gumballMachine.TurnCrank();
        //    gumballMachine.EjectQuarter();

        //    Console.WriteLine(gumballMachine);

        //    gumballMachine.InsertQuarter();
        //    gumballMachine.InsertQuarter();
        //    gumballMachine.TurnCrank();
        //    gumballMachine.InsertQuarter();
        //    gumballMachine.TurnCrank();
        //    gumballMachine.InsertQuarter();
        //    gumballMachine.TurnCrank();

        //    Console.WriteLine(gumballMachine);
        //}

        public static void Main(string[] args)
        {
            GumballMachine gumballMachine = new GumballMachine(5);

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);
        }
    }
}
