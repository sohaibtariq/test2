// <copyright file="ContainerRegistriesController.cs" company="APIMatic">
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
    /// ContainerRegistriesController.
    /// </summary>
    public class ContainerRegistriesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerRegistriesController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        internal ContainerRegistriesController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers)
            : base(config, httpClient, authManagers)
        {
        }

        /// <summary>
        /// Create a container registry by specifying parameters in the request  body when invoking the following endpoint:.
        ///   > `POST https://YourLacework.lacework.net/api/v2/ContainerRegistries`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ResponseContainerRegistries response from the API call.</returns>
        public Models.ResponseContainerRegistries CreateContainerRegistries(
                string authorization,
                string contentType,
                Models.ContVulnCfg2 body)
        {
            Task<Models.ResponseContainerRegistries> t = this.CreateContainerRegistriesAsync(authorization, contentType, body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Create a container registry by specifying parameters in the request  body when invoking the following endpoint:.
        ///   > `POST https://YourLacework.lacework.net/api/v2/ContainerRegistries`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseContainerRegistries response from the API call.</returns>
        public async Task<Models.ResponseContainerRegistries> CreateContainerRegistriesAsync(
                string authorization,
                string contentType,
                Models.ContVulnCfg2 body,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/ContainerRegistries");

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

            return ApiHelper.JsonDeserialize<Models.ResponseContainerRegistries>(response.Body);
        }

        /// <summary>
        /// Get a list of container registries for the current user by invoking the following endpoint:.
        ///   > `GET https://YourLacework.lacework.net/api/v2/ContainerRegistries`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <returns>Returns the Models.ResponseContainerRegistriesList response from the API call.</returns>
        public Models.ResponseContainerRegistriesList ListAllContainerRegistries(
                string authorization,
                string contentType)
        {
            Task<Models.ResponseContainerRegistriesList> t = this.ListAllContainerRegistriesAsync(authorization, contentType);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get a list of container registries for the current user by invoking the following endpoint:.
        ///   > `GET https://YourLacework.lacework.net/api/v2/ContainerRegistries`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseContainerRegistriesList response from the API call.</returns>
        public async Task<Models.ResponseContainerRegistriesList> ListAllContainerRegistriesAsync(
                string authorization,
                string contentType,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/ContainerRegistries");

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

            return ApiHelper.JsonDeserialize<Models.ResponseContainerRegistriesList>(response.Body);
        }

        /// <summary>
        /// Get a list of container registries of the specified type by invoking the following endpoint:.
        ///   > `GET https://YourLacework.lacework.net/api/v2/ContainerRegistries/{type}/{subtype}`.
        ///   Here is an example invocation: .
        ///   > `GET https://YourLacework.lacework.net/api/v2/ContainerRegistries/ContVulnCfg/AWS_ECR`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="type">Required parameter: Container Registry Type.</param>
        /// <param name="subtype">Required parameter: Container Registry Subtype.</param>
        /// <returns>Returns the Models.ResponseContainerRegistriesList response from the API call.</returns>
        public Models.ResponseContainerRegistriesList ListContainerRegistriesByType(
                string authorization,
                string contentType,
                Models.Type2Enum type,
                Models.ContVulnCfg1Enum subtype)
        {
            Task<Models.ResponseContainerRegistriesList> t = this.ListContainerRegistriesByTypeAsync(authorization, contentType, type, subtype);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get a list of container registries of the specified type by invoking the following endpoint:.
        ///   > `GET https://YourLacework.lacework.net/api/v2/ContainerRegistries/{type}/{subtype}`.
        ///   Here is an example invocation: .
        ///   > `GET https://YourLacework.lacework.net/api/v2/ContainerRegistries/ContVulnCfg/AWS_ECR`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="type">Required parameter: Container Registry Type.</param>
        /// <param name="subtype">Required parameter: Container Registry Subtype.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseContainerRegistriesList response from the API call.</returns>
        public async Task<Models.ResponseContainerRegistriesList> ListContainerRegistriesByTypeAsync(
                string authorization,
                string contentType,
                Models.Type2Enum type,
                Models.ContVulnCfg1Enum subtype,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/ContainerRegistries/{type}/{subtype}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "type", ApiHelper.JsonSerialize(type).Trim('\"') },
                { "subtype", ApiHelper.JsonSerialize(subtype).Trim('\"') },
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

            return ApiHelper.JsonDeserialize<Models.ResponseContainerRegistriesList>(response.Body);
        }

        /// <summary>
        /// Search container registries by invoking the following endpoint:.
        ///   > `POST https://YourLacework.lacework.net/api/v2/ContainerRegistries/search`.
        ///  To limit the returned result, optionally specify one or more `filters` in the request `body`. For more information about using filters, see the [Simple & Advanced Search section](/api/v2/docs/#tag/OVERVIEW)..
        ///   In the request body, optionally specify the list of fields to return in the response by specifying the list in the `returns` array, for example, `"returns":[ "name", "type", "enabled" ]`..
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ResponseContainerRegistriesList response from the API call.</returns>
        public Models.ResponseContainerRegistriesList SearchContainerRegistries(
                string authorization,
                string contentType,
                Models.GETDATAREQUESTBODYFILTERS body)
        {
            Task<Models.ResponseContainerRegistriesList> t = this.SearchContainerRegistriesAsync(authorization, contentType, body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Search container registries by invoking the following endpoint:.
        ///   > `POST https://YourLacework.lacework.net/api/v2/ContainerRegistries/search`.
        ///  To limit the returned result, optionally specify one or more `filters` in the request `body`. For more information about using filters, see the [Simple & Advanced Search section](/api/v2/docs/#tag/OVERVIEW)..
        ///   In the request body, optionally specify the list of fields to return in the response by specifying the list in the `returns` array, for example, `"returns":[ "name", "type", "enabled" ]`..
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseContainerRegistriesList response from the API call.</returns>
        public async Task<Models.ResponseContainerRegistriesList> SearchContainerRegistriesAsync(
                string authorization,
                string contentType,
                Models.GETDATAREQUESTBODYFILTERS body,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/ContainerRegistries/search");

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

            return ApiHelper.JsonDeserialize<Models.ResponseContainerRegistriesList>(response.Body);
        }

        /// <summary>
        /// Get the details about a container registry by invoking the following endpoint:.
        ///   > `GET https://YourLacework.lacework.net/api/v2/ContainerRegistries/{intgGuid}`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="intgGuid">Required parameter: Container Registry intgGuid.</param>
        /// <returns>Returns the Models.ResponseContainerRegistries response from the API call.</returns>
        public Models.ResponseContainerRegistries ContainerRegistryDetails(
                string authorization,
                string contentType,
                string intgGuid)
        {
            Task<Models.ResponseContainerRegistries> t = this.ContainerRegistryDetailsAsync(authorization, contentType, intgGuid);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get the details about a container registry by invoking the following endpoint:.
        ///   > `GET https://YourLacework.lacework.net/api/v2/ContainerRegistries/{intgGuid}`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="intgGuid">Required parameter: Container Registry intgGuid.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseContainerRegistries response from the API call.</returns>
        public async Task<Models.ResponseContainerRegistries> ContainerRegistryDetailsAsync(
                string authorization,
                string contentType,
                string intgGuid,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/ContainerRegistries/{intgGuid}");

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

            return ApiHelper.JsonDeserialize<Models.ResponseContainerRegistries>(response.Body);
        }

        /// <summary>
        /// Update a container registry by specifying parameters in the request body when invoking the following endpoint: .
        ///   > `PATCH https://YourLacework.lacework.net/api/v2/ContainerRegistries/{intgGuid}` .
        ///   In the request body, only specify the parameter(s) that you want to update, for example, `{ "enabled" : 0 }`..
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="intgGuid">Required parameter: Container Registry intgGuid.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ResponseContainerRegistries response from the API call.</returns>
        public Models.ResponseContainerRegistries UpdateContainerRegistries(
                string authorization,
                string contentType,
                string intgGuid,
                Models.ContVulnCfg3 body)
        {
            Task<Models.ResponseContainerRegistries> t = this.UpdateContainerRegistriesAsync(authorization, contentType, intgGuid, body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Update a container registry by specifying parameters in the request body when invoking the following endpoint: .
        ///   > `PATCH https://YourLacework.lacework.net/api/v2/ContainerRegistries/{intgGuid}` .
        ///   In the request body, only specify the parameter(s) that you want to update, for example, `{ "enabled" : 0 }`..
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="intgGuid">Required parameter: Container Registry intgGuid.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseContainerRegistries response from the API call.</returns>
        public async Task<Models.ResponseContainerRegistries> UpdateContainerRegistriesAsync(
                string authorization,
                string contentType,
                string intgGuid,
                Models.ContVulnCfg3 body,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/ContainerRegistries/{intgGuid}");

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

            return ApiHelper.JsonDeserialize<Models.ResponseContainerRegistries>(response.Body);
        }

        /// <summary>
        /// Delete a container registry by invoking the following endpoint:.
        ///   > `DELETE https://YourLacework.lacework.net/api/v2/ContainerRegistries/{intgGuid}`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="intgGuid">Required parameter: Container Registry intgGuid.</param>
        public void DeleteContainerRegistries(
                string authorization,
                string contentType,
                string intgGuid)
        {
            Task t = this.DeleteContainerRegistriesAsync(authorization, contentType, intgGuid);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Delete a container registry by invoking the following endpoint:.
        ///   > `DELETE https://YourLacework.lacework.net/api/v2/ContainerRegistries/{intgGuid}`.
        /// </summary>
        /// <param name="authorization">Required parameter: Bearer AccessToken.</param>
        /// <param name="contentType">Required parameter: application/json.</param>
        /// <param name="intgGuid">Required parameter: Container Registry intgGuid.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteContainerRegistriesAsync(
                string authorization,
                string contentType,
                string intgGuid,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/ContainerRegistries/{intgGuid}");

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