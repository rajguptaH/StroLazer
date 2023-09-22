using Microsoft.AspNetCore.Mvc;
using WebApiCrud.Models;
using WebApiCrud.Utility.Data.Service;
using WebApiCrud.Utility.Data.Service.Interface;

namespace WebApiCrud.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly ILogger<UserController> _logger;
        private readonly IUserService _UserService;

        public UserController(ILogger<UserController> logger, IUserService UserService)
        {
            _logger = logger;
            _UserService = UserService;
        }

        [HttpGet(Name = "GetUser")]
        public IEnumerable<UserModel> Get()
        {
            return _UserService.Get();
        }
        [HttpGet("GetUserById/{UserID}")]
        public UserModel Get(int UserID)
        {
            try
            {
                var User = _UserService.Get(UserID);
                return User;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [HttpPost("AddUser")]
        public IActionResult AddUser([FromBody] UserModel UserModel)
        {
            try
            {
                var result = _UserService.Insert(UserModel);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("UpdateUser")]
        public IActionResult UpdateUser([FromBody] UserModel UserModel)
        {
            try
            {
                var result = _UserService.Update(UserModel);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("Delete/{Id}")]
        public IActionResult Delete(int Id)
        {
            try
            {
                var result = _UserService.Delete(Id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("City")]
        public IActionResult GetCity()
        {
            try
            {
                var result = _UserService.GetCity();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
