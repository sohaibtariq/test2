// <copyright file="GETDATAREQUESTBODYTIMEFILTERS.cs" company="APIMatic">
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
    /// GETDATAREQUESTBODYTIMEFILTERS.
    /// </summary>
    public class GETDATAREQUESTBODYTIMEFILTERS
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GETDATAREQUESTBODYTIMEFILTERS"/> class.
        /// </summary>
        public GETDATAREQUESTBODYTIMEFILTERS()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GETDATAREQUESTBODYTIMEFILTERS"/> class.
        /// </summary>
        /// <param name="timeFilter">timeFilter.</param>
        /// <param name="filters">filters.</param>
        /// <param name="returns">returns.</param>
        public GETDATAREQUESTBODYTIMEFILTERS(
            Models.TimeFilter timeFilter = null,
            List<Models.Filters1> filters = null,
            List<string> returns = null)
        {
            this.TimeFilter = timeFilter;
            this.Filters = filters;
            this.Returns = returns;
        }

        /// <summary>
        /// Gets or sets TimeFilter.
        /// </summary>
        [JsonProperty("timeFilter", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TimeFilter TimeFilter { get; set; }

        /// <summary>
        /// Gets or sets Filters.
        /// </summary>
        [JsonProperty("filters", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Filters1> Filters { get; set; }

        /// <summary>
        /// Gets or sets Returns.
        /// </summary>
        [JsonProperty("returns", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Returns { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GETDATAREQUESTBODYTIMEFILTERS : ({string.Join(", ", toStringOutput)})";
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

            return obj is GETDATAREQUESTBODYTIMEFILTERS other &&
                ((this.TimeFilter == null && other.TimeFilter == null) || (this.TimeFilter?.Equals(other.TimeFilter) == true)) &&
                ((this.Filters == null && other.Filters == null) || (this.Filters?.Equals(other.Filters) == true)) &&
                ((this.Returns == null && other.Returns == null) || (this.Returns?.Equals(other.Returns) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -157379711;

            if (this.TimeFilter != null)
            {
               hashCode += this.TimeFilter.GetHashCode();
            }

            if (this.Filters != null)
            {
               hashCode += this.Filters.GetHashCode();
            }

            if (this.Returns != null)
            {
               hashCode += this.Returns.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TimeFilter = {(this.TimeFilter == null ? "null" : this.TimeFilter.ToString())}");
            toStringOutput.Add($"this.Filters = {(this.Filters == null ? "null" : $"[{string.Join(", ", this.Filters)} ]")}");
            toStringOutput.Add($"this.Returns = {(this.Returns == null ? "null" : $"[{string.Join(", ", this.Returns)} ]")}");
        }
    }
}