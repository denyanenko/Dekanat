using System;
using System.Windows.Forms;

namespace Dekanat
{
    public partial class DisciplineForm : Form
    {
        public DisciplineForm()
        {
            InitializeComponent();
        }

        private void DisciplineForm_Load(object sender, EventArgs e)
        {
            RefreshList();
            RefreshTxt();
        }
        private void RefreshTxt()
        {
            if (listBox1.SelectedItem != null)
                txtModify.Text = listBox1.SelectedItem.ToString();
            else
                txtModify.Text = "";
        }
        public void RefreshList()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = Discipline.Items;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                ((Discipline)listBox1.SelectedItem).RemoveDiscipline();
                RefreshList();
            }
            else
                MessageBox.Show("Оберіть дисципліну");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAdd.Text != "")
            {
                new Discipline(txtAdd.Text);
                RefreshList();
                txtAdd.Text = "";
            }
            else
                MessageBox.Show("Введіть назву дисципліни");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Виберіть дисципліну");
            }
            else
            {
                if (txtModify.Text == "")
                    MessageBox.Show("Введіть назву");
                else
                {
                    ((Discipline)listBox1.SelectedItem).Name = txtModify.Text;
                    RefreshList();
                }

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTxt();
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            int find = Discipline.FindDiscipline(textfindd.Text);
            if (textfindd.Text == "")
                MessageBox.Show("Введіть назву дисципліни");
            else if (find == -1)
                MessageBox.Show("Вказана дисципліна не знайдена");
            else
                listBox1.SetSelected(find, true);
        }
    }
}
