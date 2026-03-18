using Avalonia.Controls;
using Avalonia.Interactivity;

namespace shell_gui
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Button click handler (logic comes later)
        private void RunButton_Click(object? sender, RoutedEventArgs e)
        {
            string command = CommandTextBox.Text ?? "";

            // For now just display it in output box
            OutputTextBox.Text += $"> {command}\n";

            // TODO: later we will execute the command and show real output
        }
    }
}