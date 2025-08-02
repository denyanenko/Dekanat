using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Dekanat
{
    [DataContract]
    public class Student : People<Student>
    {
        [DataMember]
        public bool IsStarosta { get; set; }= false;
        [DataMember]
        public string PhoneNumber { get; set; } = "";
        [DataMember]
        public string Email { get; set; } = "";
        [DataMember]
        public string NomerStudentskogo { get; set; } = "";
        [DataMember]
        public bool PayForStudying { get; set; } = false;

        public string Vlastivosti
        {
            get {
                return this + "\r\nДата народження:" + Birtday.Day + "."
                    + Birtday.Month + "." + Birtday.Year + "\r\n" + GetAge() + " років\r\nНомер студедентського: "
                    + NomerStudentskogo + "\r\nEmail: " + Email + "\r\nНомер телефону: "
                    + PhoneNumber + "\r\nФорма навчання: "
                    + (PayForStudying ? "Контракт\r\n"
                    + (grupa != null ? "Ціна навчання:"
                    + grupa.CinaNavchannya + " грн" : "") : "Бюджет")
                    + (grupa != null ? "\r\nГрупа: " + grupa.ToString() : "") + (grupa != null ? "\r\n" + grupa.CursNumber + " курс":"")
                  ; }
        }
        public Student(string lastname, string firstname, string patronymic)
            : base(lastname, firstname, patronymic){}
        [DataMember]
        private Guid _GrupId;
        public Grupa grupa
        {
            get { return Grupa.Items.Find(x=>x.Id== _GrupId); }
            set { _GrupId = value.Id; }
        }
        public List<StudyDiscipline> StudyDisciplines
        {
            get
            {
                return StudyDiscipline.Items.FindAll(x => x.Student == this);
            }
        }

        public List<Discipline> Disciplines
        {
            get
            {
              
                return StudyDiscipline.Items.FindAll(x => x.Student == this).Select(x => x.Discipline).ToList();
            }
        }
        public static List<Student> StudentsWhitoutGrupa
        {
            get
            {
                return Items.FindAll(x => x.grupa == null);
            }
        }
        public override string ToString()
        {
            return base.ToString()+(IsStarosta ?" (Староста)":"");
        }
        public void DeleteStudentFromGrupa()
        {
            IsStarosta = false;
            _GrupId= Guid.Empty;
        }
        public void DeleteStudent()
        {
           Items.Remove(this);
        }
        public List<Discipline> NotStudentDiscipline
        {
            get
            {
                return Discipline.Items.FindAll(d => d.Students.Contains(this)==false);
            }
        }
        public void RemoweDiscipline(Discipline d)
        {
            StudyDisciplines.Find(x => x.Discipline == d).DeleteStudyDiscipline();
        }
        public static List<Student>  FindStudent(string fullname)
        {
            return Items.FindAll(x=>x.FullName==fullname);
        }

    }
}
