using Tyuiu.NazarovaKH.Sprint6.Task6.V12.Lib;

namespace Tyuiu.NazarovaKH.Sprint6.Task6.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBoxInput.Text = File.ReadAllText(openFilePath);
            groupBoxInput.Text = groupBoxInput.Text + " " + openFileDialogTask.FileName;
            buttonDone.Enabled = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            buttonAbout.Image = SystemIcons.Information.ToBitmap();
            buttonDone.Enabled = false;
        }
    }
}
