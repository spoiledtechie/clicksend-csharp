/* 
 * ClickSend v3 REST API
 *
 *  This is the official [ClickSend](https://clicksend.com) SDK.  *You'll need to create a free account to use the API. You can register [here](https://www.clicksend.com/signup).*  You can use our API documentation along with the SDK. Our API docs can be found [here](https://developers.clicksend.com). 
 *
 * OpenAPI spec version: 3.1.0
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
    ///  Class for testing SMSApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by ClickSend Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SMSApiTests
    {
        private SMSApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SMSApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SMSApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SMSApi
            //Assert.IsInstanceOfType(typeof(SMSApi), instance, "instance is a SMSApi");
        }

        
        /// <summary>
        /// Test SmsCancelAllPut
        /// </summary>
        [Test]
        public void SmsCancelAllPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.SmsCancelAllPut();
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test SmsCancelByMessageIdPut
        /// </summary>
        [Test]
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
        [Test]
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
        [Test]
        public void SmsHistoryGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? dateFrom = null;
            //int? dateTo = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.SmsHistoryGet(dateFrom, dateTo, page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test SmsInboundGet
        /// </summary>
        [Test]
        public void SmsInboundGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.SmsInboundGet(page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test SmsInboundPost
        /// </summary>
        [Test]
        public void SmsInboundPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string url = null;
            //var response = instance.SmsInboundPost(url);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test SmsInboundReadPut
        /// </summary>
        [Test]
        public void SmsInboundReadPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string dateBefore = null;
            //var response = instance.SmsInboundReadPut(dateBefore);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test SmsPricePost
        /// </summary>
        [Test]
        public void SmsPricePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SmsMessageCollection smsMessages = null;
            //var response = instance.SmsPricePost(smsMessages);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test SmsReceiptsByMessageIdGet
        /// </summary>
        [Test]
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
        [Test]
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
        [Test]
        public void SmsReceiptsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string url = null;
            //var response = instance.SmsReceiptsPost(url);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test SmsReceiptsReadPut
        /// </summary>
        [Test]
        public void SmsReceiptsReadPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string dateBefore = null;
            //var response = instance.SmsReceiptsReadPut(dateBefore);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test SmsSendPost
        /// </summary>
        [Test]
        public void SmsSendPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SmsMessageCollection smsMessages = null;
            //var response = instance.SmsSendPost(smsMessages);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test SmsTemplatesByTemplateIdDelete
        /// </summary>
        [Test]
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
        [Test]
        public void SmsTemplatesByTemplateIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? templateId = null;
            //SmsTemplate smsTemplate = null;
            //var response = instance.SmsTemplatesByTemplateIdPut(templateId, smsTemplate);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test SmsTemplatesGet
        /// </summary>
        [Test]
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
        [Test]
        public void SmsTemplatesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SmsTemplate smsTemplate = null;
            //var response = instance.SmsTemplatesPost(smsTemplate);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}