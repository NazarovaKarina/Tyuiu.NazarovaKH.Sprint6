namespace Tyuiu.NazarovaKH.Sprint6.Task4.V16
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            panelVerx_NKH = new Panel();
            buttonSms_NKH = new Button();
            buttonSave_NKH = new Button();
            buttonOtvet_NKH = new Button();
            groupBoxVar_NKH = new GroupBox();
            labelStop_NKH = new Label();
            labelStart_NKH = new Label();
            textBoxStop_NKH = new TextBox();
            textBoxStart_NKH = new TextBox();
            groupBoxTask_NKH = new GroupBox();
            textBoxTask_NKH = new TextBox();
            panelLeft_NKH = new Panel();
            groupBoxRes_NKH = new GroupBox();
            textBoxRes_NKH = new TextBox();
            splitter1 = new Splitter();
            panelCenter_NKH = new Panel();
            chartFun_NKH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelVerx_NKH.SuspendLayout();
            groupBoxVar_NKH.SuspendLayout();
            groupBoxTask_NKH.SuspendLayout();
            panelLeft_NKH.SuspendLayout();
            groupBoxRes_NKH.SuspendLayout();
            panelCenter_NKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFun_NKH).BeginInit();
            SuspendLayout();
            // 
            // panelVerx_NKH
            // 
            panelVerx_NKH.Controls.Add(buttonSms_NKH);
            panelVerx_NKH.Controls.Add(buttonSave_NKH);
            panelVerx_NKH.Controls.Add(buttonOtvet_NKH);
            panelVerx_NKH.Controls.Add(groupBoxVar_NKH);
            panelVerx_NKH.Controls.Add(groupBoxTask_NKH);
            panelVerx_NKH.Dock = DockStyle.Top;
            panelVerx_NKH.Location = new Point(0, 0);
            panelVerx_NKH.Name = "panelVerx_NKH";
            panelVerx_NKH.Size = new Size(982, 99);
            panelVerx_NKH.TabIndex = 0;
            // 
            // buttonSms_NKH
            // 
            buttonSms_NKH.BackColor = SystemColors.MenuHighlight;
            buttonSms_NKH.Location = new Point(899, 12);
            buttonSms_NKH.Name = "buttonSms_NKH";
            buttonSms_NKH.Size = new Size(78, 81);
            buttonSms_NKH.TabIndex = 4;
            buttonSms_NKH.Text = "Справка";
            buttonSms_NKH.UseVisualStyleBackColor = false;
            buttonSms_NKH.Click += buttonSms_NKH_Click;
            // 
            // buttonSave_NKH
            // 
            buttonSave_NKH.BackColor = Color.Brown;
            buttonSave_NKH.Location = new Point(777, 12);
            buttonSave_NKH.Name = "buttonSave_NKH";
            buttonSave_NKH.Size = new Size(116, 40);
            buttonSave_NKH.TabIndex = 3;
            buttonSave_NKH.Text = "Сохранить";
            buttonSave_NKH.UseVisualStyleBackColor = false;
            buttonSave_NKH.Click += buttonSave_NKH_Click;
            // 
            // buttonOtvet_NKH
            // 
            buttonOtvet_NKH.BackColor = Color.DarkGreen;
            buttonOtvet_NKH.Location = new Point(777, 52);
            buttonOtvet_NKH.Name = "buttonOtvet_NKH";
            buttonOtvet_NKH.Size = new Size(116, 40);
            buttonOtvet_NKH.TabIndex = 2;
            buttonOtvet_NKH.Text = "Выполнить";
            buttonOtvet_NKH.UseVisualStyleBackColor = false;
            buttonOtvet_NKH.Click += buttonOtvet_NKH_Click;
            // 
            // groupBoxVar_NKH
            // 
            groupBoxVar_NKH.Controls.Add(labelStop_NKH);
            groupBoxVar_NKH.Controls.Add(labelStart_NKH);
            groupBoxVar_NKH.Controls.Add(textBoxStop_NKH);
            groupBoxVar_NKH.Controls.Add(textBoxStart_NKH);
            groupBoxVar_NKH.Location = new Point(502, 3);
            groupBoxVar_NKH.Name = "groupBoxVar_NKH";
            groupBoxVar_NKH.Size = new Size(269, 93);
            groupBoxVar_NKH.TabIndex = 1;
            groupBoxVar_NKH.TabStop = false;
            groupBoxVar_NKH.Text = "Ввод данных:";
            // 
            // labelStop_NKH
            // 
            labelStop_NKH.AutoSize = true;
            labelStop_NKH.Location = new Point(137, 37);
            labelStop_NKH.Name = "labelStop_NKH";
            labelStop_NKH.Size = new Size(94, 20);
            labelStop_NKH.TabIndex = 3;
            labelStop_NKH.Text = "Конец шага:";
            // 
            // labelStart_NKH
            // 
            labelStart_NKH.AutoSize = true;
            labelStart_NKH.Location = new Point(6, 37);
            labelStart_NKH.Name = "labelStart_NKH";
            labelStart_NKH.Size = new Size(88, 20);
            labelStart_NKH.TabIndex = 2;
            labelStart_NKH.Text = "Старт шага:";
            // 
            // textBoxStop_NKH
            // 
            textBoxStop_NKH.Location = new Point(137, 60);
            textBoxStop_NKH.Name = "textBoxStop_NKH";
            textBoxStop_NKH.Size = new Size(125, 27);
            textBoxStop_NKH.TabIndex = 1;
            textBoxStop_NKH.KeyPress += textBoxStop_NKH_KeyPress;
            // 
            // textBoxStart_NKH
            // 
            textBoxStart_NKH.Location = new Point(6, 60);
            textBoxStart_NKH.Name = "textBoxStart_NKH";
            textBoxStart_NKH.Size = new Size(125, 27);
            textBoxStart_NKH.TabIndex = 0;
            textBoxStart_NKH.KeyPress += textBoxStart_NKH_KeyPress;
            // 
            // groupBoxTask_NKH
            // 
            groupBoxTask_NKH.Controls.Add(textBoxTask_NKH);
            groupBoxTask_NKH.Location = new Point(3, 3);
            groupBoxTask_NKH.Name = "groupBoxTask_NKH";
            groupBoxTask_NKH.Size = new Size(493, 94);
            groupBoxTask_NKH.TabIndex = 0;
            groupBoxTask_NKH.TabStop = false;
            groupBoxTask_NKH.Text = "Условие:";
            // 
            // textBoxTask_NKH
            // 
            textBoxTask_NKH.Dock = DockStyle.Fill;
            textBoxTask_NKH.Location = new Point(3, 23);
            textBoxTask_NKH.Multiline = true;
            textBoxTask_NKH.Name = "textBoxTask_NKH";
            textBoxTask_NKH.ReadOnly = true;
            textBoxTask_NKH.Size = new Size(487, 68);
            textBoxTask_NKH.TabIndex = 0;
            textBoxTask_NKH.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5. Результат вывести в textBox, построить график функции и сохранить файл OutPutFileTask4V16.txt по нажатию кнопки.";
            // 
            // panelLeft_NKH
            // 
            panelLeft_NKH.Controls.Add(groupBoxRes_NKH);
            panelLeft_NKH.Dock = DockStyle.Left;
            panelLeft_NKH.Location = new Point(0, 99);
            panelLeft_NKH.Name = "panelLeft_NKH";
            panelLeft_NKH.Size = new Size(235, 401);
            panelLeft_NKH.TabIndex = 1;
            // 
            // groupBoxRes_NKH
            // 
            groupBoxRes_NKH.Controls.Add(textBoxRes_NKH);
            groupBoxRes_NKH.Dock = DockStyle.Fill;
            groupBoxRes_NKH.Location = new Point(0, 0);
            groupBoxRes_NKH.Name = "groupBoxRes_NKH";
            groupBoxRes_NKH.Size = new Size(235, 401);
            groupBoxRes_NKH.TabIndex = 0;
            groupBoxRes_NKH.TabStop = false;
            groupBoxRes_NKH.Text = "Вывод:";
            // 
            // textBoxRes_NKH
            // 
            textBoxRes_NKH.Dock = DockStyle.Fill;
            textBoxRes_NKH.Location = new Point(3, 23);
            textBoxRes_NKH.Multiline = true;
            textBoxRes_NKH.Name = "textBoxRes_NKH";
            textBoxRes_NKH.ScrollBars = ScrollBars.Vertical;
            textBoxRes_NKH.Size = new Size(229, 375);
            textBoxRes_NKH.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(235, 99);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 401);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // panelCenter_NKH
            // 
            panelCenter_NKH.Controls.Add(chartFun_NKH);
            panelCenter_NKH.Dock = DockStyle.Fill;
            panelCenter_NKH.Location = new Point(239, 99);
            panelCenter_NKH.Name = "panelCenter_NKH";
            panelCenter_NKH.Size = new Size(743, 401);
            panelCenter_NKH.TabIndex = 3;
            // 
            // chartFun_NKH
            // 
            chartArea2.Name = "ChartArea1";
            chartFun_NKH.ChartAreas.Add(chartArea2);
            chartFun_NKH.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            chartFun_NKH.Legends.Add(legend2);
            chartFun_NKH.Location = new Point(0, 0);
            chartFun_NKH.Name = "chartFun_NKH";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartFun_NKH.Series.Add(series2);
            chartFun_NKH.Size = new Size(743, 401);
            chartFun_NKH.TabIndex = 0;
            chartFun_NKH.Text = "chart1";
            title2.Name = "TitleSin";
            title2.Text = "График функции sin(x)";
            chartFun_NKH.Titles.Add(title2);
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 500);
            Controls.Add(panelCenter_NKH);
            Controls.Add(splitter1);
            Controls.Add(panelLeft_NKH);
            Controls.Add(panelVerx_NKH);
            MinimumSize = new Size(800, 450);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 16 | Назарова К.Х";
            panelVerx_NKH.ResumeLayout(false);
            groupBoxVar_NKH.ResumeLayout(false);
            groupBoxVar_NKH.PerformLayout();
            groupBoxTask_NKH.ResumeLayout(false);
            groupBoxTask_NKH.PerformLayout();
            panelLeft_NKH.ResumeLayout(false);
            groupBoxRes_NKH.ResumeLayout(false);
            groupBoxRes_NKH.PerformLayout();
            panelCenter_NKH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFun_NKH).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelVerx_NKH;
        private Panel panelLeft_NKH;
        private Splitter splitter1;
        private Panel panelCenter_NKH;
        private GroupBox groupBoxRes_NKH;
        private TextBox textBoxRes_NKH;
        private GroupBox groupBoxTask_NKH;
        private TextBox textBoxTask_NKH;
        private GroupBox groupBoxVar_NKH;
        private TextBox textBoxStart_NKH;
        private TextBox textBoxStop_NKH;
        private Button buttonOtvet_NKH;
        private Label labelStop_NKH;
        private Label labelStart_NKH;
        private Button buttonSave_NKH;
        private Button buttonSms_NKH;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFun_NKH;
    }
}
