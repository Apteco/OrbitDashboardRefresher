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
    /// The username associated with a given session
    /// </summary>
    [DataContract]
    public partial class SessionAndUserDetails :  IEquatable<SessionAndUserDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionAndUserDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SessionAndUserDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionAndUserDetails" /> class.
        /// </summary>
        /// <param name="user">Details of the user associated with the session (required).</param>
        /// <param name="sessionId">The id for this session (required).</param>
        public SessionAndUserDetails(UserDisplayDetails user = default(UserDisplayDetails), string sessionId = default(string))
        {
            // to ensure "user" is required (not null)
            if (user == null)
            {
                throw new InvalidDataException("user is a required property for SessionAndUserDetails and cannot be null");
            }
            else
            {
                this.User = user;
            }
            // to ensure "sessionId" is required (not null)
            if (sessionId == null)
            {
                throw new InvalidDataException("sessionId is a required property for SessionAndUserDetails and cannot be null");
            }
            else
            {
                this.SessionId = sessionId;
            }
        }
        
        /// <summary>
        /// Details of the user associated with the session
        /// </summary>
        /// <value>Details of the user associated with the session</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserDisplayDetails User { get; set; }

        /// <summary>
        /// The id for this session
        /// </summary>
        /// <value>The id for this session</value>
        [DataMember(Name="sessionId", EmitDefaultValue=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SessionAndUserDetails {\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
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
            return this.Equals(input as SessionAndUserDetails);
        }

        /// <summary>
        /// Returns true if SessionAndUserDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of SessionAndUserDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SessionAndUserDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.SessionId == input.SessionId ||
                    (this.SessionId != null &&
                    this.SessionId.Equals(input.SessionId))
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
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.SessionId != null)
                    hashCode = hashCode * 59 + this.SessionId.GetHashCode();
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