// <copyright file="AWSECRAWSIAMRole.cs" company="APIMatic">
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
    /// AWSECRAWSIAMRole.
    /// </summary>
    public class AWSECRAWSIAMRole
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AWSECRAWSIAMRole"/> class.
        /// </summary>
        public AWSECRAWSIAMRole()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AWSECRAWSIAMRole"/> class.
        /// </summary>
        /// <param name="crossAccountCredentials">crossAccountCredentials.</param>
        /// <param name="awsAuthType">awsAuthType.</param>
        /// <param name="registryType">registryType.</param>
        /// <param name="registryDomain">registryDomain.</param>
        /// <param name="limitNumImg">limitNumImg.</param>
        /// <param name="limitByRep">limitByRep.</param>
        /// <param name="limitByTag">limitByTag.</param>
        /// <param name="limitByLabel">limitByLabel.</param>
        public AWSECRAWSIAMRole(
            Models.CrossAccountCredentials crossAccountCredentials,
            string awsAuthType,
            string registryType,
            string registryDomain,
            Models.LimitNumberOfImagesPerRepoEnum? limitNumImg = Models.LimitNumberOfImagesPerRepoEnum.Enum5,
            List<string> limitByRep = null,
            List<string> limitByTag = null,
            List<Models.LimitByLabelSOptional> limitByLabel = null)
        {
            this.CrossAccountCredentials = crossAccountCredentials;
            this.AwsAuthType = awsAuthType;
            this.RegistryType = registryType;
            this.RegistryDomain = registryDomain;
            this.LimitNumImg = limitNumImg;
            this.LimitByRep = limitByRep;
            this.LimitByTag = limitByTag;
            this.LimitByLabel = limitByLabel;
        }

        /// <summary>
        /// Gets or sets CrossAccountCredentials.
        /// </summary>
        [JsonProperty("crossAccountCredentials")]
        public Models.CrossAccountCredentials CrossAccountCredentials { get; set; }

        /// <summary>
        /// Gets or sets AwsAuthType.
        /// </summary>
        [JsonProperty("awsAuthType")]
        public string AwsAuthType { get; set; }

        /// <summary>
        /// Gets or sets RegistryType.
        /// </summary>
        [JsonProperty("registryType")]
        public string RegistryType { get; set; }

        /// <summary>
        /// Gets or sets RegistryDomain.
        /// </summary>
        [JsonProperty("registryDomain")]
        public string RegistryDomain { get; set; }

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

            return $"AWSECRAWSIAMRole : ({string.Join(", ", toStringOutput)})";
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

            return obj is AWSECRAWSIAMRole other &&
                ((this.CrossAccountCredentials == null && other.CrossAccountCredentials == null) || (this.CrossAccountCredentials?.Equals(other.CrossAccountCredentials) == true)) &&
                ((this.AwsAuthType == null && other.AwsAuthType == null) || (this.AwsAuthType?.Equals(other.AwsAuthType) == true)) &&
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
            int hashCode = 1587596106;

            if (this.CrossAccountCredentials != null)
            {
               hashCode += this.CrossAccountCredentials.GetHashCode();
            }

            if (this.AwsAuthType != null)
            {
               hashCode += this.AwsAuthType.GetHashCode();
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
            toStringOutput.Add($"this.CrossAccountCredentials = {(this.CrossAccountCredentials == null ? "null" : this.CrossAccountCredentials.ToString())}");
            toStringOutput.Add($"this.AwsAuthType = {(this.AwsAuthType == null ? "null" : this.AwsAuthType == string.Empty ? "" : this.AwsAuthType)}");
            toStringOutput.Add($"this.RegistryType = {(this.RegistryType == null ? "null" : this.RegistryType == string.Empty ? "" : this.RegistryType)}");
            toStringOutput.Add($"this.RegistryDomain = {(this.RegistryDomain == null ? "null" : this.RegistryDomain == string.Empty ? "" : this.RegistryDomain)}");
            toStringOutput.Add($"this.LimitNumImg = {(this.LimitNumImg == null ? "null" : this.LimitNumImg.ToString())}");
            toStringOutput.Add($"this.LimitByRep = {(this.LimitByRep == null ? "null" : $"[{string.Join(", ", this.LimitByRep)} ]")}");
            toStringOutput.Add($"this.LimitByTag = {(this.LimitByTag == null ? "null" : $"[{string.Join(", ", this.LimitByTag)} ]")}");
            toStringOutput.Add($"this.LimitByLabel = {(this.LimitByLabel == null ? "null" : $"[{string.Join(", ", this.LimitByLabel)} ]")}");
        }
    }
}