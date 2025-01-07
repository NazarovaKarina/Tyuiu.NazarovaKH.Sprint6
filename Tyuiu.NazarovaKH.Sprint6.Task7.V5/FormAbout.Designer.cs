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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            buttonDone_NKH = new Button();
            pictureBoxOne_NKH = new PictureBox();
            textBoxInfo_NKH = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOne_NKH).BeginInit();
            SuspendLayout();
            // 
            // buttonDone_NKH
            // 
            buttonDone_NKH.Location = new Point(477, 187);
            buttonDone_NKH.Name = "buttonDone_NKH";
            buttonDone_NKH.Size = new Size(75, 23);
            buttonDone_NKH.TabIndex = 5;
            buttonDone_NKH.Text = "ОК";
            buttonDone_NKH.UseVisualStyleBackColor = true;
            // 
            // pictureBoxOne_NKH
            // 
            pictureBoxOne_NKH.AccessibleRole = AccessibleRole.IpAddress;
            pictureBoxOne_NKH.Location = new Point(12, 12);
            pictureBoxOne_NKH.Name = "pictureBoxOne_NKH";
            pictureBoxOne_NKH.Size = new Size(166, 198);
            pictureBoxOne_NKH.TabIndex = 4;
            pictureBoxOne_NKH.TabStop = false;
            // 
            // textBoxInfo_NKH
            // 
            textBoxInfo_NKH.BorderStyle = BorderStyle.None;
            textBoxInfo_NKH.Location = new Point(184, 12);
            textBoxInfo_NKH.Multiline = true;
            textBoxInfo_NKH.Name = "textBoxInfo_NKH";
            textBoxInfo_NKH.ReadOnly = true;
            textBoxInfo_NKH.Size = new Size(368, 161);
            textBoxInfo_NKH.TabIndex = 3;
            textBoxInfo_NKH.Text = resources.GetString("textBoxInfo_SNM.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 261);
            Controls.Add(buttonDone_NKH);
            Controls.Add(pictureBoxOne_NKH);
            Controls.Add(textBoxInfo_NKH);
            MinimumSize = new Size(600, 300);
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