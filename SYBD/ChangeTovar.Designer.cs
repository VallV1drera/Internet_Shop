
namespace SYBD
{
    partial class ChangeTovar
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
            this.tovarNameTextBox = new System.Windows.Forms.TextBox();
            this.tovarIDComboBox = new System.Windows.Forms.ComboBox();
            this.tovarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.internet_shopDataSet20 = new SYBD.Internet_shopDataSet20();
            this.label4 = new System.Windows.Forms.Label();
            this.massTextBox = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tovarTableAdapter = new SYBD.Internet_shopDataSet20TableAdapters.tovarTableAdapter();
            this.opisTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.redButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internet_shopDataSet20)).BeginInit();
            this.SuspendLayout();
            // 
            // tovarNameTextBox
            // 
            this.tovarNameTextBox.Location = new System.Drawing.Point(120, 56);
            this.tovarNameTextBox.Name = "tovarNameTextBox";
            this.tovarNameTextBox.Size = new System.Drawing.Size(270, 20);
            this.tovarNameTextBox.TabIndex = 28;
            // 
            // tovarIDComboBox
            // 
            this.tovarIDComboBox.DataSource = this.tovarBindingSource;
            this.tovarIDComboBox.DisplayMember = "id";
            this.tovarIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tovarIDComboBox.FormattingEnabled = true;
            this.tovarIDComboBox.Location = new System.Drawing.Point(120, 19);
            this.tovarIDComboBox.Name = "tovarIDComboBox";
            this.tovarIDComboBox.Size = new System.Drawing.Size(51, 21);
            this.tovarIDComboBox.TabIndex = 27;
            this.tovarIDComboBox.ValueMember = "id";
            // 
            // tovarBindingSource
            // 
            this.tovarBindingSource.DataMember = "tovar";
            this.tovarBindingSource.DataSource = this.internet_shopDataSet20;
            // 
            // internet_shopDataSet20
            // 
            this.internet_shopDataSet20.DataSetName = "Internet_shopDataSet20";
            this.internet_shopDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Выберите ID";
            // 
            // massTextBox
            // 
            this.massTextBox.AutoSize = true;
            this.massTextBox.Location = new System.Drawing.Point(12, 170);
            this.massTextBox.Name = "massTextBox";
            this.massTextBox.Size = new System.Drawing.Size(29, 13);
            this.massTextBox.TabIndex = 25;
            this.massTextBox.Text = "Вес:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Описание:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Название:";
            // 
            // tovarTableAdapter
            // 
            this.tovarTableAdapter.ClearBeforeFill = true;
            // 
            // opisTextBox
            // 
            this.opisTextBox.Location = new System.Drawing.Point(120, 92);
            this.opisTextBox.Multiline = true;
            this.opisTextBox.Name = "opisTextBox";
            this.opisTextBox.Size = new System.Drawing.Size(270, 55);
            this.opisTextBox.TabIndex = 34;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(43, 20);
            this.textBox1.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "кг";
            // 
            // redButton
            // 
            this.redButton.Location = new System.Drawing.Point(157, 208);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(96, 23);
            this.redButton.TabIndex = 37;
            this.redButton.Text = "Редактировать";
            this.redButton.UseVisualStyleBackColor = true;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // ChangeTovar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 260);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.opisTextBox);
            this.Controls.Add(this.tovarNameTextBox);
            this.Controls.Add(this.tovarIDComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.massTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangeTovar";
            this.Text = "ChangeTovar";
            this.Load += new System.EventHandler(this.ChangeTovar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internet_shopDataSet20)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tovarNameTextBox;
        private System.Windows.Forms.ComboBox tovarIDComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label massTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Internet_shopDataSet20 internet_shopDataSet20;
        private System.Windows.Forms.BindingSource tovarBindingSource;
        private Internet_shopDataSet20TableAdapters.tovarTableAdapter tovarTableAdapter;
        private System.Windows.Forms.TextBox opisTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button redButton;
    }
}