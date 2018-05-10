using MYMAKALE.DATA.UnitofWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MYMAKALE.WEB.Controllers
{
    public class PublicController : BaseController
    {
        public PublicController(IUnitofWork uow):base(uow)
        {

        }

       
    }
}