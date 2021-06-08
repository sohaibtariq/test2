// <copyright file="InlineScanner2.cs" company="APIMatic">
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
    /// InlineScanner2.
    /// </summary>
    public class InlineScanner2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineScanner2"/> class.
        /// </summary>
        public InlineScanner2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineScanner2"/> class.
        /// </summary>
        /// <param name="registryType">registryType.</param>
        /// <param name="limitNumScan">limitNumScan.</param>
        /// <param name="identifierTag">identifierTag.</param>
        public InlineScanner2(
            Models.RegistryType5Enum? registryType = null,
            Models.LimitNumberOfScansForThisIntegrationEnum? limitNumScan = Models.LimitNumberOfScansForThisIntegrationEnum.Enum15,
            List<Models.IdentifierTagSForScan> identifierTag = null)
        {
            this.RegistryType = registryType;
            this.LimitNumScan = limitNumScan;
            this.IdentifierTag = identifierTag;
        }

        /// <summary>
        /// Gets or sets RegistryType.
        /// </summary>
        [JsonProperty("registryType", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.RegistryType5Enum? RegistryType { get; set; }

        /// <summary>
        /// Gets or sets LimitNumScan.
        /// </summary>
        [JsonProperty("limitNumScan", NullValueHandling = NullValueHandling.Ignore)]
        public Models.LimitNumberOfScansForThisIntegrationEnum? LimitNumScan { get; set; }

        /// <summary>
        /// Gets or sets IdentifierTag.
        /// </summary>
        [JsonProperty("identifierTag", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.IdentifierTagSForScan> IdentifierTag { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InlineScanner2 : ({string.Join(", ", toStringOutput)})";
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

            return obj is InlineScanner2 other &&
                ((this.RegistryType == null && other.RegistryType == null) || (this.RegistryType?.Equals(other.RegistryType) == true)) &&
                ((this.LimitNumScan == null && other.LimitNumScan == null) || (this.LimitNumScan?.Equals(other.LimitNumScan) == true)) &&
                ((this.IdentifierTag == null && other.IdentifierTag == null) || (this.IdentifierTag?.Equals(other.IdentifierTag) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 203957501;

            if (this.RegistryType != null)
            {
               hashCode += this.RegistryType.GetHashCode();
            }

            if (this.LimitNumScan != null)
            {
               hashCode += this.LimitNumScan.GetHashCode();
            }

            if (this.IdentifierTag != null)
            {
               hashCode += this.IdentifierTag.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RegistryType = {(this.RegistryType == null ? "null" : this.RegistryType.ToString())}");
            toStringOutput.Add($"this.LimitNumScan = {(this.LimitNumScan == null ? "null" : this.LimitNumScan.ToString())}");
            toStringOutput.Add($"this.IdentifierTag = {(this.IdentifierTag == null ? "null" : $"[{string.Join(", ", this.IdentifierTag)} ]")}");
        }
    }
}