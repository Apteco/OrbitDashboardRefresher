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
    /// A dimension to define the categories to break the data in the cube down by
    /// </summary>
    [DataContract]
    public partial class Dimension :  IEquatable<Dimension>
    {
        /// <summary>
        /// The type of the dimension
        /// </summary>
        /// <value>The type of the dimension</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Selector for value: Selector
            /// </summary>
            [EnumMember(Value = "Selector")]
            Selector = 1,
            
            /// <summary>
            /// Enum NumericBand for value: NumericBand
            /// </summary>
            [EnumMember(Value = "NumericBand")]
            NumericBand = 2,
            
            /// <summary>
            /// Enum DateBand for value: DateBand
            /// </summary>
            [EnumMember(Value = "DateBand")]
            DateBand = 3,
            
            /// <summary>
            /// Enum Text for value: Text
            /// </summary>
            [EnumMember(Value = "Text")]
            Text = 4,
            
            /// <summary>
            /// Enum Query for value: Query
            /// </summary>
            [EnumMember(Value = "Query")]
            Query = 5,
            
            /// <summary>
            /// Enum Expression for value: Expression
            /// </summary>
            [EnumMember(Value = "Expression")]
            Expression = 6
        }

        /// <summary>
        /// The type of the dimension
        /// </summary>
        /// <value>The type of the dimension</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Details of the function to use for this dimension
        /// </summary>
        /// <value>Details of the function to use for this dimension</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FunctionEnum
        {
            
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,
            
            /// <summary>
            /// Enum Sum for value: Sum
            /// </summary>
            [EnumMember(Value = "Sum")]
            Sum = 2,
            
            /// <summary>
            /// Enum Mean for value: Mean
            /// </summary>
            [EnumMember(Value = "Mean")]
            Mean = 3,
            
            /// <summary>
            /// Enum Min for value: Min
            /// </summary>
            [EnumMember(Value = "Min")]
            Min = 4,
            
            /// <summary>
            /// Enum Max for value: Max
            /// </summary>
            [EnumMember(Value = "Max")]
            Max = 5,
            
            /// <summary>
            /// Enum Median for value: Median
            /// </summary>
            [EnumMember(Value = "Median")]
            Median = 6,
            
            /// <summary>
            /// Enum Mode for value: Mode
            /// </summary>
            [EnumMember(Value = "Mode")]
            Mode = 7,
            
            /// <summary>
            /// Enum Distinct for value: Distinct
            /// </summary>
            [EnumMember(Value = "Distinct")]
            Distinct = 8,
            
            /// <summary>
            /// Enum Frequency for value: Frequency
            /// </summary>
            [EnumMember(Value = "Frequency")]
            Frequency = 9,
            
            /// <summary>
            /// Enum Recency for value: Recency
            /// </summary>
            [EnumMember(Value = "Recency")]
            Recency = 10,
            
            /// <summary>
            /// Enum RankCoefficient for value: RankCoefficient
            /// </summary>
            [EnumMember(Value = "RankCoefficient")]
            RankCoefficient = 11
        }

        /// <summary>
        /// Details of the function to use for this dimension
        /// </summary>
        /// <value>Details of the function to use for this dimension</value>
        [DataMember(Name="function", EmitDefaultValue=false)]
        public FunctionEnum? Function { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Dimension" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Dimension() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Dimension" /> class.
        /// </summary>
        /// <param name="id">The id of the dimension (required).</param>
        /// <param name="type">The type of the dimension (required).</param>
        /// <param name="query">If the dimension is a query dimension - the definition of the query to use.</param>
        /// <param name="variableName">If the dimension is a selector, numeric, date or text dimension then the name of the variable to use.</param>
        /// <param name="banding">If the dimension is banded, details of the banding to use.</param>
        /// <param name="function">Details of the function to use for this dimension.</param>
        /// <param name="noneCell">If this dimension represents something for a table lower down the hierarchy to the cube&#39;s resolve table,  whether to include a cell for where there a no records on the lower table.  I.e. for where a person has no orders.</param>
        /// <param name="omitUnclassified">If this dimension represents a selector with an unclassified code, whether to omit this from the cube.</param>
        /// <param name="filterQuery">If defined, a query to use to filter the dimension.</param>
        /// <param name="expression">If the dimension is based on an expression then the expression to use.</param>
        /// <param name="minimumCategoryCount">If defined, a minimum threshold for all categories in this dimension before they are included in the results for the cube.  The  value for the threshold is the category&#39;s instant count.  If this property is specified then the TopNCategoryCount and PercentageOfMaximumCategoryThreshold properties must be left undefined..</param>
        /// <param name="topNCategoryCount">If defined, specifies how many categories to return for this dimension (sorted descending by their instant count).   If this property is specified then the MinimumCategoryCount and PercentageOfMaximumCategoryThreshold properties must be left undefined..</param>
        /// <param name="percentageOfMaximumCategoryThreshold">If defined, a threshold for all categories in this dimension before they are included in the results for the cube.  The  threshold is specified as a percentage of the biggest instant count for any category in this dimension.  If this property is specified then the MinimumCategoryCount and TopNCategoryCount properties must be left undefined..</param>
        public Dimension(string id = default(string), TypeEnum type = default(TypeEnum), Query query = default(Query), string variableName = default(string), DimensionBanding banding = default(DimensionBanding), FunctionEnum? function = default(FunctionEnum?), bool? noneCell = default(bool?), bool? omitUnclassified = default(bool?), Query filterQuery = default(Query), Expression expression = default(Expression), int? minimumCategoryCount = default(int?), int? topNCategoryCount = default(int?), int? percentageOfMaximumCategoryThreshold = default(int?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for Dimension and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for Dimension and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.Query = query;
            this.VariableName = variableName;
            this.Banding = banding;
            this.Function = function;
            this.NoneCell = noneCell;
            this.OmitUnclassified = omitUnclassified;
            this.FilterQuery = filterQuery;
            this.Expression = expression;
            this.MinimumCategoryCount = minimumCategoryCount;
            this.TopNCategoryCount = topNCategoryCount;
            this.PercentageOfMaximumCategoryThreshold = percentageOfMaximumCategoryThreshold;
        }
        
        /// <summary>
        /// The id of the dimension
        /// </summary>
        /// <value>The id of the dimension</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }


        /// <summary>
        /// If the dimension is a query dimension - the definition of the query to use
        /// </summary>
        /// <value>If the dimension is a query dimension - the definition of the query to use</value>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public Query Query { get; set; }

        /// <summary>
        /// If the dimension is a selector, numeric, date or text dimension then the name of the variable to use
        /// </summary>
        /// <value>If the dimension is a selector, numeric, date or text dimension then the name of the variable to use</value>
        [DataMember(Name="variableName", EmitDefaultValue=false)]
        public string VariableName { get; set; }

        /// <summary>
        /// If the dimension is banded, details of the banding to use
        /// </summary>
        /// <value>If the dimension is banded, details of the banding to use</value>
        [DataMember(Name="banding", EmitDefaultValue=false)]
        public DimensionBanding Banding { get; set; }


        /// <summary>
        /// If this dimension represents something for a table lower down the hierarchy to the cube&#39;s resolve table,  whether to include a cell for where there a no records on the lower table.  I.e. for where a person has no orders
        /// </summary>
        /// <value>If this dimension represents something for a table lower down the hierarchy to the cube&#39;s resolve table,  whether to include a cell for where there a no records on the lower table.  I.e. for where a person has no orders</value>
        [DataMember(Name="noneCell", EmitDefaultValue=false)]
        public bool? NoneCell { get; set; }

        /// <summary>
        /// If this dimension represents a selector with an unclassified code, whether to omit this from the cube
        /// </summary>
        /// <value>If this dimension represents a selector with an unclassified code, whether to omit this from the cube</value>
        [DataMember(Name="omitUnclassified", EmitDefaultValue=false)]
        public bool? OmitUnclassified { get; set; }

        /// <summary>
        /// If defined, a query to use to filter the dimension
        /// </summary>
        /// <value>If defined, a query to use to filter the dimension</value>
        [DataMember(Name="filterQuery", EmitDefaultValue=false)]
        public Query FilterQuery { get; set; }

        /// <summary>
        /// If the dimension is based on an expression then the expression to use
        /// </summary>
        /// <value>If the dimension is based on an expression then the expression to use</value>
        [DataMember(Name="expression", EmitDefaultValue=false)]
        public Expression Expression { get; set; }

        /// <summary>
        /// If defined, a minimum threshold for all categories in this dimension before they are included in the results for the cube.  The  value for the threshold is the category&#39;s instant count.  If this property is specified then the TopNCategoryCount and PercentageOfMaximumCategoryThreshold properties must be left undefined.
        /// </summary>
        /// <value>If defined, a minimum threshold for all categories in this dimension before they are included in the results for the cube.  The  value for the threshold is the category&#39;s instant count.  If this property is specified then the TopNCategoryCount and PercentageOfMaximumCategoryThreshold properties must be left undefined.</value>
        [DataMember(Name="minimumCategoryCount", EmitDefaultValue=false)]
        public int? MinimumCategoryCount { get; set; }

        /// <summary>
        /// If defined, specifies how many categories to return for this dimension (sorted descending by their instant count).   If this property is specified then the MinimumCategoryCount and PercentageOfMaximumCategoryThreshold properties must be left undefined.
        /// </summary>
        /// <value>If defined, specifies how many categories to return for this dimension (sorted descending by their instant count).   If this property is specified then the MinimumCategoryCount and PercentageOfMaximumCategoryThreshold properties must be left undefined.</value>
        [DataMember(Name="topNCategoryCount", EmitDefaultValue=false)]
        public int? TopNCategoryCount { get; set; }

        /// <summary>
        /// If defined, a threshold for all categories in this dimension before they are included in the results for the cube.  The  threshold is specified as a percentage of the biggest instant count for any category in this dimension.  If this property is specified then the MinimumCategoryCount and TopNCategoryCount properties must be left undefined.
        /// </summary>
        /// <value>If defined, a threshold for all categories in this dimension before they are included in the results for the cube.  The  threshold is specified as a percentage of the biggest instant count for any category in this dimension.  If this property is specified then the MinimumCategoryCount and TopNCategoryCount properties must be left undefined.</value>
        [DataMember(Name="percentageOfMaximumCategoryThreshold", EmitDefaultValue=false)]
        public int? PercentageOfMaximumCategoryThreshold { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Dimension {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  VariableName: ").Append(VariableName).Append("\n");
            sb.Append("  Banding: ").Append(Banding).Append("\n");
            sb.Append("  Function: ").Append(Function).Append("\n");
            sb.Append("  NoneCell: ").Append(NoneCell).Append("\n");
            sb.Append("  OmitUnclassified: ").Append(OmitUnclassified).Append("\n");
            sb.Append("  FilterQuery: ").Append(FilterQuery).Append("\n");
            sb.Append("  Expression: ").Append(Expression).Append("\n");
            sb.Append("  MinimumCategoryCount: ").Append(MinimumCategoryCount).Append("\n");
            sb.Append("  TopNCategoryCount: ").Append(TopNCategoryCount).Append("\n");
            sb.Append("  PercentageOfMaximumCategoryThreshold: ").Append(PercentageOfMaximumCategoryThreshold).Append("\n");
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
            return this.Equals(input as Dimension);
        }

        /// <summary>
        /// Returns true if Dimension instances are equal
        /// </summary>
        /// <param name="input">Instance of Dimension to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Dimension input)
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
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Query == input.Query ||
                    (this.Query != null &&
                    this.Query.Equals(input.Query))
                ) && 
                (
                    this.VariableName == input.VariableName ||
                    (this.VariableName != null &&
                    this.VariableName.Equals(input.VariableName))
                ) && 
                (
                    this.Banding == input.Banding ||
                    (this.Banding != null &&
                    this.Banding.Equals(input.Banding))
                ) && 
                (
                    this.Function == input.Function ||
                    (this.Function != null &&
                    this.Function.Equals(input.Function))
                ) && 
                (
                    this.NoneCell == input.NoneCell ||
                    (this.NoneCell != null &&
                    this.NoneCell.Equals(input.NoneCell))
                ) && 
                (
                    this.OmitUnclassified == input.OmitUnclassified ||
                    (this.OmitUnclassified != null &&
                    this.OmitUnclassified.Equals(input.OmitUnclassified))
                ) && 
                (
                    this.FilterQuery == input.FilterQuery ||
                    (this.FilterQuery != null &&
                    this.FilterQuery.Equals(input.FilterQuery))
                ) && 
                (
                    this.Expression == input.Expression ||
                    (this.Expression != null &&
                    this.Expression.Equals(input.Expression))
                ) && 
                (
                    this.MinimumCategoryCount == input.MinimumCategoryCount ||
                    (this.MinimumCategoryCount != null &&
                    this.MinimumCategoryCount.Equals(input.MinimumCategoryCount))
                ) && 
                (
                    this.TopNCategoryCount == input.TopNCategoryCount ||
                    (this.TopNCategoryCount != null &&
                    this.TopNCategoryCount.Equals(input.TopNCategoryCount))
                ) && 
                (
                    this.PercentageOfMaximumCategoryThreshold == input.PercentageOfMaximumCategoryThreshold ||
                    (this.PercentageOfMaximumCategoryThreshold != null &&
                    this.PercentageOfMaximumCategoryThreshold.Equals(input.PercentageOfMaximumCategoryThreshold))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Query != null)
                    hashCode = hashCode * 59 + this.Query.GetHashCode();
                if (this.VariableName != null)
                    hashCode = hashCode * 59 + this.VariableName.GetHashCode();
                if (this.Banding != null)
                    hashCode = hashCode * 59 + this.Banding.GetHashCode();
                if (this.Function != null)
                    hashCode = hashCode * 59 + this.Function.GetHashCode();
                if (this.NoneCell != null)
                    hashCode = hashCode * 59 + this.NoneCell.GetHashCode();
                if (this.OmitUnclassified != null)
                    hashCode = hashCode * 59 + this.OmitUnclassified.GetHashCode();
                if (this.FilterQuery != null)
                    hashCode = hashCode * 59 + this.FilterQuery.GetHashCode();
                if (this.Expression != null)
                    hashCode = hashCode * 59 + this.Expression.GetHashCode();
                if (this.MinimumCategoryCount != null)
                    hashCode = hashCode * 59 + this.MinimumCategoryCount.GetHashCode();
                if (this.TopNCategoryCount != null)
                    hashCode = hashCode * 59 + this.TopNCategoryCount.GetHashCode();
                if (this.PercentageOfMaximumCategoryThreshold != null)
                    hashCode = hashCode * 59 + this.PercentageOfMaximumCategoryThreshold.GetHashCode();
                return hashCode;
            }
        }
    }

}
