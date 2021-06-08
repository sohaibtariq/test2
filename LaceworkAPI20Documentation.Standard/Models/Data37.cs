// <copyright file="Data37.cs" company="APIMatic">
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
    /// Data37.
    /// </summary>
    public class Data37
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data37"/> class.
        /// </summary>
        public Data37()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data37"/> class.
        /// </summary>
        /// <param name="teamsUrl">teamsUrl.</param>
        public Data37(
            string teamsUrl = null)
        {
            this.TeamsUrl = teamsUrl;
        }

        /// <summary>
        /// Gets or sets TeamsUrl.
        /// </summary>
        [JsonProperty("teamsUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string TeamsUrl { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data37 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data37 other &&
                ((this.TeamsUrl == null && other.TeamsUrl == null) || (this.TeamsUrl?.Equals(other.TeamsUrl) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1790324596;

            if (this.TeamsUrl != null)
            {
               hashCode += this.TeamsUrl.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TeamsUrl = {(this.TeamsUrl == null ? "null" : this.TeamsUrl == string.Empty ? "" : this.TeamsUrl)}");
        }
    }
}