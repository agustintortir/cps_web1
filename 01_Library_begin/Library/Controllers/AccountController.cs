using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Models;
using Library.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace Library.Controllers
{
    public class AccountController : Controller
    {
        private SignInManager<User> _signInManager;
        private UserManager<User> _userManager;
        
        public AccountController (SignInManager<User> signInManager, UserManager<User> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Login()
        {
            if (this.User.Identity.IsAuthenticated == true)
            {
                return RedirectToAction("Index", "Library");
            }
            return View();
        }
        [HttpPost]
        [ActionName("Login")]
        public async Task<IActionResult> LoginPost (LoginViewModel loginModel)
        {
            if (ModelState.IsValid == true)
            {
                var resultado = await _signInManager.PasswordSignInAsync(loginModel.UserName, loginModel.Password, loginModel.RememberMe, false);
                
                if(resultado.Succeeded == true)
                {
                    return RedirectToAction("Index", "Library");
                }
            }
            ModelState.AddModelError("", "Failed to login");
            return View();
        }
        
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Library");
        }

        public IActionResult Register ()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Register")]
        public async Task<IActionResult> RegisterPost (RegisterViewModel registerModel)
        {
            if (ModelState.IsValid == true)
            {
                User user = new User
                {
                    FirstName = registerModel.FirstName,
                    LastName = registerModel.LastName,
                    UserName = registerModel.UserName,
                    PhoneNumber = registerModel.PhoneNumber,
                    Email = registerModel.Email
                };
                var resultado = await _userManager.CreateAsync(user, registerModel.Password);

                if(resultado.Succeeded == true)
                {
                    var resultSignIn = await _signInManager.PasswordSignInAsync(registerModel.UserName, registerModel.Password, registerModel.RememberMe, false);
                    if (resultSignIn.Succeeded == true)
                    {
                        return RedirectToAction("Index", "Library");
                    }
                    foreach (var error in resultado.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View();
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
