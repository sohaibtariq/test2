// <copyright file="CloudAccountsController.cs" company="APIMatic">
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
    /// CloudAccountsController.
    /// </summary>
    public class CloudAccountsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudAccountsController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        internal CloudAccountsController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers)
            : base(config, httpClient, authManagers)
        {
        }

        /// <summary>
        /// Create a cloud account by specifying parameters in the request  body when invoking the following endpoint:.
        ///   > `POST https://YourLacework.lacework.net/api/v2/CloudAccounts`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ResponseCloudAccounts response from the API call.</returns>
        public Models.ResponseCloudAccounts CreateCloudAccounts(
                string authorization,
                string contentType,
                object body)
        {
            Task<Models.ResponseCloudAccounts> t = this.CreateCloudAccountsAsync(authorization, contentType, body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Create a cloud account by specifying parameters in the request  body when invoking the following endpoint:.
        ///   > `POST https://YourLacework.lacework.net/api/v2/CloudAccounts`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseCloudAccounts response from the API call.</returns>
        public async Task<Models.ResponseCloudAccounts> CreateCloudAccountsAsync(
                string authorization,
                string contentType,
                object body,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/CloudAccounts");

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

            return ApiHelper.JsonDeserialize<Models.ResponseCloudAccounts>(response.Body);
        }

        /// <summary>
        /// Get a list of cloud accounts for the current user by invoking the following endpoint:.
        ///   > `GET https://YourLacework.lacework.net/api/v2/CloudAccounts`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <returns>Returns the Models.ResponseCloudAccountsList response from the API call.</returns>
        public Models.ResponseCloudAccountsList ListAllCloudAccounts(
                string authorization,
                string contentType)
        {
            Task<Models.ResponseCloudAccountsList> t = this.ListAllCloudAccountsAsync(authorization, contentType);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get a list of cloud accounts for the current user by invoking the following endpoint:.
        ///   > `GET https://YourLacework.lacework.net/api/v2/CloudAccounts`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseCloudAccountsList response from the API call.</returns>
        public async Task<Models.ResponseCloudAccountsList> ListAllCloudAccountsAsync(
                string authorization,
                string contentType,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/CloudAccounts");

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

            return ApiHelper.JsonDeserialize<Models.ResponseCloudAccountsList>(response.Body);
        }

        /// <summary>
        /// Get a list of cloud accounts of the specified type by invoking the following endpoint:.
        ///   > `GET https://YourLacework.lacework.net/api/v2/CloudAccounts/{type}`.
        ///   Here is an example invocation: .
        ///   > `GET https://YourLacework.lacework.net/api/v2/CloudAccounts/AwsCfg`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="type">Required parameter: Cloud Accounts Type.</param>
        /// <returns>Returns the Models.ResponseCloudAccountsList response from the API call.</returns>
        public Models.ResponseCloudAccountsList ListCloudAccountsByType(
                string authorization,
                string contentType,
                Models.Type1Enum type)
        {
            Task<Models.ResponseCloudAccountsList> t = this.ListCloudAccountsByTypeAsync(authorization, contentType, type);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get a list of cloud accounts of the specified type by invoking the following endpoint:.
        ///   > `GET https://YourLacework.lacework.net/api/v2/CloudAccounts/{type}`.
        ///   Here is an example invocation: .
        ///   > `GET https://YourLacework.lacework.net/api/v2/CloudAccounts/AwsCfg`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="type">Required parameter: Cloud Accounts Type.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseCloudAccountsList response from the API call.</returns>
        public async Task<Models.ResponseCloudAccountsList> ListCloudAccountsByTypeAsync(
                string authorization,
                string contentType,
                Models.Type1Enum type,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/CloudAccounts/{type}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "type", ApiHelper.JsonSerialize(type).Trim('\"') },
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

            return ApiHelper.JsonDeserialize<Models.ResponseCloudAccountsList>(response.Body);
        }

        /// <summary>
        /// Search cloud accounts by invoking the following endpoint:.
        ///   > `POST https://YourLacework.lacework.net/api/v2/CloudAccounts/search`.
        ///  To limit the returned result, optionally specify one or more `filters` in the request `body`. For more information about using filters, see the [Simple & Advanced Search section](/api/v2/docs/#tag/OVERVIEW). .
        ///   In the request body, optionally specify the list of fields to return in the response by specifying the list in the `returns` array, for example, `"returns":[ "name", "type", "enabled" ]`..
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ResponseCloudAccountsList response from the API call.</returns>
        public Models.ResponseCloudAccountsList SearchCloudAccounts(
                string authorization,
                string contentType,
                Models.GETDATAREQUESTBODYFILTERS body)
        {
            Task<Models.ResponseCloudAccountsList> t = this.SearchCloudAccountsAsync(authorization, contentType, body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Search cloud accounts by invoking the following endpoint:.
        ///   > `POST https://YourLacework.lacework.net/api/v2/CloudAccounts/search`.
        ///  To limit the returned result, optionally specify one or more `filters` in the request `body`. For more information about using filters, see the [Simple & Advanced Search section](/api/v2/docs/#tag/OVERVIEW). .
        ///   In the request body, optionally specify the list of fields to return in the response by specifying the list in the `returns` array, for example, `"returns":[ "name", "type", "enabled" ]`..
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseCloudAccountsList response from the API call.</returns>
        public async Task<Models.ResponseCloudAccountsList> SearchCloudAccountsAsync(
                string authorization,
                string contentType,
                Models.GETDATAREQUESTBODYFILTERS body,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/CloudAccounts/search");

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

            return ApiHelper.JsonDeserialize<Models.ResponseCloudAccountsList>(response.Body);
        }

        /// <summary>
        /// Get the details about a cloud account by invoking the following endpoint:.
        ///   > `GET https://YourLacework.lacework.net/api/v2/CloudAccounts/{intgGuid}`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="intgGuid">Required parameter: Cloud Account intgGuid.</param>
        /// <returns>Returns the Models.ResponseCloudAccounts response from the API call.</returns>
        public Models.ResponseCloudAccounts CloudAccountsDetails(
                string authorization,
                string contentType,
                string intgGuid)
        {
            Task<Models.ResponseCloudAccounts> t = this.CloudAccountsDetailsAsync(authorization, contentType, intgGuid);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get the details about a cloud account by invoking the following endpoint:.
        ///   > `GET https://YourLacework.lacework.net/api/v2/CloudAccounts/{intgGuid}`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="intgGuid">Required parameter: Cloud Account intgGuid.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseCloudAccounts response from the API call.</returns>
        public async Task<Models.ResponseCloudAccounts> CloudAccountsDetailsAsync(
                string authorization,
                string contentType,
                string intgGuid,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/CloudAccounts/{intgGuid}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "intgGuid", intgGuid },
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

            return ApiHelper.JsonDeserialize<Models.ResponseCloudAccounts>(response.Body);
        }

        /// <summary>
        /// Update a cloud account by specifying parameters in the request body when invoking the following endpoint: .
        ///   > `PATCH https://YourLacework.lacework.net/api/v2/CloudAccounts/{intgGuid}` .
        ///   In the request body, only specify the parameter(s) that you want to update, for example, `{ "enabled" : 0 }`..
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="intgGuid">Required parameter: Cloud Account intgGuid.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ResponseCloudAccounts response from the API call.</returns>
        public Models.ResponseCloudAccounts UpdateCloudAccounts(
                string authorization,
                string contentType,
                string intgGuid,
                object body)
        {
            Task<Models.ResponseCloudAccounts> t = this.UpdateCloudAccountsAsync(authorization, contentType, intgGuid, body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Update a cloud account by specifying parameters in the request body when invoking the following endpoint: .
        ///   > `PATCH https://YourLacework.lacework.net/api/v2/CloudAccounts/{intgGuid}` .
        ///   In the request body, only specify the parameter(s) that you want to update, for example, `{ "enabled" : 0 }`..
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="intgGuid">Required parameter: Cloud Account intgGuid.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseCloudAccounts response from the API call.</returns>
        public async Task<Models.ResponseCloudAccounts> UpdateCloudAccountsAsync(
                string authorization,
                string contentType,
                string intgGuid,
                object body,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/CloudAccounts/{intgGuid}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "intgGuid", intgGuid },
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

            if (response.StatusCode == 404)
            {
                throw new Response404Exception("Not found", context);
            }

            if (response.StatusCode == 500)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ResponseCloudAccounts>(response.Body);
        }

        /// <summary>
        /// Delete a cloud account by invoking the following endpoint:.
        ///   > `DELETE https://YourLacework.lacework.net/api/v2/CloudAccounts/{intgGuid}`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="intgGuid">Required parameter: Cloud Account intgGuid.</param>
        public void DeleteCloudAccounts(
                string authorization,
                string contentType,
                string intgGuid)
        {
            Task t = this.DeleteCloudAccountsAsync(authorization, contentType, intgGuid);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Delete a cloud account by invoking the following endpoint:.
        ///   > `DELETE https://YourLacework.lacework.net/api/v2/CloudAccounts/{intgGuid}`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="intgGuid">Required parameter: Cloud Account intgGuid.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteCloudAccountsAsync(
                string authorization,
                string contentType,
                string intgGuid,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/CloudAccounts/{intgGuid}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "intgGuid", intgGuid },
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

            if (response.StatusCode == 404)
            {
                throw new Response404Exception("Not found", context);
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