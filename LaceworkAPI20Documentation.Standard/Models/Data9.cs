// <copyright file="Data9.cs" company="APIMatic">
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
    /// Data9.
    /// </summary>
    public class Data9
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data9"/> class.
        /// </summary>
        public Data9()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data9"/> class.
        /// </summary>
        /// <param name="apiIntgKey">apiIntgKey.</param>
        public Data9(
            string apiIntgKey)
        {
            this.ApiIntgKey = apiIntgKey;
        }

        /// <summary>
        /// Gets or sets ApiIntgKey.
        /// </summary>
        [JsonProperty("apiIntgKey")]
        public string ApiIntgKey { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data9 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data9 other &&
                ((this.ApiIntgKey == null && other.ApiIntgKey == null) || (this.ApiIntgKey?.Equals(other.ApiIntgKey) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 299519571;

            if (this.ApiIntgKey != null)
            {
               hashCode += this.ApiIntgKey.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ApiIntgKey = {(this.ApiIntgKey == null ? "null" : this.ApiIntgKey == string.Empty ? "" : this.ApiIntgKey)}");
        }
    }
}