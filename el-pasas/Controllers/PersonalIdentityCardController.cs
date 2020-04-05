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
    public class PersonalIdentityCardController : ControllerBase
    { 
        /// <summary>
        /// Get Personal Identity Card for the User
        /// </summary>
        
        /// <param name="userId"></param>
        /// <response code="200">Successfully retrieved Personal Identity Card model</response>
        /// <response code="404">Personal Identity Card for this {userId} not found</response>
        [HttpGet]
        [Route("/api/personalIdentityCard/{userId}")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetPersonalIdentityCard")]
        [SwaggerResponse(statusCode: 200, type: typeof(PersonalIdentityCard), description: "Successfully retrieved Personal Identity Card model")]
        public virtual IActionResult GetPersonalIdentityCard([FromRoute][Required]string userId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(PersonalIdentityCard));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            string exampleJson = null;
            exampleJson = "{\n  \"dateOfExpiry\" : \"04 07 2022\",\n  \"nationality\" : \"Lietuvos Respublikos\",\n  \"footer\" : \"I<LTU56499778<047803111025<<<<7803118F2207043LTU<<<<<<<<<<<8BRUZAITE<<VIGILIJA<<<<<<<<<<<<\",\n  \"surname\" : \"Bružaitė\",\n  \"givenName\" : \"Vigilija\",\n  \"sex\" : \"MOT/F\",\n  \"authority\" : \"Vilnius (19)\",\n  \"personalNo\" : 47803111025,\n  \"dateOfBirth\" : \"11 03 1978\",\n  \"dateOfIssue\" : \"04 07 2012\",\n  \"cardNo\" : 56499778\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PersonalIdentityCard>(exampleJson)
            : default(PersonalIdentityCard);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get profile image for the Personal Identity Card which belongs to the User
        /// </summary>
        
        /// <param name="userId"></param>
        /// <response code="200">Successfully retrieved Personal Identity Card profile image</response>
        /// <response code="404">Personal Identity Card image for this {userId} not found</response>
        [HttpGet]
        [Route("/api/personalIdentityCard/{userId}/image")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetPersonalIdentityCardImage")]
        public virtual IActionResult GetPersonalIdentityCardImage([FromRoute][Required]string userId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Get small profile image for the Personal Identity Card which belongs to the User
        /// </summary>
        
        /// <param name="userId"></param>
        /// <response code="200">Successfully retrieved Personal Identity Card small profile image</response>
        /// <response code="404">Personal Identity Card small image for this {userId} not found</response>
        [HttpGet]
        [Route("/api/personalIdentityCard/{userId}/image/small")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetPersonalIdentityCardImageSmall")]
        public virtual IActionResult GetPersonalIdentityCardImageSmall([FromRoute][Required]string userId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Get NFC code for the Personal Identity Card which belongs to the User
        /// </summary>
        
        /// <param name="userId"></param>
        /// <response code="200">Successfully retrieved Personal Identity Card NFC code</response>
        /// <response code="404">Personal Identity Card NFC code for this {userId} not found</response>
        [HttpGet]
        [Route("/api/personalIdentityCard/{userId}/nfc")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetPersonalIdentityCardNfc")]
        public virtual IActionResult GetPersonalIdentityCardNfc([FromRoute][Required]string userId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Get QR code for the Personal Identity Card which belongs to the User
        /// </summary>
        
        /// <param name="userId"></param>
        /// <response code="200">Successfully retrieved Personal Identity Card QR code</response>
        /// <response code="404">Personal Identity Card QR code for this {userId} not found</response>
        [HttpGet]
        [Route("/api/personalIdentityCard/{userId}/qr")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetPersonalIdentityCardQr")]
        public virtual IActionResult GetPersonalIdentityCardQr([FromRoute][Required]string userId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Get signature image for the Personal Identity Card which belongs to the User
        /// </summary>
        
        /// <param name="userId"></param>
        /// <response code="200">Successfully retrieved Personal Identity Card signature image</response>
        /// <response code="404">Personal Identity Card signature image for this {userId} not found</response>
        [HttpGet]
        [Route("/api/personalIdentityCard/{userId}/signature")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetPersonalIdentityCardSignature")]
        public virtual IActionResult GetPersonalIdentityCardSignature([FromRoute][Required]string userId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Update profile image for the Personal Identity Card which belongs to the User
        /// </summary>
        
        /// <param name="userId"></param>
        /// <param name="image">Image to upload</param>
        /// <response code="204">Successfully uploaded Personal Identity Card profile image</response>
        /// <response code="400">Provided image is invalid</response>
        [HttpPut]
        [Route("/api/personalIdentityCard/{userId}/image")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("PutPersonalIdentityCardImage")]
        public virtual IActionResult PutPersonalIdentityCardImage([FromRoute][Required]string userId, [FromForm][Required()]System.IO.Stream image)
        { 
            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Request to revalidate and extend expiration for Personal Identity Card
        /// </summary>
        
        /// <param name="userId"></param>
        /// <response code="204">Successfully requested Personal Identity Card revalidation</response>
        /// <response code="404">Personal Identity Card for this {userId} not found</response>
        [HttpPut]
        [Route("/api/personalIdentityCard/{userId}/validate")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("PutPersonalIdentityCardValidation")]
        public virtual IActionResult PutPersonalIdentityCardValidation([FromRoute][Required]string userId)
        { 
            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }
    }
}
