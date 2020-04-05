using System.Runtime.Serialization;

namespace el_pasas.Models
{
    [DataContract]
    public class Authorization
    { 
        /// <summary>
        /// userId which is personal number
        /// </summary>
        [DataMember(Name="userId")]
        public string UserId { get; set; }

        /// <summary>
        /// 64 char long token
        /// </summary>
        [DataMember(Name="token")]
        public string Token { get; set; }
    }
}
