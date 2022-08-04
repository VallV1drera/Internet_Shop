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
    public partial class ChangeZakaz : Form
    {
        public ChangeZakaz()
        {
            InitializeComponent();
        }

        private void ChangeZakaz_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "internet_shopDataSet22.pokupka". При необходимости она может быть перемещена или удалена.
            this.pokupkaTableAdapter.Fill(this.internet_shopDataSet22.pokupka);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "internet_shopDataSet21.tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter.Fill(this.internet_shopDataSet21.tovar);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Host=localhost;Username=postgres;Password=123456789;Database=Internet_shop";
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            if (zakazIDComboBox.Text != "")
            {
                int id = Convert.ToInt32(zakazIDComboBox.Text);
                string dostdate = dayComboBox.Text + '.' + monthComboBox.Text + '.' + yearComboBox.Text;
                string adress = adressTextBox.Text;
                string com = comTextBox.Text;
                string col = colComboBox.Text;
                if (dostdate != "" && adress != "" && col != "")
                {
                    using (var command = new NpgsqlCommand("UPDATE pokupka SET (col, dostdate, adress, com) = (col::integer, @dostdate::date, @adress, @com) WHERE id=@id", conn))
                    {
                        try
                        {
                            conn.Open();
                            command.Parameters.AddWithValue("@id", id);
                            command.Parameters.AddWithValue("@col", col);
                            command.Parameters.AddWithValue("@dostdate", dostdate);
                            command.Parameters.AddWithValue("@adress", adress);
                            command.Parameters.AddWithValue("@com", com);
                            if (command.ExecuteNonQuery() == 1)
                                MessageBox.Show("Заказ успешно изменён!");
                        }
                        catch (NpgsqlException ex)
                        {
                            string abc = ex.Message;
                            string abc1 = abc.Remove(5);
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
                    }
                }
                else
                {
                    MessageBox.Show("Не выбран ID", "Ошибка");
                }
            }
        }
    }
}
