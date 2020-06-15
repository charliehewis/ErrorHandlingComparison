using System;
using System.Collections.Generic;
using System.Text;

namespace ErrorHandlingExamples
{
    class ControllerBool
    {
        private ExecuteByBool FlagExecutor = new ExecuteByBool();

        public Response GetCertificate(Request myRequest)
        {
            // Validate the certification request object
            /*
             * myRequest = RequestValidator.Validate(myRequest);
             */

            // Attempt to perform the certification
            string certificate = FlagExecutor.Execute(myRequest);
            if (certificate == "")
            {
                return new Response(false, "problem somewhere");
            }
            return new Response(true, "Success", certificate );
        }
    }

    class Response
    {
        public bool success;
        public string message;
        public string certificate = "";

        public Response(bool success, string message) {
            this.success = success;
            this.message = message;
        }

        public Response(bool success, string message, string certificate) {
            this.success = success;
            this.message = message;
            this.certificate = certificate;
        }
    }
}
