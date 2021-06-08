// <copyright file="JIRACLOUD.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace LaceworkAPI20Documentation.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using LaceworkAPI20Documentation.Standard;
    using LaceworkAPI20Documentation.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// JIRACLOUD.
    /// </summary>
    public class JIRACLOUD
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JIRACLOUD"/> class.
        /// </summary>
        public JIRACLOUD()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JIRACLOUD"/> class.
        /// </summary>
        /// <param name="jiraUrl">jiraUrl.</param>
        /// <param name="projectId">projectId.</param>
        /// <param name="issueType">issueType.</param>
        /// <param name="username">username.</param>
        /// <param name="apiToken">apiToken.</param>
        /// <param name="jiraType">jiraType.</param>
        /// <param name="issueGrouping">issueGrouping.</param>
        /// <param name="customTemplateFile">customTemplateFile.</param>
        public JIRACLOUD(
            string jiraUrl,
            string projectId,
            string issueType,
            string username,
            string apiToken,
            Models.JiraTypeEnum? jiraType = Models.JiraTypeEnum.JIRACLOUD,
            Models.GroupIssuesByEnum? issueGrouping = Models.GroupIssuesByEnum.Events,
            Stream customTemplateFile = null)
        {
            this.JiraType = jiraType;
            this.IssueGrouping = issueGrouping;
            this.JiraUrl = jiraUrl;
            this.ProjectId = projectId;
            this.IssueType = issueType;
            this.Username = username;
            this.ApiToken = apiToken;
            this.CustomTemplateFile = customTemplateFile;
        }

        /// <summary>
        /// Gets or sets JiraType.
        /// </summary>
        [JsonProperty("jiraType", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.JiraTypeEnum? JiraType { get; set; }

        /// <summary>
        /// Gets or sets IssueGrouping.
        /// </summary>
        [JsonProperty("issueGrouping", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.GroupIssuesByEnum? IssueGrouping { get; set; }

        /// <summary>
        /// Gets or sets JiraUrl.
        /// </summary>
        [JsonProperty("jiraUrl")]
        public string JiraUrl { get; set; }

        /// <summary>
        /// Gets or sets ProjectId.
        /// </summary>
        [JsonProperty("projectId")]
        public string ProjectId { get; set; }

        /// <summary>
        /// Gets or sets IssueType.
        /// </summary>
        [JsonProperty("issueType")]
        public string IssueType { get; set; }

        /// <summary>
        /// Gets or sets Username.
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets ApiToken.
        /// </summary>
        [JsonProperty("apiToken")]
        public string ApiToken { get; set; }

        /// <summary>
        /// Gets or sets CustomTemplateFile.
        /// </summary>
        [JsonProperty("customTemplateFile", NullValueHandling = NullValueHandling.Ignore)]
        public Stream CustomTemplateFile { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"JIRACLOUD : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            return obj is JIRACLOUD other &&
                ((this.JiraType == null && other.JiraType == null) || (this.JiraType?.Equals(other.JiraType) == true)) &&
                ((this.IssueGrouping == null && other.IssueGrouping == null) || (this.IssueGrouping?.Equals(other.IssueGrouping) == true)) &&
                ((this.JiraUrl == null && other.JiraUrl == null) || (this.JiraUrl?.Equals(other.JiraUrl) == true)) &&
                ((this.ProjectId == null && other.ProjectId == null) || (this.ProjectId?.Equals(other.ProjectId) == true)) &&
                ((this.IssueType == null && other.IssueType == null) || (this.IssueType?.Equals(other.IssueType) == true)) &&
                ((this.Username == null && other.Username == null) || (this.Username?.Equals(other.Username) == true)) &&
                ((this.ApiToken == null && other.ApiToken == null) || (this.ApiToken?.Equals(other.ApiToken) == true)) &&
                ((this.CustomTemplateFile == null && other.CustomTemplateFile == null) || (this.CustomTemplateFile?.Equals(other.CustomTemplateFile) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 382366515;

            if (this.JiraType != null)
            {
               hashCode += this.JiraType.GetHashCode();
            }

            if (this.IssueGrouping != null)
            {
               hashCode += this.IssueGrouping.GetHashCode();
            }

            if (this.JiraUrl != null)
            {
               hashCode += this.JiraUrl.GetHashCode();
            }

            if (this.ProjectId != null)
            {
               hashCode += this.ProjectId.GetHashCode();
            }

            if (this.IssueType != null)
            {
               hashCode += this.IssueType.GetHashCode();
            }

            if (this.Username != null)
            {
               hashCode += this.Username.GetHashCode();
            }

            if (this.ApiToken != null)
            {
               hashCode += this.ApiToken.GetHashCode();
            }

            if (this.CustomTemplateFile != null)
            {
               hashCode += this.CustomTemplateFile.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.JiraType = {(this.JiraType == null ? "null" : this.JiraType.ToString())}");
            toStringOutput.Add($"this.IssueGrouping = {(this.IssueGrouping == null ? "null" : this.IssueGrouping.ToString())}");
            toStringOutput.Add($"this.JiraUrl = {(this.JiraUrl == null ? "null" : this.JiraUrl == string.Empty ? "" : this.JiraUrl)}");
            toStringOutput.Add($"this.ProjectId = {(this.ProjectId == null ? "null" : this.ProjectId == string.Empty ? "" : this.ProjectId)}");
            toStringOutput.Add($"this.IssueType = {(this.IssueType == null ? "null" : this.IssueType == string.Empty ? "" : this.IssueType)}");
            toStringOutput.Add($"this.Username = {(this.Username == null ? "null" : this.Username == string.Empty ? "" : this.Username)}");
            toStringOutput.Add($"this.ApiToken = {(this.ApiToken == null ? "null" : this.ApiToken == string.Empty ? "" : this.ApiToken)}");
            toStringOutput.Add($"this.CustomTemplateFile = {(this.CustomTemplateFile == null ? "null" : this.CustomTemplateFile.ToString())}");
        }
    }
}