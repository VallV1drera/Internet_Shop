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
    public partial class ControlDB : Form
    {
        public ControlDB()
        {
            InitializeComponent();
        }

        private void ControlBD_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "internet_shopDataSet18.pokupka". При необходимости она может быть перемещена или удалена.
            this.pokupkaTableAdapter3.Fill(this.internet_shopDataSet18.pokupka); //Обновление combobox id заказов.
            // TODO: данная строка кода позволяет загрузить данные в таблицу "internet_shopDataSet17.tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter4.Fill(this.internet_shopDataSet17.tovar); //Обновление combobox id товаров.
            // TODO: данная строка кода позволяет загрузить данные в таблицу "internet_shopDataSet16.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter5.Fill(this.internet_shopDataSet16.client); //Обновление combobox id клиентов.
            // TODO: данная строка кода позволяет загрузить данные в таблицу "internet_shopDataSet15.pokupka". При необходимости она может быть перемещена или удалена.
            this.pokupkaTableAdapter2.Fill(this.internet_shopDataSet15.pokupka); //Обновление таблицы заказов.
            // TODO: данная строка кода позволяет загрузить данные в таблицу "internet_shopDataSet14.tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter3.Fill(this.internet_shopDataSet14.tovar); //Обновление таблицы товаров.
            // TODO: данная строка кода позволяет загрузить данные в таблицу "internet_shopDataSet13.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter4.Fill(this.internet_shopDataSet13.client); //Обновление таблицы клиентов.

        }

        private void delCustomer_Click(object sender, EventArgs e)
        {
            string connString = "Host=localhost;Username=postgres;Password=123456789;Database=Internet_shop";
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            if (customerIDComboBox.Text != "")
            {
                int id = Convert.ToInt32(customerIDComboBox.Text);
                using (var command = new NpgsqlCommand("DELETE FROM client WHERE id=@id", conn))
                {
                    try
                    {
                        conn.Open();
                        command.Parameters.AddWithValue("@id", id);
                        if (command.ExecuteNonQuery() == 1)
                            MessageBox.Show("Покупатель успешно удалён!", "Успех");
                    }
                    catch (NpgsqlException ex)
                    {
                        string abc = ex.Message;
                        string abc1 = abc.Remove(5);
                        //3D000
                        if (abc1 == "3D000")
                        {
                            MessageBox.Show("Ошибка 3D000: База данных недоступна", "Ошибка");
                            string writePath = @"C:\Users\Margarita\Desktop\СУБД\logs.txt";
                            string text = DateTime.Now + " Ошибка 3D000: База данных недоступна";
                                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                                {
                                    sw.WriteLine(text);
                                }
                        }
                        //23503
                        if (abc1 == "23503")
                        {
                            MessageBox.Show("Ошибка 23503: Сначала необходимо удалить активный заказ", "Ошибка");
                            string writePath = @"C:\Users\Margarita\Desktop\СУБД\logs.txt";
                            string text = DateTime.Now + " Ошибка 23503: Сначала необходимо удалить активный заказ";
                            using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                            {
                                sw.WriteLine(text);
                            }
                        }
                    }
                    finally
                    {
                        conn.Close();
                        this.clientTableAdapter4.Fill(this.internet_shopDataSet13.client); //Обновление таблицы клиентов.
                        this.clientTableAdapter5.Fill(this.internet_shopDataSet16.client); //Обновление combobox id клиентов.
                    }
                }  
            }
            else
            {
                MessageBox.Show("Не выбран ID", "Ошибка");
            }
        }

        private void delGoods_Click(object sender, EventArgs e)
        {
            string connString = "Host=localhost;Username=postgres;Password=123456789;Database=Internet_shop";
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            if (tovarIDComboBox.Text != "")
            {
                int id = Convert.ToInt32(tovarIDComboBox.Text);
                using (var command = new NpgsqlCommand("DELETE FROM tovar WHERE id=@id", conn))
                {
                    try
                    {
                        conn.Open();
                        command.Parameters.AddWithValue("@id", id);
                        if (command.ExecuteNonQuery() == 1)
                            MessageBox.Show("Товар успешно удалён!", "Успех");
                    }
                    catch (NpgsqlException ex)
                    {
                        string abc = ex.Message;
                        string abc1 = abc.Remove(5);
                        //3D000
                        if (abc1 == "3D000")
                        {
                            MessageBox.Show("Ошибка 3D000: База данных недоступна", "Ошибка");
                            string writePath = @"C:\Users\Margarita\Desktop\СУБД\logs.txt";
                            string text = DateTime.Now + " Ошибка 3D000: База данных недоступна";
                            using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                            {
                                sw.WriteLine(text);
                            }
                        }
                        //23503
                        if (abc1 == "23503")
                        {
                            MessageBox.Show("Ошибка 23503: Сначала необходимо удалить активный заказ", "Ошибка");
                            string writePath = @"C:\Users\Margarita\Desktop\СУБД\logs.txt";
                            string text = DateTime.Now + " Ошибка 23503: Сначала необходимо удалить активный заказ";
                            using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                            {
                                sw.WriteLine(text);
                            }
                        }
                    }
                    finally
                    {
                        conn.Close();
                        this.tovarTableAdapter3.Fill(this.internet_shopDataSet14.tovar); //Обновление таблицы товаров.
                        this.tovarTableAdapter4.Fill(this.internet_shopDataSet17.tovar); //Обновление combobox id товаров.
                    }
                }  
            }
            else
            {
                MessageBox.Show("Не выбран ID", "Ошибка");
            }
        }

        private void delZakaz_Click(object sender, EventArgs e)
        {
            string connString = "Host=localhost;Username=postgres;Password=123456789;Database=Internet_shop";
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            if (zakazIDComboBox.Text != "")
            {
                int id = Convert.ToInt32(zakazIDComboBox.Text);
                using (var command = new NpgsqlCommand("DELETE FROM pokupka WHERE id=@id", conn))
                {
                    try
                    {
                        conn.Open();
                        command.Parameters.AddWithValue("@id", id);
                        if (command.ExecuteNonQuery() == 1)
                            MessageBox.Show("Заказ успешно удалён!", "Успех");
                    }
                    catch (NpgsqlException ex)
                    {
                        string abc = ex.Message;
                        string abc1 = abc.Remove(5);
                        //3D000
                        if (abc1 == "3D000")
                        {
                            MessageBox.Show("Ошибка 3D000: База данных недоступна", "Ошибка");
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
                        this.pokupkaTableAdapter2.Fill(this.internet_shopDataSet15.pokupka); //Обновление таблицы заказов.
                        this.pokupkaTableAdapter3.Fill(this.internet_shopDataSet18.pokupka); //Обновление combobox id заказов.
                    }
                }
            }
            else
            {
                MessageBox.Show("Не выбран ID", "Ошибка");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeZakaz changeZakaz = new ChangeZakaz();
            changeZakaz.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeCustomer changeCustomer = new ChangeCustomer();
            changeCustomer.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangeTovar changeTovar = new ChangeTovar();
            changeTovar.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "internet_shopDataSet18.pokupka". При необходимости она может быть перемещена или удалена.
            this.pokupkaTableAdapter3.Fill(this.internet_shopDataSet18.pokupka); //Обновление combobox id заказов.
            // TODO: данная строка кода позволяет загрузить данные в таблицу "internet_shopDataSet17.tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter4.Fill(this.internet_shopDataSet17.tovar); //Обновление combobox id товаров.
            // TODO: данная строка кода позволяет загрузить данные в таблицу "internet_shopDataSet16.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter5.Fill(this.internet_shopDataSet16.client); //Обновление combobox id клиентов.
            // TODO: данная строка кода позволяет загрузить данные в таблицу "internet_shopDataSet15.pokupka". При необходимости она может быть перемещена или удалена.
            this.pokupkaTableAdapter2.Fill(this.internet_shopDataSet15.pokupka); //Обновление таблицы заказов.
            // TODO: данная строка кода позволяет загрузить данные в таблицу "internet_shopDataSet14.tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter3.Fill(this.internet_shopDataSet14.tovar); //Обновление таблицы товаров.
            // TODO: данная строка кода позволяет загрузить данные в таблицу "internet_shopDataSet13.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter4.Fill(this.internet_shopDataSet13.client); //Обновление таблицы клиентов.
        }
    }
}
