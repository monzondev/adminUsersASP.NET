using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdminSystem.Models;

namespace AdminSystem.Controllers.Filtros
{
    public class Verify :  ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var ocliente = (cliente)HttpContext.Current.Session["user"];

            if(ocliente == null)
            {
                if (filterContext.Controller is AccountController == false)
                {
                    filterContext.HttpContext.Response.Redirect("~/Access/Login");

                }
                else
                if (filterContext.Controller is AccountController == true)
                {
                    filterContext.HttpContext.Response.Redirect("~/Home/Index");

                }


            }
            base.OnActionExecuting(filterContext);
        }
    }
}