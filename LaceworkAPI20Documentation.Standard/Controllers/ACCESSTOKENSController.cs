// <copyright file="ACCESSTOKENSController.cs" company="APIMatic">
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
    /// ACCESSTOKENSController.
    /// </summary>
    public class ACCESSTOKENSController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ACCESSTOKENSController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        internal ACCESSTOKENSController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers)
            : base(config, httpClient, authManagers)
        {
        }

        /// <summary>
        /// Get access tokens for the API requests by invoking the following endpoint:.
        ///   > `POST https://YourLacework.lacework.net/api/v2/access/tokens`.
        ///   After creating a secret key, administrators can generate Temporary API access (bearer) tokens that are used by clients  and client applications to access the Lacework API. Temporary API access (bearer) tokens are created by invoking the `POST https://YourLacework.lacework.net/api/v2/access/tokens` endpoint..
        /// </summary>
        /// <param name="xLWUAKS">Required parameter: YourSecretKey.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ApiV2AccessTokensResponse response from the API call.</returns>
        public Models.ApiV2AccessTokensResponse GenerateAccessTokens(
                string xLWUAKS,
                string contentType,
                Models.ApiV2AccessTokensRequest body)
        {
            Task<Models.ApiV2AccessTokensResponse> t = this.GenerateAccessTokensAsync(xLWUAKS, contentType, body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get access tokens for the API requests by invoking the following endpoint:.
        ///   > `POST https://YourLacework.lacework.net/api/v2/access/tokens`.
        ///   After creating a secret key, administrators can generate Temporary API access (bearer) tokens that are used by clients  and client applications to access the Lacework API. Temporary API access (bearer) tokens are created by invoking the `POST https://YourLacework.lacework.net/api/v2/access/tokens` endpoint..
        /// </summary>
        /// <param name="xLWUAKS">Required parameter: YourSecretKey.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ApiV2AccessTokensResponse response from the API call.</returns>
        public async Task<Models.ApiV2AccessTokensResponse> GenerateAccessTokensAsync(
                string xLWUAKS,
                string contentType,
                Models.ApiV2AccessTokensRequest body,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/access/tokens");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
                { "X-LW-UAKS", xLWUAKS },
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
                throw new ApiV2AccessTokens400ErrorException("Access Key is null.", context);
            }

            if (response.StatusCode == 500)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ApiV2AccessTokensResponse>(response.Body);
        }
    }
}