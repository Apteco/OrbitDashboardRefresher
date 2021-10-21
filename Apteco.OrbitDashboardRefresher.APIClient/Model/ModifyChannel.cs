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
    /// ModifyChannel
    /// </summary>
    [DataContract]
    public partial class ModifyChannel :  IEquatable<ModifyChannel>, IValidatableObject
    {
        /// <summary>
        /// The type of modification to perform.  If the type is delete any other specified channel details will be ignored
        /// </summary>
        /// <value>The type of modification to perform.  If the type is delete any other specified channel details will be ignored</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ModificationTypeEnum
        {
            
            /// <summary>
            /// Enum Modify for value: Modify
            /// </summary>
            [EnumMember(Value = "Modify")]
            Modify = 1,
            
            /// <summary>
            /// Enum Delete for value: Delete
            /// </summary>
            [EnumMember(Value = "Delete")]
            Delete = 2,
            
            /// <summary>
            /// Enum Add for value: Add
            /// </summary>
            [EnumMember(Value = "Add")]
            Add = 3,
            
            /// <summary>
            /// Enum Move for value: Move
            /// </summary>
            [EnumMember(Value = "Move")]
            Move = 4
        }

        /// <summary>
        /// The type of modification to perform.  If the type is delete any other specified channel details will be ignored
        /// </summary>
        /// <value>The type of modification to perform.  If the type is delete any other specified channel details will be ignored</value>
        [DataMember(Name="modificationType", EmitDefaultValue=false)]
        public ModificationTypeEnum ModificationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyChannel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ModifyChannel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyChannel" /> class.
        /// </summary>
        /// <param name="id">The id of the channel to update (required).</param>
        /// <param name="modificationType">The type of modification to perform.  If the type is delete any other specified channel details will be ignored (required).</param>
        /// <param name="channel">The channel to modify.</param>
        public ModifyChannel(string id = default(string), ModificationTypeEnum modificationType = default(ModificationTypeEnum), ModifyChannelDetail channel = default(ModifyChannelDetail))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for ModifyChannel and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "modificationType" is required (not null)
            if (modificationType == null)
            {
                throw new InvalidDataException("modificationType is a required property for ModifyChannel and cannot be null");
            }
            else
            {
                this.ModificationType = modificationType;
            }
            this.Channel = channel;
        }
        
        /// <summary>
        /// The id of the channel to update
        /// </summary>
        /// <value>The id of the channel to update</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }


        /// <summary>
        /// The channel to modify
        /// </summary>
        /// <value>The channel to modify</value>
        [DataMember(Name="channel", EmitDefaultValue=false)]
        public ModifyChannelDetail Channel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyChannel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ModificationType: ").Append(ModificationType).Append("\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
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
            return this.Equals(input as ModifyChannel);
        }

        /// <summary>
        /// Returns true if ModifyChannel instances are equal
        /// </summary>
        /// <param name="input">Instance of ModifyChannel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModifyChannel input)
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
                    this.ModificationType == input.ModificationType ||
                    (this.ModificationType != null &&
                    this.ModificationType.Equals(input.ModificationType))
                ) && 
                (
                    this.Channel == input.Channel ||
                    (this.Channel != null &&
                    this.Channel.Equals(input.Channel))
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
                if (this.ModificationType != null)
                    hashCode = hashCode * 59 + this.ModificationType.GetHashCode();
                if (this.Channel != null)
                    hashCode = hashCode * 59 + this.Channel.GetHashCode();
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
