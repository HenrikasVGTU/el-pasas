using System.Runtime.Serialization;

namespace el_pasas.Models
{
    [DataContract]
    public class StudentIdentityCard
    { 
        /// <summary>
        /// Gets or Sets StudentId
        /// </summary>
        [DataMember(Name="studentId")]
        public string StudentId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Surname
        /// </summary>
        [DataMember(Name="surname")]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or Sets PersonalNo
        /// </summary>
        [DataMember(Name="personalNo")]
        public long? PersonalNo { get; set; }

        /// <summary>
        /// Gets or Sets StudiesAt
        /// </summary>
        [DataMember(Name="studiesAt")]
        public string StudiesAt { get; set; }

        /// <summary>
        /// Gets or Sets ValidFrom
        /// </summary>
        [DataMember(Name="validFrom")]
        public string ValidFrom { get; set; }

        /// <summary>
        /// Gets or Sets ValidUntil
        /// </summary>
        [DataMember(Name="validUntil")]
        public string ValidUntil { get; set; }

        /// <summary>
        /// Gets or Sets Spd
        /// </summary>
        [DataMember(Name="spd")]
        public long? Spd { get; set; }

        /// <summary>
        /// Gets or Sets Barcode
        /// </summary>
        [DataMember(Name="barcode")]
        public string Barcode { get; set; }
    }
}
