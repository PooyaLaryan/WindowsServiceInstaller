using System.Data;
using System.Diagnostics;
using System.ServiceProcess;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
namespace WindowsServiceInstaller
{
    public partial class Form1 : Form
    {
        Process process = new Process();
        private string servicePath = string.Empty;
        public Form1()
        {
            InitializeComponent();
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.FileName = "C:\\Windows\\system32\\cmd.exe";
            dataGridView1.RowPrePaint += DataGridView1_RowPrePaint;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            openFileDialog1.Filter = "exe files (*.exe)|*.exe";
            label1.Text = string.Empty;
            label1.MaximumSize = new Size(label1.Width, 0);
            label1.AutoSize = true;
        }

        private void DataGridView1_SelectionChanged(object? sender, EventArgs e)
        {
            var status = dataGridView1.CurrentRow.Cells[1].Value as string;
            btnStopAndStart.Text = status == "Stopped" ? "Start" : "Stop";
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString().Replace(".BPJService", "");
        }

        private void DataGridView1_RowPrePaint(object? sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            if (row.Cells[1].Value.ToString() == "Stopped")
            {
                row.Cells[1].Style.ForeColor = Color.Red;
            }
            else
            {
                row.Cells[1].Style.ForeColor = Color.Green;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Text = openFileDialog1.FileName;
                servicePath = openFileDialog1.FileName;
            }
        }

        private void btn_Create_Serice_Click(object sender, EventArgs e)
        {
            var serviceName = $".BPJService{textBox1.Text}";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Service name is empty.You should select unique name for your service.");
                return;
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == serviceName)
                {
                    MessageBox.Show("your service name is already exists.");
                    return;
                }
            }
            if (servicePath == string.Empty)
            {
                MessageBox.Show("project .exe file is requiered. please select your project first");
                return;
            }

            process.StartInfo.Arguments = $"/C sc create \"{serviceName}\" binpath= \"{label1.Text}\"";
            process.Start();

            LoadServies();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadServies();
        }

        private void LoadServies()
        {
            Thread.Sleep(1000);
            ServiceController[] scServices = ServiceController.GetServices();
            var list = scServices
                .Where(x => x.ServiceName.Contains(".BPJService"))
                .Select(x => new RowItem()
                {
                    ServiceName = x.ServiceName,
                    Status = x.Status.ToString(),
                })
                .OrderBy(x => x.ServiceName)
                .ToList();
            dataGridView1.DataSource = list;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            servicePath = string.Empty;
            label1.Text = string.Empty;
        }

        private void stopAndStart_Click(object sender, EventArgs e)
        {
            string command = string.Empty;
            var serviceName = ".BPJService" + textBox1.Text;
            process.StartInfo.Arguments = btnStopAndStart.Text == "Start" ?
                $"/C sc Start \"{serviceName}\"" :
                $"/C sc stop \"{serviceName}\"";
            process.Start();

            LoadServies();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == string.Empty)
            {
                MessageBox.Show("");
                return;
            }

            if(MessageBox.Show("Your service will be removed. Do you want to countinue?","Delete Service",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                var serviceName = ".BPJService" + textBox1.Text;
                process.StartInfo.Arguments = $"/C sc stop \"{serviceName}\"\n";
                process.Start();
                process.StartInfo.Arguments = $"/C sc delete \"{serviceName}\"\n";
                process.Start();
                LoadServies();
            }
        }
    }
}
