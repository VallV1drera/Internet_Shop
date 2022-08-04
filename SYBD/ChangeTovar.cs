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
    public partial class ChangeTovar : Form
    {
        public ChangeTovar()
        {
            InitializeComponent();
        }

        private void ChangeTovar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "internet_shopDataSet20.tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter.Fill(this.internet_shopDataSet20.tovar);

        }

        private void redButton_Click(object sender, EventArgs e)
        {
            string connString = "Host=localhost;Username=postgres;Password=123456789;Database=Internet_shop";
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            if (tovarIDComboBox.Text != "")
            {
                int id = Convert.ToInt32(tovarIDComboBox.Text);
                string tovnaz = tovarNameTextBox.Text;
                string opis = opisTextBox.Text;
                string mass = textBox1.Text;
                if (tovnaz != "" && opis != "" && mass != "")
                {
                    using (var command = new NpgsqlCommand("UPDATE tovar SET (naz, opis, mass) = (@naz, @opis, @mass::double precision) WHERE id=@id", conn))
                    {
                        try
                        {
                            conn.Open();
                            command.Parameters.AddWithValue("@id", id);
                            command.Parameters.AddWithValue("@naz", tovnaz);
                            command.Parameters.AddWithValue("@opis", opis);
                            command.Parameters.AddWithValue("@mass", mass);
                            if (command.ExecuteNonQuery() == 1)
                                MessageBox.Show("Данные товара успешно изменены!", "Успех");
                        }
                        catch (NpgsqlException ex)
                        {
                            //23503
                            string abc = ex.Message;
                            string abc1 = abc.Remove(5);
                            if (abc1 == "23503")
                            {
                                MessageBox.Show("Ошибка 23503: Сначала необходимо удалить активный заказ на данный товар", "Ошибка");
                                string writePath = @"C:\Users\Margarita\Desktop\СУБД\logs.txt";
                                string text = DateTime.Now + " Ошибка 23503: Сначала необходимо удалить активный заказ на данный товар";
                                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                                {
                                    sw.WriteLine(text);
                                }
                            }
                            //23505
                            if (abc1 == "23505")
                            {
                                MessageBox.Show("Ошибка 23505: Данный товар уже существует", "Ошибка");
                                string writePath = @"C:\Users\Margarita\Desktop\СУБД\logs.txt";
                                string text = DateTime.Now + " Ошибка 23505: Данный товар уже существует";
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
                                string text = DateTime.Now + " Ошибка 3D000: База данных не найдена";
                                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                                {
                                    sw.WriteLine(text);
                                }
                            }
                            //22P02
                            if (abc1 == "22P02")
                            {
                                MessageBox.Show("Ошибка 22P02: Неверный формат массы", "Ошибка");
                                string writePath = @"C:\Users\Margarita\Desktop\СУБД\logs.txt";
                                string text = DateTime.Now + " Ошибка 22P02: Неверный формат массы";
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
