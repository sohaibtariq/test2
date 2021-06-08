// <copyright file="AlertRulesController.cs" company="APIMatic">
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
    /// AlertRulesController.
    /// </summary>
    public class AlertRulesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlertRulesController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        internal AlertRulesController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers)
            : base(config, httpClient, authManagers)
        {
        }

        /// <summary>
        /// Create an alert rules by specifying parameters in the request `body` when invoking the following endpoint:.
        ///   > `POST https://YourLacework.lacework.net/api/v2/AlertRules`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ResponseAlertRules response from the API call.</returns>
        public Models.ResponseAlertRules CreateAlertRules(
                string authorization,
                string contentType,
                Models.AlertRulesCreateSchema body)
        {
            Task<Models.ResponseAlertRules> t = this.CreateAlertRulesAsync(authorization, contentType, body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Create an alert rules by specifying parameters in the request `body` when invoking the following endpoint:.
        ///   > `POST https://YourLacework.lacework.net/api/v2/AlertRules`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseAlertRules response from the API call.</returns>
        public async Task<Models.ResponseAlertRules> CreateAlertRulesAsync(
                string authorization,
                string contentType,
                Models.AlertRulesCreateSchema body,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/AlertRules");

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

            return ApiHelper.JsonDeserialize<Models.ResponseAlertRules>(response.Body);
        }

        /// <summary>
        /// List all the alert rules in your Lacework instance,  by invoking the following endpoint:.
        ///   > `GET https://YourLacework.lacework.net/api/v2/AlertRules`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <returns>Returns the Models.ResponseAlertRulesList response from the API call.</returns>
        public Models.ResponseAlertRulesList ListAllAlertRules(
                string authorization,
                string contentType)
        {
            Task<Models.ResponseAlertRulesList> t = this.ListAllAlertRulesAsync(authorization, contentType);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// List all the alert rules in your Lacework instance,  by invoking the following endpoint:.
        ///   > `GET https://YourLacework.lacework.net/api/v2/AlertRules`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseAlertRulesList response from the API call.</returns>
        public async Task<Models.ResponseAlertRulesList> ListAllAlertRulesAsync(
                string authorization,
                string contentType,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/AlertRules");

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

            return ApiHelper.JsonDeserialize<Models.ResponseAlertRulesList>(response.Body);
        }

        /// <summary>
        /// Search alert rules by invoking the following endpoint:.
        ///   > `POST https://YourLacework.lacework.net/api/v2/AlertRules/search`.
        ///  To limit the returned result, optionally specify one or more `filters` in the request `body`. For more information about using filters, see the [Simple & Advanced Search section](/api/v2/docs/#tag/OVERVIEW). .
        ///   Here are some example `body` payloads:.
        ///   * `{ "filters": [ { "field": "mcGuid", "expression": "rlike", "value": "123ABC" } ] } ` .
        ///   * `{ "filters": [ { "field": "mcGuid", "expression": "between", "values": [ "ABC_123", "DEC_456" ] } ] }` .
        ///   * `{ "filters": [ { "field": "intgGuidList", "expression": "eq", "value": "ABC_123" } ] } ` .
        ///   * `{ "filters": [ { "field": "intgGuidList", "expression": "in", "values": [ "ABC_123", "DEF_456" ] } ] } ` .
        ///   * `{ "filters": [ { "field": "filters.name", "expression": "ilike", "value": "slack" } ] } ` .
        ///   * `{ "filters": [ { "field": "filters.resourceGroups", "expression": "eq", "value": "ABC_123" } ] } ` .
        ///   * `{ "filters": [ { "field": "filters.severity", "expression": "eq", "value": "5" } ] } ` .
        ///   * `{ "filters": [ { "field": "filters.eventCategory", "expression": "eq", "value": "App" } ] } ` .
        ///   * `{ "filters": [ { "field": "reportNotificationTypes.agentEvents", "expression": "eq", "value": "false" } ] } ` .
        ///   In the request body, optionally specify the list of fields to return in the response by specifying the list in the `returns` array..
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ResponseAlertRulesList response from the API call.</returns>
        public Models.ResponseAlertRulesList SearchAlertRules(
                string authorization,
                string contentType,
                Models.GETDATAREQUESTBODYFILTERS body)
        {
            Task<Models.ResponseAlertRulesList> t = this.SearchAlertRulesAsync(authorization, contentType, body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Search alert rules by invoking the following endpoint:.
        ///   > `POST https://YourLacework.lacework.net/api/v2/AlertRules/search`.
        ///  To limit the returned result, optionally specify one or more `filters` in the request `body`. For more information about using filters, see the [Simple & Advanced Search section](/api/v2/docs/#tag/OVERVIEW). .
        ///   Here are some example `body` payloads:.
        ///   * `{ "filters": [ { "field": "mcGuid", "expression": "rlike", "value": "123ABC" } ] } ` .
        ///   * `{ "filters": [ { "field": "mcGuid", "expression": "between", "values": [ "ABC_123", "DEC_456" ] } ] }` .
        ///   * `{ "filters": [ { "field": "intgGuidList", "expression": "eq", "value": "ABC_123" } ] } ` .
        ///   * `{ "filters": [ { "field": "intgGuidList", "expression": "in", "values": [ "ABC_123", "DEF_456" ] } ] } ` .
        ///   * `{ "filters": [ { "field": "filters.name", "expression": "ilike", "value": "slack" } ] } ` .
        ///   * `{ "filters": [ { "field": "filters.resourceGroups", "expression": "eq", "value": "ABC_123" } ] } ` .
        ///   * `{ "filters": [ { "field": "filters.severity", "expression": "eq", "value": "5" } ] } ` .
        ///   * `{ "filters": [ { "field": "filters.eventCategory", "expression": "eq", "value": "App" } ] } ` .
        ///   * `{ "filters": [ { "field": "reportNotificationTypes.agentEvents", "expression": "eq", "value": "false" } ] } ` .
        ///   In the request body, optionally specify the list of fields to return in the response by specifying the list in the `returns` array..
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseAlertRulesList response from the API call.</returns>
        public async Task<Models.ResponseAlertRulesList> SearchAlertRulesAsync(
                string authorization,
                string contentType,
                Models.GETDATAREQUESTBODYFILTERS body,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/AlertRules/search");

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

            return ApiHelper.JsonDeserialize<Models.ResponseAlertRulesList>(response.Body);
        }

        /// <summary>
        /// Get details about a Alert Rule  by invoking the following endpoint:.
        ///   > `GET https://YourLacework.lacework.net/api/v2/AlertRules/{mcGuid}`.
        ///   Replace `{mcGuid}` with the `mcGuide` value returned for a Alert Rule in the response when the  `GET /api/v2/AlertRules` endpoint is invoked..
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="mcGuid">Required parameter: Alert Rule mcGuid.</param>
        /// <returns>Returns the Models.ResponseAlertRules response from the API call.</returns>
        public Models.ResponseAlertRules AlertRuleDetails(
                string authorization,
                string contentType,
                string mcGuid)
        {
            Task<Models.ResponseAlertRules> t = this.AlertRuleDetailsAsync(authorization, contentType, mcGuid);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get details about a Alert Rule  by invoking the following endpoint:.
        ///   > `GET https://YourLacework.lacework.net/api/v2/AlertRules/{mcGuid}`.
        ///   Replace `{mcGuid}` with the `mcGuide` value returned for a Alert Rule in the response when the  `GET /api/v2/AlertRules` endpoint is invoked..
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="mcGuid">Required parameter: Alert Rule mcGuid.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseAlertRules response from the API call.</returns>
        public async Task<Models.ResponseAlertRules> AlertRuleDetailsAsync(
                string authorization,
                string contentType,
                string mcGuid,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/AlertRules/{mcGuid}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "mcGuid", mcGuid },
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

            return ApiHelper.JsonDeserialize<Models.ResponseAlertRules>(response.Body);
        }

        /// <summary>
        /// Update an alert rules by specifying parameters in the request body when invoking the following endpoint: .
        ///   > `PATCH https://YourLacework.lacework.net/api/v2/AlertRules/{mcGuid}`.
        ///   Replace `{mcGuid}` with the `mcGuide` value returned for a Alert Rule in the response when the  `GET /api/v2/AlertRules` endpoint is invoked.  In the request body, only specify the parameter(s) that you want to update..
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="mcGuid">Required parameter: Alert Rules mcGuid.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ResponseAlertRules response from the API call.</returns>
        public Models.ResponseAlertRules UpdateAlertRules(
                string authorization,
                string contentType,
                string mcGuid,
                Models.AlertRulesUpdateSchema body)
        {
            Task<Models.ResponseAlertRules> t = this.UpdateAlertRulesAsync(authorization, contentType, mcGuid, body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Update an alert rules by specifying parameters in the request body when invoking the following endpoint: .
        ///   > `PATCH https://YourLacework.lacework.net/api/v2/AlertRules/{mcGuid}`.
        ///   Replace `{mcGuid}` with the `mcGuide` value returned for a Alert Rule in the response when the  `GET /api/v2/AlertRules` endpoint is invoked.  In the request body, only specify the parameter(s) that you want to update..
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="mcGuid">Required parameter: Alert Rules mcGuid.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseAlertRules response from the API call.</returns>
        public async Task<Models.ResponseAlertRules> UpdateAlertRulesAsync(
                string authorization,
                string contentType,
                string mcGuid,
                Models.AlertRulesUpdateSchema body,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/AlertRules/{mcGuid}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "mcGuid", mcGuid },
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

            return ApiHelper.JsonDeserialize<Models.ResponseAlertRules>(response.Body);
        }

        /// <summary>
        /// Delete an Alert Rule by invoking the following endpoint:.
        ///   > `DELETE https://YourLacework.lacework.net/api/v2/AlertRule/{mcGuid}`.
        ///  .
        ///   Replace `{mcGuid}` with the `mcGuid` value returned for a Alert Rule in the response when the  `GET /api/v2/AlertRules` endpoint is invoked..
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="mcGuid">Required parameter: Alert Rules mcGuid.</param>
        public void DeleteAlertRules(
                string authorization,
                string contentType,
                string mcGuid)
        {
            Task t = this.DeleteAlertRulesAsync(authorization, contentType, mcGuid);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Delete an Alert Rule by invoking the following endpoint:.
        ///   > `DELETE https://YourLacework.lacework.net/api/v2/AlertRule/{mcGuid}`.
        ///  .
        ///   Replace `{mcGuid}` with the `mcGuid` value returned for a Alert Rule in the response when the  `GET /api/v2/AlertRules` endpoint is invoked..
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="mcGuid">Required parameter: Alert Rules mcGuid.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteAlertRulesAsync(
                string authorization,
                string contentType,
                string mcGuid,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/AlertRules/{mcGuid}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "mcGuid", mcGuid },
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