// <copyright file="Data4.cs" company="APIMatic">
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
    /// Data4.
    /// </summary>
    public class Data4
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data4"/> class.
        /// </summary>
        public Data4()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data4"/> class.
        /// </summary>
        /// <param name="channelProps">channelProps.</param>
        /// <param name="notificationTypes">notificationTypes.</param>
        public Data4(
            Models.ChannelProps channelProps = null,
            Models.NotificationTypes notificationTypes = null)
        {
            this.ChannelProps = channelProps;
            this.NotificationTypes = notificationTypes;
        }

        /// <summary>
        /// Gets or sets ChannelProps.
        /// </summary>
        [JsonProperty("channelProps", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ChannelProps ChannelProps { get; set; }

        /// <summary>
        /// Gets or sets NotificationTypes.
        /// </summary>
        [JsonProperty("notificationTypes", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NotificationTypes NotificationTypes { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data4 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data4 other &&
                ((this.ChannelProps == null && other.ChannelProps == null) || (this.ChannelProps?.Equals(other.ChannelProps) == true)) &&
                ((this.NotificationTypes == null && other.NotificationTypes == null) || (this.NotificationTypes?.Equals(other.NotificationTypes) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 734926664;

            if (this.ChannelProps != null)
            {
               hashCode += this.ChannelProps.GetHashCode();
            }

            if (this.NotificationTypes != null)
            {
               hashCode += this.NotificationTypes.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ChannelProps = {(this.ChannelProps == null ? "null" : this.ChannelProps.ToString())}");
            toStringOutput.Add($"this.NotificationTypes = {(this.NotificationTypes == null ? "null" : this.NotificationTypes.ToString())}");
        }
    }
}