// <copyright file="AlertRules.cs" company="APIMatic">
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
    /// AlertRules.
    /// </summary>
    public class AlertRules
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlertRules"/> class.
        /// </summary>
        public AlertRules()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertRules"/> class.
        /// </summary>
        /// <param name="filters">filters.</param>
        /// <param name="intgGuidList">intgGuidList.</param>
        /// <param name="type">type.</param>
        /// <param name="mcGuid">mcGuid.</param>
        public AlertRules(
            Models.Filters filters,
            object intgGuidList,
            string type,
            string mcGuid = null)
        {
            this.Filters = filters;
            this.IntgGuidList = intgGuidList;
            this.Type = type;
            this.McGuid = mcGuid;
        }

        /// <summary>
        /// Gets or sets Filters.
        /// </summary>
        [JsonProperty("filters")]
        public Models.Filters Filters { get; set; }

        /// <summary>
        /// Gets or sets IntgGuidList.
        /// </summary>
        [JsonProperty("intgGuidList")]
        public object IntgGuidList { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets McGuid.
        /// </summary>
        [JsonProperty("mcGuid", NullValueHandling = NullValueHandling.Ignore)]
        public string McGuid { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AlertRules : ({string.Join(", ", toStringOutput)})";
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

            return obj is AlertRules other &&
                ((this.Filters == null && other.Filters == null) || (this.Filters?.Equals(other.Filters) == true)) &&
                ((this.IntgGuidList == null && other.IntgGuidList == null) || (this.IntgGuidList?.Equals(other.IntgGuidList) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.McGuid == null && other.McGuid == null) || (this.McGuid?.Equals(other.McGuid) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -348273218;

            if (this.Filters != null)
            {
               hashCode += this.Filters.GetHashCode();
            }

            if (this.IntgGuidList != null)
            {
               hashCode += this.IntgGuidList.GetHashCode();
            }

            if (this.Type != null)
            {
               hashCode += this.Type.GetHashCode();
            }

            if (this.McGuid != null)
            {
               hashCode += this.McGuid.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Filters = {(this.Filters == null ? "null" : this.Filters.ToString())}");
            toStringOutput.Add($"IntgGuidList = {(this.IntgGuidList == null ? "null" : this.IntgGuidList.ToString())}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.McGuid = {(this.McGuid == null ? "null" : this.McGuid == string.Empty ? "" : this.McGuid)}");
        }
    }
}