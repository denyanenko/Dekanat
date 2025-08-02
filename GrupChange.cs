using System;
using System.Windows.Forms;

namespace Dekanat
{
    public partial class GrupChange : Form
    {
        private Grupa Grupa { get; set; }
        public GrupChange(Grupa grupa)
        {
            InitializeComponent();
            Grupa = grupa;
        }

        private void GrupChange_Load(object sender, EventArgs e)
        {
            textBox1.Text=Grupa.Name;
            textBox2.Text = Grupa.CursNumber.ToString();
            textBox3.Text = Grupa.CinaNavchannya.ToString();
        }

        

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text!="" && Convert.ToByte(textBox2.Text)>0 && Convert.ToDouble(textBox3.Text)>0)
                Grupa.GrupaModify(textBox1.Text, Convert.ToByte(textBox2.Text), Convert.ToDouble(textBox3.Text));
                else
                    MessageBox.Show("Введено не коректні дані");

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            
            Close();
        }
    }
}
