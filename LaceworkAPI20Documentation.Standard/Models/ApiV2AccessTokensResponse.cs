// <copyright file="ApiV2AccessTokensResponse.cs" company="APIMatic">
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
    /// ApiV2AccessTokensResponse.
    /// </summary>
    public class ApiV2AccessTokensResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiV2AccessTokensResponse"/> class.
        /// </summary>
        public ApiV2AccessTokensResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiV2AccessTokensResponse"/> class.
        /// </summary>
        /// <param name="expiresAt">expiresAt.</param>
        /// <param name="token">token.</param>
        public ApiV2AccessTokensResponse(
            string expiresAt = null,
            string token = null)
        {
            this.ExpiresAt = expiresAt;
            this.Token = token;
        }

        /// <summary>
        /// datetime in the format of "yyyy-MM-ddTHH:mm:ss.SSSZ"
        /// </summary>
        [JsonProperty("expiresAt", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiresAt { get; set; }

        /// <summary>
        /// Gets or sets Token.
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ApiV2AccessTokensResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is ApiV2AccessTokensResponse other &&
                ((this.ExpiresAt == null && other.ExpiresAt == null) || (this.ExpiresAt?.Equals(other.ExpiresAt) == true)) &&
                ((this.Token == null && other.Token == null) || (this.Token?.Equals(other.Token) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1275543733;

            if (this.ExpiresAt != null)
            {
               hashCode += this.ExpiresAt.GetHashCode();
            }

            if (this.Token != null)
            {
               hashCode += this.Token.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ExpiresAt = {(this.ExpiresAt == null ? "null" : this.ExpiresAt == string.Empty ? "" : this.ExpiresAt)}");
            toStringOutput.Add($"this.Token = {(this.Token == null ? "null" : this.Token == string.Empty ? "" : this.Token)}");
        }
    }
}