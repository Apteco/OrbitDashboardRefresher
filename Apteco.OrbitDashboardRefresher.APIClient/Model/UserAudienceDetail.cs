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
    /// Details for an audience viewable by a given user
    /// </summary>
    [DataContract]
    public partial class UserAudienceDetail :  IEquatable<UserAudienceDetail>
    {
        /// <summary>
        /// The status of the audience
        /// </summary>
        /// <value>The status of the audience</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Default for value: Default
            /// </summary>
            [EnumMember(Value = "Default")]
            Default = 1,
            
            /// <summary>
            /// Enum Pinned for value: Pinned
            /// </summary>
            [EnumMember(Value = "Pinned")]
            Pinned = 2,
            
            /// <summary>
            /// Enum Archived for value: Archived
            /// </summary>
            [EnumMember(Value = "Archived")]
            Archived = 3
        }

        /// <summary>
        /// The status of the audience
        /// </summary>
        /// <value>The status of the audience</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAudienceDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserAudienceDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAudienceDetail" /> class.
        /// </summary>
        /// <param name="viewingUsername">The username of the user that has access to this audience (required).</param>
        /// <param name="status">The status of the audience (required).</param>
        /// <param name="sharedToMe">Whether this audience has been shared to the given user by someone else (required).</param>
        /// <param name="sharedByMe">Whether this audience has been shared to others by the given user (required).</param>
        /// <param name="briefText">Notes associated with the audience.</param>
        /// <param name="excludeQuery">The query rule that defines the records to exclude from this audience.</param>
        /// <param name="includeQuery">The query rule that defines the records to start with when defining this audience.</param>
        /// <param name="bodyQuery">The query rule that defines the records that will make up this audience, after starting with the records defined by the include query (if specified) and then removing the records defined by the exclude query (if specified).</param>
        /// <param name="selectionModifiers">A definition of how to limit the number of records selected in the nett query built from the exclude, include and body queries.</param>
        /// <param name="queriesLookup">A set of description lookups for variables used in the exclude, include and body queries.</param>
        /// <param name="lastResult">If this audience has been calculated, the last calculation result.</param>
        /// <param name="id">The audience&#39;s id (required).</param>
        /// <param name="title">The title of the audience (required).</param>
        /// <param name="description">The description of the audience (required).</param>
        /// <param name="creationDate">The date the audience was created (required).</param>
        /// <param name="owner">The details of the user that owns this audience (required).</param>
        /// <param name="deletionDate">The date the audience was deleted, or null if it has not been deleted.</param>
        /// <param name="resolveTableName">The FastStats table that the audience is defined against (required).</param>
        /// <param name="resolveTableNettCount">If the audience has been counted, the latest overall count for the resolve table.</param>
        /// <param name="lastCountDate">If the audience has been counted, the latest date it was counted on.</param>
        /// <param name="numberOfUsersSharedWith">The number of people this audience has been shared with (required).</param>
        /// <param name="sharedToAll">Whether the audience has been shared to all users (required).</param>
        /// <param name="shareId">The id of the share associated with this audience, or null if the  audience has not yet been shared.</param>
        /// <param name="numberOfHits">The number of hits associated with this audience (required).</param>
        /// <param name="systemName">The FastStats system that this audience has been created against (required).</param>
        /// <param name="lastUpdatedUser">The details of the user that last updated this audience (required).</param>
        /// <param name="lastUpdatedDate">The date the audience was last updated (required).</param>
        /// <param name="lastUpdateId">The id of the last update for this audience (required).</param>
        /// <param name="campaignId">The PeopleStage campaign id that the audience is linked to.</param>
        /// <param name="dependencies">A list of resources dependent on this audience.</param>
        public UserAudienceDetail(string viewingUsername = default(string), StatusEnum status = default(StatusEnum), bool? sharedToMe = default(bool?), bool? sharedByMe = default(bool?), string briefText = default(string), Query excludeQuery = default(Query), Query includeQuery = default(Query), Query bodyQuery = default(Query), SelectionModifiers selectionModifiers = default(SelectionModifiers), SystemLookup queriesLookup = default(SystemLookup), AudienceResultDetail lastResult = default(AudienceResultDetail), int? id = default(int?), string title = default(string), string description = default(string), DateTime? creationDate = default(DateTime?), UserDisplayDetails owner = default(UserDisplayDetails), DateTime? deletionDate = default(DateTime?), string resolveTableName = default(string), long? resolveTableNettCount = default(long?), DateTime? lastCountDate = default(DateTime?), int? numberOfUsersSharedWith = default(int?), bool? sharedToAll = default(bool?), int? shareId = default(int?), int? numberOfHits = default(int?), string systemName = default(string), UserDisplayDetails lastUpdatedUser = default(UserDisplayDetails), DateTime? lastUpdatedDate = default(DateTime?), int? lastUpdateId = default(int?), string campaignId = default(string), List<AudienceDependency> dependencies = default(List<AudienceDependency>))
        {
            // to ensure "viewingUsername" is required (not null)
            if (viewingUsername == null)
            {
                throw new InvalidDataException("viewingUsername is a required property for UserAudienceDetail and cannot be null");
            }
            else
            {
                this.ViewingUsername = viewingUsername;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for UserAudienceDetail and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            // to ensure "sharedToMe" is required (not null)
            if (sharedToMe == null)
            {
                throw new InvalidDataException("sharedToMe is a required property for UserAudienceDetail and cannot be null");
            }
            else
            {
                this.SharedToMe = sharedToMe;
            }
            // to ensure "sharedByMe" is required (not null)
            if (sharedByMe == null)
            {
                throw new InvalidDataException("sharedByMe is a required property for UserAudienceDetail and cannot be null");
            }
            else
            {
                this.SharedByMe = sharedByMe;
            }
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for UserAudienceDetail and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for UserAudienceDetail and cannot be null");
            }
            else
            {
                this.Title = title;
            }
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for UserAudienceDetail and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            // to ensure "creationDate" is required (not null)
            if (creationDate == null)
            {
                throw new InvalidDataException("creationDate is a required property for UserAudienceDetail and cannot be null");
            }
            else
            {
                this.CreationDate = creationDate;
            }
            // to ensure "owner" is required (not null)
            if (owner == null)
            {
                throw new InvalidDataException("owner is a required property for UserAudienceDetail and cannot be null");
            }
            else
            {
                this.Owner = owner;
            }
            // to ensure "resolveTableName" is required (not null)
            if (resolveTableName == null)
            {
                throw new InvalidDataException("resolveTableName is a required property for UserAudienceDetail and cannot be null");
            }
            else
            {
                this.ResolveTableName = resolveTableName;
            }
            // to ensure "numberOfUsersSharedWith" is required (not null)
            if (numberOfUsersSharedWith == null)
            {
                throw new InvalidDataException("numberOfUsersSharedWith is a required property for UserAudienceDetail and cannot be null");
            }
            else
            {
                this.NumberOfUsersSharedWith = numberOfUsersSharedWith;
            }
            // to ensure "sharedToAll" is required (not null)
            if (sharedToAll == null)
            {
                throw new InvalidDataException("sharedToAll is a required property for UserAudienceDetail and cannot be null");
            }
            else
            {
                this.SharedToAll = sharedToAll;
            }
            // to ensure "numberOfHits" is required (not null)
            if (numberOfHits == null)
            {
                throw new InvalidDataException("numberOfHits is a required property for UserAudienceDetail and cannot be null");
            }
            else
            {
                this.NumberOfHits = numberOfHits;
            }
            // to ensure "systemName" is required (not null)
            if (systemName == null)
            {
                throw new InvalidDataException("systemName is a required property for UserAudienceDetail and cannot be null");
            }
            else
            {
                this.SystemName = systemName;
            }
            // to ensure "lastUpdatedUser" is required (not null)
            if (lastUpdatedUser == null)
            {
                throw new InvalidDataException("lastUpdatedUser is a required property for UserAudienceDetail and cannot be null");
            }
            else
            {
                this.LastUpdatedUser = lastUpdatedUser;
            }
            // to ensure "lastUpdatedDate" is required (not null)
            if (lastUpdatedDate == null)
            {
                throw new InvalidDataException("lastUpdatedDate is a required property for UserAudienceDetail and cannot be null");
            }
            else
            {
                this.LastUpdatedDate = lastUpdatedDate;
            }
            // to ensure "lastUpdateId" is required (not null)
            if (lastUpdateId == null)
            {
                throw new InvalidDataException("lastUpdateId is a required property for UserAudienceDetail and cannot be null");
            }
            else
            {
                this.LastUpdateId = lastUpdateId;
            }
            this.BriefText = briefText;
            this.ExcludeQuery = excludeQuery;
            this.IncludeQuery = includeQuery;
            this.BodyQuery = bodyQuery;
            this.SelectionModifiers = selectionModifiers;
            this.QueriesLookup = queriesLookup;
            this.LastResult = lastResult;
            this.DeletionDate = deletionDate;
            this.ResolveTableNettCount = resolveTableNettCount;
            this.LastCountDate = lastCountDate;
            this.ShareId = shareId;
            this.CampaignId = campaignId;
            this.Dependencies = dependencies;
        }
        
        /// <summary>
        /// The username of the user that has access to this audience
        /// </summary>
        /// <value>The username of the user that has access to this audience</value>
        [DataMember(Name="viewingUsername", EmitDefaultValue=false)]
        public string ViewingUsername { get; set; }


        /// <summary>
        /// Whether this audience has been shared to the given user by someone else
        /// </summary>
        /// <value>Whether this audience has been shared to the given user by someone else</value>
        [DataMember(Name="sharedToMe", EmitDefaultValue=false)]
        public bool? SharedToMe { get; set; }

        /// <summary>
        /// Whether this audience has been shared to others by the given user
        /// </summary>
        /// <value>Whether this audience has been shared to others by the given user</value>
        [DataMember(Name="sharedByMe", EmitDefaultValue=false)]
        public bool? SharedByMe { get; set; }

        /// <summary>
        /// Notes associated with the audience
        /// </summary>
        /// <value>Notes associated with the audience</value>
        [DataMember(Name="briefText", EmitDefaultValue=false)]
        public string BriefText { get; set; }

        /// <summary>
        /// The query rule that defines the records to exclude from this audience
        /// </summary>
        /// <value>The query rule that defines the records to exclude from this audience</value>
        [DataMember(Name="excludeQuery", EmitDefaultValue=false)]
        public Query ExcludeQuery { get; set; }

        /// <summary>
        /// The query rule that defines the records to start with when defining this audience
        /// </summary>
        /// <value>The query rule that defines the records to start with when defining this audience</value>
        [DataMember(Name="includeQuery", EmitDefaultValue=false)]
        public Query IncludeQuery { get; set; }

        /// <summary>
        /// The query rule that defines the records that will make up this audience, after starting with the records defined by the include query (if specified) and then removing the records defined by the exclude query (if specified)
        /// </summary>
        /// <value>The query rule that defines the records that will make up this audience, after starting with the records defined by the include query (if specified) and then removing the records defined by the exclude query (if specified)</value>
        [DataMember(Name="bodyQuery", EmitDefaultValue=false)]
        public Query BodyQuery { get; set; }

        /// <summary>
        /// A definition of how to limit the number of records selected in the nett query built from the exclude, include and body queries
        /// </summary>
        /// <value>A definition of how to limit the number of records selected in the nett query built from the exclude, include and body queries</value>
        [DataMember(Name="selectionModifiers", EmitDefaultValue=false)]
        public SelectionModifiers SelectionModifiers { get; set; }

        /// <summary>
        /// A set of description lookups for variables used in the exclude, include and body queries
        /// </summary>
        /// <value>A set of description lookups for variables used in the exclude, include and body queries</value>
        [DataMember(Name="queriesLookup", EmitDefaultValue=false)]
        public SystemLookup QueriesLookup { get; set; }

        /// <summary>
        /// If this audience has been calculated, the last calculation result
        /// </summary>
        /// <value>If this audience has been calculated, the last calculation result</value>
        [DataMember(Name="lastResult", EmitDefaultValue=false)]
        public AudienceResultDetail LastResult { get; set; }

        /// <summary>
        /// The audience&#39;s id
        /// </summary>
        /// <value>The audience&#39;s id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The title of the audience
        /// </summary>
        /// <value>The title of the audience</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// The description of the audience
        /// </summary>
        /// <value>The description of the audience</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The date the audience was created
        /// </summary>
        /// <value>The date the audience was created</value>
        [DataMember(Name="creationDate", EmitDefaultValue=false)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// The details of the user that owns this audience
        /// </summary>
        /// <value>The details of the user that owns this audience</value>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public UserDisplayDetails Owner { get; set; }

        /// <summary>
        /// The date the audience was deleted, or null if it has not been deleted
        /// </summary>
        /// <value>The date the audience was deleted, or null if it has not been deleted</value>
        [DataMember(Name="deletionDate", EmitDefaultValue=false)]
        public DateTime? DeletionDate { get; set; }

        /// <summary>
        /// The FastStats table that the audience is defined against
        /// </summary>
        /// <value>The FastStats table that the audience is defined against</value>
        [DataMember(Name="resolveTableName", EmitDefaultValue=false)]
        public string ResolveTableName { get; set; }

        /// <summary>
        /// If the audience has been counted, the latest overall count for the resolve table
        /// </summary>
        /// <value>If the audience has been counted, the latest overall count for the resolve table</value>
        [DataMember(Name="resolveTableNettCount", EmitDefaultValue=false)]
        public long? ResolveTableNettCount { get; set; }

        /// <summary>
        /// If the audience has been counted, the latest date it was counted on
        /// </summary>
        /// <value>If the audience has been counted, the latest date it was counted on</value>
        [DataMember(Name="lastCountDate", EmitDefaultValue=false)]
        public DateTime? LastCountDate { get; set; }

        /// <summary>
        /// The number of people this audience has been shared with
        /// </summary>
        /// <value>The number of people this audience has been shared with</value>
        [DataMember(Name="numberOfUsersSharedWith", EmitDefaultValue=false)]
        public int? NumberOfUsersSharedWith { get; set; }

        /// <summary>
        /// Whether the audience has been shared to all users
        /// </summary>
        /// <value>Whether the audience has been shared to all users</value>
        [DataMember(Name="sharedToAll", EmitDefaultValue=false)]
        public bool? SharedToAll { get; set; }

        /// <summary>
        /// The id of the share associated with this audience, or null if the  audience has not yet been shared
        /// </summary>
        /// <value>The id of the share associated with this audience, or null if the  audience has not yet been shared</value>
        [DataMember(Name="shareId", EmitDefaultValue=false)]
        public int? ShareId { get; set; }

        /// <summary>
        /// The number of hits associated with this audience
        /// </summary>
        /// <value>The number of hits associated with this audience</value>
        [DataMember(Name="numberOfHits", EmitDefaultValue=false)]
        public int? NumberOfHits { get; set; }

        /// <summary>
        /// The FastStats system that this audience has been created against
        /// </summary>
        /// <value>The FastStats system that this audience has been created against</value>
        [DataMember(Name="systemName", EmitDefaultValue=false)]
        public string SystemName { get; set; }

        /// <summary>
        /// The details of the user that last updated this audience
        /// </summary>
        /// <value>The details of the user that last updated this audience</value>
        [DataMember(Name="lastUpdatedUser", EmitDefaultValue=false)]
        public UserDisplayDetails LastUpdatedUser { get; set; }

        /// <summary>
        /// The date the audience was last updated
        /// </summary>
        /// <value>The date the audience was last updated</value>
        [DataMember(Name="lastUpdatedDate", EmitDefaultValue=false)]
        public DateTime? LastUpdatedDate { get; set; }

        /// <summary>
        /// The id of the last update for this audience
        /// </summary>
        /// <value>The id of the last update for this audience</value>
        [DataMember(Name="lastUpdateId", EmitDefaultValue=false)]
        public int? LastUpdateId { get; set; }

        /// <summary>
        /// The PeopleStage campaign id that the audience is linked to
        /// </summary>
        /// <value>The PeopleStage campaign id that the audience is linked to</value>
        [DataMember(Name="campaignId", EmitDefaultValue=false)]
        public string CampaignId { get; set; }

        /// <summary>
        /// A list of resources dependent on this audience
        /// </summary>
        /// <value>A list of resources dependent on this audience</value>
        [DataMember(Name="dependencies", EmitDefaultValue=false)]
        public List<AudienceDependency> Dependencies { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserAudienceDetail {\n");
            sb.Append("  ViewingUsername: ").Append(ViewingUsername).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SharedToMe: ").Append(SharedToMe).Append("\n");
            sb.Append("  SharedByMe: ").Append(SharedByMe).Append("\n");
            sb.Append("  BriefText: ").Append(BriefText).Append("\n");
            sb.Append("  ExcludeQuery: ").Append(ExcludeQuery).Append("\n");
            sb.Append("  IncludeQuery: ").Append(IncludeQuery).Append("\n");
            sb.Append("  BodyQuery: ").Append(BodyQuery).Append("\n");
            sb.Append("  SelectionModifiers: ").Append(SelectionModifiers).Append("\n");
            sb.Append("  QueriesLookup: ").Append(QueriesLookup).Append("\n");
            sb.Append("  LastResult: ").Append(LastResult).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  DeletionDate: ").Append(DeletionDate).Append("\n");
            sb.Append("  ResolveTableName: ").Append(ResolveTableName).Append("\n");
            sb.Append("  ResolveTableNettCount: ").Append(ResolveTableNettCount).Append("\n");
            sb.Append("  LastCountDate: ").Append(LastCountDate).Append("\n");
            sb.Append("  NumberOfUsersSharedWith: ").Append(NumberOfUsersSharedWith).Append("\n");
            sb.Append("  SharedToAll: ").Append(SharedToAll).Append("\n");
            sb.Append("  ShareId: ").Append(ShareId).Append("\n");
            sb.Append("  NumberOfHits: ").Append(NumberOfHits).Append("\n");
            sb.Append("  SystemName: ").Append(SystemName).Append("\n");
            sb.Append("  LastUpdatedUser: ").Append(LastUpdatedUser).Append("\n");
            sb.Append("  LastUpdatedDate: ").Append(LastUpdatedDate).Append("\n");
            sb.Append("  LastUpdateId: ").Append(LastUpdateId).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  Dependencies: ").Append(Dependencies).Append("\n");
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
            return this.Equals(input as UserAudienceDetail);
        }

        /// <summary>
        /// Returns true if UserAudienceDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of UserAudienceDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAudienceDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ViewingUsername == input.ViewingUsername ||
                    (this.ViewingUsername != null &&
                    this.ViewingUsername.Equals(input.ViewingUsername))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.SharedToMe == input.SharedToMe ||
                    (this.SharedToMe != null &&
                    this.SharedToMe.Equals(input.SharedToMe))
                ) && 
                (
                    this.SharedByMe == input.SharedByMe ||
                    (this.SharedByMe != null &&
                    this.SharedByMe.Equals(input.SharedByMe))
                ) && 
                (
                    this.BriefText == input.BriefText ||
                    (this.BriefText != null &&
                    this.BriefText.Equals(input.BriefText))
                ) && 
                (
                    this.ExcludeQuery == input.ExcludeQuery ||
                    (this.ExcludeQuery != null &&
                    this.ExcludeQuery.Equals(input.ExcludeQuery))
                ) && 
                (
                    this.IncludeQuery == input.IncludeQuery ||
                    (this.IncludeQuery != null &&
                    this.IncludeQuery.Equals(input.IncludeQuery))
                ) && 
                (
                    this.BodyQuery == input.BodyQuery ||
                    (this.BodyQuery != null &&
                    this.BodyQuery.Equals(input.BodyQuery))
                ) && 
                (
                    this.SelectionModifiers == input.SelectionModifiers ||
                    (this.SelectionModifiers != null &&
                    this.SelectionModifiers.Equals(input.SelectionModifiers))
                ) && 
                (
                    this.QueriesLookup == input.QueriesLookup ||
                    (this.QueriesLookup != null &&
                    this.QueriesLookup.Equals(input.QueriesLookup))
                ) && 
                (
                    this.LastResult == input.LastResult ||
                    (this.LastResult != null &&
                    this.LastResult.Equals(input.LastResult))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.DeletionDate == input.DeletionDate ||
                    (this.DeletionDate != null &&
                    this.DeletionDate.Equals(input.DeletionDate))
                ) && 
                (
                    this.ResolveTableName == input.ResolveTableName ||
                    (this.ResolveTableName != null &&
                    this.ResolveTableName.Equals(input.ResolveTableName))
                ) && 
                (
                    this.ResolveTableNettCount == input.ResolveTableNettCount ||
                    (this.ResolveTableNettCount != null &&
                    this.ResolveTableNettCount.Equals(input.ResolveTableNettCount))
                ) && 
                (
                    this.LastCountDate == input.LastCountDate ||
                    (this.LastCountDate != null &&
                    this.LastCountDate.Equals(input.LastCountDate))
                ) && 
                (
                    this.NumberOfUsersSharedWith == input.NumberOfUsersSharedWith ||
                    (this.NumberOfUsersSharedWith != null &&
                    this.NumberOfUsersSharedWith.Equals(input.NumberOfUsersSharedWith))
                ) && 
                (
                    this.SharedToAll == input.SharedToAll ||
                    (this.SharedToAll != null &&
                    this.SharedToAll.Equals(input.SharedToAll))
                ) && 
                (
                    this.ShareId == input.ShareId ||
                    (this.ShareId != null &&
                    this.ShareId.Equals(input.ShareId))
                ) && 
                (
                    this.NumberOfHits == input.NumberOfHits ||
                    (this.NumberOfHits != null &&
                    this.NumberOfHits.Equals(input.NumberOfHits))
                ) && 
                (
                    this.SystemName == input.SystemName ||
                    (this.SystemName != null &&
                    this.SystemName.Equals(input.SystemName))
                ) && 
                (
                    this.LastUpdatedUser == input.LastUpdatedUser ||
                    (this.LastUpdatedUser != null &&
                    this.LastUpdatedUser.Equals(input.LastUpdatedUser))
                ) && 
                (
                    this.LastUpdatedDate == input.LastUpdatedDate ||
                    (this.LastUpdatedDate != null &&
                    this.LastUpdatedDate.Equals(input.LastUpdatedDate))
                ) && 
                (
                    this.LastUpdateId == input.LastUpdateId ||
                    (this.LastUpdateId != null &&
                    this.LastUpdateId.Equals(input.LastUpdateId))
                ) && 
                (
                    this.CampaignId == input.CampaignId ||
                    (this.CampaignId != null &&
                    this.CampaignId.Equals(input.CampaignId))
                ) && 
                (
                    this.Dependencies == input.Dependencies ||
                    this.Dependencies != null &&
                    this.Dependencies.SequenceEqual(input.Dependencies)
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
                if (this.ViewingUsername != null)
                    hashCode = hashCode * 59 + this.ViewingUsername.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SharedToMe != null)
                    hashCode = hashCode * 59 + this.SharedToMe.GetHashCode();
                if (this.SharedByMe != null)
                    hashCode = hashCode * 59 + this.SharedByMe.GetHashCode();
                if (this.BriefText != null)
                    hashCode = hashCode * 59 + this.BriefText.GetHashCode();
                if (this.ExcludeQuery != null)
                    hashCode = hashCode * 59 + this.ExcludeQuery.GetHashCode();
                if (this.IncludeQuery != null)
                    hashCode = hashCode * 59 + this.IncludeQuery.GetHashCode();
                if (this.BodyQuery != null)
                    hashCode = hashCode * 59 + this.BodyQuery.GetHashCode();
                if (this.SelectionModifiers != null)
                    hashCode = hashCode * 59 + this.SelectionModifiers.GetHashCode();
                if (this.QueriesLookup != null)
                    hashCode = hashCode * 59 + this.QueriesLookup.GetHashCode();
                if (this.LastResult != null)
                    hashCode = hashCode * 59 + this.LastResult.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CreationDate != null)
                    hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.DeletionDate != null)
                    hashCode = hashCode * 59 + this.DeletionDate.GetHashCode();
                if (this.ResolveTableName != null)
                    hashCode = hashCode * 59 + this.ResolveTableName.GetHashCode();
                if (this.ResolveTableNettCount != null)
                    hashCode = hashCode * 59 + this.ResolveTableNettCount.GetHashCode();
                if (this.LastCountDate != null)
                    hashCode = hashCode * 59 + this.LastCountDate.GetHashCode();
                if (this.NumberOfUsersSharedWith != null)
                    hashCode = hashCode * 59 + this.NumberOfUsersSharedWith.GetHashCode();
                if (this.SharedToAll != null)
                    hashCode = hashCode * 59 + this.SharedToAll.GetHashCode();
                if (this.ShareId != null)
                    hashCode = hashCode * 59 + this.ShareId.GetHashCode();
                if (this.NumberOfHits != null)
                    hashCode = hashCode * 59 + this.NumberOfHits.GetHashCode();
                if (this.SystemName != null)
                    hashCode = hashCode * 59 + this.SystemName.GetHashCode();
                if (this.LastUpdatedUser != null)
                    hashCode = hashCode * 59 + this.LastUpdatedUser.GetHashCode();
                if (this.LastUpdatedDate != null)
                    hashCode = hashCode * 59 + this.LastUpdatedDate.GetHashCode();
                if (this.LastUpdateId != null)
                    hashCode = hashCode * 59 + this.LastUpdateId.GetHashCode();
                if (this.CampaignId != null)
                    hashCode = hashCode * 59 + this.CampaignId.GetHashCode();
                if (this.Dependencies != null)
                    hashCode = hashCode * 59 + this.Dependencies.GetHashCode();
                return hashCode;
            }
        }
    }

}
