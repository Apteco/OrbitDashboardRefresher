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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = Apteco.OrbitDashboardRefresher.APIClient.Client.SwaggerDateConverter;

namespace Apteco.OrbitDashboardRefresher.APIClient.Model
{
    /// <summary>
    /// The details of a particular endpoint in the API
    /// </summary>
    [DataContract]
    public partial class EndpointDetails :  IEquatable<EndpointDetails>
    {
        /// <summary>
        /// Defines RequiresLicenceFlags
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RequiresLicenceFlagsEnum
        {
            
            /// <summary>
            /// Enum AudienceSelection for value: AudienceSelection
            /// </summary>
            [EnumMember(Value = "AudienceSelection")]
            AudienceSelection = 1,
            
            /// <summary>
            /// Enum AudiencePreview for value: AudiencePreview
            /// </summary>
            [EnumMember(Value = "AudiencePreview")]
            AudiencePreview = 2,
            
            /// <summary>
            /// Enum Export for value: Export
            /// </summary>
            [EnumMember(Value = "Export")]
            Export = 3,
            
            /// <summary>
            /// Enum AdvancedQuery for value: AdvancedQuery
            /// </summary>
            [EnumMember(Value = "AdvancedQuery")]
            AdvancedQuery = 4,
            
            /// <summary>
            /// Enum Cube for value: Cube
            /// </summary>
            [EnumMember(Value = "Cube")]
            Cube = 5,
            
            /// <summary>
            /// Enum Profile for value: Profile
            /// </summary>
            [EnumMember(Value = "Profile")]
            Profile = 6,
            
            /// <summary>
            /// Enum Dashboards for value: Dashboards
            /// </summary>
            [EnumMember(Value = "Dashboards")]
            Dashboards = 7
        }


        /// <summary>
        /// The set of licence flags that the user must have in order to be able to call the endpoint
        /// </summary>
        /// <value>The set of licence flags that the user must have in order to be able to call the endpoint</value>
        [DataMember(Name="requiresLicenceFlags", EmitDefaultValue=false)]
        public List<RequiresLicenceFlagsEnum> RequiresLicenceFlags { get; set; }
        /// <summary>
        /// Defines OptionallyRequiresLicenceFlags
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OptionallyRequiresLicenceFlagsEnum
        {
            
            /// <summary>
            /// Enum AudienceSelection for value: AudienceSelection
            /// </summary>
            [EnumMember(Value = "AudienceSelection")]
            AudienceSelection = 1,
            
            /// <summary>
            /// Enum AudiencePreview for value: AudiencePreview
            /// </summary>
            [EnumMember(Value = "AudiencePreview")]
            AudiencePreview = 2,
            
            /// <summary>
            /// Enum Export for value: Export
            /// </summary>
            [EnumMember(Value = "Export")]
            Export = 3,
            
            /// <summary>
            /// Enum AdvancedQuery for value: AdvancedQuery
            /// </summary>
            [EnumMember(Value = "AdvancedQuery")]
            AdvancedQuery = 4,
            
            /// <summary>
            /// Enum Cube for value: Cube
            /// </summary>
            [EnumMember(Value = "Cube")]
            Cube = 5,
            
            /// <summary>
            /// Enum Profile for value: Profile
            /// </summary>
            [EnumMember(Value = "Profile")]
            Profile = 6,
            
            /// <summary>
            /// Enum Dashboards for value: Dashboards
            /// </summary>
            [EnumMember(Value = "Dashboards")]
            Dashboards = 7
        }


