using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_BanHang.DAL
{
    public class DAL_ThongKe
    {
        private Common conn;

        private const string GET_TONG_HOADON = "SELECT count(*) as tong FROM tblHOADON";

        private const string GET_DOANH_SO = "SELECT count(*) as tong FROM tblKHACHHANG";

        private const string GET_DOANHTHU = "SELECT sum(tongtien) as tong FROM tblHOADON";

        private const string GET_SOSANPHAM = "SELECT count(*) as tong FROM tblSANPHAM";

        public DAL_ThongKe()
        {
            conn = new Common();
        }

        public int LayTongHoaDon()
        {
            DataTable result = conn.executeSelectQuery(GET_TONG_HOADON);

            if (result.Rows.Count != 0)
            {
                return result.Rows[0].Field<int>("tong");
            }
            return 0;
        }

        public int LayDoanhSo()
        {
            DataTable result = conn.executeSelectQuery(GET_DOANH_SO);

            if (result.Rows.Count != 0)
            {
                return result.Rows[0].Field<int>("tong");
            }
            return 0;
        }

        public int LayDoanhThu()
        {
            DataTable result = conn.executeSelectQuery(GET_DOANHTHU);

            if (result.Rows.Count != 0)
            {
                return result.Rows[0].Field<int>("tong");
            }
            return 0;
        }

        public int LaySoSanPham()
        {
            DataTable result = conn.executeSelectQuery(GET_SOSANPHAM);

            if (result.Rows.Count != 0)
            {
                return result.Rows[0].Field<int>("tong");
            }
            return 0;
        }
    }
}
