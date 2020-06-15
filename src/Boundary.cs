using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace ErrorHandlingExamples
{
    class Boundary
    {
        public bool SiteExists(string mySite)
        {
            return mySite == "existingSite";
        }

        public int GetSiteId(string mySite)
        {
            return mySite == "failId" ? 0 : 1;
        }

        public void SqlStuff(string mySite)
        {
            // Uncomment for comparison with a web service call
            //using (var conn = new SqlConnection("Server=qa-sqlserver16,49501;Database=au_database_for_empower_audit;Trusted_Connection=True;"))
            //{
            //    conn.Open();
            //    using SqlCommand cmd = new SqlCommand("SELECT name FROM master.dbo.sysdatabases", conn);
            //    cmd.ExecuteNonQuery();
            //    Console.WriteLine("Doing my SQL stuff");
            //}

            if (mySite=="failSql")
            {
                throw new Exception("The SQL stuff failed!");
            }
        }
    }
}
