// <copyright file="RegistryDomainEnum.cs" company="APIMatic">
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
    /// RegistryDomainEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RegistryDomainEnum
    {
        /// <summary>
        /// EnumGcrio.
        /// </summary>
        [EnumMember(Value = "gcr.io")]
        EnumGcrio,

        /// <summary>
        /// EnumUsgcrio.
        /// </summary>
        [EnumMember(Value = "us.gcr.io")]
        EnumUsgcrio,

        /// <summary>
        /// EnumEugcrio.
        /// </summary>
        [EnumMember(Value = "eu.gcr.io")]
        EnumEugcrio,

        /// <summary>
        /// EnumAsiagcrio.
        /// </summary>
        [EnumMember(Value = "asia.gcr.io")]
        EnumAsiagcrio,
    }
}