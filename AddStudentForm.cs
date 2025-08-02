using System;
using System.Windows.Forms;

namespace Dekanat
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtFirst.Text != "" && txtLast.Text != "" && txtPatronymic.Text != "" && dateBirthday.Value != null)
            {
                new Student(txtLast.Text, txtFirst.Text, txtPatronymic.Text) { Birtday = dateBirthday.Value,Email=txtEmail.Text,PhoneNumber=txtPhone.Text,NomerStudentskogo=txtStudentske.Text, PayForStudying=checkKontrakt.Checked};
                Close();
            }
            else
                MessageBox.Show("Заповніть обов'язкові поля");
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
