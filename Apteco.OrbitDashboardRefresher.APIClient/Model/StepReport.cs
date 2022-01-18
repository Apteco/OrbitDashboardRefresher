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
    /// Details for a PeopleStage Action Report
    /// </summary>
    [DataContract]
    public partial class StepReport :  IEquatable<StepReport>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StepReport" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StepReport() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StepReport" /> class.
        /// </summary>
        /// <param name="stepId">The id of the action that generated this report (required).</param>
        /// <param name="isVisible">Whether this action report relates to a visible part of the PeopleStage diagram or not (required).</param>
        /// <param name="estimatedNextRunTime">The date and time of the estimated next run time.</param>
        /// <param name="queuePosition">If available the position in the queue of actions to process for this action.</param>
        /// <param name="jobStatus">If available the status of the job in the job queue for this action (required).</param>
        /// <param name="progress">If available the progress percentage of the action.</param>
        /// <param name="count">If available the number of records processed as the action is running.</param>
        /// <param name="operation">If available the type of operation currently being processed as the action is running (required).</param>
        /// <param name="wasCancelled">Whether this action was cancelled or not.</param>
        /// <param name="cancellationReason">If available the reason that this action was cancelled (required).</param>
        /// <param name="description">The action&#39;s description (required).</param>
        /// <param name="campaignId">The id of the campaign that contains this action (required).</param>
        /// <param name="campaignDescription">The description of the campaign that contains this action (required).</param>
        /// <param name="elementId">If present the id of the element that triggered this action (required).</param>
        /// <param name="elementDescription">If present the description of the element that triggered this action (required).</param>
        /// <param name="timeStarted">The date and time the action started.</param>
        /// <param name="timeFinished">The date and time the action finished.</param>
        /// <param name="numberOfErrors">If available the number of errors reported for this delivery.</param>
        /// <param name="numberOfWarnings">If available the number of warnings reported for this delivery.</param>
        public StepReport(string stepId = default(string), bool? isVisible = default(bool?), DateTime? estimatedNextRunTime = default(DateTime?), int? queuePosition = default(int?), string jobStatus = default(string), int? progress = default(int?), long? count = default(long?), string operation = default(string), bool? wasCancelled = default(bool?), string cancellationReason = default(string), string description = default(string), string campaignId = default(string), string campaignDescription = default(string), string elementId = default(string), string elementDescription = default(string), DateTime? timeStarted = default(DateTime?), DateTime? timeFinished = default(DateTime?), int? numberOfErrors = default(int?), int? numberOfWarnings = default(int?))
        {
            // to ensure "stepId" is required (not null)
            if (stepId == null)
            {
                throw new InvalidDataException("stepId is a required property for StepReport and cannot be null");
            }
            else
            {
                this.StepId = stepId;
            }
            // to ensure "isVisible" is required (not null)
            if (isVisible == null)
            {
                throw new InvalidDataException("isVisible is a required property for StepReport and cannot be null");
            }
            else
            {
                this.IsVisible = isVisible;
            }
            // to ensure "jobStatus" is required (not null)
            if (jobStatus == null)
            {
                throw new InvalidDataException("jobStatus is a required property for StepReport and cannot be null");
            }
            else
            {
                this.JobStatus = jobStatus;
            }
            // to ensure "operation" is required (not null)
            if (operation == null)
            {
                throw new InvalidDataException("operation is a required property for StepReport and cannot be null");
            }
            else
            {
                this.Operation = operation;
            }
            // to ensure "cancellationReason" is required (not null)
            if (cancellationReason == null)
            {
                throw new InvalidDataException("cancellationReason is a required property for StepReport and cannot be null");
            }
            else
            {
                this.CancellationReason = cancellationReason;
            }
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for StepReport and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            // to ensure "campaignId" is required (not null)
            if (campaignId == null)
            {
                throw new InvalidDataException("campaignId is a required property for StepReport and cannot be null");
            }
            else
            {
                this.CampaignId = campaignId;
            }
            // to ensure "campaignDescription" is required (not null)
            if (campaignDescription == null)
            {
                throw new InvalidDataException("campaignDescription is a required property for StepReport and cannot be null");
            }
            else
            {
                this.CampaignDescription = campaignDescription;
            }
            // to ensure "elementId" is required (not null)
            if (elementId == null)
            {
                throw new InvalidDataException("elementId is a required property for StepReport and cannot be null");
            }
            else
            {
                this.ElementId = elementId;
            }
            // to ensure "elementDescription" is required (not null)
            if (elementDescription == null)
            {
                throw new InvalidDataException("elementDescription is a required property for StepReport and cannot be null");
            }
            else
            {
                this.ElementDescription = elementDescription;
            }
            this.EstimatedNextRunTime = estimatedNextRunTime;
            this.QueuePosition = queuePosition;
            this.Progress = progress;
            this.Count = count;
            this.WasCancelled = wasCancelled;
            this.TimeStarted = timeStarted;
            this.TimeFinished = timeFinished;
            this.NumberOfErrors = numberOfErrors;
            this.NumberOfWarnings = numberOfWarnings;
        }
        
        /// <summary>
        /// The id of the action that generated this report
        /// </summary>
        /// <value>The id of the action that generated this report</value>
        [DataMember(Name="stepId", EmitDefaultValue=false)]
        public string StepId { get; set; }

        /// <summary>
        /// Whether this action report relates to a visible part of the PeopleStage diagram or not
        /// </summary>
        /// <value>Whether this action report relates to a visible part of the PeopleStage diagram or not</value>
        [DataMember(Name="isVisible", EmitDefaultValue=false)]
        public bool? IsVisible { get; set; }

        /// <summary>
        /// The date and time of the estimated next run time
        /// </summary>
        /// <value>The date and time of the estimated next run time</value>
        [DataMember(Name="estimatedNextRunTime", EmitDefaultValue=false)]
        public DateTime? EstimatedNextRunTime { get; set; }

        /// <summary>
        /// If available the position in the queue of actions to process for this action
        /// </summary>
        /// <value>If available the position in the queue of actions to process for this action</value>
        [DataMember(Name="queuePosition", EmitDefaultValue=false)]
        public int? QueuePosition { get; set; }

        /// <summary>
        /// If available the status of the job in the job queue for this action
        /// </summary>
        /// <value>If available the status of the job in the job queue for this action</value>
        [DataMember(Name="jobStatus", EmitDefaultValue=false)]
        public string JobStatus { get; set; }

        /// <summary>
        /// If available the progress percentage of the action
        /// </summary>
        /// <value>If available the progress percentage of the action</value>
        [DataMember(Name="progress", EmitDefaultValue=false)]
        public int? Progress { get; set; }

        /// <summary>
        /// If available the number of records processed as the action is running
        /// </summary>
        /// <value>If available the number of records processed as the action is running</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public long? Count { get; set; }

        /// <summary>
        /// If available the type of operation currently being processed as the action is running
        /// </summary>
        /// <value>If available the type of operation currently being processed as the action is running</value>
        [DataMember(Name="operation", EmitDefaultValue=false)]
        public string Operation { get; set; }

        /// <summary>
        /// Whether this action was cancelled or not
        /// </summary>
        /// <value>Whether this action was cancelled or not</value>
        [DataMember(Name="wasCancelled", EmitDefaultValue=false)]
        public bool? WasCancelled { get; set; }

        /// <summary>
        /// If available the reason that this action was cancelled
        /// </summary>
        /// <value>If available the reason that this action was cancelled</value>
        [DataMember(Name="cancellationReason", EmitDefaultValue=false)]
        public string CancellationReason { get; set; }

        /// <summary>
        /// The action&#39;s description
        /// </summary>
        /// <value>The action&#39;s description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The id of the campaign that contains this action
        /// </summary>
        /// <value>The id of the campaign that contains this action</value>
        [DataMember(Name="campaignId", EmitDefaultValue=false)]
        public string CampaignId { get; set; }

        /// <summary>
        /// The description of the campaign that contains this action
        /// </summary>
        /// <value>The description of the campaign that contains this action</value>
        [DataMember(Name="campaignDescription", EmitDefaultValue=false)]
        public string CampaignDescription { get; set; }

        /// <summary>
        /// If present the id of the element that triggered this action
        /// </summary>
        /// <value>If present the id of the element that triggered this action</value>
        [DataMember(Name="elementId", EmitDefaultValue=false)]
        public string ElementId { get; set; }

        /// <summary>
        /// If present the description of the element that triggered this action
        /// </summary>
        /// <value>If present the description of the element that triggered this action</value>
        [DataMember(Name="elementDescription", EmitDefaultValue=false)]
        public string ElementDescription { get; set; }

        /// <summary>
        /// The date and time the action started
        /// </summary>
        /// <value>The date and time the action started</value>
        [DataMember(Name="timeStarted", EmitDefaultValue=false)]
        public DateTime? TimeStarted { get; set; }

        /// <summary>
        /// The date and time the action finished
        /// </summary>
        /// <value>The date and time the action finished</value>
        [DataMember(Name="timeFinished", EmitDefaultValue=false)]
        public DateTime? TimeFinished { get; set; }

        /// <summary>
        /// If available the number of errors reported for this delivery
        /// </summary>
        /// <value>If available the number of errors reported for this delivery</value>
        [DataMember(Name="numberOfErrors", EmitDefaultValue=false)]
        public int? NumberOfErrors { get; set; }

        /// <summary>
        /// If available the number of warnings reported for this delivery
        /// </summary>
        /// <value>If available the number of warnings reported for this delivery</value>
        [DataMember(Name="numberOfWarnings", EmitDefaultValue=false)]
        public int? NumberOfWarnings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StepReport {\n");
            sb.Append("  StepId: ").Append(StepId).Append("\n");
            sb.Append("  IsVisible: ").Append(IsVisible).Append("\n");
            sb.Append("  EstimatedNextRunTime: ").Append(EstimatedNextRunTime).Append("\n");
            sb.Append("  QueuePosition: ").Append(QueuePosition).Append("\n");
            sb.Append("  JobStatus: ").Append(JobStatus).Append("\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  WasCancelled: ").Append(WasCancelled).Append("\n");
            sb.Append("  CancellationReason: ").Append(CancellationReason).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  CampaignDescription: ").Append(CampaignDescription).Append("\n");
            sb.Append("  ElementId: ").Append(ElementId).Append("\n");
            sb.Append("  ElementDescription: ").Append(ElementDescription).Append("\n");
            sb.Append("  TimeStarted: ").Append(TimeStarted).Append("\n");
            sb.Append("  TimeFinished: ").Append(TimeFinished).Append("\n");
            sb.Append("  NumberOfErrors: ").Append(NumberOfErrors).Append("\n");
            sb.Append("  NumberOfWarnings: ").Append(NumberOfWarnings).Append("\n");
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
            return this.Equals(input as StepReport);
        }

        /// <summary>
        /// Returns true if StepReport instances are equal
        /// </summary>
        /// <param name="input">Instance of StepReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StepReport input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StepId == input.StepId ||
                    (this.StepId != null &&
                    this.StepId.Equals(input.StepId))
                ) && 
                (
                    this.IsVisible == input.IsVisible ||
                    (this.IsVisible != null &&
                    this.IsVisible.Equals(input.IsVisible))
                ) && 
                (
                    this.EstimatedNextRunTime == input.EstimatedNextRunTime ||
                    (this.EstimatedNextRunTime != null &&
                    this.EstimatedNextRunTime.Equals(input.EstimatedNextRunTime))
                ) && 
                (
                    this.QueuePosition == input.QueuePosition ||
                    (this.QueuePosition != null &&
                    this.QueuePosition.Equals(input.QueuePosition))
                ) && 
                (
                    this.JobStatus == input.JobStatus ||
                    (this.JobStatus != null &&
                    this.JobStatus.Equals(input.JobStatus))
                ) && 
                (
                    this.Progress == input.Progress ||
                    (this.Progress != null &&
                    this.Progress.Equals(input.Progress))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.Operation == input.Operation ||
                    (this.Operation != null &&
                    this.Operation.Equals(input.Operation))
                ) && 
                (
                    this.WasCancelled == input.WasCancelled ||
                    (this.WasCancelled != null &&
                    this.WasCancelled.Equals(input.WasCancelled))
                ) && 
                (
                    this.CancellationReason == input.CancellationReason ||
                    (this.CancellationReason != null &&
                    this.CancellationReason.Equals(input.CancellationReason))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.CampaignId == input.CampaignId ||
                    (this.CampaignId != null &&
                    this.CampaignId.Equals(input.CampaignId))
                ) && 
                (
                    this.CampaignDescription == input.CampaignDescription ||
                    (this.CampaignDescription != null &&
                    this.CampaignDescription.Equals(input.CampaignDescription))
                ) && 
                (
                    this.ElementId == input.ElementId ||
                    (this.ElementId != null &&
                    this.ElementId.Equals(input.ElementId))
                ) && 
                (
                    this.ElementDescription == input.ElementDescription ||
                    (this.ElementDescription != null &&
                    this.ElementDescription.Equals(input.ElementDescription))
                ) && 
                (
                    this.TimeStarted == input.TimeStarted ||
                    (this.TimeStarted != null &&
                    this.TimeStarted.Equals(input.TimeStarted))
                ) && 
                (
                    this.TimeFinished == input.TimeFinished ||
                    (this.TimeFinished != null &&
                    this.TimeFinished.Equals(input.TimeFinished))
                ) && 
                (
                    this.NumberOfErrors == input.NumberOfErrors ||
                    (this.NumberOfErrors != null &&
                    this.NumberOfErrors.Equals(input.NumberOfErrors))
                ) && 
                (
                    this.NumberOfWarnings == input.NumberOfWarnings ||
                    (this.NumberOfWarnings != null &&
                    this.NumberOfWarnings.Equals(input.NumberOfWarnings))
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
                if (this.StepId != null)
                    hashCode = hashCode * 59 + this.StepId.GetHashCode();
                if (this.IsVisible != null)
                    hashCode = hashCode * 59 + this.IsVisible.GetHashCode();
                if (this.EstimatedNextRunTime != null)
                    hashCode = hashCode * 59 + this.EstimatedNextRunTime.GetHashCode();
                if (this.QueuePosition != null)
                    hashCode = hashCode * 59 + this.QueuePosition.GetHashCode();
                if (this.JobStatus != null)
                    hashCode = hashCode * 59 + this.JobStatus.GetHashCode();
                if (this.Progress != null)
                    hashCode = hashCode * 59 + this.Progress.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Operation != null)
                    hashCode = hashCode * 59 + this.Operation.GetHashCode();
                if (this.WasCancelled != null)
                    hashCode = hashCode * 59 + this.WasCancelled.GetHashCode();
                if (this.CancellationReason != null)
                    hashCode = hashCode * 59 + this.CancellationReason.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CampaignId != null)
                    hashCode = hashCode * 59 + this.CampaignId.GetHashCode();
                if (this.CampaignDescription != null)
                    hashCode = hashCode * 59 + this.CampaignDescription.GetHashCode();
                if (this.ElementId != null)
                    hashCode = hashCode * 59 + this.ElementId.GetHashCode();
                if (this.ElementDescription != null)
                    hashCode = hashCode * 59 + this.ElementDescription.GetHashCode();
                if (this.TimeStarted != null)
                    hashCode = hashCode * 59 + this.TimeStarted.GetHashCode();
                if (this.TimeFinished != null)
                    hashCode = hashCode * 59 + this.TimeFinished.GetHashCode();
                if (this.NumberOfErrors != null)
                    hashCode = hashCode * 59 + this.NumberOfErrors.GetHashCode();
                if (this.NumberOfWarnings != null)
                    hashCode = hashCode * 59 + this.NumberOfWarnings.GetHashCode();
                return hashCode;
            }
        }
    }

}
