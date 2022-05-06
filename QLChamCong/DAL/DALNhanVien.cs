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
    public class DALNhanVien:DALconnect
    {
        string sql;
        private SqlCommand cmd;
        public DataTable getNV()
        {
            SqlDataAdapter pb = new SqlDataAdapter("select * from NhanVien", _conn);
            DataTable tableNhanVien = new DataTable();
            pb.Fill(tableNhanVien);
            return tableNhanVien;
        }
        public bool themNV(DTONhanVien nv)
        {
            try
            {
                _conn.Open();
                sql = string.Format("insertNV(MaNV,MaPB,HeSoLuong,TenNV,GioiTinh,NgaySinh,SoCM,DienThoai,TrinhDoHV,DiaChi,Email,Hinh,TTHonNhan)");
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

        public bool suaNV(DTONhanVien nv)
        {
            try
            {
                _conn.Open();
                sql = string.Format("cv_update(_maPB,_tenPB)");
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

        public bool xoaNV(string maNV)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM NhanVien WHERE MaNV = {0})", maNV);

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
