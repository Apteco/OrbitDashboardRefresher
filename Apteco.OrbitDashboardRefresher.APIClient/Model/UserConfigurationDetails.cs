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
    /// The details of the user configuration
    /// </summary>
    [DataContract]
    public partial class UserConfigurationDetails :  IEquatable<UserConfigurationDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserConfigurationDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserConfigurationDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserConfigurationDetails" /> class.
        /// </summary>
        /// <param name="passwordRequirements">The requirements for new passwords (required).</param>
        /// <param name="emailRequirements">The requirements for email addresses when creating users or sharing to users (required).</param>
        public UserConfigurationDetails(PasswordRequirements passwordRequirements = default(PasswordRequirements), EmailRequirements emailRequirements = default(EmailRequirements))
        {
            // to ensure "passwordRequirements" is required (not null)
            if (passwordRequirements == null)
            {
                throw new InvalidDataException("passwordRequirements is a required property for UserConfigurationDetails and cannot be null");
            }
            else
            {
                this.PasswordRequirements = passwordRequirements;
            }
            // to ensure "emailRequirements" is required (not null)
            if (emailRequirements == null)
            {
                throw new InvalidDataException("emailRequirements is a required property for UserConfigurationDetails and cannot be null");
            }
            else
            {
                this.EmailRequirements = emailRequirements;
            }
        }
        
        /// <summary>
        /// The requirements for new passwords
        /// </summary>
        /// <value>The requirements for new passwords</value>
        [DataMember(Name="passwordRequirements", EmitDefaultValue=false)]
        public PasswordRequirements PasswordRequirements { get; set; }

        /// <summary>
        /// The requirements for email addresses when creating users or sharing to users
        /// </summary>
        /// <value>The requirements for email addresses when creating users or sharing to users</value>
        [DataMember(Name="emailRequirements", EmitDefaultValue=false)]
        public EmailRequirements EmailRequirements { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserConfigurationDetails {\n");
            sb.Append("  PasswordRequirements: ").Append(PasswordRequirements).Append("\n");
            sb.Append("  EmailRequirements: ").Append(EmailRequirements).Append("\n");
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
            return this.Equals(input as UserConfigurationDetails);
        }

        /// <summary>
        /// Returns true if UserConfigurationDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of UserConfigurationDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserConfigurationDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PasswordRequirements == input.PasswordRequirements ||
                    (this.PasswordRequirements != null &&
                    this.PasswordRequirements.Equals(input.PasswordRequirements))
                ) && 
                (
                    this.EmailRequirements == input.EmailRequirements ||
                    (this.EmailRequirements != null &&
                    this.EmailRequirements.Equals(input.EmailRequirements))
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
                if (this.PasswordRequirements != null)
                    hashCode = hashCode * 59 + this.PasswordRequirements.GetHashCode();
                if (this.EmailRequirements != null)
                    hashCode = hashCode * 59 + this.EmailRequirements.GetHashCode();
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
