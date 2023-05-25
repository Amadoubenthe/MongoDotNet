using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDotNet.Models;
using MongoDotNet.Services;

namespace MongoDotNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly MongoDBServices _mongoDBServices;

        public UserController(MongoDBServices mongoDBServices)
        {
            _mongoDBServices = mongoDBServices;
        }

        [HttpGet]
        public async Task<List<User>> Get()
        {
            return await _mongoDBServices.GetAsync();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] User user)
        {
            await _mongoDBServices.CreateAsync(user);
            return CreatedAtAction(nameof(Get), new { id = user.Id }, user);
        }
    }
}
