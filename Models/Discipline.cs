using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace Dekanat
{
    [DataContract]
    public class Discipline:Base<Discipline>
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
                if (HaveNameDiscipline(value)) { }

                else
                    _name = value;
            }
        }
        public Discipline(string name)
        {
            if (HaveNameDiscipline(name))
            {
                Items.Remove(this);
            }
            else
            {
                Name = name;
                Sort();
            }


        }
        public void ChangeName(string name)
        {
            Name = name;
            Sort();
        }
        public override string ToString()
        {
            return Name;
        }
        public bool HaveNameDiscipline(string name)
        {
            if (Items.Exists(gr => gr.Name == name) && Name != name)
            {
                MessageBox.Show("Дисципліна з таким ім'ям уже існує");
                return true;
            }
            else
                return false;
        }
        public static void Sort()
        {
            Items.Sort((x, y) => x.Name.CompareTo(y.Name));
        }
        public List<StudyDiscipline> StudyDisciplines
        {
            get
            {
                return StudyDiscipline.Items.FindAll(x => x.Discipline == this);
            }
        }
        public List<Student> Students
        {
            get
            {
                return StudyDiscipline.Items.FindAll(x => x.Discipline == this).Select(d => d.Student).ToList();
            }
        }
        public void RemoveDiscipline ()
        {
            Items.Remove(this);
        }
        public static int FindDiscipline(string name)
        {
            return Items.FindIndex(x => x.Name == name);
        }

    }

}
