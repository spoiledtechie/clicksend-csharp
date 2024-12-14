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
    ///  Class for testing MMSApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by ClickSend Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestClass]
    public class MMSApiTests
    {
        private MMSApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            instance = new MMSApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TestCleanup]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MMSApi
        /// </summary>
        [TestMethod]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' MMSApi
            //Assert.IsInstanceOfType(typeof(MMSApi), instance, "instance is a MMSApi");
        }

        /// <summary>
        /// Test MmsHistoryExportGet
        /// </summary>
        [TestMethod]
        public void MmsHistoryExportGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filename = null;
            //var response = instance.MmsHistoryExportGet(filename);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test MmsHistoryGet
        /// </summary>
        [TestMethod]
        public void MmsHistoryGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string q = null;
            //int? dateFrom = null;
            //int? dateTo = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.MmsHistoryGet(q, dateFrom, dateTo, page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test MmsPricePost
        /// </summary>
        [TestMethod]
        public void MmsPricePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MmsMessageCollection body = null;
            //var response = instance.MmsPricePost(body);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test MmsReceiptsGet
        /// </summary>
        [TestMethod]
        public void MmsReceiptsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.MmsReceiptsGet(page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test MmsReceiptsReadPut
        /// </summary>
        [TestMethod]
        public void MmsReceiptsReadPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateBefore body = null;
            //var response = instance.MmsReceiptsReadPut(body);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test MmsSendPost
        /// </summary>
        [TestMethod]
        public void MmsSendPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MmsMessageCollection body = null;
            //var response = instance.MmsSendPost(body);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
    }

}
