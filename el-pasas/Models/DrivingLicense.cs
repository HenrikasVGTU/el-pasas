using System.Collections.Generic;
using System.Runtime.Serialization;

namespace el_pasas.Models
{
    [DataContract]
    public class DrivingLicense
    { 
        /// <summary>
        /// Gets or Sets _1Surname
        /// </summary>
        [DataMember(Name="1_surname")]
        public string _1Surname { get; set; }

        /// <summary>
        /// Gets or Sets _2Name
        /// </summary>
        [DataMember(Name="2_name")]
        public string _2Name { get; set; }

        /// <summary>
        /// Gets or Sets _3DateOfBirth
        /// </summary>
        [DataMember(Name="3_dateOfBirth")]
        public string _3DateOfBirth { get; set; }

        /// <summary>
        /// Gets or Sets _4aDateOfIssue
        /// </summary>
        [DataMember(Name="4a_dateOfIssue")]
        public string _4aDateOfIssue { get; set; }

        /// <summary>
        /// Gets or Sets _4bDateOfExpiry
        /// </summary>
        [DataMember(Name="4b_dateOfExpiry")]
        public string _4bDateOfExpiry { get; set; }

        /// <summary>
        /// Gets or Sets _4cIssuedBy
        /// </summary>
        [DataMember(Name="4c_issuedBy")]
        public string _4cIssuedBy { get; set; }

        /// <summary>
        /// Gets or Sets _4dPersonalNo
        /// </summary>
        [DataMember(Name="4d_personalNo")]
        public long? _4dPersonalNo { get; set; }

        /// <summary>
        /// Gets or Sets _5LicenseNo
        /// </summary>
        [DataMember(Name="5_licenseNo")]
        public long? _5LicenseNo { get; set; }

        /// <summary>
        /// Gets or Sets Categories
        /// </summary>
        [DataMember(Name="categories")]
        public IEnumerable<Category> Categories { get; set; }
    }
}
