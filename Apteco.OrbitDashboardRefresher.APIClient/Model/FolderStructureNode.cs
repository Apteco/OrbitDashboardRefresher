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
    /// An item in the Folder structure tree
    /// </summary>
    [DataContract]
    public partial class FolderStructureNode :  IEquatable<FolderStructureNode>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FolderStructureNode" /> class.
        /// </summary>
        /// <param name="folder">A folder in the folder structure tree.</param>
        /// <param name="variable">A variable in the folder structure tree.</param>
        public FolderStructureNode(Folder folder = default(Folder), Variable variable = default(Variable))
        {
            this.Folder = folder;
            this.Variable = variable;
        }
        
        /// <summary>
        /// A folder in the folder structure tree
        /// </summary>
        /// <value>A folder in the folder structure tree</value>
        [DataMember(Name="folder", EmitDefaultValue=false)]
        public Folder Folder { get; set; }

        /// <summary>
        /// A variable in the folder structure tree
        /// </summary>
        /// <value>A variable in the folder structure tree</value>
        [DataMember(Name="variable", EmitDefaultValue=false)]
        public Variable Variable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FolderStructureNode {\n");
            sb.Append("  Folder: ").Append(Folder).Append("\n");
            sb.Append("  Variable: ").Append(Variable).Append("\n");
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
            return this.Equals(input as FolderStructureNode);
        }

        /// <summary>
        /// Returns true if FolderStructureNode instances are equal
        /// </summary>
        /// <param name="input">Instance of FolderStructureNode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FolderStructureNode input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Folder == input.Folder ||
                    (this.Folder != null &&
                    this.Folder.Equals(input.Folder))
                ) && 
                (
                    this.Variable == input.Variable ||
                    (this.Variable != null &&
                    this.Variable.Equals(input.Variable))
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
                if (this.Folder != null)
                    hashCode = hashCode * 59 + this.Folder.GetHashCode();
                if (this.Variable != null)
                    hashCode = hashCode * 59 + this.Variable.GetHashCode();
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
