using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using WebProject.Api.Dependency_Injection;
using WebProject.Api.Repository;
using WebProject.Api.Service;

namespace WebProject.Api.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]
    
    public class AuthenticationController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IRepository _repository;
        private readonly ISingletonPattern _singleton;

        public AuthenticationController(IUserService userService,
            IRepository repository,
            ISingletonPattern singleton)
        {
            _userService = userService;
            _repository = repository;
            _singleton = singleton;
        }

        [HttpGet]
        public IActionResult Login(string username, string password)
        {
            var guid = _singleton.Name;

            return Ok();
            //var result = _userService.Login(username, password);
            //if (result)
            //    return Ok(result);
            //return BadRequest();
        }

        [HttpGet]
        [Route("/api/[controller]/[action]")]
        public IActionResult Login2()
        {
            return Ok("Login is ok");
        }
    }
}
