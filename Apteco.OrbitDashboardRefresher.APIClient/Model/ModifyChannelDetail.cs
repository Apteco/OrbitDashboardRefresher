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
    /// ModifyChannelDetail
    /// </summary>
    [DataContract]
    public partial class ModifyChannelDetail :  IEquatable<ModifyChannelDetail>, IValidatableObject
    {
        /// <summary>
        /// The channel&#39;s type
        /// </summary>
        /// <value>The channel&#39;s type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 1,
            
            /// <summary>
            /// Enum Control for value: Control
            /// </summary>
            [EnumMember(Value = "Control")]
            Control = 2,
            
            /// <summary>
            /// Enum Broadcast for value: Broadcast
            /// </summary>
            [EnumMember(Value = "Broadcast")]
            Broadcast = 3,
            
            /// <summary>
            /// Enum File for value: File
            /// </summary>
            [EnumMember(Value = "File")]
            File = 4,
            
            /// <summary>
            /// Enum Ftp for value: Ftp
            /// </summary>
            [EnumMember(Value = "Ftp")]
            Ftp = 5,
            
            /// <summary>
            /// Enum Facebook for value: Facebook
            /// </summary>
            [EnumMember(Value = "Facebook")]
            Facebook = 6,
            
            /// <summary>
            /// Enum MicrosoftDynamics for value: MicrosoftDynamics
            /// </summary>
            [EnumMember(Value = "MicrosoftDynamics")]
            MicrosoftDynamics = 7,
            
            /// <summary>
            /// Enum SalesForce for value: SalesForce
            /// </summary>
            [EnumMember(Value = "SalesForce")]
            SalesForce = 8,
            
            /// <summary>
            /// Enum PushNotification for value: PushNotification
            /// </summary>
            [EnumMember(Value = "PushNotification")]
            PushNotification = 9,
            
            /// <summary>
            /// Enum Twitter for value: Twitter
            /// </summary>
            [EnumMember(Value = "Twitter")]
            Twitter = 10,
            
            /// <summary>
            /// Enum Google for value: Google
            /// </summary>
            [EnumMember(Value = "Google")]
            Google = 11,
            
            /// <summary>
            /// Enum LinkedIn for value: LinkedIn
            /// </summary>
            [EnumMember(Value = "LinkedIn")]
            LinkedIn = 12,
            
            /// <summary>
            /// Enum PullMarketing for value: PullMarketing
            /// </summary>
            [EnumMember(Value = "PullMarketing")]
            PullMarketing = 13,
            
            /// <summary>
            /// Enum Composite for value: Composite
            /// </summary>
            [EnumMember(Value = "Composite")]
            Composite = 14
        }

        /// <summary>
        /// The channel&#39;s type
        /// </summary>
        /// <value>The channel&#39;s type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyChannelDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ModifyChannelDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyChannelDetail" /> class.
        /// </summary>
        /// <param name="description">The channel&#39;s description (required).</param>
        /// <param name="type">The channel&#39;s type (required).</param>
        /// <param name="parentId">The id of the channel&#39;s parent.</param>
        /// <param name="broadcastOutputSettings">The broadcast settings for the channel (if channel is a broadcast channel).</param>
        /// <param name="children">The channel&#39;s children (only if channel is a Composite channel).</param>
        /// <param name="systemLookup">Lookup for channel&#39;s variables.</param>
        public ModifyChannelDetail(string description = default(string), TypeEnum type = default(TypeEnum), string parentId = default(string), ModifyBroadcastOutputSettings broadcastOutputSettings = default(ModifyBroadcastOutputSettings), List<ModifyChannel> children = default(List<ModifyChannel>), SystemLookup systemLookup = default(SystemLookup))
        {
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for ModifyChannelDetail and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for ModifyChannelDetail and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.ParentId = parentId;
            this.BroadcastOutputSettings = broadcastOutputSettings;
            this.Children = children;
            this.SystemLookup = systemLookup;
        }
        
        /// <summary>
        /// The channel&#39;s description
        /// </summary>
        /// <value>The channel&#39;s description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }


        /// <summary>
        /// The id of the channel&#39;s parent
        /// </summary>
        /// <value>The id of the channel&#39;s parent</value>
        [DataMember(Name="parentId", EmitDefaultValue=false)]
        public string ParentId { get; set; }

        /// <summary>
        /// The broadcast settings for the channel (if channel is a broadcast channel)
        /// </summary>
        /// <value>The broadcast settings for the channel (if channel is a broadcast channel)</value>
        [DataMember(Name="broadcastOutputSettings", EmitDefaultValue=false)]
        public ModifyBroadcastOutputSettings BroadcastOutputSettings { get; set; }

        /// <summary>
        /// The channel&#39;s children (only if channel is a Composite channel)
        /// </summary>
        /// <value>The channel&#39;s children (only if channel is a Composite channel)</value>
        [DataMember(Name="children", EmitDefaultValue=false)]
        public List<ModifyChannel> Children { get; set; }

        /// <summary>
        /// Lookup for channel&#39;s variables
        /// </summary>
        /// <value>Lookup for channel&#39;s variables</value>
        [DataMember(Name="systemLookup", EmitDefaultValue=false)]
        public SystemLookup SystemLookup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyChannelDetail {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  BroadcastOutputSettings: ").Append(BroadcastOutputSettings).Append("\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
            sb.Append("  SystemLookup: ").Append(SystemLookup).Append("\n");
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
            return this.Equals(input as ModifyChannelDetail);
        }

        /// <summary>
        /// Returns true if ModifyChannelDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of ModifyChannelDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModifyChannelDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
                ) && 
                (
                    this.BroadcastOutputSettings == input.BroadcastOutputSettings ||
                    (this.BroadcastOutputSettings != null &&
                    this.BroadcastOutputSettings.Equals(input.BroadcastOutputSettings))
                ) && 
                (
                    this.Children == input.Children ||
                    this.Children != null &&
                    this.Children.SequenceEqual(input.Children)
                ) && 
                (
                    this.SystemLookup == input.SystemLookup ||
                    (this.SystemLookup != null &&
                    this.SystemLookup.Equals(input.SystemLookup))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ParentId != null)
                    hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.BroadcastOutputSettings != null)
                    hashCode = hashCode * 59 + this.BroadcastOutputSettings.GetHashCode();
                if (this.Children != null)
                    hashCode = hashCode * 59 + this.Children.GetHashCode();
                if (this.SystemLookup != null)
                    hashCode = hashCode * 59 + this.SystemLookup.GetHashCode();
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