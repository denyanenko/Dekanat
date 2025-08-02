using System;
using System.Runtime.Serialization;

namespace Dekanat
{
    [DataContract]
    public class StudyDiscipline : Base<StudyDiscipline>
    {
        public StudyDiscipline(Student s, Discipline d)
        {

            if (HaveStudyDiscipline(s, d))
            {
                Items.Remove(this);
            }
            else
                Student = s; Discipline = d;

        }
        public bool HaveStudyDiscipline(Student s, Discipline d)
        {
            if (Items.Exists(st => st.Student == s && st.Discipline == d))
            {
                return true;
            }
            else
                return false;
        }
        [DataMember]
        private Guid _studentId;
        public Student Student
        {
            get { return Student.Items.Find(x => x.Id == _studentId); }
            set { _studentId = value.Id; }
        }
        [DataMember]
        private Guid _disciplineId;
        public Discipline Discipline
        {
            get { return Discipline.Items.Find(x => x.Id == _disciplineId); }
            set { _disciplineId = value.Id; }
        }
        public override bool Equals(object std)
        {
            if (Student == ((StudyDiscipline)std).Student && Discipline == ((StudyDiscipline)std).Discipline)
                return true;
            else return false;

        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public void DeleteStudyDiscipline()
        {
            Items.Remove(this);
        }
    }
}
