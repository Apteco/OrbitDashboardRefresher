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
    /// Information for a PeopleStage Channel Message
    /// </summary>
    [DataContract]
    public partial class ChannelMessage :  IEquatable<ChannelMessage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChannelMessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelMessage" /> class.
        /// </summary>
        /// <param name="id">The message&#39;s id (required).</param>
        /// <param name="description">The message&#39;s description (required).</param>
        public ChannelMessage(string id = default(string), string description = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for ChannelMessage and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for ChannelMessage and cannot be null");
            }
            else
            {
                this.Description = description;
            }
        }
        
        /// <summary>
        /// The message&#39;s id
        /// </summary>
        /// <value>The message&#39;s id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The message&#39;s description
        /// </summary>
        /// <value>The message&#39;s description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelMessage {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as ChannelMessage);
        }

        /// <summary>
        /// Returns true if ChannelMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of ChannelMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelMessage input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }

}
