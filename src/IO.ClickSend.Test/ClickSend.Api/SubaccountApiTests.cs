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
    ///  Class for testing SubaccountApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by ClickSend Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestClass]
    public class SubaccountApiTests
    {
        private SubaccountApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            instance = new SubaccountApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TestCleanup]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SubaccountApi
        /// </summary>
        [TestMethod]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SubaccountApi
            //Assert.IsInstanceOfType(typeof(SubaccountApi), instance, "instance is a SubaccountApi");
        }

        /// <summary>
        /// Test SubaccountsBySubaccountIdDelete
        /// </summary>
        [TestMethod]
        public void SubaccountsBySubaccountIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? subaccountId = null;
            //var response = instance.SubaccountsBySubaccountIdDelete(subaccountId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test SubaccountsBySubaccountIdGet
        /// </summary>
        [TestMethod]
        public void SubaccountsBySubaccountIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? subaccountId = null;
            //var response = instance.SubaccountsBySubaccountIdGet(subaccountId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test SubaccountsBySubaccountIdPut
        /// </summary>
        [TestMethod]
        public void SubaccountsBySubaccountIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Subaccount body = null;
            //int? subaccountId = null;
            //var response = instance.SubaccountsBySubaccountIdPut(body, subaccountId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test SubaccountsGet
        /// </summary>
        [TestMethod]
        public void SubaccountsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.SubaccountsGet(page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test SubaccountsPost
        /// </summary>
        [TestMethod]
        public void SubaccountsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Subaccount body = null;
            //var response = instance.SubaccountsPost(body);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test SubaccountsRegenApiKeyBySubaccountIdPut
        /// </summary>
        [TestMethod]
        public void SubaccountsRegenApiKeyBySubaccountIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? subaccountId = null;
            //var response = instance.SubaccountsRegenApiKeyBySubaccountIdPut(subaccountId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
    }

}
