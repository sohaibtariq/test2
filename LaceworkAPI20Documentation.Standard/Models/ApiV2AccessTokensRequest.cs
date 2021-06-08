// <copyright file="ApiV2AccessTokensRequest.cs" company="APIMatic">
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
    /// ApiV2AccessTokensRequest.
    /// </summary>
    public class ApiV2AccessTokensRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiV2AccessTokensRequest"/> class.
        /// </summary>
        public ApiV2AccessTokensRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiV2AccessTokensRequest"/> class.
        /// </summary>
        /// <param name="keyId">keyId.</param>
        /// <param name="expiryTime">expiryTime.</param>
        public ApiV2AccessTokensRequest(
            string keyId,
            int expiryTime)
        {
            this.KeyId = keyId;
            this.ExpiryTime = expiryTime;
        }

        /// <summary>
        /// Gets or sets KeyId.
        /// </summary>
        [JsonProperty("keyId")]
        public string KeyId { get; set; }

        /// <summary>
        /// Number of seconds, maximum value: 86400 or 24 hours.
        /// </summary>
        [JsonProperty("expiryTime")]
        public int ExpiryTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ApiV2AccessTokensRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is ApiV2AccessTokensRequest other &&
                ((this.KeyId == null && other.KeyId == null) || (this.KeyId?.Equals(other.KeyId) == true)) &&
                this.ExpiryTime.Equals(other.ExpiryTime);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -1905450917;

            if (this.KeyId != null)
            {
               hashCode += this.KeyId.GetHashCode();
            }

            hashCode += this.ExpiryTime.GetHashCode();

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.KeyId = {(this.KeyId == null ? "null" : this.KeyId == string.Empty ? "" : this.KeyId)}");
            toStringOutput.Add($"this.ExpiryTime = {this.ExpiryTime}");
        }
    }
}