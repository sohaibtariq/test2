// <copyright file="Data43.cs" company="APIMatic">
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
    /// Data43.
    /// </summary>
    public class Data43
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data43"/> class.
        /// </summary>
        public Data43()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data43"/> class.
        /// </summary>
        /// <param name="intgUrl">intgUrl.</param>
        public Data43(
            string intgUrl = null)
        {
            this.IntgUrl = intgUrl;
        }

        /// <summary>
        /// Gets or sets IntgUrl.
        /// </summary>
        [JsonProperty("intgUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string IntgUrl { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data43 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data43 other &&
                ((this.IntgUrl == null && other.IntgUrl == null) || (this.IntgUrl?.Equals(other.IntgUrl) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 200644533;

            if (this.IntgUrl != null)
            {
               hashCode += this.IntgUrl.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.IntgUrl = {(this.IntgUrl == null ? "null" : this.IntgUrl == string.Empty ? "" : this.IntgUrl)}");
        }
    }
}