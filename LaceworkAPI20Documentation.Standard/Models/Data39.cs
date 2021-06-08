// <copyright file="Data39.cs" company="APIMatic">
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
    /// Data39.
    /// </summary>
    public class Data39
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data39"/> class.
        /// </summary>
        public Data39()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data39"/> class.
        /// </summary>
        /// <param name="apiIntgKey">apiIntgKey.</param>
        public Data39(
            string apiIntgKey = null)
        {
            this.ApiIntgKey = apiIntgKey;
        }

        /// <summary>
        /// Gets or sets ApiIntgKey.
        /// </summary>
        [JsonProperty("apiIntgKey", NullValueHandling = NullValueHandling.Ignore)]
        public string ApiIntgKey { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data39 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data39 other &&
                ((this.ApiIntgKey == null && other.ApiIntgKey == null) || (this.ApiIntgKey?.Equals(other.ApiIntgKey) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -1540520312;

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