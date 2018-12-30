using EInvoice.Data.Services;
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

        public ActionResult ChangePassword()
        {
            return View();
        }

        //[HttpPost]
        //public async Task<JsonResult> ChangePassword(User model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var user =  _userService.GetUserById();

        //        IdentityResult result = UserManager.ChangePassword(user.Id, model.OldPassword, model.NewPassword);
        //        if (result.Succeeded)
        //        {
        //            return Json(new { Result = "OK" }, JsonRequestBehavior.AllowGet);

        //            // await SignInAsync(user, isPersistent: false);
        //        }
        //        else
        //        {
        //            return Json(new
        //            {
        //                Result = "ERROR",
        //                Message = "Form is not valid! " +
        //                  "Please correct it and try again.",
        //                JsonRequestBehavior.AllowGet
        //            });
        //        }
        //    }
        //    return Json(model, JsonRequestBehavior.AllowGet);
        //}
    }
}