using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DemoWCF
{
    [DataContract]
    public class Employee
    {
        [DataMember]
        public string Name { get; set; }
        public int Id { get; set; }
    }
}