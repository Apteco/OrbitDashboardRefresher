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
    /// The details of a particular static resource
    /// </summary>
    [DataContract]
    public partial class ResourceDetails :  IEquatable<ResourceDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResourceDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceDetails" /> class.
        /// </summary>
        /// <param name="name">The name of the resource (required).</param>
        /// <param name="id">The id of the resource (required).</param>
        /// <param name="size">The size of the resource in bytes (required).</param>
        /// <param name="lastModified">The datetime that the resource was last modified (required).</param>
        /// <param name="url">The API URL to access the content of the resource (required).</param>
        public ResourceDetails(string name = default(string), int? id = default(int?), long? size = default(long?), DateTime? lastModified = default(DateTime?), string url = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for ResourceDetails and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for ResourceDetails and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "size" is required (not null)
            if (size == null)
            {
                throw new InvalidDataException("size is a required property for ResourceDetails and cannot be null");
            }
            else
            {
                this.Size = size;
            }
            // to ensure "lastModified" is required (not null)
            if (lastModified == null)
            {
                throw new InvalidDataException("lastModified is a required property for ResourceDetails and cannot be null");
            }
            else
            {
                this.LastModified = lastModified;
            }
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new InvalidDataException("url is a required property for ResourceDetails and cannot be null");
            }
            else
            {
                this.Url = url;
            }
        }
        
        /// <summary>
        /// The name of the resource
        /// </summary>
        /// <value>The name of the resource</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The id of the resource
        /// </summary>
        /// <value>The id of the resource</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The size of the resource in bytes
        /// </summary>
        /// <value>The size of the resource in bytes</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public long? Size { get; set; }

        /// <summary>
        /// The datetime that the resource was last modified
        /// </summary>
        /// <value>The datetime that the resource was last modified</value>
        [DataMember(Name="lastModified", EmitDefaultValue=false)]
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// The API URL to access the content of the resource
        /// </summary>
        /// <value>The API URL to access the content of the resource</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceDetails {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as ResourceDetails);
        }

        /// <summary>
        /// Returns true if ResourceDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ResourceDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResourceDetails input)
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.LastModified == input.LastModified ||
                    (this.LastModified != null &&
                    this.LastModified.Equals(input.LastModified))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.LastModified != null)
                    hashCode = hashCode * 59 + this.LastModified.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                return hashCode;
            }
        }
    }

}
