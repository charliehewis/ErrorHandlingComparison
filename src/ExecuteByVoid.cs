using System;
using System.Collections.Generic;
using System.Text;

namespace ErrorHandlingExamples
{
    class ExecuteByVoid
    {
        private AddSiteVoid ExceptionInterface = new AddSiteVoid();
        
        public string Execute(Request myRequest)
        {
            Console.WriteLine("Executing request to add " + myRequest.sitename + " using method with exceptions");

            ExceptionInterface.AddSite(myRequest.sitename);
            
            // Some other stuff to get certificate

            return "Finished executing request";
        }
    }
}
