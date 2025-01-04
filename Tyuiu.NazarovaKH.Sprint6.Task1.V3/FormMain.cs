using Tyuiu.NazarovaKH.Sprint6.Task1.V3.Lib;

namespace Tyuiu.NazarovaKH.Sprint6.Task1.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string strLine;
        private void buttonOtvet_NKX_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();

                int start = Convert.ToInt32(textBoxStart_NKX.Text);
                int end = Convert.ToInt32(textBoxStop_NKX.Text);

                double[] valueArray = ds.GetMassFunction(start, end);
                textBoxResult_NKX.Text = "";
                textBoxResult_NKX.AppendText("+-----------+-----------+" + Environment.NewLine);
                textBoxResult_NKX.AppendText("|     X     |    f(x)   |" + Environment.NewLine);
                textBoxResult_NKX.AppendText("+-----------+-----------+" + Environment.NewLine);

                for (int i = 0; i < valueArray.Length; i++)
                {
                    strLine = String.Format("| {0,5:d}     |  {1, 7:f2}  | ", start, valueArray[i]);
                    textBoxResult_NKX.AppendText(strLine + Environment.NewLine);
                    start++;
                }
                textBoxResult_NKX.AppendText("+-----------+-----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSms_NKX_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание выполнила студентка группы ИСПб-24-1 Назарова К.Х.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxStart_NKX_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxStop_NKX_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
