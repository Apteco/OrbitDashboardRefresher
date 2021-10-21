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
    /// TwitterToken
    /// </summary>
    [DataContract]
    public partial class TwitterToken :  IEquatable<TwitterToken>, IValidatableObject
    {
        /// <summary>
        /// Defines TwitterEntityType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TwitterEntityTypeEnum
        {
            
            /// <summary>
            /// Enum App for value: App
            /// </summary>
            [EnumMember(Value = "App")]
            App = 1,
            
            /// <summary>
            /// Enum Handle for value: Handle
            /// </summary>
            [EnumMember(Value = "Handle")]
            Handle = 2
        }

        /// <summary>
        /// Gets or Sets TwitterEntityType
        /// </summary>
        [DataMember(Name="twitterEntityType", EmitDefaultValue=false)]
        public TwitterEntityTypeEnum TwitterEntityType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TwitterToken" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TwitterToken() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TwitterToken" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="twitterEntityType">twitterEntityType (required).</param>
        /// <param name="systemName">systemName (required).</param>
        /// <param name="token">token.</param>
        /// <param name="tokenSecret">tokenSecret.</param>
        public TwitterToken(int? id = default(int?), TwitterEntityTypeEnum twitterEntityType = default(TwitterEntityTypeEnum), string systemName = default(string), string token = default(string), string tokenSecret = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for TwitterToken and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "twitterEntityType" is required (not null)
            if (twitterEntityType == null)
            {
                throw new InvalidDataException("twitterEntityType is a required property for TwitterToken and cannot be null");
            }
            else
            {
                this.TwitterEntityType = twitterEntityType;
            }
            // to ensure "systemName" is required (not null)
            if (systemName == null)
            {
                throw new InvalidDataException("systemName is a required property for TwitterToken and cannot be null");
            }
            else
            {
                this.SystemName = systemName;
            }
            this.Token = token;
            this.TokenSecret = tokenSecret;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }


        /// <summary>
        /// Gets or Sets SystemName
        /// </summary>
        [DataMember(Name="systemName", EmitDefaultValue=false)]
        public string SystemName { get; set; }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }

        /// <summary>
        /// Gets or Sets TokenSecret
        /// </summary>
        [DataMember(Name="tokenSecret", EmitDefaultValue=false)]
        public string TokenSecret { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TwitterToken {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TwitterEntityType: ").Append(TwitterEntityType).Append("\n");
            sb.Append("  SystemName: ").Append(SystemName).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  TokenSecret: ").Append(TokenSecret).Append("\n");
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
            return this.Equals(input as TwitterToken);
        }

        /// <summary>
        /// Returns true if TwitterToken instances are equal
        /// </summary>
        /// <param name="input">Instance of TwitterToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TwitterToken input)
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
                    this.TwitterEntityType == input.TwitterEntityType ||
                    (this.TwitterEntityType != null &&
                    this.TwitterEntityType.Equals(input.TwitterEntityType))
                ) && 
                (
                    this.SystemName == input.SystemName ||
                    (this.SystemName != null &&
                    this.SystemName.Equals(input.SystemName))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.TokenSecret == input.TokenSecret ||
                    (this.TokenSecret != null &&
                    this.TokenSecret.Equals(input.TokenSecret))
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
                if (this.TwitterEntityType != null)
                    hashCode = hashCode * 59 + this.TwitterEntityType.GetHashCode();
                if (this.SystemName != null)
                    hashCode = hashCode * 59 + this.SystemName.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.TokenSecret != null)
                    hashCode = hashCode * 59 + this.TokenSecret.GetHashCode();
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
