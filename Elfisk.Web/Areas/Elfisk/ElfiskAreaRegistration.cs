using System.Web.Mvc;
using log4net;

namespace Elfisk.Web.Areas.Elfisk
{
  public class ElfiskAreaRegistration : AreaRegistration
  {
    ILog Logger = LogManager.GetLogger(typeof(ElfiskAreaRegistration));

    
    public override string AreaName
    {
      get
      {
        return "Elfisk";
      }
    }

    public override void RegisterArea(AreaRegistrationContext context)
    {
      Logger.Debug("Register Elfisk area");

      context.MapRoute(
        "Elfisk_default",
        "",
        new { action = "index", controller = "home" });

      context.MapRoute(
        "Elfisk_other",
        "app/elfisk/{controller}/{action}",
        new { action = "index", controller = "home" });
    }
  }
}
