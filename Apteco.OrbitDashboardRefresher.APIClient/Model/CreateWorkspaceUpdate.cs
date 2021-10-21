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
    /// Details used to create a workspace update
    /// </summary>
    [DataContract]
    public partial class CreateWorkspaceUpdate :  IEquatable<CreateWorkspaceUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWorkspaceUpdate" /> class.
        /// </summary>
        /// <param name="title">The title of the workspace.</param>
        /// <param name="description">The description of the workspace.</param>
        /// <param name="isDeleted">Whether this workspace should be deleted or not.</param>
        /// <param name="resourcesToAdd">The list of keys for resources to add to this workspace.</param>
        /// <param name="resourcesToRemove">The list of keys for resources to remove from this workspace.</param>
        public CreateWorkspaceUpdate(string title = default(string), string description = default(string), bool? isDeleted = default(bool?), List<WorkspaceResourceKey> resourcesToAdd = default(List<WorkspaceResourceKey>), List<WorkspaceResourceKey> resourcesToRemove = default(List<WorkspaceResourceKey>))
        {
            this.Title = title;
            this.Description = description;
            this.IsDeleted = isDeleted;
            this.ResourcesToAdd = resourcesToAdd;
            this.ResourcesToRemove = resourcesToRemove;
        }
        
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
        /// Whether this workspace should be deleted or not
        /// </summary>
        /// <value>Whether this workspace should be deleted or not</value>
        [DataMember(Name="isDeleted", EmitDefaultValue=false)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// The list of keys for resources to add to this workspace
        /// </summary>
        /// <value>The list of keys for resources to add to this workspace</value>
        [DataMember(Name="resourcesToAdd", EmitDefaultValue=false)]
        public List<WorkspaceResourceKey> ResourcesToAdd { get; set; }

        /// <summary>
        /// The list of keys for resources to remove from this workspace
        /// </summary>
        /// <value>The list of keys for resources to remove from this workspace</value>
        [DataMember(Name="resourcesToRemove", EmitDefaultValue=false)]
        public List<WorkspaceResourceKey> ResourcesToRemove { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateWorkspaceUpdate {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  ResourcesToAdd: ").Append(ResourcesToAdd).Append("\n");
            sb.Append("  ResourcesToRemove: ").Append(ResourcesToRemove).Append("\n");
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
            return this.Equals(input as CreateWorkspaceUpdate);
        }

        /// <summary>
        /// Returns true if CreateWorkspaceUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateWorkspaceUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateWorkspaceUpdate input)
        {
            if (input == null)
                return false;

            return 
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
                    this.IsDeleted == input.IsDeleted ||
                    (this.IsDeleted != null &&
                    this.IsDeleted.Equals(input.IsDeleted))
                ) && 
                (
                    this.ResourcesToAdd == input.ResourcesToAdd ||
                    this.ResourcesToAdd != null &&
                    this.ResourcesToAdd.SequenceEqual(input.ResourcesToAdd)
                ) && 
                (
                    this.ResourcesToRemove == input.ResourcesToRemove ||
                    this.ResourcesToRemove != null &&
                    this.ResourcesToRemove.SequenceEqual(input.ResourcesToRemove)
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IsDeleted != null)
                    hashCode = hashCode * 59 + this.IsDeleted.GetHashCode();
                if (this.ResourcesToAdd != null)
                    hashCode = hashCode * 59 + this.ResourcesToAdd.GetHashCode();
                if (this.ResourcesToRemove != null)
                    hashCode = hashCode * 59 + this.ResourcesToRemove.GetHashCode();
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