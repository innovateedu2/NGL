﻿using System.Web.Mvc;

namespace NGL.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            // ToDoMK
            //filters.Add(new AuthorizeAttribute());
        }
    }
}
