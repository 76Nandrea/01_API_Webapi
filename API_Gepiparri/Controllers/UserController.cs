using API_Gepiparri.DAL.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Gepiparri.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<User>>>GetAllUser()
        {
            var users =new List<User>()
            {
                new User
                {
                    Id = 1,
                    FName = "Nagy",
                    LName = "Andrea",
                    Email = "andrea.nagy761201@gmail.com",
                    Password = "Pass12345"
                },
                new User
                {
                    Id = 1,
                    FName = "Kövi",
                    LName = "Ricsi",
                    Email = "ricsifiam@gmail.com",
                    Password = "Pass12345"
                },
            };
            return Ok(users);
        }
    }
}
