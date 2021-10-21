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
    /// Details used to modify an audience for a given user
    /// </summary>
    [DataContract]
    public partial class ModifyUserAudienceDetailResults :  IEquatable<ModifyUserAudienceDetailResults>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyUserAudienceDetailResults" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ModifyUserAudienceDetailResults() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyUserAudienceDetailResults" /> class.
        /// </summary>
        /// <param name="audience">The details of the modified audience.</param>
        /// <param name="id">The id of the updated item (required).</param>
        /// <param name="succeeded">Whether the modification succeeded or not (required).</param>
        /// <param name="status">A status message associated with the modification (required).</param>
        /// <param name="statusCode">A status code associated with the modification (required).</param>
        public ModifyUserAudienceDetailResults(UserAudienceDetail audience = default(UserAudienceDetail), int? id = default(int?), bool? succeeded = default(bool?), string status = default(string), int? statusCode = default(int?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for ModifyUserAudienceDetailResults and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "succeeded" is required (not null)
            if (succeeded == null)
            {
                throw new InvalidDataException("succeeded is a required property for ModifyUserAudienceDetailResults and cannot be null");
            }
            else
            {
                this.Succeeded = succeeded;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for ModifyUserAudienceDetailResults and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            // to ensure "statusCode" is required (not null)
            if (statusCode == null)
            {
                throw new InvalidDataException("statusCode is a required property for ModifyUserAudienceDetailResults and cannot be null");
            }
            else
            {
                this.StatusCode = statusCode;
            }
            this.Audience = audience;
        }
        
        /// <summary>
        /// The details of the modified audience
        /// </summary>
        /// <value>The details of the modified audience</value>
        [DataMember(Name="audience", EmitDefaultValue=false)]
        public UserAudienceDetail Audience { get; set; }

        /// <summary>
        /// The id of the updated item
        /// </summary>
        /// <value>The id of the updated item</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Whether the modification succeeded or not
        /// </summary>
        /// <value>Whether the modification succeeded or not</value>
        [DataMember(Name="succeeded", EmitDefaultValue=false)]
        public bool? Succeeded { get; set; }

        /// <summary>
        /// A status message associated with the modification
        /// </summary>
        /// <value>A status message associated with the modification</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// A status code associated with the modification
        /// </summary>
        /// <value>A status code associated with the modification</value>
        [DataMember(Name="statusCode", EmitDefaultValue=false)]
        public int? StatusCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyUserAudienceDetailResults {\n");
            sb.Append("  Audience: ").Append(Audience).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Succeeded: ").Append(Succeeded).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
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
            return this.Equals(input as ModifyUserAudienceDetailResults);
        }

        /// <summary>
        /// Returns true if ModifyUserAudienceDetailResults instances are equal
        /// </summary>
        /// <param name="input">Instance of ModifyUserAudienceDetailResults to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModifyUserAudienceDetailResults input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Audience == input.Audience ||
                    (this.Audience != null &&
                    this.Audience.Equals(input.Audience))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Succeeded == input.Succeeded ||
                    (this.Succeeded != null &&
                    this.Succeeded.Equals(input.Succeeded))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.StatusCode == input.StatusCode ||
                    (this.StatusCode != null &&
                    this.StatusCode.Equals(input.StatusCode))
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
                if (this.Audience != null)
                    hashCode = hashCode * 59 + this.Audience.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Succeeded != null)
                    hashCode = hashCode * 59 + this.Succeeded.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusCode != null)
                    hashCode = hashCode * 59 + this.StatusCode.GetHashCode();
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
