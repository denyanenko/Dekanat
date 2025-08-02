using System;
using System.Windows.Forms;

namespace Dekanat
{
    public partial class AddDisciplines : Form
    {
        private Student Student{get;set; }
        public AddDisciplines(Student student)
        {
            InitializeComponent();
            Student = student;
        }

        private void AdDisciplines_Load(object sender, EventArgs e)
        {
            ((ListBox)checkedListBox1).DataSource = Student.NotStudentDiscipline;
        }

       

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                new StudyDiscipline(Student, (Discipline)checkedListBox1.CheckedItems[i]);
            }
            Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string txt = txtFind.Text;
            int index = Student.NotStudentDiscipline.FindIndex(x => x.Name == txt);
            if (txt != "")
                if (index != -1)
                {
                    checkedListBox1.SetSelected(index, true);
                }

                else
                    MessageBox.Show("Дисципліну не знайдено");

            else
                MessageBox.Show("Введіть назву дисципліни");
        }
    }
}

