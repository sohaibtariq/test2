// <copyright file="IdentifierTagSForScan.cs" company="APIMatic">
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
    /// IdentifierTagSForScan.
    /// </summary>
    public class IdentifierTagSForScan
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentifierTagSForScan"/> class.
        /// </summary>
        public IdentifierTagSForScan()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentifierTagSForScan"/> class.
        /// </summary>
        /// <param name="abc">abc.</param>
        public IdentifierTagSForScan(
            string abc = null)
        {
            this.Abc = abc;
        }

        /// <summary>
        /// Gets or sets Abc.
        /// </summary>
        [JsonProperty("abc", NullValueHandling = NullValueHandling.Ignore)]
        public string Abc { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"IdentifierTagSForScan : ({string.Join(", ", toStringOutput)})";
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

            return obj is IdentifierTagSForScan other &&
                ((this.Abc == null && other.Abc == null) || (this.Abc?.Equals(other.Abc) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 4427944;

            if (this.Abc != null)
            {
               hashCode += this.Abc.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Abc = {(this.Abc == null ? "null" : this.Abc == string.Empty ? "" : this.Abc)}");
        }
    }
}