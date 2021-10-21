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
    /// Details for a permission in the system
    /// </summary>
    [DataContract]
    public partial class AuthorisedPermission :  IEquatable<AuthorisedPermission>, IValidatableObject
    {
        /// <summary>
        /// Defines PermissionType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PermissionTypeEnum
        {
            
            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 1,
            
            /// <summary>
            /// Enum AccessRights for value: AccessRights
            /// </summary>
            [EnumMember(Value = "AccessRights")]
            AccessRights = 2,
            
            /// <summary>
            /// Enum UsageRights for value: UsageRights
            /// </summary>
            [EnumMember(Value = "UsageRights")]
            UsageRights = 3,
            
            /// <summary>
            /// Enum VariableUsageRights for value: VariableUsageRights
            /// </summary>
            [EnumMember(Value = "VariableUsageRights")]
            VariableUsageRights = 4
        }

        /// <summary>
        /// Gets or Sets PermissionType
        /// </summary>
        [DataMember(Name="permissionType", EmitDefaultValue=false)]
        public PermissionTypeEnum PermissionType { get; set; }
        /// <summary>
        /// Defines ResourceType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResourceTypeEnum
        {
            
            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 1,
            
            /// <summary>
            /// Enum File for value: File
            /// </summary>
            [EnumMember(Value = "File")]
            File = 2,
            
            /// <summary>
            /// Enum PeopleStageElement for value: PeopleStageElement
            /// </summary>
            [EnumMember(Value = "PeopleStageElement")]
            PeopleStageElement = 3,
            
            /// <summary>
            /// Enum PeopleStageDiagram for value: PeopleStageDiagram
            /// </summary>
            [EnumMember(Value = "PeopleStageDiagram")]
            PeopleStageDiagram = 4,
            
            /// <summary>
            /// Enum PeopleStageSeed for value: PeopleStageSeed
            /// </summary>
            [EnumMember(Value = "PeopleStageSeed")]
            PeopleStageSeed = 5,
            
            /// <summary>
            /// Enum PeopleStageSeedSet for value: PeopleStageSeedSet
            /// </summary>
            [EnumMember(Value = "PeopleStageSeedSet")]
            PeopleStageSeedSet = 6,
            
            /// <summary>
            /// Enum PeopleStageChannel for value: PeopleStageChannel
            /// </summary>
            [EnumMember(Value = "PeopleStageChannel")]
            PeopleStageChannel = 7,
            
            /// <summary>
            /// Enum PeopleStageAggregation for value: PeopleStageAggregation
            /// </summary>
            [EnumMember(Value = "PeopleStageAggregation")]
            PeopleStageAggregation = 8,
            
            /// <summary>
            /// Enum PeopleStageVoucherSet for value: PeopleStageVoucherSet
            /// </summary>
            [EnumMember(Value = "PeopleStageVoucherSet")]
            PeopleStageVoucherSet = 9,
            
            /// <summary>
            /// Enum PeopleStageTemplate for value: PeopleStageTemplate
            /// </summary>
            [EnumMember(Value = "PeopleStageTemplate")]
            PeopleStageTemplate = 10,
            
            /// <summary>
            /// Enum CascadeElement for value: CascadeElement
            /// </summary>
            [EnumMember(Value = "CascadeElement")]
            CascadeElement = 11,
            
            /// <summary>
            /// Enum FastStatsElement for value: FastStatsElement
            /// </summary>
            [EnumMember(Value = "FastStatsElement")]
            FastStatsElement = 12,
            
            /// <summary>
            /// Enum UserElement for value: UserElement
            /// </summary>
            [EnumMember(Value = "UserElement")]
            UserElement = 13
        }

        /// <summary>
        /// Gets or Sets ResourceType
        /// </summary>
        [DataMember(Name="resourceType", EmitDefaultValue=false)]
        public ResourceTypeEnum ResourceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorisedPermission" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuthorisedPermission() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorisedPermission" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="permission">permission.</param>
        /// <param name="permissionType">permissionType (required).</param>
        /// <param name="resource">resource.</param>
        /// <param name="resourceType">resourceType (required).</param>
        /// <param name="grant">grant (required).</param>
        /// <param name="deny">deny (required).</param>
        /// <param name="inherit">inherit (required).</param>
        /// <param name="permissionSet">permissionSet.</param>
        /// <param name="authority">authority.</param>
        /// <param name="group">group.</param>
        public AuthorisedPermission(int? id = default(int?), Object permission = default(Object), PermissionTypeEnum permissionType = default(PermissionTypeEnum), string resource = default(string), ResourceTypeEnum resourceType = default(ResourceTypeEnum), bool? grant = default(bool?), bool? deny = default(bool?), bool? inherit = default(bool?), PermissionSet permissionSet = default(PermissionSet), Authority authority = default(Authority), GroupSummary group = default(GroupSummary))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for AuthorisedPermission and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "permissionType" is required (not null)
            if (permissionType == null)
            {
                throw new InvalidDataException("permissionType is a required property for AuthorisedPermission and cannot be null");
            }
            else
            {
                this.PermissionType = permissionType;
            }
            // to ensure "resourceType" is required (not null)
            if (resourceType == null)
            {
                throw new InvalidDataException("resourceType is a required property for AuthorisedPermission and cannot be null");
            }
            else
            {
                this.ResourceType = resourceType;
            }
            // to ensure "grant" is required (not null)
            if (grant == null)
            {
                throw new InvalidDataException("grant is a required property for AuthorisedPermission and cannot be null");
            }
            else
            {
                this.Grant = grant;
            }
            // to ensure "deny" is required (not null)
            if (deny == null)
            {
                throw new InvalidDataException("deny is a required property for AuthorisedPermission and cannot be null");
            }
            else
            {
                this.Deny = deny;
            }
            // to ensure "inherit" is required (not null)
            if (inherit == null)
            {
                throw new InvalidDataException("inherit is a required property for AuthorisedPermission and cannot be null");
            }
            else
            {
                this.Inherit = inherit;
            }
            this.Permission = permission;
            this.Resource = resource;
            this.PermissionSet = permissionSet;
            this.Authority = authority;
            this.Group = group;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Permission
        /// </summary>
        [DataMember(Name="permission", EmitDefaultValue=false)]
        public Object Permission { get; set; }


        /// <summary>
        /// Gets or Sets Resource
        /// </summary>
        [DataMember(Name="resource", EmitDefaultValue=false)]
        public string Resource { get; set; }


        /// <summary>
        /// Gets or Sets Grant
        /// </summary>
        [DataMember(Name="grant", EmitDefaultValue=false)]
        public bool? Grant { get; set; }

        /// <summary>
        /// Gets or Sets Deny
        /// </summary>
        [DataMember(Name="deny", EmitDefaultValue=false)]
        public bool? Deny { get; set; }

        /// <summary>
        /// Gets or Sets Inherit
        /// </summary>
        [DataMember(Name="inherit", EmitDefaultValue=false)]
        public bool? Inherit { get; set; }

        /// <summary>
        /// Gets or Sets PermissionSet
        /// </summary>
        [DataMember(Name="permissionSet", EmitDefaultValue=false)]
        public PermissionSet PermissionSet { get; set; }

        /// <summary>
        /// Gets or Sets Authority
        /// </summary>
        [DataMember(Name="authority", EmitDefaultValue=false)]
        public Authority Authority { get; set; }

        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public GroupSummary Group { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthorisedPermission {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Permission: ").Append(Permission).Append("\n");
            sb.Append("  PermissionType: ").Append(PermissionType).Append("\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
            sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  Grant: ").Append(Grant).Append("\n");
            sb.Append("  Deny: ").Append(Deny).Append("\n");
            sb.Append("  Inherit: ").Append(Inherit).Append("\n");
            sb.Append("  PermissionSet: ").Append(PermissionSet).Append("\n");
            sb.Append("  Authority: ").Append(Authority).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
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
            return this.Equals(input as AuthorisedPermission);
        }

        /// <summary>
        /// Returns true if AuthorisedPermission instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthorisedPermission to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthorisedPermission input)
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
                    this.Permission == input.Permission ||
                    (this.Permission != null &&
                    this.Permission.Equals(input.Permission))
                ) && 
                (
                    this.PermissionType == input.PermissionType ||
                    (this.PermissionType != null &&
                    this.PermissionType.Equals(input.PermissionType))
                ) && 
                (
                    this.Resource == input.Resource ||
                    (this.Resource != null &&
                    this.Resource.Equals(input.Resource))
                ) && 
                (
                    this.ResourceType == input.ResourceType ||
                    (this.ResourceType != null &&
                    this.ResourceType.Equals(input.ResourceType))
                ) && 
                (
                    this.Grant == input.Grant ||
                    (this.Grant != null &&
                    this.Grant.Equals(input.Grant))
                ) && 
                (
                    this.Deny == input.Deny ||
                    (this.Deny != null &&
                    this.Deny.Equals(input.Deny))
                ) && 
                (
                    this.Inherit == input.Inherit ||
                    (this.Inherit != null &&
                    this.Inherit.Equals(input.Inherit))
                ) && 
                (
                    this.PermissionSet == input.PermissionSet ||
                    (this.PermissionSet != null &&
                    this.PermissionSet.Equals(input.PermissionSet))
                ) && 
                (
                    this.Authority == input.Authority ||
                    (this.Authority != null &&
                    this.Authority.Equals(input.Authority))
                ) && 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
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
                if (this.Permission != null)
                    hashCode = hashCode * 59 + this.Permission.GetHashCode();
                if (this.PermissionType != null)
                    hashCode = hashCode * 59 + this.PermissionType.GetHashCode();
                if (this.Resource != null)
                    hashCode = hashCode * 59 + this.Resource.GetHashCode();
                if (this.ResourceType != null)
                    hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.Grant != null)
                    hashCode = hashCode * 59 + this.Grant.GetHashCode();
                if (this.Deny != null)
                    hashCode = hashCode * 59 + this.Deny.GetHashCode();
                if (this.Inherit != null)
                    hashCode = hashCode * 59 + this.Inherit.GetHashCode();
                if (this.PermissionSet != null)
                    hashCode = hashCode * 59 + this.PermissionSet.GetHashCode();
                if (this.Authority != null)
                    hashCode = hashCode * 59 + this.Authority.GetHashCode();
                if (this.Group != null)
                    hashCode = hashCode * 59 + this.Group.GetHashCode();
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