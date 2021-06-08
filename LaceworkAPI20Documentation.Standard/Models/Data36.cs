// <copyright file="Data36.cs" company="APIMatic">
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
    /// Data36.
    /// </summary>
    public class Data36
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data36"/> class.
        /// </summary>
        public Data36()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data36"/> class.
        /// </summary>
        /// <param name="qradarCommType">qradarCommType.</param>
        /// <param name="qradarHostUrl">qradarHostUrl.</param>
        /// <param name="qradarHostPort">qradarHostPort.</param>
        public Data36(
            Models.CommunicationTypeEnum? qradarCommType = Models.CommunicationTypeEnum.HTTPS,
            string qradarHostUrl = null,
            double? qradarHostPort = null)
        {
            this.QradarCommType = qradarCommType;
            this.QradarHostUrl = qradarHostUrl;
            this.QradarHostPort = qradarHostPort;
        }

        /// <summary>
        /// Gets or sets QradarCommType.
        /// </summary>
        [JsonProperty("qradarCommType", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.CommunicationTypeEnum? QradarCommType { get; set; }

        /// <summary>
        /// Gets or sets QradarHostUrl.
        /// </summary>
        [JsonProperty("qradarHostUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string QradarHostUrl { get; set; }

        /// <summary>
        /// Gets or sets QradarHostPort.
        /// </summary>
        [JsonProperty("qradarHostPort", NullValueHandling = NullValueHandling.Ignore)]
        public double? QradarHostPort { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data36 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data36 other &&
                ((this.QradarCommType == null && other.QradarCommType == null) || (this.QradarCommType?.Equals(other.QradarCommType) == true)) &&
                ((this.QradarHostUrl == null && other.QradarHostUrl == null) || (this.QradarHostUrl?.Equals(other.QradarHostUrl) == true)) &&
                ((this.QradarHostPort == null && other.QradarHostPort == null) || (this.QradarHostPort?.Equals(other.QradarHostPort) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1319924153;

            if (this.QradarCommType != null)
            {
               hashCode += this.QradarCommType.GetHashCode();
            }

            if (this.QradarHostUrl != null)
            {
               hashCode += this.QradarHostUrl.GetHashCode();
            }

            if (this.QradarHostPort != null)
            {
               hashCode += this.QradarHostPort.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.QradarCommType = {(this.QradarCommType == null ? "null" : this.QradarCommType.ToString())}");
            toStringOutput.Add($"this.QradarHostUrl = {(this.QradarHostUrl == null ? "null" : this.QradarHostUrl == string.Empty ? "" : this.QradarHostUrl)}");
            toStringOutput.Add($"this.QradarHostPort = {(this.QradarHostPort == null ? "null" : this.QradarHostPort.ToString())}");
        }
    }
}