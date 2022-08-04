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
    public partial class ChangeCustomer : Form
    {
        public ChangeCustomer()
        {
            InitializeComponent();
        }

        private void ChangeCustomer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "internet_shopDataSet19.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.internet_shopDataSet19.client);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Host=localhost;Username=postgres;Password=123456789;Database=Internet_shop";
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            if (customerIDComboBox.Text != "")
            {
                int id = Convert.ToInt32(customerIDComboBox.Text);
                string fio = fioTextBox.Text;
                string date = dayComboBox.Text + '.' + monthComboBox.Text + '.' + yearComboBox.Text;
                string gen = genderComboBox.Text;
                if (fio != "" && dayComboBox.Text != "" && monthComboBox.Text != "" && yearComboBox.Text != "" && gen != "")
                {
                    using (var command = new NpgsqlCommand("UPDATE client SET (fio, date, gender) = (@fio, @date::date, @gen) WHERE id=@id", conn))
                    {
                        try
                        {
                            conn.Open();
                            command.Parameters.AddWithValue("@id", id);
                            command.Parameters.AddWithValue("@fio", fio);
                            command.Parameters.AddWithValue("@date", date);
                            command.Parameters.AddWithValue("@gen", gen);
                            if (command.ExecuteNonQuery() == 1)
                                MessageBox.Show("Данные клиента успешно изменены!");
                        }
                        catch (NpgsqlException ex)
                        {
                            //23503
                            string abc = ex.Message;
                            string abc1 = abc.Remove(5);
                            if (abc1 == "23503")
                            {
                                MessageBox.Show("Ошибка 23503: Сначала необходимо удалить активный заказ на данного клиента", "Ошибка");
                                string writePath = @"C:\Users\Margarita\Desktop\СУБД\logs.txt";
                                string text = DateTime.Now + " Ошибка 23503: Сначала необходимо удалить активный заказ на данного клиента";
                                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                                {
                                    sw.WriteLine(text);
                                }
                            }
                            //23505
                            if (abc1 == "23505")
                            {
                                MessageBox.Show("Ошибка 23505: Данный пользователь уже существует", "Ошибка");
                                string writePath = @"C:\Users\Margarita\Desktop\СУБД\logs.txt";
                                string text = DateTime.Now + " Ошибка 23505: Данный пользователь уже существует";
                                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                                {
                                    sw.WriteLine(text);
                                }
                            }
                            //3D000
                            if (abc1 == "3D000")
                            {
                                MessageBox.Show("Ошибка 3D000: База данных не найдена", "Ошибка");
                                string writePath = @"C:\Users\Margarita\Desktop\СУБД\logs.txt";
                                string text = DateTime.Now + " Ошибка 3D000: База данных недоступна";
                                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                                {
                                    sw.WriteLine(text);
                                }
                            }
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все поля", "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Не выбран ID", "Ошибка");
            }
        }
    }
}
