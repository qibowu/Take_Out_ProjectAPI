using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using Model;

namespace Take_Out_ProjectAPI.Controllers
{
    public class MZGUserController : ApiController
    {
        MZGUserBLL bl = new MZGUserBLL();
        [HttpPost]
        public int UserAdd(ModelInfo mo)
        {
            return bl.UserAdd(mo);
        }
        [HttpGet]
        public List<ModelInfo> Show()
        {
            return bl.Show();
        }
    }
}
