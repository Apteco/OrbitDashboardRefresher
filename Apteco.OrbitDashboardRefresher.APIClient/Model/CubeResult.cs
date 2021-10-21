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
    /// Results for processing a cube request
    /// </summary>
    [DataContract]
    public partial class CubeResult :  IEquatable<CubeResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CubeResult" /> class.
        /// </summary>
        /// <param name="title">The title of the cube that has been calculated.</param>
        /// <param name="notes">Any notes associated with the query that has been counted.</param>
        /// <param name="ranSuccessfully">Whether the query was counted successfully or not.</param>
        /// <param name="systemName">The name of the FastStats system that this count has been produced by.</param>
        /// <param name="systemLoadDate">The date and time that the FastStats system from which this count has come was last built.</param>
        /// <param name="userName">The name of the user that requested this count.</param>
        /// <param name="runDate">The date and time that this count was run on.</param>
        /// <param name="queryDescription">A textual description of the query that was counted.</param>
        /// <param name="dimensionResults">The set of dimension results for this cube, containing the category codes and descriptions for each dimension in the cube.</param>
        /// <param name="measureResults">The set of measure results for this cube, containing the values for each measure in the cube.</param>
        /// <param name="cube">The definition of the cube that was requested..</param>
        /// <param name="counts">A list of counts for each affected table in the FastStats system.  The first count in the list is the main one..</param>
        public CubeResult(string title = default(string), string notes = default(string), bool? ranSuccessfully = default(bool?), string systemName = default(string), DateTime? systemLoadDate = default(DateTime?), string userName = default(string), DateTime? runDate = default(DateTime?), string queryDescription = default(string), List<DimensionResult> dimensionResults = default(List<DimensionResult>), List<MeasureResult> measureResults = default(List<MeasureResult>), Cube cube = default(Cube), List<Count> counts = default(List<Count>))
        {
            this.Title = title;
            this.Notes = notes;
            this.RanSuccessfully = ranSuccessfully;
            this.SystemName = systemName;
            this.SystemLoadDate = systemLoadDate;
            this.UserName = userName;
            this.RunDate = runDate;
            this.QueryDescription = queryDescription;
            this.DimensionResults = dimensionResults;
            this.MeasureResults = measureResults;
            this.Cube = cube;
            this.Counts = counts;
        }
        
        /// <summary>
        /// The title of the cube that has been calculated
        /// </summary>
        /// <value>The title of the cube that has been calculated</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Any notes associated with the query that has been counted
        /// </summary>
        /// <value>Any notes associated with the query that has been counted</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// Whether the query was counted successfully or not
        /// </summary>
        /// <value>Whether the query was counted successfully or not</value>
        [DataMember(Name="ranSuccessfully", EmitDefaultValue=false)]
        public bool? RanSuccessfully { get; set; }

        /// <summary>
        /// The name of the FastStats system that this count has been produced by
        /// </summary>
        /// <value>The name of the FastStats system that this count has been produced by</value>
        [DataMember(Name="systemName", EmitDefaultValue=false)]
        public string SystemName { get; set; }

        /// <summary>
        /// The date and time that the FastStats system from which this count has come was last built
        /// </summary>
        /// <value>The date and time that the FastStats system from which this count has come was last built</value>
        [DataMember(Name="systemLoadDate", EmitDefaultValue=false)]
        public DateTime? SystemLoadDate { get; set; }

        /// <summary>
        /// The name of the user that requested this count
        /// </summary>
        /// <value>The name of the user that requested this count</value>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// The date and time that this count was run on
        /// </summary>
        /// <value>The date and time that this count was run on</value>
        [DataMember(Name="runDate", EmitDefaultValue=false)]
        public DateTime? RunDate { get; set; }

        /// <summary>
        /// A textual description of the query that was counted
        /// </summary>
        /// <value>A textual description of the query that was counted</value>
        [DataMember(Name="queryDescription", EmitDefaultValue=false)]
        public string QueryDescription { get; set; }

        /// <summary>
        /// The set of dimension results for this cube, containing the category codes and descriptions for each dimension in the cube
        /// </summary>
        /// <value>The set of dimension results for this cube, containing the category codes and descriptions for each dimension in the cube</value>
        [DataMember(Name="dimensionResults", EmitDefaultValue=false)]
        public List<DimensionResult> DimensionResults { get; set; }

        /// <summary>
        /// The set of measure results for this cube, containing the values for each measure in the cube
        /// </summary>
        /// <value>The set of measure results for this cube, containing the values for each measure in the cube</value>
        [DataMember(Name="measureResults", EmitDefaultValue=false)]
        public List<MeasureResult> MeasureResults { get; set; }

        /// <summary>
        /// The definition of the cube that was requested.
        /// </summary>
        /// <value>The definition of the cube that was requested.</value>
        [DataMember(Name="cube", EmitDefaultValue=false)]
        public Cube Cube { get; set; }

        /// <summary>
        /// A list of counts for each affected table in the FastStats system.  The first count in the list is the main one.
        /// </summary>
        /// <value>A list of counts for each affected table in the FastStats system.  The first count in the list is the main one.</value>
        [DataMember(Name="counts", EmitDefaultValue=false)]
        public List<Count> Counts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CubeResult {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  RanSuccessfully: ").Append(RanSuccessfully).Append("\n");
            sb.Append("  SystemName: ").Append(SystemName).Append("\n");
            sb.Append("  SystemLoadDate: ").Append(SystemLoadDate).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  RunDate: ").Append(RunDate).Append("\n");
            sb.Append("  QueryDescription: ").Append(QueryDescription).Append("\n");
            sb.Append("  DimensionResults: ").Append(DimensionResults).Append("\n");
            sb.Append("  MeasureResults: ").Append(MeasureResults).Append("\n");
            sb.Append("  Cube: ").Append(Cube).Append("\n");
            sb.Append("  Counts: ").Append(Counts).Append("\n");
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
            return this.Equals(input as CubeResult);
        }

        /// <summary>
        /// Returns true if CubeResult instances are equal
        /// </summary>
        /// <param name="input">Instance of CubeResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CubeResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.RanSuccessfully == input.RanSuccessfully ||
                    (this.RanSuccessfully != null &&
                    this.RanSuccessfully.Equals(input.RanSuccessfully))
                ) && 
                (
                    this.SystemName == input.SystemName ||
                    (this.SystemName != null &&
                    this.SystemName.Equals(input.SystemName))
                ) && 
                (
                    this.SystemLoadDate == input.SystemLoadDate ||
                    (this.SystemLoadDate != null &&
                    this.SystemLoadDate.Equals(input.SystemLoadDate))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.RunDate == input.RunDate ||
                    (this.RunDate != null &&
                    this.RunDate.Equals(input.RunDate))
                ) && 
                (
                    this.QueryDescription == input.QueryDescription ||
                    (this.QueryDescription != null &&
                    this.QueryDescription.Equals(input.QueryDescription))
                ) && 
                (
                    this.DimensionResults == input.DimensionResults ||
                    this.DimensionResults != null &&
                    this.DimensionResults.SequenceEqual(input.DimensionResults)
                ) && 
                (
                    this.MeasureResults == input.MeasureResults ||
                    this.MeasureResults != null &&
                    this.MeasureResults.SequenceEqual(input.MeasureResults)
                ) && 
                (
                    this.Cube == input.Cube ||
                    (this.Cube != null &&
                    this.Cube.Equals(input.Cube))
                ) && 
                (
                    this.Counts == input.Counts ||
                    this.Counts != null &&
                    this.Counts.SequenceEqual(input.Counts)
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.RanSuccessfully != null)
                    hashCode = hashCode * 59 + this.RanSuccessfully.GetHashCode();
                if (this.SystemName != null)
                    hashCode = hashCode * 59 + this.SystemName.GetHashCode();
                if (this.SystemLoadDate != null)
                    hashCode = hashCode * 59 + this.SystemLoadDate.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.RunDate != null)
                    hashCode = hashCode * 59 + this.RunDate.GetHashCode();
                if (this.QueryDescription != null)
                    hashCode = hashCode * 59 + this.QueryDescription.GetHashCode();
                if (this.DimensionResults != null)
                    hashCode = hashCode * 59 + this.DimensionResults.GetHashCode();
                if (this.MeasureResults != null)
                    hashCode = hashCode * 59 + this.MeasureResults.GetHashCode();
                if (this.Cube != null)
                    hashCode = hashCode * 59 + this.Cube.GetHashCode();
                if (this.Counts != null)
                    hashCode = hashCode * 59 + this.Counts.GetHashCode();
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
