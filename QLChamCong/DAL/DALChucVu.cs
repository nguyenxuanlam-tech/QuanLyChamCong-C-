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
    public class DALChucVu:DALconnect
    {
        string sql;
        private SqlCommand cmd;
        public DataTable getChucVu()
        {
            SqlDataAdapter adaptercv = new SqlDataAdapter("select * from ChucVu", _conn);
            DataTable tableChucVu = new DataTable();
            adaptercv.Fill(tableChucVu);
            return tableChucVu;
        }
        public bool themChucVu(DTOChucVu cv)
        {
            try
            {
                _conn.Open();
                sql = string.Format("CV_insert(tenCV)");
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

        public bool suaChucVu(DTOChucVu cv)
        {
            try
            {
                _conn.Open();
                sql = string.Format("cv_update(_maCV,_tenCV)");
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
        public bool xoaCV(int maCV)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM ChucVu WHERE MaCV = {0})", maCV);

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
