using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RestStub.Models
{
    [DataContract]
    public class ResponseInfo
    {
        [DataMember(Name = "data")]
        public string Data { get; set; }

    }
}