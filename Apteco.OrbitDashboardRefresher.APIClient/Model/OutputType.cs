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
    /// A definition of an output format specified by an administrator
    /// </summary>
    [DataContract]
    public partial class OutputType :  IEquatable<OutputType>, IValidatableObject
    {
        /// <summary>
        /// The format of the file to generate
        /// </summary>
        /// <value>The format of the file to generate</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FormatEnum
        {
            
            /// <summary>
            /// Enum CSV for value: CSV
            /// </summary>
            [EnumMember(Value = "CSV")]
            CSV = 1,
            
            /// <summary>
            /// Enum SDF for value: SDF
            /// </summary>
            [EnumMember(Value = "SDF")]
            SDF = 2,
            
            /// <summary>
            /// Enum XLS for value: XLS
            /// </summary>
            [EnumMember(Value = "XLS")]
            XLS = 3,
            
            /// <summary>
            /// Enum XLSX for value: XLSX
            /// </summary>
            [EnumMember(Value = "XLSX")]
            XLSX = 4,
            
            /// <summary>
            /// Enum MDB for value: MDB
            /// </summary>
            [EnumMember(Value = "MDB")]
            MDB = 5,
            
            /// <summary>
            /// Enum DBF for value: DBF
            /// </summary>
            [EnumMember(Value = "DBF")]
            DBF = 6,
            
            /// <summary>
            /// Enum URN for value: URN
            /// </summary>
            [EnumMember(Value = "URN")]
            URN = 7,
            
            /// <summary>
            /// Enum NATIVEDUMP for value: NATIVEDUMP
            /// </summary>
            [EnumMember(Value = "NATIVEDUMP")]
            NATIVEDUMP = 8
        }

        /// <summary>
        /// The format of the file to generate
        /// </summary>
        /// <value>The format of the file to generate</value>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public FormatEnum? Format { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OutputType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OutputType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OutputType" /> class.
        /// </summary>
        /// <param name="name">The name of the output type (required).</param>
        /// <param name="format">The format of the file to generate.</param>
        /// <param name="exportExtraName">The name of the Export Extras post-processing job to run on exported file.</param>
        public OutputType(string name = default(string), FormatEnum? format = default(FormatEnum?), string exportExtraName = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for OutputType and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.Format = format;
            this.ExportExtraName = exportExtraName;
        }
        
        /// <summary>
        /// The name of the output type
        /// </summary>
        /// <value>The name of the output type</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// The name of the Export Extras post-processing job to run on exported file
        /// </summary>
        /// <value>The name of the Export Extras post-processing job to run on exported file</value>
        [DataMember(Name="exportExtraName", EmitDefaultValue=false)]
        public string ExportExtraName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutputType {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  ExportExtraName: ").Append(ExportExtraName).Append("\n");
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
            return this.Equals(input as OutputType);
        }

        /// <summary>
        /// Returns true if OutputType instances are equal
        /// </summary>
        /// <param name="input">Instance of OutputType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutputType input)
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
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
                ) && 
                (
                    this.ExportExtraName == input.ExportExtraName ||
                    (this.ExportExtraName != null &&
                    this.ExportExtraName.Equals(input.ExportExtraName))
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
                if (this.Format != null)
                    hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.ExportExtraName != null)
                    hashCode = hashCode * 59 + this.ExportExtraName.GetHashCode();
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
