// <copyright file="TeamMembersController.cs" company="APIMatic">
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
    /// TeamMembersController.
    /// </summary>
    public class TeamMembersController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMembersController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        internal TeamMembersController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers)
            : base(config, httpClient, authManagers)
        {
        }

        /// <summary>
        /// Create a Team Member in your Lacework instance,  by invoking the following endpoint:.
        ///   > `POST https://YourLacework.lacework.net/api/v2/TeamMembers`.
        ///   Here is an example `body` payload:.
        ///   > `{ "userName": "jane.smith@mycompany.com",  "userEnabled": 1,  "props": {  "firstName": "Jane",  "lastName": "Smith",  "company": "myCompany", "accountAdmin": true } .
        ///   }`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="orgAccess">Optional parameter: Org account privileges.</param>
        /// <returns>Returns the Models.ResponseTeamMembers response from the API call.</returns>
        public Models.ResponseTeamMembers CreateTeamMembers(
                string authorization,
                string contentType,
                object body,
                bool? orgAccess = null)
        {
            Task<Models.ResponseTeamMembers> t = this.CreateTeamMembersAsync(authorization, contentType, body, orgAccess);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Create a Team Member in your Lacework instance,  by invoking the following endpoint:.
        ///   > `POST https://YourLacework.lacework.net/api/v2/TeamMembers`.
        ///   Here is an example `body` payload:.
        ///   > `{ "userName": "jane.smith@mycompany.com",  "userEnabled": 1,  "props": {  "firstName": "Jane",  "lastName": "Smith",  "company": "myCompany", "accountAdmin": true } .
        ///   }`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="orgAccess">Optional parameter: Org account privileges.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseTeamMembers response from the API call.</returns>
        public async Task<Models.ResponseTeamMembers> CreateTeamMembersAsync(
                string authorization,
                string contentType,
                object body,
                bool? orgAccess = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/TeamMembers");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
                { "Authorization", authorization },
                { "Content-Type", contentType },
                { "Org-Access", orgAccess.ToString() },
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

            return ApiHelper.JsonDeserialize<Models.ResponseTeamMembers>(response.Body);
        }

        /// <summary>
        /// Get a list of Team Members in your Lacework instance, by invoking the following endpoint:.
        ///   > `GET https://YourLacework.lacework.net/api/v2/TeamMembers`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <returns>Returns the Models.ResponseTeamMembersList response from the API call.</returns>
        public Models.ResponseTeamMembersList ListAllTeamMembers(
                string authorization,
                string contentType)
        {
            Task<Models.ResponseTeamMembersList> t = this.ListAllTeamMembersAsync(authorization, contentType);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get a list of Team Members in your Lacework instance, by invoking the following endpoint:.
        ///   > `GET https://YourLacework.lacework.net/api/v2/TeamMembers`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseTeamMembersList response from the API call.</returns>
        public async Task<Models.ResponseTeamMembersList> ListAllTeamMembersAsync(
                string authorization,
                string contentType,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/TeamMembers");

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

            return ApiHelper.JsonDeserialize<Models.ResponseTeamMembersList>(response.Body);
        }

        /// <summary>
        /// Search all the team members in your Lacework instance,  by invoking the following endpoint:.
        ///   > `POST https://YourLacework.lacework.net/api/v2/TeamMembers/search`.
        ///   To limit the returned result, optionally specify one or more filters in the request `body`. For more information about using filters, see the [Simple & Advanced Search section](/api/v2/docs/#tag/OVERVIEW)..
        ///   You can filter on the following fields:.
        ///   * `custGuid`.
        ///   * `userGuid`.
        ///   * `userName`.
        ///   * `userEnabled`.
        ///   Here is an example `body` payload:.
        ///   > `{ "filters" : [ { "expression": "eq", "field": "userName",  "value": "jane.smith@mycompany.com" } ] } `.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ResponseTeamMembersList response from the API call.</returns>
        public Models.ResponseTeamMembersList SearchTeamMembers(
                string authorization,
                string contentType,
                Models.GETDATAREQUESTBODYFILTERS body)
        {
            Task<Models.ResponseTeamMembersList> t = this.SearchTeamMembersAsync(authorization, contentType, body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Search all the team members in your Lacework instance,  by invoking the following endpoint:.
        ///   > `POST https://YourLacework.lacework.net/api/v2/TeamMembers/search`.
        ///   To limit the returned result, optionally specify one or more filters in the request `body`. For more information about using filters, see the [Simple & Advanced Search section](/api/v2/docs/#tag/OVERVIEW)..
        ///   You can filter on the following fields:.
        ///   * `custGuid`.
        ///   * `userGuid`.
        ///   * `userName`.
        ///   * `userEnabled`.
        ///   Here is an example `body` payload:.
        ///   > `{ "filters" : [ { "expression": "eq", "field": "userName",  "value": "jane.smith@mycompany.com" } ] } `.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseTeamMembersList response from the API call.</returns>
        public async Task<Models.ResponseTeamMembersList> SearchTeamMembersAsync(
                string authorization,
                string contentType,
                Models.GETDATAREQUESTBODYFILTERS body,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/TeamMembers/search");

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

            return ApiHelper.JsonDeserialize<Models.ResponseTeamMembersList>(response.Body);
        }

        /// <summary>
        /// Get details about a Team Member  by invoking the following endpoint:.
        ///   > `GET https://YourLacework.lacework.net/api/v2/TeamMembers/{userGuid}`.
        ///   Replace `{userGuid}` with the `userGuid` value returned for a Team Member in the response when the  `GET /api/v2/TeamMembers` endpoint is invoked..
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="userGuid">Required parameter: Team Member userGuid.</param>
        /// <returns>Returns the Models.ResponseTeamMembers response from the API call.</returns>
        public Models.ResponseTeamMembers TeamMemberDetails(
                string authorization,
                string contentType,
                string userGuid)
        {
            Task<Models.ResponseTeamMembers> t = this.TeamMemberDetailsAsync(authorization, contentType, userGuid);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get details about a Team Member  by invoking the following endpoint:.
        ///   > `GET https://YourLacework.lacework.net/api/v2/TeamMembers/{userGuid}`.
        ///   Replace `{userGuid}` with the `userGuid` value returned for a Team Member in the response when the  `GET /api/v2/TeamMembers` endpoint is invoked..
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="userGuid">Required parameter: Team Member userGuid.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseTeamMembers response from the API call.</returns>
        public async Task<Models.ResponseTeamMembers> TeamMemberDetailsAsync(
                string authorization,
                string contentType,
                string userGuid,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/TeamMembers/{userGuid}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "userGuid", userGuid },
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

            return ApiHelper.JsonDeserialize<Models.ResponseTeamMembers>(response.Body);
        }

        /// <summary>
        /// Optionally update the `userName` and`userEnabled` settings and the `props`  sub-settings of the passed in Team Member.  Update these settings by invoking the following endpoint:.
        ///   > `PATCH https://YourLacework.lacework.net/api/v2/TeamMembers/{userGuid}`.
        ///   Replace `{userGuid}` with the `userGuid` value returned for a Team Member in the response, when the  `GET /api/v2/TeamMembers` endpoint is invoked..
        ///   Here is an example `body` payload:.
        ///   > `{ "props": {"firstName":"Jane"} }`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="userGuid">Required parameter: Team Member userGuid.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="orgAccess">Optional parameter: Org account privileges.</param>
        /// <returns>Returns the Models.ResponseUpdateTeamMember response from the API call.</returns>
        public Models.ResponseUpdateTeamMember UpdateTeamMember(
                string authorization,
                string contentType,
                string userGuid,
                object body,
                bool? orgAccess = null)
        {
            Task<Models.ResponseUpdateTeamMember> t = this.UpdateTeamMemberAsync(authorization, contentType, userGuid, body, orgAccess);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Optionally update the `userName` and`userEnabled` settings and the `props`  sub-settings of the passed in Team Member.  Update these settings by invoking the following endpoint:.
        ///   > `PATCH https://YourLacework.lacework.net/api/v2/TeamMembers/{userGuid}`.
        ///   Replace `{userGuid}` with the `userGuid` value returned for a Team Member in the response, when the  `GET /api/v2/TeamMembers` endpoint is invoked..
        ///   Here is an example `body` payload:.
        ///   > `{ "props": {"firstName":"Jane"} }`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="userGuid">Required parameter: Team Member userGuid.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="orgAccess">Optional parameter: Org account privileges.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseUpdateTeamMember response from the API call.</returns>
        public async Task<Models.ResponseUpdateTeamMember> UpdateTeamMemberAsync(
                string authorization,
                string contentType,
                string userGuid,
                object body,
                bool? orgAccess = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/TeamMembers/{userGuid}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "userGuid", userGuid },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
                { "Authorization", authorization },
                { "Content-Type", contentType },
                { "Org-Access", orgAccess.ToString() },
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

            return ApiHelper.JsonDeserialize<Models.ResponseUpdateTeamMember>(response.Body);
        }

        /// <summary>
        /// Delete a Team Member by invoking the following endpoint:.
        ///   > `DELETE https://YourLacework.lacework.net/api/v2/TeamMembers/{userGuid}`.
        ///   Replace `{userGuid}` with the `userGuid` value returned for a Team Member in the response when the  `GET /api/v2/TeamMembers` endpoint is invoked..
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="userGuid">Required parameter: Team Member userGuid.</param>
        public void DeleteTeamMember(
                string authorization,
                string contentType,
                string userGuid)
        {
            Task t = this.DeleteTeamMemberAsync(authorization, contentType, userGuid);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Delete a Team Member by invoking the following endpoint:.
        ///   > `DELETE https://YourLacework.lacework.net/api/v2/TeamMembers/{userGuid}`.
        ///   Replace `{userGuid}` with the `userGuid` value returned for a Team Member in the response when the  `GET /api/v2/TeamMembers` endpoint is invoked..
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="userGuid">Required parameter: Team Member userGuid.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteTeamMemberAsync(
                string authorization,
                string contentType,
                string userGuid,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/TeamMembers/{userGuid}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "userGuid", userGuid },
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