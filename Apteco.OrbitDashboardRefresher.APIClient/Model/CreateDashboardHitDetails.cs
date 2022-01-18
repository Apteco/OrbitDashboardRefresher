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
    /// Details for registering a dashboard hit
    /// </summary>
    [DataContract]
    public partial class CreateDashboardHitDetails :  IEquatable<CreateDashboardHitDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDashboardHitDetails" /> class.
        /// </summary>
        /// <param name="userAgentDetails">Details of the client application that made the view.</param>
        public CreateDashboardHitDetails(string userAgentDetails = default(string))
        {
            this.UserAgentDetails = userAgentDetails;
        }
        
        /// <summary>
        /// Details of the client application that made the view
        /// </summary>
        /// <value>Details of the client application that made the view</value>
        [DataMember(Name="userAgentDetails", EmitDefaultValue=false)]
        public string UserAgentDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDashboardHitDetails {\n");
            sb.Append("  UserAgentDetails: ").Append(UserAgentDetails).Append("\n");
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
            return this.Equals(input as CreateDashboardHitDetails);
        }

        /// <summary>
        /// Returns true if CreateDashboardHitDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateDashboardHitDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateDashboardHitDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserAgentDetails == input.UserAgentDetails ||
                    (this.UserAgentDetails != null &&
                    this.UserAgentDetails.Equals(input.UserAgentDetails))
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
                if (this.UserAgentDetails != null)
                    hashCode = hashCode * 59 + this.UserAgentDetails.GetHashCode();
                return hashCode;
            }
        }
    }

}
