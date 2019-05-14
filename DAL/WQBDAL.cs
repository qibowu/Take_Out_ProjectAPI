using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL
{
    public class WQBDAL
    {
        /// <summary>
        /// 全部订单
        /// </summary>
        /// <returns></returns>
        public List<ModelInfo> OrderShow(int id)
        {
            string sql = @"select * from OrderTable a join DetailTable b
            on a.OrderId = b.Oid join UserInfo c on a.Uid = c.UserId
            where a.Uid = " + id;
            var dt = DBHelper.GetDataTable(sql);
            var list = DBHelper.ConvertTableToList<List<ModelInfo>>(dt);
            return list;
        }
        /// <summary>
        /// 取消订单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DelOrder(int id)
        {
            string sql = "delete from OrderTable where OrderId=" + id;
            var dt = DBHelper.ExecuteNonQuery(sql);
            return dt;
        }

        /// <summary>
        /// 再来一单功能
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ModelInfo FtOrder(int id)
        {
            string sql = "select * from DetailTable where Oid=" + id;
            var dt = DBHelper.GetDataTable(sql);
            var mo= DBHelper.ConvertTableToList<List<ModelInfo>>(dt).FirstOrDefault();
            return mo;
        }

        public List<ModelInfo> OrderInfo(int uid,int oid)
        {
            string sql = string.Format(@"select * from OrderTable a join DetailTable b
	        on a.OrderId=b.Oid join UserInfo c on a.Uid=c.UserId
	        where a.Uid={0} and a.OrderId={1}", uid, oid);
            var dt = DBHelper.GetDataTable(sql);
            var list = DBHelper.ConvertTableToList<List<ModelInfo>>(dt);
            return list;
        }
    }
}
