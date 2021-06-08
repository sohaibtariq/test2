// <copyright file="CloudActivitiesController.cs" company="APIMatic">
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
    /// CloudActivitiesController.
    /// </summary>
    public class CloudActivitiesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudActivitiesController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        internal CloudActivitiesController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers)
            : base(config, httpClient, authManagers)
        {
        }

        /// <summary>
        /// Get cloud activities details by invoking the following endpoint:.
        ///   > `GET https://YourLacework.lacework.net/api/v2/CloudActivities` .
        ///  Optionally filter by specifying the `startTime` and `endTime` of a time range using the following formats:.
        ///   * `yyyy-MM-dd` for example, `2020-12-18` .
        ///   * `yyyy-MM-ddTHH` for example, `2020-12-18T08` .
        ///   * `yyyy-MM-ddTHH:mm:ssZ` for example, `2020-12-18T08:00:00Z` .
        ///   * `yyyy-MM-ddTHH:mm:ss.SSSZ` for example, `2020-12-18T08:00:00.000Z` .
        ///   Here is an example invocation: .
        ///   > `GET https://YourLacework.lacework.net/api/v2/CloudActivities?startTime=2020-12-11T08:00:00Z&endTime=2020-12-18T08:00:00Z`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="startTime">Optional parameter: Start time.</param>
        /// <param name="endTime">Optional parameter: End time.</param>
        /// <returns>Returns the Models.ResponseCloudActivitiesList response from the API call.</returns>
        public Models.ResponseCloudActivitiesList CloudActivities(
                string authorization,
                string contentType,
                string startTime = null,
                string endTime = null)
        {
            Task<Models.ResponseCloudActivitiesList> t = this.CloudActivitiesAsync(authorization, contentType, startTime, endTime);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get cloud activities details by invoking the following endpoint:.
        ///   > `GET https://YourLacework.lacework.net/api/v2/CloudActivities` .
        ///  Optionally filter by specifying the `startTime` and `endTime` of a time range using the following formats:.
        ///   * `yyyy-MM-dd` for example, `2020-12-18` .
        ///   * `yyyy-MM-ddTHH` for example, `2020-12-18T08` .
        ///   * `yyyy-MM-ddTHH:mm:ssZ` for example, `2020-12-18T08:00:00Z` .
        ///   * `yyyy-MM-ddTHH:mm:ss.SSSZ` for example, `2020-12-18T08:00:00.000Z` .
        ///   Here is an example invocation: .
        ///   > `GET https://YourLacework.lacework.net/api/v2/CloudActivities?startTime=2020-12-11T08:00:00Z&endTime=2020-12-18T08:00:00Z`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="startTime">Optional parameter: Start time.</param>
        /// <param name="endTime">Optional parameter: End time.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseCloudActivitiesList response from the API call.</returns>
        public async Task<Models.ResponseCloudActivitiesList> CloudActivitiesAsync(
                string authorization,
                string contentType,
                string startTime = null,
                string endTime = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/CloudActivities");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "startTime", startTime },
                { "endTime", endTime },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
                { "Authorization", authorization },
                { "Content-Type", contentType },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            if (response.StatusCode == 400)
            {
                throw new ResponseInvalidDateException("Invalid Date", context);
            }

            if (response.StatusCode == 500)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ResponseCloudActivitiesList>(response.Body);
        }

        /// <summary>
        /// Search cloud activities by invoking the following endpoint:.
        ///   > `POST https://YourLacework.lacework.net/api/v2/CloudActivities/search` .
        ///   Filters can be optionally specified in the request body. For more information about using filters, see the [Simple & Advanced Search section](/api/v2/docs/#tag/OVERVIEW)..
        ///   For the `timeFilter` filter, these are the supported time formats:.
        ///   * `yyyy-MM-dd` for example, `2020-12-18` .
        ///   * `yyyy-MM-ddTHH` for example, `2020-12-18T08` .
        ///   * `yyyy-MM-ddTHH:mm:ssZ` for example, `2020-12-18T08:00:00Z` .
        ///   * `yyyy-MM-ddTHH:mm:ss.SSSZ` for example, `2020-12-18T08:00:00.000Z`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ResponseCloudActivitiesList response from the API call.</returns>
        public Models.ResponseCloudActivitiesList SearchCloudActivities(
                string authorization,
                string contentType,
                Models.GETDATAREQUESTBODYTIMEFILTERS body)
        {
            Task<Models.ResponseCloudActivitiesList> t = this.SearchCloudActivitiesAsync(authorization, contentType, body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Search cloud activities by invoking the following endpoint:.
        ///   > `POST https://YourLacework.lacework.net/api/v2/CloudActivities/search` .
        ///   Filters can be optionally specified in the request body. For more information about using filters, see the [Simple & Advanced Search section](/api/v2/docs/#tag/OVERVIEW)..
        ///   For the `timeFilter` filter, these are the supported time formats:.
        ///   * `yyyy-MM-dd` for example, `2020-12-18` .
        ///   * `yyyy-MM-ddTHH` for example, `2020-12-18T08` .
        ///   * `yyyy-MM-ddTHH:mm:ssZ` for example, `2020-12-18T08:00:00Z` .
        ///   * `yyyy-MM-ddTHH:mm:ss.SSSZ` for example, `2020-12-18T08:00:00.000Z`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseCloudActivitiesList response from the API call.</returns>
        public async Task<Models.ResponseCloudActivitiesList> SearchCloudActivitiesAsync(
                string authorization,
                string contentType,
                Models.GETDATAREQUESTBODYTIMEFILTERS body,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/CloudActivities/search");

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
                throw new ResponseInvalidDateException("Invalid Date", context);
            }

            if (response.StatusCode == 500)
            {
                throw new ResponseInternalErrorException("Internal Server Error", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ResponseCloudActivitiesList>(response.Body);
        }
    }
}