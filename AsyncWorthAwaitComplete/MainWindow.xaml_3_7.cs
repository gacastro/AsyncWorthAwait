﻿using System;
using System.Threading.Tasks;
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

        private async void action2_Click(object sender, RoutedEventArgs e)
        {
            label2Start.Content = DateTime.Now.ToString("HH:mm:ss");

            var executeA = Action1.ExecuteA();
            var executeB = Action1.ExecuteB();

            await Task.WhenAny(executeA, executeB);

            label2A.Content = executeA.Result;
            label2B.Content = executeB.Result;

            label2Stop.Content = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
