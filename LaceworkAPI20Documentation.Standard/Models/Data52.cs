// <copyright file="Data52.cs" company="APIMatic">
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
    /// Data52.
    /// </summary>
    public class Data52
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data52"/> class.
        /// </summary>
        public Data52()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data52"/> class.
        /// </summary>
        /// <param name="credentials">credentials.</param>
        /// <param name="idType">idType.</param>
        /// <param name="id">id.</param>
        public Data52(
            Models.Credentials credentials,
            Models.IntegrationLevelEnum idType,
            string id)
        {
            this.Credentials = credentials;
            this.IdType = idType;
            this.Id = id;
        }

        /// <summary>
        /// Gets or sets Credentials.
        /// </summary>
        [JsonProperty("credentials")]
        public Models.Credentials Credentials { get; set; }

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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data52 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data52 other &&
                ((this.Credentials == null && other.Credentials == null) || (this.Credentials?.Equals(other.Credentials) == true)) &&
                this.IdType.Equals(other.IdType) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -526765973;

            if (this.Credentials != null)
            {
               hashCode += this.Credentials.GetHashCode();
            }

            hashCode += this.IdType.GetHashCode();

            if (this.Id != null)
            {
               hashCode += this.Id.GetHashCode();
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
        }
    }
}