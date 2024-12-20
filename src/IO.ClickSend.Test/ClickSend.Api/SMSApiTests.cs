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
    ///  Class for testing SMSApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by ClickSend Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestClass]
    public class SMSApiTests
    {
        private SMSApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            instance = new SMSApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TestCleanup]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SMSApi
        /// </summary>
        [TestMethod]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SMSApi
            //Assert.IsInstanceOfType(typeof(SMSApi), instance, "instance is a SMSApi");
        }

        /// <summary>
        /// Test SmsCancelAllPut
        /// </summary>
        [TestMethod]
        public void SmsCancelAllPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.SmsCancelAllPut();
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test SmsCancelByMessageIdPut
        /// </summary>
        [TestMethod]
        public void SmsCancelByMessageIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string messageId = null;
            //var response = instance.SmsCancelByMessageIdPut(messageId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test SmsHistoryExportGet
        /// </summary>
        [TestMethod]
        public void SmsHistoryExportGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filename = null;
            //var response = instance.SmsHistoryExportGet(filename);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test SmsHistoryGet
        /// </summary>
        [TestMethod]
        public void SmsHistoryGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string q = null;
            //int? dateFrom = null;
            //int? dateTo = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.SmsHistoryGet(q, dateFrom, dateTo, page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test SmsInboundGet
        /// </summary>
        [TestMethod]
        public void SmsInboundGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string q = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.SmsInboundGet(q, page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test SmsInboundPost
        /// </summary>
        [TestMethod]
        public void SmsInboundPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Url body = null;
            //var response = instance.SmsInboundPost(body);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test SmsInboundReadByMessageIdPut
        /// </summary>
        [TestMethod]
        public void SmsInboundReadByMessageIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string messageId = null;
            //var response = instance.SmsInboundReadByMessageIdPut(messageId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test SmsInboundReadPut
        /// </summary>
        [TestMethod]
        public void SmsInboundReadPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateBefore body = null;
            //var response = instance.SmsInboundReadPut(body);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test SmsPricePost
        /// </summary>
        [TestMethod]
        public void SmsPricePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SmsMessageCollection body = null;
            //var response = instance.SmsPricePost(body);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test SmsReceiptsByMessageIdGet
        /// </summary>
        [TestMethod]
        public void SmsReceiptsByMessageIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string messageId = null;
            //var response = instance.SmsReceiptsByMessageIdGet(messageId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test SmsReceiptsGet
        /// </summary>
        [TestMethod]
        public void SmsReceiptsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.SmsReceiptsGet(page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test SmsReceiptsPost
        /// </summary>
        [TestMethod]
        public void SmsReceiptsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Url body = null;
            //var response = instance.SmsReceiptsPost(body);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test SmsReceiptsReadPut
        /// </summary>
        [TestMethod]
        public void SmsReceiptsReadPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateBefore body = null;
            //var response = instance.SmsReceiptsReadPut(body);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test SmsSendPost
        /// </summary>
        [TestMethod]
        public void SmsSendPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SmsMessageCollection body = null;
            //var response = instance.SmsSendPost(body);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test SmsTemplatesByTemplateIdDelete
        /// </summary>
        [TestMethod]
        public void SmsTemplatesByTemplateIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? templateId = null;
            //var response = instance.SmsTemplatesByTemplateIdDelete(templateId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test SmsTemplatesByTemplateIdPut
        /// </summary>
        [TestMethod]
        public void SmsTemplatesByTemplateIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SmsTemplate body = null;
            //int? templateId = null;
            //var response = instance.SmsTemplatesByTemplateIdPut(body, templateId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test SmsTemplatesGet
        /// </summary>
        [TestMethod]
        public void SmsTemplatesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.SmsTemplatesGet(page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test SmsTemplatesPost
        /// </summary>
        [TestMethod]
        public void SmsTemplatesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SmsTemplate body = null;
            //var response = instance.SmsTemplatesPost(body);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
    }

}
