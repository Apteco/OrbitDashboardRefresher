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
    /// CreateTelemetryStateDetails
    /// </summary>
    [DataContract]
    public partial class CreateTelemetryStateDetails :  IEquatable<CreateTelemetryStateDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTelemetryStateDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateTelemetryStateDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTelemetryStateDetails" /> class.
        /// </summary>
        /// <param name="username">The username for this telemetry state (required).</param>
        public CreateTelemetryStateDetails(string username = default(string))
        {
            // to ensure "username" is required (not null)
            if (username == null)
            {
                throw new InvalidDataException("username is a required property for CreateTelemetryStateDetails and cannot be null");
            }
            else
            {
                this.Username = username;
            }
        }
        
        /// <summary>
        /// The username for this telemetry state
        /// </summary>
        /// <value>The username for this telemetry state</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTelemetryStateDetails {\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
            return this.Equals(input as CreateTelemetryStateDetails);
        }

        /// <summary>
        /// Returns true if CreateTelemetryStateDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateTelemetryStateDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateTelemetryStateDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
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