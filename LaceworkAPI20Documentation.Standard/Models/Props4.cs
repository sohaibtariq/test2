// <copyright file="Props4.cs" company="APIMatic">
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
    /// Props4.
    /// </summary>
    public class Props4
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Props4"/> class.
        /// </summary>
        public Props4()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Props4"/> class.
        /// </summary>
        /// <param name="containerLabels">containerLabels.</param>
        /// <param name="containerTags">containerTags.</param>
        /// <param name="updatedBy">updatedBy.</param>
        /// <param name="lastUpdated">lastUpdated.</param>
        /// <param name="description">description.</param>
        public Props4(
            List<Models.FormatKey1Value1Key2Value2> containerLabels,
            List<string> containerTags,
            string updatedBy = null,
            double? lastUpdated = null,
            string description = null)
        {
            this.UpdatedBy = updatedBy;
            this.LastUpdated = lastUpdated;
            this.Description = description;
            this.ContainerLabels = containerLabels;
            this.ContainerTags = containerTags;
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
        /// Gets or sets ContainerLabels.
        /// </summary>
        [JsonProperty("containerLabels")]
        public List<Models.FormatKey1Value1Key2Value2> ContainerLabels { get; set; }

        /// <summary>
        /// Gets or sets ContainerTags.
        /// </summary>
        [JsonProperty("containerTags")]
        public List<string> ContainerTags { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Props4 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Props4 other &&
                ((this.UpdatedBy == null && other.UpdatedBy == null) || (this.UpdatedBy?.Equals(other.UpdatedBy) == true)) &&
                ((this.LastUpdated == null && other.LastUpdated == null) || (this.LastUpdated?.Equals(other.LastUpdated) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.ContainerLabels == null && other.ContainerLabels == null) || (this.ContainerLabels?.Equals(other.ContainerLabels) == true)) &&
                ((this.ContainerTags == null && other.ContainerTags == null) || (this.ContainerTags?.Equals(other.ContainerTags) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -1214567295;

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

            if (this.ContainerLabels != null)
            {
               hashCode += this.ContainerLabels.GetHashCode();
            }

            if (this.ContainerTags != null)
            {
               hashCode += this.ContainerTags.GetHashCode();
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
            toStringOutput.Add($"this.ContainerLabels = {(this.ContainerLabels == null ? "null" : $"[{string.Join(", ", this.ContainerLabels)} ]")}");
            toStringOutput.Add($"this.ContainerTags = {(this.ContainerTags == null ? "null" : $"[{string.Join(", ", this.ContainerTags)} ]")}");
        }
    }
}