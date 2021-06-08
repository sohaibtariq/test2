// <copyright file="JiraType1Enum.cs" company="APIMatic">
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
    /// JiraType1Enum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum JiraType1Enum
    {
        /// <summary>
        /// JIRASERVER.
        /// </summary>
        [EnumMember(Value = "JIRA_SERVER")]
        JIRASERVER,
    }
}