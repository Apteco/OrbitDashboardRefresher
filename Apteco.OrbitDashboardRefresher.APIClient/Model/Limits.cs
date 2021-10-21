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
    /// Limits
    /// </summary>
    [DataContract]
    public partial class Limits :  IEquatable<Limits>, IValidatableObject
    {
        /// <summary>
        /// Defines Sampling
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SamplingEnum
        {
            
            /// <summary>
            /// Enum All for value: All
            /// </summary>
            [EnumMember(Value = "All")]
            All = 1,
            
            /// <summary>
            /// Enum First for value: First
            /// </summary>
            [EnumMember(Value = "First")]
            First = 2,
            
            /// <summary>
            /// Enum Stratified for value: Stratified
            /// </summary>
            [EnumMember(Value = "Stratified")]
            Stratified = 3,
            
            /// <summary>
            /// Enum Random for value: Random
            /// </summary>
            [EnumMember(Value = "Random")]
            Random = 4
        }

        /// <summary>
        /// Gets or Sets Sampling
        /// </summary>
        [DataMember(Name="sampling", EmitDefaultValue=false)]
        public SamplingEnum? Sampling { get; set; }
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,
            
            /// <summary>
            /// Enum Total for value: Total
            /// </summary>
            [EnumMember(Value = "Total")]
            Total = 2,
            
            /// <summary>
            /// Enum Fraction for value: Fraction
            /// </summary>
            [EnumMember(Value = "Fraction")]
            Fraction = 3,
            
            /// <summary>
            /// Enum Percent for value: Percent
            /// </summary>
            [EnumMember(Value = "Percent")]
            Percent = 4
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Limits" /> class.
        /// </summary>
        /// <param name="sampling">sampling.</param>
        /// <param name="stopAtLimit">stopAtLimit.</param>
        /// <param name="total">total.</param>
        /// <param name="type">type.</param>
        /// <param name="startAt">startAt.</param>
        /// <param name="percent">percent.</param>
        /// <param name="fraction">fraction.</param>
        public Limits(SamplingEnum? sampling = default(SamplingEnum?), bool? stopAtLimit = default(bool?), long? total = default(long?), TypeEnum? type = default(TypeEnum?), long? startAt = default(long?), double? percent = default(double?), Fraction fraction = default(Fraction))
        {
            this.Sampling = sampling;
            this.StopAtLimit = stopAtLimit;
            this.Total = total;
            this.Type = type;
            this.StartAt = startAt;
            this.Percent = percent;
            this.Fraction = fraction;
        }
        

        /// <summary>
        /// Gets or Sets StopAtLimit
        /// </summary>
        [DataMember(Name="stopAtLimit", EmitDefaultValue=false)]
        public bool? StopAtLimit { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public long? Total { get; set; }


        /// <summary>
        /// Gets or Sets StartAt
        /// </summary>
        [DataMember(Name="startAt", EmitDefaultValue=false)]
        public long? StartAt { get; set; }

        /// <summary>
        /// Gets or Sets Percent
        /// </summary>
        [DataMember(Name="percent", EmitDefaultValue=false)]
        public double? Percent { get; set; }

        /// <summary>
        /// Gets or Sets Fraction
        /// </summary>
        [DataMember(Name="fraction", EmitDefaultValue=false)]
        public Fraction Fraction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Limits {\n");
            sb.Append("  Sampling: ").Append(Sampling).Append("\n");
            sb.Append("  StopAtLimit: ").Append(StopAtLimit).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  StartAt: ").Append(StartAt).Append("\n");
            sb.Append("  Percent: ").Append(Percent).Append("\n");
            sb.Append("  Fraction: ").Append(Fraction).Append("\n");
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
            return this.Equals(input as Limits);
        }

        /// <summary>
        /// Returns true if Limits instances are equal
        /// </summary>
        /// <param name="input">Instance of Limits to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Limits input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Sampling == input.Sampling ||
                    (this.Sampling != null &&
                    this.Sampling.Equals(input.Sampling))
                ) && 
                (
                    this.StopAtLimit == input.StopAtLimit ||
                    (this.StopAtLimit != null &&
                    this.StopAtLimit.Equals(input.StopAtLimit))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.StartAt == input.StartAt ||
                    (this.StartAt != null &&
                    this.StartAt.Equals(input.StartAt))
                ) && 
                (
                    this.Percent == input.Percent ||
                    (this.Percent != null &&
                    this.Percent.Equals(input.Percent))
                ) && 
                (
                    this.Fraction == input.Fraction ||
                    (this.Fraction != null &&
                    this.Fraction.Equals(input.Fraction))
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
                if (this.Sampling != null)
                    hashCode = hashCode * 59 + this.Sampling.GetHashCode();
                if (this.StopAtLimit != null)
                    hashCode = hashCode * 59 + this.StopAtLimit.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.StartAt != null)
                    hashCode = hashCode * 59 + this.StartAt.GetHashCode();
                if (this.Percent != null)
                    hashCode = hashCode * 59 + this.Percent.GetHashCode();
                if (this.Fraction != null)
                    hashCode = hashCode * 59 + this.Fraction.GetHashCode();
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