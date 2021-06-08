// <copyright file="Data8.cs" company="APIMatic">
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
    /// Data8.
    /// </summary>
    public class Data8
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data8"/> class.
        /// </summary>
        public Data8()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data8"/> class.
        /// </summary>
        /// <param name="insertKey">insertKey.</param>
        /// <param name="accountId">accountId.</param>
        public Data8(
            string insertKey,
            double accountId)
        {
            this.InsertKey = insertKey;
            this.AccountId = accountId;
        }

        /// <summary>
        /// Gets or sets InsertKey.
        /// </summary>
        [JsonProperty("insertKey")]
        public string InsertKey { get; set; }

        /// <summary>
        /// Gets or sets AccountId.
        /// </summary>
        [JsonProperty("accountId")]
        public double AccountId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data8 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data8 other &&
                ((this.InsertKey == null && other.InsertKey == null) || (this.InsertKey?.Equals(other.InsertKey) == true)) &&
                this.AccountId.Equals(other.AccountId);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -210696720;

            if (this.InsertKey != null)
            {
               hashCode += this.InsertKey.GetHashCode();
            }

            hashCode += this.AccountId.GetHashCode();

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.InsertKey = {(this.InsertKey == null ? "null" : this.InsertKey == string.Empty ? "" : this.InsertKey)}");
            toStringOutput.Add($"this.AccountId = {this.AccountId}");
        }
    }
}