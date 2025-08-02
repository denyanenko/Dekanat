using System;
using System.Windows.Forms;

namespace Dekanat
{
    public partial class StudentModify : Form
    {
        private Student Student { get; set; }
        public StudentModify(Student student)
        {
            InitializeComponent();
            Student = student;
            comboBox1.DataSource = Grupa.Items;
            if (Student.grupa != null)
                comboBox1.SelectedIndex = Grupa.Items.FindIndex(x => x == Student.grupa);
            else comboBox1.SelectedItem = null;
        }

        private void StudentModify_Load(object sender, EventArgs e)
        {
            txtFirst.Text = Student.FirstName;
            txtLast.Text = Student.LastName;
            txtPatronymic.Text = Student.Patronymic;
            dateBirthday.Value = Student.Birtday;
            txtPhone.Text = Student.PhoneNumber;
            txtEmail.Text = Student.Email;
            txtStudentske.Text = Student.NomerStudentskogo;
            checkKontrakt.Checked=Student.PayForStudying ;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtFirst.Text != "" && txtLast.Text != "" && txtLast.Text != "" && dateBirthday.Value != null)
            {
                Student.FirstName = txtFirst.Text;
                Student.LastName = txtLast.Text;
                Student.Patronymic = txtPatronymic.Text;
                Student.Email = txtEmail.Text;
                Student.Birtday = dateBirthday.Value;
                Student.PhoneNumber = txtPhone.Text;
                Student.PayForStudying = checkKontrakt.Checked;
                if (comboBox1.SelectedItem != null)
                    Student.grupa = (Grupa)comboBox1.SelectedItem;
                Student.Sort();
                Close();
            }
            else
                MessageBox.Show("Заповніть обов'язкові поля");
        }
    }
}
