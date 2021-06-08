// <copyright file="Props18.cs" company="APIMatic">
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
    /// Props18.
    /// </summary>
    public class Props18
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Props18"/> class.
        /// </summary>
        public Props18()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Props18"/> class.
        /// </summary>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="company">company.</param>
        /// <param name="accountAdmin">accountAdmin.</param>
        public Props18(
            string firstName,
            string lastName,
            string company,
            bool? accountAdmin = false)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Company = company;
            this.AccountAdmin = accountAdmin;
        }

        /// <summary>
        /// Gets or sets FirstName.
        /// </summary>
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets LastName.
        /// </summary>
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets Company.
        /// </summary>
        [JsonProperty("company")]
        public string Company { get; set; }

        /// <summary>
        /// should this user be the admin of current account, will be ignore if org-access is true
        /// </summary>
        [JsonProperty("accountAdmin", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AccountAdmin { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Props18 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Props18 other &&
                ((this.FirstName == null && other.FirstName == null) || (this.FirstName?.Equals(other.FirstName) == true)) &&
                ((this.LastName == null && other.LastName == null) || (this.LastName?.Equals(other.LastName) == true)) &&
                ((this.Company == null && other.Company == null) || (this.Company?.Equals(other.Company) == true)) &&
                ((this.AccountAdmin == null && other.AccountAdmin == null) || (this.AccountAdmin?.Equals(other.AccountAdmin) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -1914599108;

            if (this.FirstName != null)
            {
               hashCode += this.FirstName.GetHashCode();
            }

            if (this.LastName != null)
            {
               hashCode += this.LastName.GetHashCode();
            }

            if (this.Company != null)
            {
               hashCode += this.Company.GetHashCode();
            }

            if (this.AccountAdmin != null)
            {
               hashCode += this.AccountAdmin.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FirstName = {(this.FirstName == null ? "null" : this.FirstName == string.Empty ? "" : this.FirstName)}");
            toStringOutput.Add($"this.LastName = {(this.LastName == null ? "null" : this.LastName == string.Empty ? "" : this.LastName)}");
            toStringOutput.Add($"this.Company = {(this.Company == null ? "null" : this.Company == string.Empty ? "" : this.Company)}");
            toStringOutput.Add($"this.AccountAdmin = {(this.AccountAdmin == null ? "null" : this.AccountAdmin.ToString())}");
        }
    }
}