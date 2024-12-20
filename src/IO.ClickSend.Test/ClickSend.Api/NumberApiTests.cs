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
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IO.ClickSend.Test
{
    /// <summary>
    ///  Class for testing NumberApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by ClickSend Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestClass]
    public class NumberApiTests
    {
        private NumberApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            instance = new NumberApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TestCleanup]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of NumberApi
        /// </summary>
        [TestMethod]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' NumberApi
            //Assert.IsInstanceOfType(typeof(NumberApi), instance, "instance is a NumberApi");
        }

        /// <summary>
        /// Test NumbersBuyByDedicatedNumberPost
        /// </summary>
        [TestMethod]
        public void NumbersBuyByDedicatedNumberPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string dedicatedNumber = null;
            //var response = instance.NumbersBuyByDedicatedNumberPost(dedicatedNumber);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test NumbersGet
        /// </summary>
        [TestMethod]
        public void NumbersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.NumbersGet(page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test NumbersSearchByCountryGet
        /// </summary>
        [TestMethod]
        public void NumbersSearchByCountryGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string country = null;
            //string search = null;
            //int? searchType = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.NumbersSearchByCountryGet(country, search, searchType, page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
    }

}
