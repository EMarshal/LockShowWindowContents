// <copyright file="MainViewModel.cs" company="Éli Marshal">
//     Copyright (c) Éli Marshal. All rights reserved.
// </copyright>

namespace LockShowWindowContents.ViewModels
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// ViewModel for main window.
    /// </summary>
    public sealed class MainViewModel
    {
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
        public IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            if (msg == 26 && wParam.ToInt32() == 37)
            {
                ShowWindowContents.SetShowWindowContents();
            }

            return IntPtr.Zero;
        }
    }
}
