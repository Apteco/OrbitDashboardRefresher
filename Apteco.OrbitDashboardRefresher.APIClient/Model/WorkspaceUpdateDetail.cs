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
    /// Details for a workspace update
    /// </summary>
    [DataContract]
    public partial class WorkspaceUpdateDetail :  IEquatable<WorkspaceUpdateDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceUpdateDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkspaceUpdateDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceUpdateDetail" /> class.
        /// </summary>
        /// <param name="id">The workspace update&#39;s id (required).</param>
        /// <param name="timestamp">The timestamp of when the update happened (required).</param>
        /// <param name="user">The user that created this update (required).</param>
        /// <param name="title">The title of the workspace at the time of this update (required).</param>
        /// <param name="description">The workspace of the audience at the time of this update (required).</param>
        /// <param name="owner">The details of the user that owned this workspace at the time of this update (required).</param>
        /// <param name="isDeleted">Whether this update set the workspace to be deleted or not (required).</param>
        public WorkspaceUpdateDetail(int? id = default(int?), DateTime? timestamp = default(DateTime?), UserDisplayDetails user = default(UserDisplayDetails), string title = default(string), string description = default(string), UserDisplayDetails owner = default(UserDisplayDetails), bool? isDeleted = default(bool?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for WorkspaceUpdateDetail and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "timestamp" is required (not null)
            if (timestamp == null)
            {
                throw new InvalidDataException("timestamp is a required property for WorkspaceUpdateDetail and cannot be null");
            }
            else
            {
                this.Timestamp = timestamp;
            }
            // to ensure "user" is required (not null)
            if (user == null)
            {
                throw new InvalidDataException("user is a required property for WorkspaceUpdateDetail and cannot be null");
            }
            else
            {
                this.User = user;
            }
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for WorkspaceUpdateDetail and cannot be null");
            }
            else
            {
                this.Title = title;
            }
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for WorkspaceUpdateDetail and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            // to ensure "owner" is required (not null)
            if (owner == null)
            {
                throw new InvalidDataException("owner is a required property for WorkspaceUpdateDetail and cannot be null");
            }
            else
            {
                this.Owner = owner;
            }
            // to ensure "isDeleted" is required (not null)
            if (isDeleted == null)
            {
                throw new InvalidDataException("isDeleted is a required property for WorkspaceUpdateDetail and cannot be null");
            }
            else
            {
                this.IsDeleted = isDeleted;
            }
        }
        
        /// <summary>
        /// The workspace update&#39;s id
        /// </summary>
        /// <value>The workspace update&#39;s id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The timestamp of when the update happened
        /// </summary>
        /// <value>The timestamp of when the update happened</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// The user that created this update
        /// </summary>
        /// <value>The user that created this update</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserDisplayDetails User { get; set; }

        /// <summary>
        /// The title of the workspace at the time of this update
        /// </summary>
        /// <value>The title of the workspace at the time of this update</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// The workspace of the audience at the time of this update
        /// </summary>
        /// <value>The workspace of the audience at the time of this update</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The details of the user that owned this workspace at the time of this update
        /// </summary>
        /// <value>The details of the user that owned this workspace at the time of this update</value>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public UserDisplayDetails Owner { get; set; }

        /// <summary>
        /// Whether this update set the workspace to be deleted or not
        /// </summary>
        /// <value>Whether this update set the workspace to be deleted or not</value>
        [DataMember(Name="isDeleted", EmitDefaultValue=false)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkspaceUpdateDetail {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
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
            return this.Equals(input as WorkspaceUpdateDetail);
        }

        /// <summary>
        /// Returns true if WorkspaceUpdateDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkspaceUpdateDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkspaceUpdateDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.IsDeleted == input.IsDeleted ||
                    (this.IsDeleted != null &&
                    this.IsDeleted.Equals(input.IsDeleted))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.IsDeleted != null)
                    hashCode = hashCode * 59 + this.IsDeleted.GetHashCode();
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
