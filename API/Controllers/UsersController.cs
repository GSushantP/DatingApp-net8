using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;
// https://localhost:5001/api/users using this here

public class UsersController(DataContext context) : BaseApiController
{
    [AllowAnonymous]
    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUsers>>> GetUser()
    {
        var users = await context.Users.ToListAsync();

        return users;
    }

    [Authorize]
    [HttpGet("{id:int}")] //  https://localhost:5001/api/users/id (It maybe 1 or 2 or 3 or any ID)

    public async Task<ActionResult<AppUsers>> GetUsers(int id)
    {
        var user = await context.Users.FindAsync(id);
        if(user == null)
        return NotFound();
        return user;
    }

}