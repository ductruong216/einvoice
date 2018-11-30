using Data.Utilities;
using Data.Utilities.Enumeration;
using EInvoice.Data.Services;
using System;
using System.Web.Mvc;

namespace EInvoice.Web.Controllers
{
	public class LoginController : Controller
	{
		private readonly IUserService _userService;

		public LoginController(IUserService userService)
		{
			_userService = userService;
		}

		[AllowAnonymous]
		public ActionResult Login()
		{
			return View("Index");
		}

		[AllowAnonymous]
		[HttpPost]
		public ActionResult Login(string userName, string password)
		{
			try
			{
				var loginStatus = _userService.CheckLogin(userName, password);

				if (loginStatus == Enumerations.LoginStatus.WrongUserName)
				{
					return Json(new { status = "WrongUserName" }, JsonRequestBehavior.AllowGet);
				}
				else if (loginStatus == Enumerations.LoginStatus.WrongPassword)
				{
					return Json(new { status = "WrongPassword" }, JsonRequestBehavior.AllowGet);
				}
				else if (loginStatus == Enumerations.LoginStatus.Succsess)
				{
					var user = _userService.GetCustomerByName(userName);
					Session.Add(Constant.UserSession, user);
					return Json(new { status = "Succsess" }, JsonRequestBehavior.AllowGet);
				}

				return Json(new { status = "Failed" }, JsonRequestBehavior.AllowGet);
			}
			catch (Exception e)
			{
				ModelState.AddModelError("", e.Message);
				return View("Index");
			}
		}

		public ActionResult LogOut()
		{
			Session.RemoveAll();
			return (Redirect("/login"));
		}
	}
}