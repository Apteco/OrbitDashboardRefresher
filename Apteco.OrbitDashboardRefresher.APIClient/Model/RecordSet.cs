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
    /// RecordSet
    /// </summary>
    [DataContract]
    public partial class RecordSet :  IEquatable<RecordSet>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum URN for value: URN
            /// </summary>
            [EnumMember(Value = "URN")]
            URN = 1,
            
            /// <summary>
            /// Enum SBM for value: SBM
            /// </summary>
            [EnumMember(Value = "SBM")]
            SBM = 2,
            
            /// <summary>
            /// Enum FSRN for value: FSRN
            /// </summary>
            [EnumMember(Value = "FSRN")]
            FSRN = 3
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordSet" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="keyVariableName">keyVariableName.</param>
        /// <param name="byReference">byReference.</param>
        /// <param name="path">path.</param>
        /// <param name="transient">transient.</param>
        /// <param name="values">values.</param>
        /// <param name="minOccurs">minOccurs.</param>
        public RecordSet(TypeEnum? type = default(TypeEnum?), string keyVariableName = default(string), bool? byReference = default(bool?), string path = default(string), bool? transient = default(bool?), string values = default(string), int? minOccurs = default(int?))
        {
            this.Type = type;
            this.KeyVariableName = keyVariableName;
            this.ByReference = byReference;
            this.Path = path;
            this.Transient = transient;
            this.Values = values;
            this.MinOccurs = minOccurs;
        }
        

        /// <summary>
        /// Gets or Sets KeyVariableName
        /// </summary>
        [DataMember(Name="keyVariableName", EmitDefaultValue=false)]
        public string KeyVariableName { get; set; }

        /// <summary>
        /// Gets or Sets ByReference
        /// </summary>
        [DataMember(Name="byReference", EmitDefaultValue=false)]
        public bool? ByReference { get; set; }

        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// Gets or Sets Transient
        /// </summary>
        [DataMember(Name="transient", EmitDefaultValue=false)]
        public bool? Transient { get; set; }

        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public string Values { get; set; }

        /// <summary>
        /// Gets or Sets MinOccurs
        /// </summary>
        [DataMember(Name="minOccurs", EmitDefaultValue=false)]
        public int? MinOccurs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecordSet {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  KeyVariableName: ").Append(KeyVariableName).Append("\n");
            sb.Append("  ByReference: ").Append(ByReference).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Transient: ").Append(Transient).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  MinOccurs: ").Append(MinOccurs).Append("\n");
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
            return this.Equals(input as RecordSet);
        }

        /// <summary>
        /// Returns true if RecordSet instances are equal
        /// </summary>
        /// <param name="input">Instance of RecordSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecordSet input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.KeyVariableName == input.KeyVariableName ||
                    (this.KeyVariableName != null &&
                    this.KeyVariableName.Equals(input.KeyVariableName))
                ) && 
                (
                    this.ByReference == input.ByReference ||
                    (this.ByReference != null &&
                    this.ByReference.Equals(input.ByReference))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Transient == input.Transient ||
                    (this.Transient != null &&
                    this.Transient.Equals(input.Transient))
                ) && 
                (
                    this.Values == input.Values ||
                    (this.Values != null &&
                    this.Values.Equals(input.Values))
                ) && 
                (
                    this.MinOccurs == input.MinOccurs ||
                    (this.MinOccurs != null &&
                    this.MinOccurs.Equals(input.MinOccurs))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.KeyVariableName != null)
                    hashCode = hashCode * 59 + this.KeyVariableName.GetHashCode();
                if (this.ByReference != null)
                    hashCode = hashCode * 59 + this.ByReference.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Transient != null)
                    hashCode = hashCode * 59 + this.Transient.GetHashCode();
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
                if (this.MinOccurs != null)
                    hashCode = hashCode * 59 + this.MinOccurs.GetHashCode();
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
