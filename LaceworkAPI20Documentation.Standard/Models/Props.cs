// <copyright file="Props.cs" company="APIMatic">
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
    /// Props.
    /// </summary>
    public class Props
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Props"/> class.
        /// </summary>
        public Props()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Props"/> class.
        /// </summary>
        /// <param name="accountIds">accountIds.</param>
        /// <param name="updatedBy">updatedBy.</param>
        /// <param name="lastUpdated">lastUpdated.</param>
        /// <param name="description">description.</param>
        public Props(
            List<string> accountIds,
            string updatedBy = null,
            double? lastUpdated = null,
            string description = null)
        {
            this.UpdatedBy = updatedBy;
            this.LastUpdated = lastUpdated;
            this.Description = description;
            this.AccountIds = accountIds;
        }

        /// <summary>
        /// Gets or sets UpdatedBy.
        /// </summary>
        [JsonProperty("updatedBy", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Gets or sets LastUpdated.
        /// </summary>
        [JsonProperty("lastUpdated", NullValueHandling = NullValueHandling.Ignore)]
        public double? LastUpdated { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets AccountIds.
        /// </summary>
        [JsonProperty("accountIds")]
        public List<string> AccountIds { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Props : ({string.Join(", ", toStringOutput)})";
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

            return obj is Props other &&
                ((this.UpdatedBy == null && other.UpdatedBy == null) || (this.UpdatedBy?.Equals(other.UpdatedBy) == true)) &&
                ((this.LastUpdated == null && other.LastUpdated == null) || (this.LastUpdated?.Equals(other.LastUpdated) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.AccountIds == null && other.AccountIds == null) || (this.AccountIds?.Equals(other.AccountIds) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -2056281551;

            if (this.UpdatedBy != null)
            {
               hashCode += this.UpdatedBy.GetHashCode();
            }

            if (this.LastUpdated != null)
            {
               hashCode += this.LastUpdated.GetHashCode();
            }

            if (this.Description != null)
            {
               hashCode += this.Description.GetHashCode();
            }

            if (this.AccountIds != null)
            {
               hashCode += this.AccountIds.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.UpdatedBy = {(this.UpdatedBy == null ? "null" : this.UpdatedBy == string.Empty ? "" : this.UpdatedBy)}");
            toStringOutput.Add($"this.LastUpdated = {(this.LastUpdated == null ? "null" : this.LastUpdated.ToString())}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.AccountIds = {(this.AccountIds == null ? "null" : $"[{string.Join(", ", this.AccountIds)} ]")}");
        }
    }
}