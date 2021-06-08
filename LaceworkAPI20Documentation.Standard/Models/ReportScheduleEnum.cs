// <copyright file="ReportScheduleEnum.cs" company="APIMatic">
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
    /// ReportScheduleEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReportScheduleEnum
    {
        /// <summary>
        /// Enum0000GMT.
        /// </summary>
        [EnumMember(Value = "0000 (GMT)")]
        Enum0000GMT,

        /// <summary>
        /// Enum0100GMT.
        /// </summary>
        [EnumMember(Value = "0100 (GMT)")]
        Enum0100GMT,

        /// <summary>
        /// Enum0200GMT.
        /// </summary>
        [EnumMember(Value = "0200 (GMT)")]
        Enum0200GMT,

        /// <summary>
        /// Enum0300GMT.
        /// </summary>
        [EnumMember(Value = "0300 (GMT)")]
        Enum0300GMT,

        /// <summary>
        /// Enum0400GMT.
        /// </summary>
        [EnumMember(Value = "0400 (GMT)")]
        Enum0400GMT,

        /// <summary>
        /// Enum0500GMT.
        /// </summary>
        [EnumMember(Value = "0500 (GMT)")]
        Enum0500GMT,

        /// <summary>
        /// Enum0600GMT.
        /// </summary>
        [EnumMember(Value = "0600 (GMT)")]
        Enum0600GMT,

        /// <summary>
        /// Enum0700GMT.
        /// </summary>
        [EnumMember(Value = "0700 (GMT)")]
        Enum0700GMT,

        /// <summary>
        /// Enum0800GMT.
        /// </summary>
        [EnumMember(Value = "0800 (GMT)")]
        Enum0800GMT,

        /// <summary>
        /// Enum0900GMT.
        /// </summary>
        [EnumMember(Value = "0900 (GMT)")]
        Enum0900GMT,

        /// <summary>
        /// Enum1000GMT.
        /// </summary>
        [EnumMember(Value = "1000 (GMT)")]
        Enum1000GMT,

        /// <summary>
        /// Enum1100GMT.
        /// </summary>
        [EnumMember(Value = "1100 (GMT)")]
        Enum1100GMT,

        /// <summary>
        /// Enum1200GMT.
        /// </summary>
        [EnumMember(Value = "1200 (GMT)")]
        Enum1200GMT,

        /// <summary>
        /// Enum1300GMT.
        /// </summary>
        [EnumMember(Value = "1300 (GMT)")]
        Enum1300GMT,

        /// <summary>
        /// Enum1400GMT.
        /// </summary>
        [EnumMember(Value = "1400 (GMT)")]
        Enum1400GMT,

        /// <summary>
        /// Enum1500GMT.
        /// </summary>
        [EnumMember(Value = "1500 (GMT)")]
        Enum1500GMT,

        /// <summary>
        /// Enum1600GMT.
        /// </summary>
        [EnumMember(Value = "1600 (GMT)")]
        Enum1600GMT,

        /// <summary>
        /// Enum1700GMT.
        /// </summary>
        [EnumMember(Value = "1700 (GMT)")]
        Enum1700GMT,

        /// <summary>
        /// Enum1800GMT.
        /// </summary>
        [EnumMember(Value = "1800 (GMT)")]
        Enum1800GMT,

        /// <summary>
        /// Enum1900GMT.
        /// </summary>
        [EnumMember(Value = "1900 (GMT)")]
        Enum1900GMT,

        /// <summary>
        /// Enum2000GMT.
        /// </summary>
        [EnumMember(Value = "2000 (GMT)")]
        Enum2000GMT,

        /// <summary>
        /// Enum2100GMT.
        /// </summary>
        [EnumMember(Value = "2100 (GMT)")]
        Enum2100GMT,

        /// <summary>
        /// Enum2200GMT.
        /// </summary>
        [EnumMember(Value = "2200 (GMT)")]
        Enum2200GMT,

        /// <summary>
        /// Enum2300GMT.
        /// </summary>
        [EnumMember(Value = "2300 (GMT)")]
        Enum2300GMT,
    }
}