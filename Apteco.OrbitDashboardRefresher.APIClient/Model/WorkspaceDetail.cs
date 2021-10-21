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
    /// Details for a workspace
    /// </summary>
    [DataContract]
    public partial class WorkspaceDetail :  IEquatable<WorkspaceDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkspaceDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceDetail" /> class.
        /// </summary>
        /// <param name="id">The workspace&#39;s id (required).</param>
        /// <param name="title">The title of the workspace (required).</param>
        /// <param name="description">The description of the workspace (required).</param>
        /// <param name="creationDate">The date the workspace was created (required).</param>
        /// <param name="owner">The details of the user that owns this workspace (required).</param>
        /// <param name="deletionDate">The date the workspace was deleted, or null if it has not been deleted.</param>
        /// <param name="numberOfUsersSharedWith">The number of people this workspace has been shared with (required).</param>
        /// <param name="sharedToAll">Whether the workspace has been shared to all users (required).</param>
        /// <param name="shareId">The id of the share associated with this workspace, or null if the  workspace has not yet been shared.</param>
        /// <param name="lastUpdatedUser">The details of the user that last updated this workspace (required).</param>
        /// <param name="lastUpdatedDate">The date the workspace was last updated (required).</param>
        /// <param name="lastUpdateId">The id of the last update for this workspace (required).</param>
        public WorkspaceDetail(int? id = default(int?), string title = default(string), string description = default(string), DateTime? creationDate = default(DateTime?), UserDisplayDetails owner = default(UserDisplayDetails), DateTime? deletionDate = default(DateTime?), int? numberOfUsersSharedWith = default(int?), bool? sharedToAll = default(bool?), int? shareId = default(int?), UserDisplayDetails lastUpdatedUser = default(UserDisplayDetails), DateTime? lastUpdatedDate = default(DateTime?), int? lastUpdateId = default(int?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for WorkspaceDetail and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for WorkspaceDetail and cannot be null");
            }
            else
            {
                this.Title = title;
            }
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for WorkspaceDetail and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            // to ensure "creationDate" is required (not null)
            if (creationDate == null)
            {
                throw new InvalidDataException("creationDate is a required property for WorkspaceDetail and cannot be null");
            }
            else
            {
                this.CreationDate = creationDate;
            }
            // to ensure "owner" is required (not null)
            if (owner == null)
            {
                throw new InvalidDataException("owner is a required property for WorkspaceDetail and cannot be null");
            }
            else
            {
                this.Owner = owner;
            }
            // to ensure "numberOfUsersSharedWith" is required (not null)
            if (numberOfUsersSharedWith == null)
            {
                throw new InvalidDataException("numberOfUsersSharedWith is a required property for WorkspaceDetail and cannot be null");
            }
            else
            {
                this.NumberOfUsersSharedWith = numberOfUsersSharedWith;
            }
            // to ensure "sharedToAll" is required (not null)
            if (sharedToAll == null)
            {
                throw new InvalidDataException("sharedToAll is a required property for WorkspaceDetail and cannot be null");
            }
            else
            {
                this.SharedToAll = sharedToAll;
            }
            // to ensure "lastUpdatedUser" is required (not null)
            if (lastUpdatedUser == null)
            {
                throw new InvalidDataException("lastUpdatedUser is a required property for WorkspaceDetail and cannot be null");
            }
            else
            {
                this.LastUpdatedUser = lastUpdatedUser;
            }
            // to ensure "lastUpdatedDate" is required (not null)
            if (lastUpdatedDate == null)
            {
                throw new InvalidDataException("lastUpdatedDate is a required property for WorkspaceDetail and cannot be null");
            }
            else
            {
                this.LastUpdatedDate = lastUpdatedDate;
            }
            // to ensure "lastUpdateId" is required (not null)
            if (lastUpdateId == null)
            {
                throw new InvalidDataException("lastUpdateId is a required property for WorkspaceDetail and cannot be null");
            }
            else
            {
                this.LastUpdateId = lastUpdateId;
            }
            this.DeletionDate = deletionDate;
            this.ShareId = shareId;
        }
        
        /// <summary>
        /// The workspace&#39;s id
        /// </summary>
        /// <value>The workspace&#39;s id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The title of the workspace
        /// </summary>
        /// <value>The title of the workspace</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// The description of the workspace
        /// </summary>
        /// <value>The description of the workspace</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The date the workspace was created
        /// </summary>
        /// <value>The date the workspace was created</value>
        [DataMember(Name="creationDate", EmitDefaultValue=false)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// The details of the user that owns this workspace
        /// </summary>
        /// <value>The details of the user that owns this workspace</value>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public UserDisplayDetails Owner { get; set; }

        /// <summary>
        /// The date the workspace was deleted, or null if it has not been deleted
        /// </summary>
        /// <value>The date the workspace was deleted, or null if it has not been deleted</value>
        [DataMember(Name="deletionDate", EmitDefaultValue=false)]
        public DateTime? DeletionDate { get; set; }

        /// <summary>
        /// The number of people this workspace has been shared with
        /// </summary>
        /// <value>The number of people this workspace has been shared with</value>
        [DataMember(Name="numberOfUsersSharedWith", EmitDefaultValue=false)]
        public int? NumberOfUsersSharedWith { get; set; }

        /// <summary>
        /// Whether the workspace has been shared to all users
        /// </summary>
        /// <value>Whether the workspace has been shared to all users</value>
        [DataMember(Name="sharedToAll", EmitDefaultValue=false)]
        public bool? SharedToAll { get; set; }

        /// <summary>
        /// The id of the share associated with this workspace, or null if the  workspace has not yet been shared
        /// </summary>
        /// <value>The id of the share associated with this workspace, or null if the  workspace has not yet been shared</value>
        [DataMember(Name="shareId", EmitDefaultValue=false)]
        public int? ShareId { get; set; }

        /// <summary>
        /// The details of the user that last updated this workspace
        /// </summary>
        /// <value>The details of the user that last updated this workspace</value>
        [DataMember(Name="lastUpdatedUser", EmitDefaultValue=false)]
        public UserDisplayDetails LastUpdatedUser { get; set; }

        /// <summary>
        /// The date the workspace was last updated
        /// </summary>
        /// <value>The date the workspace was last updated</value>
        [DataMember(Name="lastUpdatedDate", EmitDefaultValue=false)]
        public DateTime? LastUpdatedDate { get; set; }

        /// <summary>
        /// The id of the last update for this workspace
        /// </summary>
        /// <value>The id of the last update for this workspace</value>
        [DataMember(Name="lastUpdateId", EmitDefaultValue=false)]
        public int? LastUpdateId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkspaceDetail {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  DeletionDate: ").Append(DeletionDate).Append("\n");
            sb.Append("  NumberOfUsersSharedWith: ").Append(NumberOfUsersSharedWith).Append("\n");
            sb.Append("  SharedToAll: ").Append(SharedToAll).Append("\n");
            sb.Append("  ShareId: ").Append(ShareId).Append("\n");
            sb.Append("  LastUpdatedUser: ").Append(LastUpdatedUser).Append("\n");
            sb.Append("  LastUpdatedDate: ").Append(LastUpdatedDate).Append("\n");
            sb.Append("  LastUpdateId: ").Append(LastUpdateId).Append("\n");
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
            return this.Equals(input as WorkspaceDetail);
        }

        /// <summary>
        /// Returns true if WorkspaceDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkspaceDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkspaceDetail input)
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
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.DeletionDate == input.DeletionDate ||
                    (this.DeletionDate != null &&
                    this.DeletionDate.Equals(input.DeletionDate))
                ) && 
                (
                    this.NumberOfUsersSharedWith == input.NumberOfUsersSharedWith ||
                    (this.NumberOfUsersSharedWith != null &&
                    this.NumberOfUsersSharedWith.Equals(input.NumberOfUsersSharedWith))
                ) && 
                (
                    this.SharedToAll == input.SharedToAll ||
                    (this.SharedToAll != null &&
                    this.SharedToAll.Equals(input.SharedToAll))
                ) && 
                (
                    this.ShareId == input.ShareId ||
                    (this.ShareId != null &&
                    this.ShareId.Equals(input.ShareId))
                ) && 
                (
                    this.LastUpdatedUser == input.LastUpdatedUser ||
                    (this.LastUpdatedUser != null &&
                    this.LastUpdatedUser.Equals(input.LastUpdatedUser))
                ) && 
                (
                    this.LastUpdatedDate == input.LastUpdatedDate ||
                    (this.LastUpdatedDate != null &&
                    this.LastUpdatedDate.Equals(input.LastUpdatedDate))
                ) && 
                (
                    this.LastUpdateId == input.LastUpdateId ||
                    (this.LastUpdateId != null &&
                    this.LastUpdateId.Equals(input.LastUpdateId))
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CreationDate != null)
                    hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.DeletionDate != null)
                    hashCode = hashCode * 59 + this.DeletionDate.GetHashCode();
                if (this.NumberOfUsersSharedWith != null)
                    hashCode = hashCode * 59 + this.NumberOfUsersSharedWith.GetHashCode();
                if (this.SharedToAll != null)
                    hashCode = hashCode * 59 + this.SharedToAll.GetHashCode();
                if (this.ShareId != null)
                    hashCode = hashCode * 59 + this.ShareId.GetHashCode();
                if (this.LastUpdatedUser != null)
                    hashCode = hashCode * 59 + this.LastUpdatedUser.GetHashCode();
                if (this.LastUpdatedDate != null)
                    hashCode = hashCode * 59 + this.LastUpdatedDate.GetHashCode();
                if (this.LastUpdateId != null)
                    hashCode = hashCode * 59 + this.LastUpdateId.GetHashCode();
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
