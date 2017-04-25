using System;
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

        private async void action1_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = "Action 1 starting...";
            await Action1.Execute();
            label1.Content = "Action 1 completed";
        }

        private void action2_Click(object sender, RoutedEventArgs e)
        {
            label2Start.Content = DateTime.Now.ToString("HH:mm:ss");

            label2A.Content = Action1.ExecuteA().Result;
            label2B.Content = Action1.ExecuteB().Result;

            label2Stop.Content = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
