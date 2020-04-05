using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace el_pasas.Models
{
    [DataContract]
    public class Category
    {
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NameEnum
        {
            
            /// <summary>
            /// Enum AMEnum for AM
            /// </summary>
            [EnumMember(Value = "AM")]
            AMEnum = 1,
            
            /// <summary>
            /// Enum A1Enum for A1
            /// </summary>
            [EnumMember(Value = "A1")]
            A1Enum = 2,
            
            /// <summary>
            /// Enum B1Enum for B1
            /// </summary>
            [EnumMember(Value = "B1")]
            B1Enum = 3,
            
            /// <summary>
            /// Enum BEnum for B
            /// </summary>
            [EnumMember(Value = "B")]
            BEnum = 4,
            
            /// <summary>
            /// Enum D1Enum for D1
            /// </summary>
            [EnumMember(Value = "D1")]
            D1Enum = 5,
            
            /// <summary>
            /// Enum DEnum for D
            /// </summary>
            [EnumMember(Value = "D")]
            DEnum = 6,
            
            /// <summary>
            /// Enum BEEnum for BE
            /// </summary>
            [EnumMember(Value = "BE")]
            BEEnum = 7,
            
            /// <summary>
            /// Enum D1EEnum for D1E
            /// </summary>
            [EnumMember(Value = "D1E")]
            D1EEnum = 8,
            
            /// <summary>
            /// Enum DEEnum for DE
            /// </summary>
            [EnumMember(Value = "DE")]
            DEEnum = 9
        }

        /// <summary>
        /// Gets or Sets _9Name
        /// </summary>
        [DataMember(Name="9_name")]
        public NameEnum? _9Name { get; set; }

        /// <summary>
        /// Gets or Sets _10DateOfIssue
        /// </summary>
        [DataMember(Name="10_dateOfIssue")]
        public string _10DateOfIssue { get; set; }

        /// <summary>
        /// Gets or Sets _11DateOfExpiry
        /// </summary>
        [DataMember(Name="11_dateOfExpiry")]
        public string _11DateOfExpiry { get; set; }

        /// <summary>
        /// Gets or Sets _12Code
        /// </summary>
        [DataMember(Name="12_code")]
        public string _12Code { get; set; }
    }
}
