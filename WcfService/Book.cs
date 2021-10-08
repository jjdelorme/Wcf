using System;
using System.Runtime.Serialization;

namespace LibraryServiceSolution
{
    [DataContract]
    class Book
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}