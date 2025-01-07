namespace Tyuiu.NazarovaKH.Sprint6.Task6.V12
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
            components = new System.ComponentModel.Container();
            panelButtons = new Panel();
            buttonAbout = new Button();
            buttonDone = new Button();
            buttonLoad = new Button();
            panelTask = new Panel();
            groupBoxTask = new GroupBox();
            labelTask = new Label();
            splitContainerInOutPut = new SplitContainer();
            groupBoxInput = new GroupBox();
            textBoxInput = new TextBox();
            groupBoxOutput = new GroupBox();
            textBoxOutput = new TextBox();
            openFileDialogTask = new OpenFileDialog();
            toolTip = new ToolTip(components);
            panelButtons.SuspendLayout();
            panelTask.SuspendLayout();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerInOutPut).BeginInit();
            splitContainerInOutPut.Panel1.SuspendLayout();
            splitContainerInOutPut.Panel2.SuspendLayout();
            splitContainerInOutPut.SuspendLayout();
            groupBoxInput.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            SuspendLayout();
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonAbout);
            panelButtons.Controls.Add(buttonDone);
            panelButtons.Controls.Add(buttonLoad);
            panelButtons.Dock = DockStyle.Top;
            panelButtons.Location = new Point(0, 0);
            panelButtons.Margin = new Padding(3, 4, 3, 4);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(919, 91);
            panelButtons.TabIndex = 2;
            // 
            // buttonAbout
            // 
            buttonAbout.Dock = DockStyle.Right;
            buttonAbout.Location = new Point(841, 0);
            buttonAbout.Margin = new Padding(3, 4, 3, 4);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(78, 91);
            buttonAbout.TabIndex = 2;
            toolTip.SetToolTip(buttonAbout, "Информация о приложении");
            buttonAbout.UseVisualStyleBackColor = true;
            buttonAbout.Click += buttonAbout_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDone.Dock = DockStyle.Left;
            buttonDone.Location = new Point(83, 0);
            buttonDone.Margin = new Padding(3, 4, 3, 4);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(83, 91);
            buttonDone.TabIndex = 1;
            toolTip.SetToolTip(buttonDone, "Производит поиск слов, в которых встречается w и выводит их в результирующую строку");
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.BackColor = SystemColors.Control;
            buttonLoad.BackgroundImageLayout = ImageLayout.Zoom;
            buttonLoad.Dock = DockStyle.Left;
            buttonLoad.ForeColor = SystemColors.ControlText;
            buttonLoad.Location = new Point(0, 0);
            buttonLoad.Margin = new Padding(3, 4, 3, 4);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(83, 91);
            buttonLoad.TabIndex = 0;
            toolTip.SetToolTip(buttonLoad, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonLoad.UseVisualStyleBackColor = false;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // panelTask
            // 
            panelTask.Controls.Add(groupBoxTask);
            panelTask.Dock = DockStyle.Top;
            panelTask.Location = new Point(0, 91);
            panelTask.Margin = new Padding(3, 4, 3, 4);
            panelTask.Name = "panelTask";
            panelTask.Size = new Size(919, 121);
            panelTask.TabIndex = 3;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(labelTask);
            groupBoxTask.Dock = DockStyle.Fill;
            groupBoxTask.Location = new Point(0, 0);
            groupBoxTask.Margin = new Padding(3, 4, 3, 4);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Padding = new Padding(3, 4, 3, 4);
            groupBoxTask.Size = new Size(919, 121);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // labelTask
            // 
            labelTask.Dock = DockStyle.Fill;
            labelTask.Location = new Point(3, 24);
            labelTask.MinimumSize = new Size(571, 20);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(913, 93);
            labelTask.TabIndex = 0;
            // 
            // splitContainerInOutPut
            // 
            splitContainerInOutPut.Dock = DockStyle.Fill;
            splitContainerInOutPut.Location = new Point(0, 212);
            splitContainerInOutPut.Margin = new Padding(3, 4, 3, 4);
            splitContainerInOutPut.Name = "splitContainerInOutPut";
            // 
            // splitContainerInOutPut.Panel1
            // 
            splitContainerInOutPut.Panel1.Controls.Add(groupBoxInput);
            // 
            // splitContainerInOutPut.Panel2
            // 
            splitContainerInOutPut.Panel2.Controls.Add(groupBoxOutput);
            splitContainerInOutPut.Size = new Size(919, 483);
            splitContainerInOutPut.SplitterDistance = 373;
            splitContainerInOutPut.SplitterWidth = 5;
            splitContainerInOutPut.TabIndex = 4;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(textBoxInput);
            groupBoxInput.Dock = DockStyle.Fill;
            groupBoxInput.Location = new Point(0, 0);
            groupBoxInput.Margin = new Padding(3, 4, 3, 4);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Padding = new Padding(3, 4, 3, 4);
            groupBoxInput.Size = new Size(373, 483);
            groupBoxInput.TabIndex = 0;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных:";
            // 
            // textBoxInput
            // 
            textBoxInput.Dock = DockStyle.Fill;
            textBoxInput.Location = new Point(3, 24);
            textBoxInput.Margin = new Padding(3, 4, 3, 4);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.ReadOnly = true;
            textBoxInput.ScrollBars = ScrollBars.Both;
            textBoxInput.Size = new Size(367, 455);
            textBoxInput.TabIndex = 0;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(textBoxOutput);
            groupBoxOutput.Dock = DockStyle.Fill;
            groupBoxOutput.Location = new Point(0, 0);
            groupBoxOutput.Margin = new Padding(3, 4, 3, 4);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Padding = new Padding(3, 4, 3, 4);
            groupBoxOutput.Size = new Size(541, 483);
            groupBoxOutput.TabIndex = 0;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод данных:";
            // 
            // textBoxOutput
            // 
            textBoxOutput.Dock = DockStyle.Fill;
            textBoxOutput.Location = new Point(3, 24);
            textBoxOutput.Margin = new Padding(3, 4, 3, 4);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ReadOnly = true;
            textBoxOutput.ScrollBars = ScrollBars.Both;
            textBoxOutput.Size = new Size(535, 455);
            textBoxOutput.TabIndex = 0;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // toolTip
            // 
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(919, 695);
            Controls.Add(splitContainerInOutPut);
            Controls.Add(panelTask);
            Controls.Add(panelButtons);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(935, 731);
            Name = "FormMain";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 12 | Назарова К.Х.";
            Load += FormMain_Load;
            panelButtons.ResumeLayout(false);
            panelTask.ResumeLayout(false);
            groupBoxTask.ResumeLayout(false);
            splitContainerInOutPut.Panel1.ResumeLayout(false);
            splitContainerInOutPut.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerInOutPut).EndInit();
            splitContainerInOutPut.ResumeLayout(false);
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelButtons;
        private Panel panelTask;
        private GroupBox groupBoxTask;
        private SplitContainer splitContainerInOutPut;
        private GroupBox groupBoxInput;
        private GroupBox groupBoxOutput;
        private Button buttonAbout;
        private Button buttonDone;
        private Button buttonLoad;
        private Label labelTask;
        private TextBox textBoxInput;
        private TextBox textBoxOutput;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTip;
    }
}
