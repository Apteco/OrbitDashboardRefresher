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
    /// Lookup information for a variable and its var code descriptions returned in a result
    /// </summary>
    [DataContract]
    public partial class VariableLookup :  IEquatable<VariableLookup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableLookup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VariableLookup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableLookup" /> class.
        /// </summary>
        /// <param name="variable">The details of the variable in question (required).</param>
        /// <param name="varCodesLookup">A partial list of var codes for the variable in question.</param>
        public VariableLookup(Variable variable = default(Variable), List<VarCode> varCodesLookup = default(List<VarCode>))
        {
            // to ensure "variable" is required (not null)
            if (variable == null)
            {
                throw new InvalidDataException("variable is a required property for VariableLookup and cannot be null");
            }
            else
            {
                this.Variable = variable;
            }
            this.VarCodesLookup = varCodesLookup;
        }
        
        /// <summary>
        /// The details of the variable in question
        /// </summary>
        /// <value>The details of the variable in question</value>
        [DataMember(Name="variable", EmitDefaultValue=false)]
        public Variable Variable { get; set; }

        /// <summary>
        /// A partial list of var codes for the variable in question
        /// </summary>
        /// <value>A partial list of var codes for the variable in question</value>
        [DataMember(Name="varCodesLookup", EmitDefaultValue=false)]
        public List<VarCode> VarCodesLookup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VariableLookup {\n");
            sb.Append("  Variable: ").Append(Variable).Append("\n");
            sb.Append("  VarCodesLookup: ").Append(VarCodesLookup).Append("\n");
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
            return this.Equals(input as VariableLookup);
        }

        /// <summary>
        /// Returns true if VariableLookup instances are equal
        /// </summary>
        /// <param name="input">Instance of VariableLookup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VariableLookup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Variable == input.Variable ||
                    (this.Variable != null &&
                    this.Variable.Equals(input.Variable))
                ) && 
                (
                    this.VarCodesLookup == input.VarCodesLookup ||
                    this.VarCodesLookup != null &&
                    this.VarCodesLookup.SequenceEqual(input.VarCodesLookup)
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
                if (this.Variable != null)
                    hashCode = hashCode * 59 + this.Variable.GetHashCode();
                if (this.VarCodesLookup != null)
                    hashCode = hashCode * 59 + this.VarCodesLookup.GetHashCode();
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
