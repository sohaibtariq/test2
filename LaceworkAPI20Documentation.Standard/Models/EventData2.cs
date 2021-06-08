// <copyright file="EventData2.cs" company="APIMatic">
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
    /// EventData2.
    /// </summary>
    public class EventData2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventData2"/> class.
        /// </summary>
        public EventData2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventData2"/> class.
        /// </summary>
        /// <param name="index">index.</param>
        /// <param name="source">source.</param>
        public EventData2(
            string index = null,
            string source = null)
        {
            this.Index = index;
            this.Source = source;
        }

        /// <summary>
        /// Gets or sets Index.
        /// </summary>
        [JsonProperty("index", NullValueHandling = NullValueHandling.Ignore)]
        public string Index { get; set; }

        /// <summary>
        /// Gets or sets Source.
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"EventData2 : ({string.Join(", ", toStringOutput)})";
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

            return obj is EventData2 other &&
                ((this.Index == null && other.Index == null) || (this.Index?.Equals(other.Index) == true)) &&
                ((this.Source == null && other.Source == null) || (this.Source?.Equals(other.Source) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -1143170641;

            if (this.Index != null)
            {
               hashCode += this.Index.GetHashCode();
            }

            if (this.Source != null)
            {
               hashCode += this.Source.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Index = {(this.Index == null ? "null" : this.Index == string.Empty ? "" : this.Index)}");
            toStringOutput.Add($"this.Source = {(this.Source == null ? "null" : this.Source == string.Empty ? "" : this.Source)}");
        }
    }
}