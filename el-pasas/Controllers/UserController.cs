using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using el_pasas.Attributes;
using el_pasas.Security;
using Microsoft.AspNetCore.Authorization;
using el_pasas.Models;

namespace el_pasas.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class UserController : ControllerBase
    { 
        /// <summary>
       /// User authorization
        /// </summary>
        
        /// <param name="creds">The string with user credentials in base64</param>
        /// <response code="200">Successful login</response>
        /// <response code="400">Invalid login credentials supplied</response>
        [HttpGet]
        [Route("/api/user/login")]
        [ValidateModelState]
        [SwaggerOperation("LoginUser")]
        [SwaggerResponse(statusCode: 200, type: typeof(Authorization), description: "Successful login")]
        public virtual IActionResult LoginUser([FromQuery][Required]string creds)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Authorization));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            string exampleJson = null;
            exampleJson = "{\n  \"userId\" : \"31234567890\",\n  \"token\" : \"fYoHZprrBGMWeq1fOHaAHY6fXNwm05L2KiwYDR6k6kX62rXSctD8HUlvUG6FpEe8\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Authorization>(exampleJson)
            : default(Authorization);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Logs out current logged in user session
        /// </summary>
        
        /// <param name="creds">The string with user credentials in base64</param>
        /// <response code="0">Successfully logged off</response>
        [HttpGet]
        [Route("/api/user/logout")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("LogoutUser")]
        public virtual IActionResult LogoutUser([FromQuery][Required]string creds)
        { 
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0);


            return Ok();
        }
    }
}
