using System;
using System.Collections.Generic;
using System.Text;

namespace ErrorHandlingExamples
{
    class AddSiteBool
    {
        private Boundary boundary = new Boundary();

        public bool AddSite(string mySite)
        {
            Console.WriteLine("Adding " + mySite);
            if (boundary.SiteExists(mySite))
            {
                    Console.WriteLine("Site already exists. Site not added");
                    return false;
            }

            try
            {
                // Do some SQL stuff which could possibly throw an error
                boundary.SqlStuff(mySite);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            
            int siteId = boundary.GetSiteId(mySite);
            if (siteId > 0)
            {
                Console.WriteLine("Successfully added Site: " + mySite);
                return true;

            }

            Console.WriteLine("Failed to add new Site: " + mySite);
            return false;
        }
    }
}
