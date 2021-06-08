// <copyright file="CloudActivities.cs" company="APIMatic">
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
    /// CloudActivities.
    /// </summary>
    public class CloudActivities
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudActivities"/> class.
        /// </summary>
        public CloudActivities()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudActivities"/> class.
        /// </summary>
        /// <param name="startTime">startTime.</param>
        /// <param name="endTime">endTime.</param>
        /// <param name="eventType">eventType.</param>
        /// <param name="eventId">eventId.</param>
        /// <param name="eventModel">eventModel.</param>
        /// <param name="eventActor">eventActor.</param>
        /// <param name="entityMap">entityMap.</param>
        public CloudActivities(
            int? startTime = null,
            int? endTime = null,
            string eventType = null,
            double? eventId = null,
            string eventModel = null,
            string eventActor = null,
            object entityMap = null)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.EventType = eventType;
            this.EventId = eventId;
            this.EventModel = eventModel;
            this.EventActor = eventActor;
            this.EntityMap = entityMap;
        }

        /// <summary>
        /// Gets or sets StartTime.
        /// </summary>
        [JsonProperty("startTime", NullValueHandling = NullValueHandling.Ignore)]
        public int? StartTime { get; set; }

        /// <summary>
        /// Gets or sets EndTime.
        /// </summary>
        [JsonProperty("endTime", NullValueHandling = NullValueHandling.Ignore)]
        public int? EndTime { get; set; }

        /// <summary>
        /// Gets or sets EventType.
        /// </summary>
        [JsonProperty("eventType", NullValueHandling = NullValueHandling.Ignore)]
        public string EventType { get; set; }

        /// <summary>
        /// Gets or sets EventId.
        /// </summary>
        [JsonProperty("eventId", NullValueHandling = NullValueHandling.Ignore)]
        public double? EventId { get; set; }

        /// <summary>
        /// Gets or sets EventModel.
        /// </summary>
        [JsonProperty("eventModel", NullValueHandling = NullValueHandling.Ignore)]
        public string EventModel { get; set; }

        /// <summary>
        /// Gets or sets EventActor.
        /// </summary>
        [JsonProperty("eventActor", NullValueHandling = NullValueHandling.Ignore)]
        public string EventActor { get; set; }

        /// <summary>
        /// Gets or sets EntityMap.
        /// </summary>
        [JsonProperty("entityMap", NullValueHandling = NullValueHandling.Ignore)]
        public object EntityMap { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CloudActivities : ({string.Join(", ", toStringOutput)})";
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

            return obj is CloudActivities other &&
                ((this.StartTime == null && other.StartTime == null) || (this.StartTime?.Equals(other.StartTime) == true)) &&
                ((this.EndTime == null && other.EndTime == null) || (this.EndTime?.Equals(other.EndTime) == true)) &&
                ((this.EventType == null && other.EventType == null) || (this.EventType?.Equals(other.EventType) == true)) &&
                ((this.EventId == null && other.EventId == null) || (this.EventId?.Equals(other.EventId) == true)) &&
                ((this.EventModel == null && other.EventModel == null) || (this.EventModel?.Equals(other.EventModel) == true)) &&
                ((this.EventActor == null && other.EventActor == null) || (this.EventActor?.Equals(other.EventActor) == true)) &&
                ((this.EntityMap == null && other.EntityMap == null) || (this.EntityMap?.Equals(other.EntityMap) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -2056052183;

            if (this.StartTime != null)
            {
               hashCode += this.StartTime.GetHashCode();
            }

            if (this.EndTime != null)
            {
               hashCode += this.EndTime.GetHashCode();
            }

            if (this.EventType != null)
            {
               hashCode += this.EventType.GetHashCode();
            }

            if (this.EventId != null)
            {
               hashCode += this.EventId.GetHashCode();
            }

            if (this.EventModel != null)
            {
               hashCode += this.EventModel.GetHashCode();
            }

            if (this.EventActor != null)
            {
               hashCode += this.EventActor.GetHashCode();
            }

            if (this.EntityMap != null)
            {
               hashCode += this.EntityMap.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.StartTime = {(this.StartTime == null ? "null" : this.StartTime.ToString())}");
            toStringOutput.Add($"this.EndTime = {(this.EndTime == null ? "null" : this.EndTime.ToString())}");
            toStringOutput.Add($"this.EventType = {(this.EventType == null ? "null" : this.EventType == string.Empty ? "" : this.EventType)}");
            toStringOutput.Add($"this.EventId = {(this.EventId == null ? "null" : this.EventId.ToString())}");
            toStringOutput.Add($"this.EventModel = {(this.EventModel == null ? "null" : this.EventModel == string.Empty ? "" : this.EventModel)}");
            toStringOutput.Add($"this.EventActor = {(this.EventActor == null ? "null" : this.EventActor == string.Empty ? "" : this.EventActor)}");
            toStringOutput.Add($"EntityMap = {(this.EntityMap == null ? "null" : this.EntityMap.ToString())}");
        }
    }
}