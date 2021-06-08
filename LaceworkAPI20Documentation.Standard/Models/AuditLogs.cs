// <copyright file="AuditLogs.cs" company="APIMatic">
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
    /// AuditLogs.
    /// </summary>
    public class AuditLogs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogs"/> class.
        /// </summary>
        public AuditLogs()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogs"/> class.
        /// </summary>
        /// <param name="createdTime">createdTime.</param>
        /// <param name="accountName">accountName.</param>
        /// <param name="userName">userName.</param>
        /// <param name="eventName">eventName.</param>
        /// <param name="userAction">userAction.</param>
        /// <param name="eventDescription">eventDescription.</param>
        public AuditLogs(
            int? createdTime = null,
            string accountName = null,
            string userName = null,
            string eventName = null,
            string userAction = null,
            string eventDescription = null)
        {
            this.CreatedTime = createdTime;
            this.AccountName = accountName;
            this.UserName = userName;
            this.EventName = eventName;
            this.UserAction = userAction;
            this.EventDescription = eventDescription;
        }

        /// <summary>
        /// Gets or sets CreatedTime.
        /// </summary>
        [JsonProperty("createdTime", NullValueHandling = NullValueHandling.Ignore)]
        public int? CreatedTime { get; set; }

        /// <summary>
        /// Gets or sets AccountName.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets UserName.
        /// </summary>
        [JsonProperty("userName", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets EventName.
        /// </summary>
        [JsonProperty("eventName", NullValueHandling = NullValueHandling.Ignore)]
        public string EventName { get; set; }

        /// <summary>
        /// Gets or sets UserAction.
        /// </summary>
        [JsonProperty("userAction", NullValueHandling = NullValueHandling.Ignore)]
        public string UserAction { get; set; }

        /// <summary>
        /// Gets or sets EventDescription.
        /// </summary>
        [JsonProperty("eventDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string EventDescription { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AuditLogs : ({string.Join(", ", toStringOutput)})";
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

            return obj is AuditLogs other &&
                ((this.CreatedTime == null && other.CreatedTime == null) || (this.CreatedTime?.Equals(other.CreatedTime) == true)) &&
                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.UserName == null && other.UserName == null) || (this.UserName?.Equals(other.UserName) == true)) &&
                ((this.EventName == null && other.EventName == null) || (this.EventName?.Equals(other.EventName) == true)) &&
                ((this.UserAction == null && other.UserAction == null) || (this.UserAction?.Equals(other.UserAction) == true)) &&
                ((this.EventDescription == null && other.EventDescription == null) || (this.EventDescription?.Equals(other.EventDescription) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 866539666;

            if (this.CreatedTime != null)
            {
               hashCode += this.CreatedTime.GetHashCode();
            }

            if (this.AccountName != null)
            {
               hashCode += this.AccountName.GetHashCode();
            }

            if (this.UserName != null)
            {
               hashCode += this.UserName.GetHashCode();
            }

            if (this.EventName != null)
            {
               hashCode += this.EventName.GetHashCode();
            }

            if (this.UserAction != null)
            {
               hashCode += this.UserAction.GetHashCode();
            }

            if (this.EventDescription != null)
            {
               hashCode += this.EventDescription.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CreatedTime = {(this.CreatedTime == null ? "null" : this.CreatedTime.ToString())}");
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName == string.Empty ? "" : this.AccountName)}");
            toStringOutput.Add($"this.UserName = {(this.UserName == null ? "null" : this.UserName == string.Empty ? "" : this.UserName)}");
            toStringOutput.Add($"this.EventName = {(this.EventName == null ? "null" : this.EventName == string.Empty ? "" : this.EventName)}");
            toStringOutput.Add($"this.UserAction = {(this.UserAction == null ? "null" : this.UserAction == string.Empty ? "" : this.UserAction)}");
            toStringOutput.Add($"this.EventDescription = {(this.EventDescription == null ? "null" : this.EventDescription == string.Empty ? "" : this.EventDescription)}");
        }
    }
}