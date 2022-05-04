using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALPhongBan:DALconnect
    {
        string sql;
        private SqlCommand cmd;
        public DataTable getPB()
        {
            SqlDataAdapter pb = new SqlDataAdapter("select * from PhongBan", _conn);
            DataTable tablePhongBan = new DataTable();
            pb.Fill(tablePhongBan);
            return tablePhongBan;
        }
        public bool themPB(DTOPhongBan pb)
        {
            try
            {
                _conn.Open();
                sql = string.Format("CV_insert(TenPB)");
                cmd = new SqlCommand(sql, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool suaPB(DTOPhongBan pb)
        {
            try
            {
                _conn.Open();
                sql = string.Format("cv_update(MaPB,TenPB)");
                cmd = new SqlCommand(sql, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool xoaPB(int idpb)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM PhongBan WHERE MaPB = {0})", idpb);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }
    }
}
