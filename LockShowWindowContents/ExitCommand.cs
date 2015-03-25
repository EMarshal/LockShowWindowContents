// <copyright file="ExitCommand.cs" company="Éli Marshal">
//     Copyright (c) Éli Marshal. All rights reserved.
// </copyright>

namespace LockShowWindowContents
{
    using System;
    using System.Windows;
    using System.Windows.Input;

    /// <summary>
    /// Command to exit the application.
    /// </summary>
    public sealed class ExitCommand : ICommand
    {
        /// <summary>
        /// Not used.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { }
            remove { }
        }

        /// <summary>
        /// Exits the application.
        /// </summary>
        /// <param name="parameter">The parameter is not used.</param>
        public void Execute(object parameter)
        {
            Application.Current.Shutdown();
        }

        /// <summary>
        /// Can always execute.
        /// </summary>
        /// <param name="parameter">The parameter is not used.</param>
        /// <returns>Always true.</returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }
    }
}
