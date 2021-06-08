// <copyright file="Data42.cs" company="APIMatic">
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
    /// Data42.
    /// </summary>
    public class Data42
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data42"/> class.
        /// </summary>
        public Data42()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data42"/> class.
        /// </summary>
        /// <param name="hecToken">hecToken.</param>
        /// <param name="channel">channel.</param>
        /// <param name="host">host.</param>
        /// <param name="port">port.</param>
        /// <param name="ssl">ssl.</param>
        /// <param name="eventData">eventData.</param>
        public Data42(
            string hecToken = null,
            string channel = null,
            string host = null,
            double? port = null,
            bool? ssl = null,
            Models.EventData2 eventData = null)
        {
            this.HecToken = hecToken;
            this.Channel = channel;
            this.Host = host;
            this.Port = port;
            this.Ssl = ssl;
            this.EventData = eventData;
        }

        /// <summary>
        /// Gets or sets HecToken.
        /// </summary>
        [JsonProperty("hecToken", NullValueHandling = NullValueHandling.Ignore)]
        public string HecToken { get; set; }

        /// <summary>
        /// Gets or sets Channel.
        /// </summary>
        [JsonProperty("channel", NullValueHandling = NullValueHandling.Ignore)]
        public string Channel { get; set; }

        /// <summary>
        /// Gets or sets Host.
        /// </summary>
        [JsonProperty("host", NullValueHandling = NullValueHandling.Ignore)]
        public string Host { get; set; }

        /// <summary>
        /// Gets or sets Port.
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public double? Port { get; set; }

        /// <summary>
        /// Gets or sets Ssl.
        /// </summary>
        [JsonProperty("ssl", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ssl { get; set; }

        /// <summary>
        /// Gets or sets EventData.
        /// </summary>
        [JsonProperty("eventData", NullValueHandling = NullValueHandling.Ignore)]
        public Models.EventData2 EventData { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data42 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data42 other &&
                ((this.HecToken == null && other.HecToken == null) || (this.HecToken?.Equals(other.HecToken) == true)) &&
                ((this.Channel == null && other.Channel == null) || (this.Channel?.Equals(other.Channel) == true)) &&
                ((this.Host == null && other.Host == null) || (this.Host?.Equals(other.Host) == true)) &&
                ((this.Port == null && other.Port == null) || (this.Port?.Equals(other.Port) == true)) &&
                ((this.Ssl == null && other.Ssl == null) || (this.Ssl?.Equals(other.Ssl) == true)) &&
                ((this.EventData == null && other.EventData == null) || (this.EventData?.Equals(other.EventData) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -1690454347;

            if (this.HecToken != null)
            {
               hashCode += this.HecToken.GetHashCode();
            }

            if (this.Channel != null)
            {
               hashCode += this.Channel.GetHashCode();
            }

            if (this.Host != null)
            {
               hashCode += this.Host.GetHashCode();
            }

            if (this.Port != null)
            {
               hashCode += this.Port.GetHashCode();
            }

            if (this.Ssl != null)
            {
               hashCode += this.Ssl.GetHashCode();
            }

            if (this.EventData != null)
            {
               hashCode += this.EventData.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.HecToken = {(this.HecToken == null ? "null" : this.HecToken == string.Empty ? "" : this.HecToken)}");
            toStringOutput.Add($"this.Channel = {(this.Channel == null ? "null" : this.Channel == string.Empty ? "" : this.Channel)}");
            toStringOutput.Add($"this.Host = {(this.Host == null ? "null" : this.Host == string.Empty ? "" : this.Host)}");
            toStringOutput.Add($"this.Port = {(this.Port == null ? "null" : this.Port.ToString())}");
            toStringOutput.Add($"this.Ssl = {(this.Ssl == null ? "null" : this.Ssl.ToString())}");
            toStringOutput.Add($"this.EventData = {(this.EventData == null ? "null" : this.EventData.ToString())}");
        }
    }
}