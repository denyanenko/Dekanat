using System;
using System.Windows.Forms;

namespace Dekanat
{
    public partial class StudentsGrupForm : Form
    {
        private Grupa Grupa { get; set; }
        public StudentsGrupForm(Grupa grupa)
        {
            InitializeComponent();
            Grupa = grupa;
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            RefreshList();
            label1.Text = "Список студентів групи " + Grupa;
        }
        private void RefreshList()
        {
            lstStudents.DataSource = null;
            lstStudents.DataSource = Grupa.students;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AddStudentToGrupa(Grupa).ShowDialog();
            RefreshList();

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedItem != null)
            {
                ((Student)lstStudents.SelectedItem).DeleteStudentFromGrupa();
                RefreshList();
            }
            else
                MessageBox.Show("Студента не вибрано");

        }

        private void brnStarosta_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedItem != null)
            {
                int index = lstStudents.SelectedIndex;
                Grupa.ChangeStarosta(((Student)lstStudents.SelectedItem));
                RefreshList();
                lstStudents.SetSelected(index, true);
            }
            else
                MessageBox.Show("Студента не вибрано");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string txt = txtFind.Text;
            var students = Grupa.FindStudent(txt);
            if (txt != "")
                if (students.Count != 0)
                    lstFind.DataSource = students;
                else
                    MessageBox.Show("Студента не знайдено");

            else
                MessageBox.Show("Введіть повне ім'я студента");
        }

        private void txtVlastivosty_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshText();
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
        private void RefreshText()
        {
            var st = (Student)lstStudents.SelectedItem;
            if (lstStudents.SelectedItem != null)
                txtVlastivosty.Text = st.Vlastivosti;
            else
                txtVlastivosty.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Grupa.DeleteAllStudents();
            RefreshList();
            txtVlastivosty.Text = "";
        }

        private void btnAddDiscipline_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedItem != null)
                new AddDisciplines((Student)lstStudents.SelectedItem).ShowDialog();
            else
                MessageBox.Show("Виберіть студента");
            RefreshDiscipline();

        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lstStudents.SetSelected(Grupa.students.FindIndex(x => x.Id == ((Student)lstFind.SelectedItem).Id), true);
        }

        private void btnDelDiscipline_Click(object sender, EventArgs e)
        {
            if (lstDiscipline.SelectedItem == null)
            {
                MessageBox.Show("Виберіть дисципліну");
            }
            else
            {
                for (int i = lstDiscipline.SelectedItems.Count - 1; i >= 0; i--)
                {
                    ((Student)lstStudents.SelectedItem).RemoweDiscipline((Discipline)lstDiscipline.SelectedItems[i]);
                }
                RefreshDiscipline();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedItem != null)
                new StudentModify((Student)lstStudents.SelectedItem).ShowDialog();
            else
                MessageBox.Show("Виберіть студента");
            RefreshList();
            RefreshText();

        }
    }
}
