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
    /// The parameters needed to create a new reset password request
    /// </summary>
    [DataContract]
    public partial class CreateResetPasswordRequest :  IEquatable<CreateResetPasswordRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResetPasswordRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateResetPasswordRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResetPasswordRequest" /> class.
        /// </summary>
        /// <param name="emailAddress">The email address for the user resetting their password (required).</param>
        /// <param name="resetPasswordUrl">A URL to send in the notification to the user to allow them to confirm they want to reset their password.    If the URL is specified, it can use the {token}, {emailAddress} and {username} parameters:    http://www.example.com/resetPassword/{token}?email&#x3D;{emailAddress}&amp;amp;username&#x3D;{username}    If present, the {token} parameter will be replaced with the token of the password reset request, which  will be needed when performing the reset.  The {emailAddress} parameter will be replaced with the email address  of the user resetting their password.  The {username} parameter will be replaced with the username of the  user resetting their password..</param>
        public CreateResetPasswordRequest(string emailAddress = default(string), string resetPasswordUrl = default(string))
        {
            // to ensure "emailAddress" is required (not null)
            if (emailAddress == null)
            {
                throw new InvalidDataException("emailAddress is a required property for CreateResetPasswordRequest and cannot be null");
            }
            else
            {
                this.EmailAddress = emailAddress;
            }
            this.ResetPasswordUrl = resetPasswordUrl;
        }
        
        /// <summary>
        /// The email address for the user resetting their password
        /// </summary>
        /// <value>The email address for the user resetting their password</value>
        [DataMember(Name="emailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// A URL to send in the notification to the user to allow them to confirm they want to reset their password.    If the URL is specified, it can use the {token}, {emailAddress} and {username} parameters:    http://www.example.com/resetPassword/{token}?email&#x3D;{emailAddress}&amp;amp;username&#x3D;{username}    If present, the {token} parameter will be replaced with the token of the password reset request, which  will be needed when performing the reset.  The {emailAddress} parameter will be replaced with the email address  of the user resetting their password.  The {username} parameter will be replaced with the username of the  user resetting their password.
        /// </summary>
        /// <value>A URL to send in the notification to the user to allow them to confirm they want to reset their password.    If the URL is specified, it can use the {token}, {emailAddress} and {username} parameters:    http://www.example.com/resetPassword/{token}?email&#x3D;{emailAddress}&amp;amp;username&#x3D;{username}    If present, the {token} parameter will be replaced with the token of the password reset request, which  will be needed when performing the reset.  The {emailAddress} parameter will be replaced with the email address  of the user resetting their password.  The {username} parameter will be replaced with the username of the  user resetting their password.</value>
        [DataMember(Name="resetPasswordUrl", EmitDefaultValue=false)]
        public string ResetPasswordUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateResetPasswordRequest {\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  ResetPasswordUrl: ").Append(ResetPasswordUrl).Append("\n");
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
            return this.Equals(input as CreateResetPasswordRequest);
        }

        /// <summary>
        /// Returns true if CreateResetPasswordRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateResetPasswordRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateResetPasswordRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.ResetPasswordUrl == input.ResetPasswordUrl ||
                    (this.ResetPasswordUrl != null &&
                    this.ResetPasswordUrl.Equals(input.ResetPasswordUrl))
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
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.ResetPasswordUrl != null)
                    hashCode = hashCode * 59 + this.ResetPasswordUrl.GetHashCode();
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
