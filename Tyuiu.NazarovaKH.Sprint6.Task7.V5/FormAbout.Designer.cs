namespace Tyuiu.NazarovaKH.Sprint6.Task7.V5
{
    partial class FormAbout
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
            buttonDone_NKH = new Button();
            pictureBoxOne_NKH = new PictureBox();
            textBoxInfo_NKH = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOne_NKH).BeginInit();
            SuspendLayout();
            // 
            // buttonDone_NKH
            // 
            buttonDone_NKH.Location = new Point(545, 249);
            buttonDone_NKH.Margin = new Padding(3, 4, 3, 4);
            buttonDone_NKH.Name = "buttonDone_NKH";
            buttonDone_NKH.Size = new Size(86, 31);
            buttonDone_NKH.TabIndex = 5;
            buttonDone_NKH.Text = "ОК";
            buttonDone_NKH.UseVisualStyleBackColor = true;
            // 
            // pictureBoxOne_NKH
            // 
            pictureBoxOne_NKH.AccessibleRole = AccessibleRole.IpAddress;
            pictureBoxOne_NKH.Location = new Point(14, 16);
            pictureBoxOne_NKH.Margin = new Padding(3, 4, 3, 4);
            pictureBoxOne_NKH.Name = "pictureBoxOne_NKH";
            pictureBoxOne_NKH.Size = new Size(190, 264);
            pictureBoxOne_NKH.TabIndex = 4;
            pictureBoxOne_NKH.TabStop = false;
            // 
            // textBoxInfo_NKH
            // 
            textBoxInfo_NKH.BorderStyle = BorderStyle.None;
            textBoxInfo_NKH.Location = new Point(210, 16);
            textBoxInfo_NKH.Margin = new Padding(3, 4, 3, 4);
            textBoxInfo_NKH.Multiline = true;
            textBoxInfo_NKH.Name = "textBoxInfo_NKH";
            textBoxInfo_NKH.ReadOnly = true;
            textBoxInfo_NKH.Size = new Size(421, 215);
            textBoxInfo_NKH.TabIndex = 3;
            textBoxInfo_NKH.Text = "Разработчик:\r\nНазарова Карина Халиловна\r\n\r\nГруппа:\r\nИСПб-24-1\r\n\r\nСпринт 6 \r\nЗадание 7 \r\nВариант 5";
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 348);
            Controls.Add(buttonDone_NKH);
            Controls.Add(pictureBoxOne_NKH);
            Controls.Add(textBoxInfo_NKH);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(683, 384);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxOne_NKH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDone_NKH;
        private PictureBox pictureBoxOne_NKH;
        private TextBox textBoxInfo_NKH;
    }
}