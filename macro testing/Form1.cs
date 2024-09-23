using System.Runtime.InteropServices;

namespace macro_testing
{
    public partial class Form1 : Form
    {
        // Import user32.dll functions
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string className, string windowTitle);

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        // Define the button click message
        private const int BM_CLICK = 0x00F5;

        public Form1()
        {
            InitializeComponent();
        }
        private void btnClickMacro_Click(object sender, EventArgs e)
        {
            // Replace with the target window's title
            string windowTitle = "  ";

            // Starting with null to find the first window
            IntPtr previousWindowHandle = IntPtr.Zero;

            while (true)
            {
                // Find the next window with the specified title
                IntPtr targetWindowHandle = FindWindowEx(IntPtr.Zero, previousWindowHandle, null, windowTitle);

                // If no window is found, break the loop
                if (targetWindowHandle == IntPtr.Zero)
                {
                    MessageBox.Show("No more windows found with the same title.");
                    break;
                }

                // Replace with the button's text that you want to click
                string buttonText = "OK";

                // Find the button within the target window by its text
                IntPtr buttonHandle = FindWindowEx(targetWindowHandle, IntPtr.Zero, null, buttonText);

                if (buttonHandle != IntPtr.Zero)
                {
                    // Simulate a button click
                    SendMessage(buttonHandle, BM_CLICK, IntPtr.Zero, IntPtr.Zero);
                    MessageBox.Show("Button click simulated!");

                    // After clicking the button, wait for the next window to appear
                    // We'll poll for the next window instead of a fixed delay
                    previousWindowHandle = targetWindowHandle;

                    // Poll for the next window to appear
                    while (true)
                    {
                        // Find the next window in the sequence (it appears after the button is clicked)
                        IntPtr nextWindowHandle = FindWindowEx(IntPtr.Zero, previousWindowHandle, null, windowTitle);

                        // If a new window is found, break the polling loop and continue the process
                        if (nextWindowHandle != IntPtr.Zero)
                        {
                            previousWindowHandle = nextWindowHandle;
                            break;
                        }

                        // Sleep for a short time before polling again
                        System.Threading.Thread.Sleep(500);
                    }
                }
                else
                {
                    MessageBox.Show("Button not found in the window.");
                    break;
                }
            }
        }


    }
}
