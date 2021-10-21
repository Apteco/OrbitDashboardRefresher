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
    /// Details for a category for a selector variable in the FastStats system
    /// </summary>
    [DataContract]
    public partial class VarCode :  IEquatable<VarCode>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VarCode" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VarCode() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VarCode" /> class.
        /// </summary>
        /// <param name="code">The code for this category (required).</param>
        /// <param name="description">The description for this category (required).</param>
        /// <param name="count">The number of records for the variable in the whole FastStats system that have been asigned this code.  If this is null, then the count is temporarily unavailable (perhaps due to row filters having been applied).</param>
        public VarCode(string code = default(string), string description = default(string), long? count = default(long?))
        {
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new InvalidDataException("code is a required property for VarCode and cannot be null");
            }
            else
            {
                this.Code = code;
            }
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for VarCode and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            this.Count = count;
        }
        
        /// <summary>
        /// The code for this category
        /// </summary>
        /// <value>The code for this category</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// The description for this category
        /// </summary>
        /// <value>The description for this category</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The number of records for the variable in the whole FastStats system that have been asigned this code.  If this is null, then the count is temporarily unavailable (perhaps due to row filters having been applied)
        /// </summary>
        /// <value>The number of records for the variable in the whole FastStats system that have been asigned this code.  If this is null, then the count is temporarily unavailable (perhaps due to row filters having been applied)</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public long? Count { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VarCode {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(input as VarCode);
        }

        /// <summary>
        /// Returns true if VarCode instances are equal
        /// </summary>
        /// <param name="input">Instance of VarCode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VarCode input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
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