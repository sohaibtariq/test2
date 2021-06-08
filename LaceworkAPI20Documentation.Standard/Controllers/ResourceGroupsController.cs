// <copyright file="ResourceGroupsController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace LaceworkAPI20Documentation.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using LaceworkAPI20Documentation.Standard;
    using LaceworkAPI20Documentation.Standard.Authentication;
    using LaceworkAPI20Documentation.Standard.Exceptions;
    using LaceworkAPI20Documentation.Standard.Http.Client;
    using LaceworkAPI20Documentation.Standard.Http.Request;
    using LaceworkAPI20Documentation.Standard.Http.Response;
    using LaceworkAPI20Documentation.Standard.Utilities;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// ResourceGroupsController.
    /// </summary>
    public class ResourceGroupsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceGroupsController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        internal ResourceGroupsController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers)
            : base(config, httpClient, authManagers)
        {
        }

        /// <summary>
        /// Create a resource groups by specifying parameters in the request `body` when invoking the following endpoint:.
        ///   > `POST https://YourLacework.lacework.net/api/v2/ResourceGroups`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ResponseResourceGroups response from the API call.</returns>
        public Models.ResponseResourceGroups CreateResourceGroup(
                string authorization,
                string contentType,
                object body)
        {
            Task<Models.ResponseResourceGroups> t = this.CreateResourceGroupAsync(authorization, contentType, body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Create a resource groups by specifying parameters in the request `body` when invoking the following endpoint:.
        ///   > `POST https://YourLacework.lacework.net/api/v2/ResourceGroups`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseResourceGroups response from the API call.</returns>
        public async Task<Models.ResponseResourceGroups> CreateResourceGroupAsync(
                string authorization,
                string contentType,
                object body,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/ResourceGroups");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
                { "Authorization", authorization },
                { "Content-Type", contentType },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(body);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            if (response.StatusCode == 400)
            {
                throw new ResponseInvalidTypeException("Invalid data", context);
            }

            if (response.StatusCode == 500)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ResponseResourceGroups>(response.Body);
        }

        /// <summary>
        /// Get a list of all resource groups for the account by invoking the following endpoint:.
        ///   > `GET https://YourLacework.lacework.net/api/v2/ResourceGroups`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <returns>Returns the Models.ResponseResourceGroupsList response from the API call.</returns>
        public Models.ResponseResourceGroupsList ListAllResourceGroups(
                string authorization,
                string contentType)
        {
            Task<Models.ResponseResourceGroupsList> t = this.ListAllResourceGroupsAsync(authorization, contentType);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get a list of all resource groups for the account by invoking the following endpoint:.
        ///   > `GET https://YourLacework.lacework.net/api/v2/ResourceGroups`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseResourceGroupsList response from the API call.</returns>
        public async Task<Models.ResponseResourceGroupsList> ListAllResourceGroupsAsync(
                string authorization,
                string contentType,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/ResourceGroups");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
                { "Authorization", authorization },
                { "Content-Type", contentType },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            if (response.StatusCode == 400)
            {
                throw new ResponseInvalidTypeException("Invalid data", context);
            }

            if (response.StatusCode == 500)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ResponseResourceGroupsList>(response.Body);
        }

        /// <summary>
        /// Search resource groups by invoking the following endpoint:.
        ///   > `POST https://YourLacework.lacework.net/api/v2/ResourceGroups/search`.
        ///  To limit the returned result, optionally specify one or more `filters` in the request `body`. For more information about using filters, see the [Simple & Advanced Search section](/api/v2/docs/#tag/OVERVIEW). .
        ///   In the request `body`, optionally specify the list of fields to return in the response by specifying the list in the `returns` array, for example, `"returns":[ "name", "type", "enabled" ]`..
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ResponseResourceGroupsList response from the API call.</returns>
        public Models.ResponseResourceGroupsList SearchResourceGroups(
                string authorization,
                string contentType,
                Models.GETDATAREQUESTBODYFILTERS body)
        {
            Task<Models.ResponseResourceGroupsList> t = this.SearchResourceGroupsAsync(authorization, contentType, body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Search resource groups by invoking the following endpoint:.
        ///   > `POST https://YourLacework.lacework.net/api/v2/ResourceGroups/search`.
        ///  To limit the returned result, optionally specify one or more `filters` in the request `body`. For more information about using filters, see the [Simple & Advanced Search section](/api/v2/docs/#tag/OVERVIEW). .
        ///   In the request `body`, optionally specify the list of fields to return in the response by specifying the list in the `returns` array, for example, `"returns":[ "name", "type", "enabled" ]`..
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseResourceGroupsList response from the API call.</returns>
        public async Task<Models.ResponseResourceGroupsList> SearchResourceGroupsAsync(
                string authorization,
                string contentType,
                Models.GETDATAREQUESTBODYFILTERS body,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/ResourceGroups/search");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
                { "Authorization", authorization },
                { "Content-Type", contentType },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(body);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            if (response.StatusCode == 400)
            {
                throw new ResponseInvalidTypeException("Invalid data", context);
            }

            if (response.StatusCode == 500)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ResponseResourceGroupsList>(response.Body);
        }

        /// <summary>
        /// Get the details about a resource group by invoking the following endpoint:.
        ///   > `GET https://YourLacework.lacework.net/api/v2/ResourceGroups/{resourceGuid}`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="resourceGuid">Required parameter: Resource Group resourceGuid.</param>
        /// <returns>Returns the Models.ResponseResourceGroups response from the API call.</returns>
        public Models.ResponseResourceGroups ResourceGroupsDetails(
                string authorization,
                string contentType,
                string resourceGuid)
        {
            Task<Models.ResponseResourceGroups> t = this.ResourceGroupsDetailsAsync(authorization, contentType, resourceGuid);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get the details about a resource group by invoking the following endpoint:.
        ///   > `GET https://YourLacework.lacework.net/api/v2/ResourceGroups/{resourceGuid}`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="resourceGuid">Required parameter: Resource Group resourceGuid.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseResourceGroups response from the API call.</returns>
        public async Task<Models.ResponseResourceGroups> ResourceGroupsDetailsAsync(
                string authorization,
                string contentType,
                string resourceGuid,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/ResourceGroups/{resourceGuid}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "resourceGuid", resourceGuid },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
                { "Authorization", authorization },
                { "Content-Type", contentType },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            if (response.StatusCode == 400)
            {
                throw new ResponseInvalidTypeException("Invalid data", context);
            }

            if (response.StatusCode == 500)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ResponseResourceGroups>(response.Body);
        }

        /// <summary>
        /// Update a resource group by specifying parameters in the request body  when invoking the following endpoint: .
        ///   > `PATCH https://YourLacework.lacework.net/api/v2/ResourceGroups/{resourceGuid}` .
        ///   In the request body, only specify the parameter(s) that you want to update, for example, `{ "enabled" : 0 }`..
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="resourceGuid">Required parameter: Resource Group resourceGuid.</param>
        /// <param name="body">Required parameter: Only specify the parameter(s)  that you want to update, for example, `{ "enabled" : 0 }`..</param>
        /// <returns>Returns the Models.ResponseResourceGroups response from the API call.</returns>
        public Models.ResponseResourceGroups UpdateResourceGroups(
                string authorization,
                string contentType,
                string resourceGuid,
                object body)
        {
            Task<Models.ResponseResourceGroups> t = this.UpdateResourceGroupsAsync(authorization, contentType, resourceGuid, body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Update a resource group by specifying parameters in the request body  when invoking the following endpoint: .
        ///   > `PATCH https://YourLacework.lacework.net/api/v2/ResourceGroups/{resourceGuid}` .
        ///   In the request body, only specify the parameter(s) that you want to update, for example, `{ "enabled" : 0 }`..
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="resourceGuid">Required parameter: Resource Group resourceGuid.</param>
        /// <param name="body">Required parameter: Only specify the parameter(s)  that you want to update, for example, `{ "enabled" : 0 }`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseResourceGroups response from the API call.</returns>
        public async Task<Models.ResponseResourceGroups> UpdateResourceGroupsAsync(
                string authorization,
                string contentType,
                string resourceGuid,
                object body,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/ResourceGroups/{resourceGuid}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "resourceGuid", resourceGuid },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
                { "Authorization", authorization },
                { "Content-Type", contentType },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(body);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PatchBody(queryBuilder.ToString(), headers, bodyText);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            if (response.StatusCode == 400)
            {
                throw new ResponseInvalidTypeException("Invalid data", context);
            }

            if (response.StatusCode == 500)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ResponseResourceGroups>(response.Body);
        }

        /// <summary>
        /// Delete a resource group by invoking the following endpoint:.
        ///   > `DELETE https://YourLacework.lacework.net/api/v2/ResourceGroups/{resourceGuid}`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="resourceGuid">Required parameter: Resource Group resourceGuid.</param>
        public void DeleteResourceGroups(
                string authorization,
                string contentType,
                string resourceGuid)
        {
            Task t = this.DeleteResourceGroupsAsync(authorization, contentType, resourceGuid);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Delete a resource group by invoking the following endpoint:.
        ///   > `DELETE https://YourLacework.lacework.net/api/v2/ResourceGroups/{resourceGuid}`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="resourceGuid">Required parameter: Resource Group resourceGuid.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteResourceGroupsAsync(
                string authorization,
                string contentType,
                string resourceGuid,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/ResourceGroups/{resourceGuid}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "resourceGuid", resourceGuid },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "Authorization", authorization },
                { "Content-Type", contentType },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Delete(queryBuilder.ToString(), headers, null);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            if (response.StatusCode == 400)
            {
                throw new ResponseInvalidTypeException("Invalid data", context);
            }

            if (response.StatusCode == 500)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }
    }
}