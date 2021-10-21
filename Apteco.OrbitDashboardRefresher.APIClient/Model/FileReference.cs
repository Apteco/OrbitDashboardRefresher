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
    /// FileReference
    /// </summary>
    [DataContract]
    public partial class FileReference :  IEquatable<FileReference>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Urn for value: Urn
            /// </summary>
            [EnumMember(Value = "Urn")]
            Urn = 1,
            
            /// <summary>
            /// Enum Selection for value: Selection
            /// </summary>
            [EnumMember(Value = "Selection")]
            Selection = 2
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileReference" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="keyVariable">keyVariable.</param>
        /// <param name="path">path.</param>
        /// <param name="records">records.</param>
        /// <param name="include">include.</param>
        /// <param name="tableName">tableName.</param>
        public FileReference(TypeEnum? type = default(TypeEnum?), string keyVariable = default(string), string path = default(string), int? records = default(int?), bool? include = default(bool?), string tableName = default(string))
        {
            this.Type = type;
            this.KeyVariable = keyVariable;
            this.Path = path;
            this.Records = records;
            this.Include = include;
            this.TableName = tableName;
        }
        

        /// <summary>
        /// Gets or Sets KeyVariable
        /// </summary>
        [DataMember(Name="keyVariable", EmitDefaultValue=false)]
        public string KeyVariable { get; set; }

        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// Gets or Sets Records
        /// </summary>
        [DataMember(Name="records", EmitDefaultValue=false)]
        public int? Records { get; set; }

        /// <summary>
        /// Gets or Sets Include
        /// </summary>
        [DataMember(Name="include", EmitDefaultValue=false)]
        public bool? Include { get; set; }

        /// <summary>
        /// Gets or Sets TableName
        /// </summary>
        [DataMember(Name="tableName", EmitDefaultValue=false)]
        public string TableName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileReference {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  KeyVariable: ").Append(KeyVariable).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Records: ").Append(Records).Append("\n");
            sb.Append("  Include: ").Append(Include).Append("\n");
            sb.Append("  TableName: ").Append(TableName).Append("\n");
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
            return this.Equals(input as FileReference);
        }

        /// <summary>
        /// Returns true if FileReference instances are equal
        /// </summary>
        /// <param name="input">Instance of FileReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.KeyVariable == input.KeyVariable ||
                    (this.KeyVariable != null &&
                    this.KeyVariable.Equals(input.KeyVariable))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Records == input.Records ||
                    (this.Records != null &&
                    this.Records.Equals(input.Records))
                ) && 
                (
                    this.Include == input.Include ||
                    (this.Include != null &&
                    this.Include.Equals(input.Include))
                ) && 
                (
                    this.TableName == input.TableName ||
                    (this.TableName != null &&
                    this.TableName.Equals(input.TableName))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.KeyVariable != null)
                    hashCode = hashCode * 59 + this.KeyVariable.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Records != null)
                    hashCode = hashCode * 59 + this.Records.GetHashCode();
                if (this.Include != null)
                    hashCode = hashCode * 59 + this.Include.GetHashCode();
                if (this.TableName != null)
                    hashCode = hashCode * 59 + this.TableName.GetHashCode();
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