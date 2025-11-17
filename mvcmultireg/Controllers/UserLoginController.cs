using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcmultireg.Models;

namespace mvcmultireg.Controllers
{
    public class UserLoginController : Controller
    {
        mvcmultiuserregEntities dbobj = new mvcmultiuserregEntities();
        // GET: UserLogin
        public ActionResult Login_pageload()
        {
            return View();
        }
        public ActionResult Userhome()
        {
            return View();
        }
        public ActionResult Adminhome()
        {
            return View();
        }
        public ActionResult Login_click(Logincls objcls)
        {
            if (ModelState.IsValid)
            {
                var val = dbobj.sp_loginCountId(objcls.username, objcls.password).First();
                if (val == 1)
                {
                    var uid = dbobj.sp_loginId(objcls.username, objcls.password).FirstOrDefault();
                    Session["uid"] = uid;
                    var lt = dbobj.sp_logintype(objcls.username, objcls.password).FirstOrDefault();
                    if (lt == "user")
                    {
                        return RedirectToAction("Userhome");
                    }
                    else if (lt == "admin")
                    {
                        return RedirectToAction("Adminhome");
                    }
                }
                else
                {
                    ModelState.Clear();
                    objcls.msg = "Invalid username and password....";
                    return View("Login_pageload", objcls);
            }   }
            else
            {
                ModelState.Clear();
                objcls.msg = "Invalid username and password....";
                return View("Login_pageload", objcls);
            }
            return View("Login_pageload", objcls);


        }
}       }