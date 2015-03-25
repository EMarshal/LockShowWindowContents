// <copyright file="NativeMethods.cs" company="Éli Marshal">
//     Copyright (c) Éli Marshal. All rights reserved.
// </copyright>

namespace LockShowWindowContents
{
    using System.Runtime.InteropServices;

    /// <summary>
    /// Contains native methods for SystemParametersInfo to use for SPI_SETDRAGFULLWINDOWS and SPI_GETDRAGFULLWINDOWS
    /// </summary>
    public static sealed class NativeMethods
    {
        /// <summary>
        /// Constant 0x01.
        /// </summary>
        internal const short SPIF_UPDATEINIFILE = 0x01;

        /// <summary>
        /// Constant 0x02.
        /// </summary>
        internal const short SPIF_SENDCHANGE = 0x02;

        /// <summary>
        /// Constant 0x25.
        /// </summary>
        internal const short SPI_SETDRAGFULLWINDOWS = 0x25;

        /// <summary>
        /// Constant 0x26.
        /// </summary>
        internal const short SPI_GETDRAGFULLWINDOWS = 0x26;

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool SystemParametersInfo(int uAction, int uParam, ref bool lpvParam, int fuWinIni);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern bool SystemParametersInfo(int uAction, bool uParam, string lpvParam, int fuWinIni);
    }
}
