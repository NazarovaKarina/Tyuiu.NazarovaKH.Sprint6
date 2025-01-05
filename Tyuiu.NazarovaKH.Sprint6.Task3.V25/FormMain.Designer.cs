namespace Tyuiu.NazarovaKH.Sprint6.Task3.V25
{
    partial class FormMain
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
            groupBoxTask_NKH = new GroupBox();
            dataGridViewRes_NKH = new DataGridView();
            textBoxTask_NKH = new TextBox();
            groupBoxRes_NKH = new GroupBox();
            labelRes_NKH = new Label();
            textBoxRes_NKH = new TextBox();
            buttonSms_NKH = new Button();
            buttonOtvet_NKH = new Button();
            groupBoxTask_NKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_NKH).BeginInit();
            groupBoxRes_NKH.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_NKH
            // 
            groupBoxTask_NKH.Controls.Add(dataGridViewRes_NKH);
            groupBoxTask_NKH.Controls.Add(textBoxTask_NKH);
            groupBoxTask_NKH.Location = new Point(12, 12);
            groupBoxTask_NKH.Name = "groupBoxTask_NKH";
            groupBoxTask_NKH.Size = new Size(674, 295);
            groupBoxTask_NKH.TabIndex = 0;
            groupBoxTask_NKH.TabStop = false;
            groupBoxTask_NKH.Text = "Условие";
            // 
            // dataGridViewRes_NKH
            // 
            dataGridViewRes_NKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRes_NKH.Location = new Point(403, 26);
            dataGridViewRes_NKH.Name = "dataGridViewRes_NKH";
            dataGridViewRes_NKH.RowHeadersVisible = false;
            dataGridViewRes_NKH.RowHeadersWidth = 51;
            dataGridViewRes_NKH.Size = new Size(265, 263);
            dataGridViewRes_NKH.TabIndex = 1;
            // 
            // textBoxTask_NKH
            // 
            textBoxTask_NKH.Location = new Point(6, 26);
            textBoxTask_NKH.Multiline = true;
            textBoxTask_NKH.Name = "textBoxTask_NKH";
            textBoxTask_NKH.ReadOnly = true;
            textBoxTask_NKH.Size = new Size(391, 263);
            textBoxTask_NKH.TabIndex = 0;
            textBoxTask_NKH.Text = "Дана матрица 5 на 5 \r\n 14   5  -9  18  21\r\n-5 -12 -12   4  28\r\n 27  -2 -14  23  27\r\n-19 -15  17  15   1\r\n 33   2   6  24  24\r\nВыполнить сортировку по возрастанию в 3 столбце.";
            // 
            // groupBoxRes_NKH
            // 
            groupBoxRes_NKH.Controls.Add(labelRes_NKH);
            groupBoxRes_NKH.Controls.Add(textBoxRes_NKH);
            groupBoxRes_NKH.Location = new Point(692, 12);
            groupBoxRes_NKH.Name = "groupBoxRes_NKH";
            groupBoxRes_NKH.Size = new Size(166, 91);
            groupBoxRes_NKH.TabIndex = 1;
            groupBoxRes_NKH.TabStop = false;
            groupBoxRes_NKH.Text = "Вывод данных";
            // 
            // labelRes_NKH
            // 
            labelRes_NKH.AutoSize = true;
            labelRes_NKH.Location = new Point(6, 23);
            labelRes_NKH.Name = "labelRes_NKH";
            labelRes_NKH.Size = new Size(78, 20);
            labelRes_NKH.TabIndex = 1;
            labelRes_NKH.Text = "Результат:";
            // 
            // textBoxRes_NKH
            // 
            textBoxRes_NKH.Location = new Point(6, 43);
            textBoxRes_NKH.Name = "textBoxRes_NKH";
            textBoxRes_NKH.Size = new Size(125, 27);
            textBoxRes_NKH.TabIndex = 0;
            textBoxRes_NKH.TextChanged += textBox1_TextChanged;
            // 
            // buttonSms_NKH
            // 
            buttonSms_NKH.Location = new Point(692, 264);
            buttonSms_NKH.Name = "buttonSms_NKH";
            buttonSms_NKH.Size = new Size(49, 43);
            buttonSms_NKH.TabIndex = 2;
            buttonSms_NKH.Text = "?";
            buttonSms_NKH.UseVisualStyleBackColor = true;
            buttonSms_NKH.Click += buttonSms_NKH_Click;
            // 
            // buttonOtvet_NKH
            // 
            buttonOtvet_NKH.Location = new Point(747, 264);
            buttonOtvet_NKH.Name = "buttonOtvet_NKH";
            buttonOtvet_NKH.Size = new Size(113, 43);
            buttonOtvet_NKH.TabIndex = 3;
            buttonOtvet_NKH.Text = "Выполнить";
            buttonOtvet_NKH.UseVisualStyleBackColor = true;
            buttonOtvet_NKH.Click += buttonOtvet_NKH_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 319);
            Controls.Add(buttonOtvet_NKH);
            Controls.Add(buttonSms_NKH);
            Controls.Add(groupBoxRes_NKH);
            Controls.Add(groupBoxTask_NKH);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 25 | Назарова К.Х.";
            Load += FormMain_Load;
            groupBoxTask_NKH.ResumeLayout(false);
            groupBoxTask_NKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_NKH).EndInit();
            groupBoxRes_NKH.ResumeLayout(false);
            groupBoxRes_NKH.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_NKH;
        private TextBox textBoxTask_NKH;
        private DataGridView dataGridViewRes_NKH;
        private GroupBox groupBoxRes_NKH;
        private TextBox textBoxRes_NKH;
        private Label labelRes_NKH;
        private Button buttonSms_NKH;
        private Button buttonOtvet_NKH;
    }
}
