// <copyright file="ContractInfo.cs" company="APIMatic">
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
    /// ContractInfo.
    /// </summary>
    public class ContractInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractInfo"/> class.
        /// </summary>
        public ContractInfo()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContractInfo"/> class.
        /// </summary>
        /// <param name="objName">objName.</param>
        /// <param name="props">props.</param>
        public ContractInfo(
            string objName = null,
            object props = null)
        {
            this.ObjName = objName;
            this.Props = props;
        }

        /// <summary>
        /// Gets or sets ObjName.
        /// </summary>
        [JsonProperty("objName", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjName { get; set; }

        /// <summary>
        /// Gets or sets Props.
        /// </summary>
        [JsonProperty("props", NullValueHandling = NullValueHandling.Ignore)]
        public object Props { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ContractInfo : ({string.Join(", ", toStringOutput)})";
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

            return obj is ContractInfo other &&
                ((this.ObjName == null && other.ObjName == null) || (this.ObjName?.Equals(other.ObjName) == true)) &&
                ((this.Props == null && other.Props == null) || (this.Props?.Equals(other.Props) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1923117064;

            if (this.ObjName != null)
            {
               hashCode += this.ObjName.GetHashCode();
            }

            if (this.Props != null)
            {
               hashCode += this.Props.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ObjName = {(this.ObjName == null ? "null" : this.ObjName == string.Empty ? "" : this.ObjName)}");
            toStringOutput.Add($"Props = {(this.Props == null ? "null" : this.Props.ToString())}");
        }
    }
}