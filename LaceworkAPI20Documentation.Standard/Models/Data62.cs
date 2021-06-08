// <copyright file="Data62.cs" company="APIMatic">
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
    /// Data62.
    /// </summary>
    public class Data62
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data62"/> class.
        /// </summary>
        public Data62()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data62"/> class.
        /// </summary>
        /// <param name="awsAccountId">awsAccountId.</param>
        /// <param name="crossAccountCredentials">crossAccountCredentials.</param>
        /// <param name="queueUrl">queueUrl.</param>
        /// <param name="accountMappingFile">accountMappingFile.</param>
        /// <param name="accountMapping">accountMapping.</param>
        public Data62(
            string awsAccountId = null,
            Models.CrossAccountCredentials4 crossAccountCredentials = null,
            string queueUrl = null,
            Stream accountMappingFile = null,
            object accountMapping = null)
        {
            this.AwsAccountId = awsAccountId;
            this.CrossAccountCredentials = crossAccountCredentials;
            this.QueueUrl = queueUrl;
            this.AccountMappingFile = accountMappingFile;
            this.AccountMapping = accountMapping;
        }

        /// <summary>
        /// Gets or sets AwsAccountId.
        /// </summary>
        [JsonProperty("awsAccountId", NullValueHandling = NullValueHandling.Ignore)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Gets or sets CrossAccountCredentials.
        /// </summary>
        [JsonProperty("crossAccountCredentials", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CrossAccountCredentials4 CrossAccountCredentials { get; set; }

        /// <summary>
        /// Gets or sets QueueUrl.
        /// </summary>
        [JsonProperty("queueUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string QueueUrl { get; set; }

        /// <summary>
        /// Gets or sets AccountMappingFile.
        /// </summary>
        [JsonProperty("accountMappingFile", NullValueHandling = NullValueHandling.Ignore)]
        public Stream AccountMappingFile { get; set; }

        /// <summary>
        /// Gets or sets AccountMapping.
        /// </summary>
        [JsonProperty("accountMapping", NullValueHandling = NullValueHandling.Ignore)]
        public object AccountMapping { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data62 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data62 other &&
                ((this.AwsAccountId == null && other.AwsAccountId == null) || (this.AwsAccountId?.Equals(other.AwsAccountId) == true)) &&
                ((this.CrossAccountCredentials == null && other.CrossAccountCredentials == null) || (this.CrossAccountCredentials?.Equals(other.CrossAccountCredentials) == true)) &&
                ((this.QueueUrl == null && other.QueueUrl == null) || (this.QueueUrl?.Equals(other.QueueUrl) == true)) &&
                ((this.AccountMappingFile == null && other.AccountMappingFile == null) || (this.AccountMappingFile?.Equals(other.AccountMappingFile) == true)) &&
                ((this.AccountMapping == null && other.AccountMapping == null) || (this.AccountMapping?.Equals(other.AccountMapping) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -413470982;

            if (this.AwsAccountId != null)
            {
               hashCode += this.AwsAccountId.GetHashCode();
            }

            if (this.CrossAccountCredentials != null)
            {
               hashCode += this.CrossAccountCredentials.GetHashCode();
            }

            if (this.QueueUrl != null)
            {
               hashCode += this.QueueUrl.GetHashCode();
            }

            if (this.AccountMappingFile != null)
            {
               hashCode += this.AccountMappingFile.GetHashCode();
            }

            if (this.AccountMapping != null)
            {
               hashCode += this.AccountMapping.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AwsAccountId = {(this.AwsAccountId == null ? "null" : this.AwsAccountId == string.Empty ? "" : this.AwsAccountId)}");
            toStringOutput.Add($"this.CrossAccountCredentials = {(this.CrossAccountCredentials == null ? "null" : this.CrossAccountCredentials.ToString())}");
            toStringOutput.Add($"this.QueueUrl = {(this.QueueUrl == null ? "null" : this.QueueUrl == string.Empty ? "" : this.QueueUrl)}");
            toStringOutput.Add($"this.AccountMappingFile = {(this.AccountMappingFile == null ? "null" : this.AccountMappingFile.ToString())}");
            toStringOutput.Add($"AccountMapping = {(this.AccountMapping == null ? "null" : this.AccountMapping.ToString())}");
        }
    }
}