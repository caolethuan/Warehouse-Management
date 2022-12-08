using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHangHoa
{
    class DataConnection
    {
        string conStr;
        public DataConnection()
        {
            conStr = "Data Source=thuanlenovo;Initial Catalog=QuanLyHangHoa;Integrated Security=True";
        }
        public SqlConnection GetConnect()
        {
            return new SqlConnection(conStr);
        }
    }
}
