// <copyright file="ReportNotificationTypes.cs" company="APIMatic">
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
    /// ReportNotificationTypes.
    /// </summary>
    public class ReportNotificationTypes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportNotificationTypes"/> class.
        /// </summary>
        public ReportNotificationTypes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportNotificationTypes"/> class.
        /// </summary>
        /// <param name="agentEvents">agentEvents.</param>
        /// <param name="awsCisS3">awsCisS3.</param>
        /// <param name="awsCloudtrailEvents">awsCloudtrailEvents.</param>
        /// <param name="awsComplianceEvents">awsComplianceEvents.</param>
        /// <param name="azureActivityLogEvents">azureActivityLogEvents.</param>
        /// <param name="azureCis">azureCis.</param>
        /// <param name="azureComplianceEvents">azureComplianceEvents.</param>
        /// <param name="azurePci">azurePci.</param>
        /// <param name="azureSoc">azureSoc.</param>
        /// <param name="gcpAuditTrailEvents">gcpAuditTrailEvents.</param>
        /// <param name="gcpCis">gcpCis.</param>
        /// <param name="gcpComplianceEvents">gcpComplianceEvents.</param>
        /// <param name="gcpPci">gcpPci.</param>
        /// <param name="gcpSoc">gcpSoc.</param>
        /// <param name="hipaa">hipaa.</param>
        /// <param name="iso2700">iso2700.</param>
        /// <param name="nist80053Rev4">nist800-53Rev4.</param>
        /// <param name="nist800171Rev2">nist800-171Rev2.</param>
        /// <param name="openShiftCompliance">openShiftCompliance.</param>
        /// <param name="openShiftComplianceEvents">openShiftComplianceEvents.</param>
        /// <param name="pci">pci.</param>
        /// <param name="soc">soc.</param>
        /// <param name="awsSocRev2">awsSocRev2.</param>
        /// <param name="trendReport">trendReport.</param>
        public ReportNotificationTypes(
            bool? agentEvents = null,
            bool? awsCisS3 = null,
            bool? awsCloudtrailEvents = null,
            bool? awsComplianceEvents = null,
            bool? azureActivityLogEvents = null,
            bool? azureCis = null,
            bool? azureComplianceEvents = null,
            bool? azurePci = null,
            bool? azureSoc = null,
            bool? gcpAuditTrailEvents = null,
            bool? gcpCis = null,
            bool? gcpComplianceEvents = null,
            bool? gcpPci = null,
            bool? gcpSoc = null,
            bool? hipaa = null,
            bool? iso2700 = null,
            bool? nist80053Rev4 = null,
            bool? nist800171Rev2 = null,
            bool? openShiftCompliance = null,
            bool? openShiftComplianceEvents = null,
            bool? pci = null,
            bool? soc = null,
            bool? awsSocRev2 = null,
            bool? trendReport = null)
        {
            this.AgentEvents = agentEvents;
            this.AwsCisS3 = awsCisS3;
            this.AwsCloudtrailEvents = awsCloudtrailEvents;
            this.AwsComplianceEvents = awsComplianceEvents;
            this.AzureActivityLogEvents = azureActivityLogEvents;
            this.AzureCis = azureCis;
            this.AzureComplianceEvents = azureComplianceEvents;
            this.AzurePci = azurePci;
            this.AzureSoc = azureSoc;
            this.GcpAuditTrailEvents = gcpAuditTrailEvents;
            this.GcpCis = gcpCis;
            this.GcpComplianceEvents = gcpComplianceEvents;
            this.GcpPci = gcpPci;
            this.GcpSoc = gcpSoc;
            this.Hipaa = hipaa;
            this.Iso2700 = iso2700;
            this.Nist80053Rev4 = nist80053Rev4;
            this.Nist800171Rev2 = nist800171Rev2;
            this.OpenShiftCompliance = openShiftCompliance;
            this.OpenShiftComplianceEvents = openShiftComplianceEvents;
            this.Pci = pci;
            this.Soc = soc;
            this.AwsSocRev2 = awsSocRev2;
            this.TrendReport = trendReport;
        }

        /// <summary>
        /// Gets or sets AgentEvents.
        /// </summary>
        [JsonProperty("agentEvents", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AgentEvents { get; set; }

        /// <summary>
        /// Gets or sets AwsCisS3.
        /// </summary>
        [JsonProperty("awsCisS3", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AwsCisS3 { get; set; }

        /// <summary>
        /// Gets or sets AwsCloudtrailEvents.
        /// </summary>
        [JsonProperty("awsCloudtrailEvents", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AwsCloudtrailEvents { get; set; }

        /// <summary>
        /// Gets or sets AwsComplianceEvents.
        /// </summary>
        [JsonProperty("awsComplianceEvents", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AwsComplianceEvents { get; set; }

        /// <summary>
        /// Gets or sets AzureActivityLogEvents.
        /// </summary>
        [JsonProperty("azureActivityLogEvents", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AzureActivityLogEvents { get; set; }

        /// <summary>
        /// Gets or sets AzureCis.
        /// </summary>
        [JsonProperty("azureCis", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AzureCis { get; set; }

        /// <summary>
        /// Gets or sets AzureComplianceEvents.
        /// </summary>
        [JsonProperty("azureComplianceEvents", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AzureComplianceEvents { get; set; }

        /// <summary>
        /// Gets or sets AzurePci.
        /// </summary>
        [JsonProperty("azurePci", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AzurePci { get; set; }

        /// <summary>
        /// Gets or sets AzureSoc.
        /// </summary>
        [JsonProperty("azureSoc", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AzureSoc { get; set; }

        /// <summary>
        /// Gets or sets GcpAuditTrailEvents.
        /// </summary>
        [JsonProperty("gcpAuditTrailEvents", NullValueHandling = NullValueHandling.Ignore)]
        public bool? GcpAuditTrailEvents { get; set; }

        /// <summary>
        /// Gets or sets GcpCis.
        /// </summary>
        [JsonProperty("gcpCis", NullValueHandling = NullValueHandling.Ignore)]
        public bool? GcpCis { get; set; }

        /// <summary>
        /// Gets or sets GcpComplianceEvents.
        /// </summary>
        [JsonProperty("gcpComplianceEvents", NullValueHandling = NullValueHandling.Ignore)]
        public bool? GcpComplianceEvents { get; set; }

        /// <summary>
        /// Gets or sets GcpPci.
        /// </summary>
        [JsonProperty("gcpPci", NullValueHandling = NullValueHandling.Ignore)]
        public bool? GcpPci { get; set; }

        /// <summary>
        /// Gets or sets GcpSoc.
        /// </summary>
        [JsonProperty("gcpSoc", NullValueHandling = NullValueHandling.Ignore)]
        public bool? GcpSoc { get; set; }

        /// <summary>
        /// Gets or sets Hipaa.
        /// </summary>
        [JsonProperty("hipaa", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hipaa { get; set; }

        /// <summary>
        /// Gets or sets Iso2700.
        /// </summary>
        [JsonProperty("iso2700", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Iso2700 { get; set; }

        /// <summary>
        /// Gets or sets Nist80053Rev4.
        /// </summary>
        [JsonProperty("nist800-53Rev4", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Nist80053Rev4 { get; set; }

        /// <summary>
        /// Gets or sets Nist800171Rev2.
        /// </summary>
        [JsonProperty("nist800-171Rev2", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Nist800171Rev2 { get; set; }

        /// <summary>
        /// Gets or sets OpenShiftCompliance.
        /// </summary>
        [JsonProperty("openShiftCompliance", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OpenShiftCompliance { get; set; }

        /// <summary>
        /// Gets or sets OpenShiftComplianceEvents.
        /// </summary>
        [JsonProperty("openShiftComplianceEvents", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OpenShiftComplianceEvents { get; set; }

        /// <summary>
        /// Gets or sets Pci.
        /// </summary>
        [JsonProperty("pci", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Pci { get; set; }

        /// <summary>
        /// Gets or sets Soc.
        /// </summary>
        [JsonProperty("soc", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Soc { get; set; }

        /// <summary>
        /// Gets or sets AwsSocRev2.
        /// </summary>
        [JsonProperty("awsSocRev2", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AwsSocRev2 { get; set; }

        /// <summary>
        /// Gets or sets TrendReport.
        /// </summary>
        [JsonProperty("trendReport", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TrendReport { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ReportNotificationTypes : ({string.Join(", ", toStringOutput)})";
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

            return obj is ReportNotificationTypes other &&
                ((this.AgentEvents == null && other.AgentEvents == null) || (this.AgentEvents?.Equals(other.AgentEvents) == true)) &&
                ((this.AwsCisS3 == null && other.AwsCisS3 == null) || (this.AwsCisS3?.Equals(other.AwsCisS3) == true)) &&
                ((this.AwsCloudtrailEvents == null && other.AwsCloudtrailEvents == null) || (this.AwsCloudtrailEvents?.Equals(other.AwsCloudtrailEvents) == true)) &&
                ((this.AwsComplianceEvents == null && other.AwsComplianceEvents == null) || (this.AwsComplianceEvents?.Equals(other.AwsComplianceEvents) == true)) &&
                ((this.AzureActivityLogEvents == null && other.AzureActivityLogEvents == null) || (this.AzureActivityLogEvents?.Equals(other.AzureActivityLogEvents) == true)) &&
                ((this.AzureCis == null && other.AzureCis == null) || (this.AzureCis?.Equals(other.AzureCis) == true)) &&
                ((this.AzureComplianceEvents == null && other.AzureComplianceEvents == null) || (this.AzureComplianceEvents?.Equals(other.AzureComplianceEvents) == true)) &&
                ((this.AzurePci == null && other.AzurePci == null) || (this.AzurePci?.Equals(other.AzurePci) == true)) &&
                ((this.AzureSoc == null && other.AzureSoc == null) || (this.AzureSoc?.Equals(other.AzureSoc) == true)) &&
                ((this.GcpAuditTrailEvents == null && other.GcpAuditTrailEvents == null) || (this.GcpAuditTrailEvents?.Equals(other.GcpAuditTrailEvents) == true)) &&
                ((this.GcpCis == null && other.GcpCis == null) || (this.GcpCis?.Equals(other.GcpCis) == true)) &&
                ((this.GcpComplianceEvents == null && other.GcpComplianceEvents == null) || (this.GcpComplianceEvents?.Equals(other.GcpComplianceEvents) == true)) &&
                ((this.GcpPci == null && other.GcpPci == null) || (this.GcpPci?.Equals(other.GcpPci) == true)) &&
                ((this.GcpSoc == null && other.GcpSoc == null) || (this.GcpSoc?.Equals(other.GcpSoc) == true)) &&
                ((this.Hipaa == null && other.Hipaa == null) || (this.Hipaa?.Equals(other.Hipaa) == true)) &&
                ((this.Iso2700 == null && other.Iso2700 == null) || (this.Iso2700?.Equals(other.Iso2700) == true)) &&
                ((this.Nist80053Rev4 == null && other.Nist80053Rev4 == null) || (this.Nist80053Rev4?.Equals(other.Nist80053Rev4) == true)) &&
                ((this.Nist800171Rev2 == null && other.Nist800171Rev2 == null) || (this.Nist800171Rev2?.Equals(other.Nist800171Rev2) == true)) &&
                ((this.OpenShiftCompliance == null && other.OpenShiftCompliance == null) || (this.OpenShiftCompliance?.Equals(other.OpenShiftCompliance) == true)) &&
                ((this.OpenShiftComplianceEvents == null && other.OpenShiftComplianceEvents == null) || (this.OpenShiftComplianceEvents?.Equals(other.OpenShiftComplianceEvents) == true)) &&
                ((this.Pci == null && other.Pci == null) || (this.Pci?.Equals(other.Pci) == true)) &&
                ((this.Soc == null && other.Soc == null) || (this.Soc?.Equals(other.Soc) == true)) &&
                ((this.AwsSocRev2 == null && other.AwsSocRev2 == null) || (this.AwsSocRev2?.Equals(other.AwsSocRev2) == true)) &&
                ((this.TrendReport == null && other.TrendReport == null) || (this.TrendReport?.Equals(other.TrendReport) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 608277429;

            if (this.AgentEvents != null)
            {
               hashCode += this.AgentEvents.GetHashCode();
            }

            if (this.AwsCisS3 != null)
            {
               hashCode += this.AwsCisS3.GetHashCode();
            }

            if (this.AwsCloudtrailEvents != null)
            {
               hashCode += this.AwsCloudtrailEvents.GetHashCode();
            }

            if (this.AwsComplianceEvents != null)
            {
               hashCode += this.AwsComplianceEvents.GetHashCode();
            }

            if (this.AzureActivityLogEvents != null)
            {
               hashCode += this.AzureActivityLogEvents.GetHashCode();
            }

            if (this.AzureCis != null)
            {
               hashCode += this.AzureCis.GetHashCode();
            }

            if (this.AzureComplianceEvents != null)
            {
               hashCode += this.AzureComplianceEvents.GetHashCode();
            }

            if (this.AzurePci != null)
            {
               hashCode += this.AzurePci.GetHashCode();
            }

            if (this.AzureSoc != null)
            {
               hashCode += this.AzureSoc.GetHashCode();
            }

            if (this.GcpAuditTrailEvents != null)
            {
               hashCode += this.GcpAuditTrailEvents.GetHashCode();
            }

            if (this.GcpCis != null)
            {
               hashCode += this.GcpCis.GetHashCode();
            }

            if (this.GcpComplianceEvents != null)
            {
               hashCode += this.GcpComplianceEvents.GetHashCode();
            }

            if (this.GcpPci != null)
            {
               hashCode += this.GcpPci.GetHashCode();
            }

            if (this.GcpSoc != null)
            {
               hashCode += this.GcpSoc.GetHashCode();
            }

            if (this.Hipaa != null)
            {
               hashCode += this.Hipaa.GetHashCode();
            }

            if (this.Iso2700 != null)
            {
               hashCode += this.Iso2700.GetHashCode();
            }

            if (this.Nist80053Rev4 != null)
            {
               hashCode += this.Nist80053Rev4.GetHashCode();
            }

            if (this.Nist800171Rev2 != null)
            {
               hashCode += this.Nist800171Rev2.GetHashCode();
            }

            if (this.OpenShiftCompliance != null)
            {
               hashCode += this.OpenShiftCompliance.GetHashCode();
            }

            if (this.OpenShiftComplianceEvents != null)
            {
               hashCode += this.OpenShiftComplianceEvents.GetHashCode();
            }

            if (this.Pci != null)
            {
               hashCode += this.Pci.GetHashCode();
            }

            if (this.Soc != null)
            {
               hashCode += this.Soc.GetHashCode();
            }

            if (this.AwsSocRev2 != null)
            {
               hashCode += this.AwsSocRev2.GetHashCode();
            }

            if (this.TrendReport != null)
            {
               hashCode += this.TrendReport.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AgentEvents = {(this.AgentEvents == null ? "null" : this.AgentEvents.ToString())}");
            toStringOutput.Add($"this.AwsCisS3 = {(this.AwsCisS3 == null ? "null" : this.AwsCisS3.ToString())}");
            toStringOutput.Add($"this.AwsCloudtrailEvents = {(this.AwsCloudtrailEvents == null ? "null" : this.AwsCloudtrailEvents.ToString())}");
            toStringOutput.Add($"this.AwsComplianceEvents = {(this.AwsComplianceEvents == null ? "null" : this.AwsComplianceEvents.ToString())}");
            toStringOutput.Add($"this.AzureActivityLogEvents = {(this.AzureActivityLogEvents == null ? "null" : this.AzureActivityLogEvents.ToString())}");
            toStringOutput.Add($"this.AzureCis = {(this.AzureCis == null ? "null" : this.AzureCis.ToString())}");
            toStringOutput.Add($"this.AzureComplianceEvents = {(this.AzureComplianceEvents == null ? "null" : this.AzureComplianceEvents.ToString())}");
            toStringOutput.Add($"this.AzurePci = {(this.AzurePci == null ? "null" : this.AzurePci.ToString())}");
            toStringOutput.Add($"this.AzureSoc = {(this.AzureSoc == null ? "null" : this.AzureSoc.ToString())}");
            toStringOutput.Add($"this.GcpAuditTrailEvents = {(this.GcpAuditTrailEvents == null ? "null" : this.GcpAuditTrailEvents.ToString())}");
            toStringOutput.Add($"this.GcpCis = {(this.GcpCis == null ? "null" : this.GcpCis.ToString())}");
            toStringOutput.Add($"this.GcpComplianceEvents = {(this.GcpComplianceEvents == null ? "null" : this.GcpComplianceEvents.ToString())}");
            toStringOutput.Add($"this.GcpPci = {(this.GcpPci == null ? "null" : this.GcpPci.ToString())}");
            toStringOutput.Add($"this.GcpSoc = {(this.GcpSoc == null ? "null" : this.GcpSoc.ToString())}");
            toStringOutput.Add($"this.Hipaa = {(this.Hipaa == null ? "null" : this.Hipaa.ToString())}");
            toStringOutput.Add($"this.Iso2700 = {(this.Iso2700 == null ? "null" : this.Iso2700.ToString())}");
            toStringOutput.Add($"this.Nist80053Rev4 = {(this.Nist80053Rev4 == null ? "null" : this.Nist80053Rev4.ToString())}");
            toStringOutput.Add($"this.Nist800171Rev2 = {(this.Nist800171Rev2 == null ? "null" : this.Nist800171Rev2.ToString())}");
            toStringOutput.Add($"this.OpenShiftCompliance = {(this.OpenShiftCompliance == null ? "null" : this.OpenShiftCompliance.ToString())}");
            toStringOutput.Add($"this.OpenShiftComplianceEvents = {(this.OpenShiftComplianceEvents == null ? "null" : this.OpenShiftComplianceEvents.ToString())}");
            toStringOutput.Add($"this.Pci = {(this.Pci == null ? "null" : this.Pci.ToString())}");
            toStringOutput.Add($"this.Soc = {(this.Soc == null ? "null" : this.Soc.ToString())}");
            toStringOutput.Add($"this.AwsSocRev2 = {(this.AwsSocRev2 == null ? "null" : this.AwsSocRev2.ToString())}");
            toStringOutput.Add($"this.TrendReport = {(this.TrendReport == null ? "null" : this.TrendReport.ToString())}");
        }
    }
}