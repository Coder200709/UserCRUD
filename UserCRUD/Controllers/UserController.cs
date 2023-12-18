using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using UserCRUD.Models.Users;
using UserCRUD.Services.Foundations.Users;

namespace UserCRUD.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class UserController : Controller
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost]
        public async ValueTask<ActionResult<User>> PostUserAsync(User user)
        {
            return await this.userService.AddUserAsync(user);
        }

        [HttpGet("GetById_Salom")]
        public async ValueTask<ActionResult<User>> GetUserByIdAsync(Guid userId)
        {
            return await this.userService.RetrieveUserByIdAsync(userId);
        }

        [HttpGet]
        public ActionResult<IQueryable<User>> GetAllUsers()
        {
            var users =  this.userService.RetrieveAllUsers();

            return Ok(users);
        }
        [HttpPut("Update")]
        public async ValueTask<ActionResult<User>> PutUserAsync(User user)
        {
            return await this.userService.ModifyUserAsync(user);
        }
        [HttpDelete("O'chirib tasha")]
        public async ValueTask<ActionResult<User>> DeleteUserAsync(Guid userId)
        {
            return await this.userService.RemoveUserAsync(userId);
        }
    }
}
