using System.Drawing.Drawing2D;
using System.Windows.Forms.VisualStyles;
using Tyuiu.NazarovaKH.Sprint6.Task2.V17.Lib;

namespace Tyuiu.NazarovaKH.Sprint6.Task2.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();


        private void textBoxStart_NKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != '.') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxStop_NKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != '.') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void buttonSms_NKH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание выполнила студентка группы ИСПб-24-1 Назарова К.Х.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOtvet_NKH_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_NKH.Text);
                int stopStep = Convert.ToInt32(textBoxStop_NKH.Text);

                DataService ds = new DataService();
                double[] valueArray = ds.GetMassFunction(startStep, stopStep);

                int height = pictureBoxGraf_NKH.Height;
                int width = pictureBoxGraf_NKH.Width;

                Bitmap bmp = new Bitmap(width, height);
                Graphics g = Graphics.FromImage(bmp);
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.White);

                g.DrawLine(Pens.Black, 50, height - 50, width - 50, height - 50);
                g.DrawLine(Pens.Black, 50, height - 50, 50, 50);

                for (int i = 0; i < valueArray.Length; i++)
                {
                    float x_pos = (float)((startStep - startStep) / (float)(stopStep - startStep) * (width - 100) + 50);
                    float y_pos = (float)(height - 50 - (valueArray[i] + 1) / 2.0 * (height - 100));
                    g.FillEllipse(Brushes.Blue, x_pos - 2, y_pos - 2, 4, 4);

                    this.dataGridViewRes_NKH.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    startStep++;
                }

                pictureBoxGraf_NKH.Image = bmp;
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
