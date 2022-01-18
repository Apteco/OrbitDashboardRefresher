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
    /// The results returned for a dimension defined in the cube
    /// </summary>
    [DataContract]
    public partial class DimensionResult :  IEquatable<DimensionResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DimensionResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DimensionResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DimensionResult" /> class.
        /// </summary>
        /// <param name="id">The id of the dimension (required).</param>
        /// <param name="headerCodes">A set of tab-delimited codes, one for each category in the dimension (required).</param>
        /// <param name="headerDescriptions">A set of tab-delimited descriptions, one for each category in the dimension (required).</param>
        public DimensionResult(string id = default(string), string headerCodes = default(string), string headerDescriptions = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for DimensionResult and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "headerCodes" is required (not null)
            if (headerCodes == null)
            {
                throw new InvalidDataException("headerCodes is a required property for DimensionResult and cannot be null");
            }
            else
            {
                this.HeaderCodes = headerCodes;
            }
            // to ensure "headerDescriptions" is required (not null)
            if (headerDescriptions == null)
            {
                throw new InvalidDataException("headerDescriptions is a required property for DimensionResult and cannot be null");
            }
            else
            {
                this.HeaderDescriptions = headerDescriptions;
            }
        }
        
        /// <summary>
        /// The id of the dimension
        /// </summary>
        /// <value>The id of the dimension</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// A set of tab-delimited codes, one for each category in the dimension
        /// </summary>
        /// <value>A set of tab-delimited codes, one for each category in the dimension</value>
        [DataMember(Name="headerCodes", EmitDefaultValue=false)]
        public string HeaderCodes { get; set; }

        /// <summary>
        /// A set of tab-delimited descriptions, one for each category in the dimension
        /// </summary>
        /// <value>A set of tab-delimited descriptions, one for each category in the dimension</value>
        [DataMember(Name="headerDescriptions", EmitDefaultValue=false)]
        public string HeaderDescriptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DimensionResult {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  HeaderCodes: ").Append(HeaderCodes).Append("\n");
            sb.Append("  HeaderDescriptions: ").Append(HeaderDescriptions).Append("\n");
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
            return this.Equals(input as DimensionResult);
        }

        /// <summary>
        /// Returns true if DimensionResult instances are equal
        /// </summary>
        /// <param name="input">Instance of DimensionResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DimensionResult input)
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
                    this.HeaderCodes == input.HeaderCodes ||
                    (this.HeaderCodes != null &&
                    this.HeaderCodes.Equals(input.HeaderCodes))
                ) && 
                (
                    this.HeaderDescriptions == input.HeaderDescriptions ||
                    (this.HeaderDescriptions != null &&
                    this.HeaderDescriptions.Equals(input.HeaderDescriptions))
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
                if (this.HeaderCodes != null)
                    hashCode = hashCode * 59 + this.HeaderCodes.GetHashCode();
                if (this.HeaderDescriptions != null)
                    hashCode = hashCode * 59 + this.HeaderDescriptions.GetHashCode();
                return hashCode;
            }
        }
    }

}
