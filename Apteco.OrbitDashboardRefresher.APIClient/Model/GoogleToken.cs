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
    /// GoogleToken
    /// </summary>
    [DataContract]
    public partial class GoogleToken :  IEquatable<GoogleToken>
    {
        /// <summary>
        /// Defines GoogleEntityType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GoogleEntityTypeEnum
        {
            
            /// <summary>
            /// Enum App for value: App
            /// </summary>
            [EnumMember(Value = "App")]
            App = 1,
            
            /// <summary>
            /// Enum Account for value: Account
            /// </summary>
            [EnumMember(Value = "Account")]
            Account = 2
        }

        /// <summary>
        /// Gets or Sets GoogleEntityType
        /// </summary>
        [DataMember(Name="googleEntityType", EmitDefaultValue=false)]
        public GoogleEntityTypeEnum GoogleEntityType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleToken" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GoogleToken() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleToken" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="googleEntityType">googleEntityType (required).</param>
        /// <param name="systemName">systemName (required).</param>
        /// <param name="token">token.</param>
        public GoogleToken(int? id = default(int?), GoogleEntityTypeEnum googleEntityType = default(GoogleEntityTypeEnum), string systemName = default(string), string token = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for GoogleToken and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "googleEntityType" is required (not null)
            if (googleEntityType == null)
            {
                throw new InvalidDataException("googleEntityType is a required property for GoogleToken and cannot be null");
            }
            else
            {
                this.GoogleEntityType = googleEntityType;
            }
            // to ensure "systemName" is required (not null)
            if (systemName == null)
            {
                throw new InvalidDataException("systemName is a required property for GoogleToken and cannot be null");
            }
            else
            {
                this.SystemName = systemName;
            }
            this.Token = token;
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GoogleToken {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  GoogleEntityType: ").Append(GoogleEntityType).Append("\n");
            sb.Append("  SystemName: ").Append(SystemName).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
            return this.Equals(input as GoogleToken);
        }

        /// <summary>
        /// Returns true if GoogleToken instances are equal
        /// </summary>
        /// <param name="input">Instance of GoogleToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoogleToken input)
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
                    this.GoogleEntityType == input.GoogleEntityType ||
                    (this.GoogleEntityType != null &&
                    this.GoogleEntityType.Equals(input.GoogleEntityType))
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
                if (this.GoogleEntityType != null)
                    hashCode = hashCode * 59 + this.GoogleEntityType.GetHashCode();
                if (this.SystemName != null)
                    hashCode = hashCode * 59 + this.SystemName.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                return hashCode;
            }
        }
    }

}
