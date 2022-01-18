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
    /// The set of capabilities supported by a DataView
    /// </summary>
    [DataContract]
    public partial class Capabilities :  IEquatable<Capabilities>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Capabilities" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Capabilities() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Capabilities" /> class.
        /// </summary>
        /// <param name="supportsAudiences">Whether the DataView in question can support audiences functionality (required).</param>
        /// <param name="supportsPermissions">Whether the DataView in question can support permissions functionality (required).</param>
        /// <param name="supportsDashboardsPareto">Whether the DataView in question can support Pareto tiles functionality in dashboards (required).</param>
        /// <param name="supportsCampaignMonitoring">Whether the DataView in question can support exporting an audience to a PeopleStage channel (required).</param>
        /// <param name="supportsFacebookTokens">Whether the DataView in question can support generating facebook tokens (required).</param>
        /// <param name="supportsGoogleTokens">Whether the DataView in question can support generating google tokens (required).</param>
        /// <param name="supportsLinkedInTokens">Whether the DataView in question can support generating linkedIn tokens (required).</param>
        /// <param name="supportsTwitterTokens">Whether the DataView in question can support generating twitter tokens (required).</param>
        /// <param name="supportsUsersAndGroups">Whether the DataView in question can support users and groups functionality (required).</param>
        public Capabilities(bool? supportsAudiences = default(bool?), bool? supportsPermissions = default(bool?), bool? supportsDashboardsPareto = default(bool?), bool? supportsCampaignMonitoring = default(bool?), bool? supportsFacebookTokens = default(bool?), bool? supportsGoogleTokens = default(bool?), bool? supportsLinkedInTokens = default(bool?), bool? supportsTwitterTokens = default(bool?), bool? supportsUsersAndGroups = default(bool?))
        {
            // to ensure "supportsAudiences" is required (not null)
            if (supportsAudiences == null)
            {
                throw new InvalidDataException("supportsAudiences is a required property for Capabilities and cannot be null");
            }
            else
            {
                this.SupportsAudiences = supportsAudiences;
            }
            // to ensure "supportsPermissions" is required (not null)
            if (supportsPermissions == null)
            {
                throw new InvalidDataException("supportsPermissions is a required property for Capabilities and cannot be null");
            }
            else
            {
                this.SupportsPermissions = supportsPermissions;
            }
            // to ensure "supportsDashboardsPareto" is required (not null)
            if (supportsDashboardsPareto == null)
            {
                throw new InvalidDataException("supportsDashboardsPareto is a required property for Capabilities and cannot be null");
            }
            else
            {
                this.SupportsDashboardsPareto = supportsDashboardsPareto;
            }
            // to ensure "supportsCampaignMonitoring" is required (not null)
            if (supportsCampaignMonitoring == null)
            {
                throw new InvalidDataException("supportsCampaignMonitoring is a required property for Capabilities and cannot be null");
            }
            else
            {
                this.SupportsCampaignMonitoring = supportsCampaignMonitoring;
            }
            // to ensure "supportsFacebookTokens" is required (not null)
            if (supportsFacebookTokens == null)
            {
                throw new InvalidDataException("supportsFacebookTokens is a required property for Capabilities and cannot be null");
            }
            else
            {
                this.SupportsFacebookTokens = supportsFacebookTokens;
            }
            // to ensure "supportsGoogleTokens" is required (not null)
            if (supportsGoogleTokens == null)
            {
                throw new InvalidDataException("supportsGoogleTokens is a required property for Capabilities and cannot be null");
            }
            else
            {
                this.SupportsGoogleTokens = supportsGoogleTokens;
            }
            // to ensure "supportsLinkedInTokens" is required (not null)
            if (supportsLinkedInTokens == null)
            {
                throw new InvalidDataException("supportsLinkedInTokens is a required property for Capabilities and cannot be null");
            }
            else
            {
                this.SupportsLinkedInTokens = supportsLinkedInTokens;
            }
            // to ensure "supportsTwitterTokens" is required (not null)
            if (supportsTwitterTokens == null)
            {
                throw new InvalidDataException("supportsTwitterTokens is a required property for Capabilities and cannot be null");
            }
            else
            {
                this.SupportsTwitterTokens = supportsTwitterTokens;
            }
            // to ensure "supportsUsersAndGroups" is required (not null)
            if (supportsUsersAndGroups == null)
            {
                throw new InvalidDataException("supportsUsersAndGroups is a required property for Capabilities and cannot be null");
            }
            else
            {
                this.SupportsUsersAndGroups = supportsUsersAndGroups;
            }
        }
        
        /// <summary>
        /// Whether the DataView in question can support audiences functionality
        /// </summary>
        /// <value>Whether the DataView in question can support audiences functionality</value>
        [DataMember(Name="supportsAudiences", EmitDefaultValue=false)]
        public bool? SupportsAudiences { get; set; }

        /// <summary>
        /// Whether the DataView in question can support permissions functionality
        /// </summary>
        /// <value>Whether the DataView in question can support permissions functionality</value>
        [DataMember(Name="supportsPermissions", EmitDefaultValue=false)]
        public bool? SupportsPermissions { get; set; }

        /// <summary>
        /// Whether the DataView in question can support Pareto tiles functionality in dashboards
        /// </summary>
        /// <value>Whether the DataView in question can support Pareto tiles functionality in dashboards</value>
        [DataMember(Name="supportsDashboardsPareto", EmitDefaultValue=false)]
        public bool? SupportsDashboardsPareto { get; set; }

        /// <summary>
        /// Whether the DataView in question can support exporting an audience to a PeopleStage channel
        /// </summary>
        /// <value>Whether the DataView in question can support exporting an audience to a PeopleStage channel</value>
        [DataMember(Name="supportsCampaignMonitoring", EmitDefaultValue=false)]
        public bool? SupportsCampaignMonitoring { get; set; }

        /// <summary>
        /// Whether the DataView in question can support generating facebook tokens
        /// </summary>
        /// <value>Whether the DataView in question can support generating facebook tokens</value>
        [DataMember(Name="supportsFacebookTokens", EmitDefaultValue=false)]
        public bool? SupportsFacebookTokens { get; set; }

        /// <summary>
        /// Whether the DataView in question can support generating google tokens
        /// </summary>
        /// <value>Whether the DataView in question can support generating google tokens</value>
        [DataMember(Name="supportsGoogleTokens", EmitDefaultValue=false)]
        public bool? SupportsGoogleTokens { get; set; }

        /// <summary>
        /// Whether the DataView in question can support generating linkedIn tokens
        /// </summary>
        /// <value>Whether the DataView in question can support generating linkedIn tokens</value>
        [DataMember(Name="supportsLinkedInTokens", EmitDefaultValue=false)]
        public bool? SupportsLinkedInTokens { get; set; }

        /// <summary>
        /// Whether the DataView in question can support generating twitter tokens
        /// </summary>
        /// <value>Whether the DataView in question can support generating twitter tokens</value>
        [DataMember(Name="supportsTwitterTokens", EmitDefaultValue=false)]
        public bool? SupportsTwitterTokens { get; set; }

        /// <summary>
        /// Whether the DataView in question can support users and groups functionality
        /// </summary>
        /// <value>Whether the DataView in question can support users and groups functionality</value>
        [DataMember(Name="supportsUsersAndGroups", EmitDefaultValue=false)]
        public bool? SupportsUsersAndGroups { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Capabilities {\n");
            sb.Append("  SupportsAudiences: ").Append(SupportsAudiences).Append("\n");
            sb.Append("  SupportsPermissions: ").Append(SupportsPermissions).Append("\n");
            sb.Append("  SupportsDashboardsPareto: ").Append(SupportsDashboardsPareto).Append("\n");
            sb.Append("  SupportsCampaignMonitoring: ").Append(SupportsCampaignMonitoring).Append("\n");
            sb.Append("  SupportsFacebookTokens: ").Append(SupportsFacebookTokens).Append("\n");
            sb.Append("  SupportsGoogleTokens: ").Append(SupportsGoogleTokens).Append("\n");
            sb.Append("  SupportsLinkedInTokens: ").Append(SupportsLinkedInTokens).Append("\n");
            sb.Append("  SupportsTwitterTokens: ").Append(SupportsTwitterTokens).Append("\n");
            sb.Append("  SupportsUsersAndGroups: ").Append(SupportsUsersAndGroups).Append("\n");
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
            return this.Equals(input as Capabilities);
        }

        /// <summary>
        /// Returns true if Capabilities instances are equal
        /// </summary>
        /// <param name="input">Instance of Capabilities to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Capabilities input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SupportsAudiences == input.SupportsAudiences ||
                    (this.SupportsAudiences != null &&
                    this.SupportsAudiences.Equals(input.SupportsAudiences))
                ) && 
                (
                    this.SupportsPermissions == input.SupportsPermissions ||
                    (this.SupportsPermissions != null &&
                    this.SupportsPermissions.Equals(input.SupportsPermissions))
                ) && 
                (
                    this.SupportsDashboardsPareto == input.SupportsDashboardsPareto ||
                    (this.SupportsDashboardsPareto != null &&
                    this.SupportsDashboardsPareto.Equals(input.SupportsDashboardsPareto))
                ) && 
                (
                    this.SupportsCampaignMonitoring == input.SupportsCampaignMonitoring ||
                    (this.SupportsCampaignMonitoring != null &&
                    this.SupportsCampaignMonitoring.Equals(input.SupportsCampaignMonitoring))
                ) && 
                (
                    this.SupportsFacebookTokens == input.SupportsFacebookTokens ||
                    (this.SupportsFacebookTokens != null &&
                    this.SupportsFacebookTokens.Equals(input.SupportsFacebookTokens))
                ) && 
                (
                    this.SupportsGoogleTokens == input.SupportsGoogleTokens ||
                    (this.SupportsGoogleTokens != null &&
                    this.SupportsGoogleTokens.Equals(input.SupportsGoogleTokens))
                ) && 
                (
                    this.SupportsLinkedInTokens == input.SupportsLinkedInTokens ||
                    (this.SupportsLinkedInTokens != null &&
                    this.SupportsLinkedInTokens.Equals(input.SupportsLinkedInTokens))
                ) && 
                (
                    this.SupportsTwitterTokens == input.SupportsTwitterTokens ||
                    (this.SupportsTwitterTokens != null &&
                    this.SupportsTwitterTokens.Equals(input.SupportsTwitterTokens))
                ) && 
                (
                    this.SupportsUsersAndGroups == input.SupportsUsersAndGroups ||
                    (this.SupportsUsersAndGroups != null &&
                    this.SupportsUsersAndGroups.Equals(input.SupportsUsersAndGroups))
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
                if (this.SupportsAudiences != null)
                    hashCode = hashCode * 59 + this.SupportsAudiences.GetHashCode();
                if (this.SupportsPermissions != null)
                    hashCode = hashCode * 59 + this.SupportsPermissions.GetHashCode();
                if (this.SupportsDashboardsPareto != null)
                    hashCode = hashCode * 59 + this.SupportsDashboardsPareto.GetHashCode();
                if (this.SupportsCampaignMonitoring != null)
                    hashCode = hashCode * 59 + this.SupportsCampaignMonitoring.GetHashCode();
                if (this.SupportsFacebookTokens != null)
                    hashCode = hashCode * 59 + this.SupportsFacebookTokens.GetHashCode();
                if (this.SupportsGoogleTokens != null)
                    hashCode = hashCode * 59 + this.SupportsGoogleTokens.GetHashCode();
                if (this.SupportsLinkedInTokens != null)
                    hashCode = hashCode * 59 + this.SupportsLinkedInTokens.GetHashCode();
                if (this.SupportsTwitterTokens != null)
                    hashCode = hashCode * 59 + this.SupportsTwitterTokens.GetHashCode();
                if (this.SupportsUsersAndGroups != null)
                    hashCode = hashCode * 59 + this.SupportsUsersAndGroups.GetHashCode();
                return hashCode;
            }
        }
    }

}
