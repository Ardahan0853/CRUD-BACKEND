using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TestCRUD.Models;

namespace TestCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly RegisterContext _context;

        public RegisterController(RegisterContext context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(LoginModel model)
        {
            // Check if the user already exists
            var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.Username == model.Username);

            if (existingUser != null)
            {
                return Conflict(new { message = "Username already exists" });
            }

            // Create a new user
            var newUser = new User
            {
                Username = model.Username,
                Password = model.Password // In a real application, make sure to hash the password before storing it
            };

            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Registration successful", user = newUser });
        }
    }
}
