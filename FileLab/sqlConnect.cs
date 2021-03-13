using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FileLab
{
    // Global class to use across forms
    public static class sqlConnect
    {
        public static SqlConnection connection;
    }
}
