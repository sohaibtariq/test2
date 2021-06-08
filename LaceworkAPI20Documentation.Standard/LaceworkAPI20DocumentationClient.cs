// <copyright file="LaceworkAPI20DocumentationClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace LaceworkAPI20Documentation.Standard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Text;
    using LaceworkAPI20Documentation.Standard.Authentication;
    using LaceworkAPI20Documentation.Standard.Controllers;
    using LaceworkAPI20Documentation.Standard.Http.Client;
    using LaceworkAPI20Documentation.Standard.Utilities;

    /// <summary>
    /// The gateway for the SDK. This class acts as a factory for Controller and
    /// holds the configuration of the SDK.
    /// </summary>
    public sealed class LaceworkAPI20DocumentationClient : IConfiguration
    {
        // A map of environments and their corresponding servers/baseurls
        private static readonly Dictionary<Environment, Dictionary<Server, string>> EnvironmentsMap =
            new Dictionary<Environment, Dictionary<Server, string>>
        {
            {
                Environment.Production, new Dictionary<Server, string>
                {
                    { Server.Default, "https://{defaultHost}" },
                }
            },
        };

        private readonly IDictionary<string, IAuthManager> authManagers;
        private readonly IHttpClient httpClient;

        private readonly Lazy<ACCESSTOKENSController> aCCESSTOKENS;
        private readonly Lazy<SCHEMASController> sCHEMAS;
        private readonly Lazy<AgentAccessTokensController> agentAccessTokens;
        private readonly Lazy<AlertChannelsController> alertChannels;
        private readonly Lazy<AlertRulesController> alertRules;
        private readonly Lazy<AuditLogsController> auditLogs;
        private readonly Lazy<CloudAccountsController> cloudAccounts;
        private readonly Lazy<CloudActivitiesController> cloudActivities;
        private readonly Lazy<ContainerRegistriesController> containerRegistries;
        private readonly Lazy<ContractInfoController> contractInfo;
        private readonly Lazy<ReportRulesController> reportRules;
        private readonly Lazy<ResourceGroupsController> resourceGroups;
        private readonly Lazy<TeamMembersController> teamMembers;
        private readonly Lazy<UserProfileController> userProfile;

        private LaceworkAPI20DocumentationClient(
            Environment environment,
            string defaultHost,
            IDictionary<string, IAuthManager> authManagers,
            IHttpClient httpClient,
            IHttpClientConfiguration httpClientConfiguration)
        {
            this.Environment = environment;
            this.DefaultHost = defaultHost;
            this.httpClient = httpClient;
            this.authManagers = (authManagers == null) ? new Dictionary<string, IAuthManager>() : new Dictionary<string, IAuthManager>(authManagers);
            this.HttpClientConfiguration = httpClientConfiguration;

            this.aCCESSTOKENS = new Lazy<ACCESSTOKENSController>(
                () => new ACCESSTOKENSController(this, this.httpClient, this.authManagers));
            this.sCHEMAS = new Lazy<SCHEMASController>(
                () => new SCHEMASController(this, this.httpClient, this.authManagers));
            this.agentAccessTokens = new Lazy<AgentAccessTokensController>(
                () => new AgentAccessTokensController(this, this.httpClient, this.authManagers));
            this.alertChannels = new Lazy<AlertChannelsController>(
                () => new AlertChannelsController(this, this.httpClient, this.authManagers));
            this.alertRules = new Lazy<AlertRulesController>(
                () => new AlertRulesController(this, this.httpClient, this.authManagers));
            this.auditLogs = new Lazy<AuditLogsController>(
                () => new AuditLogsController(this, this.httpClient, this.authManagers));
            this.cloudAccounts = new Lazy<CloudAccountsController>(
                () => new CloudAccountsController(this, this.httpClient, this.authManagers));
            this.cloudActivities = new Lazy<CloudActivitiesController>(
                () => new CloudActivitiesController(this, this.httpClient, this.authManagers));
            this.containerRegistries = new Lazy<ContainerRegistriesController>(
                () => new ContainerRegistriesController(this, this.httpClient, this.authManagers));
            this.contractInfo = new Lazy<ContractInfoController>(
                () => new ContractInfoController(this, this.httpClient, this.authManagers));
            this.reportRules = new Lazy<ReportRulesController>(
                () => new ReportRulesController(this, this.httpClient, this.authManagers));
            this.resourceGroups = new Lazy<ResourceGroupsController>(
                () => new ResourceGroupsController(this, this.httpClient, this.authManagers));
            this.teamMembers = new Lazy<TeamMembersController>(
                () => new TeamMembersController(this, this.httpClient, this.authManagers));
            this.userProfile = new Lazy<UserProfileController>(
                () => new UserProfileController(this, this.httpClient, this.authManagers));
        }

        /// <summary>
        /// Gets ACCESSTOKENSController controller.
        /// </summary>
        public ACCESSTOKENSController ACCESSTOKENSController => this.aCCESSTOKENS.Value;

        /// <summary>
        /// Gets SCHEMASController controller.
        /// </summary>
        public SCHEMASController SCHEMASController => this.sCHEMAS.Value;

        /// <summary>
        /// Gets AgentAccessTokensController controller.
        /// </summary>
        public AgentAccessTokensController AgentAccessTokensController => this.agentAccessTokens.Value;

        /// <summary>
        /// Gets AlertChannelsController controller.
        /// </summary>
        public AlertChannelsController AlertChannelsController => this.alertChannels.Value;

        /// <summary>
        /// Gets AlertRulesController controller.
        /// </summary>
        public AlertRulesController AlertRulesController => this.alertRules.Value;

        /// <summary>
        /// Gets AuditLogsController controller.
        /// </summary>
        public AuditLogsController AuditLogsController => this.auditLogs.Value;

        /// <summary>
        /// Gets CloudAccountsController controller.
        /// </summary>
        public CloudAccountsController CloudAccountsController => this.cloudAccounts.Value;

        /// <summary>
        /// Gets CloudActivitiesController controller.
        /// </summary>
        public CloudActivitiesController CloudActivitiesController => this.cloudActivities.Value;

        /// <summary>
        /// Gets ContainerRegistriesController controller.
        /// </summary>
        public ContainerRegistriesController ContainerRegistriesController => this.containerRegistries.Value;

        /// <summary>
        /// Gets ContractInfoController controller.
        /// </summary>
        public ContractInfoController ContractInfoController => this.contractInfo.Value;

        /// <summary>
        /// Gets ReportRulesController controller.
        /// </summary>
        public ReportRulesController ReportRulesController => this.reportRules.Value;

        /// <summary>
        /// Gets ResourceGroupsController controller.
        /// </summary>
        public ResourceGroupsController ResourceGroupsController => this.resourceGroups.Value;

        /// <summary>
        /// Gets TeamMembersController controller.
        /// </summary>
        public TeamMembersController TeamMembersController => this.teamMembers.Value;

        /// <summary>
        /// Gets UserProfileController controller.
        /// </summary>
        public UserProfileController UserProfileController => this.userProfile.Value;

        /// <summary>
        /// Gets the configuration of the Http Client associated with this client.
        /// </summary>
        public IHttpClientConfiguration HttpClientConfiguration { get; }

        /// <summary>
        /// Gets Environment.
        /// Current API environment.
        /// </summary>
        public Environment Environment { get; }

        /// <summary>
        /// Gets DefaultHost.
        /// DefaultHost value.
        /// </summary>
        public string DefaultHost { get; }

        /// <summary>
        /// Gets auth managers.
        /// </summary>
        internal IDictionary<string, IAuthManager> AuthManagers => this.authManagers;

        /// <summary>
        /// Gets http client.
        /// </summary>
        internal IHttpClient HttpClient => this.httpClient;

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends
        /// it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:DEFAULT.</param>
        /// <returns>Returns the baseurl.</returns>
        public string GetBaseUri(Server alias = Server.Default)
        {
            StringBuilder url = new StringBuilder(EnvironmentsMap[this.Environment][alias]);
            ApiHelper.AppendUrlWithTemplateParameters(url, this.GetBaseUriParameters());

            return url.ToString();
        }

        /// <summary>
        /// Creates an object of the LaceworkAPI20DocumentationClient using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            Builder builder = new Builder()
                .Environment(this.Environment)
                .DefaultHost(this.DefaultHost)
                .HttpClient(this.httpClient)
                .AuthManagers(this.authManagers)
                .HttpClientConfig(config => config.Build());

            return builder;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return
                $"Environment = {this.Environment}, " +
                $"DefaultHost = {this.DefaultHost}, " +
                $"HttpClientConfiguration = {this.HttpClientConfiguration}, ";
        }

        /// <summary>
        /// Creates the client using builder.
        /// </summary>
        /// <returns> LaceworkAPI20DocumentationClient.</returns>
        internal static LaceworkAPI20DocumentationClient CreateFromEnvironment()
        {
            var builder = new Builder();

            string environment = System.Environment.GetEnvironmentVariable("LACEWORK_API_20_DOCUMENTATION_STANDARD_ENVIRONMENT");
            string defaultHost = System.Environment.GetEnvironmentVariable("LACEWORK_API_20_DOCUMENTATION_STANDARD_DEFAULT_HOST");

            if (environment != null)
            {
                builder.Environment(ApiHelper.JsonDeserialize<Environment>($"\"{environment}\""));
            }

            if (defaultHost != null)
            {
                builder.DefaultHost(defaultHost);
            }

            return builder.Build();
        }

        /// <summary>
        /// Makes a list of the BaseURL parameters.
        /// </summary>
        /// <returns>Returns the parameters list.</returns>
        private List<KeyValuePair<string, object>> GetBaseUriParameters()
        {
            List<KeyValuePair<string, object>> kvpList = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("defaultHost", this.DefaultHost),
            };
            return kvpList;
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private Environment environment = LaceworkAPI20Documentation.Standard.Environment.Production;
            private string defaultHost = "www.example.com";
            private IDictionary<string, IAuthManager> authManagers = new Dictionary<string, IAuthManager>();
            private bool createCustomHttpClient = false;
            private HttpClientConfiguration.Builder httpClientConfig = new HttpClientConfiguration.Builder();
            private IHttpClient httpClient;

            /// <summary>
            /// Sets Environment.
            /// </summary>
            /// <param name="environment"> Environment. </param>
            /// <returns> Builder. </returns>
            public Builder Environment(Environment environment)
            {
                this.environment = environment;
                return this;
            }

            /// <summary>
            /// Sets DefaultHost.
            /// </summary>
            /// <param name="defaultHost"> DefaultHost. </param>
            /// <returns> Builder. </returns>
            public Builder DefaultHost(string defaultHost)
            {
                this.defaultHost = defaultHost ?? throw new ArgumentNullException(nameof(defaultHost));
                return this;
            }

            /// <summary>
            /// Sets HttpClientConfig.
            /// </summary>
            /// <param name="action"> Action. </param>
            /// <returns>Builder.</returns>
            public Builder HttpClientConfig(Action<HttpClientConfiguration.Builder> action)
            {
                if (action is null)
                {
                    throw new ArgumentNullException(nameof(action));
                }

                action(this.httpClientConfig);
                this.createCustomHttpClient = true;
                return this;
            }

            /// <summary>
            /// Sets the IHttpClient for the Builder.
            /// </summary>
            /// <param name="httpClient"> http client. </param>
            /// <returns>Builder.</returns>
            internal Builder HttpClient(IHttpClient httpClient)
            {
                this.httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
                return this;
            }

            /// <summary>
            /// Sets the authentication managers for the Builder.
            /// </summary>
            /// <param name="authManagers"> auth managers. </param>
            /// <returns>Builder.</returns>
            internal Builder AuthManagers(IDictionary<string, IAuthManager> authManagers)
            {
                this.authManagers = authManagers ?? throw new ArgumentNullException(nameof(authManagers));
                return this;
            }

            /// <summary>
            /// Creates an object of the LaceworkAPI20DocumentationClient using the values provided for the builder.
            /// </summary>
            /// <returns>LaceworkAPI20DocumentationClient.</returns>
            public LaceworkAPI20DocumentationClient Build()
            {
                if (this.createCustomHttpClient)
                {
                    this.httpClient = new HttpClientWrapper(this.httpClientConfig.Build());
                }
                else
                {
                    this.httpClient = new HttpClientWrapper();
                }

                return new LaceworkAPI20DocumentationClient(
                    this.environment,
                    this.defaultHost,
                    this.authManagers,
                    this.httpClient,
                    this.httpClientConfig.Build());
            }
        }
    }
}
