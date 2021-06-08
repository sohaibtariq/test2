// <copyright file="CrossAccountCredentials.cs" company="APIMatic">
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
    /// CrossAccountCredentials.
    /// </summary>
    public class CrossAccountCredentials
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CrossAccountCredentials"/> class.
        /// </summary>
        public CrossAccountCredentials()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CrossAccountCredentials"/> class.
        /// </summary>
        /// <param name="externalId">externalId.</param>
        /// <param name="roleArn">roleArn.</param>
        public CrossAccountCredentials(
            string externalId,
            string roleArn)
        {
            this.ExternalId = externalId;
            this.RoleArn = roleArn;
        }

        /// <summary>
        /// Gets or sets ExternalId.
        /// </summary>
        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or sets RoleArn.
        /// </summary>
        [JsonProperty("roleArn")]
        public string RoleArn { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CrossAccountCredentials : ({string.Join(", ", toStringOutput)})";
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

            return obj is CrossAccountCredentials other &&
                ((this.ExternalId == null && other.ExternalId == null) || (this.ExternalId?.Equals(other.ExternalId) == true)) &&
                ((this.RoleArn == null && other.RoleArn == null) || (this.RoleArn?.Equals(other.RoleArn) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1582298758;

            if (this.ExternalId != null)
            {
               hashCode += this.ExternalId.GetHashCode();
            }

            if (this.RoleArn != null)
            {
               hashCode += this.RoleArn.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ExternalId = {(this.ExternalId == null ? "null" : this.ExternalId == string.Empty ? "" : this.ExternalId)}");
            toStringOutput.Add($"this.RoleArn = {(this.RoleArn == null ? "null" : this.RoleArn == string.Empty ? "" : this.RoleArn)}");
        }
    }
}