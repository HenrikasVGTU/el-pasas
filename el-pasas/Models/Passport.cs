using System.Runtime.Serialization;

namespace el_pasas.Models
{
    [DataContract]
    public class Passport
    { 
        /// <summary>
        /// Gets or Sets PassportNo
        /// </summary>
        [DataMember(Name="passportNo")]
        public long? PassportNo { get; set; }

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
        public long? PersonalNo { get; set; }

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
    }
}
