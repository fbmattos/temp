/*
 * Swagger Petstore
 *
 * This is a sample server Petstore server.  You can find out more about Swagger at [http://swagger.io](http://swagger.io) or on [irc.freenode.net, #swagger](http://swagger.io/irc/).  For this sample, you can use the api key `special-key` to test the authorization filters.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.SwaggerGen.Annotations;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    public class PetApiController : Controller
    { 

        /// <summary>
        /// Add a new pet to the store
        /// </summary>
        /// <remarks></remarks>
        /// <param name="body">Pet object that needs to be added to the store</param>
        /// <response code="405">Invalid input</response>
        [HttpPost]
        [Route("/v2/pet")]
        [SwaggerOperation("AddPet")]
        public virtual void AddPet([FromBody]Pet body)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Deletes a pet
        /// </summary>
        /// <remarks></remarks>
        /// <param name="petId">Pet id to delete</param>
        /// <param name="apiKey"></param>
        /// <response code="400">Invalid ID supplied</response>
        /// <response code="404">Pet not found</response>
        [HttpDelete]
        [Route("/v2/pet/{petId}")]
        [SwaggerOperation("DeletePet")]
        public virtual void DeletePet([FromRoute]long? petId, [FromHeader]string apiKey)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Finds Pets by status
        /// </summary>
        /// <remarks>Multiple status values can be provided with comma separated strings</remarks>
        /// <param name="status">Status values that need to be considered for filter</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid status value</response>
        [HttpGet]
        [Route("/v2/pet/findByStatus")]
        [SwaggerOperation("FindPetsByStatus")]
        [SwaggerResponse(200, type: typeof(List<Pet>))]
        public virtual IActionResult FindPetsByStatus([FromQuery]List<string> status)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Pet>>(exampleJson)
            : default(List<Pet>);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Finds Pets by tags
        /// </summary>
        /// <remarks>Muliple tags can be provided with comma separated strings. Use tag1, tag2, tag3 for testing.</remarks>
        /// <param name="tags">Tags to filter by</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid tag value</response>
        [HttpGet]
        [Route("/v2/pet/findByTags")]
        [SwaggerOperation("FindPetsByTags")]
        [SwaggerResponse(200, type: typeof(List<Pet>))]
        public virtual IActionResult FindPetsByTags([FromQuery]List<string> tags)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Pet>>(exampleJson)
            : default(List<Pet>);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Find pet by ID
        /// </summary>
        /// <remarks>Returns a single pet</remarks>
        /// <param name="petId">ID of pet to return</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid ID supplied</response>
        /// <response code="404">Pet not found</response>
        [HttpGet]
        [Route("/v2/pet/{petId}")]
        [SwaggerOperation("GetPetById")]
        [SwaggerResponse(200, type: typeof(Pet))]
        public virtual IActionResult GetPetById([FromRoute]long? petId)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Pet>(exampleJson)
            : default(Pet);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Update an existing pet
        /// </summary>
        /// <remarks></remarks>
        /// <param name="body">Pet object that needs to be added to the store</param>
        /// <response code="400">Invalid ID supplied</response>
        /// <response code="404">Pet not found</response>
        /// <response code="405">Validation exception</response>
        [HttpPut]
        [Route("/v2/pet")]
        [SwaggerOperation("UpdatePet")]
        public virtual void UpdatePet([FromBody]Pet body)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Updates a pet in the store with form data
        /// </summary>
        /// <remarks></remarks>
        /// <param name="petId">ID of pet that needs to be updated</param>
        /// <param name="name">Updated name of the pet</param>
        /// <param name="status">Updated status of the pet</param>
        /// <response code="405">Invalid input</response>
        [HttpPost]
        [Route("/v2/pet/{petId}")]
        [SwaggerOperation("UpdatePetWithForm")]
        public virtual void UpdatePetWithForm([FromRoute]long? petId, [FromForm]string name, [FromForm]string status)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// uploads an image
        /// </summary>
        /// <remarks></remarks>
        /// <param name="petId">ID of pet to update</param>
        /// <param name="additionalMetadata">Additional data to pass to server</param>
        /// <param name="file">file to upload</param>
        /// <response code="200">successful operation</response>
        [HttpPost]
        [Route("/v2/pet/{petId}/uploadImage")]
        [SwaggerOperation("UploadFile")]
        [SwaggerResponse(200, type: typeof(ApiResponse))]
        public virtual IActionResult UploadFile([FromRoute]long? petId, [FromForm]string additionalMetadata, [FromForm]System.IO.Stream file)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ApiResponse>(exampleJson)
            : default(ApiResponse);
            return new ObjectResult(example);
        }
    }
}
