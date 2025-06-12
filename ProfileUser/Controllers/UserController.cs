using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProfileUser.Data; 
using ProfileUser.Model;

namespace ProfileUser.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _context.Users.Select(u => new UserDto
            {
                UserId = u.UserId,
                PhoneNumber = u.PhoneNumber,
                FullName = u.FullName,
                Dob = u.Dob,
                Gender = u.Gender,
                Address = u.Address,
                BloodTypeId = u.BloodTypeId
            }).ToList();

            return Ok(users);
        }

        [HttpPost]
        public IActionResult Create([FromBody] UserDto userDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = new User
            {
                PhoneNumber = userDto.PhoneNumber,
                Password = userDto.Password,
                FullName = userDto.FullName ?? string.Empty,  
                Dob = userDto.Dob,
                Gender = userDto.Gender ?? "Unknown",         
                Address = userDto.Address ?? string.Empty,    
                Role = userDto.Role ?? "Member",
                BloodTypeId = userDto.BloodTypeId
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetAll), new { id = user.UserId }, user);
        }
    }
}
