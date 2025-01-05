
namespace Tyuiu.NazarovaKH.Sprint6.Task1.V3
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
            groupBoxTask_NKX = new GroupBox();
            textBoxTask_NKX = new TextBox();
            groupBoxVar_NKX = new GroupBox();
            textBoxStart_NKX = new TextBox();
            textBoxStop_NKX = new TextBox();
            labelStop = new Label();
            labelStart_NKX = new Label();
            groupBoxEnd_NKX = new GroupBox();
            textBoxResult_NKX = new TextBox();
            labelEnd_NKX = new Label();
            buttonSms_NKX = new Button();
            buttonOtvet_NKX = new Button();
            groupBoxTask_NKX.SuspendLayout();
            groupBoxVar_NKX.SuspendLayout();
            groupBoxEnd_NKX.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_NKX
            // 
            groupBoxTask_NKX.Controls.Add(textBoxTask_NKX);
            groupBoxTask_NKX.Location = new Point(33, 25);
            groupBoxTask_NKX.Name = "groupBoxTask_NKX";
            groupBoxTask_NKX.Size = new Size(580, 259);
            groupBoxTask_NKX.TabIndex = 0;
            groupBoxTask_NKX.TabStop = false;
            groupBoxTask_NKX.Text = "Условие";
            // 
            // textBoxTask_NKX
            // 
            textBoxTask_NKX.Location = new Point(6, 26);
            textBoxTask_NKX.Multiline = true;
            textBoxTask_NKX.Name = "textBoxTask_NKX";
            textBoxTask_NKX.ReadOnly = true;
            textBoxTask_NKX.Size = new Size(387, 49);
            textBoxTask_NKX.TabIndex = 0;
            textBoxTask_NKX.Text = "Протабулировать функцию на заданном диапазоне. Результат вывести в виде таблицы";
            // 
            // groupBoxVar_NKX
            // 
            groupBoxVar_NKX.Controls.Add(textBoxStart_NKX);
            groupBoxVar_NKX.Controls.Add(textBoxStop_NKX);
            groupBoxVar_NKX.Controls.Add(labelStop);
            groupBoxVar_NKX.Controls.Add(labelStart_NKX);
            groupBoxVar_NKX.Location = new Point(33, 299);
            groupBoxVar_NKX.Name = "groupBoxVar_NKX";
            groupBoxVar_NKX.Size = new Size(300, 92);
            groupBoxVar_NKX.TabIndex = 1;
            groupBoxVar_NKX.TabStop = false;
            groupBoxVar_NKX.Text = "Ввод данных";
            // 
            // textBoxStart_NKX
            // 
            textBoxStart_NKX.Location = new Point(6, 46);
            textBoxStart_NKX.Name = "textBoxStart_NKX";
            textBoxStart_NKX.Size = new Size(125, 27);
            textBoxStart_NKX.TabIndex = 4;
            textBoxStart_NKX.TextChanged += textBox1_TextChanged;
            textBoxStart_NKX.KeyPress += textBoxStart_NKX_KeyPress;
            // 
            // textBoxStop_NKX
            // 
            textBoxStop_NKX.Location = new Point(154, 46);
            textBoxStop_NKX.Name = "textBoxStop_NKX";
            textBoxStop_NKX.Size = new Size(125, 27);
            textBoxStop_NKX.TabIndex = 3;
            textBoxStop_NKX.KeyPress += textBoxStop_NKX_KeyPress;
            // 
            // labelStop
            // 
            labelStop.AutoSize = true;
            labelStop.Location = new Point(154, 23);
            labelStop.Name = "labelStop";
            labelStop.Size = new Size(94, 20);
            labelStop.TabIndex = 1;
            labelStop.Text = "Конец шага:";
            // 
            // labelStart_NKX
            // 
            labelStart_NKX.AutoSize = true;
            labelStart_NKX.Location = new Point(6, 23);
            labelStart_NKX.Name = "labelStart_NKX";
            labelStart_NKX.Size = new Size(88, 20);
            labelStart_NKX.TabIndex = 0;
            labelStart_NKX.Text = "Старт шага:";
            // 
            // groupBoxEnd_NKX
            // 
            groupBoxEnd_NKX.Controls.Add(textBoxResult_NKX);
            groupBoxEnd_NKX.Controls.Add(labelEnd_NKX);
            groupBoxEnd_NKX.Location = new Point(619, 25);
            groupBoxEnd_NKX.Name = "groupBoxEnd_NKX";
            groupBoxEnd_NKX.Size = new Size(301, 366);
            groupBoxEnd_NKX.TabIndex = 2;
            groupBoxEnd_NKX.TabStop = false;
            groupBoxEnd_NKX.Text = "Вывод данных";
            // 
            // textBoxResult_NKX
            // 
            textBoxResult_NKX.Location = new Point(6, 46);
            textBoxResult_NKX.Multiline = true;
            textBoxResult_NKX.Name = "textBoxResult_NKX";
            textBoxResult_NKX.Size = new Size(289, 314);
            textBoxResult_NKX.TabIndex = 1;
            // 
            // labelEnd_NKX
            // 
            labelEnd_NKX.AutoSize = true;
            labelEnd_NKX.Location = new Point(6, 23);
            labelEnd_NKX.Name = "labelEnd_NKX";
            labelEnd_NKX.Size = new Size(78, 20);
            labelEnd_NKX.TabIndex = 0;
            labelEnd_NKX.Text = "Результат:";
            // 
            // buttonSms_NKX
            // 
            buttonSms_NKX.BackColor = Color.CornflowerBlue;
            buttonSms_NKX.Location = new Point(339, 307);
            buttonSms_NKX.Name = "buttonSms_NKX";
            buttonSms_NKX.Size = new Size(98, 84);
            buttonSms_NKX.TabIndex = 3;
            buttonSms_NKX.Text = "Справка";
            buttonSms_NKX.UseVisualStyleBackColor = false;
            buttonSms_NKX.Click += buttonSms_NKX_Click;
            // 
            // buttonOtvet_NKX
            // 
            buttonOtvet_NKX.BackColor = Color.SeaGreen;
            buttonOtvet_NKX.Location = new Point(443, 307);
            buttonOtvet_NKX.Name = "buttonOtvet_NKX";
            buttonOtvet_NKX.Size = new Size(170, 84);
            buttonOtvet_NKX.TabIndex = 4;
            buttonOtvet_NKX.Text = "Выполнить";
            buttonOtvet_NKX.UseVisualStyleBackColor = false;
            buttonOtvet_NKX.Click += buttonOtvet_NKX_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 403);
            Controls.Add(buttonOtvet_NKX);
            Controls.Add(buttonSms_NKX);
            Controls.Add(groupBoxEnd_NKX);
            Controls.Add(groupBoxVar_NKX);
            Controls.Add(groupBoxTask_NKX);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 3 | Назарова К.Х.";
            Load += FormMain_Load;
            groupBoxTask_NKX.ResumeLayout(false);
            groupBoxTask_NKX.PerformLayout();
            groupBoxVar_NKX.ResumeLayout(false);
            groupBoxVar_NKX.PerformLayout();
            groupBoxEnd_NKX.ResumeLayout(false);
            groupBoxEnd_NKX.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_NKX;
        private TextBox textBoxTask_NKX;
        private GroupBox groupBoxVar_NKX;
        private TextBox textBoxStart_NKX;
        private TextBox textBoxStop_NKX;
        private Label labelStop;
        private Label labelStart_NKX;
        private GroupBox groupBoxEnd_NKX;
        private Label labelEnd_NKX;
        private Button buttonSms_NKX;
        private Button buttonOtvet_NKX;
        private TextBox textBoxResult_NKX;
    }
}
