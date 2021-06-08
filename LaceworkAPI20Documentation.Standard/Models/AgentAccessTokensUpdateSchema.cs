// <copyright file="AgentAccessTokensUpdateSchema.cs" company="APIMatic">
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
    /// AgentAccessTokensUpdateSchema.
    /// </summary>
    public class AgentAccessTokensUpdateSchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAccessTokensUpdateSchema"/> class.
        /// </summary>
        public AgentAccessTokensUpdateSchema()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAccessTokensUpdateSchema"/> class.
        /// </summary>
        /// <param name="tokenEnabled">tokenEnabled.</param>
        public AgentAccessTokensUpdateSchema(
            string tokenEnabled = null)
        {
            this.TokenEnabled = tokenEnabled;
        }

        /// <summary>
        /// Gets or sets TokenEnabled.
        /// </summary>
        [JsonProperty("tokenEnabled", NullValueHandling = NullValueHandling.Ignore)]
        public string TokenEnabled { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AgentAccessTokensUpdateSchema : ({string.Join(", ", toStringOutput)})";
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

            return obj is AgentAccessTokensUpdateSchema other &&
                ((this.TokenEnabled == null && other.TokenEnabled == null) || (this.TokenEnabled?.Equals(other.TokenEnabled) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -947021780;

            if (this.TokenEnabled != null)
            {
               hashCode += this.TokenEnabled.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TokenEnabled = {(this.TokenEnabled == null ? "null" : this.TokenEnabled == string.Empty ? "" : this.TokenEnabled)}");
        }
    }
}