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
    /// Communication statistics for the specified date range
    /// </summary>
    [DataContract]
    public partial class RangeStatistics :  IEquatable<RangeStatistics>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RangeStatistics" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RangeStatistics() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RangeStatistics" /> class.
        /// </summary>
        /// <param name="id">The element&#39;s id (required).</param>
        /// <param name="communicationsCount">The number of communications sent within this element during the specified date range.</param>
        /// <param name="deliveriesCount">The number of deliveries that have run within this element during the specified date range.</param>
        /// <param name="messagesCount">The number of messages that have had at least one delivery run within this element during the specified date range.</param>
        /// <param name="campaignsCount">The number of campaigns that have had at least one delivery run within this element during the specified date range.</param>
        /// <param name="firstRan">The first time that any deliveries ran within this element during the specified date range.</param>
        /// <param name="lastRan">The last time that any deliveries ran within this element during the specified date range.</param>
        /// <param name="statisticsTimestamp">The date and time that the campaign statistics were calculated.</param>
        public RangeStatistics(string id = default(string), long? communicationsCount = default(long?), long? deliveriesCount = default(long?), long? messagesCount = default(long?), long? campaignsCount = default(long?), DateTime? firstRan = default(DateTime?), DateTime? lastRan = default(DateTime?), DateTime? statisticsTimestamp = default(DateTime?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for RangeStatistics and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            this.CommunicationsCount = communicationsCount;
            this.DeliveriesCount = deliveriesCount;
            this.MessagesCount = messagesCount;
            this.CampaignsCount = campaignsCount;
            this.FirstRan = firstRan;
            this.LastRan = lastRan;
            this.StatisticsTimestamp = statisticsTimestamp;
        }
        
        /// <summary>
        /// The element&#39;s id
        /// </summary>
        /// <value>The element&#39;s id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The number of communications sent within this element during the specified date range
        /// </summary>
        /// <value>The number of communications sent within this element during the specified date range</value>
        [DataMember(Name="communicationsCount", EmitDefaultValue=false)]
        public long? CommunicationsCount { get; set; }

        /// <summary>
        /// The number of deliveries that have run within this element during the specified date range
        /// </summary>
        /// <value>The number of deliveries that have run within this element during the specified date range</value>
        [DataMember(Name="deliveriesCount", EmitDefaultValue=false)]
        public long? DeliveriesCount { get; set; }

        /// <summary>
        /// The number of messages that have had at least one delivery run within this element during the specified date range
        /// </summary>
        /// <value>The number of messages that have had at least one delivery run within this element during the specified date range</value>
        [DataMember(Name="messagesCount", EmitDefaultValue=false)]
        public long? MessagesCount { get; set; }

        /// <summary>
        /// The number of campaigns that have had at least one delivery run within this element during the specified date range
        /// </summary>
        /// <value>The number of campaigns that have had at least one delivery run within this element during the specified date range</value>
        [DataMember(Name="campaignsCount", EmitDefaultValue=false)]
        public long? CampaignsCount { get; set; }

        /// <summary>
        /// The first time that any deliveries ran within this element during the specified date range
        /// </summary>
        /// <value>The first time that any deliveries ran within this element during the specified date range</value>
        [DataMember(Name="firstRan", EmitDefaultValue=false)]
        public DateTime? FirstRan { get; set; }

        /// <summary>
        /// The last time that any deliveries ran within this element during the specified date range
        /// </summary>
        /// <value>The last time that any deliveries ran within this element during the specified date range</value>
        [DataMember(Name="lastRan", EmitDefaultValue=false)]
        public DateTime? LastRan { get; set; }

        /// <summary>
        /// The date and time that the campaign statistics were calculated
        /// </summary>
        /// <value>The date and time that the campaign statistics were calculated</value>
        [DataMember(Name="statisticsTimestamp", EmitDefaultValue=false)]
        public DateTime? StatisticsTimestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RangeStatistics {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CommunicationsCount: ").Append(CommunicationsCount).Append("\n");
            sb.Append("  DeliveriesCount: ").Append(DeliveriesCount).Append("\n");
            sb.Append("  MessagesCount: ").Append(MessagesCount).Append("\n");
            sb.Append("  CampaignsCount: ").Append(CampaignsCount).Append("\n");
            sb.Append("  FirstRan: ").Append(FirstRan).Append("\n");
            sb.Append("  LastRan: ").Append(LastRan).Append("\n");
            sb.Append("  StatisticsTimestamp: ").Append(StatisticsTimestamp).Append("\n");
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
            return this.Equals(input as RangeStatistics);
        }

        /// <summary>
        /// Returns true if RangeStatistics instances are equal
        /// </summary>
        /// <param name="input">Instance of RangeStatistics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RangeStatistics input)
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
                    this.CommunicationsCount == input.CommunicationsCount ||
                    (this.CommunicationsCount != null &&
                    this.CommunicationsCount.Equals(input.CommunicationsCount))
                ) && 
                (
                    this.DeliveriesCount == input.DeliveriesCount ||
                    (this.DeliveriesCount != null &&
                    this.DeliveriesCount.Equals(input.DeliveriesCount))
                ) && 
                (
                    this.MessagesCount == input.MessagesCount ||
                    (this.MessagesCount != null &&
                    this.MessagesCount.Equals(input.MessagesCount))
                ) && 
                (
                    this.CampaignsCount == input.CampaignsCount ||
                    (this.CampaignsCount != null &&
                    this.CampaignsCount.Equals(input.CampaignsCount))
                ) && 
                (
                    this.FirstRan == input.FirstRan ||
                    (this.FirstRan != null &&
                    this.FirstRan.Equals(input.FirstRan))
                ) && 
                (
                    this.LastRan == input.LastRan ||
                    (this.LastRan != null &&
                    this.LastRan.Equals(input.LastRan))
                ) && 
                (
                    this.StatisticsTimestamp == input.StatisticsTimestamp ||
                    (this.StatisticsTimestamp != null &&
                    this.StatisticsTimestamp.Equals(input.StatisticsTimestamp))
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
                if (this.CommunicationsCount != null)
                    hashCode = hashCode * 59 + this.CommunicationsCount.GetHashCode();
                if (this.DeliveriesCount != null)
                    hashCode = hashCode * 59 + this.DeliveriesCount.GetHashCode();
                if (this.MessagesCount != null)
                    hashCode = hashCode * 59 + this.MessagesCount.GetHashCode();
                if (this.CampaignsCount != null)
                    hashCode = hashCode * 59 + this.CampaignsCount.GetHashCode();
                if (this.FirstRan != null)
                    hashCode = hashCode * 59 + this.FirstRan.GetHashCode();
                if (this.LastRan != null)
                    hashCode = hashCode * 59 + this.LastRan.GetHashCode();
                if (this.StatisticsTimestamp != null)
                    hashCode = hashCode * 59 + this.StatisticsTimestamp.GetHashCode();
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
