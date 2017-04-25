using System.Windows;

namespace AsyncWorthAwaitComplete
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void action1_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = "Action 1 starting...";
            Action1.Execute();
            label1.Content = "Action 1 completed";
        }
    }
}
