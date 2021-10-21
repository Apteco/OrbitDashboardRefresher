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
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Apteco.OrbitDashboardRefresher.APIClient.Client.SwaggerDateConverter;

namespace Apteco.OrbitDashboardRefresher.APIClient.Model
{
    /// <summary>
    /// TelemetrySessionAttribute
    /// </summary>
    [DataContract]
    public partial class TelemetrySessionAttribute :  IEquatable<TelemetrySessionAttribute>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TelemetrySessionAttribute" /> class.
        /// </summary>
        /// <param name="attributeIndex">The attribute Id.</param>
        /// <param name="attributeValues">The list of attribute values.</param>
        public TelemetrySessionAttribute(int? attributeIndex = default(int?), List<string> attributeValues = default(List<string>))
        {
            this.AttributeIndex = attributeIndex;
            this.AttributeValues = attributeValues;
        }
        
        /// <summary>
        /// The attribute Id
        /// </summary>
        /// <value>The attribute Id</value>
        [DataMember(Name="attributeIndex", EmitDefaultValue=false)]
        public int? AttributeIndex { get; set; }

        /// <summary>
        /// The list of attribute values
        /// </summary>
        /// <value>The list of attribute values</value>
        [DataMember(Name="attributeValues", EmitDefaultValue=false)]
        public List<string> AttributeValues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TelemetrySessionAttribute {\n");
            sb.Append("  AttributeIndex: ").Append(AttributeIndex).Append("\n");
            sb.Append("  AttributeValues: ").Append(AttributeValues).Append("\n");
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
            return this.Equals(input as TelemetrySessionAttribute);
        }

        /// <summary>
        /// Returns true if TelemetrySessionAttribute instances are equal
        /// </summary>
        /// <param name="input">Instance of TelemetrySessionAttribute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TelemetrySessionAttribute input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AttributeIndex == input.AttributeIndex ||
                    (this.AttributeIndex != null &&
                    this.AttributeIndex.Equals(input.AttributeIndex))
                ) && 
                (
                    this.AttributeValues == input.AttributeValues ||
                    this.AttributeValues != null &&
                    this.AttributeValues.SequenceEqual(input.AttributeValues)
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
                if (this.AttributeIndex != null)
                    hashCode = hashCode * 59 + this.AttributeIndex.GetHashCode();
                if (this.AttributeValues != null)
                    hashCode = hashCode * 59 + this.AttributeValues.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
