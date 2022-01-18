/* 
 * Apteco API
 *
 * An API to allow access to Apteco Marketing Suite resources
 *
 * OpenAPI spec version: v2
 * Contact: support@apteco.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = Apteco.OrbitDashboardRefresher.APIClient.Client.SwaggerDateConverter;

namespace Apteco.OrbitDashboardRefresher.APIClient.Model
{
    /// <summary>
    /// The details required to calculate check statistics for an audience
    /// </summary>
    [DataContract]
    public partial class CheckAudienceDetails :  IEquatable<CheckAudienceDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckAudienceDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CheckAudienceDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckAudienceDetails" /> class.
        /// </summary>
        /// <param name="dimensions">The dimensions to check for this audience.  This can be one or more variables, queries, etc. (required).</param>
        public CheckAudienceDetails(List<Dimension> dimensions = default(List<Dimension>))
        {
            // to ensure "dimensions" is required (not null)
            if (dimensions == null)
            {
                throw new InvalidDataException("dimensions is a required property for CheckAudienceDetails and cannot be null");
            }
            else
            {
                this.Dimensions = dimensions;
            }
        }
        
        /// <summary>
        /// The dimensions to check for this audience.  This can be one or more variables, queries, etc.
        /// </summary>
        /// <value>The dimensions to check for this audience.  This can be one or more variables, queries, etc.</value>
        [DataMember(Name="dimensions", EmitDefaultValue=false)]
        public List<Dimension> Dimensions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckAudienceDetails {\n");
            sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckAudienceDetails);
        }

        /// <summary>
        /// Returns true if CheckAudienceDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckAudienceDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckAudienceDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Dimensions == input.Dimensions ||
                    this.Dimensions != null &&
                    this.Dimensions.SequenceEqual(input.Dimensions)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Dimensions != null)
                    hashCode = hashCode * 59 + this.Dimensions.GetHashCode();
                return hashCode;
            }
        }
    }

}
