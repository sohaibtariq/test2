// <copyright file="Data44.cs" company="APIMatic">
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
    /// Data44.
    /// </summary>
    public class Data44
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data44"/> class.
        /// </summary>
        public Data44()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data44"/> class.
        /// </summary>
        /// <param name="webhookUrl">webhookUrl.</param>
        public Data44(
            string webhookUrl = null)
        {
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Gets or sets WebhookUrl.
        /// </summary>
        [JsonProperty("webhookUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string WebhookUrl { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data44 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data44 other &&
                ((this.WebhookUrl == null && other.WebhookUrl == null) || (this.WebhookUrl?.Equals(other.WebhookUrl) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 2074310071;

            if (this.WebhookUrl != null)
            {
               hashCode += this.WebhookUrl.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.WebhookUrl = {(this.WebhookUrl == null ? "null" : this.WebhookUrl == string.Empty ? "" : this.WebhookUrl)}");
        }
    }
}