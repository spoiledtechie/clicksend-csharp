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
    ///  Class for testing PostLetterApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by ClickSend Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestClass]
    public class PostLetterApiTests
    {
        private PostLetterApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            instance = new PostLetterApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TestCleanup]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PostLetterApi
        /// </summary>
        [TestMethod]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PostLetterApi
            //Assert.IsInstanceOfType(typeof(PostLetterApi), instance, "instance is a PostLetterApi");
        }

        /// <summary>
        /// Test PostLettersExportGet
        /// </summary>
        [TestMethod]
        public void PostLettersExportGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filename = null;
            //var response = instance.PostLettersExportGet(filename);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test PostLettersHistoryGet
        /// </summary>
        [TestMethod]
        public void PostLettersHistoryGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.PostLettersHistoryGet(page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test PostLettersPricePost
        /// </summary>
        [TestMethod]
        public void PostLettersPricePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PostLetter body = null;
            //var response = instance.PostLettersPricePost(body);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test PostLettersSendPost
        /// </summary>
        [TestMethod]
        public void PostLettersSendPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PostLetter body = null;
            //var response = instance.PostLettersSendPost(body);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
    }

}
