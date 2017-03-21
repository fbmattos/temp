/*
 * Simple Inventory API
 *
 * This is a simple APIasfdsadasdasd
 *
 * OpenAPI spec version: 1.0.0
 * Contact: you@your-company.com
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
    public class DevelopersApiController : Controller
    { 

        /// <summary>
        /// searches inventory
        /// </summary>
        /// <remarks>By passing in the appropriate options, you can search for available inventory in the system </remarks>
        /// <param name="searchString">pass an optional search string for looking up inventory</param>
        /// <param name="skip">number of records to skip for pagination</param>
        /// <param name="limit">maximum number of records to return</param>
        /// <response code="200">search results matching criteria</response>
        /// <response code="400">bad input parameter</response>
        [HttpGet]
        [Route("/org_test_ticket1572_2/test_ticket1579_mocking3/1.0.0/inventory")]
        [SwaggerOperation("SearchInventory")]
        [SwaggerResponse(200, type: typeof(List<InventoryItem>))]
        public virtual IActionResult SearchInventory([FromQuery]string searchString, [FromQuery]int? skip, [FromQuery]int? limit)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<InventoryItem>>(exampleJson)
            : default(List<InventoryItem>);
            return new ObjectResult(example);
        }
    }
}