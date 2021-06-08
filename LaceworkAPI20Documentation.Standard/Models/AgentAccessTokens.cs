// <copyright file="AgentAccessTokens.cs" company="APIMatic">
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
    /// AgentAccessTokens.
    /// </summary>
    public class AgentAccessTokens
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAccessTokens"/> class.
        /// </summary>
        public AgentAccessTokens()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAccessTokens"/> class.
        /// </summary>
        /// <param name="tokenEnabled">tokenEnabled.</param>
        /// <param name="tokenAlias">tokenAlias.</param>
        /// <param name="accessToken">accessToken.</param>
        /// <param name="createdTime">createdTime.</param>
        /// <param name="props">props.</param>
        /// <param name="version">version.</param>
        public AgentAccessTokens(
            string tokenEnabled,
            string tokenAlias,
            string accessToken = null,
            string createdTime = null,
            string props = null,
            string version = null)
        {
            this.TokenEnabled = tokenEnabled;
            this.TokenAlias = tokenAlias;
            this.AccessToken = accessToken;
            this.CreatedTime = createdTime;
            this.Props = props;
            this.Version = version;
        }

        /// <summary>
        /// Gets or sets TokenEnabled.
        /// </summary>
        [JsonProperty("tokenEnabled")]
        public string TokenEnabled { get; set; }

        /// <summary>
        /// Gets or sets TokenAlias.
        /// </summary>
        [JsonProperty("tokenAlias")]
        public string TokenAlias { get; set; }

        /// <summary>
        /// Gets or sets AccessToken.
        /// </summary>
        [JsonProperty("accessToken", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or sets CreatedTime.
        /// </summary>
        [JsonProperty("createdTime", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// Gets or sets Props.
        /// </summary>
        [JsonProperty("props", NullValueHandling = NullValueHandling.Ignore)]
        public string Props { get; set; }

        /// <summary>
        /// Gets or sets Version.
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AgentAccessTokens : ({string.Join(", ", toStringOutput)})";
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

            return obj is AgentAccessTokens other &&
                ((this.TokenEnabled == null && other.TokenEnabled == null) || (this.TokenEnabled?.Equals(other.TokenEnabled) == true)) &&
                ((this.TokenAlias == null && other.TokenAlias == null) || (this.TokenAlias?.Equals(other.TokenAlias) == true)) &&
                ((this.AccessToken == null && other.AccessToken == null) || (this.AccessToken?.Equals(other.AccessToken) == true)) &&
                ((this.CreatedTime == null && other.CreatedTime == null) || (this.CreatedTime?.Equals(other.CreatedTime) == true)) &&
                ((this.Props == null && other.Props == null) || (this.Props?.Equals(other.Props) == true)) &&
                ((this.Version == null && other.Version == null) || (this.Version?.Equals(other.Version) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1057125236;

            if (this.TokenEnabled != null)
            {
               hashCode += this.TokenEnabled.GetHashCode();
            }

            if (this.TokenAlias != null)
            {
               hashCode += this.TokenAlias.GetHashCode();
            }

            if (this.AccessToken != null)
            {
               hashCode += this.AccessToken.GetHashCode();
            }

            if (this.CreatedTime != null)
            {
               hashCode += this.CreatedTime.GetHashCode();
            }

            if (this.Props != null)
            {
               hashCode += this.Props.GetHashCode();
            }

            if (this.Version != null)
            {
               hashCode += this.Version.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TokenEnabled = {(this.TokenEnabled == null ? "null" : this.TokenEnabled == string.Empty ? "" : this.TokenEnabled)}");
            toStringOutput.Add($"this.TokenAlias = {(this.TokenAlias == null ? "null" : this.TokenAlias == string.Empty ? "" : this.TokenAlias)}");
            toStringOutput.Add($"this.AccessToken = {(this.AccessToken == null ? "null" : this.AccessToken == string.Empty ? "" : this.AccessToken)}");
            toStringOutput.Add($"this.CreatedTime = {(this.CreatedTime == null ? "null" : this.CreatedTime == string.Empty ? "" : this.CreatedTime)}");
            toStringOutput.Add($"this.Props = {(this.Props == null ? "null" : this.Props == string.Empty ? "" : this.Props)}");
            toStringOutput.Add($"this.Version = {(this.Version == null ? "null" : this.Version == string.Empty ? "" : this.Version)}");
        }
    }
}