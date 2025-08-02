using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace Dekanat
{
    [DataContract]
    public class Grupa : Base<Grupa>
    {
        [DataMember]
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (HaveName(value)) { }

                else
                    _name = value;
            }
        }
        public int StudentCount
        {
            get
            {
                return students.Count;
            }
        }
        [DataMember]
        public  double CinaNavchannya { get; set; } = 0;
        [DataMember]
        public byte CursNumber { get; set; } = 1;
        public string Vlastivosty
        {
            get
            {
                return Name + "\r\n" + CursNumber + " курс" + "\r\nКількість студентів:"
                    + StudentCount + "\r\nСтароста:" + (Starosta != null ? Starosta.FullName
                    : "Не назначена") + "\r\nЦіна навчання: " + CinaNavchannya + " грн";
            }
        }
        public Grupa(string name)
        {
            if (HaveName(name))
            {
                Items.Remove(this);
            }
            else
            {
                Name = name;
                Sort();
            }


        }
        public static void Sort()
        {
            Items.Sort((x, y) => x.Name.CompareTo(y.Name));
        }
        
        public void NewCurs()
        {
            CursNumber++;
        }
        public bool HaveName(string name)
        {
            if (Items.Exists(gr => gr.Name == name) && Name != name)
            {
                MessageBox.Show("Група з таким ім'ям уже існує");
                return true;
            }
            else
                return false;
        }
        public List<Student> students
        {
            get
            {
                return Student.Items.FindAll(x => x.grupa == this);
            }
        }
        
        public Student Starosta
        {
            get
            {
                return students.Find(x => x.IsStarosta == true);
            }
        }

        public void ChangeStarosta(Student newstarosta)
        {
            if (Starosta != null)
                Starosta.IsStarosta = false;
            newstarosta.IsStarosta = true;
        }
        public void GrupaModify(string name, byte cursnumber, double cina)
        {
            Name = name;
            CursNumber = cursnumber;
            CinaNavchannya = cina;

            Sort();
        }
        public override string ToString()
        {
            return Name;
        }
        public static int FindGrup(string name)
        {
            return Items.FindIndex(x => x.Name == name);
        }
        public List<Student> FindStudent(string name)
        {
            return students.FindAll(x=>x.FullName==name);
        }
        public void DeleteGrupa()
        {
            DeleteAllStudents();
            Items.Remove(this);
        }
        
        public void DeleteAllStudents()
        {
            for (int i = students.Count-1; i >=0; i--)
            {
                students[i].DeleteStudentFromGrupa();
            }
        }
        
        public void AddDiscipline(List<Discipline> d)
        {
            for(int i=0; i < d.Count; i++)
            {
                for(int j=0; j < students.Count; j++)
                {
                    new StudyDiscipline(students[j], d[i]);
                }
            }
        }
        


    }
}
