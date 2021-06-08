// <copyright file="Props11.cs" company="APIMatic">
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
    /// Props11.
    /// </summary>
    public class Props11
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Props11"/> class.
        /// </summary>
        public Props11()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Props11"/> class.
        /// </summary>
        /// <param name="lwAccounts">lwAccounts.</param>
        /// <param name="description">description.</param>
        public Props11(
            List<string> lwAccounts,
            string description = null)
        {
            this.Description = description;
            this.LwAccounts = lwAccounts;
        }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets LwAccounts.
        /// </summary>
        [JsonProperty("lwAccounts")]
        public List<string> LwAccounts { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Props11 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Props11 other &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.LwAccounts == null && other.LwAccounts == null) || (this.LwAccounts?.Equals(other.LwAccounts) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -148762557;

            if (this.Description != null)
            {
               hashCode += this.Description.GetHashCode();
            }

            if (this.LwAccounts != null)
            {
               hashCode += this.LwAccounts.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.LwAccounts = {(this.LwAccounts == null ? "null" : $"[{string.Join(", ", this.LwAccounts)} ]")}");
        }
    }
}