using System;
using System.Collections.Generic;
using System.Text;

namespace ErrorHandlingExamples
{
    class ControllerVoid
    {
        private ExecuteByVoid ExceptionExecutor = new ExecuteByVoid();

        public string GetCertificate(Request myRequest)
        {
            try
            {
                // Validate the certification request object
                /*
                 * RequestValidator.Validate(myRequest);
                 */

                // Attempt to perform the certification
                string certificate = ExceptionExecutor.Execute(myRequest);
                return certificate;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "";
            }
        }
    }
}
