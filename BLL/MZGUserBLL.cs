using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public  class MZGUserBLL  
    {
        MZGUserDAL dl = new MZGUserDAL();
        public int UserAdd(ModelInfo mo)
        {
            return dl.UserAdd(mo);
        }
        public List<ModelInfo> Show()
        {
            return dl.Show();
        }
    }
}
