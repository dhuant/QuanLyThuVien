using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.DTO
{
    public class LoaiSach
    {

        public LoaiSach(string id, string name, string description)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
        }
        public LoaiSach(DataRow row)
        {
            this.Id = row["ID"].ToString();
            this.Name = row["Name"].ToString();
            this.Description = row["Description"].ToString();
        }
        private string id;
        private string name;
        private string description;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
    }
}
