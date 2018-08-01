using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.DTO
{
    public class PhieuMuon
    {

        public PhieuMuon (string id, string idBD, string idsach, string idNV, string ngaymuon, string status)
        {
            this.Id = id;
            this.IdBD = idBD;
            this.IdSach = idsach;
            this.IdNV = idNV;
            this.Ngaymuon = ngaymuon;
            this.Status = status;
        }

        public PhieuMuon(DataRow row)
        {
            this.Id = row["ID"].ToString();
            this.IdBD = row["IDBanDoc"].ToString();
            this.IdSach = row["IDSach"].ToString();
            this.IdNV = row["IDNV"].ToString();
            this.Ngaymuon = row["NgayMuon"].ToString();
            this.Status = row["status"].ToString();
            this.IdNVTra = row["IDNVTra"].ToString();
            this.Ngaytra = row["NgayTra"].ToString();
        }
        private string id;
        private string idBD;
        private string idSach;
        private string idNV;
        private string ngaymuon;
        private string status;
        private string idNVTra;
        private string ngaytra;

        public string Id { get => id; set => id = value; }
        public string IdBD { get => idBD; set => idBD = value; }
        public string IdSach { get => idSach; set => idSach = value; }
        public string IdNV { get => idNV; set => idNV = value; }
        public string Ngaymuon { get => ngaymuon; set => ngaymuon = value; }
        public string Status { get => status; set => status = value; }
        public string IdNVTra { get => idNVTra; set => idNVTra = value; }
        public string Ngaytra { get => ngaytra; set => ngaytra = value; }
    }
}
