using System.Runtime.InteropServices;

namespace ParadoxForge.Scripts.Mods
{
    internal class Features
    {
        #region import
        [DllImport("User32.dll")]
        public static extern short GetAsyncKeyState(Keys ArrowKeys);
        #endregion

        private Memory? _memory;

        private nint _client;
        private string _processName;
        public Features(string processName)
        {
            _processName = processName;
        }

        public void Inject()
        {
            _memory = new Memory(_processName);
            /* Get module base from Game
            
            _client = _memory.GetModuleBase("example.dll");

            */

            Start();

            Task.Run(() =>
            {
                Update();
            });
        }

        private void Start()
        {
            //FPSbypass();
        }

        private void Update()
        {
            while (true)
            {
                /* A function that will work all the time

                GetPlayerHealth();

                */

                Thread.Sleep(1);
            }
        }

        /* Simple examples
        
        public void GetPlayerHealth()
        {
            IntPtr player = _memory.ReadPointer(_client, 0x123456, 0x12);
            float health = _memory.ReadFloat(player, 0x1);
        }

        public void FPSbypass()
        {
            IntPtr fps = _memory.ReadPointer(_client, 0x1234);
            _memory.WriteFloat(fog, 0x4 + 0x1, 144);
        }

        */
    }
}
