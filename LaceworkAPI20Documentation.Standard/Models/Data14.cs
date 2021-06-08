// <copyright file="Data14.cs" company="APIMatic">
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
    /// Data14.
    /// </summary>
    public class Data14
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data14"/> class.
        /// </summary>
        public Data14()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data14"/> class.
        /// </summary>
        /// <param name="webhookUrl">webhookUrl.</param>
        public Data14(
            string webhookUrl)
        {
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Gets or sets WebhookUrl.
        /// </summary>
        [JsonProperty("webhookUrl")]
        public string WebhookUrl { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data14 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data14 other &&
                ((this.WebhookUrl == null && other.WebhookUrl == null) || (this.WebhookUrl?.Equals(other.WebhookUrl) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1154550300;

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