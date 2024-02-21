using System;
using System.Windows.Forms;

namespace Авиабилеты
{
    public partial class Form2 : Form
    {
        private string selectedDestination;
        private string destination;

        public Form2(string selectedDestination)
        {
            InitializeComponent();
            destination = selectedDestination;// получаем пункт назначения из 1-ой формы
        }


        

        private void button1_Click(object sender, EventArgs e)
        {
            int adults = (int)numericUpDown1.Value; // получение числа 
            int children = (int)numericUpDown2.Value;// получение числа

           


            if(adults == 0 && children >=1) // проверка на наличие родителя
            {
                MessageBox.Show("Ребёнок не может ехать без родителя!"); // Предупреждение если родитель не указан
            }

            else if (adults == 0 && children == 0) // проверка выбрано ли количество пассажиров 
            {
                MessageBox.Show("Выбирете количество билетов!");// предупреждение если не выбрано ни одного билета
            }
            else
            {
                Form3 form3 = new Form3(destination, adults, children);// передача данных на следующую форму
                form3.Show();
                this.Hide();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
