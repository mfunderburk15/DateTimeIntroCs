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

            //Console.WriteLine("Hour: " + now.Hour);
            //Console.WriteLine("Time: " + now.Minute);

            DateTime tomorrow = now.AddDays(1);
            DateTime yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yy-MM-dd HH:mm"));

        }
    }
}
