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
    /// Metadata information for a PeopleStage Diagram
    /// </summary>
    [DataContract]
    public partial class DiagramMetadata :  IEquatable<DiagramMetadata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagramMetadata" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DiagramMetadata() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagramMetadata" /> class.
        /// </summary>
        /// <param name="defaultCurrencyLocale">The locale string for the default currency for cost and revenue data in the PeopleStage diagram (required).</param>
        /// <param name="tableDefinitions">A list of FastStats tables used by PeopleStage (required).</param>
        /// <param name="contactsTableName">The table in the FastStats system that contains the contacts for campaigning (required).</param>
        public DiagramMetadata(string defaultCurrencyLocale = default(string), List<TableDefinition> tableDefinitions = default(List<TableDefinition>), string contactsTableName = default(string))
        {
            // to ensure "defaultCurrencyLocale" is required (not null)
            if (defaultCurrencyLocale == null)
            {
                throw new InvalidDataException("defaultCurrencyLocale is a required property for DiagramMetadata and cannot be null");
            }
            else
            {
                this.DefaultCurrencyLocale = defaultCurrencyLocale;
            }
            // to ensure "tableDefinitions" is required (not null)
            if (tableDefinitions == null)
            {
                throw new InvalidDataException("tableDefinitions is a required property for DiagramMetadata and cannot be null");
            }
            else
            {
                this.TableDefinitions = tableDefinitions;
            }
            // to ensure "contactsTableName" is required (not null)
            if (contactsTableName == null)
            {
                throw new InvalidDataException("contactsTableName is a required property for DiagramMetadata and cannot be null");
            }
            else
            {
                this.ContactsTableName = contactsTableName;
            }
        }
        
        /// <summary>
        /// The locale string for the default currency for cost and revenue data in the PeopleStage diagram
        /// </summary>
        /// <value>The locale string for the default currency for cost and revenue data in the PeopleStage diagram</value>
        [DataMember(Name="defaultCurrencyLocale", EmitDefaultValue=false)]
        public string DefaultCurrencyLocale { get; set; }

        /// <summary>
        /// A list of FastStats tables used by PeopleStage
        /// </summary>
        /// <value>A list of FastStats tables used by PeopleStage</value>
        [DataMember(Name="tableDefinitions", EmitDefaultValue=false)]
        public List<TableDefinition> TableDefinitions { get; set; }

        /// <summary>
        /// The table in the FastStats system that contains the contacts for campaigning
        /// </summary>
        /// <value>The table in the FastStats system that contains the contacts for campaigning</value>
        [DataMember(Name="contactsTableName", EmitDefaultValue=false)]
        public string ContactsTableName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiagramMetadata {\n");
            sb.Append("  DefaultCurrencyLocale: ").Append(DefaultCurrencyLocale).Append("\n");
            sb.Append("  TableDefinitions: ").Append(TableDefinitions).Append("\n");
            sb.Append("  ContactsTableName: ").Append(ContactsTableName).Append("\n");
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
            return this.Equals(input as DiagramMetadata);
        }

        /// <summary>
        /// Returns true if DiagramMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of DiagramMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiagramMetadata input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DefaultCurrencyLocale == input.DefaultCurrencyLocale ||
                    (this.DefaultCurrencyLocale != null &&
                    this.DefaultCurrencyLocale.Equals(input.DefaultCurrencyLocale))
                ) && 
                (
                    this.TableDefinitions == input.TableDefinitions ||
                    this.TableDefinitions != null &&
                    this.TableDefinitions.SequenceEqual(input.TableDefinitions)
                ) && 
                (
                    this.ContactsTableName == input.ContactsTableName ||
                    (this.ContactsTableName != null &&
                    this.ContactsTableName.Equals(input.ContactsTableName))
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
                if (this.DefaultCurrencyLocale != null)
                    hashCode = hashCode * 59 + this.DefaultCurrencyLocale.GetHashCode();
                if (this.TableDefinitions != null)
                    hashCode = hashCode * 59 + this.TableDefinitions.GetHashCode();
                if (this.ContactsTableName != null)
                    hashCode = hashCode * 59 + this.ContactsTableName.GetHashCode();
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
