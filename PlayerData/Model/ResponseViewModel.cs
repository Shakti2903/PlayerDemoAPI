using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PlayerData.Model
{
    [DataContract]
    public class ResponseViewModel<T>
    {
        [DataMember(Name = "IsSuccess")]
        public bool IsSuccess { get; set; }

        [DataMember(Name = "InfoMessage")]
        public string InfoMessage { get; set; }

        [DataMember(Name = "Data")]
        public T Data { get; set; }
    }

    
}
