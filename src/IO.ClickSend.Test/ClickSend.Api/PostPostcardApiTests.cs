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
using NUnit.Framework;

using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.ClickSend.Model;

namespace IO.ClickSend.Test
{
    /// <summary>
    ///  Class for testing PostPostcardApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by ClickSend Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PostPostcardApiTests
    {
        private PostPostcardApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PostPostcardApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PostPostcardApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PostPostcardApi
            //Assert.IsInstanceOfType(typeof(PostPostcardApi), instance, "instance is a PostPostcardApi");
        }

        
        /// <summary>
        /// Test PostPostcardsHistoryExportGet
        /// </summary>
        [Test]
        public void PostPostcardsHistoryExportGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filename = null;
            //var response = instance.PostPostcardsHistoryExportGet(filename);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test PostPostcardsHistoryGet
        /// </summary>
        [Test]
        public void PostPostcardsHistoryGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.PostPostcardsHistoryGet(page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test PostPostcardsPricePost
        /// </summary>
        [Test]
        public void PostPostcardsPricePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PostPostcard postPostcards = null;
            //var response = instance.PostPostcardsPricePost(postPostcards);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test PostPostcardsSendPost
        /// </summary>
        [Test]
        public void PostPostcardsSendPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PostPostcard postPostcards = null;
            //var response = instance.PostPostcardsSendPost(postPostcards);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}
