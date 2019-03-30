using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class NguyenVong_SinhVien_DAL:Database
    {
        public List<NGUYENVONG_SINHVIEN> LayNguyenVongSinhVien_TheoMaSV(string MASV)
        {
            return db.NGUYENVONG_SINHVIENs.Where(t => t.MASV == MASV).ToList();
        }
    }
}
