// <copyright file="Data6.cs" company="APIMatic">
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
    /// Data6.
    /// </summary>
    public class Data6
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data6"/> class.
        /// </summary>
        public Data6()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data6"/> class.
        /// </summary>
        /// <param name="qradarCommType">qradarCommType.</param>
        /// <param name="qradarHostUrl">qradarHostUrl.</param>
        /// <param name="qradarHostPort">qradarHostPort.</param>
        public Data6(
            Models.CommunicationTypeEnum qradarCommType,
            string qradarHostUrl,
            double? qradarHostPort = null)
        {
            this.QradarCommType = qradarCommType;
            this.QradarHostUrl = qradarHostUrl;
            this.QradarHostPort = qradarHostPort;
        }

        /// <summary>
        /// Gets or sets QradarCommType.
        /// </summary>
        [JsonProperty("qradarCommType", ItemConverterType = typeof(StringEnumConverter))]
        public Models.CommunicationTypeEnum QradarCommType { get; set; }

        /// <summary>
        /// Gets or sets QradarHostUrl.
        /// </summary>
        [JsonProperty("qradarHostUrl")]
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

            return $"Data6 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data6 other &&
                this.QradarCommType.Equals(other.QradarCommType) &&
                ((this.QradarHostUrl == null && other.QradarHostUrl == null) || (this.QradarHostUrl?.Equals(other.QradarHostUrl) == true)) &&
                ((this.QradarHostPort == null && other.QradarHostPort == null) || (this.QradarHostPort?.Equals(other.QradarHostPort) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1390010009;
            hashCode += this.QradarCommType.GetHashCode();

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
            toStringOutput.Add($"this.QradarCommType = {this.QradarCommType}");
            toStringOutput.Add($"this.QradarHostUrl = {(this.QradarHostUrl == null ? "null" : this.QradarHostUrl == string.Empty ? "" : this.QradarHostUrl)}");
            toStringOutput.Add($"this.QradarHostPort = {(this.QradarHostPort == null ? "null" : this.QradarHostPort.ToString())}");
        }
    }
}