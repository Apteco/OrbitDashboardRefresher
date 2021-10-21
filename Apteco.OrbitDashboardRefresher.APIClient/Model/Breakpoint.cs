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
    /// Breakpoint
    /// </summary>
    [DataContract]
    public partial class Breakpoint :  IEquatable<Breakpoint>, IValidatableObject
    {
        /// <summary>
        /// The target breakpoint size
        /// </summary>
        /// <value>The target breakpoint size</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BreakpointEnum
        {
            
            /// <summary>
            /// Enum Xs for value: xs
            /// </summary>
            [EnumMember(Value = "xs")]
            Xs = 1,
            
            /// <summary>
            /// Enum Sm for value: sm
            /// </summary>
            [EnumMember(Value = "sm")]
            Sm = 2,
            
            /// <summary>
            /// Enum Md for value: md
            /// </summary>
            [EnumMember(Value = "md")]
            Md = 3,
            
            /// <summary>
            /// Enum Lg for value: lg
            /// </summary>
            [EnumMember(Value = "lg")]
            Lg = 4,
            
            /// <summary>
            /// Enum Xl for value: xl
            /// </summary>
            [EnumMember(Value = "xl")]
            Xl = 5
        }

        /// <summary>
        /// The target breakpoint size
        /// </summary>
        /// <value>The target breakpoint size</value>
        [DataMember(Name="breakpoint", EmitDefaultValue=false)]
        public BreakpointEnum _Breakpoint { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Breakpoint" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Breakpoint() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Breakpoint" /> class.
        /// </summary>
        /// <param name="breakpoint">The target breakpoint size (required).</param>
        /// <param name="x">The target breakpoint x location (required).</param>
        /// <param name="y">The target breakpoint y location (required).</param>
        /// <param name="size">The size of the dashboard item at the current target breakpoint (required).</param>
        /// <param name="notesAlignment">The alignment details for the dashboard item notes at the current target breakpoint (required).</param>
        public Breakpoint(BreakpointEnum breakpoint = default(BreakpointEnum), int? x = default(int?), int? y = default(int?), Size size = default(Size), NotesAlignment notesAlignment = default(NotesAlignment))
        {
            // to ensure "breakpoint" is required (not null)
            if (breakpoint == null)
            {
                throw new InvalidDataException("breakpoint is a required property for Breakpoint and cannot be null");
            }
            else
            {
                this._Breakpoint = breakpoint;
            }
            // to ensure "x" is required (not null)
            if (x == null)
            {
                throw new InvalidDataException("x is a required property for Breakpoint and cannot be null");
            }
            else
            {
                this.X = x;
            }
            // to ensure "y" is required (not null)
            if (y == null)
            {
                throw new InvalidDataException("y is a required property for Breakpoint and cannot be null");
            }
            else
            {
                this.Y = y;
            }
            // to ensure "size" is required (not null)
            if (size == null)
            {
                throw new InvalidDataException("size is a required property for Breakpoint and cannot be null");
            }
            else
            {
                this.Size = size;
            }
            // to ensure "notesAlignment" is required (not null)
            if (notesAlignment == null)
            {
                throw new InvalidDataException("notesAlignment is a required property for Breakpoint and cannot be null");
            }
            else
            {
                this.NotesAlignment = notesAlignment;
            }
        }
        

        /// <summary>
        /// The target breakpoint x location
        /// </summary>
        /// <value>The target breakpoint x location</value>
        [DataMember(Name="x", EmitDefaultValue=false)]
        public int? X { get; set; }

        /// <summary>
        /// The target breakpoint y location
        /// </summary>
        /// <value>The target breakpoint y location</value>
        [DataMember(Name="y", EmitDefaultValue=false)]
        public int? Y { get; set; }

        /// <summary>
        /// The size of the dashboard item at the current target breakpoint
        /// </summary>
        /// <value>The size of the dashboard item at the current target breakpoint</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public Size Size { get; set; }

        /// <summary>
        /// The alignment details for the dashboard item notes at the current target breakpoint
        /// </summary>
        /// <value>The alignment details for the dashboard item notes at the current target breakpoint</value>
        [DataMember(Name="notesAlignment", EmitDefaultValue=false)]
        public NotesAlignment NotesAlignment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Breakpoint {\n");
            sb.Append("  _Breakpoint: ").Append(_Breakpoint).Append("\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  NotesAlignment: ").Append(NotesAlignment).Append("\n");
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
            return this.Equals(input as Breakpoint);
        }

        /// <summary>
        /// Returns true if Breakpoint instances are equal
        /// </summary>
        /// <param name="input">Instance of Breakpoint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Breakpoint input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Breakpoint == input._Breakpoint ||
                    (this._Breakpoint != null &&
                    this._Breakpoint.Equals(input._Breakpoint))
                ) && 
                (
                    this.X == input.X ||
                    (this.X != null &&
                    this.X.Equals(input.X))
                ) && 
                (
                    this.Y == input.Y ||
                    (this.Y != null &&
                    this.Y.Equals(input.Y))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.NotesAlignment == input.NotesAlignment ||
                    (this.NotesAlignment != null &&
                    this.NotesAlignment.Equals(input.NotesAlignment))
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
                if (this._Breakpoint != null)
                    hashCode = hashCode * 59 + this._Breakpoint.GetHashCode();
                if (this.X != null)
                    hashCode = hashCode * 59 + this.X.GetHashCode();
                if (this.Y != null)
                    hashCode = hashCode * 59 + this.Y.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.NotesAlignment != null)
                    hashCode = hashCode * 59 + this.NotesAlignment.GetHashCode();
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