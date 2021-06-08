// <copyright file="WithOrgAccess2.cs" company="APIMatic">
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
    /// WithOrgAccess2.
    /// </summary>
    public class WithOrgAccess2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WithOrgAccess2"/> class.
        /// </summary>
        public WithOrgAccess2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WithOrgAccess2"/> class.
        /// </summary>
        /// <param name="props">props.</param>
        /// <param name="orgAdmin">orgAdmin.</param>
        /// <param name="orgUser">orgUser.</param>
        /// <param name="adminRoleAccounts">adminRoleAccounts.</param>
        /// <param name="userRoleAccounts">userRoleAccounts.</param>
        /// <param name="userEnabled">userEnabled.</param>
        public WithOrgAccess2(
            Models.Props22 props = null,
            bool? orgAdmin = false,
            bool? orgUser = false,
            List<string> adminRoleAccounts = null,
            List<string> userRoleAccounts = null,
            Models.UserEnabledEnum? userEnabled = null)
        {
            this.Props = props;
            this.OrgAdmin = orgAdmin;
            this.OrgUser = orgUser;
            this.AdminRoleAccounts = adminRoleAccounts;
            this.UserRoleAccounts = userRoleAccounts;
            this.UserEnabled = userEnabled;
        }

        /// <summary>
        /// Gets or sets Props.
        /// </summary>
        [JsonProperty("props", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Props22 Props { get; set; }

        /// <summary>
        /// should this user be the org admin of this org, adminRoleAccounts and userRoleAccounts list will be ignored
        /// </summary>
        [JsonProperty("orgAdmin", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OrgAdmin { get; set; }

        /// <summary>
        /// should this user be the org user of this org, userRoleAccounts list will be ignored
        /// </summary>
        [JsonProperty("orgUser", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OrgUser { get; set; }

        /// <summary>
        /// list of account names that this user will be admin
        /// </summary>
        [JsonProperty("adminRoleAccounts", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AdminRoleAccounts { get; set; }

        /// <summary>
        /// list of account names that this user will be user
        /// </summary>
        [JsonProperty("userRoleAccounts", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UserRoleAccounts { get; set; }

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

            return $"WithOrgAccess2 : ({string.Join(", ", toStringOutput)})";
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

            return obj is WithOrgAccess2 other &&
                ((this.Props == null && other.Props == null) || (this.Props?.Equals(other.Props) == true)) &&
                ((this.OrgAdmin == null && other.OrgAdmin == null) || (this.OrgAdmin?.Equals(other.OrgAdmin) == true)) &&
                ((this.OrgUser == null && other.OrgUser == null) || (this.OrgUser?.Equals(other.OrgUser) == true)) &&
                ((this.AdminRoleAccounts == null && other.AdminRoleAccounts == null) || (this.AdminRoleAccounts?.Equals(other.AdminRoleAccounts) == true)) &&
                ((this.UserRoleAccounts == null && other.UserRoleAccounts == null) || (this.UserRoleAccounts?.Equals(other.UserRoleAccounts) == true)) &&
                ((this.UserEnabled == null && other.UserEnabled == null) || (this.UserEnabled?.Equals(other.UserEnabled) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -1163276051;

            if (this.Props != null)
            {
               hashCode += this.Props.GetHashCode();
            }

            if (this.OrgAdmin != null)
            {
               hashCode += this.OrgAdmin.GetHashCode();
            }

            if (this.OrgUser != null)
            {
               hashCode += this.OrgUser.GetHashCode();
            }

            if (this.AdminRoleAccounts != null)
            {
               hashCode += this.AdminRoleAccounts.GetHashCode();
            }

            if (this.UserRoleAccounts != null)
            {
               hashCode += this.UserRoleAccounts.GetHashCode();
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
            toStringOutput.Add($"this.Props = {(this.Props == null ? "null" : this.Props.ToString())}");
            toStringOutput.Add($"this.OrgAdmin = {(this.OrgAdmin == null ? "null" : this.OrgAdmin.ToString())}");
            toStringOutput.Add($"this.OrgUser = {(this.OrgUser == null ? "null" : this.OrgUser.ToString())}");
            toStringOutput.Add($"this.AdminRoleAccounts = {(this.AdminRoleAccounts == null ? "null" : $"[{string.Join(", ", this.AdminRoleAccounts)} ]")}");
            toStringOutput.Add($"this.UserRoleAccounts = {(this.UserRoleAccounts == null ? "null" : $"[{string.Join(", ", this.UserRoleAccounts)} ]")}");
            toStringOutput.Add($"this.UserEnabled = {(this.UserEnabled == null ? "null" : this.UserEnabled.ToString())}");
        }
    }
}