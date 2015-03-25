// <copyright file="NotifyIconViewModel.cs" company="Éli Marshal">
//     Copyright (c) Éli Marshal. All rights reserved.
// </copyright>

namespace LockShowWindowContents
{
    using System.Windows;
    using System.Windows.Input;

    /// <summary>
    /// ViewModel for notify icon.
    /// </summary>
    public sealed class NotifyIconViewModel
    {
        /// <summary>
        /// Gets command to exit the application.
        /// </summary>
        /// <param name="parameter">The parameter is not used.</param>
        public ICommand ExitApplicationCommand
        {
            get
            {
                return new DelegateCommand { CommandAction = () => Application.Current.Shutdown() };
            }
        }
    }
}
