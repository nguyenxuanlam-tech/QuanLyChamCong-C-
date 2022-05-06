using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALconnect
    {
        protected SqlConnection _conn = new SqlConnection("Data Source=DESKTOP-1ICQ6GR;Initial Catalog=ChamCong;Integrated Security=True");
    }
}
