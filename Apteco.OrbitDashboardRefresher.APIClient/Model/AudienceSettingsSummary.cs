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
    /// Summary of audience settings for a system
    /// </summary>
    [DataContract]
    public partial class AudienceSettingsSummary :  IEquatable<AudienceSettingsSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AudienceSettingsSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AudienceSettingsSummary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AudienceSettingsSummary" /> class.
        /// </summary>
        /// <param name="systemName">The name of the system that the settings apply to (required).</param>
        /// <param name="allowAudienceBrowserDownloadDeliveryEntry">Whether an audience is allowed to have exported data delivered directly to the browser for download (required).</param>
        /// <param name="allowAudienceFtpDeliveryEntry">Whether an audience is allowed to have exported data delivered to an FTP site (required).</param>
        public AudienceSettingsSummary(string systemName = default(string), bool? allowAudienceBrowserDownloadDeliveryEntry = default(bool?), bool? allowAudienceFtpDeliveryEntry = default(bool?))
        {
            // to ensure "systemName" is required (not null)
            if (systemName == null)
            {
                throw new InvalidDataException("systemName is a required property for AudienceSettingsSummary and cannot be null");
            }
            else
            {
                this.SystemName = systemName;
            }
            // to ensure "allowAudienceBrowserDownloadDeliveryEntry" is required (not null)
            if (allowAudienceBrowserDownloadDeliveryEntry == null)
            {
                throw new InvalidDataException("allowAudienceBrowserDownloadDeliveryEntry is a required property for AudienceSettingsSummary and cannot be null");
            }
            else
            {
                this.AllowAudienceBrowserDownloadDeliveryEntry = allowAudienceBrowserDownloadDeliveryEntry;
            }
            // to ensure "allowAudienceFtpDeliveryEntry" is required (not null)
            if (allowAudienceFtpDeliveryEntry == null)
            {
                throw new InvalidDataException("allowAudienceFtpDeliveryEntry is a required property for AudienceSettingsSummary and cannot be null");
            }
            else
            {
                this.AllowAudienceFtpDeliveryEntry = allowAudienceFtpDeliveryEntry;
            }
        }
        
        /// <summary>
        /// The name of the system that the settings apply to
        /// </summary>
        /// <value>The name of the system that the settings apply to</value>
        [DataMember(Name="systemName", EmitDefaultValue=false)]
        public string SystemName { get; set; }

        /// <summary>
        /// Whether an audience is allowed to have exported data delivered directly to the browser for download
        /// </summary>
        /// <value>Whether an audience is allowed to have exported data delivered directly to the browser for download</value>
        [DataMember(Name="allowAudienceBrowserDownloadDeliveryEntry", EmitDefaultValue=false)]
        public bool? AllowAudienceBrowserDownloadDeliveryEntry { get; set; }

        /// <summary>
        /// Whether an audience is allowed to have exported data delivered to an FTP site
        /// </summary>
        /// <value>Whether an audience is allowed to have exported data delivered to an FTP site</value>
        [DataMember(Name="allowAudienceFtpDeliveryEntry", EmitDefaultValue=false)]
        public bool? AllowAudienceFtpDeliveryEntry { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AudienceSettingsSummary {\n");
            sb.Append("  SystemName: ").Append(SystemName).Append("\n");
            sb.Append("  AllowAudienceBrowserDownloadDeliveryEntry: ").Append(AllowAudienceBrowserDownloadDeliveryEntry).Append("\n");
            sb.Append("  AllowAudienceFtpDeliveryEntry: ").Append(AllowAudienceFtpDeliveryEntry).Append("\n");
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
            return this.Equals(input as AudienceSettingsSummary);
        }

        /// <summary>
        /// Returns true if AudienceSettingsSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of AudienceSettingsSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AudienceSettingsSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SystemName == input.SystemName ||
                    (this.SystemName != null &&
                    this.SystemName.Equals(input.SystemName))
                ) && 
                (
                    this.AllowAudienceBrowserDownloadDeliveryEntry == input.AllowAudienceBrowserDownloadDeliveryEntry ||
                    (this.AllowAudienceBrowserDownloadDeliveryEntry != null &&
                    this.AllowAudienceBrowserDownloadDeliveryEntry.Equals(input.AllowAudienceBrowserDownloadDeliveryEntry))
                ) && 
                (
                    this.AllowAudienceFtpDeliveryEntry == input.AllowAudienceFtpDeliveryEntry ||
                    (this.AllowAudienceFtpDeliveryEntry != null &&
                    this.AllowAudienceFtpDeliveryEntry.Equals(input.AllowAudienceFtpDeliveryEntry))
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
                if (this.SystemName != null)
                    hashCode = hashCode * 59 + this.SystemName.GetHashCode();
                if (this.AllowAudienceBrowserDownloadDeliveryEntry != null)
                    hashCode = hashCode * 59 + this.AllowAudienceBrowserDownloadDeliveryEntry.GetHashCode();
                if (this.AllowAudienceFtpDeliveryEntry != null)
                    hashCode = hashCode * 59 + this.AllowAudienceFtpDeliveryEntry.GetHashCode();
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
