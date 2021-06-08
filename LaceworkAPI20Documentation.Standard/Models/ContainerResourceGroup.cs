// <copyright file="ContainerResourceGroup.cs" company="APIMatic">
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
    /// ContainerResourceGroup.
    /// </summary>
    public class ContainerResourceGroup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerResourceGroup"/> class.
        /// </summary>
        public ContainerResourceGroup()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerResourceGroup"/> class.
        /// </summary>
        /// <param name="resourceName">resourceName.</param>
        /// <param name="resourceType">resourceType.</param>
        /// <param name="props">props.</param>
        /// <param name="resourceGuid">resourceGuid.</param>
        /// <param name="guid">guid.</param>
        /// <param name="guidType">guidType.</param>
        /// <param name="isDefault">isDefault.</param>
        /// <param name="enabled">enabled.</param>
        public ContainerResourceGroup(
            string resourceName,
            string resourceType,
            Models.Props4 props,
            string resourceGuid = null,
            string guid = null,
            string guidType = null,
            double? isDefault = null,
            Models.EnabledEnum? enabled = null)
        {
            this.ResourceGuid = resourceGuid;
            this.Guid = guid;
            this.GuidType = guidType;
            this.IsDefault = isDefault;
            this.ResourceName = resourceName;
            this.ResourceType = resourceType;
            this.Enabled = enabled;
            this.Props = props;
        }

        /// <summary>
        /// Gets or sets ResourceGuid.
        /// </summary>
        [JsonProperty("resourceGuid", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceGuid { get; set; }

        /// <summary>
        /// Gets or sets Guid.
        /// </summary>
        [JsonProperty("guid", NullValueHandling = NullValueHandling.Ignore)]
        public string Guid { get; set; }

        /// <summary>
        /// Gets or sets GuidType.
        /// </summary>
        [JsonProperty("guidType", NullValueHandling = NullValueHandling.Ignore)]
        public string GuidType { get; set; }

        /// <summary>
        /// Gets or sets IsDefault.
        /// </summary>
        [JsonProperty("isDefault", NullValueHandling = NullValueHandling.Ignore)]
        public double? IsDefault { get; set; }

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
        public Models.Props4 Props { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ContainerResourceGroup : ({string.Join(", ", toStringOutput)})";
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

            return obj is ContainerResourceGroup other &&
                ((this.ResourceGuid == null && other.ResourceGuid == null) || (this.ResourceGuid?.Equals(other.ResourceGuid) == true)) &&
                ((this.Guid == null && other.Guid == null) || (this.Guid?.Equals(other.Guid) == true)) &&
                ((this.GuidType == null && other.GuidType == null) || (this.GuidType?.Equals(other.GuidType) == true)) &&
                ((this.IsDefault == null && other.IsDefault == null) || (this.IsDefault?.Equals(other.IsDefault) == true)) &&
                ((this.ResourceName == null && other.ResourceName == null) || (this.ResourceName?.Equals(other.ResourceName) == true)) &&
                ((this.ResourceType == null && other.ResourceType == null) || (this.ResourceType?.Equals(other.ResourceType) == true)) &&
                ((this.Enabled == null && other.Enabled == null) || (this.Enabled?.Equals(other.Enabled) == true)) &&
                ((this.Props == null && other.Props == null) || (this.Props?.Equals(other.Props) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -1414654440;

            if (this.ResourceGuid != null)
            {
               hashCode += this.ResourceGuid.GetHashCode();
            }

            if (this.Guid != null)
            {
               hashCode += this.Guid.GetHashCode();
            }

            if (this.GuidType != null)
            {
               hashCode += this.GuidType.GetHashCode();
            }

            if (this.IsDefault != null)
            {
               hashCode += this.IsDefault.GetHashCode();
            }

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
            toStringOutput.Add($"this.ResourceGuid = {(this.ResourceGuid == null ? "null" : this.ResourceGuid == string.Empty ? "" : this.ResourceGuid)}");
            toStringOutput.Add($"this.Guid = {(this.Guid == null ? "null" : this.Guid == string.Empty ? "" : this.Guid)}");
            toStringOutput.Add($"this.GuidType = {(this.GuidType == null ? "null" : this.GuidType == string.Empty ? "" : this.GuidType)}");
            toStringOutput.Add($"this.IsDefault = {(this.IsDefault == null ? "null" : this.IsDefault.ToString())}");
            toStringOutput.Add($"this.ResourceName = {(this.ResourceName == null ? "null" : this.ResourceName == string.Empty ? "" : this.ResourceName)}");
            toStringOutput.Add($"this.ResourceType = {(this.ResourceType == null ? "null" : this.ResourceType == string.Empty ? "" : this.ResourceType)}");
            toStringOutput.Add($"this.Enabled = {(this.Enabled == null ? "null" : this.Enabled.ToString())}");
            toStringOutput.Add($"this.Props = {(this.Props == null ? "null" : this.Props.ToString())}");
        }
    }
}