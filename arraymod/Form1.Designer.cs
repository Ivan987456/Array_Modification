
namespace ArrayMod
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buildButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rndButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.YComboBox = new System.Windows.Forms.ComboBox();
            this.XComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rowComboBox = new System.Windows.Forms.ComboBox();
            this.columnComboBox = new System.Windows.Forms.ComboBox();
            this.rowRadioButton = new System.Windows.Forms.RadioButton();
            this.ColumnRadioButton = new System.Windows.Forms.RadioButton();
            this.sumDiagButton = new System.Windows.Forms.Button();
            this.sumMainDiagTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.productSideDiagTextBox = new System.Windows.Forms.TextBox();
            this.sumSideDiagTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.productMainDiagTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buildButton
            // 
            this.buildButton.Location = new System.Drawing.Point(9, 48);
            this.buildButton.Name = "buildButton";
            this.buildButton.Size = new System.Drawing.Size(145, 23);
            this.buildButton.TabIndex = 0;
            this.buildButton.Text = "Построить";
            this.buildButton.UseVisualStyleBackColor = true;
            this.buildButton.Click += new System.EventHandler(this.buildButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.Size = new System.Drawing.Size(475, 476);
            this.dataGridView1.TabIndex = 1;
            // 
            // rndButton
            // 
            this.rndButton.Location = new System.Drawing.Point(9, 77);
            this.rndButton.Name = "rndButton";
            this.rndButton.Size = new System.Drawing.Size(145, 23);
            this.rndButton.TabIndex = 4;
            this.rndButton.Text = "Случайные числа";
            this.rndButton.UseVisualStyleBackColor = true;
            this.rndButton.Click += new System.EventHandler(this.rndButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(9, 92);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(145, 23);
            this.sortButton.TabIndex = 5;
            this.sortButton.Text = "Сортировать";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(20, 69);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(122, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Обратный порядок";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.YComboBox);
            this.groupBox1.Controls.Add(this.XComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buildButton);
            this.groupBox1.Controls.Add(this.rndButton);
            this.groupBox1.Location = new System.Drawing.Point(478, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 109);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создание и заполнение";
            // 
            // YComboBox
            // 
            this.YComboBox.FormattingEnabled = true;
            this.YComboBox.Items.AddRange(new object[] {
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
            "20"});
            this.YComboBox.Location = new System.Drawing.Point(114, 22);
            this.YComboBox.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.YComboBox.Name = "YComboBox";
            this.YComboBox.Size = new System.Drawing.Size(40, 21);
            this.YComboBox.TabIndex = 14;
            // 
            // XComboBox
            // 
            this.XComboBox.FormattingEnabled = true;
            this.XComboBox.Items.AddRange(new object[] {
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
            "20"});
            this.XComboBox.Location = new System.Drawing.Point(58, 22);
            this.XComboBox.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.XComboBox.Name = "XComboBox";
            this.XComboBox.Size = new System.Drawing.Size(40, 21);
            this.XComboBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "х";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Размер";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rowComboBox);
            this.groupBox2.Controls.Add(this.columnComboBox);
            this.groupBox2.Controls.Add(this.rowRadioButton);
            this.groupBox2.Controls.Add(this.ColumnRadioButton);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.sortButton);
            this.groupBox2.Location = new System.Drawing.Point(478, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(164, 124);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сортировка";
            // 
            // rowComboBox
            // 
            this.rowComboBox.FormattingEnabled = true;
            this.rowComboBox.Location = new System.Drawing.Point(93, 42);
            this.rowComboBox.Name = "rowComboBox";
            this.rowComboBox.Size = new System.Drawing.Size(61, 21);
            this.rowComboBox.TabIndex = 13;
            // 
            // columnComboBox
            // 
            this.columnComboBox.FormattingEnabled = true;
            this.columnComboBox.Location = new System.Drawing.Point(9, 42);
            this.columnComboBox.Name = "columnComboBox";
            this.columnComboBox.Size = new System.Drawing.Size(61, 21);
            this.columnComboBox.TabIndex = 12;
            // 
            // rowRadioButton
            // 
            this.rowRadioButton.AutoSize = true;
            this.rowRadioButton.Location = new System.Drawing.Point(93, 19);
            this.rowRadioButton.Name = "rowRadioButton";
            this.rowRadioButton.Size = new System.Drawing.Size(61, 17);
            this.rowRadioButton.TabIndex = 11;
            this.rowRadioButton.Text = "Строка";
            this.rowRadioButton.UseVisualStyleBackColor = true;
            // 
            // ColumnRadioButton
            // 
            this.ColumnRadioButton.AutoSize = true;
            this.ColumnRadioButton.Checked = true;
            this.ColumnRadioButton.Location = new System.Drawing.Point(9, 19);
            this.ColumnRadioButton.Name = "ColumnRadioButton";
            this.ColumnRadioButton.Size = new System.Drawing.Size(67, 17);
            this.ColumnRadioButton.TabIndex = 10;
            this.ColumnRadioButton.TabStop = true;
            this.ColumnRadioButton.Text = "Столбец";
            this.ColumnRadioButton.UseVisualStyleBackColor = true;
            // 
            // sumDiagButton
            // 
            this.sumDiagButton.Location = new System.Drawing.Point(9, 123);
            this.sumDiagButton.Name = "sumDiagButton";
            this.sumDiagButton.Size = new System.Drawing.Size(145, 23);
            this.sumDiagButton.TabIndex = 12;
            this.sumDiagButton.Text = "Вычислить";
            this.sumDiagButton.UseVisualStyleBackColor = true;
            this.sumDiagButton.Click += new System.EventHandler(this.sumDiagButton_Click);
            // 
            // sumMainDiagTextBox
            // 
            this.sumMainDiagTextBox.Location = new System.Drawing.Point(9, 45);
            this.sumMainDiagTextBox.Name = "sumMainDiagTextBox";
            this.sumMainDiagTextBox.ReadOnly = true;
            this.sumMainDiagTextBox.Size = new System.Drawing.Size(43, 20);
            this.sumMainDiagTextBox.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.productSideDiagTextBox);
            this.groupBox3.Controls.Add(this.sumSideDiagTextBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.productMainDiagTextBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.sumDiagButton);
            this.groupBox3.Controls.Add(this.sumMainDiagTextBox);
            this.groupBox3.Location = new System.Drawing.Point(478, 254);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(164, 155);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вычисление";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Произведение";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Сумма";
            // 
            // productSideDiagTextBox
            // 
            this.productSideDiagTextBox.Location = new System.Drawing.Point(58, 97);
            this.productSideDiagTextBox.Name = "productSideDiagTextBox";
            this.productSideDiagTextBox.ReadOnly = true;
            this.productSideDiagTextBox.Size = new System.Drawing.Size(96, 20);
            this.productSideDiagTextBox.TabIndex = 20;
            // 
            // sumSideDiagTextBox
            // 
            this.sumSideDiagTextBox.Location = new System.Drawing.Point(9, 97);
            this.sumSideDiagTextBox.Name = "sumSideDiagTextBox";
            this.sumSideDiagTextBox.ReadOnly = true;
            this.sumSideDiagTextBox.Size = new System.Drawing.Size(43, 20);
            this.sumSideDiagTextBox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Произведение";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Сумма";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Побочная диагональ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // productMainDiagTextBox
            // 
            this.productMainDiagTextBox.Location = new System.Drawing.Point(58, 45);
            this.productMainDiagTextBox.Name = "productMainDiagTextBox";
            this.productMainDiagTextBox.ReadOnly = true;
            this.productMainDiagTextBox.Size = new System.Drawing.Size(96, 20);
            this.productMainDiagTextBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Главная диагональ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 476);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Работа с массивом";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buildButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button rndButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button sumDiagButton;
        private System.Windows.Forms.TextBox sumMainDiagTextBox;
        private System.Windows.Forms.ComboBox XComboBox;
        private System.Windows.Forms.ComboBox YComboBox;
        private System.Windows.Forms.RadioButton rowRadioButton;
        private System.Windows.Forms.RadioButton ColumnRadioButton;
        private System.Windows.Forms.ComboBox rowComboBox;
        private System.Windows.Forms.ComboBox columnComboBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productMainDiagTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox productSideDiagTextBox;
        private System.Windows.Forms.TextBox sumSideDiagTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}

