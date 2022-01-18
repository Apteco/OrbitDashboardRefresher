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
    /// Clause
    /// </summary>
    [DataContract]
    public partial class Clause :  IEquatable<Clause>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Clause" /> class.
        /// </summary>
        /// <param name="logic">logic.</param>
        /// <param name="criteria">criteria.</param>
        /// <param name="subSelection">subSelection.</param>
        /// <param name="audienceReference">audienceReference.</param>
        /// <param name="fileReference">fileReference.</param>
        public Clause(Logic logic = default(Logic), Criteria criteria = default(Criteria), SubSelection subSelection = default(SubSelection), AudienceReference audienceReference = default(AudienceReference), FileReference fileReference = default(FileReference))
        {
            this.Logic = logic;
            this.Criteria = criteria;
            this.SubSelection = subSelection;
            this.AudienceReference = audienceReference;
            this.FileReference = fileReference;
        }
        
        /// <summary>
        /// Gets or Sets Logic
        /// </summary>
        [DataMember(Name="logic", EmitDefaultValue=false)]
        public Logic Logic { get; set; }

        /// <summary>
        /// Gets or Sets Criteria
        /// </summary>
        [DataMember(Name="criteria", EmitDefaultValue=false)]
        public Criteria Criteria { get; set; }

        /// <summary>
        /// Gets or Sets SubSelection
        /// </summary>
        [DataMember(Name="subSelection", EmitDefaultValue=false)]
        public SubSelection SubSelection { get; set; }

        /// <summary>
        /// Gets or Sets AudienceReference
        /// </summary>
        [DataMember(Name="audienceReference", EmitDefaultValue=false)]
        public AudienceReference AudienceReference { get; set; }

        /// <summary>
        /// Gets or Sets FileReference
        /// </summary>
        [DataMember(Name="fileReference", EmitDefaultValue=false)]
        public FileReference FileReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Clause {\n");
            sb.Append("  Logic: ").Append(Logic).Append("\n");
            sb.Append("  Criteria: ").Append(Criteria).Append("\n");
            sb.Append("  SubSelection: ").Append(SubSelection).Append("\n");
            sb.Append("  AudienceReference: ").Append(AudienceReference).Append("\n");
            sb.Append("  FileReference: ").Append(FileReference).Append("\n");
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
            return this.Equals(input as Clause);
        }

        /// <summary>
        /// Returns true if Clause instances are equal
        /// </summary>
        /// <param name="input">Instance of Clause to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Clause input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Logic == input.Logic ||
                    (this.Logic != null &&
                    this.Logic.Equals(input.Logic))
                ) && 
                (
                    this.Criteria == input.Criteria ||
                    (this.Criteria != null &&
                    this.Criteria.Equals(input.Criteria))
                ) && 
                (
                    this.SubSelection == input.SubSelection ||
                    (this.SubSelection != null &&
                    this.SubSelection.Equals(input.SubSelection))
                ) && 
                (
                    this.AudienceReference == input.AudienceReference ||
                    (this.AudienceReference != null &&
                    this.AudienceReference.Equals(input.AudienceReference))
                ) && 
                (
                    this.FileReference == input.FileReference ||
                    (this.FileReference != null &&
                    this.FileReference.Equals(input.FileReference))
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
                if (this.Logic != null)
                    hashCode = hashCode * 59 + this.Logic.GetHashCode();
                if (this.Criteria != null)
                    hashCode = hashCode * 59 + this.Criteria.GetHashCode();
                if (this.SubSelection != null)
                    hashCode = hashCode * 59 + this.SubSelection.GetHashCode();
                if (this.AudienceReference != null)
                    hashCode = hashCode * 59 + this.AudienceReference.GetHashCode();
                if (this.FileReference != null)
                    hashCode = hashCode * 59 + this.FileReference.GetHashCode();
                return hashCode;
            }
        }
    }

}
