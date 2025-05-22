namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoadButton = new Button();
            SaveButton = new Button();
            YearFilterButton = new Button();
            dataGridView1 = new DataGridView();
            YearTextBox = new TextBox();
            textBox2 = new TextBox();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // LoadButton
            // 
            LoadButton.Location = new Point(12, 12);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(75, 23);
            LoadButton.TabIndex = 0;
            LoadButton.Text = "Загрузка";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += LoadButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(93, 12);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(83, 23);
            SaveButton.TabIndex = 1;
            SaveButton.Text = "Сохранение";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // YearFilterButton
            // 
            YearFilterButton.Location = new Point(128, 61);
            YearFilterButton.Name = "YearFilterButton";
            YearFilterButton.Size = new Size(142, 23);
            YearFilterButton.TabIndex = 4;
            YearFilterButton.Text = "Отсортировать по году";
            YearFilterButton.UseVisualStyleBackColor = true;
            YearFilterButton.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 173);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(536, 217);
            dataGridView1.TabIndex = 5;
            // 
            // YearTextBox
            // 
            YearTextBox.Location = new Point(12, 61);
            YearTextBox.Name = "YearTextBox";
            YearTextBox.Size = new Size(100, 23);
            YearTextBox.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 7;
            // 
            // button4
            // 
            button4.Location = new Point(128, 112);
            button4.Name = "button4";
            button4.Size = new Size(195, 23);
            button4.TabIndex = 8;
            button4.Text = "Минимальная по размеру книга";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 9;
            label1.Text = "Год";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 94);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 10;
            label2.Text = "Автор";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 395);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(textBox2);
            Controls.Add(YearTextBox);
            Controls.Add(dataGridView1);
            Controls.Add(YearFilterButton);
            Controls.Add(SaveButton);
            Controls.Add(LoadButton);
            Name = "Form1";
            Text = "Форма";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button LoadButton;
        private Button SaveButton;
        private Button YearFilterButton;
        private DataGridView dataGridView1;
        private TextBox YearTextBox;
        private TextBox textBox2;
        private Button button4;
        private Label label1;
        private Label label2;
    }
}
