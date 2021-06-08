// <copyright file="TypeEnum.cs" company="APIMatic">
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
    /// TypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TypeEnum
    {
        /// <summary>
        /// AwsS3.
        /// </summary>
        [EnumMember(Value = "AwsS3")]
        AwsS3,

        /// <summary>
        /// CiscoSparkWebhook.
        /// </summary>
        [EnumMember(Value = "CiscoSparkWebhook")]
        CiscoSparkWebhook,

        /// <summary>
        /// CloudwatchEb.
        /// </summary>
        [EnumMember(Value = "CloudwatchEb")]
        CloudwatchEb,

        /// <summary>
        /// Datadog.
        /// </summary>
        [EnumMember(Value = "Datadog")]
        Datadog,

        /// <summary>
        /// EmailUser.
        /// </summary>
        [EnumMember(Value = "EmailUser")]
        EmailUser,

        /// <summary>
        /// GcpPubsub.
        /// </summary>
        [EnumMember(Value = "GcpPubsub")]
        GcpPubsub,

        /// <summary>
        /// IbmQradar.
        /// </summary>
        [EnumMember(Value = "IbmQradar")]
        IbmQradar,

        /// <summary>
        /// Jira.
        /// </summary>
        [EnumMember(Value = "Jira")]
        Jira,

        /// <summary>
        /// MicrosoftTeams.
        /// </summary>
        [EnumMember(Value = "MicrosoftTeams")]
        MicrosoftTeams,

        /// <summary>
        /// NewRelicInsights.
        /// </summary>
        [EnumMember(Value = "NewRelicInsights")]
        NewRelicInsights,

        /// <summary>
        /// PagerDutyApi.
        /// </summary>
        [EnumMember(Value = "PagerDutyApi")]
        PagerDutyApi,

        /// <summary>
        /// ServiceNowRest.
        /// </summary>
        [EnumMember(Value = "ServiceNowRest")]
        ServiceNowRest,

        /// <summary>
        /// SlackChannel.
        /// </summary>
        [EnumMember(Value = "SlackChannel")]
        SlackChannel,

        /// <summary>
        /// SplunkHec.
        /// </summary>
        [EnumMember(Value = "SplunkHec")]
        SplunkHec,

        /// <summary>
        /// VictorOps.
        /// </summary>
        [EnumMember(Value = "VictorOps")]
        VictorOps,

        /// <summary>
        /// Webhook.
        /// </summary>
        [EnumMember(Value = "Webhook")]
        Webhook,
    }
}