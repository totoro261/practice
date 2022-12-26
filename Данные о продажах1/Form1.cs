using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Данные_о_продажах1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var txt = File.ReadAllLines("TextFile1.txt");
            foreach (string line in txt)
                comboBox2.Items.Add(line);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = Convert.ToInt32(comboBox6.SelectedItem.ToString());
            int s = Convert.ToInt32(numericUpDown1.Value);

            listBox1.Items.Add("Название магазина: " + comboBox1.SelectedItem.ToString());
            listBox1.Items.Add("Город:" + comboBox2.SelectedItem.ToString());
            listBox1.Items.Add("ФИО менеджера:" + comboBox3.SelectedItem.ToString());
            listBox1.Items.Add("Тип клиента:" + comboBox4.SelectedItem.ToString());
            listBox1.Items.Add("Товар:" + comboBox5.SelectedItem.ToString());
            listBox1.Items.Add("Количество: " + numericUpDown1.Value);
            listBox1.Items.Add("Цена:" + comboBox6.SelectedItem.ToString());
            listBox1.Items.Add("Дата продажи: " + dateTimePicker1.Value);
            if (checkBox1.Checked)
            {
                listBox1.Items.Add("Оплата безналичными");
            }
            else
                listBox1.Items.Add("Наличные");
            int n = a * s;
            listBox1.Items.Add("Итог: " + n + " руб.");
            listBox1.Items.Add("--------------------------------------------------");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex == 0)
            {
                comboBox6.Items.Clear();
                comboBox6.Items.Add("15999");
            }
            else if (comboBox5.SelectedIndex == 1)
            {
                comboBox6.Items.Clear();
                comboBox6.Items.Add("59999");
            }
            else if (comboBox5.SelectedIndex == 2)
            {
                comboBox6.Items.Clear();
                comboBox6.Items.Add("3799");
            }
            else if (comboBox5.SelectedIndex == 3)
            {
                comboBox6.Items.Clear();
                comboBox6.Items.Add("2300");
            }
            else if (comboBox5.SelectedIndex == 4)
            {
                comboBox6.Items.Clear();
                comboBox6.Items.Add("2000");
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
