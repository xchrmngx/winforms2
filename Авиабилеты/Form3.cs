using System;
using System.Collections.Generic;
using System.Windows.Forms;



namespace Авиабилеты
{
    public partial class Form3 : Form
    {
        private string destination;
        string  dateNow;      
        int price = 2500; //цена
        private int adults;
        private int children; 
        private int sum;
        int countPass = 0; // количество мест

        private List<Passenger> list = new List<Passenger>(); // список "пассажир"
        private List<Ticket> list2 = new List<Ticket>(); // список "Билет"

        public Form3(string destination, int adults, int children)
        {
            InitializeComponent();       
            Ticket ticket = new Ticket();
            this.destination = destination;
            this.adults = adults;
            this.children = children;          
            int sum = adults + children; // подсчёт сколько мест выбрано         
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dateNow = Convert.ToString(DateTime.Now); // сегодняшняя дата
                Passenger pass = new Passenger((textBox1.Text, textBox2.Text, dateTimePicker1.Value, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text)));
                list.Add(pass);// добавляем класс в список
                
                // блок получения данных
                string Fio = pass.fio = Convert.ToString(textBox1.Text);
                string Name = pass.name = textBox2.Text;
                DateTime date = pass.dateOfBirth = dateTimePicker1.Value;
                int passS = pass.passportSeries = Convert.ToInt32(textBox3.Text);
                int passN = pass.passportNumber = Convert.ToInt32(textBox4.Text);

                DateTime datN = DateTime.Parse("2021-10-05");//дети до 2-х лет
                DateTime datS = DateTime.Parse("2011-10-05");//дети до 12-ти лет

                //блок расчёта стоимости билета, исходя из возраста пассажира
                if (date > datN) { price = 0; }// дети до 2-х лет - бесплатно
                else if (date > datS) { price = price/2; } // дети до 12-ти лет цена на 50% меньше
                else { price = 2500; }// полная цена для людей старше 12-ти лет
                

                sum = adults + children;
                Ticket(); 
                listBox1.Items.Add($"Фамилия: {list[countPass].Fio()} Имя:{list[countPass].Name()} Дата рождения: {list[countPass].dateOfbirth()} Данные паспорта: Серия: {list[countPass].PasS()} Номер: {list[countPass].passN()}");//вывод на форму данных пассажира
               
                if (listBox1.Items.Count == sum)
                {
                    button1.Enabled = false;//блокировка кнопки после того, как достигнуто выбранное количество пассажиров
                    button3.Enabled = true;//разблокировка кнопки после ввода всех пассажиров
                }

                if (listBox1.Items.Count < sum)
                {
                    button3.Enabled = false;//блокировка кнопки далее до того, пока не будут добавлены все пассажиры
                }
                //очистка TextBox'ов после добавления пассажира
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            catch
            {
               MessageBox.Show("Данные введены неправильно!");// работает если в серию и номер записываются цифры 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Введите данные пассажира");
            }
            else
            {
                Form4 form4 = new Form4(list, list2, sum);// передача данных на следующую форму
                form4.Show();
                this.Hide();                         
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                if (listBox1.SelectedItem != null)
                {
                    int selectedIndex = listBox1.SelectedIndex;

                    // Открываем TextBox для редактирования
                    textBox1.Text = listBox1.SelectedItem.ToString();
                    textBox1.Visible = true;
                    textBox1.Focus();
                 
                    // Обработчик события завершения редактирования
                    textBox1.TextChanged += (s, args) =>
                    {
                        listBox1.Items[selectedIndex] = textBox1.Text; // Обновляем значение в ListBox
                    };

                    // Обработчик события потери фокуса TextBox (завершение редактирования)
                    textBox1.LostFocus += (s, args) =>
                    {
                        textBox1.Visible = false; // Скрываем TextBox после редактирования
                    };
                }
                else
                {
                    MessageBox.Show("Выберите элемент для редактирования.");//предупреждение если строка в listbox не выбрана
                }                
            }
        }
        public void Ticket()
        {
            Ticket ticket = new Ticket(textBox1.Text + textBox2.Text, "Пермь",destination, price, dateNow);//передача данных на 4 форму
            list2.Add(ticket);
        }
    }
}
