using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EInvoice.Service;
using EInvoice.Web.Models;

namespace EInvoice.Web.Controllers
{
    public class LoginController : Controller
    {

	    //private readonly IUserService _userService;

	    //public LoginController(IUserService userService)
	    //{
		   // _userService = userService;
	    //}
		// GET: Login
		[AllowAnonymous]
		public ActionResult Index()
        {
            return View();
        }

	    //[AllowAnonymous]
	    //[HttpPost]
	   // public ActionResult Login(LoginModel model)
	   // {
		  ////  if (ModelState.IsValid)
		  ////  {
				////var user = _userService.GetSingleById(model.UserName)

				////var user = _userService.GetPersonnel(model.UserName, Encryptor.MD5Hash(model.PassWord));
			 ////   if (user != null)
			 ////   {
				////    Session.Add(Constants.USER_SESSION, user);
				////    ViewBag.FullName = user.FullName;
				////    return RedirectToAction("Index", "Home");
			 ////   }
			 ////   else
			 ////   {
				////    ModelState.AddModelError("", "User or Password is incorrect");
			 ////   }
		  ////  }
		  ////  return View(model);
	   // }
	}
}