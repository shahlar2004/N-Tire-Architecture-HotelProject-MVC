using HotelProject.Entity.DTOs.Users;
using HotelProject.Entity.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;

        public AuthController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager   = signInManager;
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginDto request)
        {
            if (request.Email == null || request.Password == null)
            {
                ModelState.AddModelError("", "E-mail adresiniz  və ya şifrəniz yanlışdır. ");
                return View();
            }


            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(request.Email);

                if (user != null)
                {
                    var result = await signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home", new { Area = "Admin" });
                    }

                    else
                    {
                        ModelState.AddModelError("", "E-mail adresiniz  və ya şifrəniz yanlışdır. ");

                        return View();
                    }
                }

                else
                {
                    ModelState.AddModelError("", "E-mail adresiniz  və ya şifrəniz yanlışdır. ");
                    return View();
                }
            }

            else
            {
                return View();
            }

        }


        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login", "Auth", new { Area = "Admin" });
        }




    }
}
