using ParadoxForge.Scripts;
using ParadoxForge.Scripts.Mods;
using System.Diagnostics;

namespace ParadoxForge
{
    public partial class Main : Form
    {
        private string _processPriority = String.Empty;
        private string _processName = "PROCESS_NAME_WITHOUT_EXE";

        Launcher _launcher = new Launcher();
        Features _features;
        public Main()
        {
            InitializeComponent();

            _features = new Features(_processName);
            priority_cmb.SelectedIndex = 2;
        }

        private void launch_btn_Click(object sender, EventArgs e)
        {
            _launcher.RunGame(_processPriority);

            if (inject_chb.Checked)
            {
                _features.Inject();
            }
        }

        private void priority_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (priority_cmb.SelectedItem != null)
            {
                _processPriority = priority_cmb.SelectedItem.ToString() ?? "Normal";
            }
            else
            {
                MessageBox.Show("Please select a priority!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closegame_chb.Checked)
            {
                Process[] processes = Process.GetProcessesByName(_processName);

                foreach (Process process in processes)
                {
                    try
                    {
                        process.Kill();
                    }
                    catch
                    {
                        MessageBox.Show("Incorrect path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void feature1_btn_Click(object sender, EventArgs e)
        {
            //_features.GetPlayerHealth();
        }

        private void feature2_btn_Click(object sender, EventArgs e)
        {
            //_features.ChangeFog();
        }
    }
}
