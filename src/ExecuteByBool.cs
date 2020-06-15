using System;
using System.Collections.Generic;
using System.Text;

namespace ErrorHandlingExamples
{
    class ExecuteByBool
    {
        private AddSiteBool FlagInterface = new AddSiteBool();

        public string Execute(Request myRequest)
        {
            Console.WriteLine("Executing request to add " + myRequest.sitename + " using method with bool flags");

            if (!FlagInterface.AddSite(myRequest.sitename))
            {
                Console.WriteLine("Error adding new Site");
                return "";
            }

            // Some other stuff

            return "successful execution";
        }
    }
}
