// <copyright file="Data.cs" company="APIMatic">
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
    /// Data.
    /// </summary>
    public class Data
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data"/> class.
        /// </summary>
        public Data()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data"/> class.
        /// </summary>
        /// <param name="s3CrossAccountCredentials">s3CrossAccountCredentials.</param>
        public Data(
            Models.S3CrossAccountCredentials s3CrossAccountCredentials)
        {
            this.S3CrossAccountCredentials = s3CrossAccountCredentials;
        }

        /// <summary>
        /// Gets or sets S3CrossAccountCredentials.
        /// </summary>
        [JsonProperty("s3CrossAccountCredentials")]
        public Models.S3CrossAccountCredentials S3CrossAccountCredentials { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data other &&
                ((this.S3CrossAccountCredentials == null && other.S3CrossAccountCredentials == null) || (this.S3CrossAccountCredentials?.Equals(other.S3CrossAccountCredentials) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -504302380;

            if (this.S3CrossAccountCredentials != null)
            {
               hashCode += this.S3CrossAccountCredentials.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.S3CrossAccountCredentials = {(this.S3CrossAccountCredentials == null ? "null" : this.S3CrossAccountCredentials.ToString())}");
        }
    }
}