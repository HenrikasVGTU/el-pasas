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
    public class DrivingLicenseController : ControllerBase
    { 
        /// <summary>
        /// Get Driving License for the User
        /// </summary>
        
        /// <param name="userId"></param>
        /// <response code="200">Successfully retrieved Driving License model</response>
        /// <response code="404">Driving License for this {userId} not found</response>
        [HttpGet]
        [Route("/api/drivingLicense/{userId}")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetDrivingLicense")]
        [SwaggerResponse(statusCode: 200, type: typeof(DrivingLicense), description: "Successfully retrieved Driving License model")]
        public virtual IActionResult GetDrivingLicense([FromRoute][Required]string userId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(DrivingLicense));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            string exampleJson = null;
            exampleJson = "{\n  \"4a_dateOfIssue\" : \"24 11 2016\",\n  \"4c_issuedBy\" : \"VĮ Regitra\",\n  \"2_name\" : \"Vardenis\",\n  \"4b_dateOfExpiry\" : \"24 11 2026\",\n  \"3_dateOfBirth\" : \"01 01 1985\",\n  \"4d_personalNo\" : 31234567890,\n  \"1_surname\" : \"Pavardenis\",\n  \"5_licenceNo\" : 35983081,\n  \"categories\" : [ {\n    \"9_name\" : \"AM\",\n    \"12_code\" : \"95.(24.11.21)\",\n    \"11_dateOfExpiry\" : \"24.11.21\",\n    \"10_dateOfIssue\" : \"19.01.13\"\n  }, {\n    \"9_name\" : \"AM\",\n    \"12_code\" : \"95.(24.11.21)\",\n    \"11_dateOfExpiry\" : \"24.11.21\",\n    \"10_dateOfIssue\" : \"19.01.13\"\n  } ]\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<DrivingLicense>(exampleJson)
            : default(DrivingLicense);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get profile image for the Driving License which belongs to the User
        /// </summary>
        
        /// <param name="userId"></param>
        /// <response code="200">Successfully retrieved Driving License profile image</response>
        /// <response code="404">Driving License image for this {userId} not found</response>
        [HttpGet]
        [Route("/api/drivingLicense/{userId}/image")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetDrivingLicenseImage")]
        public virtual IActionResult GetDrivingLicenseImage([FromRoute][Required]string userId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Get small profile image for the Driving License which belongs to the User
        /// </summary>
        
        /// <param name="userId"></param>
        /// <response code="200">Successfully retrieved Driving License small profile image</response>
        /// <response code="404">Driving License small image for this {userId} not found</response>
        [HttpGet]
        [Route("/api/drivingLicense/{userId}/image/small")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetDrivingLicenseImageSmall")]
        public virtual IActionResult GetDrivingLicenseImageSmall([FromRoute][Required]string userId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Get NFC code for the Driving License which belongs to the User
        /// </summary>
        
        /// <param name="userId"></param>
        /// <response code="200">Successfully retrieved Driving License NFC code</response>
        /// <response code="404">Driving License NFC code for this {userId} not found</response>
        [HttpGet]
        [Route("/api/drivingLicense/{userId}/nfc")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetDrivingLicenseNfc")]
        public virtual IActionResult GetDrivingLicenseNfc([FromRoute][Required]string userId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Get QR code for the Driving License which belongs to the User
        /// </summary>
        
        /// <param name="userId"></param>
        /// <response code="200">Successfully retrieved Driving License QR code</response>
        /// <response code="404">Driving License QR code for this {userId} not found</response>
        [HttpGet]
        [Route("/api/drivingLicense/{userId}/qr")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetDrivingLicenseQr")]
        public virtual IActionResult GetDrivingLicenseQr([FromRoute][Required]string userId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Get signature image for the Driving License which belongs to the User
        /// </summary>
        
        /// <param name="userId"></param>
        /// <response code="200">Successfully retrieved Driving License signature image</response>
        /// <response code="404">Driving License signature image for this {userId} not found</response>
        [HttpGet]
        [Route("/api/drivingLicense/{userId}/signature")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetDrivingLicenseSignature")]
        public virtual IActionResult GetDrivingLicenseSignature([FromRoute][Required]string userId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Update profile image for the Driving License which belongs to the User
        /// </summary>
        
        /// <param name="userId"></param>
        /// <param name="image">Image to upload</param>
        /// <response code="204">Successfully uploaded Driving License profile image</response>
        /// <response code="400">Provided image is invalid</response>
        [HttpPut]
        [Route("/api/drivingLicense/{userId}/image")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("PutDrivingLicenseImage")]
        public virtual IActionResult PutDrivingLicenseImage([FromRoute][Required]string userId, [FromForm][Required()]System.IO.Stream image)
        { 
            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Request to revalidate and extend expiration for Driving License
        /// </summary>
        
        /// <param name="userId"></param>
        /// <response code="204">Successfully requested Driving License revalidation</response>
        /// <response code="404">Driving License for this {userId} not found</response>
        [HttpPut]
        [Route("/api/drivingLicense/{userId}/validate")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("PutDrivingLicenseValidation")]
        public virtual IActionResult PutDrivingLicenseValidation([FromRoute][Required]string userId)
        { 
            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }
    }
}
