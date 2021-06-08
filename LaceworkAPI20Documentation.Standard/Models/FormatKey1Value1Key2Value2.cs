// <copyright file="FormatKey1Value1Key2Value2.cs" company="APIMatic">
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
    /// FormatKey1Value1Key2Value2.
    /// </summary>
    public class FormatKey1Value1Key2Value2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormatKey1Value1Key2Value2"/> class.
        /// </summary>
        public FormatKey1Value1Key2Value2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormatKey1Value1Key2Value2"/> class.
        /// </summary>
        /// <param name="abc">abc.</param>
        public FormatKey1Value1Key2Value2(
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

            return $"FormatKey1Value1Key2Value2 : ({string.Join(", ", toStringOutput)})";
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

            return obj is FormatKey1Value1Key2Value2 other &&
                ((this.Abc == null && other.Abc == null) || (this.Abc?.Equals(other.Abc) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1134748960;

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