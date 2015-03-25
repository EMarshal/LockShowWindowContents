// <copyright file="DelegateCommand.cs" company="Éli Marshal">
//     Copyright (c) Éli Marshal. All rights reserved.
// </copyright>

namespace LockShowWindowContents
{
    using System;
    using System.Windows.Input;

    /// <summary>
    /// Simple DelegateCommand base.
    /// </summary>
    public class DelegateCommand : ICommand
    {
        /// <summary>
        /// Adds or removes <c>RequerySuggested</c> from CommandManager.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// Gets or sets action to execute.
        /// </summary>
        public Action CommandAction { get; set; }

        /// <summary>
        /// Executes the command.
        /// </summary>
        /// <param name="parameter">The parameter is not used.</param>
        public void Execute(object parameter)
        {
            this.CommandAction();
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
