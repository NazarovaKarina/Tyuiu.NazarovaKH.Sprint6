namespace Tyuiu.NazarovaKH.Sprint6.Task2.V17
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
            textBoxTask_NKH = new TextBox();
            groupBoxVar_NKH = new GroupBox();
            labelStop_NKH = new Label();
            labelStart_NKH = new Label();
            textBoxStop_NKH = new TextBox();
            textBoxStart_NKH = new TextBox();
            buttonSms_NKH = new Button();
            buttonOtvet_NKH = new Button();
            groupBoxRes_NKH = new GroupBox();
            dataGridViewRes_NKH = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            labelRes_NKH = new Label();
            pictureBoxGraf_NKH = new PictureBox();
            groupBoxTask_NKH.SuspendLayout();
            groupBoxVar_NKH.SuspendLayout();
            groupBoxRes_NKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_NKH).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGraf_NKH).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_NKH
            // 
            groupBoxTask_NKH.Controls.Add(textBoxTask_NKH);
            groupBoxTask_NKH.Location = new Point(12, 12);
            groupBoxTask_NKH.Name = "groupBoxTask_NKH";
            groupBoxTask_NKH.Size = new Size(484, 252);
            groupBoxTask_NKH.TabIndex = 0;
            groupBoxTask_NKH.TabStop = false;
            groupBoxTask_NKH.Text = "Условие";
            // 
            // textBoxTask_NKH
            // 
            textBoxTask_NKH.Location = new Point(1, 26);
            textBoxTask_NKH.Multiline = true;
            textBoxTask_NKH.Name = "textBoxTask_NKH";
            textBoxTask_NKH.ReadOnly = true;
            textBoxTask_NKH.Size = new Size(483, 53);
            textBoxTask_NKH.TabIndex = 1;
            textBoxTask_NKH.Text = "Протабулировать функцию sin(x) на заданном диапазоне. Результат вывести в DataGridView и построить график функции.";
            // 
            // groupBoxVar_NKH
            // 
            groupBoxVar_NKH.Controls.Add(labelStop_NKH);
            groupBoxVar_NKH.Controls.Add(labelStart_NKH);
            groupBoxVar_NKH.Controls.Add(textBoxStop_NKH);
            groupBoxVar_NKH.Controls.Add(textBoxStart_NKH);
            groupBoxVar_NKH.Location = new Point(12, 270);
            groupBoxVar_NKH.Name = "groupBoxVar_NKH";
            groupBoxVar_NKH.Size = new Size(291, 77);
            groupBoxVar_NKH.TabIndex = 1;
            groupBoxVar_NKH.TabStop = false;
            groupBoxVar_NKH.Text = "Ввод данных";
            // 
            // labelStop_NKH
            // 
            labelStop_NKH.AutoSize = true;
            labelStop_NKH.Location = new Point(160, 21);
            labelStop_NKH.Name = "labelStop_NKH";
            labelStop_NKH.Size = new Size(94, 20);
            labelStop_NKH.TabIndex = 3;
            labelStop_NKH.Text = "Конец шага:";
            // 
            // labelStart_NKH
            // 
            labelStart_NKH.AutoSize = true;
            labelStart_NKH.Location = new Point(6, 21);
            labelStart_NKH.Name = "labelStart_NKH";
            labelStart_NKH.Size = new Size(88, 20);
            labelStart_NKH.TabIndex = 2;
            labelStart_NKH.Text = "Старт шага:";
            // 
            // textBoxStop_NKH
            // 
            textBoxStop_NKH.Location = new Point(160, 44);
            textBoxStop_NKH.Name = "textBoxStop_NKH";
            textBoxStop_NKH.Size = new Size(125, 27);
            textBoxStop_NKH.TabIndex = 1;
            textBoxStop_NKH.KeyPress += textBoxStop_NKH_KeyPress;
            // 
            // textBoxStart_NKH
            // 
            textBoxStart_NKH.Location = new Point(6, 44);
            textBoxStart_NKH.Name = "textBoxStart_NKH";
            textBoxStart_NKH.Size = new Size(125, 27);
            textBoxStart_NKH.TabIndex = 0;
            textBoxStart_NKH.KeyPress += textBoxStart_NKH_KeyPress;
            // 
            // buttonSms_NKH
            // 
            buttonSms_NKH.BackColor = Color.DodgerBlue;
            buttonSms_NKH.Location = new Point(309, 291);
            buttonSms_NKH.Name = "buttonSms_NKH";
            buttonSms_NKH.Size = new Size(81, 56);
            buttonSms_NKH.TabIndex = 2;
            buttonSms_NKH.Text = "Справка";
            buttonSms_NKH.UseVisualStyleBackColor = false;
            buttonSms_NKH.Click += buttonSms_NKH_Click;
            // 
            // buttonOtvet_NKH
            // 
            buttonOtvet_NKH.BackColor = Color.SeaGreen;
            buttonOtvet_NKH.Location = new Point(387, 291);
            buttonOtvet_NKH.Name = "buttonOtvet_NKH";
            buttonOtvet_NKH.Size = new Size(109, 56);
            buttonOtvet_NKH.TabIndex = 3;
            buttonOtvet_NKH.Text = "Выполнить";
            buttonOtvet_NKH.UseVisualStyleBackColor = false;
            buttonOtvet_NKH.Click += buttonOtvet_NKH_Click;
            // 
            // groupBoxRes_NKH
            // 
            groupBoxRes_NKH.Controls.Add(pictureBoxGraf_NKH);
            groupBoxRes_NKH.Controls.Add(dataGridViewRes_NKH);
            groupBoxRes_NKH.Controls.Add(labelRes_NKH);
            groupBoxRes_NKH.Location = new Point(502, 12);
            groupBoxRes_NKH.Name = "groupBoxRes_NKH";
            groupBoxRes_NKH.Size = new Size(486, 335);
            groupBoxRes_NKH.TabIndex = 4;
            groupBoxRes_NKH.TabStop = false;
            groupBoxRes_NKH.Text = "Вывод данных";
            // 
            // dataGridViewRes_NKH
            // 
            dataGridViewRes_NKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRes_NKH.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewRes_NKH.Location = new Point(6, 46);
            dataGridViewRes_NKH.Name = "dataGridViewRes_NKH";
            dataGridViewRes_NKH.RowHeadersVisible = false;
            dataGridViewRes_NKH.RowHeadersWidth = 51;
            dataGridViewRes_NKH.Size = new Size(120, 283);
            dataGridViewRes_NKH.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "X";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 60;
            // 
            // Column2
            // 
            Column2.HeaderText = "F(X)";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 60;
            // 
            // labelRes_NKH
            // 
            labelRes_NKH.AutoSize = true;
            labelRes_NKH.Location = new Point(6, 23);
            labelRes_NKH.Name = "labelRes_NKH";
            labelRes_NKH.Size = new Size(78, 20);
            labelRes_NKH.TabIndex = 0;
            labelRes_NKH.Text = "Результат:";
            // 
            // pictureBoxGraf_NKH
            // 
            pictureBoxGraf_NKH.Location = new Point(157, 46);
            pictureBoxGraf_NKH.Name = "pictureBoxGraf_NKH";
            pictureBoxGraf_NKH.Size = new Size(303, 283);
            pictureBoxGraf_NKH.TabIndex = 2;
            pictureBoxGraf_NKH.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 359);
            Controls.Add(groupBoxRes_NKH);
            Controls.Add(buttonOtvet_NKH);
            Controls.Add(buttonSms_NKH);
            Controls.Add(groupBoxVar_NKH);
            Controls.Add(groupBoxTask_NKH);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 17 | Назарова К.Х.";
            groupBoxTask_NKH.ResumeLayout(false);
            groupBoxTask_NKH.PerformLayout();
            groupBoxVar_NKH.ResumeLayout(false);
            groupBoxVar_NKH.PerformLayout();
            groupBoxRes_NKH.ResumeLayout(false);
            groupBoxRes_NKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_NKH).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGraf_NKH).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_NKH;
        private TextBox textBoxTask_NKH;
        private GroupBox groupBoxVar_NKH;
        private TextBox textBoxStart_NKH;
        private TextBox textBoxStop_NKH;
        private Label labelStop_NKH;
        private Label labelStart_NKH;
        private Button buttonSms_NKH;
        private Button buttonOtvet_NKH;
        private GroupBox groupBoxRes_NKH;
        private Label labelRes_NKH;
        private DataGridView dataGridViewRes_NKH;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private PictureBox pictureBoxGraf_NKH;
    }
}
