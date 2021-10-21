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
    /// Summary for a collection hit
    /// </summary>
    [DataContract]
    public partial class CollectionHitSummary :  IEquatable<CollectionHitSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionHitSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CollectionHitSummary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionHitSummary" /> class.
        /// </summary>
        /// <param name="id">The id of the hit itself (required).</param>
        /// <param name="collectionId">The id of the collection viewed (required).</param>
        /// <param name="timestamp">The timestamp of when the hit was recorded (required).</param>
        /// <param name="user">Details of the user that viewed the collection (required).</param>
        public CollectionHitSummary(int? id = default(int?), int? collectionId = default(int?), DateTime? timestamp = default(DateTime?), UserDisplayDetails user = default(UserDisplayDetails))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for CollectionHitSummary and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "collectionId" is required (not null)
            if (collectionId == null)
            {
                throw new InvalidDataException("collectionId is a required property for CollectionHitSummary and cannot be null");
            }
            else
            {
                this.CollectionId = collectionId;
            }
            // to ensure "timestamp" is required (not null)
            if (timestamp == null)
            {
                throw new InvalidDataException("timestamp is a required property for CollectionHitSummary and cannot be null");
            }
            else
            {
                this.Timestamp = timestamp;
            }
            // to ensure "user" is required (not null)
            if (user == null)
            {
                throw new InvalidDataException("user is a required property for CollectionHitSummary and cannot be null");
            }
            else
            {
                this.User = user;
            }
        }
        
        /// <summary>
        /// The id of the hit itself
        /// </summary>
        /// <value>The id of the hit itself</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The id of the collection viewed
        /// </summary>
        /// <value>The id of the collection viewed</value>
        [DataMember(Name="collectionId", EmitDefaultValue=false)]
        public int? CollectionId { get; set; }

        /// <summary>
        /// The timestamp of when the hit was recorded
        /// </summary>
        /// <value>The timestamp of when the hit was recorded</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Details of the user that viewed the collection
        /// </summary>
        /// <value>Details of the user that viewed the collection</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserDisplayDetails User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CollectionHitSummary {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CollectionId: ").Append(CollectionId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(input as CollectionHitSummary);
        }

        /// <summary>
        /// Returns true if CollectionHitSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of CollectionHitSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CollectionHitSummary input)
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
                    this.CollectionId == input.CollectionId ||
                    (this.CollectionId != null &&
                    this.CollectionId.Equals(input.CollectionId))
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
                if (this.CollectionId != null)
                    hashCode = hashCode * 59 + this.CollectionId.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
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
