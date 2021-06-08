// <copyright file="Filters.cs" company="APIMatic">
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
    /// Filters.
    /// </summary>
    public class Filters
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Filters"/> class.
        /// </summary>
        public Filters()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Filters"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="resourceGroups">resourceGroups.</param>
        /// <param name="eventCategory">eventCategory.</param>
        /// <param name="severity">severity.</param>
        public Filters(
            string name = null,
            string description = null,
            Models.EnabledEnum? enabled = null,
            object resourceGroups = null,
            List<Models.EventCategoryEnum> eventCategory = null,
            List<Models.SeverityEnum> severity = null)
        {
            this.Name = name;
            this.Description = description;
            this.Enabled = enabled;
            this.ResourceGroups = resourceGroups;
            this.EventCategory = eventCategory;
            this.Severity = severity;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Enabled.
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public Models.EnabledEnum? Enabled { get; set; }

        /// <summary>
        /// one or more unique resource groups
        /// </summary>
        [JsonProperty("resourceGroups", NullValueHandling = NullValueHandling.Ignore)]
        public object ResourceGroups { get; set; }

        /// <summary>
        /// one or more unique event categories
        /// </summary>
        [JsonProperty("eventCategory", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.EventCategoryEnum> EventCategory { get; set; }

        /// <summary>
        /// 1=Critical 2=High 3=Medium 4=Low 5=Info
        /// </summary>
        [JsonProperty("severity", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.SeverityEnum> Severity { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Filters : ({string.Join(", ", toStringOutput)})";
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

            return obj is Filters other &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Enabled == null && other.Enabled == null) || (this.Enabled?.Equals(other.Enabled) == true)) &&
                ((this.ResourceGroups == null && other.ResourceGroups == null) || (this.ResourceGroups?.Equals(other.ResourceGroups) == true)) &&
                ((this.EventCategory == null && other.EventCategory == null) || (this.EventCategory?.Equals(other.EventCategory) == true)) &&
                ((this.Severity == null && other.Severity == null) || (this.Severity?.Equals(other.Severity) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -2009839545;

            if (this.Name != null)
            {
               hashCode += this.Name.GetHashCode();
            }

            if (this.Description != null)
            {
               hashCode += this.Description.GetHashCode();
            }

            if (this.Enabled != null)
            {
               hashCode += this.Enabled.GetHashCode();
            }

            if (this.ResourceGroups != null)
            {
               hashCode += this.ResourceGroups.GetHashCode();
            }

            if (this.EventCategory != null)
            {
               hashCode += this.EventCategory.GetHashCode();
            }

            if (this.Severity != null)
            {
               hashCode += this.Severity.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.Enabled = {(this.Enabled == null ? "null" : this.Enabled.ToString())}");
            toStringOutput.Add($"ResourceGroups = {(this.ResourceGroups == null ? "null" : this.ResourceGroups.ToString())}");
            toStringOutput.Add($"this.EventCategory = {(this.EventCategory == null ? "null" : $"[{string.Join(", ", this.EventCategory)} ]")}");
            toStringOutput.Add($"this.Severity = {(this.Severity == null ? "null" : $"[{string.Join(", ", this.Severity)} ]")}");
        }
    }
}