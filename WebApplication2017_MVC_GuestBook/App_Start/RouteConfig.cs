using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication2017_MVC_GuestBook
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            ////*** 搭配 UserDB控制器 *******************************************
            //routes.MapRoute(
            //    name: "Default2",           //*****改這裡！
            //    url: "{controller}/{action}/{_ID}",                                   //*******改這裡！
            //    defaults: new { controller = "UserDB2", action = "List", _ID = UrlParameter.Optional }
            //);

            routes.MapRoute(
                name: "Default",   // 自行命名。
                url: "{controller}/{action}/{id}",    // 預設值 id。
                                                      // 跟我們在 UserDBController.cs各個動作中，接受的「 _ID 變數」不同。
                                                      // 可參閱上方 Default2 的修正。
                defaults: new { controller = "UserDB", action = "List", id = UrlParameter.Optional }
                // 最後的 id變數，代表可有可無（Optional）。
                //  寫這樣也可以  /UserDB/Details/1。   寫成這樣也行   /UserDB/Details。
            );



        }
    }
}
