using System.Linq;
using core_api_docker.Models;
using core_api_docker.Repository;
using Microsoft.AspNetCore.Mvc;

namespace core_api_docker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase 
    {
        private UserRepository _userRepo;
        public UserController()
        {
            _userRepo = new UserRepository();
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody]User user){
            var users = _userRepo.GetUsers();
            var isValidUser = users.Where(x => x.Email == user.Email).FirstOrDefault();
            
            if(isValidUser != null){
                if(isValidUser.Password == user.Password){
                    return Ok( new { user = user, message =  "User Logged In Succesfully"});
                }
                
            else{
                return Ok(new { user = new {}, message =  "Email/Password Incorrect"});
            }     
            }
            else{
                return Ok(new { user = new {}, message =  "Email/Password Incorrect"});
            }       
        }
    }
}