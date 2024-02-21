using System;
using System.Windows.Forms;

namespace Авиабилеты
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {              
                // добавляем пункт назанчения в количестве 4-х
                comboBox1.Items.Add("Москва"); 
                comboBox1.Items.Add("Адлер");
                comboBox1.Items.Add("Томск");
                comboBox1.Items.Add("Астрахань");        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedDestination = comboBox1.SelectedItem.ToString();
                Form2 form2 = new Form2(selectedDestination);//передаём выбор пассижира
                form2.Show();
                this.Hide();
            }

            catch
            {
                MessageBox.Show("Выберете пункт назначения");// предупреждение если пользователь ничего не выбрал 
            }
        }
    }
}
