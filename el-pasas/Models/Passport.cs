/*
 * eDocument API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace el_pasas.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Passport : IEquatable<Passport>
    { 
        /// <summary>
        /// Gets or Sets PassportNo
        /// </summary>
        [DataMember(Name="passportNo")]
        public int? PassportNo { get; set; }

        /// <summary>
        /// Gets or Sets Surname
        /// </summary>
        [DataMember(Name="surname")]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or Sets GivenName
        /// </summary>
        [DataMember(Name="givenName")]
        public string GivenName { get; set; }

        /// <summary>
        /// Gets or Sets Nationality
        /// </summary>
        [DataMember(Name="nationality")]
        public string Nationality { get; set; }

        /// <summary>
        /// Gets or Sets DateOfBirth
        /// </summary>
        [DataMember(Name="dateOfBirth")]
        public string DateOfBirth { get; set; }

        /// <summary>
        /// Gets or Sets Sex
        /// </summary>
        [DataMember(Name="sex")]
        public string Sex { get; set; }

        /// <summary>
        /// Gets or Sets DateOfIssue
        /// </summary>
        [DataMember(Name="dateOfIssue")]
        public string DateOfIssue { get; set; }

        /// <summary>
        /// Gets or Sets DateOfExpiry
        /// </summary>
        [DataMember(Name="dateOfExpiry")]
        public string DateOfExpiry { get; set; }

        /// <summary>
        /// Gets or Sets PersonalNo
        /// </summary>
        [DataMember(Name="personalNo")]
        public int? PersonalNo { get; set; }

        /// <summary>
        /// Gets or Sets PlaceOfBirth
        /// </summary>
        [DataMember(Name="placeOfBirth")]
        public string PlaceOfBirth { get; set; }

        /// <summary>
        /// Gets or Sets Authority
        /// </summary>
        [DataMember(Name="authority")]
        public string Authority { get; set; }

        /// <summary>
        /// Gets or Sets Footer
        /// </summary>
        [DataMember(Name="footer")]
        public string Footer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Passport {\n");
            sb.Append("  PassportNo: ").Append(PassportNo).Append("\n");
            sb.Append("  Surname: ").Append(Surname).Append("\n");
            sb.Append("  GivenName: ").Append(GivenName).Append("\n");
            sb.Append("  Nationality: ").Append(Nationality).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  Sex: ").Append(Sex).Append("\n");
            sb.Append("  DateOfIssue: ").Append(DateOfIssue).Append("\n");
            sb.Append("  DateOfExpiry: ").Append(DateOfExpiry).Append("\n");
            sb.Append("  PersonalNo: ").Append(PersonalNo).Append("\n");
            sb.Append("  PlaceOfBirth: ").Append(PlaceOfBirth).Append("\n");
            sb.Append("  Authority: ").Append(Authority).Append("\n");
            sb.Append("  Footer: ").Append(Footer).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Passport)obj);
        }

        /// <summary>
        /// Returns true if Passport instances are equal
        /// </summary>
        /// <param name="other">Instance of Passport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Passport other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    PassportNo == other.PassportNo ||
                    PassportNo != null &&
                    PassportNo.Equals(other.PassportNo)
                ) && 
                (
                    Surname == other.Surname ||
                    Surname != null &&
                    Surname.Equals(other.Surname)
                ) && 
                (
                    GivenName == other.GivenName ||
                    GivenName != null &&
                    GivenName.Equals(other.GivenName)
                ) && 
                (
                    Nationality == other.Nationality ||
                    Nationality != null &&
                    Nationality.Equals(other.Nationality)
                ) && 
                (
                    DateOfBirth == other.DateOfBirth ||
                    DateOfBirth != null &&
                    DateOfBirth.Equals(other.DateOfBirth)
                ) && 
                (
                    Sex == other.Sex ||
                    Sex != null &&
                    Sex.Equals(other.Sex)
                ) && 
                (
                    DateOfIssue == other.DateOfIssue ||
                    DateOfIssue != null &&
                    DateOfIssue.Equals(other.DateOfIssue)
                ) && 
                (
                    DateOfExpiry == other.DateOfExpiry ||
                    DateOfExpiry != null &&
                    DateOfExpiry.Equals(other.DateOfExpiry)
                ) && 
                (
                    PersonalNo == other.PersonalNo ||
                    PersonalNo != null &&
                    PersonalNo.Equals(other.PersonalNo)
                ) && 
                (
                    PlaceOfBirth == other.PlaceOfBirth ||
                    PlaceOfBirth != null &&
                    PlaceOfBirth.Equals(other.PlaceOfBirth)
                ) && 
                (
                    Authority == other.Authority ||
                    Authority != null &&
                    Authority.Equals(other.Authority)
                ) && 
                (
                    Footer == other.Footer ||
                    Footer != null &&
                    Footer.Equals(other.Footer)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (PassportNo != null)
                    hashCode = hashCode * 59 + PassportNo.GetHashCode();
                    if (Surname != null)
                    hashCode = hashCode * 59 + Surname.GetHashCode();
                    if (GivenName != null)
                    hashCode = hashCode * 59 + GivenName.GetHashCode();
                    if (Nationality != null)
                    hashCode = hashCode * 59 + Nationality.GetHashCode();
                    if (DateOfBirth != null)
                    hashCode = hashCode * 59 + DateOfBirth.GetHashCode();
                    if (Sex != null)
                    hashCode = hashCode * 59 + Sex.GetHashCode();
                    if (DateOfIssue != null)
                    hashCode = hashCode * 59 + DateOfIssue.GetHashCode();
                    if (DateOfExpiry != null)
                    hashCode = hashCode * 59 + DateOfExpiry.GetHashCode();
                    if (PersonalNo != null)
                    hashCode = hashCode * 59 + PersonalNo.GetHashCode();
                    if (PlaceOfBirth != null)
                    hashCode = hashCode * 59 + PlaceOfBirth.GetHashCode();
                    if (Authority != null)
                    hashCode = hashCode * 59 + Authority.GetHashCode();
                    if (Footer != null)
                    hashCode = hashCode * 59 + Footer.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Passport left, Passport right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Passport left, Passport right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}