using System;
using System.Collections.Generic;
using System.Text;

namespace ErrorHandlingExamples
{
    class AddSiteVoid
    {
        private Boundary boundary = new Boundary();

        public void AddSite(string mySite)
        {
            Console.WriteLine("Adding " + mySite);
            if (boundary.SiteExists(mySite))
            {
                throw new Exception("Site already exists. Site not added");
            }

            // Do some SQL stuff which could possibly throw an error
            boundary.SqlStuff(mySite);
            
            int siteId = boundary.GetSiteId(mySite);
            if (!(siteId > 0))
            {
                throw new Exception("Failed to add new Site: " + mySite);
            }
            
            Console.WriteLine("Successfully added Site: " + mySite); 
        }
    }
}
