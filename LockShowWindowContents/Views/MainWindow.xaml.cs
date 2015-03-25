// <copyright file="MainWindow.xaml.cs" company="Éli Marshal">
//     Copyright (c) Éli Marshal. All rights reserved.
// </copyright>

namespace LockShowWindowContents.Views
{
    using LockShowWindowContents.ViewModels;
    using System;
    using System.Windows;
    using System.Windows.Interop;

    /// <summary>
    /// Interaction logic for <c>MainWindow.xaml</c>
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Raises the System.Windows.Window.SourceInitialized event.
        /// Attaches an event handler to events for this window.
        /// </summary>
        /// <param name="e">An EventArgs that contains the event data.</param>
        protected override void OnSourceInitialized(EventArgs e)
        {
            base.OnSourceInitialized(e);
            HwndSource src = PresentationSource.FromVisual(this) as HwndSource;
            src.AddHook(((MainViewModel)DataContext).WndProc);
            this.Visibility = Visibility.Hidden;
            this.Closing += this.MainWindow_Closing;
        }

        /// <summary>
        /// Removes message callback when window is closed.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">An EventArgs that contains the event data.</param>
        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            HwndSource src = PresentationSource.FromVisual(this) as HwndSource;
            src.RemoveHook(((MainViewModel)DataContext).WndProc);
        }
    }
}
