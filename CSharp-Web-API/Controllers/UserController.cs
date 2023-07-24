using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult httpGetRequest()
        {
            var UsersArray = new User[] { new User(0, "Dildaar Abrahams", "prime@gmail.com"),new User(1,"DA political party","da.govt@against.anc")};
            return Ok(UsersArray);
        }
    }
}
