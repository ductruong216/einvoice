using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EInvoice.Data.Data;
using EInvoice.Data.Enumerations;
using EInvoice.Data.Utilities;
using EInvoice.Service;
using EInvoice.Web.Models;

namespace EInvoice.Web.Controllers
{
  
    public class LoginController : Controller
    {

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(string userName, string password)
        {
            try
            {
                var loginStatus = _employeeService.CheckLogin(userName,password);

                if (loginStatus == Enumeraions.LoginStatus.WrongUserName)
                {
                    return Json(new { status = "WrongUserName" }, JsonRequestBehavior.AllowGet);
                }
                else if (loginStatus == Enumeraions.LoginStatus.WrongPassword)
                {
                    return Json(new { status = "WrongPassword" }, JsonRequestBehavior.AllowGet);
                }
                else if (loginStatus == Enumeraions.LoginStatus.Succsess)
                {
                    var user = _employeeService.GetEmployeeByUserName(userName);
                    Session.Add(Constant.UserSession, user);
                    return Json(new { status = "Succsess"}, JsonRequestBehavior.AllowGet);
                }

                return Json(new { status = "Failed" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return View();
            }
        }

        public ActionResult LogOut()
        {
            Session.RemoveAll();
            return (Redirect("/login"));
        }

       

      

        // Service
        public Employee GetEmployeeByUserName(string userName)
        {
            var employee = _employeeRepository.GetEmployeeByUserName(userName);
            return employee;
        }

        public Enumerations.LoginStatus CheckLogin(string userName, string password)
        {
            var user = _employeeRepository.GetEmployeeByUserName(userName);
            if (user == null)
            {
                return Enumerations.LoginStatus.WrongUserName;
            }
            else
            {
                if (!user.Password.Equals(password))
                {
                    return Enumerations.LoginStatus.WrongPassword;
                }
                else
                {
                    return Enumerations.LoginStatus.Succsess;
                }
            }
        }
    }
}