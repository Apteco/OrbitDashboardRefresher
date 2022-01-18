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
    /// Information for a PeopleStage Channel Message
    /// </summary>
    [DataContract]
    public partial class ChannelInfo :  IEquatable<ChannelInfo>
    {
        /// <summary>
        /// The channel name
        /// </summary>
        /// <value>The channel name</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TargetChannelEnum
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
            /// Enum Syniverse for value: Syniverse
            /// </summary>
            [EnumMember(Value = "Syniverse")]
            Syniverse = 46,
            
            /// <summary>
            /// Enum Taguchi for value: Taguchi
            /// </summary>
            [EnumMember(Value = "Taguchi")]
            Taguchi = 47,
            
            /// <summary>
            /// Enum Teradata for value: Teradata
            /// </summary>
            [EnumMember(Value = "Teradata")]
            Teradata = 48,
            
            /// <summary>
            /// Enum Traction for value: Traction
            /// </summary>
            [EnumMember(Value = "Traction")]
            Traction = 49,
            
            /// <summary>
            /// Enum TrustPilot for value: TrustPilot
            /// </summary>
            [EnumMember(Value = "TrustPilot")]
            TrustPilot = 50,
            
            /// <summary>
            /// Enum Yesmail for value: Yesmail
            /// </summary>
            [EnumMember(Value = "Yesmail")]
            Yesmail = 51
        }

        /// <summary>
        /// The channel name
        /// </summary>
        /// <value>The channel name</value>
        [DataMember(Name="targetChannel", EmitDefaultValue=false)]
        public TargetChannelEnum? TargetChannel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelInfo" /> class.
        /// </summary>
        /// <param name="targetChannel">The channel name.</param>
        /// <param name="channelType">The channel type.</param>
        /// <param name="channelParameters">The list of channel parameters.</param>
        public ChannelInfo(TargetChannelEnum? targetChannel = default(TargetChannelEnum?), string channelType = default(string), List<ChannelParameterInfo> channelParameters = default(List<ChannelParameterInfo>))
        {
            this.TargetChannel = targetChannel;
            this.ChannelType = channelType;
            this.ChannelParameters = channelParameters;
        }
        

        /// <summary>
        /// The channel type
        /// </summary>
        /// <value>The channel type</value>
        [DataMember(Name="channelType", EmitDefaultValue=false)]
        public string ChannelType { get; set; }

        /// <summary>
        /// The list of channel parameters
        /// </summary>
        /// <value>The list of channel parameters</value>
        [DataMember(Name="channelParameters", EmitDefaultValue=false)]
        public List<ChannelParameterInfo> ChannelParameters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelInfo {\n");
            sb.Append("  TargetChannel: ").Append(TargetChannel).Append("\n");
            sb.Append("  ChannelType: ").Append(ChannelType).Append("\n");
            sb.Append("  ChannelParameters: ").Append(ChannelParameters).Append("\n");
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
            return this.Equals(input as ChannelInfo);
        }

        /// <summary>
        /// Returns true if ChannelInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ChannelInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TargetChannel == input.TargetChannel ||
                    (this.TargetChannel != null &&
                    this.TargetChannel.Equals(input.TargetChannel))
                ) && 
                (
                    this.ChannelType == input.ChannelType ||
                    (this.ChannelType != null &&
                    this.ChannelType.Equals(input.ChannelType))
                ) && 
                (
                    this.ChannelParameters == input.ChannelParameters ||
                    this.ChannelParameters != null &&
                    this.ChannelParameters.SequenceEqual(input.ChannelParameters)
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
                if (this.TargetChannel != null)
                    hashCode = hashCode * 59 + this.TargetChannel.GetHashCode();
                if (this.ChannelType != null)
                    hashCode = hashCode * 59 + this.ChannelType.GetHashCode();
                if (this.ChannelParameters != null)
                    hashCode = hashCode * 59 + this.ChannelParameters.GetHashCode();
                return hashCode;
            }
        }
    }

}
