// <copyright file="Program.cs" company="Éli Marshal">
// Copyright (c) Éli Marshal. All rights reserved.
// </copyright>

namespace LockShowWindowContents
{
    using LockShowWindowContents.Helpers;
    using System;

    /// <summary>
    /// The main class to set "Show window contents while dragging" console-style.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            ShowWindowContents.SetShowWindowContents();
        }
    }
}
