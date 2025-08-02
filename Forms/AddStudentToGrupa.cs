using System;
using System.Windows.Forms;

namespace Dekanat
{
    public partial class AddStudentToGrupa : Form
    {
        private Grupa Grupa{get;set;}
        public AddStudentToGrupa(Grupa grupa)
        {
            InitializeComponent();
            Grupa = grupa;
        }

        private void StudentWithoutGrupa_Load(object sender, EventArgs e)
        {
            ((ListBox)checkedListBox1).DataSource = Student.StudentsWhitoutGrupa;
        }
        private void RefreshText()
        {
            var st = (Student)lstFind.SelectedItem;
            if (lstFind.SelectedItem != null)
                txtVlastivosty.Text = st.Vlastivosti;
            else
                txtVlastivosty.Text = "";
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            for(int i=0; i<checkedListBox1.CheckedItems.Count; i++)
            {
                ((Student)checkedListBox1.CheckedItems[i]).grupa=Grupa;
            }
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = txtFind.Text;
            var students=Student.StudentsWhitoutGrupa;
            if (txt != "")
                if (students.Count != 0)
                    lstFind.DataSource = students.FindAll(x=>x.FullName==txt);
                else
                    MessageBox.Show("Студента не знайдено");

            else
                MessageBox.Show("Введіть повне ім'я студента");
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox1.SetSelected(Student.StudentsWhitoutGrupa.FindIndex(x => x.Id == ((Student)lstFind.SelectedItem).Id), true);
            RefreshText();
        }
    }
}
