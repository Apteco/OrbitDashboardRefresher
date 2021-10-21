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
    /// Summary information for a Broadcast Channel&#39;s BroadcastOutputSettings
    /// </summary>
    [DataContract]
    public partial class BroadcastOutputSettingsSummary :  IEquatable<BroadcastOutputSettingsSummary>, IValidatableObject
    {
        /// <summary>
        /// The type of broadcaster that the channel uses (e.g. Pure360)
        /// </summary>
        /// <value>The type of broadcaster that the channel uses (e.g. Pure360)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BroadcasterTypeEnum
        {
            
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,
            
            /// <summary>
            /// Enum Adestra for value: Adestra
            /// </summary>
            [EnumMember(Value = "Adestra")]
            Adestra = 2,
            
            /// <summary>
            /// Enum Bronto for value: Bronto
            /// </summary>
            [EnumMember(Value = "Bronto")]
            Bronto = 3,
            
            /// <summary>
            /// Enum Campaigner for value: Campaigner
            /// </summary>
            [EnumMember(Value = "Campaigner")]
            Campaigner = 4,
            
            /// <summary>
            /// Enum CheetahMail for value: CheetahMail
            /// </summary>
            [EnumMember(Value = "CheetahMail")]
            CheetahMail = 5,
            
            /// <summary>
            /// Enum CleverReach for value: CleverReach
            /// </summary>
            [EnumMember(Value = "CleverReach")]
            CleverReach = 6,
            
            /// <summary>
            /// Enum Communicator for value: Communicator
            /// </summary>
            [EnumMember(Value = "Communicator")]
            Communicator = 7,
            
            /// <summary>
            /// Enum DisplayBlock for value: DisplayBlock
            /// </summary>
            [EnumMember(Value = "DisplayBlock")]
            DisplayBlock = 8,
            
            /// <summary>
            /// Enum DotMailer for value: DotMailer
            /// </summary>
            [EnumMember(Value = "DotMailer")]
            DotMailer = 9,
            
            /// <summary>
            /// Enum Dream for value: Dream
            /// </summary>
            [EnumMember(Value = "Dream")]
            Dream = 10,
            
            /// <summary>
            /// Enum DreamMail for value: DreamMail
            /// </summary>
            [EnumMember(Value = "DreamMail")]
            DreamMail = 11,
            
            /// <summary>
            /// Enum Dynmark for value: Dynmark
            /// </summary>
            [EnumMember(Value = "Dynmark")]
            Dynmark = 12,
            
            /// <summary>
            /// Enum Elaine for value: Elaine
            /// </summary>
            [EnumMember(Value = "Elaine")]
            Elaine = 13,
            
            /// <summary>
            /// Enum Eloqua for value: Eloqua
            /// </summary>
            [EnumMember(Value = "Eloqua")]
            Eloqua = 14,
            
            /// <summary>
            /// Enum Ecos for value: Ecos
            /// </summary>
            [EnumMember(Value = "Ecos")]
            Ecos = 15,
            
            /// <summary>
            /// Enum EmailCenter for value: EmailCenter
            /// </summary>
            [EnumMember(Value = "EmailCenter")]
            EmailCenter = 16,
            
            /// <summary>
            /// Enum EmailFlow for value: EmailFlow
            /// </summary>
            [EnumMember(Value = "EmailFlow")]
            EmailFlow = 17,
            
            /// <summary>
            /// Enum EmailVision for value: EmailVision
            /// </summary>
            [EnumMember(Value = "EmailVision")]
            EmailVision = 18,
            
            /// <summary>
            /// Enum Emarsys for value: Emarsys
            /// </summary>
            [EnumMember(Value = "Emarsys")]
            Emarsys = 19,
            
            /// <summary>
            /// Enum ExactTarget for value: ExactTarget
            /// </summary>
            [EnumMember(Value = "ExactTarget")]
            ExactTarget = 20,
            
            /// <summary>
            /// Enum ExactTargetDataExtensions for value: ExactTargetDataExtensions
            /// </summary>
            [EnumMember(Value = "ExactTargetDataExtensions")]
            ExactTargetDataExtensions = 21,
            
            /// <summary>
            /// Enum GenericFtp for value: GenericFtp
            /// </summary>
            [EnumMember(Value = "GenericFtp")]
            GenericFtp = 22,
            
            /// <summary>
            /// Enum GetResponse for value: GetResponse
            /// </summary>
            [EnumMember(Value = "GetResponse")]
            GetResponse = 23,
            
            /// <summary>
            /// Enum Instiller for value: Instiller
            /// </summary>
            [EnumMember(Value = "Instiller")]
            Instiller = 24,
            
            /// <summary>
            /// Enum Kingpin for value: Kingpin
            /// </summary>
            [EnumMember(Value = "Kingpin")]
            Kingpin = 25,
            
            /// <summary>
            /// Enum LinkMobility for value: LinkMobility
            /// </summary>
            [EnumMember(Value = "LinkMobility")]
            LinkMobility = 26,
            
            /// <summary>
            /// Enum MailingWork for value: MailingWork
            /// </summary>
            [EnumMember(Value = "MailingWork")]
            MailingWork = 27,
            
            /// <summary>
            /// Enum Maxemail for value: Maxemail
            /// </summary>
            [EnumMember(Value = "Maxemail")]
            Maxemail = 28,
            
            /// <summary>
            /// Enum Mock for value: Mock
            /// </summary>
            [EnumMember(Value = "Mock")]
            Mock = 29,
            
            /// <summary>
            /// Enum Optivo for value: Optivo
            /// </summary>
            [EnumMember(Value = "Optivo")]
            Optivo = 30,
            
            /// <summary>
            /// Enum PowerShell for value: PowerShell
            /// </summary>
            [EnumMember(Value = "PowerShell")]
            PowerShell = 31,
            
            /// <summary>
            /// Enum Promail for value: Promail
            /// </summary>
            [EnumMember(Value = "Promail")]
            Promail = 32,
            
            /// <summary>
            /// Enum PromioMail for value: PromioMail
            /// </summary>
            [EnumMember(Value = "PromioMail")]
            PromioMail = 33,
            
            /// <summary>
            /// Enum Pure360 for value: Pure360
            /// </summary>
            [EnumMember(Value = "Pure360")]
            Pure360 = 34,
            
            /// <summary>
            /// Enum QBaseMail for value: QBaseMail
            /// </summary>
            [EnumMember(Value = "QBaseMail")]
            QBaseMail = 35,
            
            /// <summary>
            /// Enum RedEye for value: RedEye
            /// </summary>
            [EnumMember(Value = "RedEye")]
            RedEye = 36,
            
            /// <summary>
            /// Enum Responsys for value: Responsys
            /// </summary>
            [EnumMember(Value = "Responsys")]
            Responsys = 37,
            
            /// <summary>
            /// Enum ResponsysInteract for value: ResponsysInteract
            /// </summary>
            [EnumMember(Value = "ResponsysInteract")]
            ResponsysInteract = 38,
            
            /// <summary>
            /// Enum Sailthru for value: Sailthru
            /// </summary>
            [EnumMember(Value = "Sailthru")]
            Sailthru = 39,
            
            /// <summary>
            /// Enum SelligentActionList for value: SelligentActionList
            /// </summary>
            [EnumMember(Value = "SelligentActionList")]
            SelligentActionList = 40,
            
            /// <summary>
            /// Enum SelligentSegment for value: SelligentSegment
            /// </summary>
            [EnumMember(Value = "SelligentSegment")]
            SelligentSegment = 41,
            
            /// <summary>
            /// Enum SignUpTo for value: SignUpTo
            /// </summary>
            [EnumMember(Value = "SignUpTo")]
            SignUpTo = 42,
            
            /// <summary>
            /// Enum Silverpop for value: Silverpop
            /// </summary>
            [EnumMember(Value = "Silverpop")]
            Silverpop = 43,
            
            /// <summary>
            /// Enum SparkPost for value: SparkPost
            /// </summary>
            [EnumMember(Value = "SparkPost")]
            SparkPost = 44,
            
            /// <summary>
            /// Enum StrongMail for value: StrongMail
            /// </summary>
            [EnumMember(Value = "StrongMail")]
            StrongMail = 45,
            
            /// <summary>
            /// Enum Taguchi for value: Taguchi
            /// </summary>
            [EnumMember(Value = "Taguchi")]
            Taguchi = 46,
            
            /// <summary>
            /// Enum Teradata for value: Teradata
            /// </summary>
            [EnumMember(Value = "Teradata")]
            Teradata = 47,
            
            /// <summary>
            /// Enum Traction for value: Traction
            /// </summary>
            [EnumMember(Value = "Traction")]
            Traction = 48,
            
            /// <summary>
            /// Enum TrustPilot for value: TrustPilot
            /// </summary>
            [EnumMember(Value = "TrustPilot")]
            TrustPilot = 49,
            
            /// <summary>
            /// Enum Yesmail for value: Yesmail
            /// </summary>
            [EnumMember(Value = "Yesmail")]
            Yesmail = 50
        }

        /// <summary>
        /// The type of broadcaster that the channel uses (e.g. Pure360)
        /// </summary>
        /// <value>The type of broadcaster that the channel uses (e.g. Pure360)</value>
        [DataMember(Name="broadcasterType", EmitDefaultValue=false)]
        public BroadcasterTypeEnum BroadcasterType { get; set; }
        /// <summary>
        /// What type of content the message is (e.g. HTML, Text). Specifies what template the creative comes from.
        /// </summary>
        /// <value>What type of content the message is (e.g. HTML, Text). Specifies what template the creative comes from.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MessageContentTypeEnum
        {
            
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,
            
            /// <summary>
            /// Enum All for value: All
            /// </summary>
            [EnumMember(Value = "All")]
            All = 2,
            
            /// <summary>
            /// Enum Template for value: Template
            /// </summary>
            [EnumMember(Value = "Template")]
            Template = 3,
            
            /// <summary>
            /// Enum HTML for value: HTML
            /// </summary>
            [EnumMember(Value = "HTML")]
            HTML = 4,
            
            /// <summary>
            /// Enum Text for value: Text
            /// </summary>
            [EnumMember(Value = "Text")]
            Text = 5,
            
            /// <summary>
            /// Enum SMS for value: SMS
            /// </summary>
            [EnumMember(Value = "SMS")]
            SMS = 6
        }

        /// <summary>
        /// What type of content the message is (e.g. HTML, Text). Specifies what template the creative comes from.
        /// </summary>
        /// <value>What type of content the message is (e.g. HTML, Text). Specifies what template the creative comes from.</value>
        [DataMember(Name="messageContentType", EmitDefaultValue=false)]
        public MessageContentTypeEnum MessageContentType { get; set; }
        /// <summary>
        /// Whether a channel is allowed to be used with \&quot;Transactional\&quot; campaigns - i.e. campaigns on tables lower than the Person table.
        /// </summary>
        /// <value>Whether a channel is allowed to be used with \&quot;Transactional\&quot; campaigns - i.e. campaigns on tables lower than the Person table.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AllowTransactionalOutputEnum
        {
            
            /// <summary>
            /// Enum No for value: No
            /// </summary>
            [EnumMember(Value = "No")]
            No = 1,
            
            /// <summary>
            /// Enum Yes for value: Yes
            /// </summary>
            [EnumMember(Value = "Yes")]
            Yes = 2
        }

        /// <summary>
        /// Whether a channel is allowed to be used with \&quot;Transactional\&quot; campaigns - i.e. campaigns on tables lower than the Person table.
        /// </summary>
        /// <value>Whether a channel is allowed to be used with \&quot;Transactional\&quot; campaigns - i.e. campaigns on tables lower than the Person table.</value>
        [DataMember(Name="allowTransactionalOutput", EmitDefaultValue=false)]
        public AllowTransactionalOutputEnum AllowTransactionalOutput { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BroadcastOutputSettingsSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BroadcastOutputSettingsSummary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BroadcastOutputSettingsSummary" /> class.
        /// </summary>
        /// <param name="broadcasterType">The type of broadcaster that the channel uses (e.g. Pure360) (required).</param>
        /// <param name="appendToList">appendToList (required).</param>
        /// <param name="messageContentType">What type of content the message is (e.g. HTML, Text). Specifies what template the creative comes from. (required).</param>
        /// <param name="uploadButDontBroadcast">Whether the channel is upload only or not (required).</param>
        /// <param name="emailVariableDetails">If specified, details of the email variable used in this channel.</param>
        /// <param name="smsVariableDetails">If specified, details of the phone number variable used in this channel.</param>
        /// <param name="additionalVariables">Details of variables always included with this channel.</param>
        /// <param name="fileSettings">Details of the output File Settings.</param>
        /// <param name="allowTransactionalOutput">Whether a channel is allowed to be used with \&quot;Transactional\&quot; campaigns - i.e. campaigns on tables lower than the Person table. (required).</param>
        public BroadcastOutputSettingsSummary(BroadcasterTypeEnum broadcasterType = default(BroadcasterTypeEnum), bool? appendToList = default(bool?), MessageContentTypeEnum messageContentType = default(MessageContentTypeEnum), bool? uploadButDontBroadcast = default(bool?), VariableDetails emailVariableDetails = default(VariableDetails), VariableDetails smsVariableDetails = default(VariableDetails), List<VariableDetails> additionalVariables = default(List<VariableDetails>), FileSettings fileSettings = default(FileSettings), AllowTransactionalOutputEnum allowTransactionalOutput = default(AllowTransactionalOutputEnum))
        {
            // to ensure "broadcasterType" is required (not null)
            if (broadcasterType == null)
            {
                throw new InvalidDataException("broadcasterType is a required property for BroadcastOutputSettingsSummary and cannot be null");
            }
            else
            {
                this.BroadcasterType = broadcasterType;
            }
            // to ensure "appendToList" is required (not null)
            if (appendToList == null)
            {
                throw new InvalidDataException("appendToList is a required property for BroadcastOutputSettingsSummary and cannot be null");
            }
            else
            {
                this.AppendToList = appendToList;
            }
            // to ensure "messageContentType" is required (not null)
            if (messageContentType == null)
            {
                throw new InvalidDataException("messageContentType is a required property for BroadcastOutputSettingsSummary and cannot be null");
            }
            else
            {
                this.MessageContentType = messageContentType;
            }
            // to ensure "uploadButDontBroadcast" is required (not null)
            if (uploadButDontBroadcast == null)
            {
                throw new InvalidDataException("uploadButDontBroadcast is a required property for BroadcastOutputSettingsSummary and cannot be null");
            }
            else
            {
                this.UploadButDontBroadcast = uploadButDontBroadcast;
            }
            // to ensure "allowTransactionalOutput" is required (not null)
            if (allowTransactionalOutput == null)
            {
                throw new InvalidDataException("allowTransactionalOutput is a required property for BroadcastOutputSettingsSummary and cannot be null");
            }
            else
            {
                this.AllowTransactionalOutput = allowTransactionalOutput;
            }
            this.EmailVariableDetails = emailVariableDetails;
            this.SmsVariableDetails = smsVariableDetails;
            this.AdditionalVariables = additionalVariables;
            this.FileSettings = fileSettings;
        }
        

        /// <summary>
        /// Gets or Sets AppendToList
        /// </summary>
        [DataMember(Name="appendToList", EmitDefaultValue=false)]
        public bool? AppendToList { get; set; }


        /// <summary>
        /// Whether the channel is upload only or not
        /// </summary>
        /// <value>Whether the channel is upload only or not</value>
        [DataMember(Name="uploadButDontBroadcast", EmitDefaultValue=false)]
        public bool? UploadButDontBroadcast { get; set; }

        /// <summary>
        /// If specified, details of the email variable used in this channel
        /// </summary>
        /// <value>If specified, details of the email variable used in this channel</value>
        [DataMember(Name="emailVariableDetails", EmitDefaultValue=false)]
        public VariableDetails EmailVariableDetails { get; set; }

        /// <summary>
        /// If specified, details of the phone number variable used in this channel
        /// </summary>
        /// <value>If specified, details of the phone number variable used in this channel</value>
        [DataMember(Name="smsVariableDetails", EmitDefaultValue=false)]
        public VariableDetails SmsVariableDetails { get; set; }

        /// <summary>
        /// Details of variables always included with this channel
        /// </summary>
        /// <value>Details of variables always included with this channel</value>
        [DataMember(Name="additionalVariables", EmitDefaultValue=false)]
        public List<VariableDetails> AdditionalVariables { get; set; }

        /// <summary>
        /// Details of the output File Settings
        /// </summary>
        /// <value>Details of the output File Settings</value>
        [DataMember(Name="fileSettings", EmitDefaultValue=false)]
        public FileSettings FileSettings { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BroadcastOutputSettingsSummary {\n");
            sb.Append("  BroadcasterType: ").Append(BroadcasterType).Append("\n");
            sb.Append("  AppendToList: ").Append(AppendToList).Append("\n");
            sb.Append("  MessageContentType: ").Append(MessageContentType).Append("\n");
            sb.Append("  UploadButDontBroadcast: ").Append(UploadButDontBroadcast).Append("\n");
            sb.Append("  EmailVariableDetails: ").Append(EmailVariableDetails).Append("\n");
            sb.Append("  SmsVariableDetails: ").Append(SmsVariableDetails).Append("\n");
            sb.Append("  AdditionalVariables: ").Append(AdditionalVariables).Append("\n");
            sb.Append("  FileSettings: ").Append(FileSettings).Append("\n");
            sb.Append("  AllowTransactionalOutput: ").Append(AllowTransactionalOutput).Append("\n");
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
            return this.Equals(input as BroadcastOutputSettingsSummary);
        }

        /// <summary>
        /// Returns true if BroadcastOutputSettingsSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of BroadcastOutputSettingsSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BroadcastOutputSettingsSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BroadcasterType == input.BroadcasterType ||
                    (this.BroadcasterType != null &&
                    this.BroadcasterType.Equals(input.BroadcasterType))
                ) && 
                (
                    this.AppendToList == input.AppendToList ||
                    (this.AppendToList != null &&
                    this.AppendToList.Equals(input.AppendToList))
                ) && 
                (
                    this.MessageContentType == input.MessageContentType ||
                    (this.MessageContentType != null &&
                    this.MessageContentType.Equals(input.MessageContentType))
                ) && 
                (
                    this.UploadButDontBroadcast == input.UploadButDontBroadcast ||
                    (this.UploadButDontBroadcast != null &&
                    this.UploadButDontBroadcast.Equals(input.UploadButDontBroadcast))
                ) && 
                (
                    this.EmailVariableDetails == input.EmailVariableDetails ||
                    (this.EmailVariableDetails != null &&
                    this.EmailVariableDetails.Equals(input.EmailVariableDetails))
                ) && 
                (
                    this.SmsVariableDetails == input.SmsVariableDetails ||
                    (this.SmsVariableDetails != null &&
                    this.SmsVariableDetails.Equals(input.SmsVariableDetails))
                ) && 
                (
                    this.AdditionalVariables == input.AdditionalVariables ||
                    this.AdditionalVariables != null &&
                    this.AdditionalVariables.SequenceEqual(input.AdditionalVariables)
                ) && 
                (
                    this.FileSettings == input.FileSettings ||
                    (this.FileSettings != null &&
                    this.FileSettings.Equals(input.FileSettings))
                ) && 
                (
                    this.AllowTransactionalOutput == input.AllowTransactionalOutput ||
                    (this.AllowTransactionalOutput != null &&
                    this.AllowTransactionalOutput.Equals(input.AllowTransactionalOutput))
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
                if (this.BroadcasterType != null)
                    hashCode = hashCode * 59 + this.BroadcasterType.GetHashCode();
                if (this.AppendToList != null)
                    hashCode = hashCode * 59 + this.AppendToList.GetHashCode();
                if (this.MessageContentType != null)
                    hashCode = hashCode * 59 + this.MessageContentType.GetHashCode();
                if (this.UploadButDontBroadcast != null)
                    hashCode = hashCode * 59 + this.UploadButDontBroadcast.GetHashCode();
                if (this.EmailVariableDetails != null)
                    hashCode = hashCode * 59 + this.EmailVariableDetails.GetHashCode();
                if (this.SmsVariableDetails != null)
                    hashCode = hashCode * 59 + this.SmsVariableDetails.GetHashCode();
                if (this.AdditionalVariables != null)
                    hashCode = hashCode * 59 + this.AdditionalVariables.GetHashCode();
                if (this.FileSettings != null)
                    hashCode = hashCode * 59 + this.FileSettings.GetHashCode();
                if (this.AllowTransactionalOutput != null)
                    hashCode = hashCode * 59 + this.AllowTransactionalOutput.GetHashCode();
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
