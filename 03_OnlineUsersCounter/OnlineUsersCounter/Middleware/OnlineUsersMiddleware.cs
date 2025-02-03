using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

public class OnlineUsersMiddleware
{
    private readonly RequestDelegate _next;

    public OnlineUsersMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context, OnlineUsersService onlineUsersService)
    {
        string cookieKey = "UserOnlineCookie";

        if (!context.Request.Cookies.ContainsKey(cookieKey))
        {
            var cookieValue = Guid.NewGuid().ToString();
            context.Response.Cookies.Append(cookieKey, cookieValue, new CookieOptions
            {
                HttpOnly = true,
                SameSite = SameSiteMode.Lax,
                Expires = DateTimeOffset.Now.AddMinutes(1) 
            });

            onlineUsersService.AddOrUpdateUser(cookieValue);
        }
        else
        {
            string cookieValue = context.Request.Cookies[cookieKey];
            onlineUsersService.AddOrUpdateUser(cookieValue); 
        }

        await _next(context);
    }
}
