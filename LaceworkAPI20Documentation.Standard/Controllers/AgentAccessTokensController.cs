// <copyright file="AgentAccessTokensController.cs" company="APIMatic">
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
    /// AgentAccessTokensController.
    /// </summary>
    public class AgentAccessTokensController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAccessTokensController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        internal AgentAccessTokensController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers)
            : base(config, httpClient, authManagers)
        {
        }

        /// <summary>
        /// Create a new agent access token that is used by an agent to connect and send data to your Lacework instance, by invoking the following endpoint:.
        ///   > `POST https://YourLacework.lacework.net/api/v2/AgentAccessTokens`.
        ///   Here is an example `body` payload:.
        ///   > `{ "tokenAlias": "qa", "props": {"description":"QA group"} } }`.
        ///   By default, if `tokenEnabled` is not set, the agent access token is enabled..
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ResponseAgentAccessTokens response from the API call.</returns>
        public Models.ResponseAgentAccessTokens CreateAgentAccessToken(
                string authorization,
                string contentType,
                Models.AgentAccessTokensCreateSchema body)
        {
            Task<Models.ResponseAgentAccessTokens> t = this.CreateAgentAccessTokenAsync(authorization, contentType, body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Create a new agent access token that is used by an agent to connect and send data to your Lacework instance, by invoking the following endpoint:.
        ///   > `POST https://YourLacework.lacework.net/api/v2/AgentAccessTokens`.
        ///   Here is an example `body` payload:.
        ///   > `{ "tokenAlias": "qa", "props": {"description":"QA group"} } }`.
        ///   By default, if `tokenEnabled` is not set, the agent access token is enabled..
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseAgentAccessTokens response from the API call.</returns>
        public async Task<Models.ResponseAgentAccessTokens> CreateAgentAccessTokenAsync(
                string authorization,
                string contentType,
                Models.AgentAccessTokensCreateSchema body,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/AgentAccessTokens");

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

            return ApiHelper.JsonDeserialize<Models.ResponseAgentAccessTokens>(response.Body);
        }

        /// <summary>
        /// Get a list of agent Access Tokens that are currently enabled in your Lacework instance, by invoking the following endpoint:.
        ///   > `GET https://YourLacework.lacework.net/api/v2/AgentAccessTokens`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <returns>Returns the Models.ResponseAgentAccessTokensList response from the API call.</returns>
        public Models.ResponseAgentAccessTokensList ListAllAgentAccessTokens(
                string authorization,
                string contentType)
        {
            Task<Models.ResponseAgentAccessTokensList> t = this.ListAllAgentAccessTokensAsync(authorization, contentType);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get a list of agent Access Tokens that are currently enabled in your Lacework instance, by invoking the following endpoint:.
        ///   > `GET https://YourLacework.lacework.net/api/v2/AgentAccessTokens`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseAgentAccessTokensList response from the API call.</returns>
        public async Task<Models.ResponseAgentAccessTokensList> ListAllAgentAccessTokensAsync(
                string authorization,
                string contentType,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/AgentAccessTokens");

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

            return ApiHelper.JsonDeserialize<Models.ResponseAgentAccessTokensList>(response.Body);
        }

        /// <summary>
        /// Search all the enabled agent access tokens in your Lacework instance,  by invoking the following endpoint:.
        ///   > `POST https://YourLacework.lacework.net/api/v2/AgentAccessTokens/search`.
        ///   To limit the returned result, optionally specify one or more filters in the request `body`. For more information about using filters, see the [Simple & Advanced Search section](/api/v2/docs/#tag/OVERVIEW). .
        ///   You can filter on the following fields:.
        ///   * `accessToken`.
        ///   * `createdTime`.
        ///   * `tokenAlias`.
        ///   * `tokenEnabled`.
        ///   * `version`.
        ///  .
        ///   Here is an example `body` payload:.
        ///   > `{ "filters" : [ { "expression": "eq", "field": "tokenAlias", "value": "Eng" } ] } `.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ResponseAgentAccessTokensList response from the API call.</returns>
        public Models.ResponseAgentAccessTokensList SearchAgentAccessTokens(
                string authorization,
                string contentType,
                Models.GETDATAREQUESTBODYFILTERS body)
        {
            Task<Models.ResponseAgentAccessTokensList> t = this.SearchAgentAccessTokensAsync(authorization, contentType, body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Search all the enabled agent access tokens in your Lacework instance,  by invoking the following endpoint:.
        ///   > `POST https://YourLacework.lacework.net/api/v2/AgentAccessTokens/search`.
        ///   To limit the returned result, optionally specify one or more filters in the request `body`. For more information about using filters, see the [Simple & Advanced Search section](/api/v2/docs/#tag/OVERVIEW). .
        ///   You can filter on the following fields:.
        ///   * `accessToken`.
        ///   * `createdTime`.
        ///   * `tokenAlias`.
        ///   * `tokenEnabled`.
        ///   * `version`.
        ///  .
        ///   Here is an example `body` payload:.
        ///   > `{ "filters" : [ { "expression": "eq", "field": "tokenAlias", "value": "Eng" } ] } `.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseAgentAccessTokensList response from the API call.</returns>
        public async Task<Models.ResponseAgentAccessTokensList> SearchAgentAccessTokensAsync(
                string authorization,
                string contentType,
                Models.GETDATAREQUESTBODYFILTERS body,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/AgentAccessTokens/search");

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

            return ApiHelper.JsonDeserialize<Models.ResponseAgentAccessTokensList>(response.Body);
        }

        /// <summary>
        /// Get details about an agent access token  by invoking the following endpoint:.
        ///   > `GET https://YourLacework.lacework.net/api/v2/AgentAccessTokens/{id}`.
        ///   You can get the `{id}` by invoking the `GET /api/v2/AgentAccessTokens` endpoint.  Replace `{id}` with the long hexadecimal access token identifier returned in the `accessToken`  field of the `GET /api/v2/AgentAccessTokens` endpoint response. .
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="id">Required parameter: Agent Access Token {id}.</param>
        /// <returns>Returns the Models.ResponseAgentAccessTokens response from the API call.</returns>
        public Models.ResponseAgentAccessTokens AgentAccessTokenDetails(
                string authorization,
                string contentType,
                string id)
        {
            Task<Models.ResponseAgentAccessTokens> t = this.AgentAccessTokenDetailsAsync(authorization, contentType, id);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get details about an agent access token  by invoking the following endpoint:.
        ///   > `GET https://YourLacework.lacework.net/api/v2/AgentAccessTokens/{id}`.
        ///   You can get the `{id}` by invoking the `GET /api/v2/AgentAccessTokens` endpoint.  Replace `{id}` with the long hexadecimal access token identifier returned in the `accessToken`  field of the `GET /api/v2/AgentAccessTokens` endpoint response. .
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="id">Required parameter: Agent Access Token {id}.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseAgentAccessTokens response from the API call.</returns>
        public async Task<Models.ResponseAgentAccessTokens> AgentAccessTokenDetailsAsync(
                string authorization,
                string contentType,
                string id,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/AgentAccessTokens/{id}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "id", id },
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

            return ApiHelper.JsonDeserialize<Models.ResponseAgentAccessTokens>(response.Body);
        }

        /// <summary>
        /// Optionally update the `tokenEnabled`, `tokenAlias`, or `description`  settings of the passed in agent access token.  Update these settings by invoking the following endpoint:.
        ///   > `PATCH https://YourLacework.lacework.net/api/v2/AgentAccessTokens/{id}`.
        ///   You can get the agent access token id by calling the  `GET /api/v2/AgentAccessTokens` endpoint..
        ///   Replace `{id}` with the long hexadecimal access token identifier returned in the `accessToken`  field of the `GET /api/v2/AgentAccessTokens` endpoint response..
        ///   Here is an example `body` payload:.
        ///   > `{ "tokenAlias": "Eng", "tokenEnabled": "1", "props": {"description":"Eng group"} } }`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="id">Required parameter: AgentAccessTokens {id}.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ResponseAgentAccessTokens response from the API call.</returns>
        public Models.ResponseAgentAccessTokens UpdateAgentAccessToken(
                string authorization,
                string contentType,
                string id,
                Models.AgentAccessTokensUpdateSchema body)
        {
            Task<Models.ResponseAgentAccessTokens> t = this.UpdateAgentAccessTokenAsync(authorization, contentType, id, body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Optionally update the `tokenEnabled`, `tokenAlias`, or `description`  settings of the passed in agent access token.  Update these settings by invoking the following endpoint:.
        ///   > `PATCH https://YourLacework.lacework.net/api/v2/AgentAccessTokens/{id}`.
        ///   You can get the agent access token id by calling the  `GET /api/v2/AgentAccessTokens` endpoint..
        ///   Replace `{id}` with the long hexadecimal access token identifier returned in the `accessToken`  field of the `GET /api/v2/AgentAccessTokens` endpoint response..
        ///   Here is an example `body` payload:.
        ///   > `{ "tokenAlias": "Eng", "tokenEnabled": "1", "props": {"description":"Eng group"} } }`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="id">Required parameter: AgentAccessTokens {id}.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseAgentAccessTokens response from the API call.</returns>
        public async Task<Models.ResponseAgentAccessTokens> UpdateAgentAccessTokenAsync(
                string authorization,
                string contentType,
                string id,
                Models.AgentAccessTokensUpdateSchema body,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/AgentAccessTokens/{id}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "id", id },
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

            return ApiHelper.JsonDeserialize<Models.ResponseAgentAccessTokens>(response.Body);
        }
    }
}