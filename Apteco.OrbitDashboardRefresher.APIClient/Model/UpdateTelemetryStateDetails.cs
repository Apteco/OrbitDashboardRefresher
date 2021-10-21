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
    /// UpdateTelemetryStateDetails
    /// </summary>
    [DataContract]
    public partial class UpdateTelemetryStateDetails :  IEquatable<UpdateTelemetryStateDetails>, IValidatableObject
    {
        /// <summary>
        /// The optState for this telemetry state
        /// </summary>
        /// <value>The optState for this telemetry state</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OptStateEnum
        {
            
            /// <summary>
            /// Enum NotOpted for value: NotOpted
            /// </summary>
            [EnumMember(Value = "NotOpted")]
            NotOpted = 1,
            
            /// <summary>
            /// Enum OptedOut for value: OptedOut
            /// </summary>
            [EnumMember(Value = "OptedOut")]
            OptedOut = 2,
            
            /// <summary>
            /// Enum OptedIn for value: OptedIn
            /// </summary>
            [EnumMember(Value = "OptedIn")]
            OptedIn = 3,
            
            /// <summary>
            /// Enum ForcedOut for value: ForcedOut
            /// </summary>
            [EnumMember(Value = "ForcedOut")]
            ForcedOut = 4,
            
            /// <summary>
            /// Enum ForcedIn for value: ForcedIn
            /// </summary>
            [EnumMember(Value = "ForcedIn")]
            ForcedIn = 5
        }

        /// <summary>
        /// The optState for this telemetry state
        /// </summary>
        /// <value>The optState for this telemetry state</value>
        [DataMember(Name="optState", EmitDefaultValue=false)]
        public OptStateEnum OptState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTelemetryStateDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateTelemetryStateDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTelemetryStateDetails" /> class.
        /// </summary>
        /// <param name="optState">The optState for this telemetry state (required).</param>
        public UpdateTelemetryStateDetails(OptStateEnum optState = default(OptStateEnum))
        {
            // to ensure "optState" is required (not null)
            if (optState == null)
            {
                throw new InvalidDataException("optState is a required property for UpdateTelemetryStateDetails and cannot be null");
            }
            else
            {
                this.OptState = optState;
            }
        }
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTelemetryStateDetails {\n");
            sb.Append("  OptState: ").Append(OptState).Append("\n");
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
            return this.Equals(input as UpdateTelemetryStateDetails);
        }

        /// <summary>
        /// Returns true if UpdateTelemetryStateDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateTelemetryStateDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateTelemetryStateDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OptState == input.OptState ||
                    (this.OptState != null &&
                    this.OptState.Equals(input.OptState))
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
                if (this.OptState != null)
                    hashCode = hashCode * 59 + this.OptState.GetHashCode();
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