﻿using System.Web;
using System.Web.Mvc;

namespace Log4net_Error
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
