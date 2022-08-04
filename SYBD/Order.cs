using Npgsql;
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

namespace SYBD
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "internet_shopDataSet3.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter2.Fill(this.internet_shopDataSet3.client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "internet_shopDataSet21.tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter2.Fill(this.internet_shopDataSet21.tovar);

        }



        private void regButton_Click(object sender, EventArgs e)
        {
            Conn conn = new Conn();
            conn.ConnectToDB();
            string name = tovarNameComboBox.Text;
            string customer = clientNameComboBox.Text;
            string date = dayComboBox1.Text + '.' + monthComboBox1.Text + '.' + yearComboBox1.Text;
            string col = colComboBox.Text;
            string deldate = dayComboBox2.Text + '.' + monthComboBox2.Text + '.' + yearComboBox2.Text;
            string adress = adressTextBox.Text;
            string com = comTextBox.Text;
            string clientdate = (clientNameComboBox.SelectedValue).ToString();
            string clientdate1 = clientdate.Remove(10);
            if (name != "" && customer != "" && dayComboBox1.Text != "" && monthComboBox1.Text != "" && yearComboBox1.Text != "" && col != "" && dayComboBox2.Text != "" && monthComboBox2.Text != "" && yearComboBox2.Text != "" && adress != "")
            {

                using (var command = new NpgsqlCommand("INSERT INTO pokupka (tovar_naz, userfio, userdate, date, colvo, adress, com, dostdate) VALUES (@naz, @userfio, @userdate::date, @date::date, @colvo::integer, @adress, @kom, @dostdate::date)", conn))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@naz", name);
                        command.Parameters.AddWithValue("@userfio", customer);
                        command.Parameters.AddWithValue("@userdate", clientdate1);
                        command.Parameters.AddWithValue("@date", date);
                        command.Parameters.AddWithValue("@colvo", col);
                        command.Parameters.AddWithValue("@adress", adress);
                        command.Parameters.AddWithValue("@kom", com);
                        command.Parameters.AddWithValue("@dostdate", deldate);
                        if (command.ExecuteNonQuery() == 1)
                            MessageBox.Show("Заказ успешно зарегистрирован!");
                        else
                            MessageBox.Show("Регистрация не удалась!");
                    }
                    catch (NpgsqlException ex)
                    {
                        string abc = ex.Message;
                        string abc1 = abc.Remove(5);
                        //3D000
                        if (abc1 == "3D000")
                        {
                            MessageBox.Show("База данных не найдена", "Ошибка");
                            string writePath = @"C:\Users\Margarita\Desktop\СУБД\logs.txt";
                            string text = DateTime.Now + " Ошибка 3D000: База данных не найдена";
                            using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                            {
                                sw.WriteLine(text);
                            }
                        }
                        //22P02
                        if (abc1 == "22P02")
                        {
                            MessageBox.Show("Неверный формат количества", "Ошибка");
                            string writePath = @"C:\Users\Margarita\Desktop\СУБД\logs.txt";
                            string text = DateTime.Now + " Неверный формат количества";
                            using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                            {
                                sw.WriteLine(text);
                            }
                        }
                        //23505
                        if (abc1 == "23505")
                        {
                            MessageBox.Show("Ошибка 23505: Данный заказ уже существует", "Ошибка");
                            string writePath = @"C:\Users\Margarita\Desktop\СУБД\logs.txt";
                            string text = DateTime.Now + " Ошибка 23505: Данный заказ уже существует";
                            using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                            {
                                sw.WriteLine(text);
                            }
                        }
                    }
                    finally
                    {
                        conn.DissconnectToDB();
                    }
                }
            }
            else
            {
                MessageBox.Show("Заполните все обязательные поля", "Ошибка");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (clientNameComboBox.SelectedValue != null)
            {
                string clientdate = (clientNameComboBox.SelectedValue).ToString();
                string clientdate1 = clientdate.Remove(10);
                label9.Text = clientdate1;
            }
            else
            {
                MessageBox.Show("Клиент не выбран", "Ошибка");
            }
        }
    }
}
