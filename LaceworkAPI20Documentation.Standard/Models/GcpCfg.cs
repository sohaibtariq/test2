// <copyright file="GcpCfg.cs" company="APIMatic">
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
    /// GcpCfg.
    /// </summary>
    public class GcpCfg
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GcpCfg"/> class.
        /// </summary>
        public GcpCfg()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GcpCfg"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="type">type.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="data">data.</param>
        /// <param name="isOrg">isOrg.</param>
        /// <param name="props">props.</param>
        public GcpCfg(
            string name,
            string type,
            double enabled,
            Models.Data52 data,
            double? isOrg = 0,
            object props = null)
        {
            this.Name = name;
            this.Type = type;
            this.Enabled = enabled;
            this.IsOrg = isOrg;
            this.Props = props;
            this.Data = data;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets Enabled.
        /// </summary>
        [JsonProperty("enabled")]
        public double Enabled { get; set; }

        /// <summary>
        /// Gets or sets IsOrg.
        /// </summary>
        [JsonProperty("isOrg", NullValueHandling = NullValueHandling.Ignore)]
        public double? IsOrg { get; set; }

        /// <summary>
        /// Gets or sets Props.
        /// </summary>
        [JsonProperty("props", NullValueHandling = NullValueHandling.Ignore)]
        public object Props { get; set; }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("data")]
        public Models.Data52 Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GcpCfg : ({string.Join(", ", toStringOutput)})";
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

            return obj is GcpCfg other &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                this.Enabled.Equals(other.Enabled) &&
                ((this.IsOrg == null && other.IsOrg == null) || (this.IsOrg?.Equals(other.IsOrg) == true)) &&
                ((this.Props == null && other.Props == null) || (this.Props?.Equals(other.Props) == true)) &&
                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1552119189;

            if (this.Name != null)
            {
               hashCode += this.Name.GetHashCode();
            }

            if (this.Type != null)
            {
               hashCode += this.Type.GetHashCode();
            }

            hashCode += this.Enabled.GetHashCode();

            if (this.IsOrg != null)
            {
               hashCode += this.IsOrg.GetHashCode();
            }

            if (this.Props != null)
            {
               hashCode += this.Props.GetHashCode();
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
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.Enabled = {this.Enabled}");
            toStringOutput.Add($"this.IsOrg = {(this.IsOrg == null ? "null" : this.IsOrg.ToString())}");
            toStringOutput.Add($"Props = {(this.Props == null ? "null" : this.Props.ToString())}");
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : this.Data.ToString())}");
        }
    }
}