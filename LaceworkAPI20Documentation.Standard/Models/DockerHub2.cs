// <copyright file="DockerHub2.cs" company="APIMatic">
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
    /// DockerHub2.
    /// </summary>
    public class DockerHub2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DockerHub2"/> class.
        /// </summary>
        public DockerHub2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DockerHub2"/> class.
        /// </summary>
        /// <param name="credentials">credentials.</param>
        /// <param name="registryType">registryType.</param>
        /// <param name="registryDomain">registryDomain.</param>
        /// <param name="limitNumImg">limitNumImg.</param>
        /// <param name="limitByRep">limitByRep.</param>
        /// <param name="limitByTag">limitByTag.</param>
        /// <param name="limitByLabel">limitByLabel.</param>
        public DockerHub2(
            Models.Credentials23 credentials = null,
            Models.RegistryType2Enum? registryType = null,
            Models.RegistryDomain2Enum? registryDomain = Models.RegistryDomain2Enum.EnumIndexdockerio,
            Models.LimitNumberOfImagesPerRepoEnum? limitNumImg = Models.LimitNumberOfImagesPerRepoEnum.Enum5,
            List<string> limitByRep = null,
            List<string> limitByTag = null,
            List<Models.LimitByLabelSOptional> limitByLabel = null)
        {
            this.Credentials = credentials;
            this.RegistryType = registryType;
            this.RegistryDomain = registryDomain;
            this.LimitNumImg = limitNumImg;
            this.LimitByRep = limitByRep;
            this.LimitByTag = limitByTag;
            this.LimitByLabel = limitByLabel;
        }

        /// <summary>
        /// Gets or sets Credentials.
        /// </summary>
        [JsonProperty("credentials", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Credentials23 Credentials { get; set; }

        /// <summary>
        /// Gets or sets RegistryType.
        /// </summary>
        [JsonProperty("registryType", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.RegistryType2Enum? RegistryType { get; set; }

        /// <summary>
        /// Gets or sets RegistryDomain.
        /// </summary>
        [JsonProperty("registryDomain", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.RegistryDomain2Enum? RegistryDomain { get; set; }

        /// <summary>
        /// Gets or sets LimitNumImg.
        /// </summary>
        [JsonProperty("limitNumImg", NullValueHandling = NullValueHandling.Ignore)]
        public Models.LimitNumberOfImagesPerRepoEnum? LimitNumImg { get; set; }

        /// <summary>
        /// Gets or sets LimitByRep.
        /// </summary>
        [JsonProperty("limitByRep", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LimitByRep { get; set; }

        /// <summary>
        /// Gets or sets LimitByTag.
        /// </summary>
        [JsonProperty("limitByTag", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LimitByTag { get; set; }

        /// <summary>
        /// Gets or sets LimitByLabel.
        /// </summary>
        [JsonProperty("limitByLabel", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.LimitByLabelSOptional> LimitByLabel { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DockerHub2 : ({string.Join(", ", toStringOutput)})";
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

            return obj is DockerHub2 other &&
                ((this.Credentials == null && other.Credentials == null) || (this.Credentials?.Equals(other.Credentials) == true)) &&
                ((this.RegistryType == null && other.RegistryType == null) || (this.RegistryType?.Equals(other.RegistryType) == true)) &&
                ((this.RegistryDomain == null && other.RegistryDomain == null) || (this.RegistryDomain?.Equals(other.RegistryDomain) == true)) &&
                ((this.LimitNumImg == null && other.LimitNumImg == null) || (this.LimitNumImg?.Equals(other.LimitNumImg) == true)) &&
                ((this.LimitByRep == null && other.LimitByRep == null) || (this.LimitByRep?.Equals(other.LimitByRep) == true)) &&
                ((this.LimitByTag == null && other.LimitByTag == null) || (this.LimitByTag?.Equals(other.LimitByTag) == true)) &&
                ((this.LimitByLabel == null && other.LimitByLabel == null) || (this.LimitByLabel?.Equals(other.LimitByLabel) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1888318428;

            if (this.Credentials != null)
            {
               hashCode += this.Credentials.GetHashCode();
            }

            if (this.RegistryType != null)
            {
               hashCode += this.RegistryType.GetHashCode();
            }

            if (this.RegistryDomain != null)
            {
               hashCode += this.RegistryDomain.GetHashCode();
            }

            if (this.LimitNumImg != null)
            {
               hashCode += this.LimitNumImg.GetHashCode();
            }

            if (this.LimitByRep != null)
            {
               hashCode += this.LimitByRep.GetHashCode();
            }

            if (this.LimitByTag != null)
            {
               hashCode += this.LimitByTag.GetHashCode();
            }

            if (this.LimitByLabel != null)
            {
               hashCode += this.LimitByLabel.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Credentials = {(this.Credentials == null ? "null" : this.Credentials.ToString())}");
            toStringOutput.Add($"this.RegistryType = {(this.RegistryType == null ? "null" : this.RegistryType.ToString())}");
            toStringOutput.Add($"this.RegistryDomain = {(this.RegistryDomain == null ? "null" : this.RegistryDomain.ToString())}");
            toStringOutput.Add($"this.LimitNumImg = {(this.LimitNumImg == null ? "null" : this.LimitNumImg.ToString())}");
            toStringOutput.Add($"this.LimitByRep = {(this.LimitByRep == null ? "null" : $"[{string.Join(", ", this.LimitByRep)} ]")}");
            toStringOutput.Add($"this.LimitByTag = {(this.LimitByTag == null ? "null" : $"[{string.Join(", ", this.LimitByTag)} ]")}");
            toStringOutput.Add($"this.LimitByLabel = {(this.LimitByLabel == null ? "null" : $"[{string.Join(", ", this.LimitByLabel)} ]")}");
        }
    }
}