        /// <summary>
        /// The set of licence flags that the user might need to have in order to be able to call the endpoint, depending on the type of request sent to the endpoint
        /// </summary>
        /// <value>The set of licence flags that the user might need to have in order to be able to call the endpoint, depending on the type of request sent to the endpoint</value>
        [DataMember(Name="optionallyRequiresLicenceFlags", EmitDefaultValue=false)]
        public List<OptionallyRequiresLicenceFlagsEnum> OptionallyRequiresLicenceFlags { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EndpointDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointDetails" /> class.
        /// </summary>
        /// <param name="name">The name of the endpoint (required).</param>
        /// <param name="groupName">The name of the group this endpoint belongs to (required).</param>
        /// <param name="method">The HTTP method used for calling this endpoint (required).</param>
        /// <param name="urlTemplate">The URL template of this endpoint (required).</param>
        /// <param name="allowsAnonymousAccess">Whether this endpoint can be accessed without authentication details (required).</param>
        /// <param name="isExperimental">Whether this endpoint has been marked as experimental (required).</param>
        /// <param name="isUnderDevelopment">Whether this endpoint has been marked as under development (required).</param>
        /// <param name="requiresLicenceFlags">The set of licence flags that the user must have in order to be able to call the endpoint (required).</param>
        /// <param name="optionallyRequiresLicenceFlags">The set of licence flags that the user might need to have in order to be able to call the endpoint, depending on the type of request sent to the endpoint (required).</param>
        /// <param name="requiresRoles">Any roles that the user must have to access this endpoint (required).</param>
        public EndpointDetails(string name = default(string), string groupName = default(string), string method = default(string), string urlTemplate = default(string), bool? allowsAnonymousAccess = default(bool?), bool? isExperimental = default(bool?), bool? isUnderDevelopment = default(bool?), List<RequiresLicenceFlagsEnum> requiresLicenceFlags = default(List<RequiresLicenceFlagsEnum>), List<OptionallyRequiresLicenceFlagsEnum> optionallyRequiresLicenceFlags = default(List<OptionallyRequiresLicenceFlagsEnum>), List<string> requiresRoles = default(List<string>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for EndpointDetails and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "groupName" is required (not null)
            if (groupName == null)
            {
                throw new InvalidDataException("groupName is a required property for EndpointDetails and cannot be null");
            }
            else
            {
                this.GroupName = groupName;
            }
            // to ensure "method" is required (not null)
            if (method == null)
            {
                throw new InvalidDataException("method is a required property for EndpointDetails and cannot be null");
            }
            else
            {
                this.Method = method;
            }
            // to ensure "urlTemplate" is required (not null)
            if (urlTemplate == null)
            {
                throw new InvalidDataException("urlTemplate is a required property for EndpointDetails and cannot be null");
            }
            else
            {
                this.UrlTemplate = urlTemplate;
            }
            // to ensure "allowsAnonymousAccess" is required (not null)
            if (allowsAnonymousAccess == null)
            {
                throw new InvalidDataException("allowsAnonymousAccess is a required property for EndpointDetails and cannot be null");
            }
            else
            {
                this.AllowsAnonymousAccess = allowsAnonymousAccess;
            }
            // to ensure "isExperimental" is required (not null)
            if (isExperimental == null)
            {
                throw new InvalidDataException("isExperimental is a required property for EndpointDetails and cannot be null");
            }
            else
            {
                this.IsExperimental = isExperimental;
            }
            // to ensure "isUnderDevelopment" is required (not null)
            if (isUnderDevelopment == null)
            {
                throw new InvalidDataException("isUnderDevelopment is a required property for EndpointDetails and cannot be null");
            }
            else
            {
                this.IsUnderDevelopment = isUnderDevelopment;
            }
            // to ensure "requiresLicenceFlags" is required (not null)
            if (requiresLicenceFlags == null)
            {
                throw new InvalidDataException("requiresLicenceFlags is a required property for EndpointDetails and cannot be null");
            }
            else
            {
                this.RequiresLicenceFlags = requiresLicenceFlags;
            }
            // to ensure "optionallyRequiresLicenceFlags" is required (not null)
            if (optionallyRequiresLicenceFlags == null)
            {
                throw new InvalidDataException("optionallyRequiresLicenceFlags is a required property for EndpointDetails and cannot be null");
            }
            else
            {
                this.OptionallyRequiresLicenceFlags = optionallyRequiresLicenceFlags;
            }
            // to ensure "requiresRoles" is required (not null)
            if (requiresRoles == null)
            {
                throw new InvalidDataException("requiresRoles is a required property for EndpointDetails and cannot be null");
            }
            else
            {
                this.RequiresRoles = requiresRoles;
            }
        }
        
        /// <summary>
        /// The name of the endpoint
        /// </summary>
        /// <value>The name of the endpoint</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The name of the group this endpoint belongs to
        /// </summary>
        /// <value>The name of the group this endpoint belongs to</value>
        [DataMember(Name="groupName", EmitDefaultValue=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// The HTTP method used for calling this endpoint
        /// </summary>
        /// <value>The HTTP method used for calling this endpoint</value>
        [DataMember(Name="method", EmitDefaultValue=false)]
        public string Method { get; set; }

        /// <summary>
        /// The URL template of this endpoint
        /// </summary>
        /// <value>The URL template of this endpoint</value>
        [DataMember(Name="urlTemplate", EmitDefaultValue=false)]
        public string UrlTemplate { get; set; }

        /// <summary>
        /// Whether this endpoint can be accessed without authentication details
        /// </summary>
        /// <value>Whether this endpoint can be accessed without authentication details</value>
        [DataMember(Name="allowsAnonymousAccess", EmitDefaultValue=false)]
        public bool? AllowsAnonymousAccess { get; set; }

        /// <summary>
        /// Whether this endpoint has been marked as experimental
        /// </summary>
        /// <value>Whether this endpoint has been marked as experimental</value>
        [DataMember(Name="isExperimental", EmitDefaultValue=false)]
        public bool? IsExperimental { get; set; }

        /// <summary>
        /// Whether this endpoint has been marked as under development
        /// </summary>
        /// <value>Whether this endpoint has been marked as under development</value>
        [DataMember(Name="isUnderDevelopment", EmitDefaultValue=false)]
        public bool? IsUnderDevelopment { get; set; }



        /// <summary>
        /// Any roles that the user must have to access this endpoint
        /// </summary>
        /// <value>Any roles that the user must have to access this endpoint</value>
        [DataMember(Name="requiresRoles", EmitDefaultValue=false)]
        public List<string> RequiresRoles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EndpointDetails {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  UrlTemplate: ").Append(UrlTemplate).Append("\n");
            sb.Append("  AllowsAnonymousAccess: ").Append(AllowsAnonymousAccess).Append("\n");
            sb.Append("  IsExperimental: ").Append(IsExperimental).Append("\n");
            sb.Append("  IsUnderDevelopment: ").Append(IsUnderDevelopment).Append("\n");
            sb.Append("  RequiresLicenceFlags: ").Append(RequiresLicenceFlags).Append("\n");
            sb.Append("  OptionallyRequiresLicenceFlags: ").Append(OptionallyRequiresLicenceFlags).Append("\n");
            sb.Append("  RequiresRoles: ").Append(RequiresRoles).Append("\n");
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
            return this.Equals(input as EndpointDetails);
        }

        /// <summary>
        /// Returns true if EndpointDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of EndpointDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EndpointDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.GroupName == input.GroupName ||
                    (this.GroupName != null &&
                    this.GroupName.Equals(input.GroupName))
                ) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
                ) && 
                (
                    this.UrlTemplate == input.UrlTemplate ||
                    (this.UrlTemplate != null &&
                    this.UrlTemplate.Equals(input.UrlTemplate))
                ) && 
                (
                    this.AllowsAnonymousAccess == input.AllowsAnonymousAccess ||
                    (this.AllowsAnonymousAccess != null &&
                    this.AllowsAnonymousAccess.Equals(input.AllowsAnonymousAccess))
                ) && 
                (
                    this.IsExperimental == input.IsExperimental ||
                    (this.IsExperimental != null &&
                    this.IsExperimental.Equals(input.IsExperimental))
                ) && 
                (
                    this.IsUnderDevelopment == input.IsUnderDevelopment ||
                    (this.IsUnderDevelopment != null &&
                    this.IsUnderDevelopment.Equals(input.IsUnderDevelopment))
                ) && 
                (
                    this.RequiresLicenceFlags == input.RequiresLicenceFlags ||
                    this.RequiresLicenceFlags != null &&
                    this.RequiresLicenceFlags.SequenceEqual(input.RequiresLicenceFlags)
                ) && 
                (
                    this.OptionallyRequiresLicenceFlags == input.OptionallyRequiresLicenceFlags ||
                    this.OptionallyRequiresLicenceFlags != null &&
                    this.OptionallyRequiresLicenceFlags.SequenceEqual(input.OptionallyRequiresLicenceFlags)
                ) && 
                (
                    this.RequiresRoles == input.RequiresRoles ||
                    this.RequiresRoles != null &&
                    this.RequiresRoles.SequenceEqual(input.RequiresRoles)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.GroupName != null)
                    hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.Method != null)
                    hashCode = hashCode * 59 + this.Method.GetHashCode();
                if (this.UrlTemplate != null)
                    hashCode = hashCode * 59 + this.UrlTemplate.GetHashCode();
                if (this.AllowsAnonymousAccess != null)
                    hashCode = hashCode * 59 + this.AllowsAnonymousAccess.GetHashCode();
                if (this.IsExperimental != null)
                    hashCode = hashCode * 59 + this.IsExperimental.GetHashCode();
                if (this.IsUnderDevelopment != null)
                    hashCode = hashCode * 59 + this.IsUnderDevelopment.GetHashCode();
                if (this.RequiresLicenceFlags != null)
                    hashCode = hashCode * 59 + this.RequiresLicenceFlags.GetHashCode();
                if (this.OptionallyRequiresLicenceFlags != null)
                    hashCode = hashCode * 59 + this.OptionallyRequiresLicenceFlags.GetHashCode();
                if (this.RequiresRoles != null)
                    hashCode = hashCode * 59 + this.RequiresRoles.GetHashCode();
                return hashCode;
            }
        }
    }

}
