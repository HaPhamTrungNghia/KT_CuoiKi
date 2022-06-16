using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_5
{
    internal class HangThucPham
    {
        private int maHang;
        private string tenHang;
        private double donGia;
        private DateTime ngaySanXuat;
        private DateTime ngayHetHan;
        public HangThucPham()
        {
        }
        public HangThucPham(int maHang, string tenHang, double donGia, DateTime ngaySanXuat, DateTime ngayHetHan )
        {
            this.maHang = maHang;
            this.tenHang = tenHang;
            this.ngaySanXuat = ngaySanXuat;
            this.ngayHetHan = ngayHetHan;

        }
        public void setMahang (int maHang)
        {
           
        }
        public int getmaHang (int maHang )
        {
            return this.maHang;
        }



    }
}
