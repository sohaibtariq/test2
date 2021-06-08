// <copyright file="Type1Enum.cs" company="APIMatic">
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
    /// Type1Enum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type1Enum
    {
        /// <summary>
        /// AwsCfg.
        /// </summary>
        [EnumMember(Value = "AwsCfg")]
        AwsCfg,

        /// <summary>
        /// AwsCtSqs.
        /// </summary>
        [EnumMember(Value = "AwsCtSqs")]
        AwsCtSqs,

        /// <summary>
        /// AwsUsGovCfg.
        /// </summary>
        [EnumMember(Value = "AwsUsGovCfg")]
        AwsUsGovCfg,

        /// <summary>
        /// AwsUsGovCtSqs.
        /// </summary>
        [EnumMember(Value = "AwsUsGovCtSqs")]
        AwsUsGovCtSqs,

        /// <summary>
        /// AzureAlSeq.
        /// </summary>
        [EnumMember(Value = "AzureAlSeq")]
        AzureAlSeq,

        /// <summary>
        /// AzureCfg.
        /// </summary>
        [EnumMember(Value = "AzureCfg")]
        AzureCfg,

        /// <summary>
        /// GcpAtSes.
        /// </summary>
        [EnumMember(Value = "GcpAtSes")]
        GcpAtSes,

        /// <summary>
        /// GcpCfg.
        /// </summary>
        [EnumMember(Value = "GcpCfg")]
        GcpCfg,
    }
}