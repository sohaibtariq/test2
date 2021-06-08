// <copyright file="Data51.cs" company="APIMatic">
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
    /// Data51.
    /// </summary>
    public class Data51
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data51"/> class.
        /// </summary>
        public Data51()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data51"/> class.
        /// </summary>
        /// <param name="credentials">credentials.</param>
        /// <param name="idType">idType.</param>
        /// <param name="id">id.</param>
        /// <param name="subscriptionName">subscriptionName.</param>
        public Data51(
            Models.Credentials5 credentials,
            Models.IntegrationLevelEnum idType,
            string id,
            string subscriptionName)
        {
            this.Credentials = credentials;
            this.IdType = idType;
            this.Id = id;
            this.SubscriptionName = subscriptionName;
        }

        /// <summary>
        /// Gets or sets Credentials.
        /// </summary>
        [JsonProperty("credentials")]
        public Models.Credentials5 Credentials { get; set; }

        /// <summary>
        /// Gets or sets IdType.
        /// </summary>
        [JsonProperty("idType", ItemConverterType = typeof(StringEnumConverter))]
        public Models.IntegrationLevelEnum IdType { get; set; }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets SubscriptionName.
        /// </summary>
        [JsonProperty("subscriptionName")]
        public string SubscriptionName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data51 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data51 other &&
                ((this.Credentials == null && other.Credentials == null) || (this.Credentials?.Equals(other.Credentials) == true)) &&
                this.IdType.Equals(other.IdType) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.SubscriptionName == null && other.SubscriptionName == null) || (this.SubscriptionName?.Equals(other.SubscriptionName) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -1057246466;

            if (this.Credentials != null)
            {
               hashCode += this.Credentials.GetHashCode();
            }

            hashCode += this.IdType.GetHashCode();

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
            toStringOutput.Add($"this.IdType = {this.IdType}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.SubscriptionName = {(this.SubscriptionName == null ? "null" : this.SubscriptionName == string.Empty ? "" : this.SubscriptionName)}");
        }
    }
}