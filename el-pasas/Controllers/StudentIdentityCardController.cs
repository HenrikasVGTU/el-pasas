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
    public class StudentIdentityCardController : ControllerBase
    { 
        /// <summary>
        /// Get Student Identity Card for the User
        /// </summary>
        
        /// <param name="userId"></param>
        /// <response code="200">Successfully retrieved Student Identity Card model</response>
        /// <response code="404">Student Identity Card for this {userId} not found</response>
        [HttpGet]
        [Route("/api/studentIdentityCard/{userId}")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetStudentIdentityCard")]
        [SwaggerResponse(statusCode: 200, type: typeof(StudentIdentityCard), description: "Successfully retrieved Student Identity Card model")]
        public virtual IActionResult GetStudentIdentityCard([FromRoute][Required]string userId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(StudentIdentityCard));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            string exampleJson = null;
            exampleJson = "{\n  \"studentId\" : \"53675\",\n  \"studiesAt\" : \"Socialinių mokslų f.\",\n  \"surname\" : \"Universitaitė\",\n  \"spd\" : 701303,\n  \"name\" : \"Unė\",\n  \"personalNo\" : 48703030001,\n  \"validUntil\" : \"2021-06-30\",\n  \"validFrom\" : \"2017-09-01\",\n  \"barcode\" : \"94403905000000014\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<StudentIdentityCard>(exampleJson)
            : default(StudentIdentityCard);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get profile image for the Student Identity Card which belongs to the User
        /// </summary>
        
        /// <param name="userId"></param>
        /// <response code="200">Successfully retrieved Student Identity Card profile image</response>
        /// <response code="404">Student Identity Card image for this {userId} not found</response>
        [HttpGet]
        [Route("/api/studentIdentityCard/{userId}/image")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetStudentIdentityCardImage")]
        public virtual IActionResult GetStudentIdentityCardImage([FromRoute][Required]string userId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Get small profile image for the Student Identity Card which belongs to the User
        /// </summary>
        
        /// <param name="userId"></param>
        /// <response code="200">Successfully retrieved Student Identity Card small profile image</response>
        /// <response code="404">Student Identity Card small image for this {userId} not found</response>
        [HttpGet]
        [Route("/api/studentIdentityCard/{userId}/image/small")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetStudentIdentityCardImageSmall")]
        public virtual IActionResult GetStudentIdentityCardImageSmall([FromRoute][Required]string userId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Get NFC code for the Student Identity Card which belongs to the User
        /// </summary>
        
        /// <param name="userId"></param>
        /// <response code="200">Successfully retrieved Student Identity Card NFC code</response>
        /// <response code="404">Student Identity Card NFC code for this {userId} not found</response>
        [HttpGet]
        [Route("/api/studentIdentityCard/{userId}/nfc")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetStudentIdentityCardNfc")]
        public virtual IActionResult GetStudentIdentityCardNfc([FromRoute][Required]string userId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Get QR code for the Student Identity Card which belongs to the User
        /// </summary>
        
        /// <param name="userId"></param>
        /// <response code="200">Successfully retrieved Student Identity Card QR code</response>
        /// <response code="404">Student Identity Card QR code for this {userId} not found</response>
        [HttpGet]
        [Route("/api/studentIdentityCard/{userId}/qr")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetStudentIdentityCardQr")]
        public virtual IActionResult GetStudentIdentityCardQr([FromRoute][Required]string userId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Get signature image for the Student Identity Card which belongs to the User
        /// </summary>
        
        /// <param name="userId"></param>
        /// <response code="200">Successfully retrieved Student Identity Card signature image</response>
        /// <response code="404">Student Identity Card signature image for this {userId} not found</response>
        [HttpGet]
        [Route("/api/studentIdentityCard/{userId}/signature")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetStudentIdentityCardSignature")]
        public virtual IActionResult GetStudentIdentityCardSignature([FromRoute][Required]string userId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Update profile image for the Student Identity Card which belongs to the User
        /// </summary>
        
        /// <param name="userId"></param>
        /// <param name="image">Image to upload</param>
        /// <response code="204">Successfully uploaded Student Identity Card profile image</response>
        /// <response code="400">Provided image is invalid</response>
        [HttpPut]
        [Route("/api/studentIdentityCard/{userId}/image")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("PutStudentIdentityCardImage")]
        public virtual IActionResult PutStudentIdentityCardImage([FromRoute][Required]string userId, [FromForm][Required]System.IO.Stream image)
        { 
            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Request to revalidate and extend expiration for Student Identity Card
        /// </summary>
        
        /// <param name="userId"></param>
        /// <response code="204">Successfully requested Student Identity Card revalidation</response>
        /// <response code="404">Passport for this {userId} not found</response>
        [HttpPut]
        [Route("/api/studentIdentityCard/{userId}/validate")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("PutStudentIdentityCardValidation")]
        public virtual IActionResult PutStudentIdentityCardValidation([FromRoute][Required]string userId)
        { 
            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }
    }
}
