// <copyright file="Data38.cs" company="APIMatic">
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
    /// Data38.
    /// </summary>
    public class Data38
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data38"/> class.
        /// </summary>
        public Data38()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data38"/> class.
        /// </summary>
        /// <param name="insertKey">insertKey.</param>
        /// <param name="accountId">accountId.</param>
        public Data38(
            string insertKey = null,
            double? accountId = null)
        {
            this.InsertKey = insertKey;
            this.AccountId = accountId;
        }

        /// <summary>
        /// Gets or sets InsertKey.
        /// </summary>
        [JsonProperty("insertKey", NullValueHandling = NullValueHandling.Ignore)]
        public string InsertKey { get; set; }

        /// <summary>
        /// Gets or sets AccountId.
        /// </summary>
        [JsonProperty("accountId", NullValueHandling = NullValueHandling.Ignore)]
        public double? AccountId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data38 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data38 other &&
                ((this.InsertKey == null && other.InsertKey == null) || (this.InsertKey?.Equals(other.InsertKey) == true)) &&
                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -2126216748;

            if (this.InsertKey != null)
            {
               hashCode += this.InsertKey.GetHashCode();
            }

            if (this.AccountId != null)
            {
               hashCode += this.AccountId.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.InsertKey = {(this.InsertKey == null ? "null" : this.InsertKey == string.Empty ? "" : this.InsertKey)}");
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
        }
    }
}