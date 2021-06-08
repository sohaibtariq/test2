// <copyright file="ContVulnCfg1Enum.cs" company="APIMatic">
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
    /// ContVulnCfg1Enum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ContVulnCfg1Enum
    {
        /// <summary>
        /// AWSECR.
        /// </summary>
        [EnumMember(Value = "AWS_ECR")]
        AWSECR,

        /// <summary>
        /// DOCKERHUB.
        /// </summary>
        [EnumMember(Value = "DOCKERHUB")]
        DOCKERHUB,

        /// <summary>
        /// GCPGCR.
        /// </summary>
        [EnumMember(Value = "GCP_GCR")]
        GCPGCR,

        /// <summary>
        /// GHCR.
        /// </summary>
        [EnumMember(Value = "GHCR")]
        GHCR,

        /// <summary>
        /// INLINESCANNER.
        /// </summary>
        [EnumMember(Value = "INLINE_SCANNER")]
        INLINESCANNER,

        /// <summary>
        /// PROXYSCANNER.
        /// </summary>
        [EnumMember(Value = "PROXY_SCANNER")]
        PROXYSCANNER,

        /// <summary>
        /// V2REGISTRY.
        /// </summary>
        [EnumMember(Value = "V2_REGISTRY")]
        V2REGISTRY,
    }
}