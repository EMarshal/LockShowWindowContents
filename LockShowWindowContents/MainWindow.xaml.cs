// <copyright file="MainWindow.xaml.cs" company="Éli Marshal">
//     Copyright (c) Éli Marshal. All rights reserved.
// </copyright>

namespace LockShowWindowContents
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Windows;
    using System.Windows.Interop;

    /// <summary>
    /// Interaction logic for <c>MainWindow.xaml</c>
    /// </summary>
    public partial class MainWindow : Window
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
            src.AddHook(this.WndProc);
            this.Visibility = Visibility.Hidden;
            this.Closing += this.MainWindow_Closing;
        }

        /// <summary>
        /// Callback function to process messages.
        /// SetShowDragEnabled if ShowDragEnabled is "Show window contents while dragging" is changed
        /// </summary>
        /// <param name="hwnd">Handle to the window to which the message was sent.</param>
        /// <param name="msg">The message, must equal 26 to SetShowDragEnabled.</param>
        /// <param name="wParam">Value depends on sender context, must point to 37 to SetShowDragEnabled.</param>
        /// <param name="lParam">Value depends on sender context, not used.</param>
        /// <param name="handled">Indicates if message has been handled.</param>
        /// <returns>Null pointer.</returns>
        [SuppressMessage("Microsoft.StyleCop.CSharp.NamingRules", "SA1305:FieldNamesMustNotUseHungarianNotation", Justification = "wParam and lParam are standard notation.")]
        private IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            if (msg == 26 && wParam.ToInt32() == 37)
            {
                ShowWindowContents.SetShowWindowContents();
            }

            return IntPtr.Zero;
        }

        /// <summary>
        /// Removes message callback when window is closed.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">An EventArgs that contains the event data.</param>
        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            HwndSource src = PresentationSource.FromVisual(this) as HwndSource;
            src.RemoveHook(this.WndProc);
        }
    }
}
