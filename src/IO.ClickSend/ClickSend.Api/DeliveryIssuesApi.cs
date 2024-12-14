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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace IO.ClickSend.ClickSend.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface IDeliveryIssuesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get all delivery issues
        /// </summary>
        /// <remarks>
        /// Get all delivery issues
        /// </remarks>
        /// <exception cref="IO.ClickSend.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Page number (optional, default to 1)</param>
        /// <param name="limit">Number of records per page (optional, default to 10)</param>
        /// <returns>string</returns>
        string DeliveryIssuesGet (int? page = null, int? limit = null);

        /// <summary>
        /// Get all delivery issues
        /// </summary>
        /// <remarks>
        /// Get all delivery issues
        /// </remarks>
        /// <exception cref="IO.ClickSend.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Page number (optional, default to 1)</param>
        /// <param name="limit">Number of records per page (optional, default to 10)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeliveryIssuesGetWithHttpInfo (int? page = null, int? limit = null);
        /// <summary>
        /// Create delivery Issue
        /// </summary>
        /// <remarks>
        /// Create delivery Issue
        /// </remarks>
        /// <exception cref="IO.ClickSend.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DeliveryIssue model</param>
        /// <returns>string</returns>
        string DeliveryIssuesPost (DeliveryIssue body);

        /// <summary>
        /// Create delivery Issue
        /// </summary>
        /// <remarks>
        /// Create delivery Issue
        /// </remarks>
        /// <exception cref="IO.ClickSend.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DeliveryIssue model</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeliveryIssuesPostWithHttpInfo (DeliveryIssue body);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get all delivery issues
        /// </summary>
        /// <remarks>
        /// Get all delivery issues
        /// </remarks>
        /// <exception cref="IO.ClickSend.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Page number (optional, default to 1)</param>
        /// <param name="limit">Number of records per page (optional, default to 10)</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeliveryIssuesGetAsync (int? page = null, int? limit = null);

        /// <summary>
        /// Get all delivery issues
        /// </summary>
        /// <remarks>
        /// Get all delivery issues
        /// </remarks>
        /// <exception cref="IO.ClickSend.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Page number (optional, default to 1)</param>
        /// <param name="limit">Number of records per page (optional, default to 10)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeliveryIssuesGetAsyncWithHttpInfo (int? page = null, int? limit = null);
        /// <summary>
        /// Create delivery Issue
        /// </summary>
        /// <remarks>
        /// Create delivery Issue
        /// </remarks>
        /// <exception cref="IO.ClickSend.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DeliveryIssue model</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeliveryIssuesPostAsync (DeliveryIssue body);

        /// <summary>
        /// Create delivery Issue
        /// </summary>
        /// <remarks>
        /// Create delivery Issue
        /// </remarks>
        /// <exception cref="IO.ClickSend.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DeliveryIssue model</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeliveryIssuesPostAsyncWithHttpInfo (DeliveryIssue body);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class DeliveryIssuesApi : IDeliveryIssuesApi
    {
        private IO.ClickSend.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryIssuesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DeliveryIssuesApi(String basePath)
        {
            this.Configuration = new IO.ClickSend.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.ClickSend.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryIssuesApi"/> class
        /// </summary>
        /// <returns></returns>
        public DeliveryIssuesApi()
        {
            this.Configuration = IO.ClickSend.Client.Configuration.Default;

            ExceptionFactory = IO.ClickSend.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryIssuesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DeliveryIssuesApi(IO.ClickSend.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = IO.ClickSend.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.ClickSend.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.Options.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IO.ClickSend.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.ClickSend.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Get all delivery issues Get all delivery issues
        /// </summary>
        /// <exception cref="IO.ClickSend.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Page number (optional, default to 1)</param>
        /// <param name="limit">Number of records per page (optional, default to 10)</param>
        /// <returns>string</returns>
        public string DeliveryIssuesGet (int? page = null, int? limit = null)
        {
             ApiResponse<string> localVarResponse = DeliveryIssuesGetWithHttpInfo(page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all delivery issues Get all delivery issues
        /// </summary>
        /// <exception cref="IO.ClickSend.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Page number (optional, default to 1)</param>
        /// <param name="limit">Number of records per page (optional, default to 10)</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeliveryIssuesGetWithHttpInfo (int? page = null, int? limit = null)
        {

            var localVarPath = "/delivery-issues";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            // authentication (BasicAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeliveryIssuesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (string) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Get all delivery issues Get all delivery issues
        /// </summary>
        /// <exception cref="IO.ClickSend.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Page number (optional, default to 1)</param>
        /// <param name="limit">Number of records per page (optional, default to 10)</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeliveryIssuesGetAsync (int? page = null, int? limit = null)
        {
             ApiResponse<string> localVarResponse = await DeliveryIssuesGetAsyncWithHttpInfo(page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all delivery issues Get all delivery issues
        /// </summary>
        /// <exception cref="IO.ClickSend.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Page number (optional, default to 1)</param>
        /// <param name="limit">Number of records per page (optional, default to 10)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeliveryIssuesGetAsyncWithHttpInfo (int? page = null, int? limit = null)
        {

            var localVarPath = "/delivery-issues";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            // authentication (BasicAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeliveryIssuesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (string) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Create delivery Issue Create delivery Issue
        /// </summary>
        /// <exception cref="IO.ClickSend.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DeliveryIssue model</param>
        /// <returns>string</returns>
        public string DeliveryIssuesPost (DeliveryIssue body)
        {
             ApiResponse<string> localVarResponse = DeliveryIssuesPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create delivery Issue Create delivery Issue
        /// </summary>
        /// <exception cref="IO.ClickSend.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DeliveryIssue model</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeliveryIssuesPostWithHttpInfo (DeliveryIssue body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling DeliveryIssuesApi->DeliveryIssuesPost");

            var localVarPath = "/delivery-issues";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            // authentication (BasicAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeliveryIssuesPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (string) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Create delivery Issue Create delivery Issue
        /// </summary>
        /// <exception cref="IO.ClickSend.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DeliveryIssue model</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeliveryIssuesPostAsync (DeliveryIssue body)
        {
             ApiResponse<string> localVarResponse = await DeliveryIssuesPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create delivery Issue Create delivery Issue
        /// </summary>
        /// <exception cref="IO.ClickSend.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DeliveryIssue model</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeliveryIssuesPostAsyncWithHttpInfo (DeliveryIssue body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling DeliveryIssuesApi->DeliveryIssuesPost");

            var localVarPath = "/delivery-issues";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            // authentication (BasicAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeliveryIssuesPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (string) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

    }
}
