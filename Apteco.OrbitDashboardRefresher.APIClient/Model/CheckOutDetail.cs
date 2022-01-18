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
    /// Details for checking in or out a PeopleStage element
    /// </summary>
    [DataContract]
    public partial class CheckOutDetail :  IEquatable<CheckOutDetail>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckOutDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CheckOutDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckOutDetail" /> class.
        /// </summary>
        /// <param name="elementId">The id of the element affected (required).</param>
        /// <param name="checkOutUsername">If the element has been checked out, the user that it has been checked out to.</param>
        /// <param name="checkOutTimestamp">If the element has been checked out, the timestamp of when it was checked out.</param>
        /// <param name="checkInUsername">If the element has been checked in, the user that it has been checked in by.</param>
        /// <param name="checkInTimestamp">If the element has been checked in, the timestamp of when it was checked in.</param>
        /// <param name="isCheckedOutToMe">If this check out details indicates that the specified element is checked out to the user that requested it (required).</param>
        public CheckOutDetail(string elementId = default(string), string checkOutUsername = default(string), DateTime? checkOutTimestamp = default(DateTime?), string checkInUsername = default(string), DateTime? checkInTimestamp = default(DateTime?), bool? isCheckedOutToMe = default(bool?))
        {
            // to ensure "elementId" is required (not null)
            if (elementId == null)
            {
                throw new InvalidDataException("elementId is a required property for CheckOutDetail and cannot be null");
            }
            else
            {
                this.ElementId = elementId;
            }
            // to ensure "isCheckedOutToMe" is required (not null)
            if (isCheckedOutToMe == null)
            {
                throw new InvalidDataException("isCheckedOutToMe is a required property for CheckOutDetail and cannot be null");
            }
            else
            {
                this.IsCheckedOutToMe = isCheckedOutToMe;
            }
            this.CheckOutUsername = checkOutUsername;
            this.CheckOutTimestamp = checkOutTimestamp;
            this.CheckInUsername = checkInUsername;
            this.CheckInTimestamp = checkInTimestamp;
        }
        
        /// <summary>
        /// The id of the element affected
        /// </summary>
        /// <value>The id of the element affected</value>
        [DataMember(Name="elementId", EmitDefaultValue=false)]
        public string ElementId { get; set; }

        /// <summary>
        /// If the element has been checked out, the user that it has been checked out to
        /// </summary>
        /// <value>If the element has been checked out, the user that it has been checked out to</value>
        [DataMember(Name="checkOutUsername", EmitDefaultValue=false)]
        public string CheckOutUsername { get; set; }

        /// <summary>
        /// If the element has been checked out, the timestamp of when it was checked out
        /// </summary>
        /// <value>If the element has been checked out, the timestamp of when it was checked out</value>
        [DataMember(Name="checkOutTimestamp", EmitDefaultValue=false)]
        public DateTime? CheckOutTimestamp { get; set; }

        /// <summary>
        /// If the element has been checked in, the user that it has been checked in by
        /// </summary>
        /// <value>If the element has been checked in, the user that it has been checked in by</value>
        [DataMember(Name="checkInUsername", EmitDefaultValue=false)]
        public string CheckInUsername { get; set; }

        /// <summary>
        /// If the element has been checked in, the timestamp of when it was checked in
        /// </summary>
        /// <value>If the element has been checked in, the timestamp of when it was checked in</value>
        [DataMember(Name="checkInTimestamp", EmitDefaultValue=false)]
        public DateTime? CheckInTimestamp { get; set; }

        /// <summary>
        /// If this check out details indicates that the specified element is checked out to the user that requested it
        /// </summary>
        /// <value>If this check out details indicates that the specified element is checked out to the user that requested it</value>
        [DataMember(Name="isCheckedOutToMe", EmitDefaultValue=false)]
        public bool? IsCheckedOutToMe { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckOutDetail {\n");
            sb.Append("  ElementId: ").Append(ElementId).Append("\n");
            sb.Append("  CheckOutUsername: ").Append(CheckOutUsername).Append("\n");
            sb.Append("  CheckOutTimestamp: ").Append(CheckOutTimestamp).Append("\n");
            sb.Append("  CheckInUsername: ").Append(CheckInUsername).Append("\n");
            sb.Append("  CheckInTimestamp: ").Append(CheckInTimestamp).Append("\n");
            sb.Append("  IsCheckedOutToMe: ").Append(IsCheckedOutToMe).Append("\n");
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
            return this.Equals(input as CheckOutDetail);
        }

        /// <summary>
        /// Returns true if CheckOutDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckOutDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckOutDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ElementId == input.ElementId ||
                    (this.ElementId != null &&
                    this.ElementId.Equals(input.ElementId))
                ) && 
                (
                    this.CheckOutUsername == input.CheckOutUsername ||
                    (this.CheckOutUsername != null &&
                    this.CheckOutUsername.Equals(input.CheckOutUsername))
                ) && 
                (
                    this.CheckOutTimestamp == input.CheckOutTimestamp ||
                    (this.CheckOutTimestamp != null &&
                    this.CheckOutTimestamp.Equals(input.CheckOutTimestamp))
                ) && 
                (
                    this.CheckInUsername == input.CheckInUsername ||
                    (this.CheckInUsername != null &&
                    this.CheckInUsername.Equals(input.CheckInUsername))
                ) && 
                (
                    this.CheckInTimestamp == input.CheckInTimestamp ||
                    (this.CheckInTimestamp != null &&
                    this.CheckInTimestamp.Equals(input.CheckInTimestamp))
                ) && 
                (
                    this.IsCheckedOutToMe == input.IsCheckedOutToMe ||
                    (this.IsCheckedOutToMe != null &&
                    this.IsCheckedOutToMe.Equals(input.IsCheckedOutToMe))
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
                if (this.ElementId != null)
                    hashCode = hashCode * 59 + this.ElementId.GetHashCode();
                if (this.CheckOutUsername != null)
                    hashCode = hashCode * 59 + this.CheckOutUsername.GetHashCode();
                if (this.CheckOutTimestamp != null)
                    hashCode = hashCode * 59 + this.CheckOutTimestamp.GetHashCode();
                if (this.CheckInUsername != null)
                    hashCode = hashCode * 59 + this.CheckInUsername.GetHashCode();
                if (this.CheckInTimestamp != null)
                    hashCode = hashCode * 59 + this.CheckInTimestamp.GetHashCode();
                if (this.IsCheckedOutToMe != null)
                    hashCode = hashCode * 59 + this.IsCheckedOutToMe.GetHashCode();
                return hashCode;
            }
        }
    }

}
