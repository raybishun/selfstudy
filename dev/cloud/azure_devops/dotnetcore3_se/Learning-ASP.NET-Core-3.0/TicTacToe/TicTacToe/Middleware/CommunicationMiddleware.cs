using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;
using TicTacToe.Services;

namespace TicTacToe.Middleware
{
    public class CommunicationMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IUserService _userService;

        public CommunicationMiddleware(RequestDelegate next, IUserService userService)
        {
            _next = next;
            _userService = userService;
        }

        //public async Task Invoke(HttpContext context)
        //{
        //    await _next.Invoke(context);
        //}

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Path.Equals("/CheckEmailConfirmationStatus"))
            {
                await ProcessEmailConfirmation(context);
            }
            else 
            {
                await _next?.Invoke(context);
            }
        }

        private Task ProcessEmailConfirmation(HttpContext context)
        {
            
        }
    }
}
