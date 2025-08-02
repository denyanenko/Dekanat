using System;
using System.Windows.Forms;

namespace Dekanat
{
    public partial class Dekanat : Form
    {
       
        public Dekanat()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            new GrupForm().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new StudentForm().ShowDialog();
        }

        private void Dekanat_Load(object sender, EventArgs e)
        {
            //Для тестування:
            Student.Items = DBEmulation.Load().Students;
            Grupa.Items= DBEmulation.Load().Grupas;
            Discipline.Items= DBEmulation.Load().Disciplines;
            StudyDiscipline.Items= DBEmulation.Load().StudyDisciplines;
            //Для тестування;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            new DisciplineForm().ShowDialog();
        }

        private void Dekanat_FormClosed(object sender, FormClosedEventArgs e)
        {
            new DBEmulation() { Students = Student.Items, Grupas=Grupa.Items, 
                Disciplines=Discipline.Items, StudyDisciplines=StudyDiscipline.Items }.Save();

        }
    }
}
