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
    public partial class RegGoods : Form
    {
        public RegGoods()
        {
            InitializeComponent();
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            string connString = "Host=localhost;Username=postgres;Password=123456789;Database=Internet_shop";
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            string name = nameComboBox.Text;
            string opis = opisComboBox.Text;
            string mass = massComboBox.Text;
            if (name != "" && opis != "" && mass != "")
            {
                using (var command = new NpgsqlCommand("INSERT INTO tovar (naz, opis, mass) VALUES (@naz, @opis, @mass::double precision)", conn))
                {
                    try
                    {
                        conn.Open();
                        command.Parameters.AddWithValue("@naz", name);
                        command.Parameters.AddWithValue("@opis", opis);
                        command.Parameters.AddWithValue("@mass", mass);
                        if (command.ExecuteNonQuery() == 1)
                            MessageBox.Show("Товар успешно зарегистрирован!");
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
                            MessageBox.Show("Ошибка 23505: Товар с таким названием уже зарегистрирован", "Ошибка");
                            string writePath = @"C:\Users\Margarita\Desktop\СУБД\logs.txt";
                            string text = DateTime.Now + " Ошибка 23505: Товар с таким названием уже зарегистрирован";
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
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Ошибка");
            }
        }
    }
}
