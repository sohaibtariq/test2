// <copyright file="DockerV2Registry2.cs" company="APIMatic">
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
    /// DockerV2Registry2.
    /// </summary>
    public class DockerV2Registry2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DockerV2Registry2"/> class.
        /// </summary>
        public DockerV2Registry2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DockerV2Registry2"/> class.
        /// </summary>
        /// <param name="credentials">credentials.</param>
        /// <param name="registryType">registryType.</param>
        /// <param name="registryDomain">registryDomain.</param>
        /// <param name="registryNotifications">registryNotifications.</param>
        public DockerV2Registry2(
            Models.Credentials25 credentials = null,
            Models.RegistryType4Enum? registryType = null,
            string registryDomain = null,
            bool? registryNotifications = null)
        {
            this.Credentials = credentials;
            this.RegistryType = registryType;
            this.RegistryDomain = registryDomain;
            this.RegistryNotifications = registryNotifications;
        }

        /// <summary>
        /// Gets or sets Credentials.
        /// </summary>
        [JsonProperty("credentials", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Credentials25 Credentials { get; set; }

        /// <summary>
        /// Gets or sets RegistryType.
        /// </summary>
        [JsonProperty("registryType", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.RegistryType4Enum? RegistryType { get; set; }

        /// <summary>
        /// Gets or sets RegistryDomain.
        /// </summary>
        [JsonProperty("registryDomain", NullValueHandling = NullValueHandling.Ignore)]
        public string RegistryDomain { get; set; }

        /// <summary>
        /// Gets or sets RegistryNotifications.
        /// </summary>
        [JsonProperty("registryNotifications", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RegistryNotifications { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DockerV2Registry2 : ({string.Join(", ", toStringOutput)})";
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

            return obj is DockerV2Registry2 other &&
                ((this.Credentials == null && other.Credentials == null) || (this.Credentials?.Equals(other.Credentials) == true)) &&
                ((this.RegistryType == null && other.RegistryType == null) || (this.RegistryType?.Equals(other.RegistryType) == true)) &&
                ((this.RegistryDomain == null && other.RegistryDomain == null) || (this.RegistryDomain?.Equals(other.RegistryDomain) == true)) &&
                ((this.RegistryNotifications == null && other.RegistryNotifications == null) || (this.RegistryNotifications?.Equals(other.RegistryNotifications) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -1932057434;

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

            if (this.RegistryNotifications != null)
            {
               hashCode += this.RegistryNotifications.GetHashCode();
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
            toStringOutput.Add($"this.RegistryDomain = {(this.RegistryDomain == null ? "null" : this.RegistryDomain == string.Empty ? "" : this.RegistryDomain)}");
            toStringOutput.Add($"this.RegistryNotifications = {(this.RegistryNotifications == null ? "null" : this.RegistryNotifications.ToString())}");
        }
    }
}