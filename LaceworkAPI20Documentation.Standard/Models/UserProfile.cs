// <copyright file="UserProfile.cs" company="APIMatic">
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
    /// UserProfile.
    /// </summary>
    public class UserProfile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfile"/> class.
        /// </summary>
        public UserProfile()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfile"/> class.
        /// </summary>
        /// <param name="username">username.</param>
        /// <param name="orgAccount">orgAccount.</param>
        /// <param name="accounts">accounts.</param>
        /// <param name="url">url.</param>
        /// <param name="orgAdmin">orgAdmin.</param>
        /// <param name="orgUser">orgUser.</param>
        public UserProfile(
            string username,
            bool orgAccount,
            List<Models.Account> accounts,
            string url = null,
            bool? orgAdmin = null,
            bool? orgUser = null)
        {
            this.Username = username;
            this.OrgAccount = orgAccount;
            this.Url = url;
            this.OrgAdmin = orgAdmin;
            this.OrgUser = orgUser;
            this.Accounts = accounts;
        }

        /// <summary>
        /// Gets or sets Username.
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets OrgAccount.
        /// </summary>
        [JsonProperty("orgAccount")]
        public bool OrgAccount { get; set; }

        /// <summary>
        /// Gets or sets Url.
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets OrgAdmin.
        /// </summary>
        [JsonProperty("orgAdmin", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OrgAdmin { get; set; }

        /// <summary>
        /// Gets or sets OrgUser.
        /// </summary>
        [JsonProperty("orgUser", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OrgUser { get; set; }

        /// <summary>
        /// list of accounts this user has access to
        /// </summary>
        [JsonProperty("accounts")]
        public List<Models.Account> Accounts { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UserProfile : ({string.Join(", ", toStringOutput)})";
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

            return obj is UserProfile other &&
                ((this.Username == null && other.Username == null) || (this.Username?.Equals(other.Username) == true)) &&
                this.OrgAccount.Equals(other.OrgAccount) &&
                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
                ((this.OrgAdmin == null && other.OrgAdmin == null) || (this.OrgAdmin?.Equals(other.OrgAdmin) == true)) &&
                ((this.OrgUser == null && other.OrgUser == null) || (this.OrgUser?.Equals(other.OrgUser) == true)) &&
                ((this.Accounts == null && other.Accounts == null) || (this.Accounts?.Equals(other.Accounts) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -636350923;

            if (this.Username != null)
            {
               hashCode += this.Username.GetHashCode();
            }

            hashCode += this.OrgAccount.GetHashCode();

            if (this.Url != null)
            {
               hashCode += this.Url.GetHashCode();
            }

            if (this.OrgAdmin != null)
            {
               hashCode += this.OrgAdmin.GetHashCode();
            }

            if (this.OrgUser != null)
            {
               hashCode += this.OrgUser.GetHashCode();
            }

            if (this.Accounts != null)
            {
               hashCode += this.Accounts.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Username = {(this.Username == null ? "null" : this.Username == string.Empty ? "" : this.Username)}");
            toStringOutput.Add($"this.OrgAccount = {this.OrgAccount}");
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url == string.Empty ? "" : this.Url)}");
            toStringOutput.Add($"this.OrgAdmin = {(this.OrgAdmin == null ? "null" : this.OrgAdmin.ToString())}");
            toStringOutput.Add($"this.OrgUser = {(this.OrgUser == null ? "null" : this.OrgUser.ToString())}");
            toStringOutput.Add($"this.Accounts = {(this.Accounts == null ? "null" : $"[{string.Join(", ", this.Accounts)} ]")}");
        }
    }
}