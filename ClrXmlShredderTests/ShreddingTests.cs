using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using NUnit.Framework;

namespace ClrXmlShredderTests
{
    [TestFixture]
    class ShreddingTests
    {
        [TestCase]
        public void DoSomething()
        {
            ConnectionStringSettingsCollection strings = ConfigurationManager.ConnectionStrings;
            ConnectionStringSettings thisString = null;
            if (strings != null)
                thisString = strings["LocalSql"];

            if (thisString != null)
            {
                using (SqlConnection myConnection = new SqlConnection(thisString.ConnectionString))
                using (SqlCommand testcomm = new SqlCommand("SELECT 1", myConnection))
                {
                    myConnection.Open();
                    testcomm.ExecuteNonQuery();
                }
            }
        }
    }
}
