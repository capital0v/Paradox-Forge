using System.Diagnostics;

namespace ParadoxForge.Scripts
{
    internal class Launcher
    {
        private Process _process = new Process();

        private readonly string _pathToGame = @"PATH_TO_GAME";

        public Launcher() 
        {
            _process.StartInfo.FileName = _pathToGame;
        }

        public void RunGame(string priority)
        {
            try
            {
                _process.Start();

                ProcessPriorityClass priorityClass;
                if (Enum.TryParse(priority, true, out priorityClass))
                {
                    _process.PriorityClass = priorityClass;
                }
                else
                {
                    MessageBox.Show("Invalid priority value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
            }
            catch
            {
                MessageBox.Show("Incorrect path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }
    }
}
