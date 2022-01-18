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
    /// ValueRule
    /// </summary>
    [DataContract]
    public partial class ValueRule :  IEquatable<ValueRule>
    {
        /// <summary>
        /// Defines PredefinedRule
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PredefinedRuleEnum
        {
            
            /// <summary>
            /// Enum DateRange for value: DateRange
            /// </summary>
            [EnumMember(Value = "DateRange")]
            DateRange = 1,
            
            /// <summary>
            /// Enum AdhocDates for value: AdhocDates
            /// </summary>
            [EnumMember(Value = "AdhocDates")]
            AdhocDates = 2,
            
            /// <summary>
            /// Enum AdhocValues for value: AdhocValues
            /// </summary>
            [EnumMember(Value = "AdhocValues")]
            AdhocValues = 3,
            
            /// <summary>
            /// Enum Today for value: Today
            /// </summary>
            [EnumMember(Value = "Today")]
            Today = 4,
            
            /// <summary>
            /// Enum Yesterday for value: Yesterday
            /// </summary>
            [EnumMember(Value = "Yesterday")]
            Yesterday = 5,
            
            /// <summary>
            /// Enum Tomorrow for value: Tomorrow
            /// </summary>
            [EnumMember(Value = "Tomorrow")]
            Tomorrow = 6,
            
            /// <summary>
            /// Enum ThisWeek for value: ThisWeek
            /// </summary>
            [EnumMember(Value = "ThisWeek")]
            ThisWeek = 7,
            
            /// <summary>
            /// Enum ThisMonth for value: ThisMonth
            /// </summary>
            [EnumMember(Value = "ThisMonth")]
            ThisMonth = 8,
            
            /// <summary>
            /// Enum ThisQuarter for value: ThisQuarter
            /// </summary>
            [EnumMember(Value = "ThisQuarter")]
            ThisQuarter = 9,
            
            /// <summary>
            /// Enum ThisYear for value: ThisYear
            /// </summary>
            [EnumMember(Value = "ThisYear")]
            ThisYear = 10,
            
            /// <summary>
            /// Enum LastWeek for value: LastWeek
            /// </summary>
            [EnumMember(Value = "LastWeek")]
            LastWeek = 11,
            
            /// <summary>
            /// Enum Last4Weeks for value: Last4Weeks
            /// </summary>
            [EnumMember(Value = "Last4Weeks")]
            Last4Weeks = 12,
            
            /// <summary>
            /// Enum LastMonth for value: LastMonth
            /// </summary>
            [EnumMember(Value = "LastMonth")]
            LastMonth = 13,
            
            /// <summary>
            /// Enum LastQuarter for value: LastQuarter
            /// </summary>
            [EnumMember(Value = "LastQuarter")]
            LastQuarter = 14,
            
            /// <summary>
            /// Enum LastYear for value: LastYear
            /// </summary>
            [EnumMember(Value = "LastYear")]
            LastYear = 15,
            
            /// <summary>
            /// Enum NextWeek for value: NextWeek
            /// </summary>
            [EnumMember(Value = "NextWeek")]
            NextWeek = 16,
            
            /// <summary>
            /// Enum Next4Weeks for value: Next4Weeks
            /// </summary>
            [EnumMember(Value = "Next4Weeks")]
            Next4Weeks = 17,
            
            /// <summary>
            /// Enum NextMonth for value: NextMonth
            /// </summary>
            [EnumMember(Value = "NextMonth")]
            NextMonth = 18,
            
            /// <summary>
            /// Enum NextQuarter for value: NextQuarter
            /// </summary>
            [EnumMember(Value = "NextQuarter")]
            NextQuarter = 19,
            
            /// <summary>
            /// Enum NextYear for value: NextYear
            /// </summary>
            [EnumMember(Value = "NextYear")]
            NextYear = 20,
            
            /// <summary>
            /// Enum ThisWeekToDate for value: ThisWeekToDate
            /// </summary>
            [EnumMember(Value = "ThisWeekToDate")]
            ThisWeekToDate = 21,
            
            /// <summary>
            /// Enum ThisMonthToDate for value: ThisMonthToDate
            /// </summary>
            [EnumMember(Value = "ThisMonthToDate")]
            ThisMonthToDate = 22,
            
            /// <summary>
            /// Enum ThisQuarterToDate for value: ThisQuarterToDate
            /// </summary>
            [EnumMember(Value = "ThisQuarterToDate")]
            ThisQuarterToDate = 23,
            
            /// <summary>
            /// Enum ThisYearToDate for value: ThisYearToDate
            /// </summary>
            [EnumMember(Value = "ThisYearToDate")]
            ThisYearToDate = 24,
            
            /// <summary>
            /// Enum LastWeekToDate for value: LastWeekToDate
            /// </summary>
            [EnumMember(Value = "LastWeekToDate")]
            LastWeekToDate = 25,
            
            /// <summary>
            /// Enum LastMonthToDate for value: LastMonthToDate
            /// </summary>
            [EnumMember(Value = "LastMonthToDate")]
            LastMonthToDate = 26,
            
            /// <summary>
            /// Enum LastQuarterToDate for value: LastQuarterToDate
            /// </summary>
            [EnumMember(Value = "LastQuarterToDate")]
            LastQuarterToDate = 27,
            
            /// <summary>
            /// Enum LastYearToDate for value: LastYearToDate
            /// </summary>
            [EnumMember(Value = "LastYearToDate")]
            LastYearToDate = 28,
            
            /// <summary>
            /// Enum TheLastWeek for value: TheLastWeek
            /// </summary>
            [EnumMember(Value = "TheLastWeek")]
            TheLastWeek = 29,
            
            /// <summary>
            /// Enum TheLast4Weeks for value: TheLast4Weeks
            /// </summary>
            [EnumMember(Value = "TheLast4Weeks")]
            TheLast4Weeks = 30,
            
            /// <summary>
            /// Enum TheLastMonth for value: TheLastMonth
            /// </summary>
            [EnumMember(Value = "TheLastMonth")]
            TheLastMonth = 31,
            
            /// <summary>
            /// Enum TheLastQuarter for value: TheLastQuarter
            /// </summary>
            [EnumMember(Value = "TheLastQuarter")]
            TheLastQuarter = 32,
            
            /// <summary>
            /// Enum TheLastYear for value: TheLastYear
            /// </summary>
            [EnumMember(Value = "TheLastYear")]
            TheLastYear = 33,
            
            /// <summary>
            /// Enum TheNextWeek for value: TheNextWeek
            /// </summary>
            [EnumMember(Value = "TheNextWeek")]
            TheNextWeek = 34,
            
            /// <summary>
            /// Enum TheNext4Weeks for value: TheNext4Weeks
            /// </summary>
            [EnumMember(Value = "TheNext4Weeks")]
            TheNext4Weeks = 35,
            
            /// <summary>
            /// Enum TheNextMonth for value: TheNextMonth
            /// </summary>
            [EnumMember(Value = "TheNextMonth")]
            TheNextMonth = 36,
            
            /// <summary>
            /// Enum TheNextQuarter for value: TheNextQuarter
            /// </summary>
            [EnumMember(Value = "TheNextQuarter")]
            TheNextQuarter = 37,
            
            /// <summary>
            /// Enum TheNextYear for value: TheNextYear
            /// </summary>
            [EnumMember(Value = "TheNextYear")]
            TheNextYear = 38,
            
            /// <summary>
            /// Enum ThisBusinessMonth for value: ThisBusinessMonth
            /// </summary>
            [EnumMember(Value = "ThisBusinessMonth")]
            ThisBusinessMonth = 39,
            
            /// <summary>
            /// Enum ThisBusinessQuarter for value: ThisBusinessQuarter
            /// </summary>
            [EnumMember(Value = "ThisBusinessQuarter")]
            ThisBusinessQuarter = 40,
            
            /// <summary>
            /// Enum ThisBusinessYear for value: ThisBusinessYear
            /// </summary>
            [EnumMember(Value = "ThisBusinessYear")]
            ThisBusinessYear = 41,
            
            /// <summary>
            /// Enum LastBusinessMonth for value: LastBusinessMonth
            /// </summary>
            [EnumMember(Value = "LastBusinessMonth")]
            LastBusinessMonth = 42,
            
            /// <summary>
            /// Enum LastBusinessQuarter for value: LastBusinessQuarter
            /// </summary>
            [EnumMember(Value = "LastBusinessQuarter")]
            LastBusinessQuarter = 43,
            
            /// <summary>
            /// Enum LastBusinessYear for value: LastBusinessYear
            /// </summary>
            [EnumMember(Value = "LastBusinessYear")]
            LastBusinessYear = 44,
            
            /// <summary>
            /// Enum NextBusinessMonth for value: NextBusinessMonth
            /// </summary>
            [EnumMember(Value = "NextBusinessMonth")]
            NextBusinessMonth = 45,
            
            /// <summary>
            /// Enum NextBusinessQuarter for value: NextBusinessQuarter
            /// </summary>
            [EnumMember(Value = "NextBusinessQuarter")]
            NextBusinessQuarter = 46,
            
            /// <summary>
            /// Enum NextBusinessYear for value: NextBusinessYear
            /// </summary>
            [EnumMember(Value = "NextBusinessYear")]
            NextBusinessYear = 47,
            
            /// <summary>
            /// Enum ThisBusinessMonthToDate for value: ThisBusinessMonthToDate
            /// </summary>
            [EnumMember(Value = "ThisBusinessMonthToDate")]
            ThisBusinessMonthToDate = 48,
            
            /// <summary>
            /// Enum ThisBusinessQuarterToDate for value: ThisBusinessQuarterToDate
            /// </summary>
            [EnumMember(Value = "ThisBusinessQuarterToDate")]
            ThisBusinessQuarterToDate = 49,
            
            /// <summary>
            /// Enum ThisBusinessYearToDate for value: ThisBusinessYearToDate
            /// </summary>
            [EnumMember(Value = "ThisBusinessYearToDate")]
            ThisBusinessYearToDate = 50,
            
            /// <summary>
            /// Enum LastBusinessMonthToDate for value: LastBusinessMonthToDate
            /// </summary>
            [EnumMember(Value = "LastBusinessMonthToDate")]
            LastBusinessMonthToDate = 51,
            
            /// <summary>
            /// Enum LastBusinessQuarterToDate for value: LastBusinessQuarterToDate
            /// </summary>
            [EnumMember(Value = "LastBusinessQuarterToDate")]
            LastBusinessQuarterToDate = 52,
            
            /// <summary>
            /// Enum LastBusinessYearToDate for value: LastBusinessYearToDate
            /// </summary>
            [EnumMember(Value = "LastBusinessYearToDate")]
            LastBusinessYearToDate = 53,
            
            /// <summary>
            /// Enum CustomRule for value: CustomRule
            /// </summary>
            [EnumMember(Value = "CustomRule")]
            CustomRule = 54,
            
            /// <summary>
            /// Enum CustomAgeRule for value: CustomAgeRule
            /// </summary>
            [EnumMember(Value = "CustomAgeRule")]
            CustomAgeRule = 55,
            
            /// <summary>
            /// Enum CustomTimeRule for value: CustomTimeRule
            /// </summary>
            [EnumMember(Value = "CustomTimeRule")]
            CustomTimeRule = 56
        }

        /// <summary>
        /// Gets or Sets PredefinedRule
        /// </summary>
        [DataMember(Name="predefinedRule", EmitDefaultValue=false)]
        public PredefinedRuleEnum? PredefinedRule { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueRule" /> class.
        /// </summary>
        /// <param name="ageRule">ageRule.</param>
        /// <param name="dateRule">dateRule.</param>
        /// <param name="listRule">listRule.</param>
        /// <param name="timeRule">timeRule.</param>
        /// <param name="predefinedRule">predefinedRule.</param>
        /// <param name="name">name.</param>
        public ValueRule(AgeRule ageRule = default(AgeRule), DateRule dateRule = default(DateRule), ListRule listRule = default(ListRule), TimeRule timeRule = default(TimeRule), PredefinedRuleEnum? predefinedRule = default(PredefinedRuleEnum?), string name = default(string))
        {
            this.AgeRule = ageRule;
            this.DateRule = dateRule;
            this.ListRule = listRule;
            this.TimeRule = timeRule;
            this.PredefinedRule = predefinedRule;
            this.Name = name;
        }
        
        /// <summary>
        /// Gets or Sets AgeRule
        /// </summary>
        [DataMember(Name="ageRule", EmitDefaultValue=false)]
        public AgeRule AgeRule { get; set; }

        /// <summary>
        /// Gets or Sets DateRule
        /// </summary>
        [DataMember(Name="dateRule", EmitDefaultValue=false)]
        public DateRule DateRule { get; set; }

        /// <summary>
        /// Gets or Sets ListRule
        /// </summary>
        [DataMember(Name="listRule", EmitDefaultValue=false)]
        public ListRule ListRule { get; set; }

        /// <summary>
        /// Gets or Sets TimeRule
        /// </summary>
        [DataMember(Name="timeRule", EmitDefaultValue=false)]
        public TimeRule TimeRule { get; set; }


        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValueRule {\n");
            sb.Append("  AgeRule: ").Append(AgeRule).Append("\n");
            sb.Append("  DateRule: ").Append(DateRule).Append("\n");
            sb.Append("  ListRule: ").Append(ListRule).Append("\n");
            sb.Append("  TimeRule: ").Append(TimeRule).Append("\n");
            sb.Append("  PredefinedRule: ").Append(PredefinedRule).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as ValueRule);
        }

        /// <summary>
        /// Returns true if ValueRule instances are equal
        /// </summary>
        /// <param name="input">Instance of ValueRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValueRule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AgeRule == input.AgeRule ||
                    (this.AgeRule != null &&
                    this.AgeRule.Equals(input.AgeRule))
                ) && 
                (
                    this.DateRule == input.DateRule ||
                    (this.DateRule != null &&
                    this.DateRule.Equals(input.DateRule))
                ) && 
                (
                    this.ListRule == input.ListRule ||
                    (this.ListRule != null &&
                    this.ListRule.Equals(input.ListRule))
                ) && 
                (
                    this.TimeRule == input.TimeRule ||
                    (this.TimeRule != null &&
                    this.TimeRule.Equals(input.TimeRule))
                ) && 
                (
                    this.PredefinedRule == input.PredefinedRule ||
                    (this.PredefinedRule != null &&
                    this.PredefinedRule.Equals(input.PredefinedRule))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.AgeRule != null)
                    hashCode = hashCode * 59 + this.AgeRule.GetHashCode();
                if (this.DateRule != null)
                    hashCode = hashCode * 59 + this.DateRule.GetHashCode();
                if (this.ListRule != null)
                    hashCode = hashCode * 59 + this.ListRule.GetHashCode();
                if (this.TimeRule != null)
                    hashCode = hashCode * 59 + this.TimeRule.GetHashCode();
                if (this.PredefinedRule != null)
                    hashCode = hashCode * 59 + this.PredefinedRule.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }
    }

}
