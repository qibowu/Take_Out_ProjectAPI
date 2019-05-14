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
        /// <param name="id">用户id</param>
        /// <returns></returns>
        public List<ModelInfo> OrderShow(Guid id)
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
        /// <param name="id">订单id</param>
        /// <returns></returns>
        public int DelOrder(Guid id)
        {
            string sql = "delete from OrderTable where OrderId=" + id;
            var dt = DBHelper.ExecuteNonQuery(sql);
            return dt;
        }

        /// <summary>
        /// 再来一单功能
        /// </summary>
        /// <param name="id">订单id</param>
        /// <returns></returns>
        public ModelInfo FtOrder(Guid id)
        {
            string sql = "select * from DetailTable where Oid=" + id;
            var dt = DBHelper.GetDataTable(sql);
            var mo= DBHelper.ConvertTableToList<List<ModelInfo>>(dt).FirstOrDefault();
            return mo;
        }
        /// <summary>
        /// 订单详情
        /// </summary>
        /// <param name="uid">用户ID</param>
        /// <param name="oid">订单ID</param>
        /// <returns></returns>
        public List<ModelInfo> OrderInfo(Guid uid, Guid oid)
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
