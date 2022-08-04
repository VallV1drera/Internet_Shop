
namespace SYBD
{
    partial class Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tovarNameComboBox = new System.Windows.Forms.ComboBox();
            this.tovarBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.internet_shopDataSet21 = new SYBD.Internet_shopDataSet2();
            this.internet_shopDataSet = new SYBD.internet_shopDataSet();
            this.tovarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tovarTableAdapter = new SYBD.internet_shopDataSetTableAdapters.tovarTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.clientNameComboBox = new System.Windows.Forms.ComboBox();
            this.clientBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.internet_shopDataSet3 = new SYBD.Internet_shopDataSet3();
            this.internet_shopDataSet1 = new SYBD.internet_shopDataSet1();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new SYBD.internet_shopDataSet1TableAdapters.clientTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.dayComboBox1 = new System.Windows.Forms.ComboBox();
            this.monthComboBox1 = new System.Windows.Forms.ComboBox();
            this.yearComboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.colComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dayComboBox2 = new System.Windows.Forms.ComboBox();
            this.monthComboBox2 = new System.Windows.Forms.ComboBox();
            this.yearComboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comTextBox = new System.Windows.Forms.TextBox();
            this.regButton = new System.Windows.Forms.Button();
            this.internet_shopDataSet2 = new SYBD.Internet_shopDataSet();
            this.tovarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tovarTableAdapter1 = new SYBD.Internet_shopDataSetTableAdapters.tovarTableAdapter();
            this.internet_shopDataSet11 = new SYBD.Internet_shopDataSet1();
            this.clientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter1 = new SYBD.Internet_shopDataSet1TableAdapters.clientTableAdapter();
            this.tovarTableAdapter2 = new SYBD.Internet_shopDataSet2TableAdapters.tovarTableAdapter();
            this.clientTableAdapter2 = new SYBD.Internet_shopDataSet3TableAdapters.clientTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internet_shopDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internet_shopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internet_shopDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internet_shopDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internet_shopDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internet_shopDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выбор товара:*";
            // 
            // tovarNameComboBox
            // 
            this.tovarNameComboBox.DataSource = this.tovarBindingSource2;
            this.tovarNameComboBox.DisplayMember = "naz";
            this.tovarNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tovarNameComboBox.FormattingEnabled = true;
            this.tovarNameComboBox.Location = new System.Drawing.Point(124, 24);
            this.tovarNameComboBox.Name = "tovarNameComboBox";
            this.tovarNameComboBox.Size = new System.Drawing.Size(293, 21);
            this.tovarNameComboBox.TabIndex = 1;
            this.tovarNameComboBox.ValueMember = "naz";
            // 
            // tovarBindingSource2
            // 
            this.tovarBindingSource2.DataMember = "tovar";
            this.tovarBindingSource2.DataSource = this.internet_shopDataSet21;
            // 
            // internet_shopDataSet21
            // 
            this.internet_shopDataSet21.DataSetName = "Internet_shopDataSet2";
            this.internet_shopDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // internet_shopDataSet
            // 
            this.internet_shopDataSet.DataSetName = "internet_shopDataSet";
            this.internet_shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tovarBindingSource
            // 
            this.tovarBindingSource.DataMember = "tovar";
            this.tovarBindingSource.DataSource = this.internet_shopDataSet;
            // 
            // tovarTableAdapter
            // 
            this.tovarTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выбор покупателя:*";
            // 
            // clientNameComboBox
            // 
            this.clientNameComboBox.DataSource = this.clientBindingSource2;
            this.clientNameComboBox.DisplayMember = "fio";
            this.clientNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientNameComboBox.FormattingEnabled = true;
            this.clientNameComboBox.Location = new System.Drawing.Point(124, 63);
            this.clientNameComboBox.Name = "clientNameComboBox";
            this.clientNameComboBox.Size = new System.Drawing.Size(293, 21);
            this.clientNameComboBox.TabIndex = 3;
            this.clientNameComboBox.ValueMember = "date";
            // 
            // clientBindingSource2
            // 
            this.clientBindingSource2.DataMember = "client";
            this.clientBindingSource2.DataSource = this.internet_shopDataSet3;
            // 
            // internet_shopDataSet3
            // 
            this.internet_shopDataSet3.DataSetName = "Internet_shopDataSet3";
            this.internet_shopDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // internet_shopDataSet1
            // 
            this.internet_shopDataSet1.DataSetName = "internet_shopDataSet1";
            this.internet_shopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.internet_shopDataSet1;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата заказа:*";
            // 
            // dayComboBox1
            // 
            this.dayComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dayComboBox1.FormattingEnabled = true;
            this.dayComboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dayComboBox1.Location = new System.Drawing.Point(124, 143);
            this.dayComboBox1.Name = "dayComboBox1";
            this.dayComboBox1.Size = new System.Drawing.Size(48, 21);
            this.dayComboBox1.TabIndex = 5;
            // 
            // monthComboBox1
            // 
            this.monthComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthComboBox1.FormattingEnabled = true;
            this.monthComboBox1.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.monthComboBox1.Location = new System.Drawing.Point(178, 143);
            this.monthComboBox1.Name = "monthComboBox1";
            this.monthComboBox1.Size = new System.Drawing.Size(48, 21);
            this.monthComboBox1.TabIndex = 6;
            // 
            // yearComboBox1
            // 
            this.yearComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearComboBox1.FormattingEnabled = true;
            this.yearComboBox1.Items.AddRange(new object[] {
            "1900",
            "1901",
            "1902",
            "1903",
            "1904",
            "1905",
            "1906",
            "1907",
            "1908",
            "1909",
            "1910",
            "1911",
            "1912",
            "1913",
            "1914",
            "1915",
            "1916",
            "1917",
            "1918",
            "1919",
            "1920",
            "1921",
            "1922",
            "1923",
            "1924",
            "1925",
            "1926",
            "1927",
            "1928",
            "1929",
            "1930",
            "1931",
            "1932",
            "1933",
            "1934",
            "1935",
            "1936",
            "1937",
            "1938",
            "1939",
            "1940",
            "1941",
            "1942",
            "1943",
            "1944",
            "1945",
            "1946",
            "1947",
            "1948",
            "1949",
            "1950",
            "1951",
            "1952",
            "1953",
            "1954",
            "1955",
            "1956",
            "1957",
            "1958",
            "1959",
            "1960",
            "1961",
            "1962",
            "1963",
            "1964",
            "1965",
            "1966",
            "1967",
            "1968",
            "1969",
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.yearComboBox1.Location = new System.Drawing.Point(232, 143);
            this.yearComboBox1.Name = "yearComboBox1";
            this.yearComboBox1.Size = new System.Drawing.Size(61, 21);
            this.yearComboBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Количество:*";
            // 
            // colComboBox
            // 
            this.colComboBox.FormattingEnabled = true;
            this.colComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99"});
            this.colComboBox.Location = new System.Drawing.Point(124, 177);
            this.colComboBox.Name = "colComboBox";
            this.colComboBox.Size = new System.Drawing.Size(48, 21);
            this.colComboBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Дата доставки:*";
            // 
            // dayComboBox2
            // 
            this.dayComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dayComboBox2.FormattingEnabled = true;
            this.dayComboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dayComboBox2.Location = new System.Drawing.Point(124, 214);
            this.dayComboBox2.Name = "dayComboBox2";
            this.dayComboBox2.Size = new System.Drawing.Size(48, 21);
            this.dayComboBox2.TabIndex = 11;
            // 
            // monthComboBox2
            // 
            this.monthComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthComboBox2.FormattingEnabled = true;
            this.monthComboBox2.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.monthComboBox2.Location = new System.Drawing.Point(178, 214);
            this.monthComboBox2.Name = "monthComboBox2";
            this.monthComboBox2.Size = new System.Drawing.Size(48, 21);
            this.monthComboBox2.TabIndex = 12;
            // 
            // yearComboBox2
            // 
            this.yearComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearComboBox2.FormattingEnabled = true;
            this.yearComboBox2.Items.AddRange(new object[] {
            "1900",
            "1901",
            "1902",
            "1903",
            "1904",
            "1905",
            "1906",
            "1907",
            "1908",
            "1909",
            "1910",
            "1911",
            "1912",
            "1913",
            "1914",
            "1915",
            "1916",
            "1917",
            "1918",
            "1919",
            "1920",
            "1921",
            "1922",
            "1923",
            "1924",
            "1925",
            "1926",
            "1927",
            "1928",
            "1929",
            "1930",
            "1931",
            "1932",
            "1933",
            "1934",
            "1935",
            "1936",
            "1937",
            "1938",
            "1939",
            "1940",
            "1941",
            "1942",
            "1943",
            "1944",
            "1945",
            "1946",
            "1947",
            "1948",
            "1949",
            "1950",
            "1951",
            "1952",
            "1953",
            "1954",
            "1955",
            "1956",
            "1957",
            "1958",
            "1959",
            "1960",
            "1961",
            "1962",
            "1963",
            "1964",
            "1965",
            "1966",
            "1967",
            "1968",
            "1969",
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.yearComboBox2.Location = new System.Drawing.Point(232, 214);
            this.yearComboBox2.Name = "yearComboBox2";
            this.yearComboBox2.Size = new System.Drawing.Size(61, 21);
            this.yearComboBox2.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Адрес доставки:*";
            // 
            // adressTextBox
            // 
            this.adressTextBox.Location = new System.Drawing.Point(124, 251);
            this.adressTextBox.Multiline = true;
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(293, 55);
            this.adressTextBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Комментарий:";
            // 
            // comTextBox
            // 
            this.comTextBox.Location = new System.Drawing.Point(124, 325);
            this.comTextBox.Multiline = true;
            this.comTextBox.Name = "comTextBox";
            this.comTextBox.Size = new System.Drawing.Size(293, 55);
            this.comTextBox.TabIndex = 17;
            // 
            // regButton
            // 
            this.regButton.Location = new System.Drawing.Point(158, 420);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(115, 23);
            this.regButton.TabIndex = 18;
            this.regButton.Text = "Создать заказ";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // internet_shopDataSet2
            // 
            this.internet_shopDataSet2.DataSetName = "Internet_shopDataSet";
            this.internet_shopDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tovarBindingSource1
            // 
            this.tovarBindingSource1.DataMember = "tovar";
            this.tovarBindingSource1.DataSource = this.internet_shopDataSet2;
            // 
            // tovarTableAdapter1
            // 
            this.tovarTableAdapter1.ClearBeforeFill = true;
            // 
            // internet_shopDataSet11
            // 
            this.internet_shopDataSet11.DataSetName = "Internet_shopDataSet1";
            this.internet_shopDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource1
            // 
            this.clientBindingSource1.DataMember = "client";
            this.clientBindingSource1.DataSource = this.internet_shopDataSet11;
            // 
            // clientTableAdapter1
            // 
            this.clientTableAdapter1.ClearBeforeFill = true;
            // 
            // tovarTableAdapter2
            // 
            this.tovarTableAdapter2.ClearBeforeFill = true;
            // 
            // clientTableAdapter2
            // 
            this.clientTableAdapter2.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Дата рождения:*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(122, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Показать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 473);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.comTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.adressTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.yearComboBox2);
            this.Controls.Add(this.monthComboBox2);
            this.Controls.Add(this.dayComboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.colComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yearComboBox1);
            this.Controls.Add(this.monthComboBox1);
            this.Controls.Add(this.dayComboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clientNameComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tovarNameComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Order";
            this.Text = "Создание заказа";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internet_shopDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internet_shopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internet_shopDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internet_shopDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internet_shopDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internet_shopDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tovarNameComboBox;
        private internet_shopDataSet internet_shopDataSet;
        private System.Windows.Forms.BindingSource tovarBindingSource;
        private internet_shopDataSetTableAdapters.tovarTableAdapter tovarTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox clientNameComboBox;
        private internet_shopDataSet1 internet_shopDataSet1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private internet_shopDataSet1TableAdapters.clientTableAdapter clientTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox dayComboBox1;
        private System.Windows.Forms.ComboBox monthComboBox1;
        private System.Windows.Forms.ComboBox yearComboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox colComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox dayComboBox2;
        private System.Windows.Forms.ComboBox monthComboBox2;
        private System.Windows.Forms.ComboBox yearComboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox comTextBox;
        private System.Windows.Forms.Button regButton;
        private Internet_shopDataSet internet_shopDataSet2;
        private System.Windows.Forms.BindingSource tovarBindingSource1;
        private Internet_shopDataSetTableAdapters.tovarTableAdapter tovarTableAdapter1;
        private Internet_shopDataSet1 internet_shopDataSet11;
        private System.Windows.Forms.BindingSource clientBindingSource1;
        private Internet_shopDataSet1TableAdapters.clientTableAdapter clientTableAdapter1;
        private Internet_shopDataSet2 internet_shopDataSet21;
        private System.Windows.Forms.BindingSource tovarBindingSource2;
        private Internet_shopDataSet2TableAdapters.tovarTableAdapter tovarTableAdapter2;
        private Internet_shopDataSet3 internet_shopDataSet3;
        private System.Windows.Forms.BindingSource clientBindingSource2;
        private Internet_shopDataSet3TableAdapters.clientTableAdapter clientTableAdapter2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}