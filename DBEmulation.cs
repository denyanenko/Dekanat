using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Dekanat
{
    public class DBEmulation
    {
        public List<Student> Students = new List<Student>();
        public List<Grupa> Grupas = new List<Grupa>();
        public List<Discipline> Disciplines = new List<Discipline>();
        public List<StudyDiscipline> StudyDisciplines = new List<StudyDiscipline>();
        public static DBEmulation Load()
        {
            DataContractSerializer dcs = new DataContractSerializer(typeof(DBEmulation));
            XmlReader xmlr = XmlReader.Create("DBEmulation.xml");
            DBEmulation res = (DBEmulation)dcs.ReadObject(xmlr);
            xmlr.Close();
            return res;
        }

        public void Save()
        {
            DataContractSerializer dcs = new DataContractSerializer(typeof(DBEmulation));
            XmlWriter xmlw = XmlWriter.Create("DBEmulation.xml");
            dcs.WriteObject(xmlw, this);
            xmlw.Close();
        }
    }
}
