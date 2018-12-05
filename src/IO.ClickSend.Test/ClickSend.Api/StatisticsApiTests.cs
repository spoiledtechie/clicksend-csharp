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

namespace IO.ClickSend.Test
{
    /// <summary>
    ///  Class for testing StatisticsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by ClickSend Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class StatisticsApiTests
    {
        private StatisticsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new StatisticsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of StatisticsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' StatisticsApi
            //Assert.IsInstanceOfType(typeof(StatisticsApi), instance, "instance is a StatisticsApi");
        }

        
        /// <summary>
        /// Test StatisticsSmsGet
        /// </summary>
        [Test]
        public void StatisticsSmsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.StatisticsSmsGet();
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test StatisticsVoiceGet
        /// </summary>
        [Test]
        public void StatisticsVoiceGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.StatisticsVoiceGet();
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}
