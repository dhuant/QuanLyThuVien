using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV.DTO;

namespace QLTV.DAO
{
    public class pmDAO
    {
        Data data = new Data();

        public DataTable getData()
        {
            return data.getData("select pm.ID as ID, bd.ID as IDBanDoc, bd.Name as NameBanDoc, nv.ID as IDNV, nv.FullName as NameNV, qs.ID as IDSach, qs.Name as NameSach, pm.NgayMuon as NgayMuon, pm.status as Status from QuyenSach qs, BanDoc bd, PhieuMuon pm, NhanVien nv where pm.IDBanDoc = bd.ID and pm.IDNV = nv.ID and pm.IDSach = qs.ID");
        }

        public DataTable getPM()
        {
            return data.getData("select * from PhieuMuon");
        }
        public int addData(PhieuMuon pm)
        {
            DateTime date = Convert.ToDateTime(pm.Ngaymuon);
            string sql = "insert into PhieuMuon values('" + pm.Id + "','" + pm.IdBD + "','" + pm.IdSach + "','" + pm.IdNV + "','" + date.ToString("MM-dd-yyyy") + "',N'" + pm.Status + "', null, null)";
            return data.add(sql);
        }

        public int deleteData(string id)
        {
            string sql = "delete from PhieuMuon where ID = '" + id + "'";
            return data.Delete(sql);
        }

        public PhieuMuon getPMbyID(string id)
        {
            PhieuMuon pm = null;
            string sql = "select * from PhieuMuon where ID = '" + id + "'";
            DataTable table = data.getData(sql);
            foreach (DataRow item in table.Rows)
            {
                pm = new PhieuMuon(item);
                return pm;
            }
            return pm;
        }
        public int edit(PhieuMuon pm)
        {
            DateTime date = Convert.ToDateTime(pm.Ngaymuon);
            string sql = "update PhieuMuon set IDSach='" + pm.IdSach + "',IDNV='" + pm.IdNV + "',NgayMuon='" + date.ToString("MM-dd-yyyy") + "' where ID ='" + pm.Id + "' and IDBanDoc='" + pm.IdBD + "' ";
            if (data.Edit(sql) > 0)
                return 1;
            return 0;
        }

        public int update(string id, string nvTra, string ngaytra)
        {
            DateTime date = Convert.ToDateTime(ngaytra);
            string sql = "update PhieuMuon set IDNVTra='" + nvTra + "',NgayTra='" + date.ToString("MM-dd-yyyy") + "',status=N'" + "Đã trả" + "' where ID ='" + id + "' ";
            if (data.Edit(sql) > 0)
                return 1;
            return 0;
        }

        public bool CheckID(string id)
        {
            string sql = "select ID from PhieuMuon where ID ='" + id + "'";
            return data.checkID(sql);
        }
    }
}
