// <copyright file="Data3.cs" company="APIMatic">
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
    /// Data3.
    /// </summary>
    public class Data3
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data3"/> class.
        /// </summary>
        public Data3()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data3"/> class.
        /// </summary>
        /// <param name="datadogType">datadogType.</param>
        /// <param name="datadogSite">datadogSite.</param>
        /// <param name="apiKey">apiKey.</param>
        public Data3(
            Models.DatadogServiceEnum datadogType,
            Models.DatadogSiteEnum datadogSite,
            string apiKey)
        {
            this.DatadogType = datadogType;
            this.DatadogSite = datadogSite;
            this.ApiKey = apiKey;
        }

        /// <summary>
        /// Gets or sets DatadogType.
        /// </summary>
        [JsonProperty("datadogType", ItemConverterType = typeof(StringEnumConverter))]
        public Models.DatadogServiceEnum DatadogType { get; set; }

        /// <summary>
        /// Gets or sets DatadogSite.
        /// </summary>
        [JsonProperty("datadogSite", ItemConverterType = typeof(StringEnumConverter))]
        public Models.DatadogSiteEnum DatadogSite { get; set; }

        /// <summary>
        /// Gets or sets ApiKey.
        /// </summary>
        [JsonProperty("apiKey")]
        public string ApiKey { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data3 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data3 other &&
                this.DatadogType.Equals(other.DatadogType) &&
                this.DatadogSite.Equals(other.DatadogSite) &&
                ((this.ApiKey == null && other.ApiKey == null) || (this.ApiKey?.Equals(other.ApiKey) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 243324962;
            hashCode += this.DatadogType.GetHashCode();
            hashCode += this.DatadogSite.GetHashCode();

            if (this.ApiKey != null)
            {
               hashCode += this.ApiKey.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DatadogType = {this.DatadogType}");
            toStringOutput.Add($"this.DatadogSite = {this.DatadogSite}");
            toStringOutput.Add($"this.ApiKey = {(this.ApiKey == null ? "null" : this.ApiKey == string.Empty ? "" : this.ApiKey)}");
        }
    }
}