using System;
using System.Collections.Generic;
using System.Text;

namespace DO_AN_CTDL
{
    class DanhBa
    {
        private int solancuocgoi;
        private string hoten;
        private int mavung;
        private string email;
        private string sđt;
        private string nhanDB;
        private string gioitinh;
        private int ngay;
        private int thang;
        private int nam;

        public int getSoLanCuocGoi()
        {
            return this.solancuocgoi;
        }

        public string getHoTen()
        {
            return this.hoten;
        }

        public int getMaVung()
        {
            return this.mavung;
        }

        public string getEmail()
        {
            return this.email;
        }

        public string getSĐT()
        {
            return this.sđt;
        }

        public string getNhanDB()
        {
            return this.nhanDB;
        }

        public string getGioiTinh()
        {
            return this.gioitinh;
        }
        public int getNgay()
        {
            return this.ngay;
        }
        public int getThang()
        {
            return this.thang;
        }
        public int getNam()
        {
            return this.nam;
        }
        public DanhBa(int solancuocgoi, string hoten, int mavung, string email, string sđt, string nhanDB, string gioitinh, int ngay, int thang, int nam)
        {
            this.solancuocgoi = solancuocgoi;
            this.hoten = hoten;
            this.mavung = mavung;
            this.email = email;
            this.sđt = sđt;
            this.nhanDB = nhanDB;
            this.gioitinh = gioitinh;
            this.ngay = ngay;
            this.thang = thang;
            this.nam = nam;
        }

        public override string ToString()
        {
            return "Danhba(" + solancuocgoi + ", " + hoten + ", " + mavung + ", " + email + ", " + sđt + ", " + nhanDB + ", " + gioitinh + ", " + ngay + "-" + thang + "-" + nam + ")";
        }
    }
}
