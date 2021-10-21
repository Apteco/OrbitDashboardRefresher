/* 
 * Apteco API
 *
 * An API to allow access to Apteco Marketing Suite resources
 *
 * OpenAPI spec version: v2
 * Contact: support@apteco.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Apteco.OrbitDashboardRefresher.APIClient.Client;
using Apteco.OrbitDashboardRefresher.APIClient.Model;

namespace Apteco.OrbitDashboardRefresher.APIClient.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDashboardHitsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Requires OrbitAdmin: Returns details for a given dashboard hit
        /// </summary>
        /// <remarks>
        /// This endpoint is only available for users with the OrbitAdmin role
        /// </remarks>
        /// <exception cref="Apteco.OrbitDashboardRefresher.APIClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="dashboardHitId">The id of the hit</param>
        /// <returns>DashboardHitDetail</returns>
        DashboardHitDetail DashboardHitsGetDashboardHit (string dataViewName, int? dashboardHitId);

        /// <summary>
        /// Requires OrbitAdmin: Returns details for a given dashboard hit
        /// </summary>
        /// <remarks>
        /// This endpoint is only available for users with the OrbitAdmin role
        /// </remarks>
        /// <exception cref="Apteco.OrbitDashboardRefresher.APIClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="dashboardHitId">The id of the hit</param>
        /// <returns>ApiResponse of DashboardHitDetail</returns>
        ApiResponse<DashboardHitDetail> DashboardHitsGetDashboardHitWithHttpInfo (string dataViewName, int? dashboardHitId);
        /// <summary>
        /// Requires OrbitAdmin: Returns all the hit information for all dashboards.
        /// </summary>
        /// <remarks>
        /// This endpoint is only available for users with the OrbitAdmin role
        /// </remarks>
        /// <exception cref="Apteco.OrbitDashboardRefresher.APIClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="filter">Filter the list of items using a simple expression language.  The available list of fields are Username, Timestamp, UserAgentDetails. (optional)</param>
        /// <param name="orderBy">Order the items by a given field (in ascending order unless the field is preceeded by a \&quot;-\&quot; character).  The available list of fields are Username, Timestamp, UserAgentDetails. (optional)</param>
        /// <param name="offset">The number of items to skip in the (potentially filtered) result set before returning subsequent items. (optional)</param>
        /// <param name="count">The maximum number of items to show from the (potentially filtered) result set. (optional)</param>
        /// <returns>PagedResultsDashboardHitSummary</returns>
        PagedResultsDashboardHitSummary DashboardHitsGetDashboardHits (string dataViewName, string filter = null, string orderBy = null, int? offset = null, int? count = null);

        /// <summary>
        /// Requires OrbitAdmin: Returns all the hit information for all dashboards.
        /// </summary>
        /// <remarks>
        /// This endpoint is only available for users with the OrbitAdmin role
        /// </remarks>
        /// <exception cref="Apteco.OrbitDashboardRefresher.APIClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="filter">Filter the list of items using a simple expression language.  The available list of fields are Username, Timestamp, UserAgentDetails. (optional)</param>
        /// <param name="orderBy">Order the items by a given field (in ascending order unless the field is preceeded by a \&quot;-\&quot; character).  The available list of fields are Username, Timestamp, UserAgentDetails. (optional)</param>
        /// <param name="offset">The number of items to skip in the (potentially filtered) result set before returning subsequent items. (optional)</param>
        /// <param name="count">The maximum number of items to show from the (potentially filtered) result set. (optional)</param>
        /// <returns>ApiResponse of PagedResultsDashboardHitSummary</returns>
        ApiResponse<PagedResultsDashboardHitSummary> DashboardHitsGetDashboardHitsWithHttpInfo (string dataViewName, string filter = null, string orderBy = null, int? offset = null, int? count = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Requires OrbitAdmin: Returns details for a given dashboard hit
        /// </summary>
        /// <remarks>
        /// This endpoint is only available for users with the OrbitAdmin role
        /// </remarks>
        /// <exception cref="Apteco.OrbitDashboardRefresher.APIClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="dashboardHitId">The id of the hit</param>
        /// <returns>Task of DashboardHitDetail</returns>
        System.Threading.Tasks.Task<DashboardHitDetail> DashboardHitsGetDashboardHitAsync (string dataViewName, int? dashboardHitId);

        /// <summary>
        /// Requires OrbitAdmin: Returns details for a given dashboard hit
        /// </summary>
        /// <remarks>
        /// This endpoint is only available for users with the OrbitAdmin role
        /// </remarks>
        /// <exception cref="Apteco.OrbitDashboardRefresher.APIClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="dashboardHitId">The id of the hit</param>
        /// <returns>Task of ApiResponse (DashboardHitDetail)</returns>
        System.Threading.Tasks.Task<ApiResponse<DashboardHitDetail>> DashboardHitsGetDashboardHitAsyncWithHttpInfo (string dataViewName, int? dashboardHitId);
        /// <summary>
        /// Requires OrbitAdmin: Returns all the hit information for all dashboards.
        /// </summary>
        /// <remarks>
        /// This endpoint is only available for users with the OrbitAdmin role
        /// </remarks>
        /// <exception cref="Apteco.OrbitDashboardRefresher.APIClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="filter">Filter the list of items using a simple expression language.  The available list of fields are Username, Timestamp, UserAgentDetails. (optional)</param>
        /// <param name="orderBy">Order the items by a given field (in ascending order unless the field is preceeded by a \&quot;-\&quot; character).  The available list of fields are Username, Timestamp, UserAgentDetails. (optional)</param>
        /// <param name="offset">The number of items to skip in the (potentially filtered) result set before returning subsequent items. (optional)</param>
        /// <param name="count">The maximum number of items to show from the (potentially filtered) result set. (optional)</param>
        /// <returns>Task of PagedResultsDashboardHitSummary</returns>
        System.Threading.Tasks.Task<PagedResultsDashboardHitSummary> DashboardHitsGetDashboardHitsAsync (string dataViewName, string filter = null, string orderBy = null, int? offset = null, int? count = null);

        /// <summary>
        /// Requires OrbitAdmin: Returns all the hit information for all dashboards.
        /// </summary>
        /// <remarks>
        /// This endpoint is only available for users with the OrbitAdmin role
        /// </remarks>
        /// <exception cref="Apteco.OrbitDashboardRefresher.APIClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="filter">Filter the list of items using a simple expression language.  The available list of fields are Username, Timestamp, UserAgentDetails. (optional)</param>
        /// <param name="orderBy">Order the items by a given field (in ascending order unless the field is preceeded by a \&quot;-\&quot; character).  The available list of fields are Username, Timestamp, UserAgentDetails. (optional)</param>
        /// <param name="offset">The number of items to skip in the (potentially filtered) result set before returning subsequent items. (optional)</param>
        /// <param name="count">The maximum number of items to show from the (potentially filtered) result set. (optional)</param>
        /// <returns>Task of ApiResponse (PagedResultsDashboardHitSummary)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagedResultsDashboardHitSummary>> DashboardHitsGetDashboardHitsAsyncWithHttpInfo (string dataViewName, string filter = null, string orderBy = null, int? offset = null, int? count = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DashboardHitsApi : IDashboardHitsApi
    {
        private Apteco.OrbitDashboardRefresher.APIClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardHitsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DashboardHitsApi(String basePath)
        {
            this.Configuration = new Apteco.OrbitDashboardRefresher.APIClient.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Apteco.OrbitDashboardRefresher.APIClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardHitsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DashboardHitsApi(Apteco.OrbitDashboardRefresher.APIClient.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Apteco.OrbitDashboardRefresher.APIClient.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Apteco.OrbitDashboardRefresher.APIClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
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
        public Apteco.OrbitDashboardRefresher.APIClient.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Apteco.OrbitDashboardRefresher.APIClient.Client.ExceptionFactory ExceptionFactory
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
        /// Requires OrbitAdmin: Returns details for a given dashboard hit This endpoint is only available for users with the OrbitAdmin role
        /// </summary>
        /// <exception cref="Apteco.OrbitDashboardRefresher.APIClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="dashboardHitId">The id of the hit</param>
        /// <returns>DashboardHitDetail</returns>
        public DashboardHitDetail DashboardHitsGetDashboardHit (string dataViewName, int? dashboardHitId)
        {
             ApiResponse<DashboardHitDetail> localVarResponse = DashboardHitsGetDashboardHitWithHttpInfo(dataViewName, dashboardHitId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Requires OrbitAdmin: Returns details for a given dashboard hit This endpoint is only available for users with the OrbitAdmin role
        /// </summary>
        /// <exception cref="Apteco.OrbitDashboardRefresher.APIClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="dashboardHitId">The id of the hit</param>
        /// <returns>ApiResponse of DashboardHitDetail</returns>
        public ApiResponse< DashboardHitDetail > DashboardHitsGetDashboardHitWithHttpInfo (string dataViewName, int? dashboardHitId)
        {
            // verify the required parameter 'dataViewName' is set
            if (dataViewName == null)
                throw new ApiException(400, "Missing required parameter 'dataViewName' when calling DashboardHitsApi->DashboardHitsGetDashboardHit");
            // verify the required parameter 'dashboardHitId' is set
            if (dashboardHitId == null)
                throw new ApiException(400, "Missing required parameter 'dashboardHitId' when calling DashboardHitsApi->DashboardHitsGetDashboardHit");

            var localVarPath = "/{dataViewName}/DashboardHits/{dashboardHitId}";
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
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (dataViewName != null) localVarPathParams.Add("dataViewName", this.Configuration.ApiClient.ParameterToString(dataViewName)); // path parameter
            if (dashboardHitId != null) localVarPathParams.Add("dashboardHitId", this.Configuration.ApiClient.ParameterToString(dashboardHitId)); // path parameter

            // authentication (faststats_auth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DashboardHitsGetDashboardHit", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DashboardHitDetail>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DashboardHitDetail) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DashboardHitDetail)));
        }

        /// <summary>
        /// Requires OrbitAdmin: Returns details for a given dashboard hit This endpoint is only available for users with the OrbitAdmin role
        /// </summary>
        /// <exception cref="Apteco.OrbitDashboardRefresher.APIClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="dashboardHitId">The id of the hit</param>
        /// <returns>Task of DashboardHitDetail</returns>
        public async System.Threading.Tasks.Task<DashboardHitDetail> DashboardHitsGetDashboardHitAsync (string dataViewName, int? dashboardHitId)
        {
             ApiResponse<DashboardHitDetail> localVarResponse = await DashboardHitsGetDashboardHitAsyncWithHttpInfo(dataViewName, dashboardHitId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Requires OrbitAdmin: Returns details for a given dashboard hit This endpoint is only available for users with the OrbitAdmin role
        /// </summary>
        /// <exception cref="Apteco.OrbitDashboardRefresher.APIClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="dashboardHitId">The id of the hit</param>
        /// <returns>Task of ApiResponse (DashboardHitDetail)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DashboardHitDetail>> DashboardHitsGetDashboardHitAsyncWithHttpInfo (string dataViewName, int? dashboardHitId)
        {
            // verify the required parameter 'dataViewName' is set
            if (dataViewName == null)
                throw new ApiException(400, "Missing required parameter 'dataViewName' when calling DashboardHitsApi->DashboardHitsGetDashboardHit");
            // verify the required parameter 'dashboardHitId' is set
            if (dashboardHitId == null)
                throw new ApiException(400, "Missing required parameter 'dashboardHitId' when calling DashboardHitsApi->DashboardHitsGetDashboardHit");

            var localVarPath = "/{dataViewName}/DashboardHits/{dashboardHitId}";
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
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (dataViewName != null) localVarPathParams.Add("dataViewName", this.Configuration.ApiClient.ParameterToString(dataViewName)); // path parameter
            if (dashboardHitId != null) localVarPathParams.Add("dashboardHitId", this.Configuration.ApiClient.ParameterToString(dashboardHitId)); // path parameter

            // authentication (faststats_auth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DashboardHitsGetDashboardHit", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DashboardHitDetail>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DashboardHitDetail) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DashboardHitDetail)));
        }

        /// <summary>
        /// Requires OrbitAdmin: Returns all the hit information for all dashboards. This endpoint is only available for users with the OrbitAdmin role
        /// </summary>
        /// <exception cref="Apteco.OrbitDashboardRefresher.APIClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="filter">Filter the list of items using a simple expression language.  The available list of fields are Username, Timestamp, UserAgentDetails. (optional)</param>
        /// <param name="orderBy">Order the items by a given field (in ascending order unless the field is preceeded by a \&quot;-\&quot; character).  The available list of fields are Username, Timestamp, UserAgentDetails. (optional)</param>
        /// <param name="offset">The number of items to skip in the (potentially filtered) result set before returning subsequent items. (optional)</param>
        /// <param name="count">The maximum number of items to show from the (potentially filtered) result set. (optional)</param>
        /// <returns>PagedResultsDashboardHitSummary</returns>
        public PagedResultsDashboardHitSummary DashboardHitsGetDashboardHits (string dataViewName, string filter = null, string orderBy = null, int? offset = null, int? count = null)
        {
             ApiResponse<PagedResultsDashboardHitSummary> localVarResponse = DashboardHitsGetDashboardHitsWithHttpInfo(dataViewName, filter, orderBy, offset, count);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Requires OrbitAdmin: Returns all the hit information for all dashboards. This endpoint is only available for users with the OrbitAdmin role
        /// </summary>
        /// <exception cref="Apteco.OrbitDashboardRefresher.APIClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="filter">Filter the list of items using a simple expression language.  The available list of fields are Username, Timestamp, UserAgentDetails. (optional)</param>
        /// <param name="orderBy">Order the items by a given field (in ascending order unless the field is preceeded by a \&quot;-\&quot; character).  The available list of fields are Username, Timestamp, UserAgentDetails. (optional)</param>
        /// <param name="offset">The number of items to skip in the (potentially filtered) result set before returning subsequent items. (optional)</param>
        /// <param name="count">The maximum number of items to show from the (potentially filtered) result set. (optional)</param>
        /// <returns>ApiResponse of PagedResultsDashboardHitSummary</returns>
        public ApiResponse< PagedResultsDashboardHitSummary > DashboardHitsGetDashboardHitsWithHttpInfo (string dataViewName, string filter = null, string orderBy = null, int? offset = null, int? count = null)
        {
            // verify the required parameter 'dataViewName' is set
            if (dataViewName == null)
                throw new ApiException(400, "Missing required parameter 'dataViewName' when calling DashboardHitsApi->DashboardHitsGetDashboardHits");

            var localVarPath = "/{dataViewName}/DashboardHits";
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
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (dataViewName != null) localVarPathParams.Add("dataViewName", this.Configuration.ApiClient.ParameterToString(dataViewName)); // path parameter
            if (filter != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "filter", filter)); // query parameter
            if (orderBy != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "orderBy", orderBy)); // query parameter
            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (count != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "count", count)); // query parameter

            // authentication (faststats_auth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DashboardHitsGetDashboardHits", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PagedResultsDashboardHitSummary>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagedResultsDashboardHitSummary) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagedResultsDashboardHitSummary)));
        }

        /// <summary>
        /// Requires OrbitAdmin: Returns all the hit information for all dashboards. This endpoint is only available for users with the OrbitAdmin role
        /// </summary>
        /// <exception cref="Apteco.OrbitDashboardRefresher.APIClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="filter">Filter the list of items using a simple expression language.  The available list of fields are Username, Timestamp, UserAgentDetails. (optional)</param>
        /// <param name="orderBy">Order the items by a given field (in ascending order unless the field is preceeded by a \&quot;-\&quot; character).  The available list of fields are Username, Timestamp, UserAgentDetails. (optional)</param>
        /// <param name="offset">The number of items to skip in the (potentially filtered) result set before returning subsequent items. (optional)</param>
        /// <param name="count">The maximum number of items to show from the (potentially filtered) result set. (optional)</param>
        /// <returns>Task of PagedResultsDashboardHitSummary</returns>
        public async System.Threading.Tasks.Task<PagedResultsDashboardHitSummary> DashboardHitsGetDashboardHitsAsync (string dataViewName, string filter = null, string orderBy = null, int? offset = null, int? count = null)
        {
             ApiResponse<PagedResultsDashboardHitSummary> localVarResponse = await DashboardHitsGetDashboardHitsAsyncWithHttpInfo(dataViewName, filter, orderBy, offset, count);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Requires OrbitAdmin: Returns all the hit information for all dashboards. This endpoint is only available for users with the OrbitAdmin role
        /// </summary>
        /// <exception cref="Apteco.OrbitDashboardRefresher.APIClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="filter">Filter the list of items using a simple expression language.  The available list of fields are Username, Timestamp, UserAgentDetails. (optional)</param>
        /// <param name="orderBy">Order the items by a given field (in ascending order unless the field is preceeded by a \&quot;-\&quot; character).  The available list of fields are Username, Timestamp, UserAgentDetails. (optional)</param>
        /// <param name="offset">The number of items to skip in the (potentially filtered) result set before returning subsequent items. (optional)</param>
        /// <param name="count">The maximum number of items to show from the (potentially filtered) result set. (optional)</param>
        /// <returns>Task of ApiResponse (PagedResultsDashboardHitSummary)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagedResultsDashboardHitSummary>> DashboardHitsGetDashboardHitsAsyncWithHttpInfo (string dataViewName, string filter = null, string orderBy = null, int? offset = null, int? count = null)
        {
            // verify the required parameter 'dataViewName' is set
            if (dataViewName == null)
                throw new ApiException(400, "Missing required parameter 'dataViewName' when calling DashboardHitsApi->DashboardHitsGetDashboardHits");

            var localVarPath = "/{dataViewName}/DashboardHits";
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
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (dataViewName != null) localVarPathParams.Add("dataViewName", this.Configuration.ApiClient.ParameterToString(dataViewName)); // path parameter
            if (filter != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "filter", filter)); // query parameter
            if (orderBy != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "orderBy", orderBy)); // query parameter
            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (count != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "count", count)); // query parameter

            // authentication (faststats_auth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DashboardHitsGetDashboardHits", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PagedResultsDashboardHitSummary>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagedResultsDashboardHitSummary) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagedResultsDashboardHitSummary)));
        }

    }
}
