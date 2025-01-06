using System.Globalization;
using Tyuiu.NazarovaKH.Sprint6.Task5.V10.Lib;

namespace Tyuiu.NazarovaKH.Sprint6.Task5.V10
{
    public partial class FormMain : Form
    {
        private DataService ds;

        public FormMain()
        {
            InitializeComponent();
            ds = new DataService();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.chartFun_NKH.Titles.Add("График функции F(x)");
            this.chartFun_NKH.Titles[0].Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
            this.chartFun_NKH.Titles[0].ForeColor = Color.Red;
            this.chartFun_NKH.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFun_NKH.ChartAreas[0].AxisY.Title = "Ось Y";

            dataGridViewRes_NKH.RowHeadersVisible = false;
            dataGridViewRes_NKH.ColumnHeadersVisible = false;
            dataGridViewRes_NKH.Font = new Font("Segoe UI", 10);
        }
        private void buttonOtvet_NKH_Click(object sender, EventArgs e)
        {
            try
            {
                this.chartFun_NKH.Series[0].Points.Clear();

                foreach (DataGridViewRow row in dataGridViewRes_NKH.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                    {
                        int xValue;
                        double yValue;

                        if (int.TryParse(row.Cells[0].Value.ToString(), out xValue) && double.TryParse(row.Cells[1].Value.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out yValue))
                        {
                            this.chartFun_NKH.Series[0].Points.AddXY(xValue, yValue);
                        }
                        else
                        {
                            MessageBox.Show($"Некорректные данные в строке {row.Index + 1}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при чтении данных из dataGridView: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFile_NKH_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Выберите файл с данными";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    double[] data = ds.LoadFromDataFile(openFileDialog.FileName);

                    dataGridViewRes_NKH.DataSource = null;
                    dataGridViewRes_NKH.Rows.Clear();

                    dataGridViewRes_NKH.ColumnCount = 2;
                    dataGridViewRes_NKH.RowCount = data.Length;
                    dataGridViewRes_NKH.Columns[0].Width = 35;
                    dataGridViewRes_NKH.Columns[1].Width = 75;

                    for (int i = 0; i < data.Length; i++)
                    {
                        dataGridViewRes_NKH.Rows[i].Cells[0].Value = Convert.ToString(i + 1);
                        dataGridViewRes_NKH.Rows[i].Cells[1].Value = Convert.ToString(data[i]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при чтении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSms_NKH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы ИСПб-24-1 Назарова К.Х.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
