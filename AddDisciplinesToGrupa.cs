using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Dekanat
{
    public partial class AddDisciplinesToGrupa : Form
    {
        private Grupa Grupa { get; set; }
        public AddDisciplinesToGrupa(Grupa grupa)
        {
            InitializeComponent();
            Grupa = grupa;
        }

        private void AddDisciplinesToGrupa_Load(object sender, EventArgs e)
        {
            ((ListBox)checkedListBox1).DataSource = Discipline.Items;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            List<Discipline> d = new List<Discipline>();
            foreach (var item in checkedListBox1.CheckedItems)
                d.Add((Discipline)item);
            Grupa.AddDiscipline(d);

            Close();
        }

        private void btnFind_Click_1(object sender, EventArgs e)
        {

            string txt = txtFind.Text;
            int index = Discipline.Items.FindIndex(x => x.Name == txt);
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
