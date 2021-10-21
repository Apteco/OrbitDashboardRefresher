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
    /// ThemeUsage
    /// </summary>
    [DataContract]
    public partial class ThemeUsage :  IEquatable<ThemeUsage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThemeUsage" /> class.
        /// </summary>
        /// <param name="numberOfDashboardsSetToDefaultTheme">The number of dashboards set to use the default theme in the dataview.</param>
        /// <param name="themeUsageSummaries">A list of summaries of the usage for each theme in the dataview.</param>
        public ThemeUsage(int? numberOfDashboardsSetToDefaultTheme = default(int?), List<ThemeUsageSummary> themeUsageSummaries = default(List<ThemeUsageSummary>))
        {
            this.NumberOfDashboardsSetToDefaultTheme = numberOfDashboardsSetToDefaultTheme;
            this.ThemeUsageSummaries = themeUsageSummaries;
        }
        
        /// <summary>
        /// The number of dashboards set to use the default theme in the dataview
        /// </summary>
        /// <value>The number of dashboards set to use the default theme in the dataview</value>
        [DataMember(Name="numberOfDashboardsSetToDefaultTheme", EmitDefaultValue=false)]
        public int? NumberOfDashboardsSetToDefaultTheme { get; set; }

        /// <summary>
        /// A list of summaries of the usage for each theme in the dataview
        /// </summary>
        /// <value>A list of summaries of the usage for each theme in the dataview</value>
        [DataMember(Name="themeUsageSummaries", EmitDefaultValue=false)]
        public List<ThemeUsageSummary> ThemeUsageSummaries { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThemeUsage {\n");
            sb.Append("  NumberOfDashboardsSetToDefaultTheme: ").Append(NumberOfDashboardsSetToDefaultTheme).Append("\n");
            sb.Append("  ThemeUsageSummaries: ").Append(ThemeUsageSummaries).Append("\n");
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
            return this.Equals(input as ThemeUsage);
        }

        /// <summary>
        /// Returns true if ThemeUsage instances are equal
        /// </summary>
        /// <param name="input">Instance of ThemeUsage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThemeUsage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NumberOfDashboardsSetToDefaultTheme == input.NumberOfDashboardsSetToDefaultTheme ||
                    (this.NumberOfDashboardsSetToDefaultTheme != null &&
                    this.NumberOfDashboardsSetToDefaultTheme.Equals(input.NumberOfDashboardsSetToDefaultTheme))
                ) && 
                (
                    this.ThemeUsageSummaries == input.ThemeUsageSummaries ||
                    this.ThemeUsageSummaries != null &&
                    this.ThemeUsageSummaries.SequenceEqual(input.ThemeUsageSummaries)
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
                if (this.NumberOfDashboardsSetToDefaultTheme != null)
                    hashCode = hashCode * 59 + this.NumberOfDashboardsSetToDefaultTheme.GetHashCode();
                if (this.ThemeUsageSummaries != null)
                    hashCode = hashCode * 59 + this.ThemeUsageSummaries.GetHashCode();
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
