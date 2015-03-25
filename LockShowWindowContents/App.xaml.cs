// <copyright file="App.xaml.cs" company="Éli Marshal">
//     Copyright (c) Éli Marshal. All rights reserved.
// </copyright>

namespace LockShowWindowContents
{
    using Hardcodet.Wpf.TaskbarNotification;
    using System;
    using System.Windows;

    /// <summary>
    /// Interaction logic for <c>App.xaml</c>
    /// </summary>
    public sealed partial class App : Application, IDisposable
    {
        /// <summary>
        /// Taskbar icon.
        /// </summary>
        private TaskbarIcon tb;

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this.tb.Dispose();
        }

        /// <summary>
        /// Raises the System.Windows.Application.Startup event.
        /// Sets ShowWindowContents on startup and initializes notification icon.
        /// </summary>
        /// <param name="e">A StartupEventArgs that contains the event data.</param>
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ShowWindowContents.SetShowWindowContents();
            this.tb = (TaskbarIcon)FindResource("MyNotifyIcon");
        }
    }
}
