namespace Tyuiu.NazarovaKH.Sprint6.Task5.V10
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelUp_NKH = new Panel();
            buttonSms_NKH = new Button();
            buttonFile_NKH = new Button();
            buttonOtvet_NKH = new Button();
            groupBoxTask_NKH = new GroupBox();
            textBoxTask_NKH = new TextBox();
            panelLeft_NKH = new Panel();
            groupBoxRes_NKH = new GroupBox();
            panelCent_NKH = new Panel();
            splitter1 = new Splitter();
            chartFun_NKH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewRes_NKH = new DataGridView();
            panelUp_NKH.SuspendLayout();
            groupBoxTask_NKH.SuspendLayout();
            panelLeft_NKH.SuspendLayout();
            groupBoxRes_NKH.SuspendLayout();
            panelCent_NKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFun_NKH).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_NKH).BeginInit();
            SuspendLayout();
            // 
            // panelUp_NKH
            // 
            panelUp_NKH.Controls.Add(buttonSms_NKH);
            panelUp_NKH.Controls.Add(buttonFile_NKH);
            panelUp_NKH.Controls.Add(buttonOtvet_NKH);
            panelUp_NKH.Controls.Add(groupBoxTask_NKH);
            panelUp_NKH.Dock = DockStyle.Top;
            panelUp_NKH.Location = new Point(0, 0);
            panelUp_NKH.Name = "panelUp_NKH";
            panelUp_NKH.Size = new Size(853, 111);
            panelUp_NKH.TabIndex = 0;
            // 
            // buttonSms_NKH
            // 
            buttonSms_NKH.BackColor = SystemColors.ActiveCaption;
            buttonSms_NKH.Location = new Point(707, 12);
            buttonSms_NKH.Name = "buttonSms_NKH";
            buttonSms_NKH.Size = new Size(141, 88);
            buttonSms_NKH.TabIndex = 3;
            buttonSms_NKH.Text = "Справка";
            buttonSms_NKH.UseVisualStyleBackColor = false;
            buttonSms_NKH.Click += buttonSms_NKH_Click;
            // 
            // buttonFile_NKH
            // 
            buttonFile_NKH.BackColor = Color.SteelBlue;
            buttonFile_NKH.Location = new Point(560, 12);
            buttonFile_NKH.Name = "buttonFile_NKH";
            buttonFile_NKH.Size = new Size(141, 88);
            buttonFile_NKH.TabIndex = 2;
            buttonFile_NKH.Text = "Открыть файл";
            buttonFile_NKH.UseVisualStyleBackColor = false;
            buttonFile_NKH.Click += buttonFile_NKH_Click;
            // 
            // buttonOtvet_NKH
            // 
            buttonOtvet_NKH.BackColor = Color.SeaGreen;
            buttonOtvet_NKH.Location = new Point(413, 12);
            buttonOtvet_NKH.Name = "buttonOtvet_NKH";
            buttonOtvet_NKH.Size = new Size(141, 88);
            buttonOtvet_NKH.TabIndex = 1;
            buttonOtvet_NKH.Text = "Выполнить";
            buttonOtvet_NKH.UseVisualStyleBackColor = false;
            buttonOtvet_NKH.Click += buttonOtvet_NKH_Click;
            // 
            // groupBoxTask_NKH
            // 
            groupBoxTask_NKH.Controls.Add(textBoxTask_NKH);
            groupBoxTask_NKH.Location = new Point(3, 3);
            groupBoxTask_NKH.Name = "groupBoxTask_NKH";
            groupBoxTask_NKH.Size = new Size(407, 97);
            groupBoxTask_NKH.TabIndex = 0;
            groupBoxTask_NKH.TabStop = false;
            groupBoxTask_NKH.Text = "Условие";
            // 
            // textBoxTask_NKH
            // 
            textBoxTask_NKH.Dock = DockStyle.Fill;
            textBoxTask_NKH.Location = new Point(3, 23);
            textBoxTask_NKH.Multiline = true;
            textBoxTask_NKH.Name = "textBoxTask_NKH";
            textBoxTask_NKH.ReadOnly = true;
            textBoxTask_NKH.Size = new Size(401, 71);
            textBoxTask_NKH.TabIndex = 0;
            textBoxTask_NKH.Text = "Прочитать данные из файла InPutDataFileTask5V10.txt. Вывести в DataGridView положительные значения и построить диаграмму по этим значениям. ";
            // 
            // panelLeft_NKH
            // 
            panelLeft_NKH.Controls.Add(groupBoxRes_NKH);
            panelLeft_NKH.Dock = DockStyle.Left;
            panelLeft_NKH.Location = new Point(0, 111);
            panelLeft_NKH.Name = "panelLeft_NKH";
            panelLeft_NKH.Size = new Size(250, 344);
            panelLeft_NKH.TabIndex = 1;
            // 
            // groupBoxRes_NKH
            // 
            groupBoxRes_NKH.Controls.Add(dataGridViewRes_NKH);
            groupBoxRes_NKH.Dock = DockStyle.Fill;
            groupBoxRes_NKH.Location = new Point(0, 0);
            groupBoxRes_NKH.Name = "groupBoxRes_NKH";
            groupBoxRes_NKH.Size = new Size(250, 344);
            groupBoxRes_NKH.TabIndex = 0;
            groupBoxRes_NKH.TabStop = false;
            groupBoxRes_NKH.Text = "Вывод данных:";
            // 
            // panelCent_NKH
            // 
            panelCent_NKH.Controls.Add(chartFun_NKH);
            panelCent_NKH.Controls.Add(splitter1);
            panelCent_NKH.Dock = DockStyle.Fill;
            panelCent_NKH.Location = new Point(250, 111);
            panelCent_NKH.Name = "panelCent_NKH";
            panelCent_NKH.Size = new Size(603, 344);
            panelCent_NKH.TabIndex = 2;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 344);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // chartFun_NKH
            // 
            chartArea1.Name = "ChartArea1";
            chartFun_NKH.ChartAreas.Add(chartArea1);
            chartFun_NKH.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartFun_NKH.Legends.Add(legend1);
            chartFun_NKH.Location = new Point(4, 0);
            chartFun_NKH.Name = "chartFun_NKH";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFun_NKH.Series.Add(series1);
            chartFun_NKH.Size = new Size(599, 344);
            chartFun_NKH.TabIndex = 1;
            chartFun_NKH.Text = "chart1";
            // 
            // dataGridViewRes_NKH
            // 
            dataGridViewRes_NKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRes_NKH.Dock = DockStyle.Fill;
            dataGridViewRes_NKH.Location = new Point(3, 23);
            dataGridViewRes_NKH.Name = "dataGridViewRes_NKH";
            dataGridViewRes_NKH.RowHeadersWidth = 51;
            dataGridViewRes_NKH.Size = new Size(244, 318);
            dataGridViewRes_NKH.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 455);
            Controls.Add(panelCent_NKH);
            Controls.Add(panelLeft_NKH);
            Controls.Add(panelUp_NKH);
            MinimumSize = new Size(871, 502);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 10 | Назарова К.Х.";
            panelUp_NKH.ResumeLayout(false);
            groupBoxTask_NKH.ResumeLayout(false);
            groupBoxTask_NKH.PerformLayout();
            panelLeft_NKH.ResumeLayout(false);
            groupBoxRes_NKH.ResumeLayout(false);
            panelCent_NKH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFun_NKH).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_NKH).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUp_NKH;
        private Panel panelLeft_NKH;
        private Panel panelCent_NKH;
        private Splitter splitter1;
        private GroupBox groupBoxTask_NKH;
        private TextBox textBoxTask_NKH;
        private Button buttonSms_NKH;
        private Button buttonFile_NKH;
        private Button buttonOtvet_NKH;
        private GroupBox groupBoxRes_NKH;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFun_NKH;
        private DataGridView dataGridViewRes_NKH;
    }
}
