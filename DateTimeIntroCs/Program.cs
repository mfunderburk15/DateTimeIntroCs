using System;

namespace DateTimeIntroCs
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2021, 11, 6);
            DateTime now = DateTime.Now;
            DateTime today = DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Time: " + now.Minute);
        }
    }
}
