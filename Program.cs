using System;

namespace time_greeter_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            int hour = currentTime.Hour;

            string Greeting(int h)
            {
                string greeting = "";
                if (h < 12)
                {
                    greeting = "Good Morning!";
                }

                if (h >= 12 && h < 17)
                {
                    greeting = "Good Afternoon!";
                }

                if (h >= 17 && h < 21)
                {
                    greeting = "Good Evening!";
                }

                if (h >= 21)
                {
                    greeting = "Good Night! Seriously, go to bed.";
                }

                return greeting;
            }

            Console.WriteLine(Greeting(hour));
        }
    }
}
