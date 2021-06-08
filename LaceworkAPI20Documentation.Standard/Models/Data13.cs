// <copyright file="Data13.cs" company="APIMatic">
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
    /// Data13.
    /// </summary>
    public class Data13
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data13"/> class.
        /// </summary>
        public Data13()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data13"/> class.
        /// </summary>
        /// <param name="intgUrl">intgUrl.</param>
        public Data13(
            string intgUrl)
        {
            this.IntgUrl = intgUrl;
        }

        /// <summary>
        /// Gets or sets IntgUrl.
        /// </summary>
        [JsonProperty("intgUrl")]
        public string IntgUrl { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data13 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data13 other &&
                ((this.IntgUrl == null && other.IntgUrl == null) || (this.IntgUrl?.Equals(other.IntgUrl) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 371494772;

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