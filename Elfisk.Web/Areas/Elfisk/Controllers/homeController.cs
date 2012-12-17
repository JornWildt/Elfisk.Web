using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Elfisk.Web.Areas.Elfisk.Controllers
{
  public class homeController : Xyperico.Web.Mvc.Controller
  {
    public ActionResult index()
    {
      return View();
    }
  }
}
