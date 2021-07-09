using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace RestTECService
{
    [DataContract]
    public class Order
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }
        [DataMember(Name = "assignTo")]
        public string AssignTo { get; set; }
        [DataMember(Name = "estimatedTime")]
        public int EstimatedTime { get; set; }
    }
}
