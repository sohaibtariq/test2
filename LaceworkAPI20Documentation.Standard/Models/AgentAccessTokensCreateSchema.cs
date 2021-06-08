// <copyright file="AgentAccessTokensCreateSchema.cs" company="APIMatic">
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
    /// AgentAccessTokensCreateSchema.
    /// </summary>
    public class AgentAccessTokensCreateSchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAccessTokensCreateSchema"/> class.
        /// </summary>
        public AgentAccessTokensCreateSchema()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAccessTokensCreateSchema"/> class.
        /// </summary>
        /// <param name="tokenEnabled">tokenEnabled.</param>
        /// <param name="tokenAlias">tokenAlias.</param>
        public AgentAccessTokensCreateSchema(
            string tokenEnabled,
            string tokenAlias)
        {
            this.TokenEnabled = tokenEnabled;
            this.TokenAlias = tokenAlias;
        }

        /// <summary>
        /// Gets or sets TokenEnabled.
        /// </summary>
        [JsonProperty("tokenEnabled")]
        public string TokenEnabled { get; set; }

        /// <summary>
        /// Gets or sets TokenAlias.
        /// </summary>
        [JsonProperty("tokenAlias")]
        public string TokenAlias { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AgentAccessTokensCreateSchema : ({string.Join(", ", toStringOutput)})";
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

            return obj is AgentAccessTokensCreateSchema other &&
                ((this.TokenEnabled == null && other.TokenEnabled == null) || (this.TokenEnabled?.Equals(other.TokenEnabled) == true)) &&
                ((this.TokenAlias == null && other.TokenAlias == null) || (this.TokenAlias?.Equals(other.TokenAlias) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -1376639065;

            if (this.TokenEnabled != null)
            {
               hashCode += this.TokenEnabled.GetHashCode();
            }

            if (this.TokenAlias != null)
            {
               hashCode += this.TokenAlias.GetHashCode();
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
            toStringOutput.Add($"this.TokenAlias = {(this.TokenAlias == null ? "null" : this.TokenAlias == string.Empty ? "" : this.TokenAlias)}");
        }
    }
}