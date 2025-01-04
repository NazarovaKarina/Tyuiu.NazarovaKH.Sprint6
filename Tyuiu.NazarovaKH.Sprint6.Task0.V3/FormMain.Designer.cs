namespace Tyuiu.NazarovaKH.Sprint6.Task0.V3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxTask_NKX = new GroupBox();
            pictureBoxFormula_NKX = new PictureBox();
            textBoxTask_NKX = new TextBox();
            groupBoxVar_NKX = new GroupBox();
            groupBoxPer_NKX = new GroupBox();
            textBoxVarX_NKX = new TextBox();
            groupBoxButton_NKX = new GroupBox();
            buttonSms_NKX = new Button();
            textBoxOtvet_NKX = new TextBox();
            buttonOtvet_NKX = new Button();
            groupBoxTask_NKX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_NKX).BeginInit();
            groupBoxVar_NKX.SuspendLayout();
            groupBoxPer_NKX.SuspendLayout();
            groupBoxButton_NKX.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_NKX
            // 
            groupBoxTask_NKX.Controls.Add(pictureBoxFormula_NKX);
            groupBoxTask_NKX.Controls.Add(textBoxTask_NKX);
            groupBoxTask_NKX.Location = new Point(21, 26);
            groupBoxTask_NKX.Name = "groupBoxTask_NKX";
            groupBoxTask_NKX.Size = new Size(736, 168);
            groupBoxTask_NKX.TabIndex = 0;
            groupBoxTask_NKX.TabStop = false;
            groupBoxTask_NKX.Text = "Условие";
            // 
            // pictureBoxFormula_NKX
            // 
            pictureBoxFormula_NKX.Image = (Image)resources.GetObject("pictureBoxFormula_NKX.Image");
            pictureBoxFormula_NKX.Location = new Point(594, 11);
            pictureBoxFormula_NKX.Name = "pictureBoxFormula_NKX";
            pictureBoxFormula_NKX.Size = new Size(142, 84);
            pictureBoxFormula_NKX.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxFormula_NKX.TabIndex = 1;
            pictureBoxFormula_NKX.TabStop = false;
            // 
            // textBoxTask_NKX
            // 
            textBoxTask_NKX.Location = new Point(0, 26);
            textBoxTask_NKX.Multiline = true;
            textBoxTask_NKX.Name = "textBoxTask_NKX";
            textBoxTask_NKX.ReadOnly = true;
            textBoxTask_NKX.Size = new Size(306, 34);
            textBoxTask_NKX.TabIndex = 0;
            textBoxTask_NKX.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxVar_NKX
            // 
            groupBoxVar_NKX.Controls.Add(groupBoxPer_NKX);
            groupBoxVar_NKX.Location = new Point(21, 227);
            groupBoxVar_NKX.Name = "groupBoxVar_NKX";
            groupBoxVar_NKX.Size = new Size(462, 137);
            groupBoxVar_NKX.TabIndex = 1;
            groupBoxVar_NKX.TabStop = false;
            groupBoxVar_NKX.Text = "Ввод данных";
            // 
            // groupBoxPer_NKX
            // 
            groupBoxPer_NKX.Controls.Add(textBoxVarX_NKX);
            groupBoxPer_NKX.Location = new Point(96, 37);
            groupBoxPer_NKX.Name = "groupBoxPer_NKX";
            groupBoxPer_NKX.Size = new Size(250, 75);
            groupBoxPer_NKX.TabIndex = 0;
            groupBoxPer_NKX.TabStop = false;
            groupBoxPer_NKX.Text = "Переменная Х";
            // 
            // textBoxVarX_NKX
            // 
            textBoxVarX_NKX.Location = new Point(57, 26);
            textBoxVarX_NKX.Name = "textBoxVarX_NKX";
            textBoxVarX_NKX.Size = new Size(125, 27);
            textBoxVarX_NKX.TabIndex = 0;
            textBoxVarX_NKX.KeyPress += textBoxVarX_NKX_KeyPress;
            // 
            // groupBoxButton_NKX
            // 
            groupBoxButton_NKX.Controls.Add(buttonOtvet_NKX);
            groupBoxButton_NKX.Controls.Add(buttonSms_NKX);
            groupBoxButton_NKX.Controls.Add(textBoxOtvet_NKX);
            groupBoxButton_NKX.Location = new Point(507, 239);
            groupBoxButton_NKX.Name = "groupBoxButton_NKX";
            groupBoxButton_NKX.Size = new Size(250, 125);
            groupBoxButton_NKX.TabIndex = 2;
            groupBoxButton_NKX.TabStop = false;
            groupBoxButton_NKX.Text = "Вывод данных";
            // 
            // buttonSms_NKX
            // 
            buttonSms_NKX.FlatStyle = FlatStyle.Flat;
            buttonSms_NKX.Location = new Point(0, 81);
            buttonSms_NKX.Name = "buttonSms_NKX";
            buttonSms_NKX.Size = new Size(43, 44);
            buttonSms_NKX.TabIndex = 1;
            buttonSms_NKX.Text = "?";
            buttonSms_NKX.UseVisualStyleBackColor = true;
            buttonSms_NKX.Click += buttonSms_NKX_Click;
            // 
            // textBoxOtvet_NKX
            // 
            textBoxOtvet_NKX.Location = new Point(69, 51);
            textBoxOtvet_NKX.Name = "textBoxOtvet_NKX";
            textBoxOtvet_NKX.ReadOnly = true;
            textBoxOtvet_NKX.Size = new Size(123, 27);
            textBoxOtvet_NKX.TabIndex = 0;
            // 
            // buttonOtvet_NKX
            // 
            buttonOtvet_NKX.Location = new Point(49, 90);
            buttonOtvet_NKX.Name = "buttonOtvet_NKX";
            buttonOtvet_NKX.Size = new Size(174, 35);
            buttonOtvet_NKX.TabIndex = 2;
            buttonOtvet_NKX.Text = "Выполнить";
            buttonOtvet_NKX.UseVisualStyleBackColor = true;
            buttonOtvet_NKX.Click += buttonOtvet_NKX_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 403);
            Controls.Add(groupBoxButton_NKX);
            Controls.Add(groupBoxVar_NKX);
            Controls.Add(groupBoxTask_NKX);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 3 | Назарова К.Х.";
            Load += Form1_Load;
            groupBoxTask_NKX.ResumeLayout(false);
            groupBoxTask_NKX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_NKX).EndInit();
            groupBoxVar_NKX.ResumeLayout(false);
            groupBoxPer_NKX.ResumeLayout(false);
            groupBoxPer_NKX.PerformLayout();
            groupBoxButton_NKX.ResumeLayout(false);
            groupBoxButton_NKX.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_NKX;
        private TextBox textBoxTask_NKX;
        private PictureBox pictureBoxFormula_NKX;
        private GroupBox groupBoxVar_NKX;
        private GroupBox groupBoxPer_NKX;
        private TextBox textBoxVarX_NKX;
        private GroupBox groupBoxButton_NKX;
        private TextBox textBoxOtvet_NKX;
        private Button buttonSms_NKX;
        private Button buttonOtvet_NKX;
    }
}
