// <copyright file="WithoutOrgAccess2.cs" company="APIMatic">
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
    /// WithoutOrgAccess2.
    /// </summary>
    public class WithoutOrgAccess2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WithoutOrgAccess2"/> class.
        /// </summary>
        public WithoutOrgAccess2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WithoutOrgAccess2"/> class.
        /// </summary>
        /// <param name="props">props.</param>
        /// <param name="userEnabled">userEnabled.</param>
        public WithoutOrgAccess2(
            Models.Props22 props = null,
            Models.UserEnabledEnum? userEnabled = null)
        {
            this.Props = props;
            this.UserEnabled = userEnabled;
        }

        /// <summary>
        /// Gets or sets Props.
        /// </summary>
        [JsonProperty("props", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Props22 Props { get; set; }

        /// <summary>
        /// Gets or sets UserEnabled.
        /// </summary>
        [JsonProperty("userEnabled", NullValueHandling = NullValueHandling.Ignore)]
        public Models.UserEnabledEnum? UserEnabled { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"WithoutOrgAccess2 : ({string.Join(", ", toStringOutput)})";
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

            return obj is WithoutOrgAccess2 other &&
                ((this.Props == null && other.Props == null) || (this.Props?.Equals(other.Props) == true)) &&
                ((this.UserEnabled == null && other.UserEnabled == null) || (this.UserEnabled?.Equals(other.UserEnabled) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -1860755521;

            if (this.Props != null)
            {
               hashCode += this.Props.GetHashCode();
            }

            if (this.UserEnabled != null)
            {
               hashCode += this.UserEnabled.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Props = {(this.Props == null ? "null" : this.Props.ToString())}");
            toStringOutput.Add($"this.UserEnabled = {(this.UserEnabled == null ? "null" : this.UserEnabled.ToString())}");
        }
    }
}