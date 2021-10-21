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
    /// ListRule
    /// </summary>
    [DataContract]
    public partial class ListRule :  IEquatable<ListRule>, IValidatableObject
    {
        /// <summary>
        /// Defines BandingType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BandingTypeEnum
        {
            
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,
            
            /// <summary>
            /// Enum Years for value: Years
            /// </summary>
            [EnumMember(Value = "Years")]
            Years = 2,
            
            /// <summary>
            /// Enum Quarters for value: Quarters
            /// </summary>
            [EnumMember(Value = "Quarters")]
            Quarters = 3,
            
            /// <summary>
            /// Enum Months for value: Months
            /// </summary>
            [EnumMember(Value = "Months")]
            Months = 4,
            
            /// <summary>
            /// Enum Weeks for value: Weeks
            /// </summary>
            [EnumMember(Value = "Weeks")]
            Weeks = 5,
            
            /// <summary>
            /// Enum DayOfWeek for value: DayOfWeek
            /// </summary>
            [EnumMember(Value = "DayOfWeek")]
            DayOfWeek = 6,
            
            /// <summary>
            /// Enum WeekOfYear for value: WeekOfYear
            /// </summary>
            [EnumMember(Value = "WeekOfYear")]
            WeekOfYear = 7,
            
            /// <summary>
            /// Enum MonthOfYear for value: MonthOfYear
            /// </summary>
            [EnumMember(Value = "MonthOfYear")]
            MonthOfYear = 8,
            
            /// <summary>
            /// Enum QuarterOfYear for value: QuarterOfYear
            /// </summary>
            [EnumMember(Value = "QuarterOfYear")]
            QuarterOfYear = 9,
            
            /// <summary>
            /// Enum DayMonthOfYear for value: DayMonthOfYear
            /// </summary>
            [EnumMember(Value = "DayMonthOfYear")]
            DayMonthOfYear = 10,
            
            /// <summary>
            /// Enum HourOfDay for value: HourOfDay
            /// </summary>
            [EnumMember(Value = "HourOfDay")]
            HourOfDay = 11,
            
            /// <summary>
            /// Enum DayHour for value: DayHour
            /// </summary>
            [EnumMember(Value = "DayHour")]
            DayHour = 12,
            
            /// <summary>
            /// Enum DayHourMinute for value: DayHourMinute
            /// </summary>
            [EnumMember(Value = "DayHourMinute")]
            DayHourMinute = 13,
            
            /// <summary>
            /// Enum Day for value: Day
            /// </summary>
            [EnumMember(Value = "Day")]
            Day = 14,
            
            /// <summary>
            /// Enum AgeInYears for value: AgeInYears
            /// </summary>
            [EnumMember(Value = "AgeInYears")]
            AgeInYears = 15,
            
            /// <summary>
            /// Enum AgeInMonths for value: AgeInMonths
            /// </summary>
            [EnumMember(Value = "AgeInMonths")]
            AgeInMonths = 16,
            
            /// <summary>
            /// Enum AgeInQuarters for value: AgeInQuarters
            /// </summary>
            [EnumMember(Value = "AgeInQuarters")]
            AgeInQuarters = 17,
            
            /// <summary>
            /// Enum AgeInWeeks for value: AgeInWeeks
            /// </summary>
            [EnumMember(Value = "AgeInWeeks")]
            AgeInWeeks = 18,
            
            /// <summary>
            /// Enum AgeInDays for value: AgeInDays
            /// </summary>
            [EnumMember(Value = "AgeInDays")]
            AgeInDays = 19,
            
            /// <summary>
            /// Enum YearsBusiness for value: YearsBusiness
            /// </summary>
            [EnumMember(Value = "YearsBusiness")]
            YearsBusiness = 20,
            
            /// <summary>
            /// Enum QuartersBusiness for value: QuartersBusiness
            /// </summary>
            [EnumMember(Value = "QuartersBusiness")]
            QuartersBusiness = 21,
            
            /// <summary>
            /// Enum QuarterOfYearBusiness for value: QuarterOfYearBusiness
            /// </summary>
            [EnumMember(Value = "QuarterOfYearBusiness")]
            QuarterOfYearBusiness = 22,
            
            /// <summary>
            /// Enum MonthsBusiness for value: MonthsBusiness
            /// </summary>
            [EnumMember(Value = "MonthsBusiness")]
            MonthsBusiness = 23,
            
            /// <summary>
            /// Enum MonthOfYearBusiness for value: MonthOfYearBusiness
            /// </summary>
            [EnumMember(Value = "MonthOfYearBusiness")]
            MonthOfYearBusiness = 24,
            
            /// <summary>
            /// Enum WeeksBusiness for value: WeeksBusiness
            /// </summary>
            [EnumMember(Value = "WeeksBusiness")]
            WeeksBusiness = 25,
            
            /// <summary>
            /// Enum DaysBusiness for value: DaysBusiness
            /// </summary>
            [EnumMember(Value = "DaysBusiness")]
            DaysBusiness = 26,
            
            /// <summary>
            /// Enum WeekOfYearBusiness for value: WeekOfYearBusiness
            /// </summary>
            [EnumMember(Value = "WeekOfYearBusiness")]
            WeekOfYearBusiness = 27,
            
            /// <summary>
            /// Enum Custom for value: Custom
            /// </summary>
            [EnumMember(Value = "Custom")]
            Custom = 28
        }

        /// <summary>
        /// Gets or Sets BandingType
        /// </summary>
        [DataMember(Name="bandingType", EmitDefaultValue=false)]
        public BandingTypeEnum? BandingType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListRule" /> class.
        /// </summary>
        /// <param name="bandingType">bandingType.</param>
        /// <param name="list">list.</param>
        /// <param name="variableName">variableName.</param>
        public ListRule(BandingTypeEnum? bandingType = default(BandingTypeEnum?), string list = default(string), string variableName = default(string))
        {
            this.BandingType = bandingType;
            this.List = list;
            this.VariableName = variableName;
        }
        

        /// <summary>
        /// Gets or Sets List
        /// </summary>
        [DataMember(Name="list", EmitDefaultValue=false)]
        public string List { get; set; }

        /// <summary>
        /// Gets or Sets VariableName
        /// </summary>
        [DataMember(Name="variableName", EmitDefaultValue=false)]
        public string VariableName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRule {\n");
            sb.Append("  BandingType: ").Append(BandingType).Append("\n");
            sb.Append("  List: ").Append(List).Append("\n");
            sb.Append("  VariableName: ").Append(VariableName).Append("\n");
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
            return this.Equals(input as ListRule);
        }

        /// <summary>
        /// Returns true if ListRule instances are equal
        /// </summary>
        /// <param name="input">Instance of ListRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListRule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BandingType == input.BandingType ||
                    (this.BandingType != null &&
                    this.BandingType.Equals(input.BandingType))
                ) && 
                (
                    this.List == input.List ||
                    (this.List != null &&
                    this.List.Equals(input.List))
                ) && 
                (
                    this.VariableName == input.VariableName ||
                    (this.VariableName != null &&
                    this.VariableName.Equals(input.VariableName))
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
                if (this.BandingType != null)
                    hashCode = hashCode * 59 + this.BandingType.GetHashCode();
                if (this.List != null)
                    hashCode = hashCode * 59 + this.List.GetHashCode();
                if (this.VariableName != null)
                    hashCode = hashCode * 59 + this.VariableName.GetHashCode();
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
