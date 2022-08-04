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
    public partial class RegCustomer : Form
    {
        public RegCustomer()
        {
            InitializeComponent();
        }

        private void regButton_Click(object sender, EventArgs e)
        {
           string connString = "Host=localhost;Username=postgres;Password=123456789;Database=Internet_shop";
           NpgsqlConnection conn = new NpgsqlConnection(connString);
            string userFIO = fioTextBox.Text;
            string userDate = dayComboBox.Text + '.' + monthComboBox.Text + '.' + yearComboBox.Text;
            string userGender = genderComboBox.Text;
            if (userFIO != "" && userDate != "" && userGender != "")
            {
                    using (var command = new NpgsqlCommand("INSERT INTO client (fio, date, gender) VALUES (@uFIO, @uDATE::date, @uGENDER)", conn))
                    {
                        try
                        {
                            conn.Open();
                            command.Parameters.AddWithValue("@uFIO", userFIO);
                            command.Parameters.AddWithValue("@uDATE", userDate);
                            command.Parameters.AddWithValue("@uGENDER", userGender);
                            if (command.ExecuteNonQuery() == 1)
                                MessageBox.Show("Покупатель успешно зарегистрирован!");
                            else
                                MessageBox.Show("Регистрация не удалась!");
                        }
                        catch (NpgsqlException ex)
                        {
                            string abc = ex.Message;
                            string abc1 = abc.Remove(5);
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
                            string text = DateTime.Now + " Ошибка 3D000: База данных не найдена";
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
                MessageBox.Show("Заполните все поля");
            }
        }
    }
}
