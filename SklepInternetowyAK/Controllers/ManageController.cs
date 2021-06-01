using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using SklepInternetowyAK.App_Start;
using SklepInternetowyAK.Models;
using SklepInternetowyAK.ViewModels;

namespace SklepInternetowyAK.Controllers
{
    [Authorize]
    public class ManageController : Controller
    {
        public enum ManageMessageId
        {
            ChangePasswordSuccess,
            ChangeUserDataSuccess,
            Error
        }
        // GET: Manage
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;

        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }


        public async Task<ActionResult> Index(ManageMessageId? message)
        {
            ViewBag.StatusMessage =
                message == ManageMessageId.ChangePasswordSuccess ? "Zmieniono hasło."
                : message == ManageMessageId.Error ? "Wystąpił błąd."
                : message == ManageMessageId.ChangeUserDataSuccess ? "Dane użytkownika zmieniono pomyślnie."
                : "";

            var userId = User.Identity.GetUserId();
            var user = await UserManager.FindByIdAsync(userId);

            var model = new ManageViewModel
            {
                Message = message,
                UserData = user.UserData
                
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index",new {Message = ManageMessageId.Error});
            }
            var result = await UserManager.ChangePasswordAsync(User.Identity.GetUserId(), model.OldPassword, model.NewPassword);
            if (result.Succeeded)
            {
                var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
                if (user != null)
                {
                    await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
                }
                return RedirectToAction("Index", new { Message = ManageMessageId.ChangePasswordSuccess });
            }
            AddErrors(result);

            return RedirectToAction("Index", new { Message = ManageMessageId.Error });
        }


        [HttpPost]
        public async Task<ActionResult> ChangeUserData(UserData model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index", new { Message = ManageMessageId.Error });
            }

            var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
            user.UserData = model;

            var result = await UserManager.UpdateAsync(user);
           if(result.Succeeded)
               return RedirectToAction("Index", new { Message = ManageMessageId.ChangeUserDataSuccess });
           else
               return RedirectToAction("Index", new { Message = ManageMessageId.Error });
        }


        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }
    }
}