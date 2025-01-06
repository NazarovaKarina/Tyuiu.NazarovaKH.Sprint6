using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Tyuiu.NazarovaKH.Sprint6.Task5.V10.Lib;

namespace Tyuiu.NazarovaKH.Sprint6.Task5.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.AcceptButton = buttonOtvet_NKH;
        }
        DataService ds = new DataService();
        string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V10.txt");


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
                double[] nums = ds.LoadFromDataFile(path);

                dataGridViewRes_NKH.Rows.Clear();

                dataGridViewRes_NKH.ColumnCount = 2;
                dataGridViewRes_NKH.Columns[0].Width = 30;
                dataGridViewRes_NKH.Columns[1].Width = 128;
                int count = 1;
                foreach (double num in nums)
                {
                    dataGridViewRes_NKH.Rows.Add(count, num);
                    dataGridViewRes_NKH.Columns[0].HeaderText = "¹";
                    dataGridViewRes_NKH.Columns[1].HeaderText = "Значение";
                    count++;
                }
                dataGridViewRes_NKH.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewRes_NKH.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridViewRes_NKH.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewRes_NKH.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            catch
            {
                MessageBox.Show("Ошибка в выполнении", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void buttonFile_NKH_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
            catch
            {
                MessageBox.Show("Ошибка в открытии", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSms_NKH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы ИСПб-24-1 Назарова К.Х.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
