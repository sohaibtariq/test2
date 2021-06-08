// <copyright file="Data1.cs" company="APIMatic">
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
    /// Data1.
    /// </summary>
    public class Data1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data1"/> class.
        /// </summary>
        public Data1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data1"/> class.
        /// </summary>
        /// <param name="webhook">webhook.</param>
        public Data1(
            string webhook)
        {
            this.Webhook = webhook;
        }

        /// <summary>
        /// Gets or sets Webhook.
        /// </summary>
        [JsonProperty("webhook")]
        public string Webhook { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data1 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data1 other &&
                ((this.Webhook == null && other.Webhook == null) || (this.Webhook?.Equals(other.Webhook) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 858814735;

            if (this.Webhook != null)
            {
               hashCode += this.Webhook.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Webhook = {(this.Webhook == null ? "null" : this.Webhook == string.Empty ? "" : this.Webhook)}");
        }
    }
}