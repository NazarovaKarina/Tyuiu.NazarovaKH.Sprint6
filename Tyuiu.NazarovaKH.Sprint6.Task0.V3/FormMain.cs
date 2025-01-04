

using Tyuiu.NazarovaKH.Sprint6.Task0.V3.Lib;

namespace Tyuiu.NazarovaKH.Sprint6.Task0.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonOtvet_NKX_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxOtvet_NKX.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_NKX.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSms_NKX_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание выполнила студентка группы ИСПб-24-1 Назарова К.Х.", "Сообщение");
        }

        private void textBoxVarX_NKX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}
