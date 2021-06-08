// <copyright file="Account.cs" company="APIMatic">
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
    /// Account.
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        public Account()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        /// <param name="admin">admin.</param>
        /// <param name="accountName">accountName.</param>
        /// <param name="custGuid">custGuid.</param>
        /// <param name="userGuid">userGuid.</param>
        /// <param name="userEnabled">userEnabled.</param>
        public Account(
            bool? admin = null,
            string accountName = null,
            string custGuid = null,
            string userGuid = null,
            Models.UserEnabledEnum? userEnabled = null)
        {
            this.Admin = admin;
            this.AccountName = accountName;
            this.CustGuid = custGuid;
            this.UserGuid = userGuid;
            this.UserEnabled = userEnabled;
        }

        /// <summary>
        /// Gets or sets Admin.
        /// </summary>
        [JsonProperty("admin", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Admin { get; set; }

        /// <summary>
        /// Gets or sets AccountName.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets CustGuid.
        /// </summary>
        [JsonProperty("custGuid", NullValueHandling = NullValueHandling.Ignore)]
        public string CustGuid { get; set; }

        /// <summary>
        /// Gets or sets UserGuid.
        /// </summary>
        [JsonProperty("userGuid", NullValueHandling = NullValueHandling.Ignore)]
        public string UserGuid { get; set; }

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

            return $"Account : ({string.Join(", ", toStringOutput)})";
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

            return obj is Account other &&
                ((this.Admin == null && other.Admin == null) || (this.Admin?.Equals(other.Admin) == true)) &&
                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.CustGuid == null && other.CustGuid == null) || (this.CustGuid?.Equals(other.CustGuid) == true)) &&
                ((this.UserGuid == null && other.UserGuid == null) || (this.UserGuid?.Equals(other.UserGuid) == true)) &&
                ((this.UserEnabled == null && other.UserEnabled == null) || (this.UserEnabled?.Equals(other.UserEnabled) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 2111013842;

            if (this.Admin != null)
            {
               hashCode += this.Admin.GetHashCode();
            }

            if (this.AccountName != null)
            {
               hashCode += this.AccountName.GetHashCode();
            }

            if (this.CustGuid != null)
            {
               hashCode += this.CustGuid.GetHashCode();
            }

            if (this.UserGuid != null)
            {
               hashCode += this.UserGuid.GetHashCode();
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
            toStringOutput.Add($"this.Admin = {(this.Admin == null ? "null" : this.Admin.ToString())}");
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName == string.Empty ? "" : this.AccountName)}");
            toStringOutput.Add($"this.CustGuid = {(this.CustGuid == null ? "null" : this.CustGuid == string.Empty ? "" : this.CustGuid)}");
            toStringOutput.Add($"this.UserGuid = {(this.UserGuid == null ? "null" : this.UserGuid == string.Empty ? "" : this.UserGuid)}");
            toStringOutput.Add($"this.UserEnabled = {(this.UserEnabled == null ? "null" : this.UserEnabled.ToString())}");
        }
    }
}