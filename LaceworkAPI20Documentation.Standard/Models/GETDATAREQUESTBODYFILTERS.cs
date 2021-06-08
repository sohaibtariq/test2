// <copyright file="GETDATAREQUESTBODYFILTERS.cs" company="APIMatic">
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
    /// GETDATAREQUESTBODYFILTERS.
    /// </summary>
    public class GETDATAREQUESTBODYFILTERS
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GETDATAREQUESTBODYFILTERS"/> class.
        /// </summary>
        public GETDATAREQUESTBODYFILTERS()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GETDATAREQUESTBODYFILTERS"/> class.
        /// </summary>
        /// <param name="filters">filters.</param>
        /// <param name="returns">returns.</param>
        public GETDATAREQUESTBODYFILTERS(
            List<Models.Filters1> filters = null,
            List<string> returns = null)
        {
            this.Filters = filters;
            this.Returns = returns;
        }

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

            return $"GETDATAREQUESTBODYFILTERS : ({string.Join(", ", toStringOutput)})";
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

            return obj is GETDATAREQUESTBODYFILTERS other &&
                ((this.Filters == null && other.Filters == null) || (this.Filters?.Equals(other.Filters) == true)) &&
                ((this.Returns == null && other.Returns == null) || (this.Returns?.Equals(other.Returns) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 439369907;

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
            toStringOutput.Add($"this.Filters = {(this.Filters == null ? "null" : $"[{string.Join(", ", this.Filters)} ]")}");
            toStringOutput.Add($"this.Returns = {(this.Returns == null ? "null" : $"[{string.Join(", ", this.Returns)} ]")}");
        }
    }
}