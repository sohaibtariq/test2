// <copyright file="ChannelProps.cs" company="APIMatic">
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
    /// ChannelProps.
    /// </summary>
    public class ChannelProps
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelProps"/> class.
        /// </summary>
        public ChannelProps()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelProps"/> class.
        /// </summary>
        /// <param name="recipients">recipients.</param>
        public ChannelProps(
            object recipients)
        {
            this.Recipients = recipients;
        }

        /// <summary>
        /// a list of email addresses
        /// </summary>
        [JsonProperty("recipients")]
        public object Recipients { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ChannelProps : ({string.Join(", ", toStringOutput)})";
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

            return obj is ChannelProps other &&
                ((this.Recipients == null && other.Recipients == null) || (this.Recipients?.Equals(other.Recipients) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 333596138;

            if (this.Recipients != null)
            {
               hashCode += this.Recipients.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Recipients = {(this.Recipients == null ? "null" : this.Recipients.ToString())}");
        }
    }
}