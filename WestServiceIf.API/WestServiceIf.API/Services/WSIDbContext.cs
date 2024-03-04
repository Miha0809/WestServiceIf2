using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WestServiceIf.API.Services;

public class WSIDbContext(DbContextOptions<WSIDbContext> options) : IdentityDbContext(options)
{
    
}