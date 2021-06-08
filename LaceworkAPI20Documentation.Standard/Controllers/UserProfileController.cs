// <copyright file="UserProfileController.cs" company="APIMatic">
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
    /// UserProfileController.
    /// </summary>
    public class UserProfileController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        internal UserProfileController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers)
            : base(config, httpClient, authManagers)
        {
        }

        /// <summary>
        /// List all the sub-accounts that are managed by the `YourLacework` account,  by invoking the following endpoint:.
        ///   > `GET https://YourLacework.lacework.net/api/v2/UserProfile` .
        ///  For example if you specify the `IT20.MyCompany` organization account in  `YourLacework`, all the sub-accounts of the `IT20` account are listed..
        ///   Here is an example invocation:.
        ///   > `GET https://IT20.MyCompany.lacework.net/api/v2/UserProfile`.
        ///   Details about organization accounts and non-organization accounts are reported in the response.  In addition, details about authorization and privileges are also listed..
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <returns>Returns the Models.ResponseUserProfileList response from the API call.</returns>
        public Models.ResponseUserProfileList ListSubAccounts(
                string authorization,
                string contentType)
        {
            Task<Models.ResponseUserProfileList> t = this.ListSubAccountsAsync(authorization, contentType);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// List all the sub-accounts that are managed by the `YourLacework` account,  by invoking the following endpoint:.
        ///   > `GET https://YourLacework.lacework.net/api/v2/UserProfile` .
        ///  For example if you specify the `IT20.MyCompany` organization account in  `YourLacework`, all the sub-accounts of the `IT20` account are listed..
        ///   Here is an example invocation:.
        ///   > `GET https://IT20.MyCompany.lacework.net/api/v2/UserProfile`.
        ///   Details about organization accounts and non-organization accounts are reported in the response.  In addition, details about authorization and privileges are also listed..
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseUserProfileList response from the API call.</returns>
        public async Task<Models.ResponseUserProfileList> ListSubAccountsAsync(
                string authorization,
                string contentType,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/UserProfile");

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

            return ApiHelper.JsonDeserialize<Models.ResponseUserProfileList>(response.Body);
        }
    }
}