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
    /// The details of a dashboard item
    /// </summary>
    [DataContract]
    public partial class DashboardContentItemDetail :  IEquatable<DashboardContentItemDetail>, IValidatableObject
    {
        /// <summary>
        /// The chart type that will be shown in the dashboard item
        /// </summary>
        /// <value>The chart type that will be shown in the dashboard item</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChartTypeEnum
        {
            
            /// <summary>
            /// Enum Bar for value: Bar
            /// </summary>
            [EnumMember(Value = "Bar")]
            Bar = 1,
            
            /// <summary>
            /// Enum Column for value: Column
            /// </summary>
            [EnumMember(Value = "Column")]
            Column = 2,
            
            /// <summary>
            /// Enum Pie for value: Pie
            /// </summary>
            [EnumMember(Value = "Pie")]
            Pie = 3,
            
            /// <summary>
            /// Enum Donut for value: Donut
            /// </summary>
            [EnumMember(Value = "Donut")]
            Donut = 4,
            
            /// <summary>
            /// Enum Line for value: Line
            /// </summary>
            [EnumMember(Value = "Line")]
            Line = 5,
            
            /// <summary>
            /// Enum UKPostArea for value: UKPostArea
            /// </summary>
            [EnumMember(Value = "UKPostArea")]
            UKPostArea = 6,
            
            /// <summary>
            /// Enum NLProvinces for value: NLProvinces
            /// </summary>
            [EnumMember(Value = "NLProvinces")]
            NLProvinces = 7,
            
            /// <summary>
            /// Enum NLMunicipalities for value: NLMunicipalities
            /// </summary>
            [EnumMember(Value = "NLMunicipalities")]
            NLMunicipalities = 8,
            
            /// <summary>
            /// Enum DE2DigitPostCode for value: DE2DigitPostCode
            /// </summary>
            [EnumMember(Value = "DE2DigitPostCode")]
            DE2DigitPostCode = 9,
            
            /// <summary>
            /// Enum CH2DigitPostCode for value: CH2DigitPostCode
            /// </summary>
            [EnumMember(Value = "CH2DigitPostCode")]
            CH2DigitPostCode = 10,
            
            /// <summary>
            /// Enum AU2DigitPostCode for value: AU2DigitPostCode
            /// </summary>
            [EnumMember(Value = "AU2DigitPostCode")]
            AU2DigitPostCode = 11,
            
            /// <summary>
            /// Enum USStates for value: USStates
            /// </summary>
            [EnumMember(Value = "USStates")]
            USStates = 12,
            
            /// <summary>
            /// Enum NumberCard for value: NumberCard
            /// </summary>
            [EnumMember(Value = "NumberCard")]
            NumberCard = 13,
            
            /// <summary>
            /// Enum Text for value: Text
            /// </summary>
            [EnumMember(Value = "Text")]
            Text = 14,
            
            /// <summary>
            /// Enum BandedPareto for value: BandedPareto
            /// </summary>
            [EnumMember(Value = "BandedPareto")]
            BandedPareto = 15,
            
            /// <summary>
            /// Enum CategoricalPareto for value: CategoricalPareto
            /// </summary>
            [EnumMember(Value = "CategoricalPareto")]
            CategoricalPareto = 16,
            
            /// <summary>
            /// Enum Area for value: Area
            /// </summary>
            [EnumMember(Value = "Area")]
            Area = 17,
            
            /// <summary>
            /// Enum RadarLine for value: RadarLine
            /// </summary>
            [EnumMember(Value = "RadarLine")]
            RadarLine = 18,
            
            /// <summary>
            /// Enum RadarColumn for value: RadarColumn
            /// </summary>
            [EnumMember(Value = "RadarColumn")]
            RadarColumn = 19,
            
            /// <summary>
            /// Enum RadarArea for value: RadarArea
            /// </summary>
            [EnumMember(Value = "RadarArea")]
            RadarArea = 20,
            
            /// <summary>
            /// Enum Funnel for value: Funnel
            /// </summary>
            [EnumMember(Value = "Funnel")]
            Funnel = 21,
            
            /// <summary>
            /// Enum Combo for value: Combo
            /// </summary>
            [EnumMember(Value = "Combo")]
            Combo = 22,
            
            /// <summary>
            /// Enum Column2DClustered for value: Column2DClustered
            /// </summary>
            [EnumMember(Value = "Column2DClustered")]
            Column2DClustered = 23,
            
            /// <summary>
            /// Enum Column2DStacked for value: Column2DStacked
            /// </summary>
            [EnumMember(Value = "Column2DStacked")]
            Column2DStacked = 24,
            
            /// <summary>
            /// Enum Column2DStacked100 for value: Column2DStacked100
            /// </summary>
            [EnumMember(Value = "Column2DStacked100")]
            Column2DStacked100 = 25,
            
            /// <summary>
            /// Enum Bar2DClustered for value: Bar2DClustered
            /// </summary>
            [EnumMember(Value = "Bar2DClustered")]
            Bar2DClustered = 26,
            
            /// <summary>
            /// Enum Bar2DStacked for value: Bar2DStacked
            /// </summary>
            [EnumMember(Value = "Bar2DStacked")]
            Bar2DStacked = 27,
            
            /// <summary>
            /// Enum Bar2DStacked100 for value: Bar2DStacked100
            /// </summary>
            [EnumMember(Value = "Bar2DStacked100")]
            Bar2DStacked100 = 28,
            
            /// <summary>
            /// Enum Line2D for value: Line2D
            /// </summary>
            [EnumMember(Value = "Line2D")]
            Line2D = 29,
            
            /// <summary>
            /// Enum Area2DClustered for value: Area2DClustered
            /// </summary>
            [EnumMember(Value = "Area2DClustered")]
            Area2DClustered = 30,
            
            /// <summary>
            /// Enum Area2DStacked for value: Area2DStacked
            /// </summary>
            [EnumMember(Value = "Area2DStacked")]
            Area2DStacked = 31,
            
            /// <summary>
            /// Enum Area2DStacked100 for value: Area2DStacked100
            /// </summary>
            [EnumMember(Value = "Area2DStacked100")]
            Area2DStacked100 = 32,
            
            /// <summary>
            /// Enum Combo2DClustered for value: Combo2DClustered
            /// </summary>
            [EnumMember(Value = "Combo2DClustered")]
            Combo2DClustered = 33,
            
            /// <summary>
            /// Enum Combo2DStacked for value: Combo2DStacked
            /// </summary>
            [EnumMember(Value = "Combo2DStacked")]
            Combo2DStacked = 34,
            
            /// <summary>
            /// Enum Combo2DStacked100 for value: Combo2DStacked100
            /// </summary>
            [EnumMember(Value = "Combo2DStacked100")]
            Combo2DStacked100 = 35,
            
            /// <summary>
            /// Enum Venn for value: Venn
            /// </summary>
            [EnumMember(Value = "Venn")]
            Venn = 36
        }

        /// <summary>
        /// The chart type that will be shown in the dashboard item
        /// </summary>
        /// <value>The chart type that will be shown in the dashboard item</value>
        [DataMember(Name="chartType", EmitDefaultValue=false)]
        public ChartTypeEnum ChartType { get; set; }
        /// <summary>
        /// Whether the chart should be sorted in it&#39;s natural order, by ascending or descending values
        /// </summary>
        /// <value>Whether the chart should be sorted in it&#39;s natural order, by ascending or descending values</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SortOrderEnum
        {
            
            /// <summary>
            /// Enum Natural for value: Natural
            /// </summary>
            [EnumMember(Value = "Natural")]
            Natural = 1,
            
            /// <summary>
            /// Enum AscendingByValue for value: AscendingByValue
            /// </summary>
            [EnumMember(Value = "AscendingByValue")]
            AscendingByValue = 2,
            
            /// <summary>
            /// Enum DescendingByValue for value: DescendingByValue
            /// </summary>
            [EnumMember(Value = "DescendingByValue")]
            DescendingByValue = 3
        }

        /// <summary>
        /// Whether the chart should be sorted in it&#39;s natural order, by ascending or descending values
        /// </summary>
        /// <value>Whether the chart should be sorted in it&#39;s natural order, by ascending or descending values</value>
        [DataMember(Name="sortOrder", EmitDefaultValue=false)]
        public SortOrderEnum SortOrder { get; set; }
        /// <summary>
        /// The position of the legend on the dashboard item
        /// </summary>
        /// <value>The position of the legend on the dashboard item</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LegendPositionEnum
        {
            
            /// <summary>
            /// Enum Right for value: Right
            /// </summary>
            [EnumMember(Value = "Right")]
            Right = 1,
            
            /// <summary>
            /// Enum Bottom for value: Bottom
            /// </summary>
            [EnumMember(Value = "Bottom")]
            Bottom = 2,
            
            /// <summary>
            /// Enum Left for value: Left
            /// </summary>
            [EnumMember(Value = "Left")]
            Left = 3,
            
            /// <summary>
            /// Enum Top for value: Top
            /// </summary>
            [EnumMember(Value = "Top")]
            Top = 4
        }

        /// <summary>
        /// The position of the legend on the dashboard item
        /// </summary>
        /// <value>The position of the legend on the dashboard item</value>
        [DataMember(Name="legendPosition", EmitDefaultValue=false)]
        public LegendPositionEnum? LegendPosition { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardContentItemDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DashboardContentItemDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardContentItemDetail" /> class.
        /// </summary>
        /// <param name="drilldownLevel">The drill down level of the dashboard item (required).</param>
        /// <param name="description">The description of the dashboard item.</param>
        /// <param name="chartType">The chart type that will be shown in the dashboard item (required).</param>
        /// <param name="dataSpecification">Details of the data specification used for the dashboard item.</param>
        /// <param name="resolveTableName">The specific resolve table for the dashboard item.</param>
        /// <param name="allowCategoryDisplay">Whether to allow category display on the dashboard item.</param>
        /// <param name="categoryDisplay">Details of any category display on the dashboard item.</param>
        /// <param name="secondaryCategoryDisplay">Details of any secondary category display on the dashboard item.</param>
        /// <param name="omitZeros">Whether to omit zeroes in the data of the dashboard item.</param>
        /// <param name="omitUnclassifiedRows">Whether to omit unclassifieds from the second dimension in the data of the dashboard item.</param>
        /// <param name="omitUnclassifiedColumns">Whether to omit unclassifieds from the first dimension in the data of the dashboard item.</param>
        /// <param name="sortOrder">Whether the chart should be sorted in it&#39;s natural order, by ascending or descending values (required).</param>
        /// <param name="showUnderlyingData">Whether to show the underlying data of the dashboard item.</param>
        /// <param name="notes">The notes for the dashboard item.</param>
        /// <param name="showLegend">Whether to show a legend on the dashboard item.</param>
        /// <param name="legendPosition">The position of the legend on the dashboard item.</param>
        /// <param name="abbreviateCount">Whether to abbreviate the count of the dashboard item.</param>
        /// <param name="decimalPlaces">The number of decimal places to round the count to.</param>
        /// <param name="dataLabels">Details of data labels on the dashboard item.</param>
        public DashboardContentItemDetail(int? drilldownLevel = default(int?), string description = default(string), ChartTypeEnum chartType = default(ChartTypeEnum), DashboardItemDataSpecification dataSpecification = default(DashboardItemDataSpecification), string resolveTableName = default(string), bool? allowCategoryDisplay = default(bool?), DashboardItemCategoryDisplay categoryDisplay = default(DashboardItemCategoryDisplay), DashboardItemCategoryDisplay secondaryCategoryDisplay = default(DashboardItemCategoryDisplay), bool? omitZeros = default(bool?), bool? omitUnclassifiedRows = default(bool?), bool? omitUnclassifiedColumns = default(bool?), SortOrderEnum sortOrder = default(SortOrderEnum), bool? showUnderlyingData = default(bool?), string notes = default(string), bool? showLegend = default(bool?), LegendPositionEnum? legendPosition = default(LegendPositionEnum?), bool? abbreviateCount = default(bool?), int? decimalPlaces = default(int?), DashboardItemDataLabels dataLabels = default(DashboardItemDataLabels))
        {
            // to ensure "drilldownLevel" is required (not null)
            if (drilldownLevel == null)
            {
                throw new InvalidDataException("drilldownLevel is a required property for DashboardContentItemDetail and cannot be null");
            }
            else
            {
                this.DrilldownLevel = drilldownLevel;
            }
            // to ensure "chartType" is required (not null)
            if (chartType == null)
            {
                throw new InvalidDataException("chartType is a required property for DashboardContentItemDetail and cannot be null");
            }
            else
            {
                this.ChartType = chartType;
            }
            // to ensure "sortOrder" is required (not null)
            if (sortOrder == null)
            {
                throw new InvalidDataException("sortOrder is a required property for DashboardContentItemDetail and cannot be null");
            }
            else
            {
                this.SortOrder = sortOrder;
            }
            this.Description = description;
            this.DataSpecification = dataSpecification;
            this.ResolveTableName = resolveTableName;
            this.AllowCategoryDisplay = allowCategoryDisplay;
            this.CategoryDisplay = categoryDisplay;
            this.SecondaryCategoryDisplay = secondaryCategoryDisplay;
            this.OmitZeros = omitZeros;
            this.OmitUnclassifiedRows = omitUnclassifiedRows;
            this.OmitUnclassifiedColumns = omitUnclassifiedColumns;
            this.ShowUnderlyingData = showUnderlyingData;
            this.Notes = notes;
            this.ShowLegend = showLegend;
            this.LegendPosition = legendPosition;
            this.AbbreviateCount = abbreviateCount;
            this.DecimalPlaces = decimalPlaces;
            this.DataLabels = dataLabels;
        }
        
        /// <summary>
        /// The drill down level of the dashboard item
        /// </summary>
        /// <value>The drill down level of the dashboard item</value>
        [DataMember(Name="drilldownLevel", EmitDefaultValue=false)]
        public int? DrilldownLevel { get; set; }

        /// <summary>
        /// The description of the dashboard item
        /// </summary>
        /// <value>The description of the dashboard item</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }


        /// <summary>
        /// Details of the data specification used for the dashboard item
        /// </summary>
        /// <value>Details of the data specification used for the dashboard item</value>
        [DataMember(Name="dataSpecification", EmitDefaultValue=false)]
        public DashboardItemDataSpecification DataSpecification { get; set; }

        /// <summary>
        /// The specific resolve table for the dashboard item
        /// </summary>
        /// <value>The specific resolve table for the dashboard item</value>
        [DataMember(Name="resolveTableName", EmitDefaultValue=false)]
        public string ResolveTableName { get; set; }

        /// <summary>
        /// Whether to allow category display on the dashboard item
        /// </summary>
        /// <value>Whether to allow category display on the dashboard item</value>
        [DataMember(Name="allowCategoryDisplay", EmitDefaultValue=false)]
        public bool? AllowCategoryDisplay { get; set; }

        /// <summary>
        /// Details of any category display on the dashboard item
        /// </summary>
        /// <value>Details of any category display on the dashboard item</value>
        [DataMember(Name="categoryDisplay", EmitDefaultValue=false)]
        public DashboardItemCategoryDisplay CategoryDisplay { get; set; }

        /// <summary>
        /// Details of any secondary category display on the dashboard item
        /// </summary>
        /// <value>Details of any secondary category display on the dashboard item</value>
        [DataMember(Name="secondaryCategoryDisplay", EmitDefaultValue=false)]
        public DashboardItemCategoryDisplay SecondaryCategoryDisplay { get; set; }

        /// <summary>
        /// Whether to omit zeroes in the data of the dashboard item
        /// </summary>
        /// <value>Whether to omit zeroes in the data of the dashboard item</value>
        [DataMember(Name="omitZeros", EmitDefaultValue=false)]
        public bool? OmitZeros { get; set; }

        /// <summary>
        /// Whether to omit unclassifieds from the second dimension in the data of the dashboard item
        /// </summary>
        /// <value>Whether to omit unclassifieds from the second dimension in the data of the dashboard item</value>
        [DataMember(Name="omitUnclassifiedRows", EmitDefaultValue=false)]
        public bool? OmitUnclassifiedRows { get; set; }

        /// <summary>
        /// Whether to omit unclassifieds from the first dimension in the data of the dashboard item
        /// </summary>
        /// <value>Whether to omit unclassifieds from the first dimension in the data of the dashboard item</value>
        [DataMember(Name="omitUnclassifiedColumns", EmitDefaultValue=false)]
        public bool? OmitUnclassifiedColumns { get; set; }


        /// <summary>
        /// Whether to show the underlying data of the dashboard item
        /// </summary>
        /// <value>Whether to show the underlying data of the dashboard item</value>
        [DataMember(Name="showUnderlyingData", EmitDefaultValue=false)]
        public bool? ShowUnderlyingData { get; set; }

        /// <summary>
        /// The notes for the dashboard item
        /// </summary>
        /// <value>The notes for the dashboard item</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// Whether to show a legend on the dashboard item
        /// </summary>
        /// <value>Whether to show a legend on the dashboard item</value>
        [DataMember(Name="showLegend", EmitDefaultValue=false)]
        public bool? ShowLegend { get; set; }


        /// <summary>
        /// Whether to abbreviate the count of the dashboard item
        /// </summary>
        /// <value>Whether to abbreviate the count of the dashboard item</value>
        [DataMember(Name="abbreviateCount", EmitDefaultValue=false)]
        public bool? AbbreviateCount { get; set; }

        /// <summary>
        /// The number of decimal places to round the count to
        /// </summary>
        /// <value>The number of decimal places to round the count to</value>
        [DataMember(Name="decimalPlaces", EmitDefaultValue=false)]
        public int? DecimalPlaces { get; set; }

        /// <summary>
        /// Details of data labels on the dashboard item
        /// </summary>
        /// <value>Details of data labels on the dashboard item</value>
        [DataMember(Name="dataLabels", EmitDefaultValue=false)]
        public DashboardItemDataLabels DataLabels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DashboardContentItemDetail {\n");
            sb.Append("  DrilldownLevel: ").Append(DrilldownLevel).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ChartType: ").Append(ChartType).Append("\n");
            sb.Append("  DataSpecification: ").Append(DataSpecification).Append("\n");
            sb.Append("  ResolveTableName: ").Append(ResolveTableName).Append("\n");
            sb.Append("  AllowCategoryDisplay: ").Append(AllowCategoryDisplay).Append("\n");
            sb.Append("  CategoryDisplay: ").Append(CategoryDisplay).Append("\n");
            sb.Append("  SecondaryCategoryDisplay: ").Append(SecondaryCategoryDisplay).Append("\n");
            sb.Append("  OmitZeros: ").Append(OmitZeros).Append("\n");
            sb.Append("  OmitUnclassifiedRows: ").Append(OmitUnclassifiedRows).Append("\n");
            sb.Append("  OmitUnclassifiedColumns: ").Append(OmitUnclassifiedColumns).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  ShowUnderlyingData: ").Append(ShowUnderlyingData).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  ShowLegend: ").Append(ShowLegend).Append("\n");
            sb.Append("  LegendPosition: ").Append(LegendPosition).Append("\n");
            sb.Append("  AbbreviateCount: ").Append(AbbreviateCount).Append("\n");
            sb.Append("  DecimalPlaces: ").Append(DecimalPlaces).Append("\n");
            sb.Append("  DataLabels: ").Append(DataLabels).Append("\n");
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
            return this.Equals(input as DashboardContentItemDetail);
        }

        /// <summary>
        /// Returns true if DashboardContentItemDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of DashboardContentItemDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DashboardContentItemDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DrilldownLevel == input.DrilldownLevel ||
                    (this.DrilldownLevel != null &&
                    this.DrilldownLevel.Equals(input.DrilldownLevel))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ChartType == input.ChartType ||
                    (this.ChartType != null &&
                    this.ChartType.Equals(input.ChartType))
                ) && 
                (
                    this.DataSpecification == input.DataSpecification ||
                    (this.DataSpecification != null &&
                    this.DataSpecification.Equals(input.DataSpecification))
                ) && 
                (
                    this.ResolveTableName == input.ResolveTableName ||
                    (this.ResolveTableName != null &&
                    this.ResolveTableName.Equals(input.ResolveTableName))
                ) && 
                (
                    this.AllowCategoryDisplay == input.AllowCategoryDisplay ||
                    (this.AllowCategoryDisplay != null &&
                    this.AllowCategoryDisplay.Equals(input.AllowCategoryDisplay))
                ) && 
                (
                    this.CategoryDisplay == input.CategoryDisplay ||
                    (this.CategoryDisplay != null &&
                    this.CategoryDisplay.Equals(input.CategoryDisplay))
                ) && 
                (
                    this.SecondaryCategoryDisplay == input.SecondaryCategoryDisplay ||
                    (this.SecondaryCategoryDisplay != null &&
                    this.SecondaryCategoryDisplay.Equals(input.SecondaryCategoryDisplay))
                ) && 
                (
                    this.OmitZeros == input.OmitZeros ||
                    (this.OmitZeros != null &&
                    this.OmitZeros.Equals(input.OmitZeros))
                ) && 
                (
                    this.OmitUnclassifiedRows == input.OmitUnclassifiedRows ||
                    (this.OmitUnclassifiedRows != null &&
                    this.OmitUnclassifiedRows.Equals(input.OmitUnclassifiedRows))
                ) && 
                (
                    this.OmitUnclassifiedColumns == input.OmitUnclassifiedColumns ||
                    (this.OmitUnclassifiedColumns != null &&
                    this.OmitUnclassifiedColumns.Equals(input.OmitUnclassifiedColumns))
                ) && 
                (
                    this.SortOrder == input.SortOrder ||
                    (this.SortOrder != null &&
                    this.SortOrder.Equals(input.SortOrder))
                ) && 
                (
                    this.ShowUnderlyingData == input.ShowUnderlyingData ||
                    (this.ShowUnderlyingData != null &&
                    this.ShowUnderlyingData.Equals(input.ShowUnderlyingData))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.ShowLegend == input.ShowLegend ||
                    (this.ShowLegend != null &&
                    this.ShowLegend.Equals(input.ShowLegend))
                ) && 
                (
                    this.LegendPosition == input.LegendPosition ||
                    (this.LegendPosition != null &&
                    this.LegendPosition.Equals(input.LegendPosition))
                ) && 
                (
                    this.AbbreviateCount == input.AbbreviateCount ||
                    (this.AbbreviateCount != null &&
                    this.AbbreviateCount.Equals(input.AbbreviateCount))
                ) && 
                (
                    this.DecimalPlaces == input.DecimalPlaces ||
                    (this.DecimalPlaces != null &&
                    this.DecimalPlaces.Equals(input.DecimalPlaces))
                ) && 
                (
                    this.DataLabels == input.DataLabels ||
                    (this.DataLabels != null &&
                    this.DataLabels.Equals(input.DataLabels))
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
                if (this.DrilldownLevel != null)
                    hashCode = hashCode * 59 + this.DrilldownLevel.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ChartType != null)
                    hashCode = hashCode * 59 + this.ChartType.GetHashCode();
                if (this.DataSpecification != null)
                    hashCode = hashCode * 59 + this.DataSpecification.GetHashCode();
                if (this.ResolveTableName != null)
                    hashCode = hashCode * 59 + this.ResolveTableName.GetHashCode();
                if (this.AllowCategoryDisplay != null)
                    hashCode = hashCode * 59 + this.AllowCategoryDisplay.GetHashCode();
                if (this.CategoryDisplay != null)
                    hashCode = hashCode * 59 + this.CategoryDisplay.GetHashCode();
                if (this.SecondaryCategoryDisplay != null)
                    hashCode = hashCode * 59 + this.SecondaryCategoryDisplay.GetHashCode();
                if (this.OmitZeros != null)
                    hashCode = hashCode * 59 + this.OmitZeros.GetHashCode();
                if (this.OmitUnclassifiedRows != null)
                    hashCode = hashCode * 59 + this.OmitUnclassifiedRows.GetHashCode();
                if (this.OmitUnclassifiedColumns != null)
                    hashCode = hashCode * 59 + this.OmitUnclassifiedColumns.GetHashCode();
                if (this.SortOrder != null)
                    hashCode = hashCode * 59 + this.SortOrder.GetHashCode();
                if (this.ShowUnderlyingData != null)
                    hashCode = hashCode * 59 + this.ShowUnderlyingData.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.ShowLegend != null)
                    hashCode = hashCode * 59 + this.ShowLegend.GetHashCode();
                if (this.LegendPosition != null)
                    hashCode = hashCode * 59 + this.LegendPosition.GetHashCode();
                if (this.AbbreviateCount != null)
                    hashCode = hashCode * 59 + this.AbbreviateCount.GetHashCode();
                if (this.DecimalPlaces != null)
                    hashCode = hashCode * 59 + this.DecimalPlaces.GetHashCode();
                if (this.DataLabels != null)
                    hashCode = hashCode * 59 + this.DataLabels.GetHashCode();
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