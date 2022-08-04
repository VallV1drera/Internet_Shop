
namespace SYBD
{
    partial class ChangeZakaz
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
            this.button1 = new System.Windows.Forms.Button();
            this.comTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.zakazIDComboBox = new System.Windows.Forms.ComboBox();
            this.pokupkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.internet_shopDataSet22 = new SYBD.Internet_shopDataSet22();
            this.label6 = new System.Windows.Forms.Label();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.dayComboBox = new System.Windows.Forms.ComboBox();
            this.internet_shopDataSet21 = new SYBD.Internet_shopDataSet21();
            this.tovarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tovarTableAdapter = new SYBD.Internet_shopDataSet21TableAdapters.tovarTableAdapter();
            this.pokupkaTableAdapter = new SYBD.Internet_shopDataSet22TableAdapters.pokupkaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.colComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pokupkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internet_shopDataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internet_shopDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Редактировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comTextBox
            // 
            this.comTextBox.Location = new System.Drawing.Point(110, 151);
            this.comTextBox.Multiline = true;
            this.comTextBox.Name = "comTextBox";
            this.comTextBox.Size = new System.Drawing.Size(358, 52);
            this.comTextBox.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Комментарий:";
            // 
            // adressTextBox
            // 
            this.adressTextBox.Location = new System.Drawing.Point(110, 116);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(358, 20);
            this.adressTextBox.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Адрес:*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Дата доставки:*";
            // 
            // zakazIDComboBox
            // 
            this.zakazIDComboBox.DataSource = this.pokupkaBindingSource;
            this.zakazIDComboBox.DisplayMember = "id";
            this.zakazIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zakazIDComboBox.FormattingEnabled = true;
            this.zakazIDComboBox.Location = new System.Drawing.Point(110, 12);
            this.zakazIDComboBox.Name = "zakazIDComboBox";
            this.zakazIDComboBox.Size = new System.Drawing.Size(51, 21);
            this.zakazIDComboBox.TabIndex = 23;
            this.zakazIDComboBox.ValueMember = "id";
            // 
            // pokupkaBindingSource
            // 
            this.pokupkaBindingSource.DataMember = "pokupka";
            this.pokupkaBindingSource.DataSource = this.internet_shopDataSet22;
            // 
            // internet_shopDataSet22
            // 
            this.internet_shopDataSet22.DataSetName = "Internet_shopDataSet22";
            this.internet_shopDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Выберите ID";
            // 
            // yearComboBox
            // 
            this.yearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Items.AddRange(new object[] {
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
            "2021"});
            this.yearComboBox.Location = new System.Drawing.Point(229, 81);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(76, 21);
            this.yearComboBox.TabIndex = 34;
            // 
            // monthComboBox
            // 
            this.monthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Items.AddRange(new object[] {
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
            this.monthComboBox.Location = new System.Drawing.Point(167, 81);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(56, 21);
            this.monthComboBox.TabIndex = 33;
            // 
            // dayComboBox
            // 
            this.dayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dayComboBox.FormattingEnabled = true;
            this.dayComboBox.Items.AddRange(new object[] {
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
            this.dayComboBox.Location = new System.Drawing.Point(110, 81);
            this.dayComboBox.Name = "dayComboBox";
            this.dayComboBox.Size = new System.Drawing.Size(51, 21);
            this.dayComboBox.TabIndex = 32;
            // 
            // internet_shopDataSet21
            // 
            this.internet_shopDataSet21.DataSetName = "Internet_shopDataSet21";
            this.internet_shopDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tovarBindingSource
            // 
            this.tovarBindingSource.DataMember = "tovar";
            this.tovarBindingSource.DataSource = this.internet_shopDataSet21;
            // 
            // tovarTableAdapter
            // 
            this.tovarTableAdapter.ClearBeforeFill = true;
            // 
            // pokupkaTableAdapter
            // 
            this.pokupkaTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Количество:*";
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
            this.colComboBox.Location = new System.Drawing.Point(110, 47);
            this.colComboBox.Name = "colComboBox";
            this.colComboBox.Size = new System.Drawing.Size(51, 21);
            this.colComboBox.TabIndex = 36;
            // 
            // ChangeZakaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 272);
            this.Controls.Add(this.colComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yearComboBox);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.dayComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.adressTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.zakazIDComboBox);
            this.Controls.Add(this.label6);
            this.Name = "ChangeZakaz";
            this.Text = "ChangeZakaz";
            this.Load += new System.EventHandler(this.ChangeZakaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pokupkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internet_shopDataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internet_shopDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox comTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox zakazIDComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.ComboBox dayComboBox;
        private Internet_shopDataSet21 internet_shopDataSet21;
        private System.Windows.Forms.BindingSource tovarBindingSource;
        private Internet_shopDataSet21TableAdapters.tovarTableAdapter tovarTableAdapter;
        private Internet_shopDataSet22 internet_shopDataSet22;
        private System.Windows.Forms.BindingSource pokupkaBindingSource;
        private Internet_shopDataSet22TableAdapters.pokupkaTableAdapter pokupkaTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox colComboBox;
    }
}