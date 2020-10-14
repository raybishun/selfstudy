using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TicTacToe.Models;
using TicTacToe.Services;

namespace TicTacToe.Controllers
{
    public class UserRegistrationController : Controller
    {
        private IUserService _userService;
        public UserRegistrationController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserModel userModel)
        {
            if (ModelState.IsValid)
            {
                await _userService.RegisterUser(userModel);

                // return Content($"User {userModel.FirstName} {userModel.LastName} has been registered successfully.");
                return RedirectToAction(nameof(EmailConfirmation), new { userModel.Email });
            }
            else
            {
                return View(userModel);
            }
        }

        [HttpGet]
        public async Task<IActionResult> EmailConfirmation(string email)
        {
            var user = await _userService.GetUserByEmail(email);

            if (user?.IsEmailConfirmed == true)
            {
                return RedirectToAction("Index", "GameInvitation",
                    new { email = email });
            }

            ViewBag.Email = email;
            user.IsEmailConfirmed = true;
            user.EmailConfirmationDate = DateTime.Now;
            await _userService.UpdateUser(user);
            return View();
        }
    }
}