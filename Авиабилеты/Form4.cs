using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Авиабилеты
{
    public partial class Form4 : Form
    {
        private int count = 0;// переменная для подсчёта стоимости билетов
        public Form4(List<Passenger> list, List<Ticket>list2,int sum) // приём данных из 3-ей формы
        {
            InitializeComponent();
            for (int i = 0; i < sum; i++)
            {
                listBox1.Items.Add($"Данные пассажира:");
                string NewLine = ($"Фамилия: {list[i].Fio()} Имя: {list[i].Name()}   Дата рождения:{list[i].dateOfbirth()}  Паспорт: Серия:{list[i].PasS()} Номер: {list[i].passN()} ");// вывод данных пассажира
                listBox1.Items.Add(NewLine);
                listBox1.Items.Add($"Билет пассажира:");
                listBox1.Items.Add($"ФИО:{list2[i].pas()}  Пункт вылета:{list2[i].WhereFrom()}  Пункт назначения:{list2[i].whereto()}  Цена:{list2[i].Price()}₽  Дата покупки:{list2[i].Date()} ");// вывод билета пассажира
                listBox1.Items.Add("");

                count = list2[i].Price() + count;// подсчет стоимости билетов
            }
            label1.Text = $"ИТОГО {count}₽";// итоговая цена билета/ов
        }

        private void Form4_Load(object sender, EventArgs e)
        {
                
            }




        }
    }

