using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
namespace BLL
{
    public class WQBBLL
    {
        WQBDAL dal = new WQBDAL();
        /// <summary>
        /// 全部订单
        /// </summary>
        /// <param name="id">用户id</param>
        /// <returns></returns>
        public List<ModelInfo> OrderShow(Guid id)
        {
            return dal.OrderShow(id);
        }
        /// <summary>
        /// 取消订单
        /// </summary>
        /// <param name="id">订单id</param>
        /// <returns></returns>
        public int DelOrder(Guid id)
        {
            return dal.DelOrder(id);
        }

        /// <summary>
        /// 再来一单功能
        /// </summary>
        /// <param name="id">订单id</param>
        /// <returns></returns>
        public ModelInfo FtOrder(Guid id)
        {
            return dal.FtOrder(id);
        }
        /// <summary>
        /// 订单详情
        /// </summary>
        /// <param name="uid">用户ID</param>
        /// <param name="oid">订单ID</param>
        /// <returns></returns>
        public List<ModelInfo> OrderInfo(Guid uid, Guid oid)
        {
            return dal.OrderInfo(uid, oid);
        }
    }
}
