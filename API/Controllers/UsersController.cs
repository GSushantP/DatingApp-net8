using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;
[ApiController]
[Route("api/[controller]")] // https://localhost:5001/api/users
public class UsersController(DataContext context) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUsers>>> GetUser()
    {
        var users = await context.Users.ToListAsync();

        return users;
    }

    [HttpGet("{id:int}")] //  https://localhost:5001/api/users/id (It maybe 1 or 2 or 3 or any ID)

    public async Task<ActionResult<AppUsers>> GetUsers(int id)
    {
        var user = await context.Users.FindAsync(id);
        if(user == null)
        return NotFound();
        return user;
    }

}