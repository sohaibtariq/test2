// <copyright file="ExpressionEnum.cs" company="APIMatic">
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
    /// ExpressionEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExpressionEnum
    {
        /// <summary>
        /// Eq.
        /// </summary>
        [EnumMember(Value = "eq")]
        Eq,

        /// <summary>
        /// Ne.
        /// </summary>
        [EnumMember(Value = "ne")]
        Ne,

        /// <summary>
        /// In.
        /// </summary>
        [EnumMember(Value = "in")]
        In,

        /// <summary>
        /// NotIn.
        /// </summary>
        [EnumMember(Value = "not_in")]
        NotIn,

        /// <summary>
        /// Like.
        /// </summary>
        [EnumMember(Value = "like")]
        Like,

        /// <summary>
        /// Ilike.
        /// </summary>
        [EnumMember(Value = "ilike")]
        Ilike,

        /// <summary>
        /// NotLike.
        /// </summary>
        [EnumMember(Value = "not_like")]
        NotLike,

        /// <summary>
        /// NotIlike.
        /// </summary>
        [EnumMember(Value = "not_ilike")]
        NotIlike,

        /// <summary>
        /// NotRlike.
        /// </summary>
        [EnumMember(Value = "not_rlike")]
        NotRlike,

        /// <summary>
        /// Rlike.
        /// </summary>
        [EnumMember(Value = "rlike")]
        Rlike,

        /// <summary>
        /// Gt.
        /// </summary>
        [EnumMember(Value = "gt")]
        Gt,

        /// <summary>
        /// Ge.
        /// </summary>
        [EnumMember(Value = "ge")]
        Ge,

        /// <summary>
        /// Lt.
        /// </summary>
        [EnumMember(Value = "lt")]
        Lt,

        /// <summary>
        /// Le.
        /// </summary>
        [EnumMember(Value = "le")]
        Le,

        /// <summary>
        /// Between.
        /// </summary>
        [EnumMember(Value = "between")]
        Between,
    }
}