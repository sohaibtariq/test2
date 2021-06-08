// <copyright file="Data32.cs" company="APIMatic">
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
    /// Data32.
    /// </summary>
    public class Data32
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data32"/> class.
        /// </summary>
        public Data32()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data32"/> class.
        /// </summary>
        /// <param name="issueGrouping">issueGrouping.</param>
        /// <param name="eventBusArn">eventBusArn.</param>
        public Data32(
            Models.GroupIssuesByEnum? issueGrouping = Models.GroupIssuesByEnum.Events,
            string eventBusArn = null)
        {
            this.IssueGrouping = issueGrouping;
            this.EventBusArn = eventBusArn;
        }

        /// <summary>
        /// Gets or sets IssueGrouping.
        /// </summary>
        [JsonProperty("issueGrouping", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.GroupIssuesByEnum? IssueGrouping { get; set; }

        /// <summary>
        /// Gets or sets EventBusArn.
        /// </summary>
        [JsonProperty("eventBusArn", NullValueHandling = NullValueHandling.Ignore)]
        public string EventBusArn { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data32 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data32 other &&
                ((this.IssueGrouping == null && other.IssueGrouping == null) || (this.IssueGrouping?.Equals(other.IssueGrouping) == true)) &&
                ((this.EventBusArn == null && other.EventBusArn == null) || (this.EventBusArn?.Equals(other.EventBusArn) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1498913619;

            if (this.IssueGrouping != null)
            {
               hashCode += this.IssueGrouping.GetHashCode();
            }

            if (this.EventBusArn != null)
            {
               hashCode += this.EventBusArn.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.IssueGrouping = {(this.IssueGrouping == null ? "null" : this.IssueGrouping.ToString())}");
            toStringOutput.Add($"this.EventBusArn = {(this.EventBusArn == null ? "null" : this.EventBusArn == string.Empty ? "" : this.EventBusArn)}");
        }
    }
}