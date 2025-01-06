using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.NazarovaKH.Sprint6.Task4.V16.Lib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tyuiu.NazarovaKH.Sprint6.Task4.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBoxStart_NKH_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxStop_NKH_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void buttonOtvet_NKH_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int startValue = Convert.ToInt32(textBoxStart_NKH.Text);
                int stopValue = Convert.ToInt32(textBoxStop_NKH.Text);
                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxRes_NKH.Text = "";

                this.chartFun_NKH.Titles.Add("График функции");

                this.chartFun_NKH.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFun_NKH.ChartAreas[0].AxisY.Title = "Ось Y";

                Series series = new Series
                {
                    ChartType = SeriesChartType.Line
                };

                this.chartFun_NKH.Series.Clear();
                this.chartFun_NKH.Series.Add(series);

                for (int i = 0; i <= len - 1; i++)
                {
                    textBoxRes_NKH.AppendText(valueArray[i] + Environment.NewLine);
                    this.chartFun_NKH.Series[0].Points.AddXY(startValue, valueArray[i]);
                    startValue++;
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите корректное целое число.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private void buttonSave_NKH_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask4V16.txt" });
                File.WriteAllText(path, textBoxRes_NKH.Text);

                DialogResult dialogResult = MessageBox.Show("Файл\n" + path + " сохранен успешно!\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void buttonSms_NKH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студентка группы ИСПб-24-1 Назарова К.Х.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
