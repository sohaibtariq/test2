// <copyright file="DatadogServiceEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace LaceworkAPI20Documentation.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using LaceworkAPI20Documentation.Standard;
    using LaceworkAPI20Documentation.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// DatadogServiceEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DatadogServiceEnum
    {
        /// <summary>
        /// EnumLogsDetail.
        /// </summary>
        [EnumMember(Value = "Logs Detail")]
        EnumLogsDetail,

        /// <summary>
        /// EnumLogsSummary.
        /// </summary>
        [EnumMember(Value = "Logs Summary")]
        EnumLogsSummary,

        /// <summary>
        /// EnumEventsSummary.
        /// </summary>
        [EnumMember(Value = "Events Summary")]
        EnumEventsSummary,
    }
}