using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Dekanat
{
    [DataContract]
    public class Base<T> where T : Base<T>
    {
        public static List<T> Items = new List< T>();

        [DataMember]
        public Guid Id { get; private set; }

        public Base()
        {
            Id = Guid.NewGuid();
            Items.Add((T)this);
        }
        
    }
}
