// <copyright file="Data67.cs" company="APIMatic">
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
    /// Data67.
    /// </summary>
    public class Data67
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data67"/> class.
        /// </summary>
        public Data67()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data67"/> class.
        /// </summary>
        /// <param name="credentials">credentials.</param>
        /// <param name="idType">idType.</param>
        /// <param name="id">id.</param>
        /// <param name="subscriptionName">subscriptionName.</param>
        public Data67(
            Models.Credentials2 credentials = null,
            Models.IntegrationLevelEnum? idType = null,
            string id = null,
            string subscriptionName = null)
        {
            this.Credentials = credentials;
            this.IdType = idType;
            this.Id = id;
            this.SubscriptionName = subscriptionName;
        }

        /// <summary>
        /// Gets or sets Credentials.
        /// </summary>
        [JsonProperty("credentials", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Credentials2 Credentials { get; set; }

        /// <summary>
        /// Gets or sets IdType.
        /// </summary>
        [JsonProperty("idType", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.IntegrationLevelEnum? IdType { get; set; }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets SubscriptionName.
        /// </summary>
        [JsonProperty("subscriptionName", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscriptionName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data67 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data67 other &&
                ((this.Credentials == null && other.Credentials == null) || (this.Credentials?.Equals(other.Credentials) == true)) &&
                ((this.IdType == null && other.IdType == null) || (this.IdType?.Equals(other.IdType) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.SubscriptionName == null && other.SubscriptionName == null) || (this.SubscriptionName?.Equals(other.SubscriptionName) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -921527701;

            if (this.Credentials != null)
            {
               hashCode += this.Credentials.GetHashCode();
            }

            if (this.IdType != null)
            {
               hashCode += this.IdType.GetHashCode();
            }

            if (this.Id != null)
            {
               hashCode += this.Id.GetHashCode();
            }

            if (this.SubscriptionName != null)
            {
               hashCode += this.SubscriptionName.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Credentials = {(this.Credentials == null ? "null" : this.Credentials.ToString())}");
            toStringOutput.Add($"this.IdType = {(this.IdType == null ? "null" : this.IdType.ToString())}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.SubscriptionName = {(this.SubscriptionName == null ? "null" : this.SubscriptionName == string.Empty ? "" : this.SubscriptionName)}");
        }
    }
}