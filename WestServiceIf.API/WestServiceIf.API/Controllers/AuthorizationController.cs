using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WestServiceIf.API.Models.DTOs;

namespace WestServiceIf.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthorizationController(SignInManager<IdentityUser> signInManager) : Controller
{
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginDto login)
    {
        var result = await signInManager.PasswordSignInAsync(login.Email, login.Password, isPersistent: false, lockoutOnFailure: false);
        
        if (result.Succeeded)
        {
            return Ok("Logged in successfully");
        }

        return Unauthorized("Invalid email or password");
    }

    [HttpDelete("logout")]
    public async Task<IActionResult> Logout()
    {
        Response.Cookies.Delete(".AspNetCore.Identity.Application");
        return Ok();
    }
}