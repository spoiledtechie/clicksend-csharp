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
    ///  Class for testing ContactApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by ClickSend Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestClass]
    public class ContactApiTests
    {
        private ContactApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            instance = new ContactApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TestCleanup]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ContactApi
        /// </summary>
        [TestMethod]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ContactApi
            //Assert.IsInstanceOfType(typeof(ContactApi), instance, "instance is a ContactApi");
        }

        /// <summary>
        /// Test ListsContactsByListIdAndContactIdDelete
        /// </summary>
        [TestMethod]
        public void ListsContactsByListIdAndContactIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? listId = null;
            //int? contactId = null;
            //var response = instance.ListsContactsByListIdAndContactIdDelete(listId, contactId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test ListsContactsByListIdAndContactIdGet
        /// </summary>
        [TestMethod]
        public void ListsContactsByListIdAndContactIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? listId = null;
            //int? contactId = null;
            //var response = instance.ListsContactsByListIdAndContactIdGet(listId, contactId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test ListsContactsByListIdAndContactIdPut
        /// </summary>
        [TestMethod]
        public void ListsContactsByListIdAndContactIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Contact body = null;
            //int? listId = null;
            //int? contactId = null;
            //var response = instance.ListsContactsByListIdAndContactIdPut(body, listId, contactId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test ListsContactsByListIdGet
        /// </summary>
        [TestMethod]
        public void ListsContactsByListIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? listId = null;
            //int? page = null;
            //int? limit = null;
            //int? updatedAfter = null;
            //var response = instance.ListsContactsByListIdGet(listId, page, limit, updatedAfter);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test ListsContactsByListIdPost
        /// </summary>
        [TestMethod]
        public void ListsContactsByListIdPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Contact body = null;
            //int? listId = null;
            //var response = instance.ListsContactsByListIdPost(body, listId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test ListsCopyContactPut
        /// </summary>
        [TestMethod]
        public void ListsCopyContactPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? fromListId = null;
            //int? contactId = null;
            //int? toListId = null;
            //var response = instance.ListsCopyContactPut(fromListId, contactId, toListId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test ListsRemoveOptedOutContactsByListIdAndOptOutListIdPut
        /// </summary>
        [TestMethod]
        public void ListsRemoveOptedOutContactsByListIdAndOptOutListIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? listId = null;
            //int? optOutListId = null;
            //var response = instance.ListsRemoveOptedOutContactsByListIdAndOptOutListIdPut(listId, optOutListId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test ListsTransferContactPut
        /// </summary>
        [TestMethod]
        public void ListsTransferContactPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? fromListId = null;
            //int? contactId = null;
            //int? toListId = null;
            //var response = instance.ListsTransferContactPut(fromListId, contactId, toListId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
    }

}
