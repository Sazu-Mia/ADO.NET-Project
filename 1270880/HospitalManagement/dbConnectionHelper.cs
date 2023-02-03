using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public static class dbConnectionHelper
    {
        public static string ConStr
        {
            get
            {
                string db = Path.Combine(Path.GetFullPath(@"..\..\"), "HospitalManegment.mdf");
                return $@"Data Source=(localdb)\mssqllocaldb;AttachDbFilename={db};Initial Catalog=OrderManagement;Trusted_Connection=True";
            }
        }
    }
}
