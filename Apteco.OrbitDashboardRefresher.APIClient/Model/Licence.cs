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
    /// The licence details for the user
    /// </summary>
    [DataContract]
    public partial class Licence :  IEquatable<Licence>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Licence" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Licence() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Licence" /> class.
        /// </summary>
        /// <param name="audienceSelection">Whether this user is allowed to access \&quot;Audience Selection\&quot; functionality (required).</param>
        /// <param name="audiencePreview">Whether this user is allowed to access \&quot;Audience Preview\&quot; functionality (required).</param>
        /// <param name="export">Whether this user is allowed to access \&quot;Export\&quot; functionality (required).</param>
        /// <param name="advancedQuery">Whether this user is allowed to access \&quot;Advanced Query\&quot; functionality (required).</param>
        /// <param name="cube">Whether this user is allowed to access \&quot;Cube\&quot; functionality (required).</param>
        /// <param name="profile">Whether this user is allowed to access \&quot;Profile\&quot; functionality. (required).</param>
        /// <param name="dashboards">Whether this user is allowed to access \&quot;Dashboards\&quot; functionality. (required).</param>
        /// <param name="dashboardsPareto">Whether this user is allowed to access \&quot;Dashboards Pareto\&quot; functionality. (required).</param>
        /// <param name="campaignSingleStep">Whether this user is allowed to access \&quot;Campaign Single Step\&quot; functionality. (required).</param>
        /// <param name="campaignOrbitOverview">Whether this user is allowed to access \&quot;Campaign Orbit Overview\&quot; functionality. (required).</param>
        /// <param name="campaignCustomisedDataDelivery">Whether this user is allowed to access \&quot;Campaign Customised Data Delivery\&quot; functionality. (required).</param>
        /// <param name="bundles">If available, the list of bundles for this user.</param>
        public Licence(bool? audienceSelection = default(bool?), bool? audiencePreview = default(bool?), bool? export = default(bool?), bool? advancedQuery = default(bool?), bool? cube = default(bool?), bool? profile = default(bool?), bool? dashboards = default(bool?), bool? dashboardsPareto = default(bool?), bool? campaignSingleStep = default(bool?), bool? campaignOrbitOverview = default(bool?), bool? campaignCustomisedDataDelivery = default(bool?), List<UserBundleSummary> bundles = default(List<UserBundleSummary>))
        {
            // to ensure "audienceSelection" is required (not null)
            if (audienceSelection == null)
            {
                throw new InvalidDataException("audienceSelection is a required property for Licence and cannot be null");
            }
            else
            {
                this.AudienceSelection = audienceSelection;
            }
            // to ensure "audiencePreview" is required (not null)
            if (audiencePreview == null)
            {
                throw new InvalidDataException("audiencePreview is a required property for Licence and cannot be null");
            }
            else
            {
                this.AudiencePreview = audiencePreview;
            }
            // to ensure "export" is required (not null)
            if (export == null)
            {
                throw new InvalidDataException("export is a required property for Licence and cannot be null");
            }
            else
            {
                this.Export = export;
            }
            // to ensure "advancedQuery" is required (not null)
            if (advancedQuery == null)
            {
                throw new InvalidDataException("advancedQuery is a required property for Licence and cannot be null");
            }
            else
            {
                this.AdvancedQuery = advancedQuery;
            }
            // to ensure "cube" is required (not null)
            if (cube == null)
            {
                throw new InvalidDataException("cube is a required property for Licence and cannot be null");
            }
            else
            {
                this.Cube = cube;
            }
            // to ensure "profile" is required (not null)
            if (profile == null)
            {
                throw new InvalidDataException("profile is a required property for Licence and cannot be null");
            }
            else
            {
                this.Profile = profile;
            }
            // to ensure "dashboards" is required (not null)
            if (dashboards == null)
            {
                throw new InvalidDataException("dashboards is a required property for Licence and cannot be null");
            }
            else
            {
                this.Dashboards = dashboards;
            }
            // to ensure "dashboardsPareto" is required (not null)
            if (dashboardsPareto == null)
            {
                throw new InvalidDataException("dashboardsPareto is a required property for Licence and cannot be null");
            }
            else
            {
                this.DashboardsPareto = dashboardsPareto;
            }
            // to ensure "campaignSingleStep" is required (not null)
            if (campaignSingleStep == null)
            {
                throw new InvalidDataException("campaignSingleStep is a required property for Licence and cannot be null");
            }
            else
            {
                this.CampaignSingleStep = campaignSingleStep;
            }
            // to ensure "campaignOrbitOverview" is required (not null)
            if (campaignOrbitOverview == null)
            {
                throw new InvalidDataException("campaignOrbitOverview is a required property for Licence and cannot be null");
            }
            else
            {
                this.CampaignOrbitOverview = campaignOrbitOverview;
            }
            // to ensure "campaignCustomisedDataDelivery" is required (not null)
            if (campaignCustomisedDataDelivery == null)
            {
                throw new InvalidDataException("campaignCustomisedDataDelivery is a required property for Licence and cannot be null");
            }
            else
            {
                this.CampaignCustomisedDataDelivery = campaignCustomisedDataDelivery;
            }
            this.Bundles = bundles;
        }
        
        /// <summary>
        /// Whether this user is allowed to access \&quot;Audience Selection\&quot; functionality
        /// </summary>
        /// <value>Whether this user is allowed to access \&quot;Audience Selection\&quot; functionality</value>
        [DataMember(Name="audienceSelection", EmitDefaultValue=false)]
        public bool? AudienceSelection { get; set; }

        /// <summary>
        /// Whether this user is allowed to access \&quot;Audience Preview\&quot; functionality
        /// </summary>
        /// <value>Whether this user is allowed to access \&quot;Audience Preview\&quot; functionality</value>
        [DataMember(Name="audiencePreview", EmitDefaultValue=false)]
        public bool? AudiencePreview { get; set; }

        /// <summary>
        /// Whether this user is allowed to access \&quot;Export\&quot; functionality
        /// </summary>
        /// <value>Whether this user is allowed to access \&quot;Export\&quot; functionality</value>
        [DataMember(Name="export", EmitDefaultValue=false)]
        public bool? Export { get; set; }

        /// <summary>
        /// Whether this user is allowed to access \&quot;Advanced Query\&quot; functionality
        /// </summary>
        /// <value>Whether this user is allowed to access \&quot;Advanced Query\&quot; functionality</value>
        [DataMember(Name="advancedQuery", EmitDefaultValue=false)]
        public bool? AdvancedQuery { get; set; }

        /// <summary>
        /// Whether this user is allowed to access \&quot;Cube\&quot; functionality
        /// </summary>
        /// <value>Whether this user is allowed to access \&quot;Cube\&quot; functionality</value>
        [DataMember(Name="cube", EmitDefaultValue=false)]
        public bool? Cube { get; set; }

        /// <summary>
        /// Whether this user is allowed to access \&quot;Profile\&quot; functionality.
        /// </summary>
        /// <value>Whether this user is allowed to access \&quot;Profile\&quot; functionality.</value>
        [DataMember(Name="profile", EmitDefaultValue=false)]
        public bool? Profile { get; set; }

        /// <summary>
        /// Whether this user is allowed to access \&quot;Dashboards\&quot; functionality.
        /// </summary>
        /// <value>Whether this user is allowed to access \&quot;Dashboards\&quot; functionality.</value>
        [DataMember(Name="dashboards", EmitDefaultValue=false)]
        public bool? Dashboards { get; set; }

        /// <summary>
        /// Whether this user is allowed to access \&quot;Dashboards Pareto\&quot; functionality.
        /// </summary>
        /// <value>Whether this user is allowed to access \&quot;Dashboards Pareto\&quot; functionality.</value>
        [DataMember(Name="dashboardsPareto", EmitDefaultValue=false)]
        public bool? DashboardsPareto { get; set; }

        /// <summary>
        /// Whether this user is allowed to access \&quot;Campaign Single Step\&quot; functionality.
        /// </summary>
        /// <value>Whether this user is allowed to access \&quot;Campaign Single Step\&quot; functionality.</value>
        [DataMember(Name="campaignSingleStep", EmitDefaultValue=false)]
        public bool? CampaignSingleStep { get; set; }

        /// <summary>
        /// Whether this user is allowed to access \&quot;Campaign Orbit Overview\&quot; functionality.
        /// </summary>
        /// <value>Whether this user is allowed to access \&quot;Campaign Orbit Overview\&quot; functionality.</value>
        [DataMember(Name="campaignOrbitOverview", EmitDefaultValue=false)]
        public bool? CampaignOrbitOverview { get; set; }

        /// <summary>
        /// Whether this user is allowed to access \&quot;Campaign Customised Data Delivery\&quot; functionality.
        /// </summary>
        /// <value>Whether this user is allowed to access \&quot;Campaign Customised Data Delivery\&quot; functionality.</value>
        [DataMember(Name="campaignCustomisedDataDelivery", EmitDefaultValue=false)]
        public bool? CampaignCustomisedDataDelivery { get; set; }

        /// <summary>
        /// If available, the list of bundles for this user
        /// </summary>
        /// <value>If available, the list of bundles for this user</value>
        [DataMember(Name="bundles", EmitDefaultValue=false)]
        public List<UserBundleSummary> Bundles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Licence {\n");
            sb.Append("  AudienceSelection: ").Append(AudienceSelection).Append("\n");
            sb.Append("  AudiencePreview: ").Append(AudiencePreview).Append("\n");
            sb.Append("  Export: ").Append(Export).Append("\n");
            sb.Append("  AdvancedQuery: ").Append(AdvancedQuery).Append("\n");
            sb.Append("  Cube: ").Append(Cube).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
            sb.Append("  Dashboards: ").Append(Dashboards).Append("\n");
            sb.Append("  DashboardsPareto: ").Append(DashboardsPareto).Append("\n");
            sb.Append("  CampaignSingleStep: ").Append(CampaignSingleStep).Append("\n");
            sb.Append("  CampaignOrbitOverview: ").Append(CampaignOrbitOverview).Append("\n");
            sb.Append("  CampaignCustomisedDataDelivery: ").Append(CampaignCustomisedDataDelivery).Append("\n");
            sb.Append("  Bundles: ").Append(Bundles).Append("\n");
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
            return this.Equals(input as Licence);
        }

        /// <summary>
        /// Returns true if Licence instances are equal
        /// </summary>
        /// <param name="input">Instance of Licence to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Licence input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AudienceSelection == input.AudienceSelection ||
                    (this.AudienceSelection != null &&
                    this.AudienceSelection.Equals(input.AudienceSelection))
                ) && 
                (
                    this.AudiencePreview == input.AudiencePreview ||
                    (this.AudiencePreview != null &&
                    this.AudiencePreview.Equals(input.AudiencePreview))
                ) && 
                (
                    this.Export == input.Export ||
                    (this.Export != null &&
                    this.Export.Equals(input.Export))
                ) && 
                (
                    this.AdvancedQuery == input.AdvancedQuery ||
                    (this.AdvancedQuery != null &&
                    this.AdvancedQuery.Equals(input.AdvancedQuery))
                ) && 
                (
                    this.Cube == input.Cube ||
                    (this.Cube != null &&
                    this.Cube.Equals(input.Cube))
                ) && 
                (
                    this.Profile == input.Profile ||
                    (this.Profile != null &&
                    this.Profile.Equals(input.Profile))
                ) && 
                (
                    this.Dashboards == input.Dashboards ||
                    (this.Dashboards != null &&
                    this.Dashboards.Equals(input.Dashboards))
                ) && 
                (
                    this.DashboardsPareto == input.DashboardsPareto ||
                    (this.DashboardsPareto != null &&
                    this.DashboardsPareto.Equals(input.DashboardsPareto))
                ) && 
                (
                    this.CampaignSingleStep == input.CampaignSingleStep ||
                    (this.CampaignSingleStep != null &&
                    this.CampaignSingleStep.Equals(input.CampaignSingleStep))
                ) && 
                (
                    this.CampaignOrbitOverview == input.CampaignOrbitOverview ||
                    (this.CampaignOrbitOverview != null &&
                    this.CampaignOrbitOverview.Equals(input.CampaignOrbitOverview))
                ) && 
                (
                    this.CampaignCustomisedDataDelivery == input.CampaignCustomisedDataDelivery ||
                    (this.CampaignCustomisedDataDelivery != null &&
                    this.CampaignCustomisedDataDelivery.Equals(input.CampaignCustomisedDataDelivery))
                ) && 
                (
                    this.Bundles == input.Bundles ||
                    this.Bundles != null &&
                    this.Bundles.SequenceEqual(input.Bundles)
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
                if (this.AudienceSelection != null)
                    hashCode = hashCode * 59 + this.AudienceSelection.GetHashCode();
                if (this.AudiencePreview != null)
                    hashCode = hashCode * 59 + this.AudiencePreview.GetHashCode();
                if (this.Export != null)
                    hashCode = hashCode * 59 + this.Export.GetHashCode();
                if (this.AdvancedQuery != null)
                    hashCode = hashCode * 59 + this.AdvancedQuery.GetHashCode();
                if (this.Cube != null)
                    hashCode = hashCode * 59 + this.Cube.GetHashCode();
                if (this.Profile != null)
                    hashCode = hashCode * 59 + this.Profile.GetHashCode();
                if (this.Dashboards != null)
                    hashCode = hashCode * 59 + this.Dashboards.GetHashCode();
                if (this.DashboardsPareto != null)
                    hashCode = hashCode * 59 + this.DashboardsPareto.GetHashCode();
                if (this.CampaignSingleStep != null)
                    hashCode = hashCode * 59 + this.CampaignSingleStep.GetHashCode();
                if (this.CampaignOrbitOverview != null)
                    hashCode = hashCode * 59 + this.CampaignOrbitOverview.GetHashCode();
                if (this.CampaignCustomisedDataDelivery != null)
                    hashCode = hashCode * 59 + this.CampaignCustomisedDataDelivery.GetHashCode();
                if (this.Bundles != null)
                    hashCode = hashCode * 59 + this.Bundles.GetHashCode();
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