/* 
 * ClickSend v3 API
 *
 *  This is an official SDK for [ClickSend](https://clicksend.com)  Below you will find a current list of the available methods for clicksend.  *NOTE: You will need to create a free account to use the API. You can register [here](https://dashboard.clicksend.com/#/signup/step1/)..* 
 *
 * OpenAPI spec version: 3.1
 * Contact: support@clicksend.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.ClickSend.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IO.ClickSend.Test
{
    /// <summary>
    ///  Class for testing ResellerAccountApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by ClickSend Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestClass]
    public class ResellerAccountApiTests
    {
        private ResellerAccountApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            instance = new ResellerAccountApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TestCleanup]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ResellerAccountApi
        /// </summary>
        [TestMethod]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ResellerAccountApi
            //Assert.IsInstanceOfType(typeof(ResellerAccountApi), instance, "instance is a ResellerAccountApi");
        }

        /// <summary>
        /// Test ResellerAccountsByClientUserIdGet
        /// </summary>
        [TestMethod]
        public void ResellerAccountsByClientUserIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? clientUserId = null;
            //var response = instance.ResellerAccountsByClientUserIdGet(clientUserId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test ResellerAccountsByClientUserIdPut
        /// </summary>
        [TestMethod]
        public void ResellerAccountsByClientUserIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ResellerAccount body = null;
            //int? clientUserId = null;
            //var response = instance.ResellerAccountsByClientUserIdPut(body, clientUserId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test ResellerAccountsGet
        /// </summary>
        [TestMethod]
        public void ResellerAccountsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.ResellerAccountsGet(page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test ResellerAccountsPost
        /// </summary>
        [TestMethod]
        public void ResellerAccountsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ResellerAccount body = null;
            //var response = instance.ResellerAccountsPost(body);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
    }

}
