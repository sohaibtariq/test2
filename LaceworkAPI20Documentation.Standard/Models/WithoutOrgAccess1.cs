// <copyright file="WithoutOrgAccess1.cs" company="APIMatic">
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
    /// WithoutOrgAccess1.
    /// </summary>
    public class WithoutOrgAccess1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WithoutOrgAccess1"/> class.
        /// </summary>
        public WithoutOrgAccess1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WithoutOrgAccess1"/> class.
        /// </summary>
        /// <param name="props">props.</param>
        /// <param name="userName">userName.</param>
        /// <param name="userEnabled">userEnabled.</param>
        public WithoutOrgAccess1(
            Models.Props18 props,
            string userName,
            Models.UserEnabledEnum userEnabled)
        {
            this.Props = props;
            this.UserName = userName;
            this.UserEnabled = userEnabled;
        }

        /// <summary>
        /// Gets or sets Props.
        /// </summary>
        [JsonProperty("props")]
        public Models.Props18 Props { get; set; }

        /// <summary>
        /// user email address
        /// </summary>
        [JsonProperty("userName")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets UserEnabled.
        /// </summary>
        [JsonProperty("userEnabled")]
        public Models.UserEnabledEnum UserEnabled { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"WithoutOrgAccess1 : ({string.Join(", ", toStringOutput)})";
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

            return obj is WithoutOrgAccess1 other &&
                ((this.Props == null && other.Props == null) || (this.Props?.Equals(other.Props) == true)) &&
                ((this.UserName == null && other.UserName == null) || (this.UserName?.Equals(other.UserName) == true)) &&
                this.UserEnabled.Equals(other.UserEnabled);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -675925143;

            if (this.Props != null)
            {
               hashCode += this.Props.GetHashCode();
            }

            if (this.UserName != null)
            {
               hashCode += this.UserName.GetHashCode();
            }

            hashCode += this.UserEnabled.GetHashCode();

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Props = {(this.Props == null ? "null" : this.Props.ToString())}");
            toStringOutput.Add($"this.UserName = {(this.UserName == null ? "null" : this.UserName == string.Empty ? "" : this.UserName)}");
            toStringOutput.Add($"this.UserEnabled = {this.UserEnabled}");
        }
    }
}