// <copyright file="GCPResourceGroup1.cs" company="APIMatic">
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
    /// GCPResourceGroup1.
    /// </summary>
    public class GCPResourceGroup1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GCPResourceGroup1"/> class.
        /// </summary>
        public GCPResourceGroup1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GCPResourceGroup1"/> class.
        /// </summary>
        /// <param name="resourceName">resourceName.</param>
        /// <param name="resourceType">resourceType.</param>
        /// <param name="props">props.</param>
        /// <param name="enabled">enabled.</param>
        public GCPResourceGroup1(
            string resourceName,
            string resourceType,
            Models.Props8 props,
            Models.EnabledEnum? enabled = null)
        {
            this.ResourceName = resourceName;
            this.ResourceType = resourceType;
            this.Enabled = enabled;
            this.Props = props;
        }

        /// <summary>
        /// Gets or sets ResourceName.
        /// </summary>
        [JsonProperty("resourceName")]
        public string ResourceName { get; set; }

        /// <summary>
        /// Gets or sets ResourceType.
        /// </summary>
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        /// <summary>
        /// Gets or sets Enabled.
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public Models.EnabledEnum? Enabled { get; set; }

        /// <summary>
        /// Gets or sets Props.
        /// </summary>
        [JsonProperty("props")]
        public Models.Props8 Props { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GCPResourceGroup1 : ({string.Join(", ", toStringOutput)})";
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

            return obj is GCPResourceGroup1 other &&
                ((this.ResourceName == null && other.ResourceName == null) || (this.ResourceName?.Equals(other.ResourceName) == true)) &&
                ((this.ResourceType == null && other.ResourceType == null) || (this.ResourceType?.Equals(other.ResourceType) == true)) &&
                ((this.Enabled == null && other.Enabled == null) || (this.Enabled?.Equals(other.Enabled) == true)) &&
                ((this.Props == null && other.Props == null) || (this.Props?.Equals(other.Props) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1540075415;

            if (this.ResourceName != null)
            {
               hashCode += this.ResourceName.GetHashCode();
            }

            if (this.ResourceType != null)
            {
               hashCode += this.ResourceType.GetHashCode();
            }

            if (this.Enabled != null)
            {
               hashCode += this.Enabled.GetHashCode();
            }

            if (this.Props != null)
            {
               hashCode += this.Props.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ResourceName = {(this.ResourceName == null ? "null" : this.ResourceName == string.Empty ? "" : this.ResourceName)}");
            toStringOutput.Add($"this.ResourceType = {(this.ResourceType == null ? "null" : this.ResourceType == string.Empty ? "" : this.ResourceType)}");
            toStringOutput.Add($"this.Enabled = {(this.Enabled == null ? "null" : this.Enabled.ToString())}");
            toStringOutput.Add($"this.Props = {(this.Props == null ? "null" : this.Props.ToString())}");
        }
    }
}