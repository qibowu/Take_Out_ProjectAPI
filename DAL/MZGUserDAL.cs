using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;


namespace DAL
{
   public  class MZGUserDAL
    {
        public int  UserAdd(ModelInfo mo)
        {
            var sql = string.Format("insert into UserInfo(UserPhone) values('{0}')",mo.UserPhone);
            return DBHelper.ExecuteNonQuery(sql);
        }
        public List<ModelInfo> Show()
        {
            string sql = "select * from UserInfo";
            var table= DBHelper.GetDataTable(sql);
            var list = DBHelper.ConvertTableToList<List<ModelInfo>>(table);
            return list;
        }
    }
}
