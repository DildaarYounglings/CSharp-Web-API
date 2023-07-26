using CSharp_Web_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace CSharp_Web_API.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        /// <summary>
        ///     Is the Get method Of the User controller class.
        ///     Uses a [HttpGet(string that contains a value you place in that determines the route that this function returns data to;can be used for dependency injection for dynamic urls)] attribute.
        ///     Then a [ProducesResponse(declare type in 1st param, StatusCodes in 2nd param)] attribute
        /// </summary>
        /// <returns>
        ///     IActionResult containing the data in
        /// </returns>
        [HttpGet]
        [ProducesResponseType(typeof(User[]), StatusCodes.Status200OK)]
        public IActionResult GetAllUsers()
        { 
            var UsersArray = new UserRespository().UsersArray;
            return Ok(UsersArray);
        }

        [HttpPost]
        public IActionResult PostNewUser([FromBody] string users)
        {
            return Ok();
        }
    }
}
