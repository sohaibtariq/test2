// <copyright file="GcpCfg2.cs" company="APIMatic">
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
    /// GcpCfg2.
    /// </summary>
    public class GcpCfg2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GcpCfg2"/> class.
        /// </summary>
        public GcpCfg2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GcpCfg2"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="data">data.</param>
        public GcpCfg2(
            string name = null,
            double? enabled = null,
            Models.Data68 data = null)
        {
            this.Name = name;
            this.Enabled = enabled;
            this.Data = data;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Enabled.
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public double? Enabled { get; set; }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Data68 Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GcpCfg2 : ({string.Join(", ", toStringOutput)})";
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

            return obj is GcpCfg2 other &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Enabled == null && other.Enabled == null) || (this.Enabled?.Equals(other.Enabled) == true)) &&
                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 121353869;

            if (this.Name != null)
            {
               hashCode += this.Name.GetHashCode();
            }

            if (this.Enabled != null)
            {
               hashCode += this.Enabled.GetHashCode();
            }

            if (this.Data != null)
            {
               hashCode += this.Data.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.Enabled = {(this.Enabled == null ? "null" : this.Enabled.ToString())}");
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : this.Data.ToString())}");
        }
    }
}