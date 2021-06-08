// <copyright file="EventCategoryEnum.cs" company="APIMatic">
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
    /// EventCategoryEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EventCategoryEnum
    {
        /// <summary>
        /// Compliance.
        /// </summary>
        [EnumMember(Value = "Compliance")]
        Compliance,

        /// <summary>
        /// App.
        /// </summary>
        [EnumMember(Value = "App")]
        App,

        /// <summary>
        /// Cloud.
        /// </summary>
        [EnumMember(Value = "Cloud")]
        Cloud,

        /// <summary>
        /// File.
        /// </summary>
        [EnumMember(Value = "File")]
        File,

        /// <summary>
        /// Machine.
        /// </summary>
        [EnumMember(Value = "Machine")]
        Machine,

        /// <summary>
        /// User.
        /// </summary>
        [EnumMember(Value = "User")]
        User,
    }
}