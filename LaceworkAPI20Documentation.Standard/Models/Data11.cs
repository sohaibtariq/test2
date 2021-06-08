// <copyright file="Data11.cs" company="APIMatic">
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
    /// Data11.
    /// </summary>
    public class Data11
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data11"/> class.
        /// </summary>
        public Data11()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data11"/> class.
        /// </summary>
        /// <param name="slackUrl">slackUrl.</param>
        public Data11(
            string slackUrl)
        {
            this.SlackUrl = slackUrl;
        }

        /// <summary>
        /// Gets or sets SlackUrl.
        /// </summary>
        [JsonProperty("slackUrl")]
        public string SlackUrl { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data11 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data11 other &&
                ((this.SlackUrl == null && other.SlackUrl == null) || (this.SlackUrl?.Equals(other.SlackUrl) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 352328964;

            if (this.SlackUrl != null)
            {
               hashCode += this.SlackUrl.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SlackUrl = {(this.SlackUrl == null ? "null" : this.SlackUrl == string.Empty ? "" : this.SlackUrl)}");
        }
    }
}