using EInvoice.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EInvoice.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
      

        public UserController(IUserService userService)
        {
            _userService = userService;
           
        }
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult CheckPassword(string password)
        {
            if (_userService.CheckPassword(password))
            {
                return Success();
            }
            else
            {
                return Error("Your password not right");
            }
        }

        public JsonResult Success()
        {
            return Json(new { Success = true, Message = "" }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Error(string message)
        {
            return Json(new { Success = false, Message = message }, JsonRequestBehavior.AllowGet);
        }

    }
}