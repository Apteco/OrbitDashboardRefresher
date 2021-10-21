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
    /// Visualisation
    /// </summary>
    [DataContract]
    public partial class Visualisation :  IEquatable<Visualisation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Visualisation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Visualisation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Visualisation" /> class.
        /// </summary>
        /// <param name="titleColour">The hex colour to use when displaying a title (required).</param>
        /// <param name="titleFont">The font to use when displaying a title.</param>
        /// <param name="noteColour">The hex colour to use when displaying a description (required).</param>
        /// <param name="noteFont">The font to use when displaying a note.</param>
        /// <param name="labelColour">The hex colour to use when displaying a label (required).</param>
        /// <param name="visualisationColours">The hex colour(s) to use when displaying a visualisation (required).</param>
        /// <param name="highlightColours">The hex colour(s) to use when displaying a highlight (required).</param>
        public Visualisation(string titleColour = default(string), string titleFont = default(string), string noteColour = default(string), string noteFont = default(string), string labelColour = default(string), List<string> visualisationColours = default(List<string>), List<string> highlightColours = default(List<string>))
        {
            // to ensure "titleColour" is required (not null)
            if (titleColour == null)
            {
                throw new InvalidDataException("titleColour is a required property for Visualisation and cannot be null");
            }
            else
            {
                this.TitleColour = titleColour;
            }
            // to ensure "noteColour" is required (not null)
            if (noteColour == null)
            {
                throw new InvalidDataException("noteColour is a required property for Visualisation and cannot be null");
            }
            else
            {
                this.NoteColour = noteColour;
            }
            // to ensure "labelColour" is required (not null)
            if (labelColour == null)
            {
                throw new InvalidDataException("labelColour is a required property for Visualisation and cannot be null");
            }
            else
            {
                this.LabelColour = labelColour;
            }
            // to ensure "visualisationColours" is required (not null)
            if (visualisationColours == null)
            {
                throw new InvalidDataException("visualisationColours is a required property for Visualisation and cannot be null");
            }
            else
            {
                this.VisualisationColours = visualisationColours;
            }
            // to ensure "highlightColours" is required (not null)
            if (highlightColours == null)
            {
                throw new InvalidDataException("highlightColours is a required property for Visualisation and cannot be null");
            }
            else
            {
                this.HighlightColours = highlightColours;
            }
            this.TitleFont = titleFont;
            this.NoteFont = noteFont;
        }
        
        /// <summary>
        /// The hex colour to use when displaying a title
        /// </summary>
        /// <value>The hex colour to use when displaying a title</value>
        [DataMember(Name="titleColour", EmitDefaultValue=false)]
        public string TitleColour { get; set; }

        /// <summary>
        /// The font to use when displaying a title
        /// </summary>
        /// <value>The font to use when displaying a title</value>
        [DataMember(Name="titleFont", EmitDefaultValue=false)]
        public string TitleFont { get; set; }

        /// <summary>
        /// The hex colour to use when displaying a description
        /// </summary>
        /// <value>The hex colour to use when displaying a description</value>
        [DataMember(Name="noteColour", EmitDefaultValue=false)]
        public string NoteColour { get; set; }

        /// <summary>
        /// The font to use when displaying a note
        /// </summary>
        /// <value>The font to use when displaying a note</value>
        [DataMember(Name="noteFont", EmitDefaultValue=false)]
        public string NoteFont { get; set; }

        /// <summary>
        /// The hex colour to use when displaying a label
        /// </summary>
        /// <value>The hex colour to use when displaying a label</value>
        [DataMember(Name="labelColour", EmitDefaultValue=false)]
        public string LabelColour { get; set; }

        /// <summary>
        /// The hex colour(s) to use when displaying a visualisation
        /// </summary>
        /// <value>The hex colour(s) to use when displaying a visualisation</value>
        [DataMember(Name="visualisationColours", EmitDefaultValue=false)]
        public List<string> VisualisationColours { get; set; }

        /// <summary>
        /// The hex colour(s) to use when displaying a highlight
        /// </summary>
        /// <value>The hex colour(s) to use when displaying a highlight</value>
        [DataMember(Name="highlightColours", EmitDefaultValue=false)]
        public List<string> HighlightColours { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Visualisation {\n");
            sb.Append("  TitleColour: ").Append(TitleColour).Append("\n");
            sb.Append("  TitleFont: ").Append(TitleFont).Append("\n");
            sb.Append("  NoteColour: ").Append(NoteColour).Append("\n");
            sb.Append("  NoteFont: ").Append(NoteFont).Append("\n");
            sb.Append("  LabelColour: ").Append(LabelColour).Append("\n");
            sb.Append("  VisualisationColours: ").Append(VisualisationColours).Append("\n");
            sb.Append("  HighlightColours: ").Append(HighlightColours).Append("\n");
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
            return this.Equals(input as Visualisation);
        }

        /// <summary>
        /// Returns true if Visualisation instances are equal
        /// </summary>
        /// <param name="input">Instance of Visualisation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Visualisation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TitleColour == input.TitleColour ||
                    (this.TitleColour != null &&
                    this.TitleColour.Equals(input.TitleColour))
                ) && 
                (
                    this.TitleFont == input.TitleFont ||
                    (this.TitleFont != null &&
                    this.TitleFont.Equals(input.TitleFont))
                ) && 
                (
                    this.NoteColour == input.NoteColour ||
                    (this.NoteColour != null &&
                    this.NoteColour.Equals(input.NoteColour))
                ) && 
                (
                    this.NoteFont == input.NoteFont ||
                    (this.NoteFont != null &&
                    this.NoteFont.Equals(input.NoteFont))
                ) && 
                (
                    this.LabelColour == input.LabelColour ||
                    (this.LabelColour != null &&
                    this.LabelColour.Equals(input.LabelColour))
                ) && 
                (
                    this.VisualisationColours == input.VisualisationColours ||
                    this.VisualisationColours != null &&
                    this.VisualisationColours.SequenceEqual(input.VisualisationColours)
                ) && 
                (
                    this.HighlightColours == input.HighlightColours ||
                    this.HighlightColours != null &&
                    this.HighlightColours.SequenceEqual(input.HighlightColours)
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
                if (this.TitleColour != null)
                    hashCode = hashCode * 59 + this.TitleColour.GetHashCode();
                if (this.TitleFont != null)
                    hashCode = hashCode * 59 + this.TitleFont.GetHashCode();
                if (this.NoteColour != null)
                    hashCode = hashCode * 59 + this.NoteColour.GetHashCode();
                if (this.NoteFont != null)
                    hashCode = hashCode * 59 + this.NoteFont.GetHashCode();
                if (this.LabelColour != null)
                    hashCode = hashCode * 59 + this.LabelColour.GetHashCode();
                if (this.VisualisationColours != null)
                    hashCode = hashCode * 59 + this.VisualisationColours.GetHashCode();
                if (this.HighlightColours != null)
                    hashCode = hashCode * 59 + this.HighlightColours.GetHashCode();
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