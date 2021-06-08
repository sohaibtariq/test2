// <copyright file="SCHEMASController.cs" company="APIMatic">
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
    /// SCHEMASController.
    /// </summary>
    public class SCHEMASController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCHEMASController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        internal SCHEMASController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers)
            : base(config, httpClient, authManagers)
        {
        }

        /// <summary>
        /// Get a list of available Lacework schema types by invoking the following endpoint:.
        ///   > `GET https://YourLacework.lacework.net/api/v2/schemas` .
        ///   Get details about a Lacework schema by invoking the following endpoint: .
        ///   > `GET https://YourLacework.lacework.net/api/v2/schemas/{type}`.
        ///   Here is an example invocation:.
        ///   > `GET https://YourLacework.lacework.net/api/v2/schemas/AuditLogs`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="type">Required parameter: The schema type, or empty for a list of all schema types.</param>
        /// <returns>Returns the object response from the API call.</returns>
        public object SchemaDetails(
                string authorization,
                string contentType,
                string type)
        {
            Task<object> t = this.SchemaDetailsAsync(authorization, contentType, type);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get a list of available Lacework schema types by invoking the following endpoint:.
        ///   > `GET https://YourLacework.lacework.net/api/v2/schemas` .
        ///   Get details about a Lacework schema by invoking the following endpoint: .
        ///   > `GET https://YourLacework.lacework.net/api/v2/schemas/{type}`.
        ///   Here is an example invocation:.
        ///   > `GET https://YourLacework.lacework.net/api/v2/schemas/AuditLogs`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="type">Required parameter: The schema type, or empty for a list of all schema types.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the object response from the API call.</returns>
        public async Task<object> SchemaDetailsAsync(
                string authorization,
                string contentType,
                string type,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/schemas/{type}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "type", type },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
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
                throw new ApiV2Schemas400ErrorException("Audits is invalid", context);
            }

            if (response.StatusCode == 500)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return response.Body;
        }

        /// <summary>
        /// Get details about a Lacework schema by specifying a schema type and subtype  when invoking the endpoint..
        ///   > `GET https://YourLacework.lacework.net/api/v2/schemas/{type}/{subtype}` .
        ///   Here is an example invocation: .
        ///   > `GET https://YourLacework.lacework.net/api/v2/schemas/AlertChannels/SlackChannel`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="type">Required parameter: the schema type.</param>
        /// <param name="subtype">Required parameter: the subtype.</param>
        /// <returns>Returns the object response from the API call.</returns>
        public object SchemaDetailsOfSubtype(
                string authorization,
                string contentType,
                string type,
                string subtype)
        {
            Task<object> t = this.SchemaDetailsOfSubtypeAsync(authorization, contentType, type, subtype);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get details about a Lacework schema by specifying a schema type and subtype  when invoking the endpoint..
        ///   > `GET https://YourLacework.lacework.net/api/v2/schemas/{type}/{subtype}` .
        ///   Here is an example invocation: .
        ///   > `GET https://YourLacework.lacework.net/api/v2/schemas/AlertChannels/SlackChannel`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="type">Required parameter: the schema type.</param>
        /// <param name="subtype">Required parameter: the subtype.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the object response from the API call.</returns>
        public async Task<object> SchemaDetailsOfSubtypeAsync(
                string authorization,
                string contentType,
                string type,
                string subtype,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/schemas/{type}/{subtype}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "type", type },
                { "subtype", subtype },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
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
                throw new ApiV2Schemas400ErrorException("Invalid subtype", context);
            }

            if (response.StatusCode == 500)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return response.Body;
        }
    }
}