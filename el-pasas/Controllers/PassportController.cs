using System;
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
    public class PassportController : ControllerBase
    { 
        /// <summary>
        /// Get Passport for the User
        /// </summary>
        
        /// <param name="userId"></param>
        /// <response code="200">Successfully retrieved Passport model</response>
        /// <response code="404">Passport for this {userId} not found</response>
        [HttpGet]
        [Route("/api/passport/{userId}")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetPassport")]
        [SwaggerResponse(statusCode: 200, type: typeof(Passport), description: "Successfully retrieved Passport model")]
        public virtual IActionResult GetPassport([FromRoute][Required]string userId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Passport));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            string exampleJson = null;
            exampleJson = "{\n  \"passportNo\" : 14951794,\n  \"dateOfExpiry\" : \"02 01 2029\",\n  \"placeOfBirth\" : \"Lietuva\",\n  \"nationality\" : \"Lietuvos Respublikos\",\n  \"footer\" : \"P<LTUBASANAVICIENE<<BIRUTE<<<<<<<<<<<<<<<<<<14951794<0LTU90031187290102049003111045<<<86\",\n  \"surname\" : \"Basanavičienė\",\n  \"givenName\" : \"Birutė\",\n  \"sex\" : \"MOT/F\",\n  \"authority\" : \"Vilnius (19)\",\n  \"personalNo\" : 49003111045,\n  \"dateOfBirth\" : \"11 03 1990\",\n  \"dateOfIssue\" : \"02 01 2019\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Passport>(exampleJson)
            : default(Passport);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get profile image for the Passport which belongs to the User
        /// </summary>
        
        /// <param name="userId"></param>
        /// <response code="200">Successfully retrieved Passport profile image</response>
        /// <response code="404">Passport image for this {userId} not found</response>
        [HttpGet]
        [Route("/api/passport/{userId}/image")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetPassportImage")]
        public virtual IActionResult GetPassportImage([FromRoute][Required]string userId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Get small profile image for the Passport which belongs to the User
        /// </summary>
        
        /// <param name="userId"></param>
        /// <response code="200">Successfully retrieved Passport small profile image</response>
        /// <response code="404">Passport small image for this {userId} not found</response>
        [HttpGet]
        [Route("/api/passport/{userId}/image/small")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetPassportImageSmall")]
        public virtual IActionResult GetPassportImageSmall([FromRoute][Required]string userId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Get NFC code for the Passport which belongs to the User
        /// </summary>
        
        /// <param name="userId"></param>
        /// <response code="200">Successfully retrieved Passport NFC code</response>
        /// <response code="404">Passport NFC code for this {userId} not found</response>
        [HttpGet]
        [Route("/api/passport/{userId}/nfc")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetPassportNfc")]
        public virtual IActionResult GetPassportNfc([FromRoute][Required]string userId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Get QR code for the Passport which belongs to the User
        /// </summary>
        
        /// <param name="userId"></param>
        /// <response code="200">Successfully retrieved Passport QR code</response>
        /// <response code="404">Passport QR code for this {userId} not found</response>
        [HttpGet]
        [Route("/api/passport/{userId}/qr")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetPassportQr")]
        public virtual IActionResult GetPassportQr([FromRoute][Required]string userId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Get signature image for the Passport which belongs to the User
        /// </summary>
        
        /// <param name="userId"></param>
        /// <response code="200">Successfully retrieved Passport signature image</response>
        /// <response code="404">Passport signature image for this {userId} not found</response>
        [HttpGet]
        [Route("/api/passport/{userId}/signature")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetPassportSignature")]
        public virtual IActionResult GetPassportSignature([FromRoute][Required]string userId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Update profile image for the Passport which belongs to the User
        /// </summary>
        
        /// <param name="userId"></param>
        /// <param name="image">Image to upload</param>
        /// <response code="204">Successfully uploaded Passport profile image</response>
        /// <response code="400">Provided image is invalid</response>
        [HttpPut]
        [Route("/api/passport/{userId}/image")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("PutPassportImage")]
        public virtual IActionResult PutPassportImage([FromRoute][Required]string userId, [FromForm][Required()]System.IO.Stream image)
        { 
            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Request to revalidate and extend expiration for Passport
        /// </summary>
        
        /// <param name="userId"></param>
        /// <response code="204">Successfully requested Passport revalidation</response>
        /// <response code="404">Passport for this {userId} not found</response>
        [HttpPut]
        [Route("/api/passport/{userId}/validate")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("PutPassportValidation")]
        public virtual IActionResult PutPassportValidation([FromRoute][Required]string userId)
        { 
            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }
    }
}
