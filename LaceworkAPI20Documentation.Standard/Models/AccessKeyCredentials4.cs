// <copyright file="AccessKeyCredentials4.cs" company="APIMatic">
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
    /// AccessKeyCredentials4.
    /// </summary>
    public class AccessKeyCredentials4
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessKeyCredentials4"/> class.
        /// </summary>
        public AccessKeyCredentials4()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessKeyCredentials4"/> class.
        /// </summary>
        /// <param name="accountId">accountId.</param>
        /// <param name="accessKeyId">accessKeyId.</param>
        /// <param name="secretAccessKey">secretAccessKey.</param>
        public AccessKeyCredentials4(
            string accountId = null,
            string accessKeyId = null,
            string secretAccessKey = null)
        {
            this.AccountId = accountId;
            this.AccessKeyId = accessKeyId;
            this.SecretAccessKey = secretAccessKey;
        }

        /// <summary>
        /// Gets or sets AccountId.
        /// </summary>
        [JsonProperty("accountId", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountId { get; set; }

        /// <summary>
        /// Gets or sets AccessKeyId.
        /// </summary>
        [JsonProperty("accessKeyId", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// Gets or sets SecretAccessKey.
        /// </summary>
        [JsonProperty("secretAccessKey", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretAccessKey { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AccessKeyCredentials4 : ({string.Join(", ", toStringOutput)})";
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

            return obj is AccessKeyCredentials4 other &&
                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.AccessKeyId == null && other.AccessKeyId == null) || (this.AccessKeyId?.Equals(other.AccessKeyId) == true)) &&
                ((this.SecretAccessKey == null && other.SecretAccessKey == null) || (this.SecretAccessKey?.Equals(other.SecretAccessKey) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1326004053;

            if (this.AccountId != null)
            {
               hashCode += this.AccountId.GetHashCode();
            }

            if (this.AccessKeyId != null)
            {
               hashCode += this.AccessKeyId.GetHashCode();
            }

            if (this.SecretAccessKey != null)
            {
               hashCode += this.SecretAccessKey.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId == string.Empty ? "" : this.AccountId)}");
            toStringOutput.Add($"this.AccessKeyId = {(this.AccessKeyId == null ? "null" : this.AccessKeyId == string.Empty ? "" : this.AccessKeyId)}");
            toStringOutput.Add($"this.SecretAccessKey = {(this.SecretAccessKey == null ? "null" : this.SecretAccessKey == string.Empty ? "" : this.SecretAccessKey)}");
        }
    }
}