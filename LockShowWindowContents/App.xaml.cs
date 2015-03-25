// <copyright file="App.xaml.cs" company="Éli Marshal">
//     Copyright (c) Éli Marshal. All rights reserved.
// </copyright>

namespace LockShowWindowContents
{
    using System.Windows;

    /// <summary>
    /// Interaction logic for <c>App.xaml</c>
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Raises the System.Windows.Application.Startup event.
        /// Sets ShowWindowContents on startup.
        /// </summary>
        /// <param name="e">A StartupEventArgs that contains the event data.</param>
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ShowWindowContents.SetShowWindowContents();
        }
    }
}
