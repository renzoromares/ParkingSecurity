using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSecurityAndManagement
{
    public static class ConnectionString
    { 
        public static readonly string connect = "Data Source=SQL5101.site4now.net;" +
                                                "Initial Catalog=DB_A6D6D2_Try;" +
                                                "User Id=DB_A6D6D2_Try_admin;" +
                                                "Password=palermo123;";

        public static readonly string connect1 = "Server=.\\;" +
                                                 "Database=Parking_System;" +
                                                 "User Id=sa;" +
                                                 "Password=noname101;" +
                                                 "MultipleActiveResultSets=true";
    }
}
