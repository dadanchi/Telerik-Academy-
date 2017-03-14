namespace Events
{
    using System;

    using Core;
    using Models;

    public class StartUp
    {
        public static void Main()
        {
            while (Engine.ExecuteNextCommand())
            {
            }

            Console.WriteLine(Messages.Output);
        }
    }
}