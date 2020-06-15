using System;
using System.Diagnostics;

namespace ErrorHandlingExamples
{
    class Program
    {
        static void Main()
        {
            TestWithBoth(new Request("testSite"));
            TestWithBoth(new Request("existingSite"));
            TestWithBoth(new Request("failId"));
            TestWithBoth(new Request("failSql"));
        }

        static void TestWithBoth(Request myRequest)
        {
            ControllerVoid ExceptionsExample = new ControllerVoid();
            ControllerBool SuccessFlagsExample = new ControllerBool();

            var sw = Stopwatch.StartNew();
            ExceptionsExample.GetCertificate(myRequest);
            sw.Stop();
            long exTicks = sw.ElapsedTicks;
            long milliseconds = sw.ElapsedMilliseconds;
            Console.WriteLine(exTicks + " ticks - " + milliseconds + " milliseconds");
            Console.WriteLine();

            sw.Restart();
            SuccessFlagsExample.GetCertificate(myRequest);
            sw.Stop();
            long flagTicks = sw.ElapsedTicks;
            milliseconds = sw.ElapsedMilliseconds;
            Console.WriteLine(flagTicks + " ticks - " + milliseconds + " milliseconds");
            Console.WriteLine();

            float ratio = (float) exTicks / flagTicks;
            Console.WriteLine(myRequest.sitename + " - Exception time : Flag time = " + ratio + " : 1");
            Console.WriteLine();
            Console.WriteLine();
        }
    }

    class Request
    {
        public string sitename;

        public Request(string sitename)
        {
            this.sitename = sitename;
        }
    }
}
