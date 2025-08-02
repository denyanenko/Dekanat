using System;
using System.Windows.Forms;

namespace Dekanat
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddStudentForm().ShowDialog();
            RefreshList();
        }
        private void RefreshList() {
            lstStudents.DataSource = null;
            lstStudents.DataSource = Student.Items;
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            RefreshList();
            RefreshText();

        }
        private void RefreshText()
        {
            var st = (Student)lstStudents.SelectedItem;
            if (lstStudents.SelectedItem != null)
                txtVlastivosty.Text = st.Vlastivosti;
            else
                txtVlastivosty.Text = "";
        }
        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshText();
            RefreshDiscipline();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedItem != null)
            {
                ((Student)lstStudents.SelectedItem).DeleteStudent();
                RefreshList();
            }
            else
                MessageBox.Show("Виберіть студента");
        }

        private void btnAddDiscipline_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedItem != null)
                new AddDisciplines((Student)lstStudents.SelectedItem).ShowDialog();
            else
                MessageBox.Show("Виберіть студента");
            RefreshDiscipline();
        }
        private void RefreshDiscipline()
        {

            if (lstStudents.SelectedItem != null)
            {
                lstDiscipline.DataSource = null;
                lstDiscipline.DataSource = ((Student)lstStudents.SelectedItem).Disciplines;
            }
            else
                lstDiscipline.DataSource = null;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = txtFind.Text;
            var students = Student.FindStudent(txt);
            if (txt != "")
                if (students.Count != 0)
                    lstFind.DataSource = students;
                else
                    MessageBox.Show("Студента не знайдено");

            else
                MessageBox.Show("Введіть повне ім'я студента");
        }

        private void lstFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstStudents.SetSelected(Student.Items.FindIndex(x => x.Id == ((Student)lstFind.SelectedItem).Id), true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedItem != null)
            {
                new StudentModify((Student)lstStudents.SelectedItem).ShowDialog();
                Refresh();
                RefreshText();
                RefreshList();
               
            }
            else
                MessageBox.Show("Виберіть студента");
           
        }

        private void btnDelDiscipline_Click(object sender, EventArgs e)
        {
            for (int i = lstDiscipline.SelectedItems.Count - 1; i >= 0; i--)
            {
                ((Student)lstStudents.SelectedItem).RemoweDiscipline((Discipline)lstDiscipline.SelectedItems[i]);
            }
            RefreshDiscipline();
        }
    }
}
