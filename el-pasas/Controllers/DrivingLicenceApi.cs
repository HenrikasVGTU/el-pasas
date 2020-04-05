using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
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
    public class DrivingLicenceApiController : ControllerBase
    { 
        /// <summary>
        /// Get Driving Licence for the User
        /// </summary>
        
        /// <param name="userId"></param>
        /// <response code="200">Successfully retrieved Driving Licence model</response>
        /// <response code="404">Driving Licence for this {userId} not found</response>
        [HttpGet]
        [Route("/api/drivingLicence/{userId}")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetDrivingLicence")]
        [SwaggerResponse(statusCode: 200, type: typeof(DrivingLicence), description: "Successfully retrieved Driving Licence model")]
        public virtual IActionResult GetDrivingLicence([FromRoute][Required]string userId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(DrivingLicence));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            string exampleJson = null;
            exampleJson = "{\n  \"4a_dateOfIssue\" : \"24 11 2016\",\n  \"4c_issuedBy\" : \"VĮ Regitra\",\n  \"2_name\" : \"Vardenis\",\n  \"4b_dateOfExpiry\" : \"24 11 2026\",\n  \"3_dateOfBirth\" : \"01 01 1985\",\n  \"4d_personalNo\" : 31234567890,\n  \"1_surname\" : \"Pavardenis\",\n  \"5_licenceNo\" : 35983081,\n  \"categories\" : [ {\n    \"9_name\" : \"AM\",\n    \"12_code\" : \"95.(24.11.21)\",\n    \"11_dateOfExpiry\" : \"24.11.21\",\n    \"10_dateOfIssue\" : \"19.01.13\"\n  }, {\n    \"9_name\" : \"AM\",\n    \"12_code\" : \"95.(24.11.21)\",\n    \"11_dateOfExpiry\" : \"24.11.21\",\n    \"10_dateOfIssue\" : \"19.01.13\"\n  } ]\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<DrivingLicence>(exampleJson)
            : default(DrivingLicence);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get profile image for the Driving Licence which belongs to the User
        /// </summary>
        
        /// <param name="userId"></param>
        /// <response code="200">Successfully retrieved Driving Licence profile image</response>
        /// <response code="404">Driving Licence image for this {userId} not found</response>
        [HttpGet]
        [Route("/api/drivingLicence/{userId}/image")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetDrivingLicenceImage")]
        public virtual IActionResult GetDrivingLicenceImage([FromRoute][Required]string userId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Get small profile image for the Driving Licence which belongs to the User
        /// </summary>
        
        /// <param name="userId"></param>
        /// <response code="200">Successfully retrieved Driving Licence small profile image</response>
        /// <response code="404">Driving Licence small image for this {userId} not found</response>
        [HttpGet]
        [Route("/api/drivingLicence/{userId}/image/small")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetDrivingLicenceImageSmall")]
        public virtual IActionResult GetDrivingLicenceImageSmall([FromRoute][Required]string userId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Get NFC code for the Driving Licence which belongs to the User
        /// </summary>
        
        /// <param name="userId"></param>
        /// <response code="200">Successfully retrieved Driving Licence NFC code</response>
        /// <response code="404">Driving Licence NFC code for this {userId} not found</response>
        [HttpGet]
        [Route("/api/drivingLicence/{userId}/nfc")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetDrivingLicenceNfc")]
        public virtual IActionResult GetDrivingLicenceNfc([FromRoute][Required]string userId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Get QR code for the Driving Licence which belongs to the User
        /// </summary>
        
        /// <param name="userId"></param>
        /// <response code="200">Successfully retrieved Driving Licence QR code</response>
        /// <response code="404">Driving Licence QR code for this {userId} not found</response>
        [HttpGet]
        [Route("/api/drivingLicence/{userId}/qr")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetDrivingLicenceQr")]
        public virtual IActionResult GetDrivingLicenceQr([FromRoute][Required]string userId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Get signature image for the Driving Licence which belongs to the User
        /// </summary>
        
        /// <param name="userId"></param>
        /// <response code="200">Successfully retrieved Driving Licence signature image</response>
        /// <response code="404">Driving Licence signature image for this {userId} not found</response>
        [HttpGet]
        [Route("/api/drivingLicence/{userId}/signature")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetDrivingLicenceSignature")]
        public virtual IActionResult GetDrivingLicenceSignature([FromRoute][Required]string userId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Update profile image for the Driving Licence which belongs to the User
        /// </summary>
        
        /// <param name="userId"></param>
        /// <param name="image">Image to upload</param>
        /// <response code="204">Successfully uploaded Driving Licence profile image</response>
        /// <response code="400">Provided image is invalid</response>
        [HttpPut]
        [Route("/api/drivingLicence/{userId}/image")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("PutDrivingLicenceImage")]
        public virtual IActionResult PutDrivingLicenceImage([FromRoute][Required]string userId, [FromForm][Required()]System.IO.Stream image)
        { 
            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Request to revalidate and extend expiration for Driving Licence
        /// </summary>
        
        /// <param name="userId"></param>
        /// <response code="204">Successfully requested Driving Licence revalidation</response>
        /// <response code="404">Driving Licence for this {userId} not found</response>
        [HttpPut]
        [Route("/api/drivingLicence/{userId}/validate")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("PutDrivingLicenceValidation")]
        public virtual IActionResult PutDrivingLicenceValidation([FromRoute][Required]string userId)
        { 
            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }
    }
}
