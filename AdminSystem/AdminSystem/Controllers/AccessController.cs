using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdminSystem.Models;

namespace AdminSystem.Controllers
{
    public class AccessController : Controller
    {
        public ActionResult Login()
        {
            return View();

        }
        // GET: Login
        [HttpPost]
        public ContentResult LoginAuth(string correo, string password)
        {
            try
            {
                using (clientesEntities db = new clientesEntities())
                {
                    var query = from d in db.cliente where d.correo == correo && d.Contraseña == password && d.estado == 1 select d;
                    if (query.Count() > 0)
                    {
                        cliente clientAuth = query.First();
                        Session["user"] = clientAuth;
                        return Content("Si");
                    }
                    else
                    {
                        return Content("No");

                    }
                }

            }
            catch (Exception ex)
            {
                return Content("ocurrio un error:" + ex.Message);


                }

           // return View();
        }
    }
}