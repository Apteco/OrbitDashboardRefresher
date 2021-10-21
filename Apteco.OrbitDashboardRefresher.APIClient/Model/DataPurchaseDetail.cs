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
    /// Details used to create records purchase
    /// </summary>
    [DataContract]
    public partial class DataPurchaseDetail :  IEquatable<DataPurchaseDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataPurchaseDetail" /> class.
        /// </summary>
        /// <param name="queryId">The unique id of the data licensing query to purchase records for.</param>
        /// <param name="licensingSet">The name of the licensing set to purchase records for.</param>
        /// <param name="filename">The name of the file saved to the user&#39;s private directory.</param>
        /// <param name="grandTotalCost">The total cost to license the records.</param>
        /// <param name="purchaseOrderNumber">The order number for this purchase of records.</param>
        /// <param name="password">String of characters to authorise purchase.</param>
        /// <param name="authorisationCode">Authorisation code to purchase records over velocity limit.</param>
        public DataPurchaseDetail(string queryId = default(string), string licensingSet = default(string), string filename = default(string), double? grandTotalCost = default(double?), string purchaseOrderNumber = default(string), string password = default(string), string authorisationCode = default(string))
        {
            this.QueryId = queryId;
            this.LicensingSet = licensingSet;
            this.Filename = filename;
            this.GrandTotalCost = grandTotalCost;
            this.PurchaseOrderNumber = purchaseOrderNumber;
            this.Password = password;
            this.AuthorisationCode = authorisationCode;
        }
        
        /// <summary>
        /// The unique id of the data licensing query to purchase records for
        /// </summary>
        /// <value>The unique id of the data licensing query to purchase records for</value>
        [DataMember(Name="queryId", EmitDefaultValue=false)]
        public string QueryId { get; set; }

        /// <summary>
        /// The name of the licensing set to purchase records for
        /// </summary>
        /// <value>The name of the licensing set to purchase records for</value>
        [DataMember(Name="licensingSet", EmitDefaultValue=false)]
        public string LicensingSet { get; set; }

        /// <summary>
        /// The name of the file saved to the user&#39;s private directory
        /// </summary>
        /// <value>The name of the file saved to the user&#39;s private directory</value>
        [DataMember(Name="filename", EmitDefaultValue=false)]
        public string Filename { get; set; }

        /// <summary>
        /// The total cost to license the records
        /// </summary>
        /// <value>The total cost to license the records</value>
        [DataMember(Name="grandTotalCost", EmitDefaultValue=false)]
        public double? GrandTotalCost { get; set; }

        /// <summary>
        /// The order number for this purchase of records
        /// </summary>
        /// <value>The order number for this purchase of records</value>
        [DataMember(Name="purchaseOrderNumber", EmitDefaultValue=false)]
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        /// String of characters to authorise purchase
        /// </summary>
        /// <value>String of characters to authorise purchase</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Authorisation code to purchase records over velocity limit
        /// </summary>
        /// <value>Authorisation code to purchase records over velocity limit</value>
        [DataMember(Name="authorisationCode", EmitDefaultValue=false)]
        public string AuthorisationCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataPurchaseDetail {\n");
            sb.Append("  QueryId: ").Append(QueryId).Append("\n");
            sb.Append("  LicensingSet: ").Append(LicensingSet).Append("\n");
            sb.Append("  Filename: ").Append(Filename).Append("\n");
            sb.Append("  GrandTotalCost: ").Append(GrandTotalCost).Append("\n");
            sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  AuthorisationCode: ").Append(AuthorisationCode).Append("\n");
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
            return this.Equals(input as DataPurchaseDetail);
        }

        /// <summary>
        /// Returns true if DataPurchaseDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of DataPurchaseDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataPurchaseDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.QueryId == input.QueryId ||
                    (this.QueryId != null &&
                    this.QueryId.Equals(input.QueryId))
                ) && 
                (
                    this.LicensingSet == input.LicensingSet ||
                    (this.LicensingSet != null &&
                    this.LicensingSet.Equals(input.LicensingSet))
                ) && 
                (
                    this.Filename == input.Filename ||
                    (this.Filename != null &&
                    this.Filename.Equals(input.Filename))
                ) && 
                (
                    this.GrandTotalCost == input.GrandTotalCost ||
                    (this.GrandTotalCost != null &&
                    this.GrandTotalCost.Equals(input.GrandTotalCost))
                ) && 
                (
                    this.PurchaseOrderNumber == input.PurchaseOrderNumber ||
                    (this.PurchaseOrderNumber != null &&
                    this.PurchaseOrderNumber.Equals(input.PurchaseOrderNumber))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.AuthorisationCode == input.AuthorisationCode ||
                    (this.AuthorisationCode != null &&
                    this.AuthorisationCode.Equals(input.AuthorisationCode))
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
                if (this.QueryId != null)
                    hashCode = hashCode * 59 + this.QueryId.GetHashCode();
                if (this.LicensingSet != null)
                    hashCode = hashCode * 59 + this.LicensingSet.GetHashCode();
                if (this.Filename != null)
                    hashCode = hashCode * 59 + this.Filename.GetHashCode();
                if (this.GrandTotalCost != null)
                    hashCode = hashCode * 59 + this.GrandTotalCost.GetHashCode();
                if (this.PurchaseOrderNumber != null)
                    hashCode = hashCode * 59 + this.PurchaseOrderNumber.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.AuthorisationCode != null)
                    hashCode = hashCode * 59 + this.AuthorisationCode.GetHashCode();
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
