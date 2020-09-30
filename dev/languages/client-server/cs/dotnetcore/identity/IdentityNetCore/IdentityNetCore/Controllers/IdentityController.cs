using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityNetCore.Models;
using IdentityNetCore.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityNetCore.Controllers
{
    public class IdentityController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IEmailSender emailSender;

        public IdentityController(UserManager<IdentityUser> userManager, IEmailSender emailSender)
        {
            _userManager = userManager;
            this.emailSender = emailSender;
        }

        public async Task<IActionResult> SignUp()
        {
            var model = new SignUpViewModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpViewModel model)
        {
            if (ModelState.IsValid)
            {
                if ( (await _userManager.FindByEmailAsync(model.Email)) != null )
                {
                    var user = new IdentityUser 
                    {
                        Email = model.Email, UserName = model.Email
                    };
                    
                    var result = await _userManager.CreateAsync(user, model.Password);
                    var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);

                    user = await _userManager.FindByEmailAsync(model.Email);

                    if (result.Succeeded)
                    {
                        var confirmationLink = Url.ActionLink("ConfirmEmail", "Identity", new { userid = user.Id, @token = token});
                        await emailSender.SendEmailAsync("info@mydomain.com", user.Email, "Please confirm your e-mail address.", confirmationLink);

                        return RedirectToAction("SignIn");
                    }

                    ModelState.AddModelError("SignUp", string.Join("", result.Errors.Select( x=> x.Description)));

                    return View(model);
                }
            }

            return View(model);
        }

        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            return new OkResult();
        }

        public async Task<IActionResult> SignIn()
        {
            return View();
        }

        public async Task<IActionResult> AccessDenied()
        {
            return View();
        }
    }
}
