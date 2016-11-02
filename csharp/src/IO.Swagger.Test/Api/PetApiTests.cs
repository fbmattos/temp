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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing PetApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PetApiTests
    {
        private PetApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PetApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PetApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PetApi
            //Assert.IsInstanceOfType(typeof(PetApi), instance, "instance is a PetApi");
        }

        
        /// <summary>
        /// Test AddPet
        /// </summary>
        [Test]
        public void AddPetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Pet body = null;
            //instance.AddPet(body);
            
        }
        
        /// <summary>
        /// Test DeletePet
        /// </summary>
        [Test]
        public void DeletePetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? petId = null;
            //string apiKey = null;
            //instance.DeletePet(petId, apiKey);
            
        }
        
        /// <summary>
        /// Test FindPetsByStatus
        /// </summary>
        [Test]
        public void FindPetsByStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> status = null;
            //var response = instance.FindPetsByStatus(status);
            //Assert.IsInstanceOf<List<Pet>> (response, "response is List<Pet>");
        }
        
        /// <summary>
        /// Test FindPetsByTags
        /// </summary>
        [Test]
        public void FindPetsByTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> tags = null;
            //var response = instance.FindPetsByTags(tags);
            //Assert.IsInstanceOf<List<Pet>> (response, "response is List<Pet>");
        }
        
        /// <summary>
        /// Test GetPetById
        /// </summary>
        [Test]
        public void GetPetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? petId = null;
            //var response = instance.GetPetById(petId);
            //Assert.IsInstanceOf<Pet> (response, "response is Pet");
        }
        
        /// <summary>
        /// Test UpdatePet
        /// </summary>
        [Test]
        public void UpdatePetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Pet body = null;
            //instance.UpdatePet(body);
            
        }
        
        /// <summary>
        /// Test UpdatePetWithForm
        /// </summary>
        [Test]
        public void UpdatePetWithFormTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? petId = null;
            //string name = null;
            //string status = null;
            //instance.UpdatePetWithForm(petId, name, status);
            
        }
        
        /// <summary>
        /// Test UploadFile
        /// </summary>
        [Test]
        public void UploadFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? petId = null;
            //string additionalMetadata = null;
            //System.IO.Stream file = null;
            //var response = instance.UploadFile(petId, additionalMetadata, file);
            //Assert.IsInstanceOf<ApiResponse> (response, "response is ApiResponse");
        }
        
    }

}