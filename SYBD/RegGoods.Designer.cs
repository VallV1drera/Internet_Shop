
namespace SYBD
{
    partial class RegGoods
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
            this.regButton = new System.Windows.Forms.Button();
            this.massComboBox = new System.Windows.Forms.TextBox();
            this.opisComboBox = new System.Windows.Forms.TextBox();
            this.nameComboBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // regButton
            // 
            this.regButton.Location = new System.Drawing.Point(151, 184);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(116, 32);
            this.regButton.TabIndex = 16;
            this.regButton.Text = "Зарегистрировать";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // massComboBox
            // 
            this.massComboBox.Location = new System.Drawing.Point(174, 136);
            this.massComboBox.Name = "massComboBox";
            this.massComboBox.Size = new System.Drawing.Size(47, 20);
            this.massComboBox.TabIndex = 15;

            // 
            // opisComboBox
            // 
            this.opisComboBox.Location = new System.Drawing.Point(174, 62);
            this.opisComboBox.Multiline = true;
            this.opisComboBox.Name = "opisComboBox";
            this.opisComboBox.Size = new System.Drawing.Size(216, 58);
            this.opisComboBox.TabIndex = 14;

            // 
            // nameComboBox
            // 
            this.nameComboBox.Location = new System.Drawing.Point(174, 22);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(216, 20);
            this.nameComboBox.TabIndex = 13;

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Масса товара, кг:";

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Описание товара:";

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Название товара:";

            // 
            // RegGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 251);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.massComboBox);
            this.Controls.Add(this.opisComboBox);
            this.Controls.Add(this.nameComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegGoods";
            this.Text = "RegGoods";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.TextBox massComboBox;
        private System.Windows.Forms.TextBox opisComboBox;
        private System.Windows.Forms.TextBox nameComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}