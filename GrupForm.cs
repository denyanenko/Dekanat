using System;
using System.Windows.Forms;


namespace Dekanat
{
    public partial class GrupForm : Form
    {
        public GrupForm()
        {
            InitializeComponent();
        }
        public void RefreshListGrup()
        {
            gruplst.DataSource = null;
            gruplst.DataSource = Grupa.Items;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
            RefreshListGrup();
 }

        private void gruplst_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGruptxt();
        }
        public void RefreshGruptxt()
        {
            if (gruplst.SelectedItem != null)
                txtGroup.Text = ((Grupa)gruplst.SelectedItem).Vlastivosty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int find= Grupa.FindGrup(textfindg.Text);
            if (textfindg.Text == "")
                MessageBox.Show("Введіть назву групи");
            else if (find == -1)
                MessageBox.Show("Вказана група не знайдена");
            else 
                gruplst.SetSelected(find,true);
        }

        

        private void btnnew_Click_1(object sender, EventArgs e)
        {
            if (textnew.Text == "")
                MessageBox.Show("Введіть назву групи");
            else
            {
                new Grupa(textnew.Text);
                
            }
            RefreshListGrup();

        }

        private void btnCursUp_Click(object sender, EventArgs e)
        {
            if(gruplst.SelectedItem==null)
            {
                MessageBox.Show("Виберіть групу");
    
            }
            else
            {
                ((Grupa)gruplst.SelectedItem).NewCurs();
                RefreshGruptxt();
            }

        }

        private void btndelgrup_Click(object sender, EventArgs e)
        {
            if (gruplst.SelectedItem == null)
            {
                MessageBox.Show("Виберіть групу");
            }
            else
            {
                ((Grupa)gruplst.SelectedItem).DeleteGrupa();
                RefreshListGrup();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (gruplst.SelectedItem == null)
            {
                MessageBox.Show("Виберіть групу");
            }
            else
            {
                new GrupChange(((Grupa)gruplst.SelectedItem)).ShowDialog();
                RefreshListGrup();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gruplst.SelectedItem == null)
            {
                MessageBox.Show("Виберіть групу");
            }
            else
            {
                new StudentsGrupForm(((Grupa)gruplst.SelectedItem)).ShowDialog();
                RefreshListGrup();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (gruplst.SelectedItem == null)
            {
                MessageBox.Show("Виберіть групу");
            }
            else
            {
                new AddDisciplinesToGrupa((Grupa)gruplst.SelectedItem).ShowDialog();
            }

        }

        private void textfindg_TextChanged(object sender, EventArgs e)
        {

        }
    }

        
    
}
