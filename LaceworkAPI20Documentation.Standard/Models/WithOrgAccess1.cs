// <copyright file="WithOrgAccess1.cs" company="APIMatic">
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
    /// WithOrgAccess1.
    /// </summary>
    public class WithOrgAccess1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WithOrgAccess1"/> class.
        /// </summary>
        public WithOrgAccess1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WithOrgAccess1"/> class.
        /// </summary>
        /// <param name="props">props.</param>
        /// <param name="orgAdmin">orgAdmin.</param>
        /// <param name="orgUser">orgUser.</param>
        /// <param name="adminRoleAccounts">adminRoleAccounts.</param>
        /// <param name="userRoleAccounts">userRoleAccounts.</param>
        /// <param name="userName">userName.</param>
        /// <param name="userEnabled">userEnabled.</param>
        public WithOrgAccess1(
            Models.Props18 props,
            bool orgAdmin,
            bool orgUser,
            List<string> adminRoleAccounts,
            List<string> userRoleAccounts,
            string userName,
            Models.UserEnabledEnum userEnabled)
        {
            this.Props = props;
            this.OrgAdmin = orgAdmin;
            this.OrgUser = orgUser;
            this.AdminRoleAccounts = adminRoleAccounts;
            this.UserRoleAccounts = userRoleAccounts;
            this.UserName = userName;
            this.UserEnabled = userEnabled;
        }

        /// <summary>
        /// Gets or sets Props.
        /// </summary>
        [JsonProperty("props")]
        public Models.Props18 Props { get; set; }

        /// <summary>
        /// should this user be the org admin of this org, adminRoleAccounts and userRoleAccounts list will be ignored
        /// </summary>
        [JsonProperty("orgAdmin")]
        public bool OrgAdmin { get; set; }

        /// <summary>
        /// should this user be the org user of this org, userRoleAccounts list will be ignored
        /// </summary>
        [JsonProperty("orgUser")]
        public bool OrgUser { get; set; }

        /// <summary>
        /// list of account names that this user will be admin
        /// </summary>
        [JsonProperty("adminRoleAccounts")]
        public List<string> AdminRoleAccounts { get; set; }

        /// <summary>
        /// list of account names that this user will be user
        /// </summary>
        [JsonProperty("userRoleAccounts")]
        public List<string> UserRoleAccounts { get; set; }

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

            return $"WithOrgAccess1 : ({string.Join(", ", toStringOutput)})";
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

            return obj is WithOrgAccess1 other &&
                ((this.Props == null && other.Props == null) || (this.Props?.Equals(other.Props) == true)) &&
                this.OrgAdmin.Equals(other.OrgAdmin) &&
                this.OrgUser.Equals(other.OrgUser) &&
                ((this.AdminRoleAccounts == null && other.AdminRoleAccounts == null) || (this.AdminRoleAccounts?.Equals(other.AdminRoleAccounts) == true)) &&
                ((this.UserRoleAccounts == null && other.UserRoleAccounts == null) || (this.UserRoleAccounts?.Equals(other.UserRoleAccounts) == true)) &&
                ((this.UserName == null && other.UserName == null) || (this.UserName?.Equals(other.UserName) == true)) &&
                this.UserEnabled.Equals(other.UserEnabled);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -145039403;

            if (this.Props != null)
            {
               hashCode += this.Props.GetHashCode();
            }

            hashCode += this.OrgAdmin.GetHashCode();
            hashCode += this.OrgUser.GetHashCode();

            if (this.AdminRoleAccounts != null)
            {
               hashCode += this.AdminRoleAccounts.GetHashCode();
            }

            if (this.UserRoleAccounts != null)
            {
               hashCode += this.UserRoleAccounts.GetHashCode();
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
            toStringOutput.Add($"this.OrgAdmin = {this.OrgAdmin}");
            toStringOutput.Add($"this.OrgUser = {this.OrgUser}");
            toStringOutput.Add($"this.AdminRoleAccounts = {(this.AdminRoleAccounts == null ? "null" : $"[{string.Join(", ", this.AdminRoleAccounts)} ]")}");
            toStringOutput.Add($"this.UserRoleAccounts = {(this.UserRoleAccounts == null ? "null" : $"[{string.Join(", ", this.UserRoleAccounts)} ]")}");
            toStringOutput.Add($"this.UserName = {(this.UserName == null ? "null" : this.UserName == string.Empty ? "" : this.UserName)}");
            toStringOutput.Add($"this.UserEnabled = {this.UserEnabled}");
        }
    }
}