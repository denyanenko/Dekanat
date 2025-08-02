using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Dekanat
{
    [DataContract]
    public class People<T> : Base<T> where T : People<T>
    {
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Patronymic { get; set; }
        [DataMember]
        public DateTime Birtday { get; set; }
        public string FullName
        {
            get
            {
                return LastName + " " + FirstName + " " + Patronymic;
            }
        }
        public People(string lastname, string firstname, string patronymic)
        {
            LastName = lastname;
            FirstName = firstname;
            Patronymic = patronymic;
            Sort();

        }
        public static void Sort()
        {
            Items.Sort((x, y) => x.FullName.CompareTo(y.FullName));
        }

        public int GetAge()
        {
            return DateTime.Now.Year - Birtday.Year - (Birtday.DayOfYear <= DateTime.Now.DayOfYear ? 0 : 1);

        }
        public override string ToString()
        {
            return FullName;
        }

    }
}
