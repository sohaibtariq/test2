// <copyright file="ResponseAlertRulesList.cs" company="APIMatic">
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
    /// ResponseAlertRulesList.
    /// </summary>
    public class ResponseAlertRulesList
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAlertRulesList"/> class.
        /// </summary>
        public ResponseAlertRulesList()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAlertRulesList"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        public ResponseAlertRulesList(
            List<Models.AlertRules> data = null)
        {
            this.Data = data;
        }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.AlertRules> Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ResponseAlertRulesList : ({string.Join(", ", toStringOutput)})";
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

            return obj is ResponseAlertRulesList other &&
                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 173698471;

            if (this.Data != null)
            {
               hashCode += this.Data.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : $"[{string.Join(", ", this.Data)} ]")}");
        }
    }
}